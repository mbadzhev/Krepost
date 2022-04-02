using KrepostWinForms.UI;

namespace KrepostWinForms.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            toolStrip.Renderer = new CustomToolStripRenderer();
            panelEntryTop.Visible = false;
            panelEntryBottom.Visible = false;
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
        private void menuStripFileSave_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region menuStripEntry Functions
        private void menuStripEntryAddEntry_Click(object sender, EventArgs e)
        {
            if (!Program.OpenDatabase || Program.CurrentDb == null)
            {
                MessageBox.Show("A database has been opened.", "Krepost", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Form addEntryForm = new AddEntryForm();
            addEntryForm.ShowDialog();

            RefreshTreeView();
        }

        private void menuStripEntryEditEntry_Click(object sender, EventArgs e)
        {
            if (!Program.OpenDatabase || Program.CurrentDb == null)
            {
                MessageBox.Show("A database has been opened.", "Krepost", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Program.SelectedEntry == null)
            {
                return;
            }
            Form editEntryForm = new EditEntryForm(Program.SelectedEntry);
            editEntryForm.ShowDialog();

            RefreshTreeView();

            panelEntryTop.Visible = false;
            panelEntryBottom.Visible = false;
        }
        #endregion

        #region splitContainer Functions

        private void treeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            RefreshEntryHeader(e.Node);
            RefreshEntryBody(e.Node);
            Middleware.DisplayUtils.ResetSelectedEntry();
        }
        #endregion
        public void RefreshTreeView()
        {
            Middleware.DisplayUtils.DisplayEntryList(treeView, Program.CurrentDb);
            treeView.Sort();
        }
        public void RefreshEntryHeader(TreeNode node)
        {
            if (!Middleware.DisplayUtils.DisplayEntryHeader(node, Program.CurrentDb, labelEntryTitle, labelEntryDoC, labelEntryDoM))
            {
                return;
            }
            panelEntryTop.Visible = true;
            panelEntryBottom.Visible = true;
        }
        private void RefreshEntryBody(TreeNode node)
        {
            Middleware.DisplayUtils.DisplayEntryBody(node, Program.CurrentDb, textBoxUsername, textBoxEmail, textBoxPassword, textBoxUrl, textBoxNote);
        }
    }
}
