using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLPG;
using DTO_QLPG;

namespace BUS_QLPG
{
    public class BUS_DangNhap
    {
        DAL_DangNhap dalDangNhap = new DAL_DangNhap();
        public NguoiDung kiemTraDangNhap(NguoiDung nd)
        {
            return dalDangNhap.kiemtraDangNhap(nd);
        }
    }
}
