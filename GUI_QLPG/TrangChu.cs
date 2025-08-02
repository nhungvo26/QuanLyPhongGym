using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLPG
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {
            kiemTraVaiTro();
        }

        public void kiemTraVaiTro()
        {
            string vaiTro = PhanQuyen.vaiTro;
            if (vaiTro == "Chủ phòng gym")
            {
                btnHocVien.Enabled = false;
                btnLopHoc.Enabled = false;
                btnThanhToan.Enabled = false;
                btnThietBi.Enabled = false;
            }
            else if (vaiTro == "Lễ tân")
            {
                btnNhanVien.Enabled = false;
                btnThietBi.Enabled = false;
                btnThongKe.Enabled = false;
                btnThongBao.Enabled = false;
            }
            else if (vaiTro == "Nhân viên kỹ thuật")
            {
                btnNhanVien.Enabled = false;
                btnHocVien.Enabled = false;
                btnLopHoc.Enabled = false;
                btnThanhToan.Enabled = false;
                btnThongKe.Enabled = false;
                btnThongBao.Enabled = false;
            }
            else if (vaiTro == "Huấn luyện viên")
            {
                btnNhanVien.Enabled = false;
                btnHocVien.Enabled = false;
                btnThietBi.Enabled = false;
                btnThanhToan.Enabled = false;
                btnThongKe.Enabled = false;
                btnThongBao.Enabled = false;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                PhanQuyen.Clear();
                MessageBox.Show("Bạn đã đăng xuất thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.Retry;
                this.Close();
            }
        }
    }
}
