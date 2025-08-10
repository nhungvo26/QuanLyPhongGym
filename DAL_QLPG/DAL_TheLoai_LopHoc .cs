using DTO_QLPG;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLPG
{
    public class DAL_TheLoai_LopHoc : DBConnect
    {
        public List<TheLoaiLopHoc> GetAllCategories()
        {
            List<TheLoaiLopHoc> categories = new List<TheLoaiLopHoc>();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("GetAllCategories", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    TheLoaiLopHoc category  = new TheLoaiLopHoc
                    {
                        idTLLH = Convert.ToInt32(reader["idTLLH"]),
                        tenTLLH = reader["tenTLLH"].ToString()
                    };
                    categories.Add(category);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return categories;
        }

    }
}
