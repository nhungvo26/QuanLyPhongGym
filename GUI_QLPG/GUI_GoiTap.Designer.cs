
namespace GUI_QLPG
{
    partial class GUI_GoiTap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_GoiTap));
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvDSGoiTap = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbLoaiGT = new System.Windows.Forms.ComboBox();
            this.dtpNgayBatDauGT = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayKetThucGT = new System.Windows.Forms.DateTimePicker();
            this.txtDonGiaGT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnLamMoiGT = new System.Windows.Forms.Button();
            this.btnXoaGT = new System.Windows.Forms.Button();
            this.btnThemGT = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnQuayLaiGT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSGoiTap)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dgvDSGoiTap);
            this.panel2.Location = new System.Drawing.Point(21, 310);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(930, 280);
            this.panel2.TabIndex = 7;
            // 
            // dgvDSGoiTap
            // 
            this.dgvDSGoiTap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSGoiTap.Location = new System.Drawing.Point(15, 15);
            this.dgvDSGoiTap.Name = "dgvDSGoiTap";
            this.dgvDSGoiTap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSGoiTap.Size = new System.Drawing.Size(900, 250);
            this.dgvDSGoiTap.TabIndex = 0;
            this.dgvDSGoiTap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSGoiTap_CellClick);
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
            this.panel1.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbLoaiGT);
            this.groupBox1.Controls.Add(this.dtpNgayBatDauGT);
            this.groupBox1.Controls.Add(this.dtpNgayKetThucGT);
            this.groupBox1.Controls.Add(this.txtDonGiaGT);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnLamMoiGT);
            this.groupBox1.Controls.Add(this.btnXoaGT);
            this.groupBox1.Controls.Add(this.btnThemGT);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(20, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(900, 212);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // cbLoaiGT
            // 
            this.cbLoaiGT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiGT.FormattingEnabled = true;
            this.cbLoaiGT.Location = new System.Drawing.Point(140, 30);
            this.cbLoaiGT.Name = "cbLoaiGT";
            this.cbLoaiGT.Size = new System.Drawing.Size(290, 28);
            this.cbLoaiGT.TabIndex = 18;
            this.cbLoaiGT.SelectedIndexChanged += new System.EventHandler(this.cbLoaiGT_SelectedIndexChanged);
            // 
            // dtpNgayBatDauGT
            // 
            this.dtpNgayBatDauGT.Checked = false;
            this.dtpNgayBatDauGT.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayBatDauGT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayBatDauGT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBatDauGT.Location = new System.Drawing.Point(590, 35);
            this.dtpNgayBatDauGT.Name = "dtpNgayBatDauGT";
            this.dtpNgayBatDauGT.Size = new System.Drawing.Size(290, 26);
            this.dtpNgayBatDauGT.TabIndex = 17;
            // 
            // dtpNgayKetThucGT
            // 
            this.dtpNgayKetThucGT.Checked = false;
            this.dtpNgayKetThucGT.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayKetThucGT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayKetThucGT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayKetThucGT.Location = new System.Drawing.Point(590, 85);
            this.dtpNgayKetThucGT.Name = "dtpNgayKetThucGT";
            this.dtpNgayKetThucGT.Size = new System.Drawing.Size(290, 26);
            this.dtpNgayKetThucGT.TabIndex = 17;
            // 
            // txtDonGiaGT
            // 
            this.txtDonGiaGT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGiaGT.Location = new System.Drawing.Point(140, 85);
            this.txtDonGiaGT.Name = "txtDonGiaGT";
            this.txtDonGiaGT.Size = new System.Drawing.Size(290, 26);
            this.txtDonGiaGT.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(15, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Đơn giá";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(455, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Ngày bắt đầu:";
            // 
            // btnLamMoiGT
            // 
            this.btnLamMoiGT.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnLamMoiGT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoiGT.FlatAppearance.BorderColor = System.Drawing.Color.MediumSpringGreen;
            this.btnLamMoiGT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnLamMoiGT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnLamMoiGT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoiGT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoiGT.ForeColor = System.Drawing.Color.Black;
            this.btnLamMoiGT.Location = new System.Drawing.Point(640, 150);
            this.btnLamMoiGT.Name = "btnLamMoiGT";
            this.btnLamMoiGT.Size = new System.Drawing.Size(150, 35);
            this.btnLamMoiGT.TabIndex = 9;
            this.btnLamMoiGT.Text = "Làm mới";
            this.btnLamMoiGT.UseVisualStyleBackColor = false;
            // 
            // btnXoaGT
            // 
            this.btnXoaGT.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnXoaGT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaGT.FlatAppearance.BorderColor = System.Drawing.Color.MediumSpringGreen;
            this.btnXoaGT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnXoaGT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnXoaGT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaGT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaGT.ForeColor = System.Drawing.Color.Black;
            this.btnXoaGT.Location = new System.Drawing.Point(380, 150);
            this.btnXoaGT.Name = "btnXoaGT";
            this.btnXoaGT.Size = new System.Drawing.Size(150, 35);
            this.btnXoaGT.TabIndex = 9;
            this.btnXoaGT.Text = "Xóa";
            this.btnXoaGT.UseVisualStyleBackColor = false;
            // 
            // btnThemGT
            // 
            this.btnThemGT.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnThemGT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemGT.FlatAppearance.BorderColor = System.Drawing.Color.MediumSpringGreen;
            this.btnThemGT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnThemGT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnThemGT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemGT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemGT.ForeColor = System.Drawing.Color.Black;
            this.btnThemGT.Location = new System.Drawing.Point(120, 150);
            this.btnThemGT.Name = "btnThemGT";
            this.btnThemGT.Size = new System.Drawing.Size(150, 35);
            this.btnThemGT.TabIndex = 9;
            this.btnThemGT.Text = "Thêm ";
            this.btnThemGT.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(455, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Ngày kết thúc:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Loại gói tập:";
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
            this.btnQuayLaiGT.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label1.Location = new System.Drawing.Point(16, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách học viên đăng ký gói tập";
            // 
            // GUI_GoiTap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(968, 611);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "GUI_GoiTap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUI_GoiTap";
            this.Load += new System.EventHandler(this.GUI_GoiTap_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSGoiTap)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvDSGoiTap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpNgayKetThucGT;
        private System.Windows.Forms.TextBox txtDonGiaGT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnLamMoiGT;
        private System.Windows.Forms.Button btnXoaGT;
        private System.Windows.Forms.Button btnThemGT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnQuayLaiGT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbLoaiGT;
        private System.Windows.Forms.DateTimePicker dtpNgayBatDauGT;
    }
}