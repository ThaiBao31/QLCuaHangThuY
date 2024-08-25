using Microsoft.Reporting.WinForms;
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
    public partial class UC_DanhSachVatTu : UserControl
    {
        public static UC_DanhSachVatTu ucDSVT = new UC_DanhSachVatTu();
        public UC_DanhSachVatTu()
        {
            InitializeComponent();
        }



        private void reportViewer1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds_VatTu.VATTU' table. You can move, or remove it, as needed.
            this.vATTUTableAdapter.Fill(this.ds_VatTu.VATTU);
            this.reportViewer1.RefreshReport();
        }
    }
}
