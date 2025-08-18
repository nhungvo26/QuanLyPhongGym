using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QLPG;
using DTO_QLPG;
using System.Data.SqlClient;

namespace GUI_QLPG
{
    public partial class GUI_ThanhToan : Form
    {
        BUS_ThanhToan busThanhToan = new BUS_ThanhToan();
        public GUI_ThanhToan()
        {
            InitializeComponent();
        }

        private void hienThiDSHVThanhToan()
        {
            dgvDSThanhToan.DataSource = busThanhToan.xemThanhToan();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            GUI_HoaDonThanhToan form = new GUI_HoaDonThanhToan();
            form.Show();
        }

        private void GUI_ThanhToan_Load(object sender, EventArgs e)
        {
            hienThiDSHVThanhToan();
        }
    }
}
