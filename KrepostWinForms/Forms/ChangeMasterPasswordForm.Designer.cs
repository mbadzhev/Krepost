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
            System.Security.SecureString secureString1 = new System.Security.SecureString();
            System.Security.SecureString secureString2 = new System.Security.SecureString();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeMasterPasswordForm));
            this.secureStringTextBoxTop = new KrepostWinForms.UI.SecureStringTextBox();
            this.labelNewMasterPass = new System.Windows.Forms.Label();
            this.secureStringTextBoxBottom = new KrepostWinForms.UI.SecureStringTextBox();
            this.labelRepeatNewPass = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelTop = new System.Windows.Forms.Label();
            this.labelDivider = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // secureStringTextBoxTop
            // 
            this.secureStringTextBoxTop.Data = secureString1;
            this.secureStringTextBoxTop.DataHash = null;
            this.secureStringTextBoxTop.DataSalt = null;
            this.secureStringTextBoxTop.Location = new System.Drawing.Point(144, 99);
            this.secureStringTextBoxTop.Name = "secureStringTextBoxTop";
            this.secureStringTextBoxTop.Size = new System.Drawing.Size(328, 23);
            this.secureStringTextBoxTop.TabIndex = 0;
            // 
            // labelNewMasterPass
            // 
            this.labelNewMasterPass.AutoSize = true;
            this.labelNewMasterPass.Location = new System.Drawing.Point(12, 103);
            this.labelNewMasterPass.Name = "labelNewMasterPass";
            this.labelNewMasterPass.Size = new System.Drawing.Size(126, 15);
            this.labelNewMasterPass.TabIndex = 1;
            this.labelNewMasterPass.Text = "New Master Password:";
            // 
            // secureStringTextBoxBottom
            // 
            this.secureStringTextBoxBottom.Data = secureString2;
            this.secureStringTextBoxBottom.DataHash = null;
            this.secureStringTextBoxBottom.DataSalt = null;
            this.secureStringTextBoxBottom.Location = new System.Drawing.Point(144, 128);
            this.secureStringTextBoxBottom.Name = "secureStringTextBoxBottom";
            this.secureStringTextBoxBottom.Size = new System.Drawing.Size(328, 23);
            this.secureStringTextBoxBottom.TabIndex = 2;
            // 
            // labelRepeatNewPass
            // 
            this.labelRepeatNewPass.AutoSize = true;
            this.labelRepeatNewPass.Location = new System.Drawing.Point(12, 132);
            this.labelRepeatNewPass.Name = "labelRepeatNewPass";
            this.labelRepeatNewPass.Size = new System.Drawing.Size(126, 15);
            this.labelRepeatNewPass.TabIndex = 3;
            this.labelRepeatNewPass.Text = "Repeat New Password:";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(316, 192);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(397, 192);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
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
            this.labelTop.Size = new System.Drawing.Size(456, 60);
            this.labelTop.TabIndex = 6;
            this.labelTop.Text = resources.GetString("labelTop.Text");
            // 
            // labelDivider
            // 
            this.labelDivider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDivider.Location = new System.Drawing.Point(-13, 180);
            this.labelDivider.Margin = new System.Windows.Forms.Padding(3, 24, 3, 7);
            this.labelDivider.Name = "labelDivider";
            this.labelDivider.Size = new System.Drawing.Size(510, 2);
            this.labelDivider.TabIndex = 11;
            // 
            // ChangeMasterPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 227);
            this.Controls.Add(this.labelDivider);
            this.Controls.Add(this.labelTop);
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
            this.Text = "Change Master Password";
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
        private Label labelTop;
        private Label labelDivider;
    }
}