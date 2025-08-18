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
    public class BUS_ThanhToan
    {
        DAL_ThanhToan dalThanhToan = new DAL_ThanhToan();

        public DataTable xemIdHVThanhToan(int idHVTT)
        {
            return dalThanhToan.xemIdHVThanhToan(idHVTT);
        }

        public DataTable xemThanhToan()
        {
            return dalThanhToan.xemThanhToan();
        }
    }
}
