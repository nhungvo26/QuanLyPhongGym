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
        public List<DTO_LopHoc> LayTatCaLopHoc()
        {
            List<DTO_LopHoc> dsLop = new List<DTO_LopHoc>();

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("usp_LayTatCaLopHoc", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    DTO_LopHoc lop = new DTO_LopHoc
                    {
                        idLopHoc = Convert.ToInt32(dr["idLopHoc"]),
                        tenLopHoc = dr["tenLopHoc"].ToString(),
                        idTLLH = Convert.ToInt32(dr["idTLLH"]),
                        idHLV = Convert.ToInt32(dr["idHLV"]),
                        lichHoc = dr["lichHoc"].ToString(),
                        soLuongHV = Convert.ToInt32(dr["soLuongHV"]),
                        donGia = Convert.ToDecimal(dr["donGia"]),
                        ngayBatDau = Convert.ToDateTime(dr["ngayBatDau"]),
                        ngayKetThuc = Convert.ToDateTime(dr["ngayKetThuc"]),
                        moTa = dr["moTa"].ToString(),
                        //idPhongTap = Convert.ToInt32(dr["idPhongTap"])
                    };
                    dsLop.Add(lop);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }

            return dsLop;
        }

        // Lấy lớp học theo ID
        public DTO_LopHoc LayLopHocTheoID(int id)
        {
            DTO_LopHoc lop = null;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("usp_LayLopHocTheoID", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idLopHoc", id);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    lop = new DTO_LopHoc
                    {
                        idLopHoc = Convert.ToInt32(dr["idLopHoc"]),
                        tenLopHoc = dr["tenLopHoc"].ToString(),
                        idTLLH = Convert.ToInt32(dr["idTLLH"]),
                        idHLV = Convert.ToInt32(dr["idHLV"]),
                        lichHoc = dr["lichHoc"].ToString(),
                        soLuongHV = Convert.ToInt32(dr["soLuongHV"]),
                        donGia = Convert.ToDecimal(dr["donGia"]),
                        ngayBatDau = Convert.ToDateTime(dr["ngayBatDau"]),
                        ngayKetThuc = Convert.ToDateTime(dr["ngayKetThuc"]),
                        moTa = dr["moTa"].ToString(),
                        idPhongTap = Convert.ToInt32(dr["idPhongTap"])
                    };
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return lop;
        }
        // Lấy lớp học theo HLV
        public List<DTO_LopHoc> LayLopHocTheoHLV(int idHLV)
        {
            List<DTO_LopHoc> dsLop = new List<DTO_LopHoc>();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("usp_LayLopHocTheoHLV", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idHLV", idHLV);

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    DTO_LopHoc lop = new DTO_LopHoc
                    {
                        idLopHoc = Convert.ToInt32(dr["idLopHoc"]),
                        tenLopHoc = dr["tenLopHoc"].ToString(),
                        idTLLH = Convert.ToInt32(dr["idTLLH"]),
                        idHLV = Convert.ToInt32(dr["idHLV"]),
                        lichHoc = dr["lichHoc"].ToString(),
                        soLuongHV = Convert.ToInt32(dr["soLuongHV"]),
                        donGia = Convert.ToDecimal(dr["donGia"]),
                        ngayBatDau = Convert.ToDateTime(dr["ngayBatDau"]),
                        ngayKetThuc = Convert.ToDateTime(dr["ngayKetThuc"]),
                        moTa = dr["moTa"].ToString(),
                        idPhongTap = Convert.ToInt32(dr["idPhongTap"])
                    };
                    dsLop.Add(lop);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return dsLop;
        }


        // Thêm lớp học
        public int ThemLopHoc(DTO_LopHoc lop)
        {
            int kq = 0;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("usp_ThemLopHoc", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@tenLopHoc", lop.tenLopHoc);
                cmd.Parameters.AddWithValue("@idTLLH", lop.idTLLH);
                cmd.Parameters.AddWithValue("@idHLV", lop.idHLV);
                cmd.Parameters.AddWithValue("@lichHoc", lop.lichHoc);
                cmd.Parameters.AddWithValue("@soLuongHV", lop.soLuongHV);
                cmd.Parameters.AddWithValue("@donGia", lop.donGia);
                cmd.Parameters.AddWithValue("@ngayBatDau", lop.ngayBatDau);
                cmd.Parameters.AddWithValue("@ngayKetThuc", lop.ngayKetThuc);
                cmd.Parameters.AddWithValue("@moTa", lop.moTa);
              //  cmd.Parameters.AddWithValue("@idPhongTap", lop.idPhongTap);

                kq = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return kq;
        }

        // Cập nhật lớp học
        public int CapNhatLopHoc(DTO_LopHoc lop)
        {
            int kq = 0;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("usp_CapNhatLopHoc", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idLopHoc", lop.idLopHoc);
                cmd.Parameters.AddWithValue("@tenLopHoc", lop.tenLopHoc);
                cmd.Parameters.AddWithValue("@idTLLH", lop.idTLLH);
                cmd.Parameters.AddWithValue("@idHLV", lop.idHLV);
                cmd.Parameters.AddWithValue("@lichHoc", lop.lichHoc);
                cmd.Parameters.AddWithValue("@soLuongHV", lop.soLuongHV);
                cmd.Parameters.AddWithValue("@donGia", lop.donGia);
                cmd.Parameters.AddWithValue("@ngayBatDau", lop.ngayBatDau);
                cmd.Parameters.AddWithValue("@ngayKetThuc", lop.ngayKetThuc);
                cmd.Parameters.AddWithValue("@moTa", lop.moTa);
                //cmd.Parameters.AddWithValue("@idPhongTap", lop.idPhongTap);

                kq = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return kq;
        }

        // Xóa lớp học
        public int XoaLopHoc(int idLopHoc)
        {
            int kq = 0;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("usp_XoaLopHoc", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idLopHoc", idLopHoc);

                kq = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return kq;
        }
    }
}
