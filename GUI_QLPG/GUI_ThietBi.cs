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
    public partial class GUI_ThietBi : Form
    {
        BUS_ThietBi busThietBi = new BUS_ThietBi();

        public GUI_ThietBi()
        {
            InitializeComponent();
        }

        private void GUI_ThietBi_Load(object sender, EventArgs e)
        {
            hienThiDSThietBi();
            hienThiTheLoaiThietBi();
            hienThiDSPhongTap();
            hienThiTrangThaiThietBi();
        }

        private void hienThiDSThietBi()
        {
            dgvDSThietBi.DataSource = busThietBi.xemThietBi();
        }

        private void hienThiTheLoaiThietBi()
        {
            try
            {
                var theLoai = busThietBi.xemTheLoaiThietBi();
                if (theLoai == null || theLoai.Rows.Count == 0)
                {
                    MessageBox.Show("Không có thể loại nào trong hệ thống.");
                    return;
                }
                cbLoaiTB.DataSource = theLoai;
                cbLoaiTB.DisplayMember = "tenTLTB";
                cbLoaiTB.ValueMember = "idTLTB";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void hienThiDSPhongTap()
        {
            try
            {
                var phongTap = busThietBi.xemPhongTap();
                if (phongTap == null || phongTap.Rows.Count == 0)
                {
                    MessageBox.Show("Không có phòng tập đang hoạt động trong hệ thống.");
                    return;
                }
                cbPhongTap.DataSource = phongTap;
                cbPhongTap.DisplayMember = "tenPhongTap";
                cbPhongTap.ValueMember = "idPhongTap";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void hienThiTrangThaiThietBi()
        {
            cbTrangThaiTB.Items.AddRange(new string[] { "Tốt", "Cần bảo trì", "Hư hỏng" });
            cbTrangThaiTB.SelectedIndex = 0;
        }

        private void dgvDSThietBi_Click(object sender, EventArgs e)
        {
            //Lấy row hiện tại 
            DataGridViewRow row = dgvDSThietBi.SelectedRows[0];
            //Chuyển các giá trị lên form
            txtTenTB.Text = row.Cells[1].Value.ToString();
            txtDonGiaTB.Text = row.Cells[2].Value.ToString();
            dtpNgayMuaTB.Value = Convert.ToDateTime(row.Cells[3].Value);
            cbTrangThaiTB.Text = row.Cells[4].Value.ToString();
            cbLoaiTB.Text = row.Cells[5].Value.ToString();
            cbPhongTap.Text = row.Cells[6].Value.ToString();
        }

        private void btnThemTB_Click(object sender, EventArgs e)
        {
            if (txtTenTB.Text != "" && cbLoaiTB.Items.Count > 0 && txtDonGiaTB.Text != ""
                && cbTrangThaiTB.Items.Count > 0 && cbPhongTap.Items.Count > 0)
            {
                ThietBi tBi = new ThietBi(0, txtTenTB.Text.Trim(),
                                        Convert.ToInt32(cbLoaiTB.SelectedValue),
                                        decimal.TryParse(txtDonGiaTB.Text, out decimal gia) ? gia : 0,
                                        dtpNgayMuaTB.Value,
                                        cbTrangThaiTB.Text.Trim(),
                                        Convert.ToInt32(cbPhongTap.SelectedValue));
                int kq = busThietBi.themThietBi(tBi);
                if (kq > 0)
                {
                    MessageBox.Show("Thêm thiết bị thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    hienThiDSThietBi();
                }
                else
                {
                    MessageBox.Show("Thêm thiết bị thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSuaTB_Click(object sender, EventArgs e)
        {
            if (dgvDSThietBi.SelectedRows.Count > 0)
            {
                if (txtTenTB.Text != "" && cbLoaiTB.Items.Count > 0 && txtDonGiaTB.Text != ""
                    && cbTrangThaiTB.Items.Count > 0 && cbPhongTap.Items.Count > 0)
                {
                    DataGridViewRow row = dgvDSThietBi.SelectedRows[0];
                    ThietBi tBi = new ThietBi(Convert.ToInt32(row.Cells[0].Value.ToString()),
                                            txtTenTB.Text.Trim(),
                                            Convert.ToInt32(cbLoaiTB.SelectedValue),
                                            decimal.TryParse(txtDonGiaTB.Text, out decimal gia) ? gia : 0,
                                            dtpNgayMuaTB.Value,
                                            cbTrangThaiTB.Text.Trim(),
                                            Convert.ToInt32(cbPhongTap.SelectedValue));
                    int kq = busThietBi.suaThietBi(tBi);
                    if (kq > 0)
                    {
                        MessageBox.Show("Sửa thiết bị thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        hienThiDSThietBi();
                    }
                    else
                    {
                        MessageBox.Show("Sửa thiết bị thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn thiết bị muốn sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoaTB_Click(object sender, EventArgs e)
        {
            if (dgvDSThietBi.SelectedRows.Count > 0)
            {
                //int idTB = Convert.ToInt32(dgvDSThietBi.CurrentRow.Cells["idThietBi"].Value);
                DataGridViewRow row = dgvDSThietBi.SelectedRows[0];
                int idTB = Convert.ToInt32(row.Cells[0].Value.ToString());
                //string tenTB = row.Cells[1].Value.ToString();
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?",
                    "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int kq = busThietBi.xoaThietBi(idTB);
                    if (kq > 0)
                    {
                        MessageBox.Show("Xóa thiết bị thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        hienThiDSThietBi();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thiết bị thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn thiết bị muốn xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLamMoiTB_Click(object sender, EventArgs e)
        {
            txtTenTB.Clear();
            if (cbLoaiTB.Items.Count > 0)
                cbLoaiTB.SelectedIndex = 0;
            txtDonGiaTB.Clear();
            dtpNgayMuaTB.Value = DateTime.Now;
            if (cbTrangThaiTB.Items.Count > 0)
                cbTrangThaiTB.SelectedIndex = 0;
            if (cbPhongTap.Items.Count > 0)
                cbPhongTap.SelectedIndex = 0;
        }

        private void btnTimKiemTB_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiemTB.Text.Trim();
            if (string.IsNullOrEmpty(tuKhoa))
            {
                MessageBox.Show("Hãy nhập từ khóa để tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            dgvDSThietBi.DataSource = busThietBi.timKiemThietBi(tuKhoa);
        }
    }
}
