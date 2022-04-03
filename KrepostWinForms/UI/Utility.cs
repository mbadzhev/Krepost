using KrepostLib.Security;
using KrepostLib.Storage;

namespace KrepostWinForms.UI
{
    public static class Utility
    {
        public static bool SaveDatabase(string masterHash, byte[] iv)
        {
            // TODO: Securely pass master password
            // Set dialog settings
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            sfd.FilterIndex = 2;
            sfd.RestoreDirectory = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                // Create db, use the picked path and serialize the db
                Database db = DatabaseWriter.CreateDatabase(masterHash, iv);
                DatabaseWriter.SerializeDatabase(db, Program.CurrentKey, Path.GetFullPath(sfd.FileName));
                Program.CurrentDb = db;
                Program.OpenDatabase = true;
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool OpenDatabaseFile()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Krepost Database Files (*.dbf)|*.dbf| All Files (*.*)|*.*";
            ofd.FilterIndex = 1;
            ofd.RestoreDirectory = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Deserialize and validate database file
                DatabaseFile dbf = DatabaseReader.DeserializeDatabaseFile(Path.GetFullPath(ofd.FileName));
                if (!dbf.ValidateHead())
                    return false;
                if (!dbf.ValidateBody())
                    return false;

                // Save reference to db file to reduce deserializations
                Program.CurrentDbFile = dbf;
                Program.DbFilePath = Path.GetFullPath(ofd.FileName);
                return true;
            }
            else
                return false;
        }
        public static bool AccessDatabaseHead(DatabaseFile dbF)
        {
            if (dbF == null)
                throw new ArgumentNullException("dbF");

            DatabaseHead dbH = DatabaseReader.DeserializeDatabaseHead(dbF);

            if (!DatabaseReader.ValidateDatabaseHead(dbH))
                return false;

            Program.CurrentDbHead = dbH;
            return true;
        }
        /// <summary>
        /// Deserializes and decrypts a <see cref="DatabaseBody"/>
        /// from a <see cref="DatabaseFile"/>, initializing a
        /// <see cref="Database"/> to be used as global variable.
        /// </summary>
        /// <param name="dbF">Database file to read the encrypted body from.</param>
        /// <param name="dbH">Database head to read the random bytes used during encryption</param>
        /// <param name="key">Key used during encryption.</param>
        /// <returns>Boolean confirming successful execution.</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static bool AccessDatabaseBody(DatabaseFile dbF, DatabaseHead dbH, SecureByteArray key)
        {
            if (dbF == null)
                throw new ArgumentNullException("dbF");

            DatabaseBody dbB = DatabaseReader.DeserializeDatabaseBody(dbF, dbH, key);

            Program.CurrentDb = new Database(dbH, dbB);
            return true;
        }
    }
}
