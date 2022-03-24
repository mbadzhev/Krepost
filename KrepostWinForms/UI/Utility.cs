﻿using KrepostLib.Storage;

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
        public static bool OpenDatabase()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            ofd.FilterIndex = 2;
            ofd.RestoreDirectory = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Deserialize db head
                DatabaseFile dbf = DatabaseReader.DeserializeDatabaseFile(Path.GetFullPath(ofd.FileName));
                DatabaseHead dbE = DatabaseReader.DeserializeDatabaseHead(dbf);
                Program.CurrentDbHead = dbE;

                // Validate db head
                if (!DatabaseReader.ValidateDatabaseHead(dbE))
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
