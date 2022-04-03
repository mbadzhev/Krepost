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
