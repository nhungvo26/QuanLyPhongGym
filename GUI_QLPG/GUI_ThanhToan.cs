using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLPG
{
    public partial class GUI_ThanhToan : Form
    {
        public GUI_ThanhToan()
        {
            InitializeComponent();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            GUI_HoaDonThanhToan form = new GUI_HoaDonThanhToan();
            form.Show();
        }
    }
}
