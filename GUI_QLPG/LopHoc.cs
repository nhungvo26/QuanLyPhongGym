using BUS_QLPG;
using DAL_QLPG;
using DTO_QLPG;
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
    public partial class LopHoc : Form
    {
        public LopHoc()
        {
            InitializeComponent();
            panel7.Hide();
        }

        private enum ViewMode { LopHoc, HocVien }
        private ViewMode currentMode = ViewMode.LopHoc;
        private bool isSelectLopHoc = false;
        private int selectedIdLopHoc = -1;
        private int selectedTrainerId = 0;




        private void LopHoc_Load(object sender, EventArgs e)
        {
            panel4.Visible = false;
            btnThemLop.Visible = false;
            btnSuaLop.Visible = false;
            btnXoaLop.Visible = false;
            btnThemHV.Visible = false;
            btnHuy.Visible = false;

            string role = PhanQuyen.vaiTro;
            if (role == "Admin")
            {
                btnLopCuaBan.Visible = false;
            }
            else if (role == "Lễ tân")
            {
                btnLopCuaBan.Visible = false;
            }
            else if (role == "Huấn luyện viên")
            {
                btnHLV.Visible = false;
              //  btnDSHV.Visible = false;
               // btnDanhSachLop.Visible = false;
                btnCapNhatLop.Visible = false;
                btnHuy.Visible = false;
                btnThemHV.Visible = false;
            }
        }
        private void btnLopCuaBan_Click(object sender, EventArgs e)
        {
            panel5.Visible = false;

            btnThemLop.Visible = false;
            btnSuaLop.Visible = false;
            btnXoaLop.Visible = false;
            btnHuy.Visible = false;
            btnThemHV.Visible = false;

            string vaiTro = PhanQuyen.vaiTro;
            int idHLV = PhanQuyen.idNguoiDung;
            BUS_LopHoc bus_LopHoc = new BUS_LopHoc();
            List<DTO_LopHoc> lopHoc = new List<DTO_LopHoc>();

            if (vaiTro== "Huấn luyện viên")
            {
                lopHoc = bus_LopHoc.LayLopHocTheoHLV(idHLV);
            }
            if (lopHoc.Count == 0)
            {
                MessageBox.Show("Bạn chưa có lớp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dgvClass.DataSource = lopHoc;
                DataGridViewStyleHelper.FormatClassDGV(dgvClass);
            }
        }


        private void btnDanhSachLop_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            DAL_LopHoc lopHocBL = new DAL_LopHoc();
            var listLopHoc = lopHocBL.LayTatCaLopHoc();

            dgvClass.DataSource = listLopHoc;
            DataGridViewStyleHelper.FormatClassDGV(dgvClass);

            dgvClass.Columns["SelectColumn"].Visible = true;
            isSelectLopHoc = false;

            btnThemLop.Visible = false;
            btnSuaLop.Visible = false;
            btnXoaLop.Visible = false;
            btnHuy.Visible = false;
            if (PhanQuyen.vaiTro == "Admin" || PhanQuyen.vaiTro == "Lễ tân")
            {
                btnThemHV.Visible = true;
            }
        }

        // Xem danh sách học viên
        private void btnDanhSachHV_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            LoadLopHoc();
            dgvClass.Columns["SelectColumn"].Visible = false;
            isSelectLopHoc = true;

            btnThemLop.Visible = false;
            btnSuaLop.Visible = false;
            btnXoaLop.Visible = false;
            btnThemHV.Visible = false;
            if (PhanQuyen.vaiTro == "Admin" || PhanQuyen.vaiTro == "Lễ tân")
            {
                btnHuy.Visible = true;
            }
        }

        private void LoadLopHoc()
        {
            currentMode = ViewMode.LopHoc;
            BUS_LopHoc lopHocBL = new BUS_LopHoc();
            var listLopHoc = lopHocBL.LayTatCaLopHoc();

            if (PhanQuyen.vaiTro == "Huấn luyện viên")
            {
                listLopHoc = (from lh in listLopHoc
                              where lh.idHLV == PhanQuyen.idNguoiDung
                              select lh).ToList();
            }

            dgvClass.DataSource = listLopHoc;
            DataGridViewStyleHelper.FormatClassDGV(dgvClass);
        }

        private void btnThemlop_Click(object sender, EventArgs e)
        {
            string schedule = txtSchedule.Text.Trim();
            if (string.IsNullOrWhiteSpace(schedule))
            {
                MessageBox.Show("Vui lòng nhập lịch học");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtHLV.Text))
            {
                MessageBox.Show("Vui lòng phân công huấn luyện viên");
                return;
            }
            if (!NgayBatDauVaKetThuc(dtStartDate.Value, dtEndDate.Value))
                return;
            int trainerId = 0;
            foreach (DataGridViewRow row in dgvHLV.Rows)
            {
                string fullName = $"{row.Cells["HoNguoiDung"].Value} {row.Cells["TenNguoiDung"].Value}".Trim();
                if (fullName == txtHLV.Text)
                {

                    trainerId = Convert.ToInt32(row.Cells["idNguoiDung"].Value);
                    break;
                }

               
            }
            if (trainerId == 0)
            {
                MessageBox.Show("Không tìm thấy HLV phù hợp");
                return;
            }
            DTO_LopHoc newClass = new DTO_LopHoc()
            {

               // idLopHoc = selectedIdLopHoc,
                tenLopHoc = txtTenLop.Text.Trim(),
                idTLLH = Convert.ToInt32(cbLoaihinh.SelectedValue),
                idHLV = trainerId,
                lichHoc = schedule,
                soLuongHV = int.TryParse(txtSoLuongHV.Text, out int max) ? max : 20,
                donGia = decimal.TryParse(txtGia.Text, out decimal price) ? price : 0,
                ngayBatDau = dtStartDate.Value,
                ngayKetThuc = dtEndDate.Value,
                moTa = txtMoTa.Text.Trim()
                
            }; 
            try
            {
                BUS_LopHoc classesBL = new BUS_LopHoc();
                int result = classesBL.ThemLopHoc(newClass);
                if (result > 0)
                {
                    MessageBox.Show("Thêm lớp học thành công!");
                    panel7.Hide();
                    dgvCapNhat.DataSource = classesBL.LayTatCaLopHoc();
                    DataGridViewStyleHelper.FormatClassDGV(dgvCapNhat);

                    Clear();
                }
                else
                {
                    MessageBox.Show("Không thể thêm lớp học.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnSualop_Click(object sender, EventArgs e)
        {

            if (selectedIdLopHoc == 0)
            {
                MessageBox.Show("Vui lòng chọn lớp học cần chỉnh sửa.");
                return;
            }
            string schedule = txtSchedule.Text.Trim();
            if (string.IsNullOrWhiteSpace(schedule))
            {
                MessageBox.Show("Vui lòng nhập lịch học.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtHLV.Text))
            {
                MessageBox.Show("Vui lòng phân công huấn luyện viên.");
                return;
            }

            //tìm trainerId theo tên
            int trainerId = 0;
            foreach (DataGridViewRow row in dgvCapNhat.Rows)
            {
                if (Convert.ToInt32(row.Cells["idLopHoc"].Value) == selectedIdLopHoc)
                {
                    trainerId = Convert.ToInt32(row.Cells["idHLV"].Value);
                    break;
                }
            }

            if (trainerId == 0)
            {
                // Nếu không tìm được trong lưới (trường hợp người dùng đã sửa lại HLV bằng tay)
                BUS_HLV trainerBL = new BUS_HLV();
                var trainer = trainerBL.LayHLVTheoTen(txtHLV.Text.Trim());
                if (trainer != null)
                    trainerId = trainer.idNguoiDung;
                else
                {
                    MessageBox.Show("Không tìm thấy huấn luyện viên tương ứng.");
                    return;
                }
            }

            //Lấy ClassID từ dòng được chọn
            DataGridViewRow selectedRow = dgvCapNhat.SelectedRows[0];
            if (!int.TryParse(selectedRow.Cells["idLopHoc"].Value.ToString(), out int classId))
            {
                MessageBox.Show("Không thể xác định lớp học cần cập nhật.");
                return;
            }

            DTO_LopHoc updatedClass = new DTO_LopHoc()
            {
                idLopHoc = classId,
                tenLopHoc = txtTenLop.Text.Trim(),
                idTLLH = Convert.ToInt32(cbLoaihinh.SelectedValue),
                idHLV = trainerId,
                lichHoc = schedule,
                soLuongHV = int.TryParse(txtSoLuongHV.Text, out int max) ? max : 20,
                donGia = decimal.TryParse(txtGia.Text, out decimal price) ? price : 0,
                ngayBatDau = dtStartDate.Value,
                ngayKetThuc = dtEndDate.Value,
                moTa = txtMoTa.Text.Trim()
            };

            try
            {
                BUS_LopHoc classesBL = new BUS_LopHoc();
                int result = classesBL.CapNhatLopHoc(updatedClass);
                if (result > 0)
                {
                    MessageBox.Show("Cập nhật lớp học thành công!");
                    panel7.Hide();
                    dgvCapNhat.DataSource = classesBL.LayTatCaLopHoc();
                    DataGridViewStyleHelper.FormatClassDGV(dgvCapNhat);

                    selectedIdLopHoc = -1;
                    Clear();
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật lớp học.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXoalop_Click(object sender, EventArgs e)
        {
            if (dgvCapNhat.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn lớp học cần xóa.");
                return;
            }
            // Lấy thông tin lớp được chọn
            DataGridViewRow selectedRow = dgvCapNhat.SelectedRows[0];
            int idLopHoc = Convert.ToInt32(selectedRow.Cells["idLopHoc"].Value);

            // Kiểm tra xem lớp có học viên không
            int maxStudent = Convert.ToInt32(selectedRow.Cells["soLuongHV"].Value);
            BUS_HocVien_LopHoc bus_HocVienLopHoc = new BUS_HocVien_LopHoc();
            int slots = bus_HocVienLopHoc.soLuongConTrong(idLopHoc);
            int soLuongHV = maxStudent - slots;

            if (soLuongHV > 0)
            {
                MessageBox.Show("Không thể xóa lớp học vì có học viên đang tham gia lớp.");
                return;
            }
            // Hỏi người dùng có chắc chắn muốn xóa
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa lớp học này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No) return;

            // Tiến hành xóa
            BUS_LopHoc classesBL = new BUS_LopHoc();
            int deleted = classesBL.XoaLopHoc(idLopHoc);

            if (deleted > 0)
            {
                MessageBox.Show("Đã xóa lớp học thành công.");
                dgvCapNhat.DataSource = classesBL.LayTatCaLopHoc();
                DataGridViewStyleHelper.FormatClassDGV(dgvCapNhat);
                //FormatDGV(dgvCapNhat);
                selectedIdLopHoc = -1;
            }
            else
            {
                MessageBox.Show("Xóa lớp học thất bại.");
            }

        }
        private void cbLoaihinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLoaihinh.Text == "Personal Trainer")
            {
                txtSoLuongHV.Text = "1";
                txtSoLuongHV.ReadOnly = true;
            }
            else
            {
                txtSoLuongHV.Text = "20";
                txtSoLuongHV.ReadOnly = false;
            }
        }
        private List<string> NgayHoc()
        {
            List<string> selectedDays = new List<string>();
            if (chkT2.Checked) selectedDays.Add("Mon");
            if (chkT3.Checked) selectedDays.Add("Tue");
            if (chkT4.Checked) selectedDays.Add("Wed");
            if (chkT5.Checked) selectedDays.Add("Thu");
            if (chkT6.Checked) selectedDays.Add("Fri");
            if (chkT7.Checked) selectedDays.Add("Sat");
            if (chkCN.Checked) selectedDays.Add("Sun");
            return selectedDays;
        }
        
        private bool NgayBatDauVaKetThuc(DateTime startDate, DateTime endDate)
        {
            DateTime today = DateTime.Today;
            if (startDate < today.AddDays(15))
            {
                MessageBox.Show("Lớp học được mở sau ít nhất 15 ngày.");
                return false;
            }
            if (startDate >= endDate)
            {
                MessageBox.Show("Ngày bắt đầu phải trước ngày kết thúc.");
                return false;
            }
            return true;
        }
        private void ThoiGianHoc()
        {
            cbGioBD.Items.Clear();
            cbGioKT.Items.Clear();

            TimeSpan start = new TimeSpan(7, 0, 0);
            TimeSpan end = new TimeSpan(20, 0, 0);

            while (start <= end)
            {
                string time = start.ToString(@"hh\:mm");
                cbGioBD.Items.Add(time);
                cbGioKT.Items.Add(time);
                start = start.Add(TimeSpan.FromMinutes(30));
            }
            if (cbGioBD.Items.Count > 0)
                cbGioBD.SelectedIndex = 0;
            if (cbGioKT.Items.Count > 1)
                cbGioKT.SelectedIndex = 1;
        }
        private void btnThemLich_Click(object sender, EventArgs e)
        {
            var selectedDays = NgayHoc();
            if (selectedDays.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất 1 ngày!");
                return;
            }
            if (selectedDays.Count > 3)
            {
                MessageBox.Show("Chỉ được chọn tối đa 3 ngày cho 1 lớp học.");
                return;
            }
            string start = cbGioBD.Text;
            string end = cbGioKT.Text;

            if (string.IsNullOrWhiteSpace(start) || string.IsNullOrWhiteSpace(end))
            {
                MessageBox.Show("Vui lòng chọn giờ bắt đầu và giờ kết thúc.");
                return;
            }
            TimeSpan startTime = TimeSpan.Parse(start);
            TimeSpan endTime = TimeSpan.Parse(end);
            if (startTime >= endTime)
            {
                MessageBox.Show("Giờ bắt đầu phải trước giờ kết thúc.");
                return;
            }

            foreach (var day in selectedDays)
            {
                if (day == "Sun")
                {
                    if (startTime.Hours < 9 || endTime.Hours > 18)
                    {
                        MessageBox.Show("Các lớp Chủ nhật mở từ 09:00 đến 18:00");
                        return;
                    }
                }
            }
            List<string> chuoiLichHoc = new List<string>();
            foreach (var day in selectedDays)
            {
                chuoiLichHoc.Add($"{day} {start}-{end}");
            }
            string newSchedule = string.Join("; ", chuoiLichHoc);
            if (!string.IsNullOrWhiteSpace(txtSchedule.Text))
            {
                txtSchedule.Text += "; " + newSchedule;
            }
            else
            {
                txtSchedule.Text = newSchedule;
            }
        }
        private void LoadHLV()


        {
           
            BUS_HLV hlvBL = new BUS_HLV();
            var listHLV = hlvBL.LayDanhSachHLV();

            var displayList = (from t in listHLV
                               select new
                               {
                                   idNguoiDung = t.idNguoiDung,
                                   HoTen = $"{t.HoNguoiDung} {t.TenNguoiDung}",  // Nối họ và tên
                                   sdt = t.Sdt,
                                   Email = t.Email,
                                   LopDangDay = t.DanhSachLopHoc != null && t.DanhSachLopHoc.Count > 0
                                                ? string.Join(", ", t.DanhSachLopHoc)
                                                : "Chưa có lớp nào"
                               }).ToList();

            dgvClass.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClass.DataSource = displayList;
            dgvClass.Columns["idNguoiDung"].HeaderText = "ID";
            dgvClass.Columns["HoTen"].HeaderText = "Họ tên";
            dgvClass.Columns["Sdt"].HeaderText = "Số điện thoại";
            dgvClass.Columns["Email"].HeaderText = "Email";
            dgvClass.Columns["LopDangDay"].HeaderText = "Lớp đang dạy";
        }


        private void btnHLV_Click(object sender, EventArgs e)
        {
            LoadHLV();
            dgvClass.Columns["SelectColumn"].Visible = false;
            panel4.Visible = false;

            btnThemLop.Visible = false;
            btnSuaLop.Visible = false;
            btnXoaLop.Visible = false;
            btnHuy.Visible = false;
            btnThemHV.Visible = false;
        }
        private void btnCapNhatLop_Click(object sender, EventArgs e)
        {
             ThoiGianHoc();
            panel7.Hide();
            panel4.Visible = true;
            BUS_LopHoc bus_LopHoc = new BUS_LopHoc();
            var DTO_LopHoc = bus_LopHoc.LayTatCaLopHoc();

            dgvCapNhat.DataSource = DTO_LopHoc;
            DataGridViewStyleHelper.FormatClassDGV(dgvCapNhat);

            btnThemLop.Visible = true;
            btnSuaLop.Visible = true;
            btnXoaLop.Visible = true;
            btnThemHV.Visible = false;
            btnHuy.Visible = false;

            cbLoaihinh.DataSource = new BUS_TheLoai_LopHoc().GetAllCategories();
            cbLoaihinh.DisplayMember = "tenTLLH";
            cbLoaihinh.ValueMember = "idTLLH";
        }

        private void Clear()
        {
            txtTenLop.Clear();
            txtSchedule.Clear();
            txtGia.Clear();
            txtHLV.Clear();
            txtSoLuongHV.Clear();
            txtMoTa.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTenLop.Clear();
            txtGia.Clear();
            txtHLV.Clear();
            txtMoTa.Clear();
            txtSchedule.Clear();
            txtSoLuongHV.Clear();
        }

        private void btnPhanCongHLV_Click(object sender, EventArgs e)
        {
            panel7.Show();
            string schedule = txtSchedule.Text.Trim();
            DateTime startDate = dtStartDate.Value;
            DateTime endDate = dtEndDate.Value;

            if (string.IsNullOrWhiteSpace(schedule))
            {
                MessageBox.Show("Vui lòng nhập lịch học trước khi phân công HLV");
                return;
            }
            if (!NgayBatDauVaKetThuc(startDate, endDate))
                return;

            BUS_HLV trainerBL = new BUS_HLV();
            var availableTrainers = trainerBL.LayDanhSachHLVCoThe(startDate, endDate, schedule);
            if (availableTrainers.Count == 0)
            {
                MessageBox.Show("Không có huấn luyện viên nào phù hợp với lịch học.");
                return;
            }
            //gán ds HLV lên dgvCapNhat
            dgvHLV.DataSource = availableTrainers;
            dgvHLV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void dgvCapNhat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCapNhat.Rows[e.RowIndex];
                selectedIdLopHoc = Convert.ToInt32(row.Cells["idLopHoc"].Value);

                txtTenLop.Text = row.Cells["tenLopHoc"].Value.ToString();
                cbLoaihinh.SelectedValue = Convert.ToInt32(row.Cells["idTLLH"].Value);

                int trainerId = Convert.ToInt32(row.Cells["idHLV"].Value);
                BUS_HLV trainerBL = new BUS_HLV();
                var trainer = trainerBL.LayHLVTheoId(trainerId);
                txtHLV.Text = trainer != null ? $"{trainer.HoNguoiDung} {trainer.TenNguoiDung}" : "";


                txtSchedule.Text = row.Cells["lichHoc"].Value.ToString();
                txtSoLuongHV.Text = row.Cells["soLuongHV"].Value.ToString();
                txtGia.Text = row.Cells["donGia"].Value.ToString();

                dtStartDate.Value = Convert.ToDateTime(row.Cells["ngayBatDau"].Value);
                dtEndDate.Value = Convert.ToDateTime(row.Cells["ngayKetThuc"].Value);

                txtMoTa.Text = row.Cells["moTa"].Value.ToString();
            }
        }
        private void dgvHLV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvHLV.Rows[e.RowIndex];
                selectedTrainerId = Convert.ToInt32(row.Cells["idNguoiDung"].Value);
                txtHLV.Text = row.Cells["HoNguoiDung"].Value.ToString() + " " + row.Cells["TenNguoiDung"].Value.ToString();

            }
        }

        private void dgvClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (isSelectLopHoc && e.RowIndex >= 0)
            {
                int idLopHoc = Convert.ToInt32(dgvClass.Rows[e.RowIndex].Cells["idLopHoc"].Value);
                LoadHocVienTheoLop(idLopHoc);
            }
        }

        private void LoadHocVienTheoLop(int idLopHoc)
        {
            try
            {
                BUS_HocVien busHocVien = new BUS_HocVien();
                DataTable dtHocVien = busHocVien.LayHocVienTheoLop(idLopHoc);

                dgvClass.DataSource = dtHocVien;
                dgvClass.Columns["SelectColumn"].Visible = true;

                DataGridViewStyleHelper.FormatStudentDGV(dgvClass);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }      

        private void SearchClasses()
        {
            string keyword = txtTimKiem.Text.Trim().ToLower();
            BUS_LopHoc classBL = new BUS_LopHoc();
            var classes = classBL.LayTatCaLopHoc();

            if (string.IsNullOrEmpty(keyword))
            {
                dgvClass.DataSource = classes;
                DataGridViewStyleHelper.FormatClassDGV(dgvClass);
                return;
            }

            List<DTO_LopHoc> filtered = classes;

            if (rdLoaiHinh.Checked)
            {
                var categories = new BUS_TheLoai_LopHoc().GetAllCategories();
                var match = (from c in categories
                             where c.tenTLLH.ToLower().Contains(keyword)
                             select c).FirstOrDefault();

                if (match != null)
                {
                    filtered = (from c in classes
                                where c.idTLLH == match.idTLLH
                                select c).ToList();
                }
                else
                {
                    filtered = new List<DTO_LopHoc>();
                }
            }
            else if (rdHLV.Checked)
            {
                var trainers = new BUS_HLV().LayDanhSachHLV();
                
                var match = (from t in trainers
                             let fullName = (t.HoNguoiDung + " " + t.TenNguoiDung).ToLower()
                             where fullName.Contains(keyword)
                             select t).FirstOrDefault();

                if (match != null)
                {
                    // Giả sử trong DTO_HLV, ID huấn luyện viên là idNguoiDung
                    filtered = (from c in classes
                                where c.idHLV == match.idNguoiDung
                                select c).ToList();
                }
                else
                {
                    filtered = new List<DTO_LopHoc>();
                }
            }
            else if (rdThoiGian.Checked)
            {
                string dateString = txtTimKiem.Text.Trim();

                if (!DateTime.TryParseExact(dateString, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime targetDate))
                {
                    MessageBox.Show("Vui lòng nhập ngày theo định dạng dd/MM/yyyy (VD: 15/08/2025).", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                filtered = (from c in classes
                            where c.ngayBatDau.Date == targetDate || c.ngayKetThuc.Date == targetDate
                            select c).ToList();
            }
            else if (rdGia.Checked)
            {
                if (decimal.TryParse(keyword, out decimal price))
                {
                    filtered = (from c in classes
                                where c.donGia == price
                                select c).ToList();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng số cho giá tiền.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            dgvClass.DataSource = filtered;
            DataGridViewStyleHelper.FormatClassDGV(dgvClass);
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            SearchClasses();
        }

        private void btnThemHV_Click(object sender, EventArgs e)
        {
            List<int> selectedClassId = new List<int>();
            foreach (DataGridViewRow row in dgvClass.Rows)
            {
                bool isChecked = Convert.ToBoolean(row.Cells["SelectColumn"].Value);
                if (isChecked)
                {
                    int classId = Convert.ToInt32(row.Cells["idLopHoc"].Value);
                    selectedClassId.Add(classId);
                }
            }
            if (selectedClassId.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một lớp để thêm học viên.");
                return;
            }
            Form student = new ChonHocVien(selectedClassId);
            if (student.ShowDialog() == DialogResult.OK)
            {
                LoadLopHoc();
                MessageBox.Show("Danh sách học viên đã được cập nhật.");
            }
        }
    }
}
