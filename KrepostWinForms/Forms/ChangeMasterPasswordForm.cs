using KrepostWinForms.Middleware;

namespace KrepostWinForms.Forms
{
    public partial class ChangeMasterPasswordForm : Form
    {
        public byte[] Salt { get; set; }
        public ChangeMasterPasswordForm()
        {
            InitializeComponent();

            // Use the same iv for hashing and key derivation
            Salt = Program.CurrentDbHead.BodyIv;
            secureStringTextBoxTop.DataSalt = Salt;
            secureStringTextBoxBottom.DataSalt = Salt;
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to change the master password used to access this database?",
                "Krepost", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.No)
            {
                // Dispose of user input.
                secureStringTextBoxTop.Data.Dispose();
                secureStringTextBoxBottom.Data.Dispose();
                secureStringTextBoxTop.Dispose();
                secureStringTextBoxBottom.Dispose();
                Close();
                return;
            }

            // Check that the user input matches accross the text boxes.
            if (!KrepostLib.Utility.CompareStrings(secureStringTextBoxTop.DataHash, secureStringTextBoxBottom.DataHash))
                MessageBox.Show("Passwords do not match or are empty.", "Krepost", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                // Generate encryption key from user input.
                DatabaseUtils.SetNewKey(secureStringTextBoxTop);

                // Check if key generation failed.
                if (Program.CurrentKey is not null)
                {
                    // Create new database.
                    if (DatabaseUtils.ChangeMasterPassword(Program.CurrentDb,secureStringTextBoxTop.DataHash, Program.CurrentKey, Salt))
                        DialogResult = DialogResult.OK;
                    else
                        DialogResult = DialogResult.Abort;

                    // Dispose of user input.
                    secureStringTextBoxTop.Data.Dispose();
                    secureStringTextBoxBottom.Data.Dispose();
                    secureStringTextBoxTop.Dispose();
                    secureStringTextBoxBottom.Dispose();
                    Close();
                }
                else
                {
                    MessageBox.Show("Entryption key was not created correctly. A new database has not been created.",
                        "Krepost", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DialogResult = DialogResult.Abort;
                    Close();
                }
            }
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            secureStringTextBoxTop.Data.Dispose();
            secureStringTextBoxTop.Dispose();
            secureStringTextBoxBottom.Data.Dispose();
            secureStringTextBoxBottom.Dispose();
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
