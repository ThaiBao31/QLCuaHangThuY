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
    public partial class UC_TopNKhachHang : UserControl
    {
        public UC_TopNKhachHang()
        {
            InitializeComponent();
            txtTopN.KeyPress += new KeyPressEventHandler(txtTopN_KeyPress);
        }


        BL_BaoCao db = new BL_BaoCao();


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
            DataTable dt = db.TopNKH(topN, sort);

            // Tiếp tục với mã khác của bạn
            reportViewer1.LocalReport.ReportEmbeddedResource = "PMQuanLyCuaHangThuY.Rp_TopNKhachHang.rdlc";
            ReportDataSource rds = new ReportDataSource("DataSet1", dt);


            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 80;
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

    

        private void lbkSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            UpdateReport();
        }

        private void txtTopN_TextChanged(object sender, EventArgs e)
        {
            UpdateReport();
        }

        private void txtTopN_TextChanged_1(object sender, EventArgs e)
        {
            UpdateReport();
        }

        private void lbkSort_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            UpdateReport();
        }


        private void txtTopN_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự được nhập vào có phải là số hay không
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Nếu không phải số thì hủy sự kiện KeyPress
                e.Handled = true;
            }

            // Kiểm tra xem phím Enter được nhấn hay không
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Nếu là phím Enter, không cho phép xử lý (handled)
                e.Handled = true;
            }



        }


        private void txtTopN_KeyDown(object sender, KeyEventArgs e)
        {
            // Kiểm tra xem phím được nhấn có phải là phím Enter hay không
            if (e.KeyCode == Keys.Enter)
            {
                // Hủy sự kiện KeyDown để không cho phép giá trị được nhập vào ô text box
                e.SuppressKeyPress = true;
            }
        }


    }
}
