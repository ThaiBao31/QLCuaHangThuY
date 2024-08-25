using Microsoft.Reporting.WinForms;
using PMQuanLyCuaHangThuY.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMQuanLyCuaHangThuY.View
{
    public partial class UC_BangKeCt : UserControl
    {
        public UC_BangKeCt()
        {
            InitializeComponent();
            // Đăng ký sự kiện KeyDown cho UserControl
            this.KeyDown += UC_BangKeCt_KeyDown;

            // Đảm bảo rằng UserControl có khả năng nhận được sự kiện KeyDown
            this.TabStop = true;
            this.Focus();
        }

        public static UC_BangKeCt ucBangkeCt = new UC_BangKeCt();

        BL_BaoCao db = new BL_BaoCao();


        private void UC_BangKeCt_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds_VatTu.VATTU' table. You can move, or remove it, as needed.
            this.dMCTTableAdapter.Fill(this.ds_DMCT.DMCT);
            // Set giá trị mặc định cho lbkVatTu là null hoặc giá trị trống
            lbkChungTu.SelectedIndex = -1; // hoặc lbkVatTu.Text = "";
            this.reportViewer1.RefreshReport();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            // Lấy giá trị của SelectedValue hoặc gán mặc định là ''
            string chungtu = lbkChungTu.SelectedValue != null ? lbkChungTu.SelectedValue.ToString() : null;

            DataTable dt = db.BangKeCT(dtNgay1.Value.ToString("yyyy-MM-dd"), dtNgay2.Value.ToString("yyyy-MM-dd"),chungtu);
            reportViewer1.LocalReport.ReportEmbeddedResource = "PMQuanLyCuaHangThuY.Rp_BangKeCt.rdlc";
            ReportDataSource rds = new ReportDataSource("DataSet1", dt);

            ReportParameter[] parameters = new ReportParameter[3];
            parameters[0] = new ReportParameter("ngayct1", dtNgay1.Value.ToString("dd/MM/yyyy"), true);
            parameters[1] = new ReportParameter("ngayct2", dtNgay2.Value.ToString("dd/MM/yyyy"), true);
            parameters[2] = new ReportParameter("chungtu", chungtu, true);
            reportViewer1.LocalReport.SetParameters(parameters);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 120;
            this.reportViewer1.RefreshReport();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbkChungTu_SelectedIndexChanged(object sender, EventArgs e)
        {

         
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void UC_BangKeCt_KeyDown(object sender, KeyEventArgs e)
        {

            // In ra Console để kiểm tra xem UserControl có nhận sự kiện không
            Console.WriteLine("KeyDown event in UserControl");

            // Kiểm tra xem phím nhấn có phải là F5 không
            if (e.KeyCode == Keys.F5)
            {
                // Gọi phương thức xử lý sự kiện lọc
                btnTim.PerformClick();
            }
        }
    }
}
