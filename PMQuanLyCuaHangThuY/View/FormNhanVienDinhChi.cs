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
    public partial class FormNhanVienDinhChi : Form
    {
        public FormNhanVienDinhChi()
        {
            InitializeComponent();
        }

        BL_NhanVien db = new BL_NhanVien();


        private void dtgvDataNVDinhChi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void HienThiNhanVien()
        {
            dtgvDataNVDinhChi.DataSource = db.HienThiNVDinhChi();
            dtgvDataNVDinhChi.Columns[0].HeaderText = "Mã nhân viên";
            dtgvDataNVDinhChi.Columns[1].HeaderText = "Tên nhân viên";
            dtgvDataNVDinhChi.Columns[2].HeaderText = "Điện thoại";
            dtgvDataNVDinhChi.Columns[3].HeaderText = "Địa chỉ";
            dtgvDataNVDinhChi.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvDataNVDinhChi.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvDataNVDinhChi.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvDataNVDinhChi.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            UC_NhanVien.CustomDataGridView(dtgvDataNVDinhChi); 
        }

        private void FormNhanVienDinhChi_Load(object sender, EventArgs e)
        {
            HienThiNhanVien();
        }

        private void btnKhoiPhuc_Click(object sender, EventArgs e)
        {
            if (dtgvDataNVDinhChi.Rows.Count == 0)
            {
                return;
            }
            DataGridViewRow row = this.dtgvDataNVDinhChi.Rows[dtgvDataNVDinhChi.CurrentCell.RowIndex];

            DialogResult dr = MessageBox.Show("Bạn có muốn khôi phục dữ liệu này ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    db.KhoiPhuc(dtgvDataNVDinhChi.Rows[dtgvDataNVDinhChi.CurrentCell.RowIndex].Cells[0].Value.ToString());
                    MessageBox.Show("Đã khôi phục thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    HienThiNhanVien();
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
