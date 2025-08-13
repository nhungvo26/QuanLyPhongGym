using BUS_QLPG;
using GUI_QLPG.Helpers;
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
    public partial class ChonHocVien : Form
    {

        BUS_HocVien busHocVien = new BUS_HocVien();
        BUS_LopHoc busLopHoc = new BUS_LopHoc();
        private List<int> selectedClassId;
      

        public ChonHocVien(List<int> selectedClassId)
        {
            InitializeComponent();
            this.selectedClassId = selectedClassId;
            
            LoadStudents();
        }

        private void ChonHocVien_Load(object sender, EventArgs e)
        {
           

        }
        private void hienThiDSHocVien()
        {
            dgvHocVien.DataSource = busHocVien.layHocVienChuaCoLop();
        }

        private void LoadStudents()
        {
            BUS_HocVien studentBL = new BUS_HocVien();
            dgvHocVien.DataSource = studentBL.layHocVienChuaCoLop();
            DataGridViewStyleHelper.FormatStudentDGV(dgvHocVien);


            if (!dgvHocVien.Columns.Contains("SelectColumn"))
            {
                DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
                chk.Name = "SelectColumn";
                chk.HeaderText = "Chọn";
                dgvHocVien.Columns.Insert(0, chk);
            }
        }

        private void btQuaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (dgvHocVien.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn học viên trước!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idHocVien = Convert.ToInt32(dgvHocVien.CurrentRow.Cells["idHocVien"].Value);
            bool daThemThanhCong = false;

            foreach (int idLop in selectedClassId)
            {
                int result = busLopHoc.ThemHocVienVaoLop(idHocVien, idLop);

                switch (result)
                {
                    case 0:
                        daThemThanhCong = true;
                        MessageBox.Show($"Đã thêm học viên vào lớp {idLop} thành công!",
                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case 1:
                        MessageBox.Show($"Lớp {idLop} đã đủ số lượng, bỏ qua.",
                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;

                    case 2:
                        MessageBox.Show($"Học viên đã tham gia lớp {idLop}.",
                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;

                    default:
                        MessageBox.Show($"Lỗi không xác định khi thêm vào lớp {idLop}.",
                            "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }

            if (daThemThanhCong)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }


      
    }
}
