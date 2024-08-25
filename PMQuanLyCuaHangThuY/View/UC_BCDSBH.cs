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
    public partial class UC_BCDSBH : UserControl
    {
        public UC_BCDSBH()
        {
            InitializeComponent();
        }
        BL_BaoCao db = new BL_BaoCao();
        public static UC_BCDSBH ucBCDSBH = new UC_BCDSBH();
        private void UC_BCDSBH_Load(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            DataTable dt = db.BCDSBH(dtNgay1.Value.ToString("yyyy-MM-dd"), dtNgay2.Value.ToString("yyyy-MM-dd"),txtMa.Text.Trim());
            reportViewer1.LocalReport.ReportEmbeddedResource = "PMQuanLyCuaHangThuY.Rp_BCDSBH.rdlc";
            ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            ReportParameter[] parameters = new ReportParameter[2];
            parameters[0] = new ReportParameter("ngayct1", dtNgay1.Value.ToString("dd/MM/yyyy"), true);
            parameters[1] = new ReportParameter("ngayct2", dtNgay2.Value.ToString("dd/MM/yyyy"), true);
            reportViewer1.LocalReport.SetParameters(parameters);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 120;
            this.reportViewer1.RefreshReport();
        }

        private void dtNgay1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtMa_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
