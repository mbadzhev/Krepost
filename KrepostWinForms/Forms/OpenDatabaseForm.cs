using KrepostLib.Security;

using KrepostWinForms.UI;

namespace KrepostWinForms.Forms
{
    public partial class OpenDatabaseForm : Form
    {
        public OpenDatabaseForm()
        {
            InitializeComponent();

            // Extract db head from db file to access hashed master password
            if (!Utility.AccessDatabaseHead(Program.CurrentDbFile))
            {
                MessageBox.Show("The database did not pass validation." +
                    "Data stored in it may be corrupted or compromised.");
                return;
            }

            // Use the saved iv for hashing and key derivation
            secureStringTextBox.DataSalt = Program.CurrentDbHead.BodyIv;
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            if (!KrepostLib.Utility.CompareStrings(Program.CurrentDbHead.AccessHash, secureStringTextBox.DataHash))
            {
                DialogResult = DialogResult.Abort;
                MessageBox.Show("Password is incorrect.", "Krepost", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Compute and save the key used in encrypting the database body
                using (SecureStringUtil wrapper = new SecureStringUtil(secureStringTextBox.Data))
                {
                    byte[] temp = wrapper.SecureStringToByteArray();
                    byte[] key = KrepostLib.Cryptography.Argon2Engine.DeriveKey(temp, Program.CurrentDbHead.BodyIv);
                    Array.Clear(temp, 0, temp.Length);
                    Program.CurrentKey = new SecureByteArray(ref key);
                    Array.Clear(key, 0, key.Length);
                }

                // Decrypt and deserialize the last component needed for a complete database
                if (!Utility.AccessDatabaseBody(Program.CurrentDbFile, Program.CurrentDbHead, Program.CurrentKey))
                {
                    DialogResult = DialogResult.Abort;
                    MessageBox.Show("Something went wrong while opening encrypted database content.", "Krepost", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Marks that a database is opened
                    Program.OpenDatabase = true;
                    DialogResult = DialogResult.OK;
                }

                secureStringTextBox.Data.Dispose();
                Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            secureStringTextBox.Data.Dispose();
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
