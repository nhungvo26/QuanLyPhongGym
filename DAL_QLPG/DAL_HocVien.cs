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
    public class DAL_HocVien : DBConnect
    {
        public DataTable xemHocVien()
        {
            try
            {
                return GetDataTable("XemHocVien", null);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int themHocVien(HocVien hv)
        {
            try
            {
                SqlParameter[] para =
                {
                    new SqlParameter("tenHocVien", hv.tenHocVien),
                    new SqlParameter("gioiTinh", hv.gioiTinh),
                    new SqlParameter("ngaySinh", hv.ngaySinh),
                    new SqlParameter("sdt", hv.sdt),
                    new SqlParameter("email", hv.email),
                    new SqlParameter("diaChi", hv.diaChi),
                    new SqlParameter("ngayThamGia", hv.ngayThamGia)
                };
                return ExecuteSQL("ThemHocVien", para);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int suaHocVien(HocVien hv)
        {
            try
            {
                SqlParameter[] para =
                {
                    new SqlParameter("idHocVien", hv.idHocVien),
                    new SqlParameter("tenHocVien", hv.tenHocVien),
                    new SqlParameter("gioiTinh", hv.gioiTinh),
                    new SqlParameter("ngaySinh", hv.ngaySinh),
                    new SqlParameter("sdt", hv.sdt),
                    new SqlParameter("email", hv.email),
                    new SqlParameter("diaChi", hv.diaChi),
                    new SqlParameter("ngayThamGia", hv.ngayThamGia)
                };
                return ExecuteSQL("SuaHocVien", para);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int xoaHocVien(int id)
        {
            try
            {
                SqlParameter[] para =
                {
                    new SqlParameter("idHocVien", id),
                };
                return ExecuteSQL("XoaHocVien", para);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable timKiemHocVien(string tuKhoa)
        {
            try
            {
                SqlParameter[] para =
                {
                    new SqlParameter("@tuKhoa", tuKhoa)
                };
                return GetDataTable("TimKiemHocVien", para);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable layHocVienChuaCoLop()
        {
            try
            {
                // Không có tham số nên để null
                return GetDataTable("sp_GetHocVienChuaCoLop", null);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable LayHocVienTheoLop(int idLopHoc)
        {
            SqlParameter[] para = {
                new SqlParameter("@idLopHoc", idLopHoc)
            };
            return GetDataTable("usp_LayHocVienTheoLop", para);
        }

        public int kiemTraGoiTapHieuLuc(int idHV)
        {
            try
            {
                SqlParameter[] para =
                {
                    new SqlParameter("idHocVien", idHV),
                };
                DataTable kq = GetDataTable("KiemTraGoiTapHieuLuc", para);
                return Convert.ToInt32(kq.Rows[0]["soLuong"]);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

