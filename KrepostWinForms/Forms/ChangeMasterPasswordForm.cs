namespace KrepostWinForms.Forms
{
    public partial class ChangeMasterPasswordForm : Form
    {
        public ChangeMasterPasswordForm()
        {
            InitializeComponent();
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
