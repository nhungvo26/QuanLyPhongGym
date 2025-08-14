using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLPG
{
    public class GoiTap
    {
        public int idHVGT { get; set; }
        public int idHocVien { get; set; }
        public string loaiGoiTap { get; set; }
        public DateTime ngayBatDau { get; set; }
        public DateTime ngayKetThuc { get; set; }
        public decimal donGia { get; set; }
    }
}
