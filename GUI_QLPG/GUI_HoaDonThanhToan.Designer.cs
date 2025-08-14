
namespace GUI_QLPG
{
    partial class GUI_HoaDonThanhToan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_HoaDonThanhToan));
            this.label1 = new System.Windows.Forms.Label();
            this.btnQuayLaiGT = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaLopHoc = new System.Windows.Forms.TextBox();
            this.dtpNgayTT = new System.Windows.Forms.DateTimePicker();
            this.cbLoaiTT = new System.Windows.Forms.ComboBox();
            this.cbPhuongThucTT = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnQRCode = new System.Windows.Forms.Button();
            this.btnThanhToanHD = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDonGiaTT = new System.Windows.Forms.TextBox();
            this.txtMaHocVien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label1.Location = new System.Drawing.Point(400, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thanh toán";
            // 
            // btnQuayLaiGT
            // 
            this.btnQuayLaiGT.BackColor = System.Drawing.Color.Transparent;
            this.btnQuayLaiGT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuayLaiGT.FlatAppearance.BorderColor = System.Drawing.Color.MediumSpringGreen;
            this.btnQuayLaiGT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnQuayLaiGT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnQuayLaiGT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuayLaiGT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuayLaiGT.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.btnQuayLaiGT.Location = new System.Drawing.Point(742, 10);
            this.btnQuayLaiGT.Name = "btnQuayLaiGT";
            this.btnQuayLaiGT.Size = new System.Drawing.Size(140, 30);
            this.btnQuayLaiGT.TabIndex = 8;
            this.btnQuayLaiGT.Text = "Quay lại";
            this.btnQuayLaiGT.UseVisualStyleBackColor = false;
            this.btnQuayLaiGT.Click += new System.EventHandler(this.btnQuayLaiGT_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnQuayLaiGT);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(17, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(930, 300);
            this.panel1.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaLopHoc);
            this.groupBox1.Controls.Add(this.dtpNgayTT);
            this.groupBox1.Controls.Add(this.cbLoaiTT);
            this.groupBox1.Controls.Add(this.cbPhuongThucTT);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnQRCode);
            this.groupBox1.Controls.Add(this.btnThanhToanHD);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtDonGiaTT);
            this.groupBox1.Controls.Add(this.txtMaHocVien);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(20, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(890, 246);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // txtMaLopHoc
            // 
            this.txtMaLopHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLopHoc.Location = new System.Drawing.Point(147, 75);
            this.txtMaLopHoc.Name = "txtMaLopHoc";
            this.txtMaLopHoc.Size = new System.Drawing.Size(195, 26);
            this.txtMaLopHoc.TabIndex = 13;
            // 
            // dtpNgayTT
            // 
            this.dtpNgayTT.Checked = false;
            this.dtpNgayTT.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayTT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayTT.Location = new System.Drawing.Point(620, 120);
            this.dtpNgayTT.Name = "dtpNgayTT";
            this.dtpNgayTT.Size = new System.Drawing.Size(195, 26);
            this.dtpNgayTT.TabIndex = 12;
            // 
            // cbLoaiTT
            // 
            this.cbLoaiTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiTT.FormattingEnabled = true;
            this.cbLoaiTT.Location = new System.Drawing.Point(620, 75);
            this.cbLoaiTT.Name = "cbLoaiTT";
            this.cbLoaiTT.Size = new System.Drawing.Size(195, 28);
            this.cbLoaiTT.TabIndex = 11;
            // 
            // cbPhuongThucTT
            // 
            this.cbPhuongThucTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPhuongThucTT.FormattingEnabled = true;
            this.cbPhuongThucTT.Location = new System.Drawing.Point(620, 30);
            this.cbPhuongThucTT.Name = "cbPhuongThucTT";
            this.cbPhuongThucTT.Size = new System.Drawing.Size(195, 28);
            this.cbPhuongThucTT.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(400, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(207, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Phương thức thanh toán:";
            // 
            // btnQRCode
            // 
            this.btnQRCode.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnQRCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQRCode.FlatAppearance.BorderColor = System.Drawing.Color.MediumSpringGreen;
            this.btnQRCode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnQRCode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnQRCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQRCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQRCode.ForeColor = System.Drawing.Color.Black;
            this.btnQRCode.Location = new System.Drawing.Point(530, 190);
            this.btnQRCode.Name = "btnQRCode";
            this.btnQRCode.Size = new System.Drawing.Size(150, 35);
            this.btnQRCode.TabIndex = 9;
            this.btnQRCode.Text = "QR Code";
            this.btnQRCode.UseVisualStyleBackColor = false;
            // 
            // btnThanhToanHD
            // 
            this.btnThanhToanHD.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnThanhToanHD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThanhToanHD.FlatAppearance.BorderColor = System.Drawing.Color.MediumSpringGreen;
            this.btnThanhToanHD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnThanhToanHD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnThanhToanHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToanHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToanHD.ForeColor = System.Drawing.Color.Black;
            this.btnThanhToanHD.Location = new System.Drawing.Point(220, 190);
            this.btnThanhToanHD.Name = "btnThanhToanHD";
            this.btnThanhToanHD.Size = new System.Drawing.Size(150, 35);
            this.btnThanhToanHD.TabIndex = 9;
            this.btnThanhToanHD.Text = "Thanh toán";
            this.btnThanhToanHD.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(400, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Loại thanh toán:";
            // 
            // txtDonGiaTT
            // 
            this.txtDonGiaTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGiaTT.Location = new System.Drawing.Point(147, 120);
            this.txtDonGiaTT.Name = "txtDonGiaTT";
            this.txtDonGiaTT.Size = new System.Drawing.Size(195, 26);
            this.txtDonGiaTT.TabIndex = 4;
            // 
            // txtMaHocVien
            // 
            this.txtMaHocVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHocVien.Location = new System.Drawing.Point(147, 30);
            this.txtMaHocVien.Name = "txtMaHocVien";
            this.txtMaHocVien.Size = new System.Drawing.Size(195, 26);
            this.txtMaHocVien.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(400, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Ngày thanh toán:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã học viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã lớp học";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(21, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Đơn giá:";
            // 
            // GUI_HoaDonThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(968, 347);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "GUI_HoaDonThanhToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HoaDonThanhToan";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQuayLaiGT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpNgayTT;
        private System.Windows.Forms.ComboBox cbLoaiTT;
        private System.Windows.Forms.ComboBox cbPhuongThucTT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnQRCode;
        private System.Windows.Forms.Button btnThanhToanHD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDonGiaTT;
        private System.Windows.Forms.TextBox txtMaHocVien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaLopHoc;
    }
}