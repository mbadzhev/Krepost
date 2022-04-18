using KrepostWinForms.UI;

namespace KrepostWinForms.Forms
{
    partial class NewDatabaseForm
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
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelPasswordRepeat = new System.Windows.Forms.Label();
            this.labelTop = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.secureStringTextBoxBottom = new KrepostWinForms.UI.SecureStringTextBox();
            this.secureStringTextBoxTop = new KrepostWinForms.UI.SecureStringTextBox();
            this.labelDivider = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(12, 101);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(129, 15);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Enter Master Password:";
            // 
            // labelPasswordRepeat
            // 
            this.labelPasswordRepeat.AutoSize = true;
            this.labelPasswordRepeat.Location = new System.Drawing.Point(12, 130);
            this.labelPasswordRepeat.Name = "labelPasswordRepeat";
            this.labelPasswordRepeat.Size = new System.Drawing.Size(138, 15);
            this.labelPasswordRepeat.TabIndex = 3;
            this.labelPasswordRepeat.Text = "Repeat Master Password:";
            // 
            // labelTop
            // 
            this.labelTop.AutoSize = true;
            this.labelTop.Location = new System.Drawing.Point(12, 12);
            this.labelTop.Margin = new System.Windows.Forms.Padding(3, 3, 3, 24);
            this.labelTop.MaximumSize = new System.Drawing.Size(460, 0);
            this.labelTop.Name = "labelTop";
            this.labelTop.Size = new System.Drawing.Size(451, 60);
            this.labelTop.TabIndex = 4;
            this.labelTop.Text = "Credentials are stored in a database file. Once \'Save\' is pressed, a promp to cho" +
    "ose a save location will appear.\r\n\r\nIt is important to remember where the databa" +
    "se file is located.\r\n";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(397, 190);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(316, 190);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // secureStringTextBoxBottom
            // 
            this.secureStringTextBoxBottom.Data = secureString3;
            this.secureStringTextBoxBottom.DataHash = null;
            this.secureStringTextBoxBottom.DataSalt = null;
            this.secureStringTextBoxBottom.Location = new System.Drawing.Point(157, 126);
            this.secureStringTextBoxBottom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.secureStringTextBoxBottom.Name = "secureStringTextBoxBottom";
            this.secureStringTextBoxBottom.Size = new System.Drawing.Size(315, 23);
            this.secureStringTextBoxBottom.TabIndex = 7;
            // 
            // secureStringTextBoxTop
            // 
            this.secureStringTextBoxTop.Data = secureString4;
            this.secureStringTextBoxTop.DataHash = null;
            this.secureStringTextBoxTop.DataSalt = null;
            this.secureStringTextBoxTop.Location = new System.Drawing.Point(157, 97);
            this.secureStringTextBoxTop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.secureStringTextBoxTop.Name = "secureStringTextBoxTop";
            this.secureStringTextBoxTop.Size = new System.Drawing.Size(315, 23);
            this.secureStringTextBoxTop.TabIndex = 8;
            // 
            // labelDivider
            // 
            this.labelDivider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDivider.Location = new System.Drawing.Point(-14, 178);
            this.labelDivider.Margin = new System.Windows.Forms.Padding(3, 24, 3, 7);
            this.labelDivider.Name = "labelDivider";
            this.labelDivider.Size = new System.Drawing.Size(510, 2);
            this.labelDivider.TabIndex = 9;
            // 
            // NewDatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 225);
            this.Controls.Add(this.labelDivider);
            this.Controls.Add(this.secureStringTextBoxTop);
            this.Controls.Add(this.secureStringTextBoxBottom);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelTop);
            this.Controls.Add(this.labelPasswordRepeat);
            this.Controls.Add(this.labelPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewDatabaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Database";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label labelPassword;
        private Label labelPasswordRepeat;
        private Label labelTop;
        private Button buttonCancel;
        private Button buttonSave;
        private SecureStringTextBox secureStringTextBoxBottom;
        private SecureStringTextBox secureStringTextBoxTop;
        private Label labelDivider;
    }
}