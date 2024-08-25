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
    public partial class UC_DoanhSoNhanVien : UserControl
    {
        public UC_DoanhSoNhanVien()
        {
            InitializeComponent();
        }

        BL_BaoCao db = new BL_BaoCao();


        public static UC_DoanhSoNhanVien ucDSNV = new UC_DoanhSoNhanVien();


        private void btnTim_Click(object sender, EventArgs e)
        {
            string NhanVien = lbkNhanVien.SelectedValue != null ? lbkNhanVien.SelectedValue.ToString() : null;


            DataTable dt = db.HoaDonBH(dtNgay1.Value.ToString("yyyy-MM-dd"), dtNgay2.Value.ToString("yyyy-MM-dd"), NhanVien);
            reportViewer1.LocalReport.ReportEmbeddedResource = "PMQuanLyCuaHangThuY.Rp_DoanhSoBanHangTheoNhanVien.rdlc";
            ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            ReportParameter[] parameters = new ReportParameter[2];
            parameters[0] = new ReportParameter("ngayct1", dtNgay1.Value.ToString("dd/MM/yyyy"), true);
            parameters[1] = new ReportParameter("ngayct2", dtNgay2.Value.ToString("dd/MM/yyyy"), true);
            reportViewer1.LocalReport.SetParameters(parameters);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }

        private void UC_DoanhSoNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds_VatTu.VATTU' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this.ds_NhanVien.NHANVIEN);
            this.reportViewer1.RefreshReport();
        }

        private void lbkNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
