using BUS_QLPG;
using DTO_QLPG;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI_QLPG
{
    public partial class ThongKe : Form
    {
        private BUS_ThongKe busThongKe = new BUS_ThongKe();
        public ThongKe()
        {
            InitializeComponent();
        }
        private void LoadChartHocVienTheoThang()
        {
            var data = busThongKe.LaySoLuongHocVienTheoThang();

            chart2.Series.Clear();
            chart2.Titles.Clear();

            chart2.Titles.Add(new Title("Số lượng học viên theo tháng", Docking.Top, new Font("Microsoft Sans Serif", 20, FontStyle.Bold), Color.Black));
            Series series = new Series("Số lượng")
            {
                ChartType = SeriesChartType.Column,
                Color = Color.SteelBlue,
                Font = new Font("Microsoft Sans Serif", 16, FontStyle.Bold),
                IsValueShownAsLabel = true
            };
            chart2.Series.Add(series);

            foreach (var item in data)
            {
                string thang = "Tháng " + item.Thang.ToString();
                int soLuong = item.SoLuong;
                series.Points.AddXY(thang, soLuong);
            }

            chart2.ChartAreas[0].AxisX.Title = "Tháng";
            chart2.ChartAreas[0].AxisY.Title = "Số lượng học viên";
            chart2.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Microsoft Sans Serif", 15, FontStyle.Bold);
            chart2.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Microsoft Sans Serif", 15, FontStyle.Bold);
        }
        private void LoadChartTiLeHocVienTheoLoaiHinh()
        {
            var data = busThongKe.LayTiLeHocVienTheoLoaiHinh();

            chart1.Series.Clear();
            chart1.Titles.Clear();

            chart1.Titles.Add(new Title("Tỉ lệ học viên theo loại hình", Docking.Top, new Font("Microsoft Sans Serif", 20, FontStyle.Bold), Color.Black));

            Series series = new Series("Tỉ lệ học viên")
            {
                ChartType = SeriesChartType.Pie,
                Font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold),
                IsValueShownAsLabel = true
            };

            chart1.Series.Add(series);

            foreach (var item in data)
            {
                series.Points.AddXY(item.TenLoaiHinh, item.SoLuongHocVien);
            }

            // Thiết lập label hiển thị % tỉ lệ
            series.Label = "#PERCENT{P1}";
            series.LegendText = "#VALX";
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            LoadChartHocVienTheoThang();
            LoadChartTiLeHocVienTheoLoaiHinh();
        }
    }

}
