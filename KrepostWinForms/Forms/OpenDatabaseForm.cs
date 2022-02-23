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
    public partial class OpenDatabaseForm : Form
    {
        public OpenDatabaseForm()
        {
            InitializeComponent();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            // Check for empty textbox
            if (textBoxPassword.Text == "")
                MessageBox.Show("Password is empty", "Krepost", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (Program.CurrentDb.Items.accessHash == KrepostLib.Cryptography.Sha256Engine.ComputeSha256Hash(textBoxPassword.Text))
            {
                // TODO: Decrypt db
            }
            else
            {
                MessageBox.Show("Password is incorrect", "Krepost", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
