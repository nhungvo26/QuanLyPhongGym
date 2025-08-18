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
    public class BUS_GoiTap
    {
        DAL_GoiTap dalGoiTap = new DAL_GoiTap();

        public DataTable xemDSHVDKGoiTap()
        {
            return dalGoiTap.xemDSHVDKGoiTap();
        }

        public List<TheLoaiGoiTap> xemLoaiGoiTap()
        {
            return dalGoiTap.xemLoaiGoiTap();
        }

        public int themGoiTap(GoiTap gt)
        {
            return dalGoiTap.themGoiTap(gt);
        }

        public int xoaGoiTap(int idHV)
        {
            return dalGoiTap.xoaGoiTap(idHV);
        }

        public GoiTap layGoiTapHienTai(int idHV)
        {
            return dalGoiTap.layGoiTapHienTai(idHV);
        }

        public int kiemTraGoiTapHieuLuc(int idHV)
        {
            return dalGoiTap.kiemTraGoiTapHieuLuc(idHV);
        }

        public bool con1TuanTruocHetHan(GoiTap gt)
        {
            return (gt != null && (gt.ngayKetThuc - DateTime.Now).TotalDays <= 7);
        }
    }
}
