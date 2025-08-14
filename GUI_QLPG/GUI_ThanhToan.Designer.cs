
namespace GUI_QLPG
{
    partial class GUI_ThanhToan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_ThanhToan));
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvDSThanhToan = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimKiemTT = new System.Windows.Forms.TextBox();
            this.btnTimKiemTT = new System.Windows.Forms.Button();
            this.btnNhacNhoTT = new System.Windows.Forms.Button();
            this.btnLichSuGiaoDich = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSThanhToan)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dgvDSThanhToan);
            this.panel2.Location = new System.Drawing.Point(21, 190);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(930, 280);
            this.panel2.TabIndex = 7;
            // 
            // dgvDSThanhToan
            // 
            this.dgvDSThanhToan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSThanhToan.Location = new System.Drawing.Point(15, 15);
            this.dgvDSThanhToan.Name = "dgvDSThanhToan";
            this.dgvDSThanhToan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSThanhToan.Size = new System.Drawing.Size(900, 250);
            this.dgvDSThanhToan.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnTimKiemTT);
            this.panel1.Controls.Add(this.btnLichSuGiaoDich);
            this.panel1.Controls.Add(this.btnNhacNhoTT);
            this.panel1.Controls.Add(this.btnThanhToan);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtTimKiemTT);
            this.panel1.Location = new System.Drawing.Point(17, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(930, 300);
            this.panel1.TabIndex = 6;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.Transparent;
            this.btnThanhToan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThanhToan.FlatAppearance.BorderColor = System.Drawing.Color.MediumSpringGreen;
            this.btnThanhToan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnThanhToan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.btnThanhToan.Location = new System.Drawing.Point(120, 90);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(140, 30);
            this.btnThanhToan.TabIndex = 8;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách thanh toán";
            // 
            // txtTimKiemTT
            // 
            this.txtTimKiemTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemTT.Location = new System.Drawing.Point(279, 18);
            this.txtTimKiemTT.Name = "txtTimKiemTT";
            this.txtTimKiemTT.Size = new System.Drawing.Size(342, 26);
            this.txtTimKiemTT.TabIndex = 4;
            // 
            // btnTimKiemTT
            // 
            this.btnTimKiemTT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTimKiemTT.BackgroundImage")));
            this.btnTimKiemTT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimKiemTT.Location = new System.Drawing.Point(628, 17);
            this.btnTimKiemTT.Name = "btnTimKiemTT";
            this.btnTimKiemTT.Size = new System.Drawing.Size(30, 28);
            this.btnTimKiemTT.TabIndex = 11;
            this.btnTimKiemTT.UseVisualStyleBackColor = true;
            // 
            // btnNhacNhoTT
            // 
            this.btnNhacNhoTT.BackColor = System.Drawing.Color.Transparent;
            this.btnNhacNhoTT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNhacNhoTT.FlatAppearance.BorderColor = System.Drawing.Color.MediumSpringGreen;
            this.btnNhacNhoTT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnNhacNhoTT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnNhacNhoTT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhacNhoTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhacNhoTT.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.btnNhacNhoTT.Location = new System.Drawing.Point(690, 90);
            this.btnNhacNhoTT.Name = "btnNhacNhoTT";
            this.btnNhacNhoTT.Size = new System.Drawing.Size(140, 30);
            this.btnNhacNhoTT.TabIndex = 8;
            this.btnNhacNhoTT.Text = "Nhắc nhở";
            this.btnNhacNhoTT.UseVisualStyleBackColor = false;
            // 
            // btnLichSuGiaoDich
            // 
            this.btnLichSuGiaoDich.BackColor = System.Drawing.Color.Transparent;
            this.btnLichSuGiaoDich.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLichSuGiaoDich.FlatAppearance.BorderColor = System.Drawing.Color.MediumSpringGreen;
            this.btnLichSuGiaoDich.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnLichSuGiaoDich.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnLichSuGiaoDich.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLichSuGiaoDich.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLichSuGiaoDich.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.btnLichSuGiaoDich.Location = new System.Drawing.Point(380, 90);
            this.btnLichSuGiaoDich.Name = "btnLichSuGiaoDich";
            this.btnLichSuGiaoDich.Size = new System.Drawing.Size(200, 30);
            this.btnLichSuGiaoDich.TabIndex = 8;
            this.btnLichSuGiaoDich.Text = "Lịch sử giao dịch";
            this.btnLichSuGiaoDich.UseVisualStyleBackColor = false;
            // 
            // GUI_ThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(968, 501);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "GUI_ThanhToan";
            this.Text = "GUI_ThanhToan";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSThanhToan)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvDSThanhToan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTimKiemTT;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTimKiemTT;
        private System.Windows.Forms.Button btnLichSuGiaoDich;
        private System.Windows.Forms.Button btnNhacNhoTT;
    }
}