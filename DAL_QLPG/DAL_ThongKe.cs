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
    public class DAL_ThongKe: DBConnect
    {
        public List<DTO_StudentCountByMonth> LaySoLuongHocVienTheoThang()
        {
            List<DTO_StudentCountByMonth> list = new List<DTO_StudentCountByMonth>();

            string sql = @"
            SELECT MONTH(ngayDangKy) AS Thang, COUNT(*) AS SoLuong
            FROM HocVien_LopHoc
            GROUP BY MONTH(ngayDangKy)
            ORDER BY Thang";

            try
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DTO_StudentCountByMonth item = new DTO_StudentCountByMonth()
                            {
                                Thang = Convert.ToInt32(reader["Thang"]),
                                SoLuong = Convert.ToInt32(reader["SoLuong"])
                            };
                            list.Add(item);
                        }
                    }
                }
            }
            finally
            {
                conn.Close();
            }

            return list;
        }
        public List<DTO_StudentRatioByCategory> LayTiLeHocVienTheoLoaiHinh()
        {
            List<DTO_StudentRatioByCategory> list = new List<DTO_StudentRatioByCategory>();

            string sql = @"
                SELECT t.tenTLLH AS TenLoaiHinh, COUNT(hvlh.idHocVien) AS SoLuongHocVien
                FROM HocVien_LopHoc hvlh
                INNER JOIN LopHoc lh ON hvlh.idLopHoc = lh.idLopHoc
                INNER JOIN TheLoai_LopHoc t ON lh.idTLLH = t.idTLLH
                WHERE hvlh.trangThai = N'Đang hoạt động'
                GROUP BY t.tenTLLH";

            try
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DTO_StudentRatioByCategory item = new DTO_StudentRatioByCategory
                            {
                                TenLoaiHinh = reader["TenLoaiHinh"].ToString(),
                                SoLuongHocVien = Convert.ToInt32(reader["SoLuongHocVien"])
                            };
                            list.Add(item);
                        }
                    }
                }
            }
            finally
            {
                conn.Close();
            }
            return list;
        }
    }
}
