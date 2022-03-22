﻿using KrepostWinForms.UI;

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
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelPasswordRepeat = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.secureStringTextBoxBottom = new SecureStringTextBox();
            this.secureStringTextBoxTop = new SecureStringTextBox();
            this.SuspendLayout();
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(12, 112);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(129, 15);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Enter Master Password:";
            // 
            // labelPasswordRepeat
            // 
            this.labelPasswordRepeat.AutoSize = true;
            this.labelPasswordRepeat.Location = new System.Drawing.Point(12, 152);
            this.labelPasswordRepeat.Name = "labelPasswordRepeat";
            this.labelPasswordRepeat.Size = new System.Drawing.Size(138, 15);
            this.labelPasswordRepeat.TabIndex = 3;
            this.labelPasswordRepeat.Text = "Repeat Master Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "TODO: Explain master password.";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(347, 376);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(266, 376);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // secureStringTextBoxBottom
            // 
            this.secureStringTextBoxBottom.DataHash = null;
            this.secureStringTextBoxBottom.DataSalt = null;
            this.secureStringTextBoxBottom.Location = new System.Drawing.Point(157, 148);
            this.secureStringTextBoxBottom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.secureStringTextBoxBottom.Name = "secureStringTextBoxBottom";
            this.secureStringTextBoxBottom.Size = new System.Drawing.Size(264, 23);
            this.secureStringTextBoxBottom.TabIndex = 7;
            // 
            // secureStringTextBoxTop
            // 
            this.secureStringTextBoxTop.DataHash = null;
            this.secureStringTextBoxTop.DataSalt = null;
            this.secureStringTextBoxTop.Location = new System.Drawing.Point(157, 108);
            this.secureStringTextBoxTop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.secureStringTextBoxTop.Name = "secureStringTextBoxTop";
            this.secureStringTextBoxTop.Size = new System.Drawing.Size(264, 23);
            this.secureStringTextBoxTop.TabIndex = 8;
            // 
            // NewDatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.secureStringTextBoxTop);
            this.Controls.Add(this.secureStringTextBoxBottom);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPasswordRepeat);
            this.Controls.Add(this.labelPassword);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewDatabaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewDatabaseForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label labelPassword;
        private Label labelPasswordRepeat;
        private Label label1;
        private Button buttonCancel;
        private Button buttonSave;
        private SecureStringTextBox secureStringTextBoxBottom;
        private SecureStringTextBox secureStringTextBoxTop;
    }
}