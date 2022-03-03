using System.Diagnostics;
namespace KrepostWinForms.Forms
{
    public partial class OpenDatabaseForm : Form
    {
        public OpenDatabaseForm()
        {
            InitializeComponent();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            // Check for empty textbox

            if (Program.CurrentDb.Head.accessHash == KrepostLib.Cryptography.Sha256Engine.ComputeSha256Hash(textBoxPassword.Text))
            {
                // TODO: Extremely insecure!!! Add secure layer over this reference

                // Compute and save the key used in encrypting the database body
                Program.CurrentKey = KrepostLib.Cryptography.Argon2Engine.DeriveKey(textBoxPassword.Text, Program.CurrentDb.Head.databaseIv);
               
                // TODO: Decrypt db

                Close();
            }
            else if (textBoxPassword.Text == "")
            {
                MessageBox.Show("Password is empty", "Krepost", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Password is incorrect", "Krepost", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
