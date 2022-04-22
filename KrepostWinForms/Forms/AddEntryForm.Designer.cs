using KrepostWinForms.UI;

namespace KrepostWinForms.Forms
{
    partial class AddEntryForm
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
            System.Security.SecureString secureString5 = new System.Security.SecureString();
            System.Security.SecureString secureString6 = new System.Security.SecureString();
            System.Security.SecureString secureString7 = new System.Security.SecureString();
            System.Security.SecureString secureString8 = new System.Security.SecureString();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUrl = new System.Windows.Forms.Label();
            this.labelNote = new System.Windows.Forms.Label();
            this.secureStringTextBoxPassword = new KrepostWinForms.UI.SecureStringTextBox();
            this.secureStringTextBoxEmail = new KrepostWinForms.UI.SecureStringTextBox();
            this.secureStringTextBoxUsername = new KrepostWinForms.UI.SecureStringTextBox();
            this.secureStringTextBoxNote = new KrepostWinForms.UI.SecureStringTextBox();
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelTop = new System.Windows.Forms.Label();
            this.labelDivider = new System.Windows.Forms.Label();
            this.buttonRevealNote = new System.Windows.Forms.Button();
            this.buttonRevealPassword = new System.Windows.Forms.Button();
            this.buttonRevealEmail = new System.Windows.Forms.Button();
            this.buttonRevealUsername = new System.Windows.Forms.Button();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxNote = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(12, 73);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(32, 15);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Title:";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(12, 102);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(63, 15);
            this.labelUsername.TabIndex = 1;
            this.labelUsername.Text = "Username:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(12, 131);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(39, 15);
            this.labelEmail.TabIndex = 2;
            this.labelEmail.Text = "Email:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(12, 160);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(60, 15);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Password:";
            // 
            // labelUrl
            // 
            this.labelUrl.AutoSize = true;
            this.labelUrl.Location = new System.Drawing.Point(12, 189);
            this.labelUrl.Name = "labelUrl";
            this.labelUrl.Size = new System.Drawing.Size(31, 15);
            this.labelUrl.TabIndex = 4;
            this.labelUrl.Text = "URL:";
            // 
            // labelNote
            // 
            this.labelNote.AutoSize = true;
            this.labelNote.Location = new System.Drawing.Point(12, 218);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(36, 15);
            this.labelNote.TabIndex = 5;
            this.labelNote.Text = "Note:";
            // 
            // secureStringTextBoxPassword
            // 
            this.secureStringTextBoxPassword.Data = secureString5;
            this.secureStringTextBoxPassword.DataHash = null;
            this.secureStringTextBoxPassword.DataSalt = null;
            this.secureStringTextBoxPassword.Location = new System.Drawing.Point(81, 156);
            this.secureStringTextBoxPassword.Name = "secureStringTextBoxPassword";
            this.secureStringTextBoxPassword.Size = new System.Drawing.Size(325, 23);
            this.secureStringTextBoxPassword.TabIndex = 3;
            // 
            // secureStringTextBoxEmail
            // 
            this.secureStringTextBoxEmail.Data = secureString6;
            this.secureStringTextBoxEmail.DataHash = null;
            this.secureStringTextBoxEmail.DataSalt = null;
            this.secureStringTextBoxEmail.Location = new System.Drawing.Point(81, 127);
            this.secureStringTextBoxEmail.Name = "secureStringTextBoxEmail";
            this.secureStringTextBoxEmail.Size = new System.Drawing.Size(325, 23);
            this.secureStringTextBoxEmail.TabIndex = 2;
            // 
            // secureStringTextBoxUsername
            // 
            this.secureStringTextBoxUsername.Data = secureString7;
            this.secureStringTextBoxUsername.DataHash = null;
            this.secureStringTextBoxUsername.DataSalt = null;
            this.secureStringTextBoxUsername.Location = new System.Drawing.Point(81, 98);
            this.secureStringTextBoxUsername.Name = "secureStringTextBoxUsername";
            this.secureStringTextBoxUsername.Size = new System.Drawing.Size(325, 23);
            this.secureStringTextBoxUsername.TabIndex = 1;
            // 
            // secureStringTextBoxNote
            // 
            this.secureStringTextBoxNote.Data = secureString8;
            this.secureStringTextBoxNote.DataHash = null;
            this.secureStringTextBoxNote.DataSalt = null;
            this.secureStringTextBoxNote.Location = new System.Drawing.Point(81, 214);
            this.secureStringTextBoxNote.Name = "secureStringTextBoxNote";
            this.secureStringTextBoxNote.Size = new System.Drawing.Size(325, 23);
            this.secureStringTextBoxNote.TabIndex = 5;
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Location = new System.Drawing.Point(81, 185);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(391, 23);
            this.textBoxUrl.TabIndex = 4;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(81, 69);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(391, 23);
            this.textBoxTitle.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(316, 278);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(397, 278);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelTop
            // 
            this.labelTop.AutoSize = true;
            this.labelTop.Location = new System.Drawing.Point(12, 12);
            this.labelTop.Margin = new System.Windows.Forms.Padding(3, 3, 3, 24);
            this.labelTop.MaximumSize = new System.Drawing.Size(460, 0);
            this.labelTop.Name = "labelTop";
            this.labelTop.Size = new System.Drawing.Size(458, 30);
            this.labelTop.TabIndex = 24;
            this.labelTop.Text = "Currently creating a database entry. Once \'Add\' is pressed, the database still ha" +
    "s to be saved for this change to take effect.";
            // 
            // labelDivider
            // 
            this.labelDivider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDivider.Location = new System.Drawing.Point(-13, 266);
            this.labelDivider.Margin = new System.Windows.Forms.Padding(3, 24, 3, 7);
            this.labelDivider.Name = "labelDivider";
            this.labelDivider.Size = new System.Drawing.Size(510, 2);
            this.labelDivider.TabIndex = 25;
            // 
            // buttonRevealNote
            // 
            this.buttonRevealNote.Location = new System.Drawing.Point(412, 214);
            this.buttonRevealNote.Name = "buttonRevealNote";
            this.buttonRevealNote.Size = new System.Drawing.Size(60, 23);
            this.buttonRevealNote.TabIndex = 29;
            this.buttonRevealNote.Text = "Reveal";
            this.buttonRevealNote.UseVisualStyleBackColor = true;
            this.buttonRevealNote.Click += new System.EventHandler(this.buttonRevealNote_Click);
            // 
            // buttonRevealPassword
            // 
            this.buttonRevealPassword.Location = new System.Drawing.Point(412, 156);
            this.buttonRevealPassword.Name = "buttonRevealPassword";
            this.buttonRevealPassword.Size = new System.Drawing.Size(60, 23);
            this.buttonRevealPassword.TabIndex = 28;
            this.buttonRevealPassword.Text = "Reveal";
            this.buttonRevealPassword.UseVisualStyleBackColor = true;
            this.buttonRevealPassword.Click += new System.EventHandler(this.buttonRevealPassword_Click);
            // 
            // buttonRevealEmail
            // 
            this.buttonRevealEmail.Location = new System.Drawing.Point(412, 127);
            this.buttonRevealEmail.Name = "buttonRevealEmail";
            this.buttonRevealEmail.Size = new System.Drawing.Size(60, 23);
            this.buttonRevealEmail.TabIndex = 27;
            this.buttonRevealEmail.Text = "Reveal";
            this.buttonRevealEmail.UseVisualStyleBackColor = true;
            this.buttonRevealEmail.Click += new System.EventHandler(this.buttonRevealEmail_Click);
            // 
            // buttonRevealUsername
            // 
            this.buttonRevealUsername.Location = new System.Drawing.Point(412, 98);
            this.buttonRevealUsername.Name = "buttonRevealUsername";
            this.buttonRevealUsername.Size = new System.Drawing.Size(60, 23);
            this.buttonRevealUsername.TabIndex = 26;
            this.buttonRevealUsername.Text = "Reveal";
            this.buttonRevealUsername.UseVisualStyleBackColor = true;
            this.buttonRevealUsername.Click += new System.EventHandler(this.buttonRevealUsername_Click);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(81, 98);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.ReadOnly = true;
            this.textBoxUsername.Size = new System.Drawing.Size(325, 23);
            this.textBoxUsername.TabIndex = 30;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(81, 127);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.ReadOnly = true;
            this.textBoxEmail.Size = new System.Drawing.Size(325, 23);
            this.textBoxEmail.TabIndex = 31;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(81, 156);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.ReadOnly = true;
            this.textBoxPassword.Size = new System.Drawing.Size(325, 23);
            this.textBoxPassword.TabIndex = 32;
            // 
            // textBoxNote
            // 
            this.textBoxNote.Location = new System.Drawing.Point(81, 214);
            this.textBoxNote.Name = "textBoxNote";
            this.textBoxNote.ReadOnly = true;
            this.textBoxNote.Size = new System.Drawing.Size(325, 23);
            this.textBoxNote.TabIndex = 33;
            // 
            // AddEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 313);
            this.Controls.Add(this.buttonRevealNote);
            this.Controls.Add(this.buttonRevealPassword);
            this.Controls.Add(this.buttonRevealEmail);
            this.Controls.Add(this.buttonRevealUsername);
            this.Controls.Add(this.labelDivider);
            this.Controls.Add(this.labelTop);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.textBoxUrl);
            this.Controls.Add(this.secureStringTextBoxNote);
            this.Controls.Add(this.secureStringTextBoxUsername);
            this.Controls.Add(this.secureStringTextBoxEmail);
            this.Controls.Add(this.secureStringTextBoxPassword);
            this.Controls.Add(this.labelNote);
            this.Controls.Add(this.labelUrl);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxNote);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEntryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Entry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelTitle;
        private Label labelUsername;
        private Label labelEmail;
        private Label labelPassword;
        private Label labelUrl;
        private Label labelNote;
        private SecureStringTextBox secureStringTextBoxPassword;
        private SecureStringTextBox secureStringTextBoxEmail;
        private SecureStringTextBox secureStringTextBoxUsername;
        private SecureStringTextBox secureStringTextBoxNote;
        private TextBox textBoxUrl;
        private TextBox textBoxTitle;
        private Button buttonAdd;
        private Button buttonCancel;
        private Label labelTop;
        private Label labelDivider;
        private Button buttonRevealNote;
        private Button buttonRevealPassword;
        private Button buttonRevealEmail;
        private Button buttonRevealUsername;
        private TextBox textBoxUsername;
        private TextBox textBoxEmail;
        private TextBox textBoxPassword;
        private TextBox textBoxNote;
    }
}