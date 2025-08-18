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
    public partial class GUI_HocVien : Form
    {
        BUS_HocVien busHocVien = new BUS_HocVien();
        BUS_GoiTap busGoiTap = new BUS_GoiTap();

        public GUI_HocVien()
        {
            InitializeComponent();
        }

        private void GUI_HocVien_Load(object sender, EventArgs e)
        {
            hienThiDSHocVien();
        }

        private void hienThiDSHocVien()
        {
            dgvDSHocVien.DataSource = busHocVien.xemHocVien();
        }

        private void dgvDSHocVien_Click(object sender, EventArgs e)
        {
            try
            {
                //Lấy row hiện tại 
                DataGridViewRow row = dgvDSHocVien.SelectedRows[0];
                //Chuyển các giá trị lên form
                txtTenHV.Text = row.Cells[1].Value.ToString();
                rbNamHV.Checked = row.Cells[2].Value.ToString() == "Nam";
                rbNuHV.Checked = row.Cells[2].Value.ToString() == "Nữ";
                dtpNgaySinhHV.Value = Convert.ToDateTime(row.Cells[3].Value);
                txtSdtHV.Text = row.Cells[4].Value.ToString();
                txtEmailHV.Text = row.Cells[5].Value.ToString();
                txtDiaChiHV.Text = row.Cells[6].Value.ToString();
                dtpNgayTGHV.Value = Convert.ToDateTime(row.Cells[7].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnThemHV_Click(object sender, EventArgs e)
        {
            if (txtTenHV.Text != "" && txtSdtHV.Text != "" && txtEmailHV.Text != "" && txtDiaChiHV.Text != "")
            {
                HocVien hVien = new HocVien(0, txtTenHV.Text.Trim(), rbNamHV.Checked ? "Nam" : "Nữ", dtpNgaySinhHV.Value,
                                        txtSdtHV.Text.Trim(), txtEmailHV.Text.Trim(), txtDiaChiHV.Text.Trim(), dtpNgayTGHV.Value);
                int kq = busHocVien.themHocVien(hVien);
                if (kq > 0)
                {
                    MessageBox.Show("Thêm học viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    hienThiDSHocVien();
                }
                else
                {
                    MessageBox.Show("Thêm học viên thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSuaHV_Click(object sender, EventArgs e)
        {
            if (dgvDSHocVien.SelectedRows.Count > 0)
            {
                if (txtTenHV.Text != "" && txtSdtHV.Text != "" && txtEmailHV.Text != "" && txtDiaChiHV.Text != "")
                {
                    DataGridViewRow row = dgvDSHocVien.SelectedRows[0];
                    HocVien hVien = new HocVien(Convert.ToInt32(row.Cells[0].Value.ToString()), txtTenHV.Text.Trim(),
                                            rbNamHV.Checked ? "Nam" : "Nữ", dtpNgaySinhHV.Value, txtSdtHV.Text.Trim(),
                                            txtEmailHV.Text.Trim(), txtDiaChiHV.Text.Trim(), dtpNgayTGHV.Value);
                    int kq = busHocVien.suaHocVien(hVien);
                    if (kq > 0)
                    {
                        MessageBox.Show("Sửa học viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        hienThiDSHocVien();
                    }
                    else
                    {
                        MessageBox.Show("Sửa học viên thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn học viên muốn sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoaHV_Click(object sender, EventArgs e)
        {
            if (dgvDSHocVien.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvDSHocVien.SelectedRows[0];
                int idHV = Convert.ToInt32(row.Cells[0].Value.ToString());
                string tenHV = row.Cells[1].Value.ToString();
                if (busHocVien.kiemTraGoiTapHieuLuc(idHV) > 0)
                {
                    MessageBox.Show($"Không thể xóa học viên {tenHV} vì vẫn đang có gói tập còn hiệu lực.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show($"Bạn có chắc chắn muốn xóa học viên {tenHV} không?",
                    "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int kq = busHocVien.xoaHocVien(idHV);
                    if (kq > 0)
                    {
                        MessageBox.Show($"Xóa học viên {tenHV} thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        hienThiDSHocVien();
                    }
                    else
                    {
                        MessageBox.Show($"Xóa học viên {tenHV} thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn học viên muốn xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLamMoiHV_Click(object sender, EventArgs e)
        {
            txtTenHV.Clear();
            dtpNgaySinhHV.Value = DateTime.Now;
            txtSdtHV.Clear();
            txtEmailHV.Clear();
            txtDiaChiHV.Clear();
            dtpNgayTGHV.Value = DateTime.Now;
        }

        private void btnTimKiemHV_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiemHV.Text.Trim();
            if (string.IsNullOrEmpty(tuKhoa))
            {
                MessageBox.Show("Hãy nhập từ khóa để tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            dgvDSHocVien.DataSource = busHocVien.timKiemHocVien(tuKhoa);
        }

        private void btnGoiTap_Click(object sender, EventArgs e)
        {            
            if (dgvDSHocVien.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvDSHocVien.SelectedRows[0];
                int idHV = Convert.ToInt32(row.Cells[0].Value);
                string tenHV = row.Cells[1].Value.ToString();

                GUI_GoiTap formGT = new GUI_GoiTap(idHV, tenHV);

                if (formGT.ShowDialog() == DialogResult.OK)
                {
                    // Nếu thêm gói tập thành công, thêm vào database
                    GoiTap goiTapMoi = formGT.goiTapMoi;
                    if (goiTapMoi != null)
                    {
                        int kq = busGoiTap.themGoiTap(goiTapMoi);
                        if (kq > 0)
                        {
                            MessageBox.Show($"Đã thêm gói tập {goiTapMoi.loaiGoiTap} cho học viên {tenHV} thành công!",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Thêm gói tập thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }            
            else
            {
                MessageBox.Show("Hãy chọn học viên để thêm gói tập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
