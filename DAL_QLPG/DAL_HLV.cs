using DAL_QLPG.Helpers;
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
   public class DAL_HLV : DBConnect
    {
        //public List<DTO_HLV> LayDanhSachHLV()
        //{
        //    List<DTO_HLV> danhSachHLV = new List<DTO_HLV>();

        //    try
        //    {
        //        conn.Open();
        //        SqlCommand cmd = new SqlCommand("LayDanhSachHuanLuyenVien", conn);
        //        cmd.CommandType = CommandType.StoredProcedure;

        //        SqlDataReader dr = cmd.ExecuteReader();

        //        // Dùng dictionary để gom lớp học theo HLV
        //        Dictionary<int, DTO_HLV> mapHLV = new Dictionary<int, DTO_HLV>();

        //        while (dr.Read())
        //        {
        //            int idNguoiDung = Convert.ToInt32(dr["idNguoiDung"]);
        //            string hoNguoiDung = dr["hoNguoiDung"].ToString();
        //            string tenNguoiDung = dr["tenNguoiDung"].ToString();
        //            string sdt = dr["sdt"].ToString();
        //            string email = dr["email"].ToString();
        //            string tenLopHoc = dr["tenLopHoc"] == DBNull.Value ? "Chưa có lớp nào" : dr["tenLopHoc"].ToString();

        //            if (!mapHLV.ContainsKey(idNguoiDung))
        //            {
        //                mapHLV[idNguoiDung] = new DTO_HLV()
        //                {
        //                    idNguoiDung = idNguoiDung,
        //                    HoNguoiDung = hoNguoiDung,
        //                    TenNguoiDung = tenNguoiDung,
        //                    Sdt = sdt,
        //                    Email = email,
        //                    DanhSachLopHoc = new List<string>()
        //                };
        //            }

        //            if (!mapHLV[idNguoiDung].DanhSachLopHoc.Contains(tenLopHoc))
        //                mapHLV[idNguoiDung].DanhSachLopHoc.Add(tenLopHoc);
        //        }
        //        dr.Close();

        //        danhSachHLV = new List<DTO_HLV>(mapHLV.Values);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }

        //    return danhSachHLV;
        //}
        public List<DTO_HLV> LayDanhSachHLV()
        {
            List<DTO_HLV> danhSachHLV = new List<DTO_HLV>();

            try
            {
                // Gọi stored procedure lấy DataTable
                DataTable dt = GetDataTable("LayDanhSachHuanLuyenVien", null);

                // Dùng dictionary để gom lớp học theo HLV
                Dictionary<int, DTO_HLV> mapHLV = new Dictionary<int, DTO_HLV>();

                foreach (DataRow row in dt.Rows)
                {
                    int idNguoiDung = Convert.ToInt32(row["idNguoiDung"]);
                    string hoNguoiDung = row["hoNguoiDung"].ToString();
                    string tenNguoiDung = row["tenNguoiDung"].ToString();
                    string sdt = row["sdt"].ToString();
                    string email = row["email"].ToString();
                    string tenLopHoc = row["tenLopHoc"] == DBNull.Value ? "Chưa có lớp nào" : row["tenLopHoc"].ToString();

                    if (!mapHLV.ContainsKey(idNguoiDung))
                    {
                        mapHLV[idNguoiDung] = new DTO_HLV()
                        {
                            idNguoiDung = idNguoiDung,
                            HoNguoiDung = hoNguoiDung,
                            TenNguoiDung = tenNguoiDung,
                            Sdt = sdt,
                            Email = email,
                            DanhSachLopHoc = new List<string>()
                        };
                    }

                    if (!mapHLV[idNguoiDung].DanhSachLopHoc.Contains(tenLopHoc))
                        mapHLV[idNguoiDung].DanhSachLopHoc.Add(tenLopHoc);
                }

                danhSachHLV = new List<DTO_HLV>(mapHLV.Values);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return danhSachHLV;
        }


        // Lấy HLV theo Id
        //public DTO_HLV LayHLVTheoId(int idNguoiDung)
        //{
        //    DTO_HLV hlv = null;
        //    try
        //    {
        //        conn.Open();
        //        SqlCommand cmd = new SqlCommand("LayHuanLuyenVienTheoId", conn);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@idNguoiDung", idNguoiDung);

        //        SqlDataReader dr = cmd.ExecuteReader();

        //        hlv = new DTO_HLV();
        //        hlv.DanhSachLopHoc = new List<string>();

        //        while (dr.Read())
        //        {
        //            if (hlv.idNguoiDung == 0)
        //            {
        //                hlv.idNguoiDung = Convert.ToInt32(dr["idNguoiDung"]);
        //                hlv.HoNguoiDung = dr["hoNguoiDung"].ToString();
        //                hlv.TenNguoiDung = dr["tenNguoiDung"].ToString();
        //                hlv.Sdt = dr["sdt"].ToString();
        //                hlv.Email = dr["email"].ToString();
        //            }

        //            string tenLopHoc = dr["tenLopHoc"] == DBNull.Value ? "Chưa có lớp nào" : dr["tenLopHoc"].ToString();

        //            if (!hlv.DanhSachLopHoc.Contains(tenLopHoc))
        //                hlv.DanhSachLopHoc.Add(tenLopHoc);
        //        }
        //        dr.Close();

        //        if (hlv.idNguoiDung == 0)
        //            hlv = null; // không có dữ liệu
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //    return hlv;
        //}
        public DTO_HLV LayHLVTheoId(int idNguoiDung)
        {
            DTO_HLV hlv = null;
            try
            {
                // Gọi stored procedure lấy DataTable
                SqlParameter[] parameters = { new SqlParameter("@idNguoiDung", idNguoiDung) };
                DataTable dt = GetDataTable("LayHuanLuyenVienTheoId", parameters);

                if (dt.Rows.Count == 0)
                    return null; // Không có dữ liệu thì trả về null

                hlv = new DTO_HLV();
                hlv.DanhSachLopHoc = new List<string>();

                foreach (DataRow row in dt.Rows)
                {
                    if (hlv.idNguoiDung == 0)
                    {
                        hlv.idNguoiDung = Convert.ToInt32(row["idNguoiDung"]);
                        hlv.HoNguoiDung = row["hoNguoiDung"].ToString();
                        hlv.TenNguoiDung = row["tenNguoiDung"].ToString();
                        hlv.Sdt = row["sdt"].ToString();
                        hlv.Email = row["email"].ToString();
                    }

                    string tenLopHoc = row["tenLopHoc"] == DBNull.Value ? "Chưa có lớp nào" : row["tenLopHoc"].ToString();

                    if (!hlv.DanhSachLopHoc.Contains(tenLopHoc))
                        hlv.DanhSachLopHoc.Add(tenLopHoc);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return hlv;
        }

        // Lấy HLV theo tên
        //public DTO_HLV LayHLVTheoTen(string tenNguoiDung)
        //{
        //    DTO_HLV hlv = null;
        //    try
        //    {
        //        conn.Open();
        //        SqlCommand cmd = new SqlCommand("LayHuanLuyenVienTheoTen", conn);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@tenNguoiDung", tenNguoiDung);

        //        SqlDataReader dr = cmd.ExecuteReader();

        //        hlv = new DTO_HLV();
        //        hlv.DanhSachLopHoc = new List<string>();

        //        while (dr.Read())
        //        {
        //            if (hlv.idNguoiDung == 0)
        //            {
        //                hlv.idNguoiDung = Convert.ToInt32(dr["idNguoiDung"]);
        //                hlv.HoNguoiDung = dr["hoNguoiDung"].ToString();
        //                hlv.TenNguoiDung = dr["tenNguoiDung"].ToString();
        //                hlv.Sdt = dr["sdt"].ToString();
        //                hlv.Email = dr["email"].ToString();
        //            }

        //            string tenLopHoc = dr["tenLopHoc"] == DBNull.Value ? "Chưa có lớp nào" : dr["tenLopHoc"].ToString();

        //            if (!hlv.DanhSachLopHoc.Contains(tenLopHoc))
        //                hlv.DanhSachLopHoc.Add(tenLopHoc);
        //        }
        //        dr.Close();

        //        if (hlv.idNguoiDung == 0)
        //            hlv = null; // không có dữ liệu
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //    return hlv;
        //}
        public DTO_HLV LayHLVTheoTen(string tenNguoiDung)
        {
            DTO_HLV hlv = null;
            try
            {
                SqlParameter[] parameters = { new SqlParameter("@tenNguoiDung", tenNguoiDung) };
                DataTable dt = GetDataTable("LayHuanLuyenVienTheoTen", parameters);

                if (dt.Rows.Count == 0)
                    return null; // Không tìm thấy HLV

                hlv = new DTO_HLV();
                hlv.DanhSachLopHoc = new List<string>();

                foreach (DataRow row in dt.Rows)
                {
                    if (hlv.idNguoiDung == 0)
                    {
                        hlv.idNguoiDung = Convert.ToInt32(row["idNguoiDung"]);
                        hlv.HoNguoiDung = row["hoNguoiDung"].ToString();
                        hlv.TenNguoiDung = row["tenNguoiDung"].ToString();
                        hlv.Sdt = row["sdt"].ToString();
                        hlv.Email = row["email"].ToString();
                    }

                    string tenLopHoc = row["tenLopHoc"] == DBNull.Value ? "Chưa có lớp nào" : row["tenLopHoc"].ToString();

                    if (!hlv.DanhSachLopHoc.Contains(tenLopHoc))
                        hlv.DanhSachLopHoc.Add(tenLopHoc);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return hlv;
        }

        public List<DTO_HLV> LayDanhSachHLVCoThe(DateTime ngayBatDauMoi, DateTime ngayKetThucMoi, string lichHocMoi)
        {
            // Phân tích lịch học mới thành danh sách khung thời gian
            var lichMoiPhanTich = TroGiupLich.PhanTichLich(lichHocMoi);

            // Lấy tất cả huấn luyện viên và lớp học
            List<DTO_HLV> tatCaHLV = LayDanhSachHLV();
            List<DTO_LopHoc> tatCaLopHoc = new DAL_LopHoc().LayTatCaLopHoc();

            // Lọc huấn luyện viên không bị trùng lịch
            var danhSachHLVKhongTrungLich = (from hlv in tatCaHLV
                                             where !(from lop in tatCaLopHoc
                                                     where lop.idHLV == hlv.idNguoiDung
                                                        && ngayBatDauMoi <= lop.ngayKetThuc
                                                        && ngayKetThucMoi >= lop.ngayBatDau
                                                     select lop).Any(lop =>
                                                     {
                                                         var lichCu = TroGiupLich.PhanTichLich(lop.lichHoc);
                                                         return TroGiupLich.KiemTraTrungLich(lichMoiPhanTich, lichCu);
                                                     })
                                             select hlv).ToList();

            return danhSachHLVKhongTrungLich;
        }

    }
}
