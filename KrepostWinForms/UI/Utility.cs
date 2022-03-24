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
                Program.CurrentDb = db;
                DatabaseWriter.SerializeDatabase(db, Program.CurrentKey, Path.GetFullPath(sfd.FileName));
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
                return true;
            }
            else
                return false;
        }
    }
}
