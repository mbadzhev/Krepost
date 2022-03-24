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
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUrl = new System.Windows.Forms.Label();
            this.labelNote = new System.Windows.Forms.Label();
            this.secureStringTextBoxPassword = new SecureStringTextBox();
            this.secureStringTextBoxEmail = new SecureStringTextBox();
            this.secureStringTextBoxUsername = new SecureStringTextBox();
            this.secureStringTextBoxNote = new SecureStringTextBox();
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(12, 63);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(32, 15);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Title:";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(12, 103);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(63, 15);
            this.labelUsername.TabIndex = 1;
            this.labelUsername.Text = "Username:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(12, 143);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(39, 15);
            this.labelEmail.TabIndex = 2;
            this.labelEmail.Text = "Email:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(12, 183);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(60, 15);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Password:";
            // 
            // labelUrl
            // 
            this.labelUrl.AutoSize = true;
            this.labelUrl.Location = new System.Drawing.Point(12, 223);
            this.labelUrl.Name = "labelUrl";
            this.labelUrl.Size = new System.Drawing.Size(31, 15);
            this.labelUrl.TabIndex = 4;
            this.labelUrl.Text = "URL:";
            // 
            // labelNote
            // 
            this.labelNote.AutoSize = true;
            this.labelNote.Location = new System.Drawing.Point(12, 263);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(36, 15);
            this.labelNote.TabIndex = 5;
            this.labelNote.Text = "Note:";
            // 
            // secureStringTextBoxPassword
            // 
            this.secureStringTextBoxPassword.DataHash = null;
            this.secureStringTextBoxPassword.DataSalt = null;
            this.secureStringTextBoxPassword.Location = new System.Drawing.Point(97, 180);
            this.secureStringTextBoxPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.secureStringTextBoxPassword.Name = "secureStringTextBoxPassword";
            this.secureStringTextBoxPassword.Size = new System.Drawing.Size(325, 23);
            this.secureStringTextBoxPassword.TabIndex = 6;
            // 
            // secureStringTextBoxEmail
            // 
            this.secureStringTextBoxEmail.DataHash = null;
            this.secureStringTextBoxEmail.DataSalt = null;
            this.secureStringTextBoxEmail.Location = new System.Drawing.Point(97, 140);
            this.secureStringTextBoxEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.secureStringTextBoxEmail.Name = "secureStringTextBoxEmail";
            this.secureStringTextBoxEmail.Size = new System.Drawing.Size(325, 23);
            this.secureStringTextBoxEmail.TabIndex = 7;
            // 
            // secureStringTextBoxUsername
            // 
            this.secureStringTextBoxUsername.DataHash = null;
            this.secureStringTextBoxUsername.DataSalt = null;
            this.secureStringTextBoxUsername.Location = new System.Drawing.Point(97, 100);
            this.secureStringTextBoxUsername.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.secureStringTextBoxUsername.Name = "secureStringTextBoxUsername";
            this.secureStringTextBoxUsername.Size = new System.Drawing.Size(325, 23);
            this.secureStringTextBoxUsername.TabIndex = 8;
            // 
            // secureStringTextBoxNote
            // 
            this.secureStringTextBoxNote.DataHash = null;
            this.secureStringTextBoxNote.DataSalt = null;
            this.secureStringTextBoxNote.Location = new System.Drawing.Point(97, 260);
            this.secureStringTextBoxNote.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.secureStringTextBoxNote.Name = "secureStringTextBoxNote";
            this.secureStringTextBoxNote.Size = new System.Drawing.Size(325, 23);
            this.secureStringTextBoxNote.TabIndex = 10;
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Location = new System.Drawing.Point(97, 220);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(325, 23);
            this.textBoxUrl.TabIndex = 11;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(97, 60);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(325, 23);
            this.textBoxTitle.TabIndex = 12;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(266, 376);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 14;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(347, 376);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // AddEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.buttonSave);
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEntryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEntryForm";
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
        private Button buttonSave;
        private Button buttonCancel;
    }
}