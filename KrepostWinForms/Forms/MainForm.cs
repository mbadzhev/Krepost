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

        #region MainForm Functions
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Program.SavedDatabase == false)
            {
                var result = ConfirmChanges();
                if (result == DialogResult.Yes)
                {
                    if (Program.CurrentDb != null && Program.CurrentKey != null && Program.DbFilePath != null)
                        Middleware.DatabaseUtils.SaveDatabase(Program.CurrentDb, Program.CurrentKey, Program.DbFilePath);
                    else
                    {
                        string str2 = "A loaded database was not found. No changes could be saved.";
                        MessageBox.Show(str2, "Krepost", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (result == DialogResult.No)
                {
                    // Discard all changes.
                }
                else if (result == DialogResult.Cancel)
                {
                    // Cancel the closure of the form.
                    e.Cancel = true;
                }
            }
        }
        #endregion

        #region menuStripFile Functions
        private void menuStripFileNew_Click(object sender, EventArgs e)
        {
            if (Program.SavedDatabase == false)
            {
                var result = ConfirmChanges();
                if (result == DialogResult.Yes)
                {
                    if (Program.CurrentDb != null && Program.CurrentKey != null && Program.DbFilePath != null)
                        Middleware.DatabaseUtils.SaveDatabase(Program.CurrentDb, Program.CurrentKey, Program.DbFilePath);
                    else
                    {
                        string str2 = "A loaded database was not found. No changes could be saved.";
                        MessageBox.Show(str2, "Krepost", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
            }

            Form newDbForm = new NewDatabaseForm();
            newDbForm.ShowDialog();
        }
        private void menuStripFileOpen_Click(object sender, EventArgs e)
        {
            if (Program.SavedDatabase == false)
            {
                var result = ConfirmChanges();
                if (result == DialogResult.Yes)
                {
                    if (Program.CurrentDb != null && Program.CurrentKey != null && Program.DbFilePath != null)
                        Middleware.DatabaseUtils.SaveDatabase(Program.CurrentDb, Program.CurrentKey, Program.DbFilePath);
                    else
                    {
                        string str2 = "A loaded database was not found. No changes could be saved.";
                        MessageBox.Show(str2, "Krepost", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
            }

            if (Utility.OpenDatabaseFile())
            {
                Form openDbForm = new OpenDatabaseForm();
                openDbForm.ShowDialog();
            }
        }
        private void menuStripFileSave_Click(object sender, EventArgs e)
        {
            Middleware.DatabaseUtils.SaveDatabase(Program.CurrentDb, Program.CurrentKey, Program.DbFilePath);
        }
        private void menuStripFileSaveAs_Click(object sender, EventArgs e)
        {
            if (Program.CurrentDb != null && Program.CurrentKey != null)
            {
                if (!Middleware.DatabaseUtils.SaveAsDatabase(Program.CurrentDb, Program.CurrentKey))
                    return;
                return;
            }
            MessageBox.Show("A database has not been opened.", "Krepost", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        #endregion

        #region menuStripEntry Functions
        private void menuStripEntryAddEntry_Click(object sender, EventArgs e)
        {
            if (!Program.OpenDatabase || Program.CurrentDb == null)
            {
                MessageBox.Show("A database has not been opened.", "Krepost", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private DialogResult ConfirmChanges()
        {
            string message = "There are unsaved database changes. Should these changes be saved?";
            var result = MessageBox.Show(message, "Krepost", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                return DialogResult.Yes;
            else if (result == DialogResult.No)
                return DialogResult.No;
            else
                return DialogResult.Cancel;
        }
    }
}
