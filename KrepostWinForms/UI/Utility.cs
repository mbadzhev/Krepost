namespace KrepostWinForms.UI
{
    public static class Utility
    {
        public static void SaveDatabase()
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
            }
        }
    }
}
