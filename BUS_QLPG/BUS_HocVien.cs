using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLPG;
using DTO_QLPG;
using System.Data;

namespace BUS_QLPG
{
    public class BUS_HocVien
    {
        DAL_HocVien dalHocVien = new DAL_HocVien();

        public DataTable xemHocVien()
        {
            return dalHocVien.xemHocVien();
        }

        public int themHocVien(HocVien hv)
        {
            return dalHocVien.themHocVien(hv);
        }

        public int suaHocVien(HocVien hv)
        {
            return dalHocVien.suaHocVien(hv);
        }

        public int xoaHocVien(int id)
        {
            return dalHocVien.xoaHocVien(id);
        }

        public DataTable timKiemHocVien(string tuKhoa)
        {
            return dalHocVien.timKiemHocVien(tuKhoa);
        }
        public DataTable layHocVienChuaCoLop()
        {
            return dalHocVien.layHocVienChuaCoLop();
        }
        public DataTable LayHocVienTheoLop(int idLopHoc)
        {
            return dalHocVien.LayHocVienTheoLop(idLopHoc);
        }
    }
}

