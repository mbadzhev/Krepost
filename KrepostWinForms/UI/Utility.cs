namespace KrepostWinForms.UI
{
    public static class Utility
    {
        public static bool SaveDatabase()
        {
            // Set dialog settings
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            sfd.FilterIndex = 2;
            sfd.RestoreDirectory = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                // Create db, use the picked path and serialize the db
                KrepostLib.DatabaseWriter.WriteDatabase(KrepostLib.DatabaseWriter.CreateDatabase(), Path.GetFullPath(sfd.FileName));
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool OpenDatabase()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            ofd.FilterIndex = 2;
            ofd.RestoreDirectory = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Initial deserialization of db
                Program.CurrentDb = KrepostLib.DatabaseReader.ReadDatabase(Path.GetFullPath(ofd.FileName));
                
                // Validate db header
                if (!KrepostLib.DatabaseReader.ValidateDatabaseHeader(Program.CurrentDb))
                {
                    return false;
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
