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
    public partial class GUI_GoiTap : Form
    {
        public GUI_GoiTap()
        {
            InitializeComponent();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDSGoiTap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Lấy row hiện tại 
            DataGridViewRow row = dgvDSGoiTap.SelectedRows[0];
            //Chuyển các giá trị lên form
            cbLoaiGT.Text = row.Cells[1].Value.ToString();
            txtDonGiaGT.Text = row.Cells[2].Value.ToString();
            dtpNgayBatDauGT.Value = Convert.ToDateTime(row.Cells[3].Value);
            dtpNgayKetThucGT.Value = Convert.ToDateTime(row.Cells[4].Value);
        }
    }
}
