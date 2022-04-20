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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelTop = new System.Windows.Forms.Label();
            this.labelDivider = new System.Windows.Forms.Label();
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
            this.secureStringTextBoxPassword.Data = secureString1;
            this.secureStringTextBoxPassword.DataHash = null;
            this.secureStringTextBoxPassword.DataSalt = null;
            this.secureStringTextBoxPassword.Location = new System.Drawing.Point(81, 156);
            this.secureStringTextBoxPassword.Name = "secureStringTextBoxPassword";
            this.secureStringTextBoxPassword.Size = new System.Drawing.Size(391, 23);
            this.secureStringTextBoxPassword.TabIndex = 3;
            // 
            // secureStringTextBoxEmail
            // 
            this.secureStringTextBoxEmail.Data = secureString2;
            this.secureStringTextBoxEmail.DataHash = null;
            this.secureStringTextBoxEmail.DataSalt = null;
            this.secureStringTextBoxEmail.Location = new System.Drawing.Point(81, 127);
            this.secureStringTextBoxEmail.Name = "secureStringTextBoxEmail";
            this.secureStringTextBoxEmail.Size = new System.Drawing.Size(391, 23);
            this.secureStringTextBoxEmail.TabIndex = 2;
            // 
            // secureStringTextBoxUsername
            // 
            this.secureStringTextBoxUsername.Data = secureString3;
            this.secureStringTextBoxUsername.DataHash = null;
            this.secureStringTextBoxUsername.DataSalt = null;
            this.secureStringTextBoxUsername.Location = new System.Drawing.Point(81, 98);
            this.secureStringTextBoxUsername.Name = "secureStringTextBoxUsername";
            this.secureStringTextBoxUsername.Size = new System.Drawing.Size(391, 23);
            this.secureStringTextBoxUsername.TabIndex = 1;
            // 
            // secureStringTextBoxNote
            // 
            this.secureStringTextBoxNote.Data = secureString4;
            this.secureStringTextBoxNote.DataHash = null;
            this.secureStringTextBoxNote.DataSalt = null;
            this.secureStringTextBoxNote.Location = new System.Drawing.Point(81, 214);
            this.secureStringTextBoxNote.Name = "secureStringTextBoxNote";
            this.secureStringTextBoxNote.Size = new System.Drawing.Size(391, 23);
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
            // AddEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 313);
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
    }
}