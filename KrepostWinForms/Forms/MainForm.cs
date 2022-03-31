using KrepostWinForms.UI;
namespace KrepostWinForms.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            toolStrip.Renderer = new CustomToolStripRenderer();
            //menuStripEntryAddEntry.Enabled = false;
        }

        #region menuStripFile Functions
        private void menuStripFileNew_Click(object sender, EventArgs e)
        {
            Form newDbForm = new NewDatabaseForm();
            newDbForm.ShowDialog();
        }

        private void menuStripFileOpen_Click(object sender, EventArgs e)
        {
            if (UI.Utility.OpenDatabaseFile())
            {
                Form openDbForm = new OpenDatabaseForm();
                openDbForm.ShowDialog();
            }
        }
        #endregion

        #region menuStripEntry Functions
        private void menuStripEntryAddEntry_Click(object sender, EventArgs e)
        {
            if (Program.CurrentDb == null)
            {
                MessageBox.Show("No open database is available.", "Krepost", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Form addEntryForm = new AddEntryForm();
            addEntryForm.ShowDialog();
        }

        private void menuStripEntryEditEntry_Click(object sender, EventArgs e)
        {
            if (!Program.OpenDatabase)
            {
                MessageBox.Show("A database has been opened.", "Krepost", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Form editEntryForm = new EditEntryForm();
            editEntryForm.Show();
        }
        #endregion
    }
}
