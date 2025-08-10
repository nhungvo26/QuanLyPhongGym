using DAL_QLPG;
using DTO_QLPG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QLPG
{
    public class BUS_HLV
    {
        private DAL_HLV dalHLV = new DAL_HLV();

        // Lấy danh sách HLV
        public List<DTO_HLV> LayDanhSachHLV()
        {
            return dalHLV.LayDanhSachHLV();
        }

        // Lấy HLV theo Id
        public DTO_HLV LayHLVTheoId(int idNguoiDung)
        {
            return dalHLV.LayHLVTheoId(idNguoiDung);
        }

        // Lấy HLV theo tên
        public DTO_HLV LayHLVTheoTen(string tenNguoiDung)
        {
            return dalHLV.LayHLVTheoTen(tenNguoiDung);
        }
        public List<DTO_HLV> LayDanhSachHLVCoThe(DateTime ngayBatDauMoi, DateTime ngayKetThucMoi, string lichHocMoi)
        {
            return dalHLV.LayDanhSachHLVCoThe(ngayBatDauMoi, ngayKetThucMoi, lichHocMoi);
        }

    }
}
