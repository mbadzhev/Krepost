using KrepostWinForms.UI;

namespace KrepostWinForms.Forms
{
    partial class EditEntryForm
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
            System.Security.SecureString secureString1 = new System.Security.SecureString();
            System.Security.SecureString secureString2 = new System.Security.SecureString();
            System.Security.SecureString secureString3 = new System.Security.SecureString();
            System.Security.SecureString secureString4 = new System.Security.SecureString();
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
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonRevealUsername = new System.Windows.Forms.Button();
            this.buttonRevealEmail = new System.Windows.Forms.Button();
            this.buttonRevealPassword = new System.Windows.Forms.Button();
            this.buttonRevealNote = new System.Windows.Forms.Button();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxNote = new System.Windows.Forms.TextBox();
            this.labelTop = new System.Windows.Forms.Label();
            this.labelDivider = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(12, 103);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(32, 15);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Title:";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(12, 132);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(63, 15);
            this.labelUsername.TabIndex = 1;
            this.labelUsername.Text = "Username:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(12, 161);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(39, 15);
            this.labelEmail.TabIndex = 2;
            this.labelEmail.Text = "Email:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(12, 190);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(60, 15);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Password:";
            // 
            // labelUrl
            // 
            this.labelUrl.AutoSize = true;
            this.labelUrl.Location = new System.Drawing.Point(12, 219);
            this.labelUrl.Name = "labelUrl";
            this.labelUrl.Size = new System.Drawing.Size(31, 15);
            this.labelUrl.TabIndex = 4;
            this.labelUrl.Text = "URL:";
            // 
            // labelNote
            // 
            this.labelNote.AutoSize = true;
            this.labelNote.Location = new System.Drawing.Point(12, 249);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(36, 15);
            this.labelNote.TabIndex = 5;
            this.labelNote.Text = "Note:";
            // 
            // secureStringTextBoxPassword
            // 
            this.secureStringTextBoxPassword.Data = secureString1;
            this.secureStringTextBoxPassword.DataHash = null;
            this.secureStringTextBoxPassword.DataSalt = null;
            this.secureStringTextBoxPassword.Location = new System.Drawing.Point(81, 186);
            this.secureStringTextBoxPassword.Name = "secureStringTextBoxPassword";
            this.secureStringTextBoxPassword.Size = new System.Drawing.Size(325, 23);
            this.secureStringTextBoxPassword.TabIndex = 6;
            // 
            // secureStringTextBoxEmail
            // 
            this.secureStringTextBoxEmail.Data = secureString2;
            this.secureStringTextBoxEmail.DataHash = null;
            this.secureStringTextBoxEmail.DataSalt = null;
            this.secureStringTextBoxEmail.Location = new System.Drawing.Point(81, 157);
            this.secureStringTextBoxEmail.Name = "secureStringTextBoxEmail";
            this.secureStringTextBoxEmail.Size = new System.Drawing.Size(325, 23);
            this.secureStringTextBoxEmail.TabIndex = 7;
            // 
            // secureStringTextBoxUsername
            // 
            this.secureStringTextBoxUsername.Data = secureString3;
            this.secureStringTextBoxUsername.DataHash = null;
            this.secureStringTextBoxUsername.DataSalt = null;
            this.secureStringTextBoxUsername.Location = new System.Drawing.Point(81, 128);
            this.secureStringTextBoxUsername.Name = "secureStringTextBoxUsername";
            this.secureStringTextBoxUsername.Size = new System.Drawing.Size(325, 23);
            this.secureStringTextBoxUsername.TabIndex = 8;
            // 
            // secureStringTextBoxNote
            // 
            this.secureStringTextBoxNote.Data = secureString4;
            this.secureStringTextBoxNote.DataHash = null;
            this.secureStringTextBoxNote.DataSalt = null;
            this.secureStringTextBoxNote.Location = new System.Drawing.Point(81, 245);
            this.secureStringTextBoxNote.Name = "secureStringTextBoxNote";
            this.secureStringTextBoxNote.Size = new System.Drawing.Size(325, 23);
            this.secureStringTextBoxNote.TabIndex = 10;
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Location = new System.Drawing.Point(81, 216);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(391, 23);
            this.textBoxUrl.TabIndex = 11;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(81, 99);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(391, 23);
            this.textBoxTitle.TabIndex = 12;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(316, 309);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 14;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(397, 309);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonRevealUsername
            // 
            this.buttonRevealUsername.Location = new System.Drawing.Point(412, 128);
            this.buttonRevealUsername.Name = "buttonRevealUsername";
            this.buttonRevealUsername.Size = new System.Drawing.Size(60, 23);
            this.buttonRevealUsername.TabIndex = 15;
            this.buttonRevealUsername.Text = "Reveal";
            this.buttonRevealUsername.UseVisualStyleBackColor = true;
            this.buttonRevealUsername.Click += new System.EventHandler(this.buttonRevealUsername_Click);
            // 
            // buttonRevealEmail
            // 
            this.buttonRevealEmail.Location = new System.Drawing.Point(412, 157);
            this.buttonRevealEmail.Name = "buttonRevealEmail";
            this.buttonRevealEmail.Size = new System.Drawing.Size(60, 23);
            this.buttonRevealEmail.TabIndex = 16;
            this.buttonRevealEmail.Text = "Reveal";
            this.buttonRevealEmail.UseVisualStyleBackColor = true;
            this.buttonRevealEmail.Click += new System.EventHandler(this.buttonRevealEmail_Click);
            // 
            // buttonRevealPassword
            // 
            this.buttonRevealPassword.Location = new System.Drawing.Point(412, 186);
            this.buttonRevealPassword.Name = "buttonRevealPassword";
            this.buttonRevealPassword.Size = new System.Drawing.Size(60, 23);
            this.buttonRevealPassword.TabIndex = 17;
            this.buttonRevealPassword.Text = "Reveal";
            this.buttonRevealPassword.UseVisualStyleBackColor = true;
            this.buttonRevealPassword.Click += new System.EventHandler(this.buttonRevealPassword_Click);
            // 
            // buttonRevealNote
            // 
            this.buttonRevealNote.Location = new System.Drawing.Point(412, 245);
            this.buttonRevealNote.Name = "buttonRevealNote";
            this.buttonRevealNote.Size = new System.Drawing.Size(60, 23);
            this.buttonRevealNote.TabIndex = 18;
            this.buttonRevealNote.Text = "Reveal";
            this.buttonRevealNote.UseVisualStyleBackColor = true;
            this.buttonRevealNote.Click += new System.EventHandler(this.buttonRevealNote_Click);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(81, 128);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.ReadOnly = true;
            this.textBoxUsername.Size = new System.Drawing.Size(325, 23);
            this.textBoxUsername.TabIndex = 19;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(81, 157);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.ReadOnly = true;
            this.textBoxEmail.Size = new System.Drawing.Size(325, 23);
            this.textBoxEmail.TabIndex = 20;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(81, 186);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.ReadOnly = true;
            this.textBoxPassword.Size = new System.Drawing.Size(325, 23);
            this.textBoxPassword.TabIndex = 21;
            // 
            // textBoxNote
            // 
            this.textBoxNote.Location = new System.Drawing.Point(81, 245);
            this.textBoxNote.Name = "textBoxNote";
            this.textBoxNote.ReadOnly = true;
            this.textBoxNote.Size = new System.Drawing.Size(325, 23);
            this.textBoxNote.TabIndex = 22;
            // 
            // labelTop
            // 
            this.labelTop.AutoSize = true;
            this.labelTop.Location = new System.Drawing.Point(12, 12);
            this.labelTop.Margin = new System.Windows.Forms.Padding(3, 3, 3, 24);
            this.labelTop.MaximumSize = new System.Drawing.Size(460, 0);
            this.labelTop.Name = "labelTop";
            this.labelTop.Size = new System.Drawing.Size(459, 60);
            this.labelTop.TabIndex = 23;
            this.labelTop.Text = "Currently editing a database entry. Once \'Edit\' is pressed, the database has to b" +
    "e saved for the changes to take effect.\r\n\r\nThis action cannot be undone, once th" +
    "e database changes are saved.";
            // 
            // labelDivider
            // 
            this.labelDivider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDivider.Location = new System.Drawing.Point(-11, 297);
            this.labelDivider.Margin = new System.Windows.Forms.Padding(3, 24, 3, 7);
            this.labelDivider.Name = "labelDivider";
            this.labelDivider.Size = new System.Drawing.Size(510, 2);
            this.labelDivider.TabIndex = 24;
            // 
            // EditEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 344);
            this.Controls.Add(this.labelDivider);
            this.Controls.Add(this.labelTop);
            this.Controls.Add(this.buttonRevealNote);
            this.Controls.Add(this.buttonRevealPassword);
            this.Controls.Add(this.buttonRevealEmail);
            this.Controls.Add(this.buttonRevealUsername);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.textBoxUrl);
            this.Controls.Add(this.secureStringTextBoxNote);
            this.Controls.Add(this.secureStringTextBoxEmail);
            this.Controls.Add(this.secureStringTextBoxPassword);
            this.Controls.Add(this.labelNote);
            this.Controls.Add(this.labelUrl);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.secureStringTextBoxUsername);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxNote);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditEntryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Entry";
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
        private Button buttonEdit;
        private Button buttonCancel;
        private Button buttonRevealUsername;
        private Button buttonRevealEmail;
        private Button buttonRevealPassword;
        private Button buttonRevealNote;
        private TextBox textBoxUsername;
        private TextBox textBoxEmail;
        private TextBox textBoxPassword;
        private TextBox textBoxNote;
        private Label labelTop;
        private Label labelDivider;
    }
}