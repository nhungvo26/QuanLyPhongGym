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
    public class DAL_GoiTap : DBConnect
    {
        public DataTable xemDSHVDKGoiTap()
        {
            try
            {
                return GetDataTable("XemDSHVDKGoiTap", null);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<TheLoaiGoiTap> xemLoaiGoiTap()
        {
            List<TheLoaiGoiTap> dsTLGT = new List<TheLoaiGoiTap>();
            try
            {
                DataTable dt = GetDataTable("XemLoaiGoiTap", null);
                foreach (DataRow row in dt.Rows)
                {
                    string loaiGoi = row["loaiGoiTap"].ToString();
                    int thang = 1;
                    if (loaiGoi == "1 tháng") thang = 1;
                    else if (loaiGoi == "3 tháng") thang = 3;
                    else if (loaiGoi == "6 tháng") thang = 6;
                    else if (loaiGoi == "12 tháng") thang = 12;

                    dsTLGT.Add(new TheLoaiGoiTap
                    {
                        loaiGoiTap = loaiGoi,
                        thang = thang,
                        donGia = Convert.ToDecimal(row["donGia"])
                    });
                }
                return dsTLGT;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int themGoiTap(GoiTap gt)
        {
            try
            {
                SqlParameter[] para = 
                {
                    new SqlParameter("idHocVien", gt.idHocVien),
                    new SqlParameter("loaiGoiTap", gt.loaiGoiTap),
                    new SqlParameter("ngayBatDau", gt.ngayBatDau),
                    new SqlParameter("ngayKetThuc", gt.ngayKetThuc),
                    new SqlParameter("donGia", gt.donGia),
                };
                return ExecuteSQL("ThemGoiTap", para);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int xoaGoiTap(int idHV)
        {
            try
            {
                SqlParameter[] para =
                {
                    new SqlParameter("idHocVien", idHV),
                };
                return ExecuteSQL("XoaGoiTap", para);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public GoiTap layGoiTapHienTai(int idHV)
        {
            try
            {
                SqlParameter[] para =
                {
                    new SqlParameter("idHocVien", idHV)
                };
                DataTable dt = GetDataTable("LayGoiTapHienTai", para);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    return new GoiTap
                    {
                        idHVGT = Convert.ToInt32(row["idHVGT"]),
                        idHocVien = Convert.ToInt32(row["idHocVien"]),
                        loaiGoiTap = row["loaiGoiTap"].ToString(),
                        ngayBatDau = Convert.ToDateTime(row["ngayBatDau"]),
                        ngayKetThuc = Convert.ToDateTime(row["ngayKetThuc"]),
                        donGia = Convert.ToDecimal(row["donGia"])
                    };
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DTO_LopHoc LayLopHocTheoID(int id)
        {
            DTO_LopHoc lop = null;
            try
            {
                SqlParameter[] para = { new SqlParameter("idLopHoc", id) };
                DataTable dt = GetDataTable("usp_LayLopHocTheoID", para);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    lop = new DTO_LopHoc
                    {
                        idLopHoc = Convert.ToInt32(row["idLopHoc"]),
                        tenLopHoc = row["tenLopHoc"].ToString(),
                        idTLLH = Convert.ToInt32(row["idTLLH"]),                        
                        ngayKetThuc = Convert.ToDateTime(row["ngayKetThuc"]),
                        moTa = row["moTa"] == DBNull.Value ? null : row["moTa"].ToString(),
                        idPhongTap = row["idPhongTap"] == DBNull.Value ? 0 : Convert.ToInt32(row["idPhongTap"])
                    };
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lop;
        }

        public int kiemTraGoiTapHieuLuc(int idHV)
        {
            try
            {
                SqlParameter[] para =
                {
                    new SqlParameter("idHocVien", idHV),
                };
                return ExecuteSQL("KiemTraGoiTapHieuLuc", para);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
