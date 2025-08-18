using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QLPG;
using DTO_QLPG;
using System.Data.SqlClient;

namespace GUI_QLPG
{
    public partial class GUI_GoiTap : Form
    {
        BUS_GoiTap busGoiTap = new BUS_GoiTap();
        public GoiTap goiTapMoi { get; private set; }
        private int idHV;
        private string tenHV;

        //Constructor mặc định (để hiển thị danh sách gói tập)
        public GUI_GoiTap()
        {
            InitializeComponent();
            this.idHV = 0;
            this.tenHV = "";
        }

        //Constructor với tham số (để thêm gói tập cho học viên cụ thể)
        public GUI_GoiTap(int idHocVien, string tenHocVien)
        {
            InitializeComponent();
            this.idHV = idHocVien;
            this.tenHV = tenHocVien;
        }

        private void GUI_GoiTap_Load(object sender, EventArgs e)
        {
            hienThiLoaiGoiTap();
            hienThiDSHVDKGoiTap();
            cbLoaiGT.SelectedIndexChanged += cbLoaiGT_SelectedIndexChanged;            
        }

        private void hienThiDSHVDKGoiTap()
        {
            dgvDSGoiTap.DataSource = busGoiTap.xemDSHVDKGoiTap();
        }

        private void hienThiLoaiGoiTap()
        {
            try
            {
                List<TheLoaiGoiTap> loaiGT = busGoiTap.xemLoaiGoiTap();
                cbLoaiGT.DataSource = loaiGT;
                cbLoaiGT.DisplayMember = "loaiGoiTap";
                cbLoaiGT.ValueMember = "loaiGoiTap";

                if(loaiGT.Count > 0)
                {
                    cbLoaiGT.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Không có loại gói tập nào trong hệ thống.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void cbLoaiGT_SelectedIndexChanged(object sender, EventArgs e)
        {
            var chonGT = cbLoaiGT.SelectedItem as TheLoaiGoiTap;
            if (chonGT == null) return;

            DateTime ngayBD = dtpNgayBatDauGT.Value;
            dtpNgayKetThucGT.Value = ngayBD.AddMonths(chonGT.thang);
            txtDonGiaGT.Text = chonGT.donGia.ToString();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            //Nếu đang trong chế độ thêm gói tập cho học viên cụ thể
            if (idHV > 0)
            {
                DialogResult = DialogResult.Cancel;
            }
            else
            {
                this.Close();
            }
        }

        private void dgvDSGoiTap_Click(object sender, EventArgs e)
        {
            //Chỉ cho phép click vào danh sách nếu không phải chế độ thêm gói tập
            if (idHV == 0)
            {
                //Lấy row hiện tại 
                DataGridViewRow row = dgvDSGoiTap.SelectedRows[0];
                //Chuyển các giá trị lên form
                cbLoaiGT.Text = row.Cells[2].Value.ToString();
                txtDonGiaGT.Text = row.Cells[3].Value.ToString();
                dtpNgayBatDauGT.Value = Convert.ToDateTime(row.Cells[4].Value);
                dtpNgayKetThucGT.Value = Convert.ToDateTime(row.Cells[5].Value);
            }
        }

        private void btnLamMoiGT_Click(object sender, EventArgs e)
        {
            if (cbLoaiGT.Items.Count > 0)
                cbLoaiGT.SelectedIndex = 0;            
            txtDonGiaGT.Clear();
            dtpNgayBatDauGT.Value = DateTime.Now;
            dtpNgayKetThucGT.Value = DateTime.Now;
        }

        private void btnThemGT_Click(object sender, EventArgs e)
        {
            var chonGT = cbLoaiGT.SelectedItem as TheLoaiGoiTap;
            if (chonGT == null)
            {
                MessageBox.Show("Hãy chọn loại gói tập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Nếu đang ở chế độ thêm gói tập cho học viên cụ thể
            if (idHV > 0)
            {
                // Kiểm tra xem học viên đã có gói tập còn hiệu lực chưa
                GoiTap gtHienTai = busGoiTap.layGoiTapHienTai(idHV);
                if (gtHienTai != null && gtHienTai.ngayKetThuc >= DateTime.Now)
                {
                    if (busGoiTap.con1TuanTruocHetHan(gtHienTai))
                    {
                        MessageBox.Show("Gói tập của học viên này sắp hết hạn trong vòng 1 tuần.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show($"Học viên {tenHV} vẫn còn gói tập hiệu lực đến {gtHienTai.ngayKetThuc:dd/MM/yyyy}",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }                                       
                }

                goiTapMoi = new GoiTap
                {
                    idHocVien = idHV,
                    loaiGoiTap = chonGT.loaiGoiTap,
                    ngayBatDau = dtpNgayBatDauGT.Value.Date,
                    ngayKetThuc = dtpNgayKetThucGT.Value.Date,
                    donGia = chonGT.donGia
                };
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Chức năng này chỉ hoạt động khi thêm gói tập cho học viên cụ thể!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXoaGT_Click(object sender, EventArgs e)
        {
            if (dgvDSGoiTap.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvDSGoiTap.SelectedRows[0];
                int idHV = Convert.ToInt32(row.Cells[0].Value.ToString());                

                if (MessageBox.Show($"Bạn có chắc chắn muốn xóa gói tập của học viên {tenHV} không?",
                    "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int kq = busGoiTap.xoaGoiTap(idHV);
                    if (kq > 0)
                    {
                        MessageBox.Show("Xóa gói tập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        hienThiDSHVDKGoiTap();
                    }
                    else
                    {
                        MessageBox.Show("Xóa gói tập thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn học viên muốn xóa gói tập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }        
    }    
}
