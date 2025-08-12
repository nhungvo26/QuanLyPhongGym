using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLPG
{
    public class ThietBi
    {
        public int idThietBi { get; set; }
        public string tenThietBi { get; set; }
        public decimal donGia { get; set; }
        public DateTime ngayMua { get; set; }
        public string trangThai { get; set; }
        public int idTLTB { get; set; }
        public int idPhongTap { get; set; }

        public ThietBi() { }

        public ThietBi(int idThietBi, string tenThietBi, int idTLTB, decimal donGia, DateTime ngayMua, string trangThai, int idPhongTap)
        {
            this.idThietBi = idThietBi;
            this.tenThietBi = tenThietBi;
            this.idTLTB = idTLTB;
            this.donGia = donGia;
            this.ngayMua = ngayMua;
            this.trangThai = trangThai;
            this.idPhongTap = idPhongTap;
        }
    }
}
