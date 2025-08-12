using DAL_QLPG;
using DTO_QLPG;
using System;
using System.Collections.Generic;

namespace BUS_QLPG
{
    public class BUS_NhanVien
    {
        private DAL_NhanVien dal = new DAL_NhanVien();

        public List<NguoiDung> XemTatCaNhanVien()
        {
            return dal.XemTatCaNhanVien();
        }

        public int ThemNhanVien(NguoiDung user)
        {
            if (string.IsNullOrWhiteSpace(user.username) ||
                string.IsNullOrWhiteSpace($"{user.hoNguoiDung}{user.tenNguoiDung}".Trim()))
            {
                throw new ArgumentException("Tên đăng nhập và họ tên không được để trống.");
            }

            if (dal.KiemTraTrung(user.username, user.email))
            {
                throw new Exception("Tên đăng nhập hoặc email đã tồn tại.");
            }

            
            int newUserId = dal.ThemNhanVien(user, user.hoNguoiDung, user.tenNguoiDung, user.gioiTinh);

            if (newUserId <= 0)
            {
                throw new Exception("Thêm nhân viên thất bại.");
            }


            return newUserId;
        }

        public int CapNhatNhanVien(NguoiDung user, string hoNguoiDung, string tenNguoiDung, string gioiTinh = null)
        {
            if (user.idNguoiDung <= 0)
            {
                throw new ArgumentException("ID nhân viên không hợp lệ.");
            }
            return dal.CapNhatNhanVien(user, hoNguoiDung, tenNguoiDung, gioiTinh);
        }


        public int XoaNhanVien(int userId)
        {
            if (userId <= 0)
            {
                throw new ArgumentException("ID nhân viên không hợp lệ.");
            }

            return dal.XoaNhanVien(userId);
        }
        public List<NguoiDung> TimKiemNhanVien(string tuKhoa, string loaiTimKiem)
        {
            bool theoSDT = loaiTimKiem.Equals("SDT", StringComparison.OrdinalIgnoreCase);
            return dal.TimKiemNhanVien(tuKhoa, theoSDT);
        }
        public bool KiemTraNhanVienDangDayLop(int userId)
        {
            return dal.NhanVienDangDayLop(userId);
        }

    }
}
