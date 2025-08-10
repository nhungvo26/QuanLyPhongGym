using DAL_QLPG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QLPG
{
    public class BUS_HocVien_LopHoc
    {

        DAL_HocVien_LopHoc dl = new DAL_HocVien_LopHoc();
        public int soLuongConTrong(int idLopHoc)
        {
            return dl.soLuongConTrong(idLopHoc);
        }
    }
}
