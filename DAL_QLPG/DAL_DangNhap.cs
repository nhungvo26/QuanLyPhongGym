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
    public class DAL_DangNhap : DBConnect
    {
        /*public string kiemTraDangNhap(NguoiDung nd)
        {
            string user = null;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("KiemTraDangNhap", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("username", nd.username);
                cmd.Parameters.AddWithValue("password", nd.password);
                cmd.Connection = conn;
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.HasRows)
                {
                    while(dr.Read())
                    {
                        user = dr.GetString(0);
                    }
                    dr.Close();
                }
                else
                {
                    return "Tài khoản hoặc mật khẩu không đúng!";
                }
            }
            catch(Exception ex) 
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return user;
        }*/
        public NguoiDung kiemtraDangNhap(NguoiDung nd)
        {
            NguoiDung user = null;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("KiemTraDangNhap", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("username", nd.username);
                cmd.Parameters.AddWithValue("password", nd.password);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    user = new NguoiDung
                    {
                        idNguoiDung = Convert.ToInt32(dr["idNguoiDung"]),
                        username = dr["username"].ToString(),
                        vaiTro = dr["vaiTro"].ToString()
                    };
                }
                dr.Close();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return user;
        }
   }
}
