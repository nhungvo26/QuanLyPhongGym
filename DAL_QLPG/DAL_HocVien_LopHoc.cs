using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLPG
{
    public class DAL_HocVien_LopHoc :DBConnect
    {
        public int soLuongConTrong(int idLopHoc)
        {
            int slots = 0;
            string sql = @"
        SELECT 
            (l.soLuongHV - COUNT(hvlh.idHocVien)) AS soLuongConTrong
        FROM LopHoc l
        LEFT JOIN HocVien_LopHoc hvlh 
            ON l.idLopHoc = hvlh.idLopHoc 
            AND hvlh.trangThai = N'Đang hoạt động'
        WHERE l.idLopHoc = @idLopHoc
        GROUP BY l.soLuongHV";

            try
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@idLopHoc", idLopHoc);
                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                        slots = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }

            return slots;
        }

    }
}
