using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLPG.Helpers
{
        public class TroGiupLich
        {
            public class KhoangThoiGian
            {
                public DayOfWeek ThuTrongTuan { get; set; }
                public TimeSpan BatDau { get; set; }
                public TimeSpan KetThuc { get; set; }
            }
            public static List<KhoangThoiGian> PhanTichLich(string lich)
            {
                var ketQua = new List<KhoangThoiGian>();

                if (string.IsNullOrEmpty(lich))
                    return ketQua;

                // Tách các lịch theo dấu chấm phẩy
                var lichTungNgay = lich.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var lichNgay in lichTungNgay)
                {
                    // Ví dụ lichNgay: "Mon 18:00-19:30"
                    var phanTach = lichNgay.Trim().Split(' '); // tách ngày và thời gian

                    if (phanTach.Length != 2)
                        continue;

                    var thuStr = phanTach[0];
                    var gioStr = phanTach[1]; // "18:00-19:30"

                    // Chuyển tên thứ sang DayOfWeek
                    DayOfWeek thu;
                    if (!ChuyenTenThuSangDayOfWeek(thuStr, out thu))
                        continue;

                    // Tách giờ bắt đầu và giờ kết thúc
                    var gioPhut = gioStr.Split('-');
                    if (gioPhut.Length != 2)
                        continue;

                    if (TimeSpan.TryParse(gioPhut[0], out TimeSpan batDau) && TimeSpan.TryParse(gioPhut[1], out TimeSpan ketThuc))
                    {
                        ketQua.Add(new KhoangThoiGian
                        {
                            ThuTrongTuan = thu,
                            BatDau = batDau,
                            KetThuc = ketThuc
                        });
                    }
                }

                return ketQua;
            }

            // Hàm chuyển tên thứ (ví dụ "Mon", "Tue") sang DayOfWeek
            private static bool ChuyenTenThuSangDayOfWeek(string tenThu, out DayOfWeek thu)
            {
                thu = DayOfWeek.Monday; // mặc định
                switch (tenThu.ToLower())
                {
                    case "mon":
                        thu = DayOfWeek.Monday;
                        return true;
                    case "tue":
                        thu = DayOfWeek.Tuesday;
                        return true;
                    case "wed":
                        thu = DayOfWeek.Wednesday;
                        return true;
                    case "thu":
                        thu = DayOfWeek.Thursday;
                        return true;
                    case "fri":
                        thu = DayOfWeek.Friday;
                        return true;
                    case "sat":
                        thu = DayOfWeek.Saturday;
                        return true;
                    case "sun":
                        thu = DayOfWeek.Sunday;
                        return true;
                    default:
                        return false;
                }
            }
            public static bool KiemTraTrungLich(List<KhoangThoiGian> lichMoi, List<KhoangThoiGian> lichCu)
            {
                foreach (var moi in lichMoi)
                {
                    foreach (var cu in lichCu)
                    {
                        // Chỉ xét khi cùng thứ trong tuần
                        if (moi.ThuTrongTuan == cu.ThuTrongTuan)
                        {
                            // Kiểm tra khoảng thời gian có chồng lấp
                            if (moi.BatDau < cu.KetThuc && moi.KetThuc > cu.BatDau)
                            {
                                return true; // có trùng lịch
                            }
                        }
                    }
                }
                return false; // không trùng lịch
            }



        }
    }