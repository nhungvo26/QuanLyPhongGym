using DTO_QLPG;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLPG.Helpers
{
    public static class DataGridViewStyleHelper
    {
        public static void ApplyCustomStyle(DataGridView dgv)
        {
            dgv.BorderStyle = BorderStyle.None;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(40, 96, 144);
            dgv.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgv.BackgroundColor = Color.White;

            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
        }
        public static void FormatClassDGV(DataGridView dataGridView)
        {
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.Columns["idLopHoc"].HeaderText = "Mã lớp";
            dataGridView.Columns["tenLopHoc"].HeaderText = "Tên lớp";
            dataGridView.Columns["idTLLH"].HeaderText = "Loại hình lớp học";
            dataGridView.Columns["idHLV"].HeaderText = "Mã HLV phụ trách";
            dataGridView.Columns["lichHoc"].HeaderText = "Lịch học";
            dataGridView.Columns["soLuongHV"].HeaderText = "Số học viên tối đa";
            dataGridView.Columns["soLuongConTrong"].HeaderText = "Số lượng còn trống";
            dataGridView.Columns["donGia"].HeaderText = "Giá";
            dataGridView.Columns["ngayBatDau"].HeaderText = "Ngày bắt đầu";
            dataGridView.Columns["ngayKetThuc"].HeaderText = "Ngày kết thúc";
            dataGridView.Columns["moTa"].HeaderText = "Mô tả";
        }
        public static void FormatStudentDGV(DataGridView dataGridView)
        {

            dataGridView.Columns["StudentId"].HeaderText = "Mã học viên";
            dataGridView.Columns["FullName"].HeaderText = "Họ tên học viên";
            dataGridView.Columns["DOB"].HeaderText = "Ngày sinh";
            dataGridView.Columns["Gender"].HeaderText = "Giới tính";
            dataGridView.Columns["Phone"].HeaderText = "Số điện thoại";
            dataGridView.Columns["Email"].HeaderText = "Email";
            dataGridView.Columns["Address"].HeaderText = "Địa chỉ";
            dataGridView.Columns["RegisteredDate"].HeaderText = "Ngày đăng ký";
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public static void FormatMembershipDGV(DataGridView dataGridView)
        {
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.Columns["UserId"].HeaderText = "Mã HV";
            dataGridView.Columns["Fullname"].HeaderText = "Họ tên";
            dataGridView.Columns["Packagetype"].HeaderText = "Gói tập";
            dataGridView.Columns["Price"].HeaderText = "Giá";
            dataGridView.Columns["Startdate"].HeaderText = "Ngày bắt đầu";
            dataGridView.Columns["Enddate"].HeaderText = "Ngày kết thúc";
            dataGridView.Columns["ClassNames"].Visible = false;
        }
        public static void DinhDangDanhSachNhanVien(DataGridView dataGridView)
        {
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (dataGridView.Columns.Count > 0)
            {
                dataGridView.Columns[nameof(NguoiDung.idNguoiDung)].HeaderText = "Mã nhân viên";
                dataGridView.Columns[nameof(NguoiDung.username)].HeaderText = "Tên đăng nhập";
                dataGridView.Columns[nameof(NguoiDung.hoNguoiDung)].HeaderText = "Họ";
                dataGridView.Columns[nameof(NguoiDung.tenNguoiDung)].HeaderText = "Tên";
                dataGridView.Columns[nameof(NguoiDung.ngaySinh)].HeaderText = "Ngày sinh";
                dataGridView.Columns[nameof(NguoiDung.sdt)].HeaderText = "Số điện thoại";
                dataGridView.Columns[nameof(NguoiDung.email)].HeaderText = "Email";
                dataGridView.Columns[nameof(NguoiDung.diaChi)].HeaderText = "Địa chỉ";
                dataGridView.Columns[nameof(NguoiDung.vaiTro)].HeaderText = "Vị trí";
            }
        }

    }
}
