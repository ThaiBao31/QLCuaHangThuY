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
    public partial class FormHBTLDinhChi : Form
    {
        public FormHBTLDinhChi()
        {
            InitializeComponent();
        }

        BL_HBTL db = new BL_HBTL();
        private void HienThi()
        {
            HienThiHBTLDinhChi();
            if (dtgvDataHBTLDinhChi.Rows.Count > 0)
            {
                var row = this.dtgvDataHBTLDinhChi.Rows[0];
                HienThiChiTietHoaDon(row.Cells["MaHD"].Value.ToString());
            }
            else
            {
                HienThiChiTietHoaDon("");
            }
        }

        private void dtgvDataHDBHDinhChi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void HienThiHBTLDinhChi()
        {
            dtgvDataHBTLDinhChi.DataSource = db.HienThiHBTLDinhChi();
            dtgvDataHBTLDinhChi.Columns[0].HeaderText = "Mã HD";
            dtgvDataHBTLDinhChi.Columns[1].HeaderText = "Mã KH";
            dtgvDataHBTLDinhChi.Columns[2].HeaderText = "Tên KH";
            dtgvDataHBTLDinhChi.Columns[3].HeaderText = "Ngày HĐ";
            dtgvDataHBTLDinhChi.Columns[4].HeaderText = "Mã NV";
            dtgvDataHBTLDinhChi.Columns[5].HeaderText = "Tên NV";
            dtgvDataHBTLDinhChi.Columns[6].HeaderText = "Tổng tiền";
            dtgvDataHBTLDinhChi.Columns[7].HeaderText = "Trạng thái";
            dtgvDataHBTLDinhChi.Columns[8].HeaderText = "Diễn giải";
            dtgvDataHBTLDinhChi.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvDataHBTLDinhChi.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvDataHBTLDinhChi.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvDataHBTLDinhChi.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvDataHBTLDinhChi.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvDataHBTLDinhChi.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvDataHBTLDinhChi.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvDataHBTLDinhChi.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvDataHBTLDinhChi.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;


            // Cấu hình định dạng cho cột "Tổng tiền"
            dtgvDataHBTLDinhChi.Columns[6].DefaultCellStyle.Format = "N0";
            dtgvDataHBTLDinhChi.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;




            UC_NhanVien.CustomDataGridView(dtgvDataHBTLDinhChi);
        }

        private void HienThiChiTietHoaDon(string value)
        {
            dtgvChiTietHBTL.DataSource = db.HienThiCHITIETHOADON(value);
            dtgvChiTietHBTL.Columns[0].HeaderText = "Mã HĐ";
            dtgvChiTietHBTL.Columns[1].HeaderText = "Mã VT";
            dtgvChiTietHBTL.Columns[2].HeaderText = "Tên VT";
            dtgvChiTietHBTL.Columns[3].HeaderText = "Đơn giá";
            dtgvChiTietHBTL.Columns[4].HeaderText = "Số lượng";
            dtgvChiTietHBTL.Columns[5].HeaderText = "Thành tiền";
            dtgvChiTietHBTL.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvChiTietHBTL.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvChiTietHBTL.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvChiTietHBTL.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvChiTietHBTL.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvChiTietHBTL.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            // Cấu hình định dạng cho cột "Đơn giá"
            dtgvChiTietHBTL.Columns[3].DefaultCellStyle.Format = "N0";
            dtgvChiTietHBTL.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // Cấu hình định dạng cho cột "Số lượng"
            dtgvChiTietHBTL.Columns[4].DefaultCellStyle.Format = "N2";
            dtgvChiTietHBTL.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // Cấu hình định dạng cho cột "Thành tiền"
            dtgvChiTietHBTL.Columns[5].DefaultCellStyle.Format = "N0";
            dtgvChiTietHBTL.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;


            UC_NhanVien.CustomDataGridView(dtgvChiTietHBTL);
        }




        private void FormHBTLDinhChi_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void btnKhoiPhuc_Click(object sender, EventArgs e)
        {
            if (dtgvDataHBTLDinhChi.Rows.Count == 0)
            {
                return;
            }
            DataGridViewRow row = this.dtgvDataHBTLDinhChi.Rows[dtgvDataHBTLDinhChi.CurrentCell.RowIndex];

            DialogResult dr = MessageBox.Show("Bạn có muốn khôi phục dữ liệu này ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    db.KhoiPhuc(dtgvDataHBTLDinhChi.Rows[dtgvDataHBTLDinhChi.CurrentCell.RowIndex].Cells[0].Value.ToString());
                    MessageBox.Show("Đã khôi phục thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    HienThi();
                }
                catch (Exception)
                {
                    { MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                    return;
                }
            }
            else
                return;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
