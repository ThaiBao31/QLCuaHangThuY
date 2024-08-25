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

namespace PMQuanLyCuaHangThuY
{
    public partial class BaoCaoDoanhSoVtTheoThang : Form
    {
        public BaoCaoDoanhSoVtTheoThang()
        {
            InitializeComponent();
        }


        BL_BaoCao db = new BL_BaoCao();


        private void BaoCaoDoanhSoVtTheoThang_Load(object sender, EventArgs e)
        {

            //DataTable dt = db.BCDSVTTT(dtNgay1.Value.ToString("yyyy-MM-dd"), dtNgay2.Value.ToString("yyyy-MM-dd"));
            //reportViewer1.LocalReport.ReportEmbeddedResource = "PMQuanLyCuaHangThuY.Rp_DoanhSoVatTuTheoThang.rdlc";
            //ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            ////ReportParameter[] parameters = new ReportParameter[2];
            ////parameters[0] = new ReportParameter("Ngay1", dtNgay1.Value.ToString("dd/MM/yyyy"), true);
            ////parameters[1] = new ReportParameter("Ngay2", dtNgay2.Value.ToString("dd/MM/yyyy"), true);
            ////reportViewer1.LocalReport.SetParameters(parameters);
            //reportViewer1.LocalReport.DataSources.Clear();
            //reportViewer1.LocalReport.DataSources.Add(rds);
            //this.reportViewer1.RefreshReport();

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
