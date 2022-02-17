using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                UI.Utility.SaveDatabase();
                Close();
            }
        }
    }
}
