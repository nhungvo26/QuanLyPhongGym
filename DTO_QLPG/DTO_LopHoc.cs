using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLPG
{
    public class DTO_LopHoc
    {
        public int idLopHoc { get; set; }
        public string tenLopHoc { get; set; }
        public int idTLLH { get; set; }
        public int idHLV { get; set; }
        public string lichHoc { get; set; }
        public int soLuongHV { get; set; }
        public int soLuongConTrong { get; set; }
        public decimal donGia { get; set; }
        public DateTime ngayBatDau { get; set; }
        public DateTime ngayKetThuc { get; set; }
        public string moTa { get; set; }
        public int idPhongTap { get; set; }
        public DTO_LopHoc() { }
        public DTO_LopHoc(int idLopHoc, string tenLopHoc, int idTLLH, int idHLV, string lichHoc, int soLuongHV, decimal donGia, DateTime ngayBatDau, DateTime ngayKetThuc, string moTa, int idPhongTap)
        {
            this.idLopHoc = idLopHoc;
            this.tenLopHoc = tenLopHoc;
            this.idTLLH = idTLLH;
            this.idHLV = idHLV;
            this.lichHoc = lichHoc;
            this.soLuongHV = soLuongHV;
            this.donGia = donGia;
            this.ngayBatDau = ngayBatDau;
            this.ngayKetThuc = ngayKetThuc;
            this.moTa = moTa;
            this.idPhongTap = idPhongTap;
        }
        public class StudentCountByCategory
        {
            public string CategoryName { get; set; }
            public int StudentCount { get; set; }
        }
    }
}
