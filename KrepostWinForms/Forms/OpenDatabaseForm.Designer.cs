using KrepostWinForms.UI;

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
            System.Security.SecureString secureString1 = new System.Security.SecureString();
            this.labelTop = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.secureStringTextBox = new KrepostWinForms.UI.SecureStringTextBox();
            this.labelDivider = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTop
            // 
            this.labelTop.AutoSize = true;
            this.labelTop.Location = new System.Drawing.Point(12, 12);
            this.labelTop.Margin = new System.Windows.Forms.Padding(3, 3, 3, 24);
            this.labelTop.Name = "labelTop";
            this.labelTop.Size = new System.Drawing.Size(126, 15);
            this.labelTop.TabIndex = 0;
            this.labelTop.Text = "Enter Master Password";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(12, 58);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(99, 15);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Master Password:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(397, 118);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(316, 118);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(75, 23);
            this.buttonOpen.TabIndex = 4;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // secureStringTextBox
            // 
            this.secureStringTextBox.Data = secureString1;
            this.secureStringTextBox.DataHash = null;
            this.secureStringTextBox.DataSalt = null;
            this.secureStringTextBox.Location = new System.Drawing.Point(117, 54);
            this.secureStringTextBox.Name = "secureStringTextBox";
            this.secureStringTextBox.Size = new System.Drawing.Size(355, 23);
            this.secureStringTextBox.TabIndex = 5;
            // 
            // labelDivider
            // 
            this.labelDivider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDivider.Location = new System.Drawing.Point(-13, 106);
            this.labelDivider.Margin = new System.Windows.Forms.Padding(3, 24, 3, 7);
            this.labelDivider.Name = "labelDivider";
            this.labelDivider.Size = new System.Drawing.Size(510, 2);
            this.labelDivider.TabIndex = 10;
            // 
            // OpenDatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 153);
            this.Controls.Add(this.labelDivider);
            this.Controls.Add(this.secureStringTextBox);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OpenDatabaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Open Database";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelTop;
        private Label labelPassword;
        private Button buttonCancel;
        private Button buttonOpen;
        private SecureStringTextBox secureStringTextBox;
        private Label labelDivider;
    }
}