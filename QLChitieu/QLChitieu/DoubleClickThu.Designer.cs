namespace QLChitieu
{
    partial class DoubleClickThu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoubleClickThu));
            this.ngaythangthuDBT = new System.Windows.Forms.DateTimePicker();
            this.btnSavethuDBT = new System.Windows.Forms.Button();
            this.txtGiathuDBT = new System.Windows.Forms.TextBox();
            this.txtThuDBT = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaThu = new System.Windows.Forms.TextBox();
            this.btncancelDBCT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ngaythangthuDBT
            // 
            this.ngaythangthuDBT.Location = new System.Drawing.Point(204, 121);
            this.ngaythangthuDBT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ngaythangthuDBT.Name = "ngaythangthuDBT";
            this.ngaythangthuDBT.Size = new System.Drawing.Size(222, 22);
            this.ngaythangthuDBT.TabIndex = 65;
            // 
            // btnSavethuDBT
            // 
            this.btnSavethuDBT.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSavethuDBT.Location = new System.Drawing.Point(294, 161);
            this.btnSavethuDBT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSavethuDBT.Name = "btnSavethuDBT";
            this.btnSavethuDBT.Size = new System.Drawing.Size(75, 37);
            this.btnSavethuDBT.TabIndex = 64;
            this.btnSavethuDBT.Text = "Save";
            this.btnSavethuDBT.UseVisualStyleBackColor = false;
            // 
            // txtGiathuDBT
            // 
            this.txtGiathuDBT.Location = new System.Drawing.Point(89, 121);
            this.txtGiathuDBT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGiathuDBT.Name = "txtGiathuDBT";
            this.txtGiathuDBT.Size = new System.Drawing.Size(100, 22);
            this.txtGiathuDBT.TabIndex = 63;
            // 
            // txtThuDBT
            // 
            this.txtThuDBT.Location = new System.Drawing.Point(326, 51);
            this.txtThuDBT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtThuDBT.Name = "txtThuDBT";
            this.txtThuDBT.Size = new System.Drawing.Size(100, 22);
            this.txtThuDBT.TabIndex = 62;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(13, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 17);
            this.label9.TabIndex = 61;
            this.label9.Text = "Số Tiền";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(209, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 17);
            this.label8.TabIndex = 60;
            this.label8.Text = "TÊN THU NHẬP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(12, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 17);
            this.label5.TabIndex = 66;
            this.label5.Text = "STT";
            // 
            // txtMaThu
            // 
            this.txtMaThu.Location = new System.Drawing.Point(89, 49);
            this.txtMaThu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaThu.Name = "txtMaThu";
            this.txtMaThu.Size = new System.Drawing.Size(100, 22);
            this.txtMaThu.TabIndex = 67;
            // 
            // btncancelDBCT
            // 
            this.btncancelDBCT.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btncancelDBCT.Location = new System.Drawing.Point(89, 161);
            this.btncancelDBCT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncancelDBCT.Name = "btncancelDBCT";
            this.btncancelDBCT.Size = new System.Drawing.Size(75, 37);
            this.btncancelDBCT.TabIndex = 68;
            this.btncancelDBCT.Text = "Cancel";
            this.btncancelDBCT.UseVisualStyleBackColor = false;
            // 
            // DoubleClickThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(460, 253);
            this.Controls.Add(this.btncancelDBCT);
            this.Controls.Add(this.txtMaThu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ngaythangthuDBT);
            this.Controls.Add(this.btnSavethuDBT);
            this.Controls.Add(this.txtGiathuDBT);
            this.Controls.Add(this.txtThuDBT);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Name = "DoubleClickThu";
            this.Text = "DoubleClickThu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker ngaythangthuDBT;
        private System.Windows.Forms.Button btnSavethuDBT;
        private System.Windows.Forms.TextBox txtGiathuDBT;
        private System.Windows.Forms.TextBox txtThuDBT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaThu;
        private System.Windows.Forms.Button btncancelDBCT;
    }
}