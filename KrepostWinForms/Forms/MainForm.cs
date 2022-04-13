using System.Diagnostics;

using KrepostWinForms.UI;

namespace KrepostWinForms.Forms
{
    public partial class MainForm : Form
    {
        private System.Windows.Forms.Timer copyTimer = new System.Windows.Forms.Timer();
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
            // Handle any unsaved changes.
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
            var formResult = newDbForm.ShowDialog();
            if (formResult == DialogResult.OK)
            {
                RefreshTreeView();
            }
        }
        private void menuStripFileOpen_Click(object sender, EventArgs e)
        {
            // Handle any unsaved changes.
            if (Program.SavedDatabase == false)
            {
                var result = ConfirmChanges();
                if (result == DialogResult.Yes)
                {
                    if (Program.CurrentDb != null && Program.CurrentKey != null && Program.DbFilePath != null)
                        Middleware.DatabaseUtils.SaveDatabase(Program.CurrentDb, Program.CurrentKey, Program.DbFilePath);
                    else
                    {
                        string str2 = "Something went wronge. No dabatase could be loaded.";
                        MessageBox.Show(str2, "Krepost", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
            }

            // Open database.
            if (Middleware.DatabaseUtils.OpenDatabase())
            {
                Form openDbForm = new OpenDatabaseForm();
                var formResult = openDbForm.ShowDialog();
                if (formResult == DialogResult.OK)
                {
                    RefreshTreeView();
                }
            }
        }
        private void menuStripFileSave_Click(object sender, EventArgs e)
        {
            if (Program.CurrentDb is not null && Program.CurrentKey is not null)
            {
                if (!Middleware.DatabaseUtils.SaveDatabase(Program.CurrentDb, Program.CurrentKey, Program.DbFilePath))
                {
                    MessageBox.Show("An error occured. The changes could not be saved.", "Krepost", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                return;
            }
            MessageBox.Show("A database has not been opened.", "Krepost", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void menuStripFileSaveAs_Click(object sender, EventArgs e)
        {
            if (Program.CurrentDb is not null && Program.CurrentKey is not null)
            {
                if (!Middleware.DatabaseUtils.SaveAsDatabase(Program.CurrentDb, Program.CurrentKey))
                {
                    MessageBox.Show("An error occured. The changes could not be saved.", "Krepost", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                return;
            }
            MessageBox.Show("A database has not been opened.", "Krepost", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void menuStripFileChangeMasterPass_Click(object sender, EventArgs e)
        {
            if (Program.CurrentDb is null)
            {
                string str = "No database is open. A database must be opened before its master password can be changed.";
                MessageBox.Show(str, "Krepost", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Handle any unsaved changes.
            if (Program.SavedDatabase == false)
            {
                var result = ConfirmChanges();
                if (result == DialogResult.Yes)
                {
                    if (Program.CurrentDb is not null && Program.CurrentKey is not null && Program.DbFilePath is not null)
                        Middleware.DatabaseUtils.SaveDatabase(Program.CurrentDb, Program.CurrentKey, Program.DbFilePath);
                    else
                    {
                        string str2 = "A loaded database was not found. No changes could be saved.";
                        MessageBox.Show(str2, "Krepost", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (result == DialogResult.Cancel)
                    return;
            }

            Form changeMasterPassForm = new ChangeMasterPasswordForm();
            var formResult = changeMasterPassForm.ShowDialog();
            if (formResult == DialogResult.OK)
                RefreshTreeView();
        }
        #endregion

        #region menuStripEntry Functions
        private void menuStripEntryAddEntry_Click(object sender, EventArgs e)
        {
            if (!Program.OpenDatabase || Program.CurrentDb is null)
            {
                MessageBox.Show("A database has not been opened.", "Krepost", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Form addEntryForm = new AddEntryForm();
            addEntryForm.ShowDialog();

            RefreshTreeView();
        }

        private void menuStripEntryEditEntry_Click(object sender, EventArgs e)
        {
            if (!Program.OpenDatabase || Program.CurrentDb is null)
            {
                MessageBox.Show("A database has been opened.", "Krepost", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (Program.SelectedEntry is null)
                return;

            Form editEntryForm = new EditEntryForm(Program.SelectedEntry);
            editEntryForm.ShowDialog();

            RefreshTreeView();

            panelEntryTop.Visible = false;
            panelEntryBottom.Visible = false;
        }

        private void menuStripEntryDeleteEntry_Click(object sender, EventArgs e)
        {
            if (!Program.OpenDatabase || Program.CurrentDb is null)
            {
                MessageBox.Show("A database has not been opened.",
                    "Krepost", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (Program.SelectedEntry is null)
            {
                MessageBox.Show("An entry has to be selected before it can be deleted.",
                    "Krepost", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var result = MessageBox.Show("Are you sure you want to delete '" + Program.SelectedEntry.Title + "' entry? This action cannot be undone.",
                "Krepost", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                Middleware.DatabaseUtils.DeleteEntry(Program.CurrentDb, Program.SelectedEntry);

            RefreshTreeView();
        }

        private void menuStripEntryCopyUsername_Click(object sender, EventArgs e)
        {
            if (!Program.OpenDatabase || Program.CurrentDb is null)
            {
                MessageBox.Show("A database has not been opened.",
                    "Krepost", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (Program.SelectedEntry is null)
            {
                MessageBox.Show("An entry has to be selected before its username can be copied.",
                    "Krepost", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            copyTimer.Tick += new EventHandler(TimerEventProcessor);
            copyTimer.Interval = 10000;
            copyTimer.Start();
            Clipboard.SetText(Middleware.CryptographyUtils.GetString(Program.SelectedEntry.Username));
        }

        private void menuStripEntryCopyEmail_Click(object sender, EventArgs e)
        {
            if (!Program.OpenDatabase || Program.CurrentDb is null)
            {
                MessageBox.Show("A database has not been opened.",
                    "Krepost", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (Program.SelectedEntry is null)
            {
                MessageBox.Show("An entry has to be selected before its email can be copied.",
                    "Krepost", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            copyTimer.Tick += new EventHandler(TimerEventProcessor);
            copyTimer.Interval = 10000;
            copyTimer.Start();
            Clipboard.SetText(Middleware.CryptographyUtils.GetString(Program.SelectedEntry.Email));
        }

        private void menuStripEntryCopyPassword_Click(object sender, EventArgs e)
        {
            if (!Program.OpenDatabase || Program.CurrentDb is null)
            {
                MessageBox.Show("A database has not been opened.",
                    "Krepost", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (Program.SelectedEntry is null)
            {
                MessageBox.Show("An entry has to be selected before its password can be copied.",
                    "Krepost", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            copyTimer.Tick += new EventHandler(TimerEventProcessor);
            copyTimer.Interval = 10000;
            copyTimer.Start();
            Clipboard.SetText(Middleware.CryptographyUtils.GetString(Program.SelectedEntry.Password));
        }
        private void menuStripEntryOpenUrl_Click(object sender, EventArgs e)
        {
            if (!Program.OpenDatabase || Program.CurrentDb is null)
            {
                MessageBox.Show("A database has not been opened.",
                    "Krepost", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (Program.SelectedEntry is null)
            {
                MessageBox.Show("An entry has to be selected before its URL can be opened.",
                    "Krepost", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Open entry url.
            var psi = new ProcessStartInfo(textBoxUrl.Text)
            {
                UseShellExecute = true,
                Verb = "open"
            };

            try
            {
                Process.Start(psi);
            }
            catch (Exception)
            {
                MessageBox.Show("The URL could not be opened. Make sure it is a valid URL.",
                    "Krepost", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region toolStrip Functions
        private void toolStripNew_Click(object sender, EventArgs e)
        {
            menuStripFileNew_Click(sender, e);
        }

        private void toolStripOpen_Click(object sender, EventArgs e)
        {
            menuStripFileOpen_Click(sender, e);
        }

        private void toolStripSave_Click(object sender, EventArgs e)
        {
            menuStripFileSave_Click(sender, e);
        }

        private void toolStripAddEntry_Click(object sender, EventArgs e)
        {
            menuStripEntryAddEntry_Click(sender, e);
        }

        private void toolStripEditEntry_Click(object sender, EventArgs e)
        {
            menuStripEntryEditEntry_Click(sender, e);
        }

        private void toolStripDeleteEntry_Click(object sender, EventArgs e)
        {
            menuStripEntryDeleteEntry_Click(sender, e );
        }

        private void toolStripCopyUsername_Click(object sender, EventArgs e)
        {
            buttonUsername_Click(sender, e);
        }

        private void toolStripCopyEmail_Click(object sender, EventArgs e)
        {
            buttonEmail_Click(sender, e);
        }

        private void toolStripCopyPassword_Click(object sender, EventArgs e)
        {
            buttonPassword_Click(sender, e);
        }

        private void toolStripOpenUrl_Click(object sender, EventArgs e)
        {
            menuStripEntryOpenUrl_Click(sender, e);
        }
        #endregion

        #region splitContainerMain Functions

        private void treeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            RefreshEntryHeader(e.Node);
            RefreshEntryBody(e.Node);
            Middleware.DisplayUtils.ResetSelectedEntry();
        }
        #endregion

        #region SplitContainerEntry Functions

        private void buttonUsername_Click(object sender, EventArgs e)
        {
            menuStripEntryCopyUsername_Click(sender, e);
        }

        private void buttonEmail_Click(object sender, EventArgs e)
        {
            menuStripEntryCopyEmail_Click(sender, e);
        }

        private void buttonPassword_Click(object sender, EventArgs e)
        {
            menuStripEntryCopyPassword_Click(sender, e);
        }
        private void buttonUrl_Click(object sender, EventArgs e)
        {
            if (!Program.OpenDatabase || Program.CurrentDb is null)
            {
                MessageBox.Show("A database has not been opened.",
                    "Krepost", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (Program.SelectedEntry is null)
            {
                MessageBox.Show("An entry has to be selected before its URL can be copied.",
                    "Krepost", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            copyTimer.Tick += new EventHandler(TimerEventProcessor);
            copyTimer.Interval = 10000;
            copyTimer.Start();
            Clipboard.SetText(textBoxUrl.Text);
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
        private static void TimerEventProcessor(object sender, EventArgs e)
        {
            Clipboard.Clear();
        }
    }
}
