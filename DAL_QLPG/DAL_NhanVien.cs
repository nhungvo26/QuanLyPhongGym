using DTO_QLPG;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL_QLPG
{
    public class DAL_NhanVien : DBConnect
    {
        // 1. Lấy tất cả nhân viên
        public List<NguoiDung> XemTatCaNhanVien()

        {
            List<NguoiDung> list = new List<NguoiDung>();
            
            try
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("uspGetAllNhanVien", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(MapReaderToUser(reader));
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

        // 2. Thêm nhân viên
        public int ThemNhanVien(NguoiDung user, string hoNguoiDung, string tenNguoiDung, string gioiTinh)
        {
            try
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("uspAddNhanVien", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Username", user.username ?? string.Empty);
                    cmd.Parameters.AddWithValue("@Password", user.password ?? string.Empty);
                    cmd.Parameters.AddWithValue("@HoNV", hoNguoiDung ?? string.Empty);
                    cmd.Parameters.AddWithValue("@TenNV", tenNguoiDung ?? string.Empty);
                    cmd.Parameters.AddWithValue("@GioiTinh", (object)gioiTinh ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@DOB", user.ngaySinh ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Phone", user.sdt ?? string.Empty);
                    cmd.Parameters.AddWithValue("@Email", user.email ?? string.Empty);
                    cmd.Parameters.AddWithValue("@Address", user.diaChi ?? string.Empty);
                    cmd.Parameters.AddWithValue("@Role", user.vaiTro ?? string.Empty);

                    SqlParameter outId = new SqlParameter("@NewUserId", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(outId);

                    cmd.ExecuteNonQuery();
                    return outId.Value != DBNull.Value ? Convert.ToInt32(outId.Value) : 0;
                }
            }
            finally
            {
                conn.Close();
            }
        }

        // 3. Cập nhật nhân viên
        public int CapNhatNhanVien(NguoiDung user, string hoNguoiDung, string tenNguoiDung, string gioiTinh = null)
        {
            try
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("uspUpdateNhanVien", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@UserId", user.idNguoiDung);
                    cmd.Parameters.AddWithValue("@Username", user.username ?? string.Empty);
                    cmd.Parameters.AddWithValue("@HoNV", hoNguoiDung ?? string.Empty);
                    cmd.Parameters.AddWithValue("@TenNV", tenNguoiDung ?? string.Empty);
                    cmd.Parameters.AddWithValue("@GioiTinh", (object)gioiTinh ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@DOB", user.ngaySinh ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Phone", user.sdt ?? string.Empty);
                    cmd.Parameters.AddWithValue("@Email", user.email ?? string.Empty);

                    // Đây là đoạn xử lý password mới:
                    string matKhauMoi = string.IsNullOrWhiteSpace(user.password) ? null : user.password.Trim();
                    cmd.Parameters.AddWithValue("@Password", (object)matKhauMoi ?? DBNull.Value);

                    cmd.Parameters.AddWithValue("@Address", user.diaChi ?? string.Empty);
                    cmd.Parameters.AddWithValue("@Role", user.vaiTro ?? string.Empty);

                    // Thay ExecuteNonQuery bằng ExecuteScalar để lấy số dòng update bảng NguoiDung
                    object result = cmd.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int rowsUpdated))
                    {
                        return rowsUpdated;
                    }
                    return 0;
                }
            }
            finally
            {
                conn.Close();
            }
        }





        // 4. Xóa nhân viên
        public int XoaNhanVien(int userId)
        {
            try
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("uspDeleteNhanVien", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserId", userId);

                    // Lấy số dòng bị xóa trong bảng NguoiDung
                    object result = cmd.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int rowsDeleted))
                    {
                        return rowsDeleted;
                    }
                    return 0;
                }
            }
            finally
            {
                conn.Close();
            }
        }


        public List<NguoiDung> TimKiemNhanVien(string tuKhoa, bool theoSDT)
        {
            List<NguoiDung> list = new List<NguoiDung>();
            conn.Open();
            using (SqlCommand cmd = new SqlCommand(theoSDT ? "uspSearchNhanVienByPhone" : "uspSearchNhanVienByName", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TuKhoa", tuKhoa);
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                        list.Add(MapReaderToUser(dr));
                }
            }
            conn.Close();
            return list;
        }

        // 5. Kiểm tra trùng username/email
        public bool KiemTraTrung(string username, string email)
        {
            try
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("uspKiemTraTrung", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Username", username ?? string.Empty);
                    cmd.Parameters.AddWithValue("@Email", email ?? string.Empty);

                    SqlParameter outParam = new SqlParameter("@Count", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(outParam);

                    cmd.ExecuteNonQuery();
                    int count = outParam.Value != DBNull.Value ? Convert.ToInt32(outParam.Value) : 0;
                    return count > 0;
                }
            }
            finally
            {
                conn.Close();
            }
        }

        // 6. Thêm vào Employees
        public bool ThemVaoEmployees(int userId, string role)
        {
            try
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("uspThemVaoEmployees", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    cmd.Parameters.AddWithValue("@Role", role ?? string.Empty);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            finally
            {
                conn.Close();
            }
        }

        // Mapping DataReader → NguoiDung
        private NguoiDung MapReaderToUser(SqlDataReader reader)
        {
 
           

            return new NguoiDung
            {
                idNguoiDung = reader["User_id"] != DBNull.Value ? Convert.ToInt32(reader["User_id"]) : 0,
                username = reader["Username"]?.ToString() ?? string.Empty,
                hoNguoiDung = reader["HoNguoiDung"].ToString(),
                tenNguoiDung = reader["TenNguoiDung"].ToString(),

                gioiTinh = reader["Gender"].ToString(),
                // Không có cột Gender trong result
                ngaySinh = reader["DOB"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["DOB"]),
                sdt = reader["Phone"]?.ToString() ?? string.Empty,
                email = reader["Email"]?.ToString() ?? string.Empty,
                diaChi = reader["Address"]?.ToString() ?? string.Empty,
                vaiTro = reader["Role"]?.ToString() ?? string.Empty
            };
        }
        public bool NhanVienDangDayLop(int nhanVienId)
        {
            string query = "SELECT COUNT(*) FROM LopHoc WHERE idHLV = @id";

            try
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", nhanVienId);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
            finally
            {
                conn.Close();
            }
        }


    }
}
