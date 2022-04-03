using KrepostLib.Security;
using KrepostLib.Storage;

namespace KrepostWinForms.Middleware
{
    internal class DatabaseUtils
    {
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
    }
}
