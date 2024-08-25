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
    public partial class DoanhSoNV : Form
    {
        public DoanhSoNV()
        {
            InitializeComponent();
        }

        BL_BaoCao db = new BL_BaoCao();


        private void DoanhSoNV_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }



        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            //DataTable dt = db.HoaDonBH(dtNgay1.Value.ToString("yyyy-MM-dd"), dtNgay2.Value.ToString("yyyy-MM-dd"));
            //reportViewer1.LocalReport.ReportEmbeddedResource = "PMQuanLyCuaHangThuY.Rp_DoanhSoBanHangTheoNhanVien.rdlc";
            //ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            ////ReportParameter[] parameters = new ReportParameter[2];
            ////parameters[0] = new ReportParameter("ngayct1", dtNgay1.Value.ToString("dd/MM/yyyy"), true);
            ////parameters[1] = new ReportParameter("ngayct2", dtNgay2.Value.ToString("dd/MM/yyyy"), true);
            ////reportViewer1.LocalReport.SetParameters(parameters);
            //reportViewer1.LocalReport.DataSources.Clear();
            //reportViewer1.LocalReport.DataSources.Add(rds);
            //this.reportViewer1.RefreshReport();



        }

        private void dtNgay1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dtNgay2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
