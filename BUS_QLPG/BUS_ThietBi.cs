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
    public class BUS_ThietBi
    {
        DAL_ThietBi dalThietBi = new DAL_ThietBi();
        public DataTable xemThietBi()
        {
            return dalThietBi.xemThietBi();
        }

        /*public DataTable xemIdThietBi(string id)
        {
            return dalThietBi.xemIdThietBi(id);
        }*/

        public int themThietBi(ThietBi tb)
        {
            return dalThietBi.themThietBi(tb);
        }

        public int suaThietBi(ThietBi tb)
        {
            return dalThietBi.suaThietBi(tb);
        }

        public int xoaThietBi(int id)
        {
            return dalThietBi.xoaThietBi(id);
        }

        public DataTable xemTheLoaiThietBi()
        {
            return dalThietBi.xemTheLoaiThietBi();
        }

        public DataTable xemPhongTap()
        {
            return dalThietBi.xemPhongTap();
        }

        public DataTable timKiemThietBi(string tuKhoa)
        {
            return dalThietBi.timKiemThietBi(tuKhoa);
        }

        public int capNhatTrangThaiThietBi(int idTB, string tThai)
        {
            return dalThietBi.capNhatTrangThaiThietBi(idTB, tThai);
        }
     }
}
