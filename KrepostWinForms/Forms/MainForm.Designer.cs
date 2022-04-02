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
            this.menuStripEntry = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripEntryAddEntry = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripEntryEditEntry = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
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
            this.menuStrip.SuspendLayout();
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
            this.menuStripFileOpen});
            this.menuStripFile.Name = "menuStripFile";
            this.menuStripFile.Size = new System.Drawing.Size(37, 20);
            this.menuStripFile.Text = "File";
            // 
            // menuStripFileNew
            // 
            this.menuStripFileNew.Name = "menuStripFileNew";
            this.menuStripFileNew.Size = new System.Drawing.Size(103, 22);
            this.menuStripFileNew.Text = "New";
            this.menuStripFileNew.Click += new System.EventHandler(this.menuStripFileNew_Click);
            // 
            // menuStripFileOpen
            // 
            this.menuStripFileOpen.Name = "menuStripFileOpen";
            this.menuStripFileOpen.Size = new System.Drawing.Size(103, 22);
            this.menuStripFileOpen.Text = "Open";
            this.menuStripFileOpen.Click += new System.EventHandler(this.menuStripFileOpen_Click);
            // 
            // menuStripEntry
            // 
            this.menuStripEntry.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripEntryAddEntry,
            this.menuStripEntryEditEntry});
            this.menuStripEntry.Name = "menuStripEntry";
            this.menuStripEntry.Size = new System.Drawing.Size(46, 20);
            this.menuStripEntry.Text = "Entry";
            // 
            // menuStripEntryAddEntry
            // 
            this.menuStripEntryAddEntry.Name = "menuStripEntryAddEntry";
            this.menuStripEntryAddEntry.Size = new System.Drawing.Size(126, 22);
            this.menuStripEntryAddEntry.Text = "Add Entry";
            this.menuStripEntryAddEntry.Click += new System.EventHandler(this.menuStripEntryAddEntry_Click);
            // 
            // menuStripEntryEditEntry
            // 
            this.menuStripEntryEditEntry.Name = "menuStripEntryEditEntry";
            this.menuStripEntryEditEntry.Size = new System.Drawing.Size(126, 22);
            this.menuStripEntryEditEntry.Text = "Edit Entry";
            this.menuStripEntryEditEntry.Click += new System.EventHandler(this.menuStripEntryEditEntry_Click);
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
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(584, 25);
            this.toolStrip.TabIndex = 2;
            this.toolStrip.Text = "toolStrip";
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
            // 
            // buttonUrl
            // 
            this.buttonUrl.Location = new System.Drawing.Point(371, 189);
            this.buttonUrl.Name = "buttonUrl";
            this.buttonUrl.Size = new System.Drawing.Size(60, 23);
            this.buttonUrl.TabIndex = 13;
            this.buttonUrl.Text = "Reveal";
            this.buttonUrl.UseVisualStyleBackColor = true;
            // 
            // buttonPassword
            // 
            this.buttonPassword.Location = new System.Drawing.Point(371, 146);
            this.buttonPassword.Name = "buttonPassword";
            this.buttonPassword.Size = new System.Drawing.Size(60, 23);
            this.buttonPassword.TabIndex = 12;
            this.buttonPassword.Text = "Reveal";
            this.buttonPassword.UseVisualStyleBackColor = true;
            // 
            // buttonEmail
            // 
            this.buttonEmail.Location = new System.Drawing.Point(371, 102);
            this.buttonEmail.Name = "buttonEmail";
            this.buttonEmail.Size = new System.Drawing.Size(60, 23);
            this.buttonEmail.TabIndex = 11;
            this.buttonEmail.Text = "Reveal";
            this.buttonEmail.UseVisualStyleBackColor = true;
            // 
            // buttonUsername
            // 
            this.buttonUsername.Location = new System.Drawing.Point(371, 60);
            this.buttonUsername.Name = "buttonUsername";
            this.buttonUsername.Size = new System.Drawing.Size(60, 23);
            this.buttonUsername.TabIndex = 10;
            this.buttonUsername.Text = "Reveal";
            this.buttonUsername.UseVisualStyleBackColor = true;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.splitContainerMain);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
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
    }
}