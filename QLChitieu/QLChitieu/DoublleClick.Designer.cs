namespace QLChitieu
{
    partial class DoublleClick
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
            this.lbeSoluong = new System.Windows.Forms.Label();
            this.txtSoluongDB = new System.Windows.Forms.TextBox();
            this.ngaythangChiDB = new System.Windows.Forms.DateTimePicker();
            this.btnSaveChiDB = new System.Windows.Forms.Button();
            this.txtGiaChiDB = new System.Windows.Forms.TextBox();
            this.txtChiDB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbeSoluong
            // 
            this.lbeSoluong.AutoSize = true;
            this.lbeSoluong.Location = new System.Drawing.Point(644, 115);
            this.lbeSoluong.Name = "lbeSoluong";
            this.lbeSoluong.Size = new System.Drawing.Size(69, 17);
            this.lbeSoluong.TabIndex = 69;
            this.lbeSoluong.Text = "Số Lượng";
            // 
            // txtSoluongDB
            // 
            this.txtSoluongDB.Location = new System.Drawing.Point(720, 115);
            this.txtSoluongDB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoluongDB.Name = "txtSoluongDB";
            this.txtSoluongDB.Size = new System.Drawing.Size(100, 22);
            this.txtSoluongDB.TabIndex = 68;
            // 
            // ngaythangChiDB
            // 
            this.ngaythangChiDB.Location = new System.Drawing.Point(414, 115);
            this.ngaythangChiDB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ngaythangChiDB.Name = "ngaythangChiDB";
            this.ngaythangChiDB.Size = new System.Drawing.Size(224, 22);
            this.ngaythangChiDB.TabIndex = 67;
            // 
            // btnSaveChiDB
            // 
            this.btnSaveChiDB.Location = new System.Drawing.Point(826, 115);
            this.btnSaveChiDB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveChiDB.Name = "btnSaveChiDB";
            this.btnSaveChiDB.Size = new System.Drawing.Size(75, 23);
            this.btnSaveChiDB.TabIndex = 66;
            this.btnSaveChiDB.Text = "Save";
            this.btnSaveChiDB.UseVisualStyleBackColor = true;
            // 
            // txtGiaChiDB
            // 
            this.txtGiaChiDB.Location = new System.Drawing.Point(297, 115);
            this.txtGiaChiDB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGiaChiDB.Name = "txtGiaChiDB";
            this.txtGiaChiDB.Size = new System.Drawing.Size(100, 22);
            this.txtGiaChiDB.TabIndex = 65;
            // 
            // txtChiDB
            // 
            this.txtChiDB.Location = new System.Drawing.Point(133, 115);
            this.txtChiDB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtChiDB.Name = "txtChiDB";
            this.txtChiDB.Size = new System.Drawing.Size(100, 22);
            this.txtChiDB.TabIndex = 64;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(261, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 17);
            this.label6.TabIndex = 63;
            this.label6.Text = "Giá";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 62;
            this.label5.Text = "Tên chi tiêu";
            // 
            // DoublleClick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 253);
            this.Controls.Add(this.lbeSoluong);
            this.Controls.Add(this.txtSoluongDB);
            this.Controls.Add(this.ngaythangChiDB);
            this.Controls.Add(this.btnSaveChiDB);
            this.Controls.Add(this.txtGiaChiDB);
            this.Controls.Add(this.txtChiDB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Name = "DoublleClick";
            this.Text = "DoublleClick";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbeSoluong;
        private System.Windows.Forms.TextBox txtSoluongDB;
        private System.Windows.Forms.DateTimePicker ngaythangChiDB;
        private System.Windows.Forms.Button btnSaveChiDB;
        private System.Windows.Forms.TextBox txtGiaChiDB;
        private System.Windows.Forms.TextBox txtChiDB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}