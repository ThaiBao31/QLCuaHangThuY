using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PMQuanLyCuaHangThuY.ds_VatTuTableAdapters;  // Add this line

namespace PMQuanLyCuaHangThuY
{
    public partial class tonkhovt : Form
    {
        private VATTUTableAdapter vATTUTableAdapter;  // Declare the adapter

        public tonkhovt()
        {
            InitializeComponent();
            this.vATTUTableAdapter = new VATTUTableAdapter();  // Initialize the adapter
        }

        private void tonkhovt_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds_VatTu.VATTU' table. You can move, or remove it, as needed.
            this.vATTUTableAdapter1.Fill(this.ds_VatTu.VATTU);
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            
        }

        private void reportViewer1_Load_1(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load_2(object sender, EventArgs e)
        {

        }
    }
}
