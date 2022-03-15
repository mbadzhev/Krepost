namespace KrepostWinForms.Forms
{
    public partial class NewDatabaseForm : Form
    {
        public byte[] salt { get; set; }
        public NewDatabaseForm()
        {
            InitializeComponent();

            // Generate and set salt to be used for hashing user input
            salt = KrepostLib.Cryptography.Generator.GenerateBytes(16);
            secureStringTextBoxTop.DataSalt = salt;
            secureStringTextBoxBottom.DataSalt = salt;
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            // TODO: Securely compare the master passwords.
            if (!KrepostLib.Utility.CompareStrings(secureStringTextBoxTop.DataHash, secureStringTextBoxBottom.DataHash))
            {
                MessageBox.Show("Passwords do not match or are empty.", "Krepost", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (UI.Utility.SaveDatabase(secureStringTextBoxTop.DataHash, secureStringTextBoxTop.DataSalt))
                {
                    Close();
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
