namespace KrepostWinForms.Forms
{
    partial class OpenDatabaseForm
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
            this.labelHeader = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.secureStringTextBox = new SecureStringTextBox.SecureStringTextBox();
            this.SuspendLayout();
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Location = new System.Drawing.Point(12, 9);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(153, 15);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "Enter Your Master Password";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(12, 86);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(99, 15);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Master Password:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(347, 326);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(266, 326);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(75, 23);
            this.buttonOpen.TabIndex = 4;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // secureStringTextBox
            // 
            this.secureStringTextBox.DataHash = null;
            this.secureStringTextBox.DataSalt = null;
            this.secureStringTextBox.Location = new System.Drawing.Point(117, 82);
            this.secureStringTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.secureStringTextBox.Name = "secureStringTextBox";
            this.secureStringTextBox.Size = new System.Drawing.Size(305, 23);
            this.secureStringTextBox.TabIndex = 5;
            // 
            // OpenDatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 361);
            this.Controls.Add(this.secureStringTextBox);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelHeader);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OpenDatabaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OpenDatabaseForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelHeader;
        private Label labelPassword;
        private Button buttonCancel;
        private Button buttonOpen;
        private SecureStringTextBox.SecureStringTextBox secureStringTextBox;
    }
}