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
    public partial class FormHDNhapDinhChi : Form
    {
        public FormHDNhapDinhChi()
        {
            InitializeComponent();
        }

        BL_NhapHang db = new BL_NhapHang();

        private void HienThi()
        {
            HienThiHoaDonDinhChi();
            if (dtgvDataHDNhapDinhChi.Rows.Count > 0)
            {
                var row = this.dtgvDataHDNhapDinhChi.Rows[0];
                HienThiChiTietHoaDon(row.Cells["MaHD"].Value.ToString());
            }
            else
            {
                HienThiChiTietHoaDon("");
            }
        }


        private void dtgvDataHDNhapDinhChi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void HienThiHoaDonDinhChi()
        {
            dtgvDataHDNhapDinhChi.DataSource = db.HienThiHOADONNhapDinhChi();
            dtgvDataHDNhapDinhChi.Columns[0].HeaderText = "Mã HD";
            dtgvDataHDNhapDinhChi.Columns[1].HeaderText = "Mã NCC";
            dtgvDataHDNhapDinhChi.Columns[2].HeaderText = "Tên NCC";
            dtgvDataHDNhapDinhChi.Columns[3].HeaderText = "Ngày HĐ";
            dtgvDataHDNhapDinhChi.Columns[4].HeaderText = "Mã NV";
            dtgvDataHDNhapDinhChi.Columns[5].HeaderText = "Tên NV";
            dtgvDataHDNhapDinhChi.Columns[6].HeaderText = "Tổng tiền";
            dtgvDataHDNhapDinhChi.Columns[7].HeaderText = "Diễn giải";
            dtgvDataHDNhapDinhChi.Columns[8].HeaderText = "Trạng thái";

            dtgvDataHDNhapDinhChi.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvDataHDNhapDinhChi.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvDataHDNhapDinhChi.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvDataHDNhapDinhChi.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvDataHDNhapDinhChi.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvDataHDNhapDinhChi.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvDataHDNhapDinhChi.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvDataHDNhapDinhChi.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvDataHDNhapDinhChi.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;


            // Cấu hình định dạng cho cột "Tổng tiền"
            dtgvDataHDNhapDinhChi.Columns[6].DefaultCellStyle.Format = "N0";
            dtgvDataHDNhapDinhChi.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;


            UC_NhanVien.CustomDataGridView(dtgvDataHDNhapDinhChi);
        }

        private void HienThiChiTietHoaDon(string value)
        {
            dtgvChiTietNhap.DataSource = db.HienThiCHITIETHOADON(value);
            dtgvChiTietNhap.Columns[0].HeaderText = "Mã HĐ";
            dtgvChiTietNhap.Columns[1].HeaderText = "Mã VT";
            dtgvChiTietNhap.Columns[2].HeaderText = "Tên VT";
            dtgvChiTietNhap.Columns[3].HeaderText = "Đơn giá";
            dtgvChiTietNhap.Columns[4].HeaderText = "Số lượng";
            dtgvChiTietNhap.Columns[5].HeaderText = "Thành tiền";
            dtgvChiTietNhap.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvChiTietNhap.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvChiTietNhap.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvChiTietNhap.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvChiTietNhap.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvChiTietNhap.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;


            // Cấu hình định dạng cho cột "Đơn giá"
            dtgvChiTietNhap.Columns[3].DefaultCellStyle.Format = "N0";
            dtgvChiTietNhap.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // Cấu hình định dạng cho cột "Số lượng"
            dtgvChiTietNhap.Columns[4].DefaultCellStyle.Format = "N2";
            dtgvChiTietNhap.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // Cấu hình định dạng cho cột "Thành tiền"
            dtgvChiTietNhap.Columns[5].DefaultCellStyle.Format = "N0";
            dtgvChiTietNhap.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;


            UC_NhanVien.CustomDataGridView(dtgvChiTietNhap);
        }




        private void FormHDNhapDinhChi_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void btnKhoiPhuc_Click(object sender, EventArgs e)
        {
            if (dtgvDataHDNhapDinhChi.Rows.Count == 0)
            {
                return;
            }
            DataGridViewRow row = this.dtgvDataHDNhapDinhChi.Rows[dtgvDataHDNhapDinhChi.CurrentCell.RowIndex];

            DialogResult dr = MessageBox.Show("Bạn có muốn khôi phục dữ liệu này ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    db.KhoiPhuc(dtgvDataHDNhapDinhChi.Rows[dtgvDataHDNhapDinhChi.CurrentCell.RowIndex].Cells[0].Value.ToString());
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

        private void dtgvChiTietNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
