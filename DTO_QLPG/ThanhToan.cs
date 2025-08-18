using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLPG
{
    public class ThanhToan
    {
        public int idHoaDon { get; set; }
        public int idHocVien { get; set; }
        public decimal donGia { get; set; }
        public string phuongThucThanhToan { get; set; }
        public string loaiThanhToan { get; set; }
        public DateTime ngayThanhToan { get; set; }
        public int idDKLH { get; set; }
	}
}
