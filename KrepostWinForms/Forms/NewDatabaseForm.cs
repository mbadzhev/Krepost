using KrepostWinForms.Middleware;

namespace KrepostWinForms.Forms
{
    public partial class NewDatabaseForm : Form
    {
        public byte[] salt { get; set; }
        public NewDatabaseForm()
        {
            InitializeComponent();

            // Generate salt for hashing user input.
            salt = CryptographyUtils.GenerateSalt(16);
            secureStringTextBoxTop.DataSalt = salt;
            secureStringTextBoxBottom.DataSalt = salt;
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Check that the user input matches accross the text boxes.
            if (!KrepostLib.Utility.CompareStrings(secureStringTextBoxTop.DataHash, secureStringTextBoxBottom.DataHash))
                MessageBox.Show("Passwords do not match or are empty.", "Krepost", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                // Generate encryption key from user input.
                DatabaseUtils.SetNewKey(secureStringTextBoxTop);

                // Check if key generation failed.
                if (Program.CurrentKey != null)
                {
                    // Create new database.
                    if (DatabaseUtils.NewDatabase(secureStringTextBoxTop.DataHash, Program.CurrentKey, secureStringTextBoxTop.DataSalt))
                        DialogResult = DialogResult.OK;
                    else
                        DialogResult=DialogResult.Abort;

                    // Dispose of user input.
                    secureStringTextBoxTop.Data.Dispose();
                    secureStringTextBoxBottom.Data.Dispose();
                    Close();
                }
                else
                {
                    MessageBox.Show("Entryption key was not created correctly. A new database has not been created.",
                        "Krepost", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DialogResult = DialogResult.Abort;
                    // Dispose of user input.
                    secureStringTextBoxTop.Data.Dispose();
                    secureStringTextBoxBottom.Data.Dispose();
                    Close();
                }
            }
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            secureStringTextBoxTop.Data.Dispose();
            secureStringTextBoxBottom.Data.Dispose();
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
