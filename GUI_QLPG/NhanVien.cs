using BUS_QLPG;
using DTO_QLPG;
using GUI_QLPG.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLPG
{
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
            //DataGridViewStyleHelper.ApplyCustomStyle(dgvChinhSuaNV);
            this.Load += Nhanvien_Load;

        }

        private BUS_NhanVien nhanvienBL = new BUS_NhanVien();
        private BindingSource NhanVienBindingSource = new BindingSource();
        
        private void Nhanvien_Load(object sender, EventArgs e)
        {
            LoadDanhSachNhanVien();
            DinhDangDanhSachNhanVien();
            cboRole.Items.Clear(); // Xóa dữ liệu cũ (nếu có)

            // Thêm vai trò vào ComboBox
            cboRole.Items.AddRange(new[] { "Admin", "Huấn luyện viên", "Lễ tân", "Nhân viên kỹ thuật" });

            cboRole.SelectedIndex = 0;
            cboGioiTinh.Items.Add("Nam");
            cboGioiTinh.Items.Add("Nữ");

            // Tuỳ chọn: set giá trị mặc định
            cboGioiTinh.SelectedIndex = 0; // Mặc định chọn "Nam"

            //btThemNV.Visible = false;
            //  btCapNhatNV.Visible = false;
            // btXoaNV.Visible = false;
            // btClearNV.Visible = false;
        }

        private void DinhDangDanhSachNhanVien()
        {
            
            dgvChinhSuaNV.AutoGenerateColumns = false;
            dgvChinhSuaNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChinhSuaNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (dgvChinhSuaNV.Columns.Count > 0)
            {
                dgvChinhSuaNV.Columns[nameof(NguoiDung.idNguoiDung)].HeaderText = "Mã nhân viên";
                dgvChinhSuaNV.Columns[nameof(NguoiDung.username)].HeaderText = "Tên đăng nhập";
                dgvChinhSuaNV.Columns[nameof(NguoiDung.FullName)].HeaderText = "Họ tên";
                dgvChinhSuaNV.Columns[nameof(NguoiDung.gioiTinh)].HeaderText = "Giới tính";
                dgvChinhSuaNV.Columns[nameof(NguoiDung.ngaySinh)].HeaderText = "Ngày sinh";
                dgvChinhSuaNV.Columns[nameof(NguoiDung.sdt)].HeaderText = "Số điện thoại";
                dgvChinhSuaNV.Columns[nameof(NguoiDung.email)].HeaderText = "Email";
                dgvChinhSuaNV.Columns[nameof(NguoiDung.diaChi)].HeaderText = "Địa chỉ";
                dgvChinhSuaNV.Columns[nameof(NguoiDung.vaiTro)].HeaderText = "Vị trí";
            }
        }

        private void LoadDanhSachNhanVien()
        {
            List<NguoiDung> data = nhanvienBL.XemTatCaNhanVien();
            NhanVienBindingSource.DataSource = data;


            dgvChinhSuaNV.DataSource = NhanVienBindingSource;
            
            if (dgvChinhSuaNV.Columns.Contains("Password"))
                dgvChinhSuaNV.Columns["Password"].Visible = false;
            if (dgvChinhSuaNV.Columns.Contains("HoNguoiDung"))
                dgvChinhSuaNV.Columns["HoNguoiDung"].Visible = false;
            if (dgvChinhSuaNV.Columns.Contains("TenNguoiDung"))
                dgvChinhSuaNV.Columns["TenNguoiDung"].Visible = false;
            DinhDangDanhSachNhanVien();

        }

        private void btThemNV_Click(object sender, EventArgs e)
        {
            // Tách họ và tên
            string[] parts = txtHoVaTenNV.Text.Trim().Split(' ');
            string ho = "";
            string ten = "";

            if (parts.Length > 0)
            {
                ten = parts[parts.Length - 1]; // Lấy từ cuối cùng làm tên
                ho = string.Join(" ", parts.Take(parts.Length - 1)); // Phần còn lại là họ

                NguoiDung newUser = new NguoiDung
                {
                    username = txtTenNV.Text.Trim(),
                    password = txtMatKhauNV.Text.Trim(),
                    hoNguoiDung = ho,
                    tenNguoiDung = ten,
                    gioiTinh= cboGioiTinh.Text.Trim(),
                    ngaySinh = dpNgaySinhNV.Value,
                    sdt = txtSDTNV.Text.Trim(),
                    email = txtEmailNV.Text.Trim(),
                    diaChi = txtDiaChiNV.Text.Trim(),
                    vaiTro = cboRole.Text.Trim() // ví dụ: "Admin", "Lễ tân", "Huấn luyện viên"
                };

                try
                {
                    int newUserId = nhanvienBL.ThemNhanVien(newUser);
                    if (newUserId > 0)
                    {
                        MessageBox.Show("Thêm nhân viên thành công!", "Thành công");
                        LoadDanhSachNhanVien();
                    }
                    else
                    {
                        MessageBox.Show("Thêm nhân viên thất bại!", "Lỗi");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập họ và tên hợp lệ!", "Lỗi");
            }
        }


        private void btnDanhSachNV_Click(object sender, EventArgs e)
        {
           
            LoadDanhSachNhanVien();
         //   btThemNV.Visible = false;
          //  btCapNhatNV.Visible = false;
           // btXoaNV.Visible = false;
         //   btClearNV.Visible = false;
        }

        private void btnChinhSuaNV_Click(object sender, EventArgs e)
        {
            LoadDanhSachNhanVien();
            btThemNV.Visible = true;
            btCapNhatNV.Visible = true;
            btXoaNV.Visible = true;
            btClearNV.Visible = true;
        }

        private void btCapNhatNV_Click(object sender, EventArgs e)
        {
            if (btCapNhatNV.Tag == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int userId = Convert.ToInt32(btCapNhatNV.Tag);

            // Tách họ và tên từ textbox
            string[] parts = txtHoVaTenNV.Text.Trim().Split(' ');
            string ho = "";
            string ten = "";

            if (parts.Length > 0)
            {
                ten = parts[parts.Length - 1]; // Tên là từ cuối cùng
                ho = string.Join(" ", parts.Take(parts.Length - 1)); // Họ là phần còn lại
            }
            
            NguoiDung user = new NguoiDung
            {
                idNguoiDung = userId,
                username = txtTenNV.Text.Trim(),
                hoNguoiDung = ho,
                tenNguoiDung = ten,
                gioiTinh = cboGioiTinh.Text.Trim(),
                ngaySinh = dpNgaySinhNV.Value,
                sdt = txtSDTNV.Text.Trim(),
                email = txtEmailNV.Text.Trim(),
                diaChi = txtDiaChiNV.Text.Trim(),
                vaiTro = cboRole.Text.Trim(),

                
                password = txtMatKhauNV.Text 
            };

            int success = 0;
            try
            {
                success = nhanvienBL.CapNhatNhanVien(user, ho, ten, user.gioiTinh);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (success > 0)
            {
                MessageBox.Show("Cập nhật nhân viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachNhanVien();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btXoaNV_Click(object sender, EventArgs e)
        {
            if (btXoaNV.Tag == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên để xóa!", "Thông báo");
                return;
            }

            if (PhanQuyen.vaiTro != "Chủ phòng gym")
            {
                MessageBox.Show("Chỉ Admin mới có quyền xóa nhân viên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int userId = Convert.ToInt32(btXoaNV.Tag);
            string hoTen = txtHoVaTenNV.Text;

            if (nhanvienBL.KiemTraNhanVienDangDayLop(userId))
            {
                MessageBox.Show("Không thể xóa vì nhân viên này đang phụ trách lớp học!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show($"Bạn có chắc muốn xóa nhân viên \"{hoTen}\" không?", "Xác nhận", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                int success = nhanvienBL.XoaNhanVien(userId);
                if (success > 0)
                {
                    MessageBox.Show("Xóa nhân viên thành công.");
                    LoadDanhSachNhanVien();
                }
                else
                {
                    MessageBox.Show("Xóa nhân viên thất bại.");
                }
            }
        }

        


        private void btClearNV_Click(object sender, EventArgs e)
        {
            txtTenNV.Clear();
            txtMatKhauNV.Clear();
            txtHoVaTenNV.Clear();
            dpNgaySinhNV.Value = DateTime.Now;
            txtSDTNV.Clear();
            txtEmailNV.Clear();
            txtDiaChiNV.Clear();
        }

       

        private void btnSearchNV_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiemNV.Text.Trim();
            if (string.IsNullOrEmpty(tuKhoa))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm.");
                return;
            }

            string loaiTimKiem = rdoSDTNV.Checked ? "sdt" : "ten";

            List<NguoiDung> result = nhanvienBL.TimKiemNhanVien(tuKhoa, loaiTimKiem);
            NhanVienBindingSource.DataSource = result;
            dgvChinhSuaNV.DataSource = NhanVienBindingSource;
            dgvChinhSuaNV.DataSource = NhanVienBindingSource;
        }
        private void dgvChinhSuaNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dgvChinhSuaNV.Rows[e.RowIndex].DataBoundItem is NguoiDung selectedUser)
                {
                    txtTenNV.Text = selectedUser.username;
                    txtMatKhauNV.Text = "";
                    txtHoVaTenNV.Text = selectedUser.FullName;
                    txtEmailNV.Text = selectedUser.email;
                    txtDiaChiNV.Text = selectedUser.diaChi;
                    txtSDTNV.Text = selectedUser.sdt;
                    cboRole.Text = selectedUser.vaiTro;
                    dpNgaySinhNV.Value = selectedUser.ngaySinh ?? DateTime.Now;
                    btCapNhatNV.Tag = selectedUser.idNguoiDung;
                    btXoaNV.Tag = selectedUser.idNguoiDung;
                }
            }
        }

      
    }
}
