using System.Diagnostics;

using KrepostLib.Security;

namespace KrepostWinForms.Forms
{
    public partial class OpenDatabaseForm : Form
    {
        public OpenDatabaseForm()
        {
            InitializeComponent();

            secureStringTextBox.DataSalt = Program.CurrentDbHead.BodyIv;
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            if (!KrepostLib.Utility.CompareStrings(Program.CurrentDbHead.AccessHash, secureStringTextBox.DataHash))
            {
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

                // TODO: Decrypt db

                secureStringTextBox.Data.Dispose();
                Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            secureStringTextBox.Data.Dispose();
            Close();
        }
    }
}
