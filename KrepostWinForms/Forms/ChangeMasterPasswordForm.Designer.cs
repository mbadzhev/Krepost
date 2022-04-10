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
            System.Security.SecureString secureString3 = new System.Security.SecureString();
            System.Security.SecureString secureString4 = new System.Security.SecureString();
            this.secureStringTextBoxTop = new KrepostWinForms.UI.SecureStringTextBox();
            this.labelNewMasterPass = new System.Windows.Forms.Label();
            this.secureStringTextBoxBottom = new KrepostWinForms.UI.SecureStringTextBox();
            this.labelRepeatNewPass = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // secureStringTextBoxTop
            // 
            this.secureStringTextBoxTop.Data = secureString3;
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
            this.secureStringTextBoxBottom.Data = secureString4;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(315, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.button1);
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
        private Button button1;
        private Button buttonCancel;
    }
}