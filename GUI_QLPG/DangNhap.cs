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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username và Password không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                NguoiDung ndDangNhap = new NguoiDung(username, password);
                BUS_DangNhap busDangNhap = new BUS_DangNhap();
                NguoiDung kq = busDangNhap.kiemTraDangNhap(ndDangNhap);
                if(kq != null)
                {
                    PhanQuyen.idNguoiDung = kq.idNguoiDung;
                    PhanQuyen.username = kq.username;
                    PhanQuyen.vaiTro = kq.vaiTro;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ckbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = ckbShowPassword.Checked ? '\0' : '*';
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnLogin;
        }
    }
}
