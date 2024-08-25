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
    public partial class FormMauInHDBH : Form
    {
        private string maHoaDon;

        public FormMauInHDBH(string maHoaDon)
        {
            InitializeComponent();
            this.maHoaDon = maHoaDon;
        }




        BL_BaoCao db = new BL_BaoCao();

        private void FormMauInHDBH_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

            // Gọi phương thức LayMaKHTheoMaHD với giá trị MaHD
            DataTable dt2 = db.LayThongTinTheoMaHD(maHoaDon);

            // Kiểm tra xem DataTable có dữ liệu hay không
            if (dt2.Rows.Count > 0)
            {
                // Lấy các giá trị từ DataTable
                string ngayHD = dt2.Rows[0]["NGAYHD"].ToString();
                string tenKH = dt2.Rows[0]["TENKH"].ToString();
                string diaChi = dt2.Rows[0]["DIACHI"].ToString();
                string sdt = dt2.Rows[0]["SDT"].ToString();
                string dienGiai = dt2.Rows[0]["DIENGIAI"].ToString();
                string tenNV = dt2.Rows[0]["TENNV"].ToString();
                string tongTien= dt2.Rows[0]["TONGTIEN"].ToString();
                string mact= dt2.Rows[0]["MACT"].ToString();
                string soHD = maHoaDon.ToString();


                // Truyền thông tin vào báo cáo
                ReportParameter ngayHDParameter = new ReportParameter("NgayHD", ngayHD);
                ReportParameter tenKHParameter = new ReportParameter("TenKH", tenKH);
                ReportParameter diaChiParameter = new ReportParameter("DiaChi", diaChi);
                ReportParameter sdtParameter = new ReportParameter("Sdt", sdt);
                ReportParameter dienGiaiParameter = new ReportParameter("DienGiai", dienGiai);
                ReportParameter tenNVParameter = new ReportParameter("TenNv", tenNV);
                ReportParameter soHDParameter = new ReportParameter("SoHD", soHD);
                ReportParameter tongTienParameter = new ReportParameter("TongTien", tongTien);
                ReportParameter mactParameter = new ReportParameter("MaCt", mact);

                reportViewer1.LocalReport.SetParameters(new ReportParameter[] { ngayHDParameter, 
                                                                                tenKHParameter, 
                                                                                diaChiParameter, 
                                                                                sdtParameter, 
                                                                                dienGiaiParameter, 
                                                                                tenNVParameter, 
                                                                                soHDParameter, 
                                                                                tongTienParameter, 
                                                                                mactParameter });


            }



            // Gọi phương thức MauInHDBH với giá trị MaHD
            DataTable dt = db.MauInHDBH(maHoaDon);
            reportViewer1.LocalReport.ReportEmbeddedResource = "PMQuanLyCuaHangThuY.Rp_MauInHDBH.rdlc";
            ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
