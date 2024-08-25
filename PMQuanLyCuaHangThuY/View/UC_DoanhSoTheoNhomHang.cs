using Microsoft.Reporting.WinForms;
using PMQuanLyCuaHangThuY.BL;
using PMQuanLyCuaHangThuY.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMQuanLyCuaHangThuY
{
    public partial class UC_DoanhSoTheoNhomHang : UserControl
    {
        public UC_DoanhSoTheoNhomHang()
        {
            InitializeComponent();
        }

        BL_BaoCao db = new BL_BaoCao();

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        public static UC_DoanhSoTheoNhomHang ucDoanhSoTheoNhomHang = new UC_DoanhSoTheoNhomHang();



        private void btnTim_Click(object sender, EventArgs e)
        {
            DataTable dt = db.BGDSNHOMHANG(dtNgay1.Value.ToString("yyyy-MM-dd"), dtNgay2.Value.ToString("yyyy-MM-dd"));
            reportViewer1.LocalReport.ReportEmbeddedResource = "PMQuanLyCuaHangThuY.Rp_DsNhomHang.rdlc";
            ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            //ReportParameter[] parameters = new ReportParameter[2];
            //parameters[0] = new ReportParameter("ngayct1", dtNgay1.Value.ToString("dd/MM/yyyy"), true);
            //parameters[1] = new ReportParameter("ngayct2", dtNgay2.Value.ToString("dd/MM/yyyy"), true);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
