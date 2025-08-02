using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_QLPG
{
    public class PhanQuyen
    {
        public static int idNguoiDung { get; set; }
        public static string username { get; set; }
        public static string vaiTro { get; set; }
        public static void Clear()
        {
            idNguoiDung = 0;
            username = null;
            vaiTro = null;
        }
    }
}
