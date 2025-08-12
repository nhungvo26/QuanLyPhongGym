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
    public class DAL_ThietBi : DBConnect
    {
        public DataTable xemThietBi()
        {
            try
            {
                return GetDataTable("XemThietBi", null);
            }     
            catch (Exception ex)
            {
                throw ex;
            }
        } 

        /*public DataTable xemIdThietBi(string id)
        {
            SqlParameter[] para =
            {
                new SqlParameter("idThietBi", id)
            };
            return GetDataTable("XemIdThietBi", para);
        }*/

        public int themThietBi(ThietBi tb)
        {
            try
            {
                SqlParameter[] para =
                {
                    new SqlParameter("tenThietBi", tb.tenThietBi),
                    new SqlParameter("idTLTB", tb.idTLTB),
                    new SqlParameter("donGia", tb.donGia),
                    new SqlParameter("ngayMua", tb.ngayMua),
                    new SqlParameter("trangThai", tb.trangThai),                    
                    new SqlParameter("idPhongTap", tb.idPhongTap)
                };
                return ExecuteSQL("ThemThietBi", para);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int suaThietBi(ThietBi tb)
        {
            try
            {
                SqlParameter[] para =
                {
                    new SqlParameter("idThietBi", tb.idThietBi),
                    new SqlParameter("tenThietBi", tb.tenThietBi),
                    new SqlParameter("idTLTB", tb.idTLTB),
                    new SqlParameter("donGia", tb.donGia),
                    new SqlParameter("ngayMua", tb.ngayMua),
                    new SqlParameter("trangThai", tb.trangThai),                    
                    new SqlParameter("idPhongTap", tb.idPhongTap)
                };
                return ExecuteSQL("SuaThietBi", para);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int xoaThietBi(int id)
        {
            try
            {
                SqlParameter[] para =
                {
                    new SqlParameter("idThietBi", id)
                };
                return ExecuteSQL("XoaThietBi", para);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable xemTheLoaiThietBi()
        {
            try
            {
                return GetDataTable("xemTheLoaiThietBi", null);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable xemPhongTap()
        {
            try
            {
                return GetDataTable("xemPhongTap", null);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable timKiemThietBi(string tuKhoa)
        {
            try
            {
                SqlParameter[] para =
                {
                    new SqlParameter("@tuKhoa", tuKhoa)
                };
                return GetDataTable("TimKiemThietBi", para);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int capNhatTrangThaiThietBi(int idTB, string tThai)
        {
            try
            {
                SqlParameter[] para =
                {
                    new SqlParameter("@idThietBi", idTB),
                    new SqlParameter("@trangThai", tThai)
                };
                return ExecuteSQL("CapNhatTrangThaiThietBi", para);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
