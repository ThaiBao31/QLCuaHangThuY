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
    public partial class FormDulieuNhomDinhChi : Form
    {
        public FormDulieuNhomDinhChi()
        {
            InitializeComponent();
        }

        BL_Nhom db = new BL_Nhom();

        private void dtgvDataHDBHDinhChi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void HienThiNhomDinhChi()
        {
            dtgvDataNhomDinhChi.DataSource = db.HienThiNhomDinhChi();
            dtgvDataNhomDinhChi.Columns[0].HeaderText = "Mã nhóm";
            dtgvDataNhomDinhChi.Columns[1].HeaderText = "Tên nhóm";
            dtgvDataNhomDinhChi.Columns[2].HeaderText = "Loại";
            dtgvDataNhomDinhChi.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvDataNhomDinhChi.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvDataNhomDinhChi.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            UC_NhanVien.CustomDataGridView(dtgvDataNhomDinhChi);
        }

        private void FormDulieuNhomDinhChi_Load(object sender, EventArgs e)
        {
            HienThiNhomDinhChi();
        }

        private void btnKhoiPhuc_Click(object sender, EventArgs e)
        {
            if (dtgvDataNhomDinhChi.Rows.Count == 0)
            {
                return;
            }
            DataGridViewRow row = this.dtgvDataNhomDinhChi.Rows[dtgvDataNhomDinhChi.CurrentCell.RowIndex];

            DialogResult dr = MessageBox.Show("Bạn có muốn khôi phục dữ liệu này ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    db.KhoiPhuc(dtgvDataNhomDinhChi.Rows[dtgvDataNhomDinhChi.CurrentCell.RowIndex].Cells[0].Value.ToString());
                    MessageBox.Show("Đã khôi phục thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    HienThiNhomDinhChi();
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
