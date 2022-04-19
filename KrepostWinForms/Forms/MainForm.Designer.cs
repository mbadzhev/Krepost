namespace KrepostWinForms.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuStripFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStripFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStripFileChangeMasterPass = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripEntry = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripEntryAddEntry = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripEntryEditEntry = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripEntryDeleteEntry = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStripEntryCopyUsername = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripEntryCopyEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripEntryCopyPassword = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripEntryOpenUrl = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripAddEntry = new System.Windows.Forms.ToolStripButton();
            this.toolStripEditEntry = new System.Windows.Forms.ToolStripButton();
            this.toolStripDeleteEntry = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripCopyUsername = new System.Windows.Forms.ToolStripButton();
            this.toolStripCopyEmail = new System.Windows.Forms.ToolStripButton();
            this.toolStripCopyPassword = new System.Windows.Forms.ToolStripButton();
            this.toolStripOpenUrl = new System.Windows.Forms.ToolStripButton();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.treeView = new System.Windows.Forms.TreeView();
            this.splitContainerEntry = new System.Windows.Forms.SplitContainer();
            this.panelEntryTop = new System.Windows.Forms.Panel();
            this.labelEntryDoM = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.labelEntryDoC = new System.Windows.Forms.Label();
            this.labelEntryTitle = new System.Windows.Forms.Label();
            this.panelEntryBottom = new System.Windows.Forms.Panel();
            this.buttonNote = new System.Windows.Forms.Button();
            this.buttonUrl = new System.Windows.Forms.Button();
            this.buttonPassword = new System.Windows.Forms.Button();
            this.buttonEmail = new System.Windows.Forms.Button();
            this.buttonUsername = new System.Windows.Forms.Button();
            this.textBoxNote = new System.Windows.Forms.TextBox();
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelNote = new System.Windows.Forms.Label();
            this.labelUrl = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxNoteReveal = new System.Windows.Forms.TextBox();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerEntry)).BeginInit();
            this.splitContainerEntry.Panel1.SuspendLayout();
            this.splitContainerEntry.Panel2.SuspendLayout();
            this.splitContainerEntry.SuspendLayout();
            this.panelEntryTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panelEntryBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripFile,
            this.menuStripEntry});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(584, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // menuStripFile
            // 
            this.menuStripFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripFileNew,
            this.menuStripFileOpen,
            this.toolStripSeparator1,
            this.menuStripFileSave,
            this.menuStripFileSaveAs,
            this.toolStripSeparator2,
            this.menuStripFileChangeMasterPass});
            this.menuStripFile.Name = "menuStripFile";
            this.menuStripFile.Size = new System.Drawing.Size(37, 20);
            this.menuStripFile.Text = "File";
            // 
            // menuStripFileNew
            // 
            this.menuStripFileNew.Image = global::KrepostWinForms.Properties.Resources.NewDocument;
            this.menuStripFileNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuStripFileNew.Name = "menuStripFileNew";
            this.menuStripFileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuStripFileNew.Size = new System.Drawing.Size(207, 22);
            this.menuStripFileNew.Text = "New";
            this.menuStripFileNew.Click += new System.EventHandler(this.menuStripFileNew_Click);
            // 
            // menuStripFileOpen
            // 
            this.menuStripFileOpen.Image = global::KrepostWinForms.Properties.Resources.OpenFolder;
            this.menuStripFileOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuStripFileOpen.Name = "menuStripFileOpen";
            this.menuStripFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menuStripFileOpen.Size = new System.Drawing.Size(207, 22);
            this.menuStripFileOpen.Text = "Open";
            this.menuStripFileOpen.Click += new System.EventHandler(this.menuStripFileOpen_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(204, 6);
            // 
            // menuStripFileSave
            // 
            this.menuStripFileSave.Image = global::KrepostWinForms.Properties.Resources.Save;
            this.menuStripFileSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuStripFileSave.Name = "menuStripFileSave";
            this.menuStripFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuStripFileSave.Size = new System.Drawing.Size(207, 22);
            this.menuStripFileSave.Text = "Save";
            this.menuStripFileSave.Click += new System.EventHandler(this.menuStripFileSave_Click);
            // 
            // menuStripFileSaveAs
            // 
            this.menuStripFileSaveAs.Image = global::KrepostWinForms.Properties.Resources.SaveAs;
            this.menuStripFileSaveAs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuStripFileSaveAs.Name = "menuStripFileSaveAs";
            this.menuStripFileSaveAs.Size = new System.Drawing.Size(207, 22);
            this.menuStripFileSaveAs.Text = "Save As";
            this.menuStripFileSaveAs.Click += new System.EventHandler(this.menuStripFileSaveAs_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(204, 6);
            // 
            // menuStripFileChangeMasterPass
            // 
            this.menuStripFileChangeMasterPass.Image = global::KrepostWinForms.Properties.Resources.NewKey;
            this.menuStripFileChangeMasterPass.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuStripFileChangeMasterPass.Name = "menuStripFileChangeMasterPass";
            this.menuStripFileChangeMasterPass.Size = new System.Drawing.Size(207, 22);
            this.menuStripFileChangeMasterPass.Text = "Change Master Password";
            this.menuStripFileChangeMasterPass.Click += new System.EventHandler(this.menuStripFileChangeMasterPass_Click);
            // 
            // menuStripEntry
            // 
            this.menuStripEntry.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripEntryAddEntry,
            this.menuStripEntryEditEntry,
            this.menuStripEntryDeleteEntry,
            this.toolStripSeparator3,
            this.menuStripEntryCopyUsername,
            this.menuStripEntryCopyEmail,
            this.menuStripEntryCopyPassword,
            this.menuStripEntryOpenUrl});
            this.menuStripEntry.Name = "menuStripEntry";
            this.menuStripEntry.Size = new System.Drawing.Size(46, 20);
            this.menuStripEntry.Text = "Entry";
            // 
            // menuStripEntryAddEntry
            // 
            this.menuStripEntryAddEntry.Image = global::KrepostWinForms.Properties.Resources.Add;
            this.menuStripEntryAddEntry.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuStripEntryAddEntry.Name = "menuStripEntryAddEntry";
            this.menuStripEntryAddEntry.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.menuStripEntryAddEntry.Size = new System.Drawing.Size(232, 22);
            this.menuStripEntryAddEntry.Text = "Add Entry";
            this.menuStripEntryAddEntry.Click += new System.EventHandler(this.menuStripEntryAddEntry_Click);
            // 
            // menuStripEntryEditEntry
            // 
            this.menuStripEntryEditEntry.Image = global::KrepostWinForms.Properties.Resources.Edit;
            this.menuStripEntryEditEntry.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuStripEntryEditEntry.Name = "menuStripEntryEditEntry";
            this.menuStripEntryEditEntry.Size = new System.Drawing.Size(232, 22);
            this.menuStripEntryEditEntry.Text = "Edit Entry";
            this.menuStripEntryEditEntry.Click += new System.EventHandler(this.menuStripEntryEditEntry_Click);
            // 
            // menuStripEntryDeleteEntry
            // 
            this.menuStripEntryDeleteEntry.Image = global::KrepostWinForms.Properties.Resources.Remove;
            this.menuStripEntryDeleteEntry.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuStripEntryDeleteEntry.Name = "menuStripEntryDeleteEntry";
            this.menuStripEntryDeleteEntry.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.menuStripEntryDeleteEntry.Size = new System.Drawing.Size(232, 22);
            this.menuStripEntryDeleteEntry.Text = "Delete Entry";
            this.menuStripEntryDeleteEntry.Click += new System.EventHandler(this.menuStripEntryDeleteEntry_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(229, 6);
            // 
            // menuStripEntryCopyUsername
            // 
            this.menuStripEntryCopyUsername.Image = global::KrepostWinForms.Properties.Resources.User;
            this.menuStripEntryCopyUsername.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuStripEntryCopyUsername.Name = "menuStripEntryCopyUsername";
            this.menuStripEntryCopyUsername.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.menuStripEntryCopyUsername.Size = new System.Drawing.Size(232, 22);
            this.menuStripEntryCopyUsername.Text = "Copy Username";
            this.menuStripEntryCopyUsername.Click += new System.EventHandler(this.menuStripEntryCopyUsername_Click);
            // 
            // menuStripEntryCopyEmail
            // 
            this.menuStripEntryCopyEmail.Image = global::KrepostWinForms.Properties.Resources.EmailAddressViewer;
            this.menuStripEntryCopyEmail.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuStripEntryCopyEmail.Name = "menuStripEntryCopyEmail";
            this.menuStripEntryCopyEmail.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.C)));
            this.menuStripEntryCopyEmail.Size = new System.Drawing.Size(232, 22);
            this.menuStripEntryCopyEmail.Text = "Copy Email";
            this.menuStripEntryCopyEmail.Click += new System.EventHandler(this.menuStripEntryCopyEmail_Click);
            // 
            // menuStripEntryCopyPassword
            // 
            this.menuStripEntryCopyPassword.Image = global::KrepostWinForms.Properties.Resources.PasswordBox;
            this.menuStripEntryCopyPassword.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuStripEntryCopyPassword.Name = "menuStripEntryCopyPassword";
            this.menuStripEntryCopyPassword.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.menuStripEntryCopyPassword.Size = new System.Drawing.Size(232, 22);
            this.menuStripEntryCopyPassword.Text = "Copy Password";
            this.menuStripEntryCopyPassword.Click += new System.EventHandler(this.menuStripEntryCopyPassword_Click);
            // 
            // menuStripEntryOpenUrl
            // 
            this.menuStripEntryOpenUrl.Image = global::KrepostWinForms.Properties.Resources.OpenWebSite;
            this.menuStripEntryOpenUrl.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuStripEntryOpenUrl.Name = "menuStripEntryOpenUrl";
            this.menuStripEntryOpenUrl.Size = new System.Drawing.Size(232, 22);
            this.menuStripEntryOpenUrl.Text = "Open URL in Browser";
            this.menuStripEntryOpenUrl.Click += new System.EventHandler(this.menuStripEntryOpenUrl_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 539);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip.Size = new System.Drawing.Size(584, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip";
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripNew,
            this.toolStripOpen,
            this.toolStripSave,
            this.toolStripSeparator,
            this.toolStripAddEntry,
            this.toolStripEditEntry,
            this.toolStripDeleteEntry,
            this.toolStripSeparator4,
            this.toolStripCopyUsername,
            this.toolStripCopyEmail,
            this.toolStripCopyPassword,
            this.toolStripOpenUrl});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(584, 25);
            this.toolStrip.TabIndex = 2;
            this.toolStrip.Text = "toolStrip";
            // 
            // toolStripNew
            // 
            this.toolStripNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripNew.Image = global::KrepostWinForms.Properties.Resources.NewDocument;
            this.toolStripNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripNew.Name = "toolStripNew";
            this.toolStripNew.Size = new System.Drawing.Size(23, 22);
            this.toolStripNew.Text = "New Database (Ctrl+N)";
            this.toolStripNew.Click += new System.EventHandler(this.toolStripNew_Click);
            // 
            // toolStripOpen
            // 
            this.toolStripOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripOpen.Image = global::KrepostWinForms.Properties.Resources.OpenFolder;
            this.toolStripOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripOpen.Name = "toolStripOpen";
            this.toolStripOpen.Size = new System.Drawing.Size(23, 22);
            this.toolStripOpen.Text = "Open Database (Ctrl+O)";
            this.toolStripOpen.Click += new System.EventHandler(this.toolStripOpen_Click);
            // 
            // toolStripSave
            // 
            this.toolStripSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSave.Image = global::KrepostWinForms.Properties.Resources.Save;
            this.toolStripSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSave.Name = "toolStripSave";
            this.toolStripSave.Size = new System.Drawing.Size(23, 22);
            this.toolStripSave.Text = "Save (Ctrl+S)";
            this.toolStripSave.Click += new System.EventHandler(this.toolStripSave_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripAddEntry
            // 
            this.toolStripAddEntry.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripAddEntry.Image = global::KrepostWinForms.Properties.Resources.Add;
            this.toolStripAddEntry.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripAddEntry.Name = "toolStripAddEntry";
            this.toolStripAddEntry.Size = new System.Drawing.Size(23, 22);
            this.toolStripAddEntry.Text = "Add Entry (Ctrl+I)";
            this.toolStripAddEntry.Click += new System.EventHandler(this.toolStripAddEntry_Click);
            // 
            // toolStripEditEntry
            // 
            this.toolStripEditEntry.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripEditEntry.Image = global::KrepostWinForms.Properties.Resources.Edit;
            this.toolStripEditEntry.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripEditEntry.Name = "toolStripEditEntry";
            this.toolStripEditEntry.Size = new System.Drawing.Size(23, 22);
            this.toolStripEditEntry.Text = "Edit Entry";
            this.toolStripEditEntry.Click += new System.EventHandler(this.toolStripEditEntry_Click);
            // 
            // toolStripDeleteEntry
            // 
            this.toolStripDeleteEntry.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDeleteEntry.Image = global::KrepostWinForms.Properties.Resources.Remove;
            this.toolStripDeleteEntry.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDeleteEntry.Name = "toolStripDeleteEntry";
            this.toolStripDeleteEntry.Size = new System.Drawing.Size(23, 22);
            this.toolStripDeleteEntry.Text = "Delete Entry (Del)";
            this.toolStripDeleteEntry.Click += new System.EventHandler(this.toolStripDeleteEntry_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripCopyUsername
            // 
            this.toolStripCopyUsername.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripCopyUsername.Image = global::KrepostWinForms.Properties.Resources.User;
            this.toolStripCopyUsername.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripCopyUsername.Name = "toolStripCopyUsername";
            this.toolStripCopyUsername.Size = new System.Drawing.Size(23, 22);
            this.toolStripCopyUsername.Text = "Copy Username (Ctrl+Shift+C)";
            this.toolStripCopyUsername.Click += new System.EventHandler(this.toolStripCopyUsername_Click);
            // 
            // toolStripCopyEmail
            // 
            this.toolStripCopyEmail.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripCopyEmail.Image = global::KrepostWinForms.Properties.Resources.EmailAddressViewer;
            this.toolStripCopyEmail.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripCopyEmail.Name = "toolStripCopyEmail";
            this.toolStripCopyEmail.Size = new System.Drawing.Size(23, 22);
            this.toolStripCopyEmail.Text = "Copy Email (Ctrl+Alt+C)";
            this.toolStripCopyEmail.Click += new System.EventHandler(this.toolStripCopyEmail_Click);
            // 
            // toolStripCopyPassword
            // 
            this.toolStripCopyPassword.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripCopyPassword.Image = global::KrepostWinForms.Properties.Resources.PasswordBox;
            this.toolStripCopyPassword.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripCopyPassword.Name = "toolStripCopyPassword";
            this.toolStripCopyPassword.Size = new System.Drawing.Size(23, 22);
            this.toolStripCopyPassword.Text = "Copy Password (Ctrl+C)";
            this.toolStripCopyPassword.Click += new System.EventHandler(this.toolStripCopyPassword_Click);
            // 
            // toolStripOpenUrl
            // 
            this.toolStripOpenUrl.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripOpenUrl.Image = global::KrepostWinForms.Properties.Resources.OpenWebSite;
            this.toolStripOpenUrl.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripOpenUrl.Name = "toolStripOpenUrl";
            this.toolStripOpenUrl.Size = new System.Drawing.Size(23, 22);
            this.toolStripOpenUrl.Text = "Open URL";
            this.toolStripOpenUrl.Click += new System.EventHandler(this.toolStripOpenUrl_Click);
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainerMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 49);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.BackColor = System.Drawing.SystemColors.Window;
            this.splitContainerMain.Panel1.Controls.Add(this.treeView);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.splitContainerEntry);
            this.splitContainerMain.Size = new System.Drawing.Size(584, 490);
            this.splitContainerMain.SplitterDistance = 120;
            this.splitContainerMain.SplitterWidth = 3;
            this.splitContainerMain.TabIndex = 3;
            // 
            // treeView
            // 
            this.treeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.Location = new System.Drawing.Point(0, 0);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(118, 488);
            this.treeView.TabIndex = 0;
            this.treeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_NodeMouseClick);
            // 
            // splitContainerEntry
            // 
            this.splitContainerEntry.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainerEntry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerEntry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerEntry.Location = new System.Drawing.Point(0, 0);
            this.splitContainerEntry.Name = "splitContainerEntry";
            this.splitContainerEntry.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerEntry.Panel1
            // 
            this.splitContainerEntry.Panel1.BackColor = System.Drawing.SystemColors.Window;
            this.splitContainerEntry.Panel1.Controls.Add(this.panelEntryTop);
            // 
            // splitContainerEntry.Panel2
            // 
            this.splitContainerEntry.Panel2.BackColor = System.Drawing.SystemColors.Window;
            this.splitContainerEntry.Panel2.Controls.Add(this.panelEntryBottom);
            this.splitContainerEntry.Size = new System.Drawing.Size(461, 490);
            this.splitContainerEntry.SplitterDistance = 120;
            this.splitContainerEntry.SplitterWidth = 3;
            this.splitContainerEntry.TabIndex = 0;
            // 
            // panelEntryTop
            // 
            this.panelEntryTop.Controls.Add(this.labelEntryDoM);
            this.panelEntryTop.Controls.Add(this.pictureBox);
            this.panelEntryTop.Controls.Add(this.labelEntryDoC);
            this.panelEntryTop.Controls.Add(this.labelEntryTitle);
            this.panelEntryTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEntryTop.Location = new System.Drawing.Point(0, 0);
            this.panelEntryTop.Name = "panelEntryTop";
            this.panelEntryTop.Size = new System.Drawing.Size(459, 118);
            this.panelEntryTop.TabIndex = 4;
            // 
            // labelEntryDoM
            // 
            this.labelEntryDoM.AutoSize = true;
            this.labelEntryDoM.Location = new System.Drawing.Point(281, 81);
            this.labelEntryDoM.Name = "labelEntryDoM";
            this.labelEntryDoM.Size = new System.Drawing.Size(167, 15);
            this.labelEntryDoM.TabIndex = 3;
            this.labelEntryDoM.Text = "Modified: 01/01/0001, 01:01:01";
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Image = global::KrepostWinForms.Properties.Resources.Image_Placeholder;
            this.pictureBox.Location = new System.Drawing.Point(24, 24);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(128, 72);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // labelEntryDoC
            // 
            this.labelEntryDoC.AutoSize = true;
            this.labelEntryDoC.Location = new System.Drawing.Point(281, 24);
            this.labelEntryDoC.Name = "labelEntryDoC";
            this.labelEntryDoC.Size = new System.Drawing.Size(160, 15);
            this.labelEntryDoC.TabIndex = 2;
            this.labelEntryDoC.Text = "Created: 01/01/0001, 01:01:01";
            // 
            // labelEntryTitle
            // 
            this.labelEntryTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelEntryTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEntryTitle.Location = new System.Drawing.Point(0, 0);
            this.labelEntryTitle.Name = "labelEntryTitle";
            this.labelEntryTitle.Size = new System.Drawing.Size(459, 118);
            this.labelEntryTitle.TabIndex = 1;
            this.labelEntryTitle.Text = "Title";
            this.labelEntryTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelEntryBottom
            // 
            this.panelEntryBottom.Controls.Add(this.buttonNote);
            this.panelEntryBottom.Controls.Add(this.buttonUrl);
            this.panelEntryBottom.Controls.Add(this.buttonPassword);
            this.panelEntryBottom.Controls.Add(this.buttonEmail);
            this.panelEntryBottom.Controls.Add(this.buttonUsername);
            this.panelEntryBottom.Controls.Add(this.textBoxNote);
            this.panelEntryBottom.Controls.Add(this.textBoxUrl);
            this.panelEntryBottom.Controls.Add(this.textBoxPassword);
            this.panelEntryBottom.Controls.Add(this.textBoxEmail);
            this.panelEntryBottom.Controls.Add(this.textBoxUsername);
            this.panelEntryBottom.Controls.Add(this.labelNote);
            this.panelEntryBottom.Controls.Add(this.labelUrl);
            this.panelEntryBottom.Controls.Add(this.labelPassword);
            this.panelEntryBottom.Controls.Add(this.labelEmail);
            this.panelEntryBottom.Controls.Add(this.labelUsername);
            this.panelEntryBottom.Controls.Add(this.textBoxNoteReveal);
            this.panelEntryBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEntryBottom.Location = new System.Drawing.Point(0, 0);
            this.panelEntryBottom.Name = "panelEntryBottom";
            this.panelEntryBottom.Size = new System.Drawing.Size(459, 365);
            this.panelEntryBottom.TabIndex = 0;
            // 
            // buttonNote
            // 
            this.buttonNote.Location = new System.Drawing.Point(371, 232);
            this.buttonNote.Name = "buttonNote";
            this.buttonNote.Size = new System.Drawing.Size(60, 23);
            this.buttonNote.TabIndex = 14;
            this.buttonNote.Text = "Reveal";
            this.buttonNote.UseVisualStyleBackColor = true;
            this.buttonNote.Click += new System.EventHandler(this.buttonNote_Click);
            // 
            // buttonUrl
            // 
            this.buttonUrl.Location = new System.Drawing.Point(371, 189);
            this.buttonUrl.Name = "buttonUrl";
            this.buttonUrl.Size = new System.Drawing.Size(60, 23);
            this.buttonUrl.TabIndex = 13;
            this.buttonUrl.Text = "Copy";
            this.buttonUrl.UseVisualStyleBackColor = true;
            this.buttonUrl.Click += new System.EventHandler(this.buttonUrl_Click);
            // 
            // buttonPassword
            // 
            this.buttonPassword.Location = new System.Drawing.Point(371, 146);
            this.buttonPassword.Name = "buttonPassword";
            this.buttonPassword.Size = new System.Drawing.Size(60, 23);
            this.buttonPassword.TabIndex = 12;
            this.buttonPassword.Text = "Copy";
            this.buttonPassword.UseVisualStyleBackColor = true;
            this.buttonPassword.Click += new System.EventHandler(this.buttonPassword_Click);
            // 
            // buttonEmail
            // 
            this.buttonEmail.Location = new System.Drawing.Point(371, 102);
            this.buttonEmail.Name = "buttonEmail";
            this.buttonEmail.Size = new System.Drawing.Size(60, 23);
            this.buttonEmail.TabIndex = 11;
            this.buttonEmail.Text = "Copy";
            this.buttonEmail.UseVisualStyleBackColor = true;
            this.buttonEmail.Click += new System.EventHandler(this.buttonEmail_Click);
            // 
            // buttonUsername
            // 
            this.buttonUsername.Location = new System.Drawing.Point(371, 60);
            this.buttonUsername.Name = "buttonUsername";
            this.buttonUsername.Size = new System.Drawing.Size(60, 23);
            this.buttonUsername.TabIndex = 10;
            this.buttonUsername.Text = "Copy";
            this.buttonUsername.UseVisualStyleBackColor = true;
            this.buttonUsername.Click += new System.EventHandler(this.buttonUsername_Click);
            // 
            // textBoxNote
            // 
            this.textBoxNote.Location = new System.Drawing.Point(100, 232);
            this.textBoxNote.Margin = new System.Windows.Forms.Padding(10);
            this.textBoxNote.Multiline = true;
            this.textBoxNote.Name = "textBoxNote";
            this.textBoxNote.PasswordChar = '●';
            this.textBoxNote.ReadOnly = true;
            this.textBoxNote.Size = new System.Drawing.Size(265, 75);
            this.textBoxNote.TabIndex = 9;
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Location = new System.Drawing.Point(100, 189);
            this.textBoxUrl.Margin = new System.Windows.Forms.Padding(10);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.ReadOnly = true;
            this.textBoxUrl.Size = new System.Drawing.Size(265, 23);
            this.textBoxUrl.TabIndex = 8;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(100, 146);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(10);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '●';
            this.textBoxPassword.ReadOnly = true;
            this.textBoxPassword.Size = new System.Drawing.Size(265, 23);
            this.textBoxPassword.TabIndex = 7;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(100, 103);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(10, 10, 3, 10);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.PasswordChar = '●';
            this.textBoxEmail.ReadOnly = true;
            this.textBoxEmail.Size = new System.Drawing.Size(265, 23);
            this.textBoxEmail.TabIndex = 6;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(100, 60);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(10);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.PasswordChar = '●';
            this.textBoxUsername.ReadOnly = true;
            this.textBoxUsername.Size = new System.Drawing.Size(265, 23);
            this.textBoxUsername.TabIndex = 5;
            // 
            // labelNote
            // 
            this.labelNote.AutoSize = true;
            this.labelNote.Location = new System.Drawing.Point(27, 235);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(36, 15);
            this.labelNote.TabIndex = 4;
            this.labelNote.Text = "Note:";
            // 
            // labelUrl
            // 
            this.labelUrl.AutoSize = true;
            this.labelUrl.Location = new System.Drawing.Point(27, 192);
            this.labelUrl.Name = "labelUrl";
            this.labelUrl.Size = new System.Drawing.Size(31, 15);
            this.labelUrl.TabIndex = 3;
            this.labelUrl.Text = "URL:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(27, 149);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(60, 15);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Password:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(27, 106);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(39, 15);
            this.labelEmail.TabIndex = 1;
            this.labelEmail.Text = "Email:";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(27, 63);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(63, 15);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "Username:";
            // 
            // textBoxNoteReveal
            // 
            this.textBoxNoteReveal.Location = new System.Drawing.Point(100, 232);
            this.textBoxNoteReveal.Margin = new System.Windows.Forms.Padding(10);
            this.textBoxNoteReveal.Multiline = true;
            this.textBoxNoteReveal.Name = "textBoxNoteReveal";
            this.textBoxNoteReveal.ReadOnly = true;
            this.textBoxNoteReveal.Size = new System.Drawing.Size(265, 75);
            this.textBoxNoteReveal.TabIndex = 15;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.splitContainerMain);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Krepost";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.splitContainerEntry.Panel1.ResumeLayout(false);
            this.splitContainerEntry.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerEntry)).EndInit();
            this.splitContainerEntry.ResumeLayout(false);
            this.panelEntryTop.ResumeLayout(false);
            this.panelEntryTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panelEntryBottom.ResumeLayout(false);
            this.panelEntryBottom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem menuStripFile;
        private ToolStripMenuItem menuStripFileNew;
        private ToolStripMenuItem menuStripFileOpen;
        private ToolStripMenuItem menuStripEntry;
        private ToolStripMenuItem menuStripEntryAddEntry;
        private ToolStripMenuItem menuStripEntryEditEntry;
        private StatusStrip statusStrip;
        private ToolStrip toolStrip;
        private SplitContainer splitContainerMain;
        private SplitContainer splitContainerEntry;
        private TreeView treeView;
        private Label labelEntryTitle;
        private PictureBox pictureBox;
        private Label labelEntryDoC;
        private Label labelEntryDoM;
        private Panel panelEntryBottom;
        private Panel panelEntryTop;
        private Label labelNote;
        private Label labelUrl;
        private Label labelPassword;
        private Label labelEmail;
        private Label labelUsername;
        private TextBox textBoxNote;
        private TextBox textBoxUrl;
        private TextBox textBoxPassword;
        private TextBox textBoxEmail;
        private TextBox textBoxUsername;
        private Button buttonUsername;
        private Button buttonEmail;
        private Button buttonNote;
        private Button buttonUrl;
        private Button buttonPassword;
        private ToolStripMenuItem menuStripFileSave;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem menuStripFileSaveAs;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem menuStripEntryDeleteEntry;
        private ToolStripButton toolStripNew;
        private ToolStripButton toolStripOpen;
        private ToolStripButton toolStripSave;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripButton toolStripAddEntry;
        private ToolStripButton toolStripEditEntry;
        private ToolStripButton toolStripDeleteEntry;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton toolStripCopyUsername;
        private ToolStripButton toolStripCopyEmail;
        private ToolStripButton toolStripCopyPassword;
        private ToolStripButton toolStripOpenUrl;
        private ToolStripMenuItem menuStripFileChangeMasterPass;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem menuStripEntryCopyUsername;
        private ToolStripMenuItem menuStripEntryCopyEmail;
        private ToolStripMenuItem menuStripEntryCopyPassword;
        private ToolStripMenuItem menuStripEntryOpenUrl;
        private TextBox textBoxNoteReveal;
    }
}