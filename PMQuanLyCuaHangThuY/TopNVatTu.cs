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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PMQuanLyCuaHangThuY
{
    public partial class TopNVatTu : Form
    {
        public TopNVatTu()
        {
            InitializeComponent();
        } 

        BL_BaoCao db = new BL_BaoCao();




        private void txtTopN_TextChanged_1(object sender, EventArgs e)
        {
            // Gọi phương thức để cập nhật báo cáo khi giá trị thay đổi
            UpdateReport();
        }

        private void lbkSort_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Gọi phương thức để cập nhật báo cáo khi giá trị thay đổi
            UpdateReport();
        }


        private void UpdateReport()
        {
            // Khởi tạo giá trị mặc định
            int topN = 5;
            string sort = "DESC";

            // Kiểm tra và cập nhật giá trị nếu người dùng nhập giá trị trong TextBox
            if (!string.IsNullOrEmpty(txtTopN.Text) && int.TryParse(txtTopN.Text, out int topNFromTextBox))
            {
                topN = topNFromTextBox;
            }

            // Kiểm tra và cập nhật giá trị nếu người dùng chọn giá trị trong ComboBox
            if (lbkSort.SelectedItem != null)
            {
                string selectedValue = lbkSort.SelectedItem.ToString();
                sort = (selectedValue == "Cao nhất") ? "DESC" : "ASC";
            }

            // Gọi phương thức TopNVatTu với các giá trị đã được cập nhật
            DataTable dt = db.TopNVatTu(topN, sort);

            // Tiếp tục với mã khác của bạn
            reportViewer1.LocalReport.ReportEmbeddedResource = "PMQuanLyCuaHangThuY.Rp_TopNVatTu.rdlc";
            ReportDataSource rds = new ReportDataSource("DataSet1", dt);

            //// Khai báo các ReportParameter
            //ReportParameter[] parameters = new ReportParameter[2];
            //parameters[0] = new ReportParameter("TopN", topN.ToString(), true);
            //parameters[1] = new ReportParameter("Sort", sort, true);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }


        private void TopNVatTu_Load(object sender, EventArgs e)
        {

            UpdateReport();

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            UpdateReport();
        }

     
   

    }
}
