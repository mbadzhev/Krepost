using KrepostLib.Storage;

namespace KrepostWinForms.Forms
{
    public partial class AddEntryForm : Form
    {
        public AddEntryForm()
        {
            InitializeComponent();
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

            // Generate uuid for the entry.
            Guid uuid = Guid.NewGuid();
            string uuidStr = uuid.ToString();

            // Create new database entry with data from the input boxes.
            DatabaseEntry entry = new DatabaseEntry(textBoxTitle.Text,
                secureStringTextBoxUsername.ToSecureByteArray(),
                secureStringTextBoxEmail.ToSecureByteArray(),
                secureStringTextBoxPassword.ToSecureByteArray(),
                textBoxUrl.Text,
                secureStringTextBoxNote.ToSecureByteArray(), uuidStr,
                KrepostLib.Cryptography.Generator.GenerateBytes(16));

            Program.CurrentDb.Body.EntryList.Add(entry);

            secureStringTextBoxUsername.Data.Dispose();
            secureStringTextBoxEmail.Data.Dispose();
            secureStringTextBoxPassword.Data.Dispose();
            secureStringTextBoxNote.Data.Dispose();
            Close();
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
    }
}
