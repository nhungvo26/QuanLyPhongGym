using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLPG
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new DangNhap());
            while (true)
            {
                DangNhap dangNhap = new DangNhap();
                DialogResult kqDN = dangNhap.ShowDialog();  // Form login trả về OK nếu đăng nhập thành công

                if (kqDN == DialogResult.OK)
                {
                    TrangChu trangChu = new TrangChu();
                    DialogResult kq = trangChu.ShowDialog(); // Nếu người dùng bấm Đăng xuất thì quay lại

                    if (kq != DialogResult.Retry)
                    {
                        break; // Thoát ứng dụng
                    }
                }
                else
                {
                    break; // Đóng từ form login -> thoát ứng dụng
                }
            }
        }
    }
}
