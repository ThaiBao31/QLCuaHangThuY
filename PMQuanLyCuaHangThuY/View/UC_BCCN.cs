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
    public partial class UC_BCCN : UserControl
    {
        public UC_BCCN()
        {
            InitializeComponent();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        BL_BaoCao db = new BL_BaoCao();

        public static UC_BCCN ucBCCN = new UC_BCCN();

        private void btnTim_Click(object sender, EventArgs e)
        {
            string DoiTuong = lbkDoiTuong.SelectedValue != null ? lbkDoiTuong.SelectedValue.ToString() : null;

            DataTable dt = db.BCCN(dtNgay1.Value.ToString("yyyy-MM-dd"), dtNgay2.Value.ToString("yyyy-MM-dd"), DoiTuong);
            reportViewer1.LocalReport.ReportEmbeddedResource = "PMQuanLyCuaHangThuY.Rp_BCCongno2.rdlc";
            ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            ReportParameter[] parameters = new ReportParameter[2];
            parameters[0] = new ReportParameter("ngayct1", dtNgay1.Value.ToString("dd/MM/yyyy"), true);
            parameters[1] = new ReportParameter("ngayct2", dtNgay2.Value.ToString("dd/MM/yyyy"), true);
            reportViewer1.LocalReport.SetParameters(parameters);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }

        private void UC_BCCN_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds_VatTu.VATTU' table. You can move, or remove it, as needed.
            this.kHACHHANGTableAdapter.Fill(this.ds_DMDoiTuong.KHACHHANG);
            // Set giá trị mặc định cho lbkVatTu là null hoặc giá trị trống
            lbkDoiTuong.SelectedIndex = -1; // hoặc lbkVatTu.Text = "";

            this.reportViewer1.RefreshReport();
        }
    }
}
