﻿using System.Reflection;

using KrepostLib.Cryptography;
using KrepostLib.Security;
using KrepostLib.Storage;

using KrepostWinForms.UI;

namespace KrepostWinForms.Middleware
{
    internal class DatabaseUtils
    {
        /// <summary>
        /// Creates and saves a new database.
        /// </summary>
        /// <param name="masterHash">Hash of the master password.</param>
        /// <param name="key">Key used for encryption and decryption.</param>
        /// <param name="iv">Initialization vector used for encryption and decryption.</param>
        /// <returns>True, if the database was created, false if it was not.</returns>
        public static bool NewDatabase(string masterHash, SecureByteArray key, byte[] iv)
        {
            // Set dialog settings
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "New";
            sfd.InitialDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            sfd.FileName = "Untitled.dbf";
            sfd.Filter = "Krepost Database Files (*.dbf)|*.dbf| All Files (*.*)|*.*";
            sfd.FilterIndex = 1;
            sfd.DefaultExt = "dbf";
            sfd.AddExtension = true;
            //sfd.RestoreDirectory = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                // Create db, use the picked path and serialize the db
                Database db = DatabaseWriter.CreateDatabase(masterHash, iv);
                DatabaseWriter.SerializeDatabase(db, key, Path.GetFullPath(sfd.FileName));
                Program.CurrentDb = db;
                Program.DbFilePath = Path.GetFullPath(sfd.FileName);
                Program.OpenDatabase = true;

                return true;
            }
            else
                return false;
        }
        /// <summary>
        /// Opens and deserializes a <see cref="DatabaseFile"/>. No authentication is done on the file.
        /// </summary>
        /// <returns>True, if the file is successfully deserialized.
        /// False, if the <see cref="OpenFileDialog"/> returns <see cref="DialogResult.Cancel"/>.</returns>
        public static bool OpenDatabase()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open";
            ofd.Filter = "Krepost Database Files (*.dbf)|*.dbf| All Files (*.*)|*.*";
            ofd.FilterIndex = 1;
            //ofd.RestoreDirectory = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Deserialize database file
                DatabaseFile dbf = DatabaseReader.DeserializeDatabaseFile(Path.GetFullPath(ofd.FileName));
                
                // Save reference to db file to reduce deserializations
                Program.CurrentDbFile = dbf;
                Program.DbFilePath = Path.GetFullPath(ofd.FileName);
                return true;
            }
            else
                return false;
        }
        /// <summary>
        /// Sets a new key used for encryption and decryption, devired from user input.
        /// </summary>
        /// <param name="userInput">Master password used to access a database.</param>
        public static void SetNewKey(SecureStringTextBox userInput)
        {
            byte[] key = Argon2Engine.DeriveKey(userInput.ToSecureByteArray(), userInput.DataSalt);
            Program.CurrentKey = new SecureByteArray(ref key);
            Array.Clear(key, 0, key.Length);
        }
        /// <summary>
        /// Saves the database currently in use to the file it was loaded from.
        /// </summary>
        /// <param name="db">The database to be saved.</param>
        /// <param name="key">The key used for encryption and decryption.</param>
        /// <param name="path">The path to the save directory, including filename and expension (path = ...\dir\file.ext).</param>
        /// <returns>True only.</returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static bool SaveDatabase(Database db, SecureByteArray key, string path)
        {
            // Validate arguments
            if (db == null)
                throw new ArgumentNullException("db");
            if (key == null)
                throw new ArgumentNullException("key");
            if (path == null)
                throw new ArgumentNullException("path");
            if (path.Length <= 0)
                throw new ArgumentOutOfRangeException("path");

            // Serialize the database to the specified path (path = ...\dir\file.ext).
            DatabaseWriter.SerializeDatabase(db, key, path);
            Program.SavedDatabase = true;

            return true;
        }
        /// <summary>
        /// Saves the database currently in use to a new file.
        /// </summary>
        /// <param name="db">The database to be saved.</param>
        /// <param name="key">The key used for encryption and decryption.</param>
        /// <returns>True, if the operation was successful, false if the database could not be saved.</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static bool SaveAsDatabase(Database db, SecureByteArray key)
        {
            // Validate arguments
            if (db == null)
                throw new ArgumentNullException("db");
            if (key == null)
                throw new ArgumentNullException("key");

            //Set dialog settings
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Save As";
            sfd.FileName = "Untitled.dbf";
            sfd.Filter = "Krepost Database Files (*.dbf)|*.dbf| All Files (*.*)|*.*";
            sfd.FilterIndex = 1;
            sfd.DefaultExt = "dbf";
            sfd.AddExtension = true;
            sfd.RestoreDirectory = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                // Serialize the database to the path chosen through the dialog.
                DatabaseWriter.SerializeDatabase(db, key, Path.GetFullPath(sfd.FileName));
                Program.DbFilePath = Path.GetFullPath(sfd.FileName);
                Program.SavedDatabase = true;

                return true;
            }
            else
                return false;
        }
        public static DatabaseEntry? FindEntry(string uuid, Database db)
        {
            DatabaseEntry? entry = db.Body.EntryList.Find(x => x.Uid == uuid);
            if (entry == null)
                return null;
            return entry;
        }
        public static DatabaseEntry? FindEntry(TreeNode trn, Database db)
        {
            DatabaseEntry? entry = db.Body.EntryList.Find(x => x.Uid == (string)trn.Tag);
            if (entry == null)
                return null;
            return entry;
        }
        /// <summary>
        /// Checks if any <see cref="DatabaseFile"/> signitures are invalid.
        /// </summary>
        /// <param name="dbF">The <see cref="DatabaseFile"/> to be checked.</param>
        /// <param name="key"> The secret used to generate the authentication key.</param>
        /// <returns>True, if the signitures are valid. False, if at least one of the signitures is invalid.</returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static bool CheckDatabaseFileSignature(DatabaseFile dbF, SecureByteArray key)
        {
            // Validate arguments.
            if (dbF is null)
                throw new ArgumentNullException(nameof(dbF));
            if (key is null)
                throw new ArgumentNullException(nameof(key));
            if (key.Length <= 0)
                throw new ArgumentOutOfRangeException(nameof(key));

            if (DatabaseReader.AuthenticateDatabaseFile(dbF, key))
                return true;
            return false;
        }
    }
}
