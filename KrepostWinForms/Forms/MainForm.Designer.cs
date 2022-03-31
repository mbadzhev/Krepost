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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.splitContainerEntry = new System.Windows.Forms.SplitContainer();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerEntry)).BeginInit();
            this.splitContainerEntry.SuspendLayout();
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
            this.menuStrip.Size = new System.Drawing.Size(684, 24);
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
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 439);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(684, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip
            // 
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(684, 25);
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
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.splitContainerEntry);
            this.splitContainerMain.Size = new System.Drawing.Size(684, 390);
            this.splitContainerMain.SplitterDistance = 200;
            this.splitContainerMain.SplitterWidth = 3;
            this.splitContainerMain.TabIndex = 3;
            // 
            // splitContainerEntry
            // 
            this.splitContainerEntry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerEntry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerEntry.Location = new System.Drawing.Point(0, 0);
            this.splitContainerEntry.Name = "splitContainerEntry";
            this.splitContainerEntry.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.splitContainerEntry.Size = new System.Drawing.Size(481, 390);
            this.splitContainerEntry.SplitterDistance = 100;
            this.splitContainerEntry.SplitterWidth = 3;
            this.splitContainerEntry.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.splitContainerMain);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerEntry)).EndInit();
            this.splitContainerEntry.ResumeLayout(false);
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
        private StatusStrip statusStrip1;
        private ToolStrip toolStrip;
        private SplitContainer splitContainerMain;
        private SplitContainer splitContainerEntry;
    }
}