﻿namespace QLChitieu
{
    partial class Form1
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
            this.btnDN = new System.Windows.Forms.Button();
            this.btnDK = new System.Windows.Forms.Button();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.txt_account = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDN
            // 
            this.btnDN.Location = new System.Drawing.Point(209, 105);
            this.btnDN.Margin = new System.Windows.Forms.Padding(4);
            this.btnDN.Name = "btnDN";
            this.btnDN.Size = new System.Drawing.Size(97, 28);
            this.btnDN.TabIndex = 11;
            this.btnDN.Text = "Đăng nhập";
            this.btnDN.UseVisualStyleBackColor = true;
            // 
            // btnDK
            // 
            this.btnDK.Location = new System.Drawing.Point(85, 106);
            this.btnDK.Margin = new System.Windows.Forms.Padding(4);
            this.btnDK.Name = "btnDK";
            this.btnDK.Size = new System.Drawing.Size(79, 27);
            this.btnDK.TabIndex = 10;
            this.btnDK.Text = "Đăng ký";
            this.btnDK.UseVisualStyleBackColor = true;
            // 
            // txt_Pass
            // 
            this.txt_Pass.Location = new System.Drawing.Point(105, 52);
            this.txt_Pass.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.Size = new System.Drawing.Size(255, 22);
            this.txt_Pass.TabIndex = 9;
            this.txt_Pass.UseSystemPasswordChar = true;
            // 
            // txt_account
            // 
            this.txt_account.Location = new System.Drawing.Point(105, 17);
            this.txt_account.Margin = new System.Windows.Forms.Padding(4);
            this.txt_account.Name = "txt_account";
            this.txt_account.Size = new System.Drawing.Size(255, 22);
            this.txt_account.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mật Khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tài Khoản";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 161);
            this.Controls.Add(this.btnDN);
            this.Controls.Add(this.btnDK);
            this.Controls.Add(this.txt_Pass);
            this.Controls.Add(this.txt_account);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDN;
        private System.Windows.Forms.Button btnDK;
        private System.Windows.Forms.TextBox txt_Pass;
        private System.Windows.Forms.TextBox txt_account;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

