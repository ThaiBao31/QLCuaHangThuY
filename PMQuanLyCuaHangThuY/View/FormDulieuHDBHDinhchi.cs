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
    public partial class FormDulieuHDBHDinhchi : Form
    {
        public FormDulieuHDBHDinhchi()
        {
            InitializeComponent();
        }

        BL_HDBH db = new BL_HDBH();

        private void HienThi()
        {
            HienThiHoaDonDinhChi();
            if (dtgvDataHDBHDinhChi.Rows.Count > 0)
            {
                var row = this.dtgvDataHDBHDinhChi.Rows[0];
                HienThiChiTietHoaDon(row.Cells["MaHD"].Value.ToString());
            }
            else
            {
                HienThiChiTietHoaDon("");
            }
        }


        private void HienThiHoaDonDinhChi()
        {
            dtgvDataHDBHDinhChi.DataSource = db.HienThiHOADONDinhChi();
            dtgvDataHDBHDinhChi.Columns[0].HeaderText = "Mã HD";
            dtgvDataHDBHDinhChi.Columns[1].HeaderText = "Mã KH";
            dtgvDataHDBHDinhChi.Columns[2].HeaderText = "Tên KH";
            dtgvDataHDBHDinhChi.Columns[3].HeaderText = "Ngày HĐ";
            dtgvDataHDBHDinhChi.Columns[4].HeaderText = "Mã NV";
            dtgvDataHDBHDinhChi.Columns[5].HeaderText = "Tên NV";
            dtgvDataHDBHDinhChi.Columns[6].HeaderText = "Tổng tiền";
            dtgvDataHDBHDinhChi.Columns[7].HeaderText = "Trạng thái";
            dtgvDataHDBHDinhChi.Columns[8].HeaderText = "Diễn giải";
            dtgvDataHDBHDinhChi.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvDataHDBHDinhChi.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvDataHDBHDinhChi.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvDataHDBHDinhChi.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvDataHDBHDinhChi.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvDataHDBHDinhChi.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvDataHDBHDinhChi.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvDataHDBHDinhChi.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvDataHDBHDinhChi.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            // Cấu hình định dạng cho cột "Tổng tiền"
            dtgvDataHDBHDinhChi.Columns[6].DefaultCellStyle.Format = "N0";
            dtgvDataHDBHDinhChi.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;


            UC_NhanVien.CustomDataGridView(dtgvDataHDBHDinhChi);
        }

        private void HienThiChiTietHoaDon(string value)
        {
            dtgvCTHD.DataSource = db.HienThiCHITIETHOADON(value);
            dtgvCTHD.Columns[0].HeaderText = "Mã HĐ";
            dtgvCTHD.Columns[1].HeaderText = "Mã VT";
            dtgvCTHD.Columns[2].HeaderText = "Tên VT";
            dtgvCTHD.Columns[3].HeaderText = "Đơn giá";
            dtgvCTHD.Columns[4].HeaderText = "Số lượng";
            dtgvCTHD.Columns[5].HeaderText = "Thành tiền";
            dtgvCTHD.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvCTHD.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvCTHD.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvCTHD.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvCTHD.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvCTHD.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            // Cấu hình định dạng cho cột "Đơn giá"
            dtgvCTHD.Columns[3].DefaultCellStyle.Format = "N0";
            dtgvCTHD.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // Cấu hình định dạng cho cột "Số lượng"
            dtgvCTHD.Columns[4].DefaultCellStyle.Format = "N2";
            dtgvCTHD.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // Cấu hình định dạng cho cột "Thành tiền"
            dtgvCTHD.Columns[5].DefaultCellStyle.Format = "N0";
            dtgvCTHD.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;


            UC_NhanVien.CustomDataGridView(dtgvCTHD);
        }




        private void dtgvDataHDBHDinhChi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormDulieuHDBHDinhchi_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void btnKhoiPhuc_Click(object sender, EventArgs e)
        {
           
                if (dtgvDataHDBHDinhChi.Rows.Count == 0)
                {
                    return;
                }
                DataGridViewRow row = this.dtgvDataHDBHDinhChi.Rows[dtgvDataHDBHDinhChi.CurrentCell.RowIndex];

                DialogResult dr = MessageBox.Show("Bạn có muốn khôi phục dữ liệu này ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        db.KhoiPhuc(dtgvDataHDBHDinhChi.Rows[dtgvDataHDBHDinhChi.CurrentCell.RowIndex].Cells[0].Value.ToString());
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

        private void dtgvCTHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
