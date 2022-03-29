using KrepostLib.Security;
using KrepostLib.Storage;

using KrepostWinForms.UI;

namespace KrepostWinForms.Forms
{
    public partial class EditEntryForm : Form
    {
        DatabaseEntry entry;
        public EditEntryForm()
        {
            InitializeComponent();
        }
        public EditEntryForm(DatabaseEntry dbE)
        {
            if (dbE == null)
            {
                MessageBox.Show("No database entry is selected.");
                return;
            }
            entry = dbE;

            InitializeComponent();

            // Set the SecureStrings to use in the SecureStringTextBoxes.
            // Exposes the plaintext of the encrypted entry in memory!
            using (SecureStringUtil ssu = new SecureStringUtil(entry.Username.Expose()))
                secureStringTextBoxUsername.Data = ssu.ByteArrayToSecureString(entry.Username.Expose());
            using (SecureStringUtil ssu = new SecureStringUtil(entry.Email.Expose()))
                secureStringTextBoxEmail.Data = ssu.ByteArrayToSecureString(entry.Email.Expose());
            using (SecureStringUtil ssu = new SecureStringUtil(entry.Password.Expose()))
                secureStringTextBoxPassword.Data = ssu.ByteArrayToSecureString(entry.Password.Expose());
            using (SecureStringUtil ssu = new SecureStringUtil(entry.Note.Expose()))
                secureStringTextBoxNote.Data = ssu.ByteArrayToSecureString(entry.Note.Expose());

            textBoxTitle.Text = dbE.Title;
            secureStringTextBoxUsername.DisplayCharacterNumberOnly(dbE.Username.Length);
            secureStringTextBoxEmail.DisplayCharacterNumberOnly(dbE.Email.Length);
            secureStringTextBoxPassword.DisplayCharacterNumberOnly(dbE.Password.Length);
            textBoxUrl.Text = dbE.Url;
            secureStringTextBoxNote.DisplayCharacterNumberOnly(dbE.Note.Length);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (Program.CurrentDb == null)
            {
                MessageBox.Show("No open database is available.", "Krepost", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check the required entry fields (title, email/username & password)
            // are filled and not empty.
            if (!ValidateInput())
            {
                return;
            }

            // Create new database entry with data from the input boxes.
            DatabaseEntry entry = new DatabaseEntry(textBoxTitle.Text,
                secureStringTextBoxUsername.ToSecureByteArray(),
                secureStringTextBoxEmail.ToSecureByteArray(),
                secureStringTextBoxPassword.ToSecureByteArray(),
                textBoxUrl.Text,
                secureStringTextBoxNote.ToSecureByteArray(),
                KrepostLib.Cryptography.Generator.GenerateBytes(16));

            Program.CurrentDb.Body.EntryList.Add(entry);
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            secureStringTextBoxUsername.Data.Dispose();
            secureStringTextBoxEmail.Data.Dispose();
            secureStringTextBoxPassword.Data.Dispose();
            secureStringTextBoxNote.Data.Dispose();
            Close();
        }
        private bool ValidateInput()
        {
            if (textBoxTitle.Text == null || textBoxTitle.Text.Length <= 0)
            {
                MessageBox.Show("No title set for entry. An entry must contain a title.", "Krepost", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if ((secureStringTextBoxUsername.Data == null ||
                secureStringTextBoxUsername.Data.Length <= 0) &&
                (secureStringTextBoxEmail.Data == null ||
                secureStringTextBoxEmail.Data.Length <= 0))
            {
                MessageBox.Show("No username or email set for entry. An entry must contain at least one.", "Krepost", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (secureStringTextBoxPassword.Data == null || secureStringTextBoxPassword.Data.Length <= 0)
            {
                MessageBox.Show("No username set for entry. An entry must contain a title.", "Krepost", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void buttonRevealUsername_Click(object sender, EventArgs e)
        {
            ButtonRevealClick(buttonRevealUsername, textBoxUsername, secureStringTextBoxUsername);
        }

        private void buttonRevealEmail_Click(object sender, EventArgs e)
        {
            ButtonRevealClick(buttonRevealEmail, textBoxEmail, secureStringTextBoxEmail);
        }

        private void buttonRevealPassword_Click(object sender, EventArgs e)
        {
            ButtonRevealClick(buttonRevealPassword, textBoxPassword, secureStringTextBoxPassword);
        }

        private void buttonRevealNote_Click(object sender, EventArgs e)
        {
            ButtonRevealClick(buttonRevealNote, textBoxNote, secureStringTextBoxNote);
        }
        private void ButtonRevealClick(Button btn, TextBox tbx, SecureStringTextBox sstbx)
        {
            if (btn.Text == "Reveal")
            {
                tbx.Text = sstbx.Expose();
                tbx.Visible = true;
                sstbx.Visible = false;
                btn.Text = "Hide";
            }
            else if (btn.Text == "Hide")
            {
                sstbx.Visible = true;
                tbx.Visible = false;
                btn.Text = "Reveal";
            }
        }
    }
}
