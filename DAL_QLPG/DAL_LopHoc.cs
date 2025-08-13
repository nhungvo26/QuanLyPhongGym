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
    public class DAL_LopHoc : DBConnect
    {
  
        public List<DTO_LopHoc> LayTatCaLopHoc()
        {
            DAL_HocVien_LopHoc dalHV_LopHoc = new DAL_HocVien_LopHoc();
            List<DTO_LopHoc> dsLop = new List<DTO_LopHoc>();
            try
            {
                // Gọi stored procedure lấy DataTable
                DataTable dt = GetDataTable("usp_LayTatCaLopHoc", null);

                // Duyệt từng dòng trong DataTable để tạo danh sách DTO
                foreach (DataRow row in dt.Rows)
                {
                    DTO_LopHoc lop = new DTO_LopHoc
                    {
                        idLopHoc = Convert.ToInt32(row["idLopHoc"]),
                        tenLopHoc = row["tenLopHoc"].ToString(),
                        idTLLH = Convert.ToInt32(row["idTLLH"]),
                        idHLV = Convert.ToInt32(row["idHLV"]),
                        lichHoc = row["lichHoc"].ToString(),
                        soLuongHV = Convert.ToInt32(row["soLuongHV"]),
                        donGia = Convert.ToDecimal(row["donGia"]),
                        ngayBatDau = Convert.ToDateTime(row["ngayBatDau"]),
                        ngayKetThuc = Convert.ToDateTime(row["ngayKetThuc"]),
                        moTa = row["moTa"] == DBNull.Value ? null : row["moTa"].ToString(),
                        // idPhongTap = row["idPhongTap"] == DBNull.Value ? 0 : Convert.ToInt32(row["idPhongTap"])
                    };
                    lop.soLuongConTrong = dalHV_LopHoc.soLuongConTrong(lop.idLopHoc);
                    dsLop.Add(lop);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dsLop;
        }



        public List<DTO_LopHoc> LayLopHocTheoHLV(int idHLV)
        {
            List<DTO_LopHoc> dsLop = new List<DTO_LopHoc>();
            try
            {
                // Tạo tham số cho stored procedure
                SqlParameter[] para = {
            new SqlParameter("idHLV", idHLV)
        };

                // Lấy DataTable từ stored procedure
                DataTable dt = GetDataTable("usp_LayLopHocTheoHLV", para);

                // Duyệt từng dòng và map vào DTO_LopHoc
                foreach (DataRow row in dt.Rows)
                {
                    DTO_LopHoc lop = new DTO_LopHoc
                    {
                        idLopHoc = Convert.ToInt32(row["idLopHoc"]),
                        tenLopHoc = row["tenLopHoc"].ToString(),
                        idTLLH = Convert.ToInt32(row["idTLLH"]),
                        idHLV = Convert.ToInt32(row["idHLV"]),
                        lichHoc = row["lichHoc"].ToString(),
                        soLuongHV = Convert.ToInt32(row["soLuongHV"]),
                        donGia = Convert.ToDecimal(row["donGia"]),
                        ngayBatDau = Convert.ToDateTime(row["ngayBatDau"]),
                        ngayKetThuc = Convert.ToDateTime(row["ngayKetThuc"]),
                        moTa = row["moTa"] == DBNull.Value ? null : row["moTa"].ToString(),
                        idPhongTap = row["idPhongTap"] == DBNull.Value ? 0 : Convert.ToInt32(row["idPhongTap"])
                    };
                    dsLop.Add(lop);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dsLop;
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
                        idHLV = Convert.ToInt32(row["idHLV"]),
                        lichHoc = row["lichHoc"].ToString(),
                        soLuongHV = Convert.ToInt32(row["soLuongHV"]),
                        donGia = Convert.ToDecimal(row["donGia"]),
                        ngayBatDau = Convert.ToDateTime(row["ngayBatDau"]),
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



        public int ThemLopHoc(DTO_LopHoc lop)
        {
            try
            {
                SqlParameter[] para =
                {
            new SqlParameter("tenLopHoc", lop.tenLopHoc),
            new SqlParameter("idTLLH", lop.idTLLH),
            new SqlParameter("idHLV", lop.idHLV),
            new SqlParameter("lichHoc", lop.lichHoc),
            new SqlParameter("soLuongHV", lop.soLuongHV),
            new SqlParameter("donGia", lop.donGia),
            new SqlParameter("ngayBatDau", lop.ngayBatDau),
            new SqlParameter("ngayKetThuc", lop.ngayKetThuc),
            new SqlParameter("moTa", lop.moTa),

        };
                return ExecuteSQL("usp_ThemLopHoc", para);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public int CapNhatLopHoc(DTO_LopHoc lop)
        {
            try
            {
                SqlParameter[] para =
                {
            new SqlParameter("idLopHoc", lop.idLopHoc),
            new SqlParameter("tenLopHoc", lop.tenLopHoc),
            new SqlParameter("idTLLH", lop.idTLLH),
            new SqlParameter("idHLV", lop.idHLV),
            new SqlParameter("lichHoc", lop.lichHoc),
            new SqlParameter("soLuongHV", lop.soLuongHV),
            new SqlParameter("donGia", lop.donGia),
            new SqlParameter("ngayBatDau", lop.ngayBatDau),
            new SqlParameter("ngayKetThuc", lop.ngayKetThuc),
            new SqlParameter("moTa", lop.moTa),

        };
                return ExecuteSQL("usp_CapNhatLopHoc", para);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public int XoaLopHoc(int idLopHoc)
        {
            try
            {
                SqlParameter[] para = {
            new SqlParameter("idLopHoc", idLopHoc)
        };
                return ExecuteSQL("usp_XoaLopHoc", para);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int ThemHocVienVaoLop(int idHocVien, int idLopHoc)
        {
            SqlParameter[] para =
            {
        new SqlParameter("@idHocVien", idHocVien),
        new SqlParameter("@idLopHoc", idLopHoc),
        new SqlParameter("@ResultCode", SqlDbType.Int) { Direction = ParameterDirection.Output }
    };

            ExecuteSQL("usp_ThemHocVienVaoLop", para);
            return (int)para[2].Value; // 0: OK, 1: Lớp đầy, 2: Đã tồn tại
        }

        public bool KiemTraSiSo(int idLop)
        {
            try
            {
                SqlParameter[] para = { new SqlParameter("@idLop", idLop) };
                DataTable dt = GetDataTable("KiemTraSiSo", para); // Store này trả về 1 row chứa SoLuongConLai
                if (dt.Rows.Count > 0)
                {
                    int soLuongConLai = Convert.ToInt32(dt.Rows[0]["SoLuongConLai"]);
                    return soLuongConLai > 0;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
