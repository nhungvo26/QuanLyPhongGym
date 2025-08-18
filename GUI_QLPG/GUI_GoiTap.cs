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
        BUS_GoiTap busGoiTap = new BUS_GoiTap();

        public GUI_GoiTap()
        {
            InitializeComponent();
        }

        private void GUI_GoiTap_Load(object sender, EventArgs e)
        {
            hienThiLoaiGoiTap();
            hienThiDSHVDKGoiTap();
            cbLoaiGT.SelectedIndexChanged += cbLoaiGT_SelectedIndexChanged;
        }

        private void hienThiDSHVDKGoiTap()
        {
            dgvDSGoiTap.DataSource = busGoiTap.xemDSHVDKGoiTap();
        }

        private void hienThiLoaiGoiTap()
        {
            try
            {
                List<TheLoaiGoiTap> loaiGT = busGoiTap.xemLoaiGoiTap();
                cbLoaiGT.DataSource = loaiGT;
                cbLoaiGT.DisplayMember = "loaiGoiTap";
                cbLoaiGT.ValueMember = "loaiGoiTap";

                if(loaiGT.Count > 0)
                {
                    cbLoaiGT.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Không có loại gói tập nào trong hệ thống.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void cbLoaiGT_SelectedIndexChanged(object sender, EventArgs e)
        {
            var chonGT = cbLoaiGT.SelectedItem as TheLoaiGoiTap;
            if (chonGT == null) return;

            DateTime ngayBD = dtpNgayBatDauGT.Value;
            dtpNgayKetThucGT.Value = ngayBD.AddMonths(chonGT.thang);
            txtDonGiaGT.Text = chonGT.donGia.ToString();
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
            cbLoaiGT.Text = row.Cells[2].Value.ToString();
            txtDonGiaGT.Text = row.Cells[5].Value.ToString();
            dtpNgayBatDauGT.Value = Convert.ToDateTime(row.Cells[3].Value);
            dtpNgayKetThucGT.Value = Convert.ToDateTime(row.Cells[4].Value);
        }
    }
}
