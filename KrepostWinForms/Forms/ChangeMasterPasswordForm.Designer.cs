namespace KrepostWinForms.Forms
{
    partial class ChangeMasterPasswordForm
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
            this.secureStringTextBoxTop = new KrepostWinForms.UI.SecureStringTextBox();
            this.labelNewMasterPass = new System.Windows.Forms.Label();
            this.secureStringTextBoxBottom = new KrepostWinForms.UI.SecureStringTextBox();
            this.labelRepeatNewPass = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // secureStringTextBoxTop
            // 
            this.secureStringTextBoxTop.Data = secureString5;
            this.secureStringTextBoxTop.DataHash = null;
            this.secureStringTextBoxTop.DataSalt = null;
            this.secureStringTextBoxTop.Location = new System.Drawing.Point(142, 58);
            this.secureStringTextBoxTop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 10);
            this.secureStringTextBoxTop.Name = "secureStringTextBoxTop";
            this.secureStringTextBoxTop.Size = new System.Drawing.Size(329, 23);
            this.secureStringTextBoxTop.TabIndex = 0;
            // 
            // labelNewMasterPass
            // 
            this.labelNewMasterPass.AutoSize = true;
            this.labelNewMasterPass.Location = new System.Drawing.Point(12, 62);
            this.labelNewMasterPass.Name = "labelNewMasterPass";
            this.labelNewMasterPass.Size = new System.Drawing.Size(123, 15);
            this.labelNewMasterPass.TabIndex = 1;
            this.labelNewMasterPass.Text = "New Master Password";
            // 
            // secureStringTextBoxBottom
            // 
            this.secureStringTextBoxBottom.Data = secureString6;
            this.secureStringTextBoxBottom.DataHash = null;
            this.secureStringTextBoxBottom.DataSalt = null;
            this.secureStringTextBoxBottom.Location = new System.Drawing.Point(142, 94);
            this.secureStringTextBoxBottom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.secureStringTextBoxBottom.Name = "secureStringTextBoxBottom";
            this.secureStringTextBoxBottom.Size = new System.Drawing.Size(329, 23);
            this.secureStringTextBoxBottom.TabIndex = 2;
            // 
            // labelRepeatNewPass
            // 
            this.labelRepeatNewPass.AutoSize = true;
            this.labelRepeatNewPass.Location = new System.Drawing.Point(12, 98);
            this.labelRepeatNewPass.Name = "labelRepeatNewPass";
            this.labelRepeatNewPass.Size = new System.Drawing.Size(123, 15);
            this.labelRepeatNewPass.TabIndex = 3;
            this.labelRepeatNewPass.Text = "Repeat New Password";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(315, 226);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(396, 226);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // ChangeMasterPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelRepeatNewPass);
            this.Controls.Add(this.secureStringTextBoxBottom);
            this.Controls.Add(this.labelNewMasterPass);
            this.Controls.Add(this.secureStringTextBoxTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangeMasterPasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangeMasterPasswordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UI.SecureStringTextBox secureStringTextBoxTop;
        private Label labelNewMasterPass;
        private UI.SecureStringTextBox secureStringTextBoxBottom;
        private Label labelRepeatNewPass;
        private Button buttonSave;
        private Button buttonCancel;
    }
}