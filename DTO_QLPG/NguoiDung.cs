using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLPG
{
    public class NguoiDung
    {
        public int idNguoiDung { get; set; }
        public string hoNguoiDung { get; set; }
        public string tenNguoiDung { get; set; }
        public string gioiTinh { get; set; }
        public DateTime? ngaySinh { get; set; }
        public string sdt { get; set; }
        public string email { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string vaiTro { get; set; }  

        public NguoiDung() { }

        public NguoiDung(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
    }
}
