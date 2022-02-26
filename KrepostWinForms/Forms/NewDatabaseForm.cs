namespace KrepostWinForms.Forms
{
    public partial class NewDatabaseForm : Form
    {
        public NewDatabaseForm()
        {
            InitializeComponent();
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            // TODO: Securely compare the master passwords.
            if (KrepostLib.Utility.CompareStrings(textBoxPassword.Text, textBoxPasswordRepeat.Text))
            {
                textBoxPasswordRepeat.BackColor = Color.White;
            }
            else
            {
                textBoxPasswordRepeat.BackColor = Color.Red;
            }
        }

        private void textBoxPasswordRepeat_TextChanged(object sender, EventArgs e)
        {
            // TODO: Securely compare the master passwords.
            if (KrepostLib.Utility.CompareStrings(textBoxPassword.Text, textBoxPasswordRepeat.Text))
            {
                textBoxPasswordRepeat.BackColor = Color.White;
            }
            else
            {
                textBoxPasswordRepeat.BackColor = Color.Red;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // TODO: Securely compare the master passwords.
            if (!KrepostLib.Utility.CompareStrings(textBoxPassword.Text, textBoxPasswordRepeat.Text))
            {
                MessageBox.Show("Passwords do not match or are empty.", "Krepost", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (UI.Utility.SaveDatabase(textBoxPassword.Text))
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
