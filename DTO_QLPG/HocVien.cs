using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLPG
{
    public class HocVien
    {
        public int idHocVien { get; set; }
        public string tenHocVien { get; set; }
        public string gioiTinh { get; set; }
        public DateTime ngaySinh { get; set; }
        public string sdt { get; set; }
        public string email { get; set; }
        public string diaChi { get; set; }
        public DateTime ngayThamGia { get; set; }

        public HocVien() { }

        public HocVien(int idHocVien, string tenHocVien, string gioiTinh, DateTime ngaySinh, string sdt, string email, string diaChi, DateTime ngayThamGia)
        {
            this.idHocVien = idHocVien;
            this.tenHocVien = tenHocVien;
            this.gioiTinh = gioiTinh;
            this.ngaySinh = ngaySinh;
            this.sdt = sdt;
            this.email = email;
            this.diaChi = diaChi;
            this.ngayThamGia = ngayThamGia;
        }
    }
}
