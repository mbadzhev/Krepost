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
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripFile,
            this.menuStripEntry});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
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
            this.menuStripEntryAddEntry.Size = new System.Drawing.Size(180, 22);
            this.menuStripEntryAddEntry.Text = "Add Entry";
            this.menuStripEntryAddEntry.Click += new System.EventHandler(this.menuStripEntryAddEntry_Click);
            // 
            // menuStripEntryEditEntry
            // 
            this.menuStripEntryEditEntry.Name = "menuStripEntryEditEntry";
            this.menuStripEntryEditEntry.Size = new System.Drawing.Size(180, 22);
            this.menuStripEntryEditEntry.Text = "Edit Entry";
            this.menuStripEntryEditEntry.Click += new System.EventHandler(this.menuStripEntryEditEntry_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
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
    }
}