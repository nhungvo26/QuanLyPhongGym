
namespace GUI_QLPG
{
    partial class GUI_ThietBi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_ThietBi));
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvDSThietBi = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpNgayMuaTB = new System.Windows.Forms.DateTimePicker();
            this.cbTrangThaiTB = new System.Windows.Forms.ComboBox();
            this.cbPhongTap = new System.Windows.Forms.ComboBox();
            this.cbLoaiTB = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnLamMoiTB = new System.Windows.Forms.Button();
            this.btnXoaTB = new System.Windows.Forms.Button();
            this.btnSuaTB = new System.Windows.Forms.Button();
            this.btnThemTB = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDonGiaTB = new System.Windows.Forms.TextBox();
            this.txtTenTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBaoTri = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimKiemTB = new System.Windows.Forms.TextBox();
            this.btnTimKiemTB = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSThietBi)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dgvDSThietBi);
            this.panel2.Location = new System.Drawing.Point(19, 341);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(930, 280);
            this.panel2.TabIndex = 3;
            // 
            // dgvDSThietBi
            // 
            this.dgvDSThietBi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSThietBi.Location = new System.Drawing.Point(15, 15);
            this.dgvDSThietBi.Name = "dgvDSThietBi";
            this.dgvDSThietBi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSThietBi.Size = new System.Drawing.Size(900, 250);
            this.dgvDSThietBi.TabIndex = 0;
            this.dgvDSThietBi.Click += new System.EventHandler(this.dgvDSThietBi_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnTimKiemTB);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnBaoTri);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtTimKiemTB);
            this.panel1.Location = new System.Drawing.Point(19, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(930, 300);
            this.panel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpNgayMuaTB);
            this.groupBox1.Controls.Add(this.cbTrangThaiTB);
            this.groupBox1.Controls.Add(this.cbPhongTap);
            this.groupBox1.Controls.Add(this.cbLoaiTB);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnLamMoiTB);
            this.groupBox1.Controls.Add(this.btnXoaTB);
            this.groupBox1.Controls.Add(this.btnSuaTB);
            this.groupBox1.Controls.Add(this.btnThemTB);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtDonGiaTB);
            this.groupBox1.Controls.Add(this.txtTenTB);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(20, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(890, 246);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // dtpNgayMuaTB
            // 
            this.dtpNgayMuaTB.Checked = false;
            this.dtpNgayMuaTB.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayMuaTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayMuaTB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayMuaTB.Location = new System.Drawing.Point(572, 30);
            this.dtpNgayMuaTB.Name = "dtpNgayMuaTB";
            this.dtpNgayMuaTB.Size = new System.Drawing.Size(290, 26);
            this.dtpNgayMuaTB.TabIndex = 12;
            // 
            // cbTrangThaiTB
            // 
            this.cbTrangThaiTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTrangThaiTB.FormattingEnabled = true;
            this.cbTrangThaiTB.Location = new System.Drawing.Point(572, 75);
            this.cbTrangThaiTB.Name = "cbTrangThaiTB";
            this.cbTrangThaiTB.Size = new System.Drawing.Size(290, 28);
            this.cbTrangThaiTB.TabIndex = 11;
            // 
            // cbPhongTap
            // 
            this.cbPhongTap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPhongTap.FormattingEnabled = true;
            this.cbPhongTap.Location = new System.Drawing.Point(572, 120);
            this.cbPhongTap.Name = "cbPhongTap";
            this.cbPhongTap.Size = new System.Drawing.Size(290, 28);
            this.cbPhongTap.TabIndex = 11;
            // 
            // cbLoaiTB
            // 
            this.cbLoaiTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiTB.FormattingEnabled = true;
            this.cbLoaiTB.Location = new System.Drawing.Point(147, 75);
            this.cbLoaiTB.Name = "cbLoaiTB";
            this.cbLoaiTB.Size = new System.Drawing.Size(290, 28);
            this.cbLoaiTB.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(470, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Phòng tập:";
            // 
            // btnLamMoiTB
            // 
            this.btnLamMoiTB.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnLamMoiTB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoiTB.FlatAppearance.BorderColor = System.Drawing.Color.MediumSpringGreen;
            this.btnLamMoiTB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnLamMoiTB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnLamMoiTB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoiTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoiTB.ForeColor = System.Drawing.Color.Black;
            this.btnLamMoiTB.Location = new System.Drawing.Point(670, 190);
            this.btnLamMoiTB.Name = "btnLamMoiTB";
            this.btnLamMoiTB.Size = new System.Drawing.Size(150, 35);
            this.btnLamMoiTB.TabIndex = 9;
            this.btnLamMoiTB.Text = "Làm mới";
            this.btnLamMoiTB.UseVisualStyleBackColor = false;
            this.btnLamMoiTB.Click += new System.EventHandler(this.btnLamMoiTB_Click);
            // 
            // btnXoaTB
            // 
            this.btnXoaTB.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnXoaTB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaTB.FlatAppearance.BorderColor = System.Drawing.Color.MediumSpringGreen;
            this.btnXoaTB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnXoaTB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnXoaTB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaTB.ForeColor = System.Drawing.Color.Black;
            this.btnXoaTB.Location = new System.Drawing.Point(470, 190);
            this.btnXoaTB.Name = "btnXoaTB";
            this.btnXoaTB.Size = new System.Drawing.Size(150, 35);
            this.btnXoaTB.TabIndex = 9;
            this.btnXoaTB.Text = "Xóa";
            this.btnXoaTB.UseVisualStyleBackColor = false;
            this.btnXoaTB.Click += new System.EventHandler(this.btnXoaTB_Click);
            // 
            // btnSuaTB
            // 
            this.btnSuaTB.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnSuaTB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaTB.FlatAppearance.BorderColor = System.Drawing.Color.MediumSpringGreen;
            this.btnSuaTB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSuaTB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSuaTB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaTB.ForeColor = System.Drawing.Color.Black;
            this.btnSuaTB.Location = new System.Drawing.Point(270, 190);
            this.btnSuaTB.Name = "btnSuaTB";
            this.btnSuaTB.Size = new System.Drawing.Size(150, 35);
            this.btnSuaTB.TabIndex = 9;
            this.btnSuaTB.Text = "Sửa";
            this.btnSuaTB.UseVisualStyleBackColor = false;
            this.btnSuaTB.Click += new System.EventHandler(this.btnSuaTB_Click);
            // 
            // btnThemTB
            // 
            this.btnThemTB.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnThemTB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemTB.FlatAppearance.BorderColor = System.Drawing.Color.MediumSpringGreen;
            this.btnThemTB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnThemTB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnThemTB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemTB.ForeColor = System.Drawing.Color.Black;
            this.btnThemTB.Location = new System.Drawing.Point(70, 190);
            this.btnThemTB.Name = "btnThemTB";
            this.btnThemTB.Size = new System.Drawing.Size(150, 35);
            this.btnThemTB.TabIndex = 9;
            this.btnThemTB.Text = "Thêm";
            this.btnThemTB.UseVisualStyleBackColor = false;
            this.btnThemTB.Click += new System.EventHandler(this.btnThemTB_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(470, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Trạng thái:";
            // 
            // txtDonGiaTB
            // 
            this.txtDonGiaTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGiaTB.Location = new System.Drawing.Point(147, 120);
            this.txtDonGiaTB.Name = "txtDonGiaTB";
            this.txtDonGiaTB.Size = new System.Drawing.Size(290, 26);
            this.txtDonGiaTB.TabIndex = 4;
            // 
            // txtTenTB
            // 
            this.txtTenTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTB.Location = new System.Drawing.Point(147, 30);
            this.txtTenTB.Name = "txtTenTB";
            this.txtTenTB.Size = new System.Drawing.Size(290, 26);
            this.txtTenTB.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(470, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Ngày mua:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên thiết bị:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Loại thiết bị:";
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
            // btnBaoTri
            // 
            this.btnBaoTri.BackColor = System.Drawing.Color.Transparent;
            this.btnBaoTri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBaoTri.FlatAppearance.BorderColor = System.Drawing.Color.MediumSpringGreen;
            this.btnBaoTri.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnBaoTri.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnBaoTri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaoTri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoTri.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.btnBaoTri.Location = new System.Drawing.Point(742, 10);
            this.btnBaoTri.Name = "btnBaoTri";
            this.btnBaoTri.Size = new System.Drawing.Size(140, 30);
            this.btnBaoTri.TabIndex = 8;
            this.btnBaoTri.Text = "Bảo trì";
            this.btnBaoTri.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label1.Location = new System.Drawing.Point(16, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách thiết bị";
            // 
            // txtTimKiemTB
            // 
            this.txtTimKiemTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemTB.Location = new System.Drawing.Point(261, 10);
            this.txtTimKiemTB.Name = "txtTimKiemTB";
            this.txtTimKiemTB.Size = new System.Drawing.Size(342, 26);
            this.txtTimKiemTB.TabIndex = 4;
            // 
            // btnTimKiemTB
            // 
            this.btnTimKiemTB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTimKiemTB.BackgroundImage")));
            this.btnTimKiemTB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimKiemTB.Location = new System.Drawing.Point(610, 9);
            this.btnTimKiemTB.Name = "btnTimKiemTB";
            this.btnTimKiemTB.Size = new System.Drawing.Size(30, 28);
            this.btnTimKiemTB.TabIndex = 11;
            this.btnTimKiemTB.UseVisualStyleBackColor = true;
            this.btnTimKiemTB.Click += new System.EventHandler(this.btnTimKiemTB_Click);
            // 
            // GUI_ThietBi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(968, 642);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "GUI_ThietBi";
            this.Text = "ThietBi";
            this.Load += new System.EventHandler(this.GUI_ThietBi_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSThietBi)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvDSThietBi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTimKiemTB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpNgayMuaTB;
        private System.Windows.Forms.ComboBox cbTrangThaiTB;
        private System.Windows.Forms.ComboBox cbPhongTap;
        private System.Windows.Forms.ComboBox cbLoaiTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnLamMoiTB;
        private System.Windows.Forms.Button btnXoaTB;
        private System.Windows.Forms.Button btnSuaTB;
        private System.Windows.Forms.Button btnThemTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDonGiaTB;
        private System.Windows.Forms.TextBox txtTenTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBaoTri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTimKiemTB;
    }
}