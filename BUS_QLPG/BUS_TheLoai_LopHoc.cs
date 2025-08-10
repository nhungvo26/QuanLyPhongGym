using DAL_QLPG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QLPG
{
    public class BUS_TheLoai_LopHoc
    {
        public List<DTO_QLPG.TheLoaiLopHoc> GetAllCategories()
        {
            return new DAL_TheLoai_LopHoc().GetAllCategories();
        }
    }
}
