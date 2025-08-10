using DAL_QLPG;
using DTO_QLPG;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QLPG
{
    public class BUS_LopHoc
    {
         DAL_LopHoc dal = new DAL_LopHoc();

        // Lấy tất cả lớp học
        public List<DTO_LopHoc> LayTatCaLopHoc()
        {
            return dal.LayTatCaLopHoc();
        }

        // Lấy lớp học theo ID
        public DTO_LopHoc LayLopHocTheoID(int idLopHoc)
        {
            return dal.LayLopHocTheoID(idLopHoc);
        }

        // Lấy lớp học theo HLV
        public List<DTO_LopHoc> LayLopHocTheoHLV(int idHLV)
        {
            return dal.LayLopHocTheoHLV(idHLV);
        }

        // Thêm lớp học
        public int ThemLopHoc(DTO_LopHoc lop)
        {
            try
            {
                return dal.ThemLopHoc(lop);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        // Cập nhật lớp học
        public int CapNhatLopHoc(DTO_LopHoc lop)
        {
            try
            {
                return dal.CapNhatLopHoc(lop);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        // Xóa lớp học
        public int XoaLopHoc(int idLopHoc)
        {
            try
            {
                return dal.XoaLopHoc(idLopHoc);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
