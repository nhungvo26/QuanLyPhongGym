using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLPG
{
    public class DTO_HLV
    {
      
        // Thông tin người dùng (liên kết qua idNguoiDung)
        public int idNguoiDung { get; set; }

        // Thông tin người dùng - mở rộng (có thể lấy từ bảng NguoiDung)
        public string HoNguoiDung { get; set; }
        public string TenNguoiDung { get; set; }
        public string Sdt { get; set; }
        public string Email { get; set; }

        // Vai trò (có thể lấy từ NhanVien hoặc NguoiDung)
        public List<string> DanhSachLopHoc { get; set; }


        public DTO_HLV()
        {
            DanhSachLopHoc = new List<string>();
        }

        public DTO_HLV(int idNguoiDung, string hoNguoiDung, string tenNguoiDung, string sdt, string email, List<string> dTO_LopHoc)
        {
            this.idNguoiDung = idNguoiDung;
            HoNguoiDung = hoNguoiDung;
            TenNguoiDung = tenNguoiDung;
            Sdt = sdt;
            Email = email;
            DanhSachLopHoc = DanhSachLopHoc ?? new List<string>();
        }
    }
}
