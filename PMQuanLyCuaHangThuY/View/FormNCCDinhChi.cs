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
    public partial class FormNCCDinhChi : Form
    {
        public FormNCCDinhChi()
        {
            InitializeComponent();
        }

        BL_NhaCungCap db = new BL_NhaCungCap();


        private void dtgvDataVatTuDinhChi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void HienThiNhaCungCap()
        {
           

            dtgvDataNCCDinhChi.DataSource = db.HienThiNCCDinhChi();

            dtgvDataNCCDinhChi.Columns[0].HeaderText = "Mã NCC";
            dtgvDataNCCDinhChi.Columns[1].HeaderText = "Tên NCC";
            dtgvDataNCCDinhChi.Columns[2].HeaderText = "Nhóm";
            dtgvDataNCCDinhChi.Columns[3].HeaderText = "Địa chỉ";
            dtgvDataNCCDinhChi.Columns[4].HeaderText = "Số điện thoại";
            dtgvDataNCCDinhChi.Columns[5].HeaderText = "Fax";
            dtgvDataNCCDinhChi.Columns[6].HeaderText = "Mã số thuế";
            dtgvDataNCCDinhChi.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvDataNCCDinhChi.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvDataNCCDinhChi.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvDataNCCDinhChi.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvDataNCCDinhChi.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvDataNCCDinhChi.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvDataNCCDinhChi.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            UC_NhanVien.CustomDataGridView(dtgvDataNCCDinhChi);
        }

        private void FormNCCDinhChi_Load(object sender, EventArgs e)
        {
            HienThiNhaCungCap();
        }

        private void btnKhoiPhuc_Click(object sender, EventArgs e)
        {
            if (dtgvDataNCCDinhChi.Rows.Count == 0)
            {
                return;
            }
            DataGridViewRow row = this.dtgvDataNCCDinhChi.Rows[dtgvDataNCCDinhChi.CurrentCell.RowIndex];

            DialogResult dr = MessageBox.Show("Bạn có muốn khôi phục dữ liệu này ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    db.KhoiPhuc(dtgvDataNCCDinhChi.Rows[dtgvDataNCCDinhChi.CurrentCell.RowIndex].Cells[0].Value.ToString());
                    MessageBox.Show("Đã khôi phục thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    HienThiNhaCungCap();
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
    }
}
