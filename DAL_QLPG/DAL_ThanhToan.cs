using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO_QLPG;

namespace DAL_QLPG
{
    public class DAL_ThanhToan : DBConnect
    {
        public DataTable xemIdHVThanhToan(int idHVTT)
        {
            try
            {
                SqlParameter[] para =
                {
                    new SqlParameter("idHocVien", idHVTT)
                };
                return GetDataTable("XemIdHVThanhToan", para);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable xemThanhToan()
        {
            try
            {                
                return GetDataTable("XemThanhToan", null);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
