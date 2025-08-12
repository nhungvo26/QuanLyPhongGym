using DAL_QLPG;
using DTO_QLPG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QLPG
{
    public class BUS_ThongKe
    {
        private DAL_ThongKe dal = new DAL_ThongKe();

        public List<DTO_StudentCountByMonth> LaySoLuongHocVienTheoThang()
        {
            return dal.LaySoLuongHocVienTheoThang();
        }
        public List<DTO_StudentRatioByCategory> LayTiLeHocVienTheoLoaiHinh()
        {
            return dal.LayTiLeHocVienTheoLoaiHinh();
        }
    }
}

