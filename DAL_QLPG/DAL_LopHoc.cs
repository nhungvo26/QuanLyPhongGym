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
        // Lấy tất cả lớp học
        //public List<DTO_LopHoc> LayTatCaLopHoc()
        //{
        //    List<DTO_LopHoc> dsLop = new List<DTO_LopHoc>();

        //    try
        //    {
        //        conn.Open();
        //        SqlCommand cmd = new SqlCommand("usp_LayTatCaLopHoc", conn);
        //        cmd.CommandType = CommandType.StoredProcedure;

        //        SqlDataReader dr = cmd.ExecuteReader();
        //        while (dr.Read())
        //        {
        //            DTO_LopHoc lop = new DTO_LopHoc
        //            {
        //                idLopHoc = Convert.ToInt32(dr["idLopHoc"]),
        //                tenLopHoc = dr["tenLopHoc"].ToString(),
        //                idTLLH = Convert.ToInt32(dr["idTLLH"]),
        //                idHLV = Convert.ToInt32(dr["idHLV"]),
        //                lichHoc = dr["lichHoc"].ToString(),
        //                soLuongHV = Convert.ToInt32(dr["soLuongHV"]),
        //                donGia = Convert.ToDecimal(dr["donGia"]),
        //                ngayBatDau = Convert.ToDateTime(dr["ngayBatDau"]),
        //                ngayKetThuc = Convert.ToDateTime(dr["ngayKetThuc"]),
        //                moTa = dr["moTa"].ToString(),
        //                //idPhongTap = Convert.ToInt32(dr["idPhongTap"])
        //            };
        //            dsLop.Add(lop);
        //        }
        //        dr.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }

        //    return dsLop;
        //}
        public List<DTO_LopHoc> LayTatCaLopHoc()
        {
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
                    dsLop.Add(lop);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dsLop;
        }


        // Lấy lớp học theo ID
        //public DTO_LopHoc LayLopHocTheoID(int id)
        //{
        //    DTO_LopHoc lop = null;
        //    try
        //    {
        //        conn.Open();
        //        SqlCommand cmd = new SqlCommand("usp_LayLopHocTheoID", conn);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@idLopHoc", id);

        //        SqlDataReader dr = cmd.ExecuteReader();
        //        if (dr.Read())
        //        {
        //            lop = new DTO_LopHoc
        //            {
        //                idLopHoc = Convert.ToInt32(dr["idLopHoc"]),
        //                tenLopHoc = dr["tenLopHoc"].ToString(),
        //                idTLLH = Convert.ToInt32(dr["idTLLH"]),
        //                idHLV = Convert.ToInt32(dr["idHLV"]),
        //                lichHoc = dr["lichHoc"].ToString(),
        //                soLuongHV = Convert.ToInt32(dr["soLuongHV"]),
        //                donGia = Convert.ToDecimal(dr["donGia"]),
        //                ngayBatDau = Convert.ToDateTime(dr["ngayBatDau"]),
        //                ngayKetThuc = Convert.ToDateTime(dr["ngayKetThuc"]),
        //                moTa = dr["moTa"].ToString(),
        //                idPhongTap = Convert.ToInt32(dr["idPhongTap"])
        //            };
        //        }
        //        dr.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //    return lop;
        //}

        //// Lấy lớp học theo HLV
        //public List<DTO_LopHoc> LayLopHocTheoHLV(int idHLV)
        //{
        //    List<DTO_LopHoc> dsLop = new List<DTO_LopHoc>();
        //    try
        //    {
        //        conn.Open();
        //        SqlCommand cmd = new SqlCommand("usp_LayLopHocTheoHLV", conn);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@idHLV", idHLV);

        //        SqlDataReader dr = cmd.ExecuteReader();
        //        while (dr.Read())
        //        {
        //            DTO_LopHoc lop = new DTO_LopHoc
        //            {
        //                idLopHoc = Convert.ToInt32(dr["idLopHoc"]),
        //                tenLopHoc = dr["tenLopHoc"].ToString(),
        //                idTLLH = Convert.ToInt32(dr["idTLLH"]),
        //                idHLV = Convert.ToInt32(dr["idHLV"]),
        //                lichHoc = dr["lichHoc"].ToString(),
        //                soLuongHV = Convert.ToInt32(dr["soLuongHV"]),
        //                donGia = Convert.ToDecimal(dr["donGia"]),
        //                ngayBatDau = Convert.ToDateTime(dr["ngayBatDau"]),
        //                ngayKetThuc = Convert.ToDateTime(dr["ngayKetThuc"]),
        //                moTa = dr["moTa"].ToString(),
        //                idPhongTap = Convert.ToInt32(dr["idPhongTap"])
        //            };
        //            dsLop.Add(lop);
        //        }
        //        dr.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //    return dsLop;
        //}
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



        // Thêm lớp học
        //public int ThemLopHoc(DTO_LopHoc lop)
        //{
        //    int kq = 0;
        //    try
        //    {
        //        conn.Open();
        //        SqlCommand cmd = new SqlCommand("usp_ThemLopHoc", conn);
        //        cmd.CommandType = CommandType.StoredProcedure;

        //        cmd.Parameters.AddWithValue("@tenLopHoc", lop.tenLopHoc);
        //        cmd.Parameters.AddWithValue("@idTLLH", lop.idTLLH);
        //        cmd.Parameters.AddWithValue("@idHLV", lop.idHLV);
        //        cmd.Parameters.AddWithValue("@lichHoc", lop.lichHoc);
        //        cmd.Parameters.AddWithValue("@soLuongHV", lop.soLuongHV);
        //        cmd.Parameters.AddWithValue("@donGia", lop.donGia);
        //        cmd.Parameters.AddWithValue("@ngayBatDau", lop.ngayBatDau);
        //        cmd.Parameters.AddWithValue("@ngayKetThuc", lop.ngayKetThuc);
        //        cmd.Parameters.AddWithValue("@moTa", lop.moTa);
        //        //  cmd.Parameters.AddWithValue("@idPhongTap", lop.idPhongTap);

        //        kq = cmd.ExecuteNonQuery();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //    return kq;
        //}
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


        // Cập nhật lớp học
        //public int CapNhatLopHoc(DTO_LopHoc lop)
        //{
        //    int kq = 0;
        //    try
        //    {
        //        conn.Open();
        //        SqlCommand cmd = new SqlCommand("usp_CapNhatLopHoc", conn);
        //        cmd.CommandType = CommandType.StoredProcedure;

        //        cmd.Parameters.AddWithValue("@idLopHoc", lop.idLopHoc);
        //        cmd.Parameters.AddWithValue("@tenLopHoc", lop.tenLopHoc);
        //        cmd.Parameters.AddWithValue("@idTLLH", lop.idTLLH);
        //        cmd.Parameters.AddWithValue("@idHLV", lop.idHLV);
        //        cmd.Parameters.AddWithValue("@lichHoc", lop.lichHoc);
        //        cmd.Parameters.AddWithValue("@soLuongHV", lop.soLuongHV);
        //        cmd.Parameters.AddWithValue("@donGia", lop.donGia);
        //        cmd.Parameters.AddWithValue("@ngayBatDau", lop.ngayBatDau);
        //        cmd.Parameters.AddWithValue("@ngayKetThuc", lop.ngayKetThuc);
        //        cmd.Parameters.AddWithValue("@moTa", lop.moTa);
        //        //cmd.Parameters.AddWithValue("@idPhongTap", lop.idPhongTap);

        //        kq = cmd.ExecuteNonQuery();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //    return kq;
        //}
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


        // Xóa lớp học
        //public int XoaLopHoc(int idLopHoc)
        //{
        //    int kq = 0;
        //    try
        //    {
        //        conn.Open();
        //        SqlCommand cmd = new SqlCommand("usp_XoaLopHoc", conn);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@idLopHoc", idLopHoc);

        //        kq = cmd.ExecuteNonQuery();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //    return kq;
        //}
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

    }
}
