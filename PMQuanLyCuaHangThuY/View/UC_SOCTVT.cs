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
    public partial class UC_SOCTVT : UserControl
    {
        public UC_SOCTVT()
        {
            InitializeComponent();
        }

        public static UC_SOCTVT ucSCTVT = new UC_SOCTVT();

        BL_BaoCao db = new BL_BaoCao();


   

        private void btnTim_Click(object sender, EventArgs e)
        {
            string VatTu = lbkVatTu.SelectedValue != null ? lbkVatTu.SelectedValue.ToString() : null;

            DataTable dtMaTenVatTu = db.GetMaTenVatTu(VatTu);

            // Lấy tên vật tư từ DataTable mới
            string TenVatTu = dtMaTenVatTu.Rows.Count > 0 ? dtMaTenVatTu.Rows[0]["MaTenVatTu"].ToString() : "";


            DataTable dt = db.SOCTVT(dtNgay1.Value.ToString("yyyy-MM-dd"), dtNgay2.Value.ToString("yyyy-MM-dd"), VatTu);
            reportViewer1.LocalReport.ReportEmbeddedResource = "PMQuanLyCuaHangThuY.Rp_SoChiTietVT.rdlc";
            ReportDataSource rds = new ReportDataSource("DataSet1", dt);

            ReportParameter[] parameters = new ReportParameter[3];
            parameters[0] = new ReportParameter("ngayct1", dtNgay1.Value.ToString("dd/MM/yyyy"), true);
            parameters[1] = new ReportParameter("ngayct2", dtNgay2.Value.ToString("dd/MM/yyyy"), true);
            parameters[2] = new ReportParameter("VatTu", TenVatTu, true);
            reportViewer1.LocalReport.SetParameters(parameters);
            reportViewer1.LocalReport.SetParameters(parameters);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 120;
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbkVatTu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UC_SOCTVT_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds_VatTu.VATTU' table. You can move, or remove it, as needed.
            this.vATTUTableAdapter.Fill(this.ds_VatTu.VATTU);
            // Set giá trị mặc định cho lbkVatTu là null hoặc giá trị trống
            lbkVatTu.SelectedIndex = -1; // hoặc lbkVatTu.Text = "";

            this.reportViewer1.RefreshReport();
        }
    }
}
