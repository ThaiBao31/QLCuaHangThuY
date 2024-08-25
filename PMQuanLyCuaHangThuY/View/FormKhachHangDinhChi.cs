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
    public partial class FormKhachHangDinhChi : Form
    {
        public FormKhachHangDinhChi()
        {
            InitializeComponent();
        }
        BL_KhachHang db = new BL_KhachHang();

        private void HienThiKhachHangDinhChi()
        {
           
            dtgvDataKHDinhChi.DataSource = db.HienThiKHDinhChi();

            dtgvDataKHDinhChi.Columns[0].HeaderText = "Mã KH";
            dtgvDataKHDinhChi.Columns[1].HeaderText = "Tên KH";
            dtgvDataKHDinhChi.Columns[2].HeaderText = "Nhóm";
            dtgvDataKHDinhChi.Columns[3].HeaderText = "Ngày sinh";
            dtgvDataKHDinhChi.Columns[4].HeaderText = "Giới tính";
            dtgvDataKHDinhChi.Columns[5].HeaderText = "Địa chỉ";
            dtgvDataKHDinhChi.Columns[6].HeaderText = "Số điện thoại";
            dtgvDataKHDinhChi.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvDataKHDinhChi.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvDataKHDinhChi.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvDataKHDinhChi.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvDataKHDinhChi.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvDataKHDinhChi.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvDataKHDinhChi.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                  
            UC_NhanVien.CustomDataGridView(dtgvDataKHDinhChi);
        }



        private void dtgvDataNhomDinhChi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormKhachHangDinhChi_Load(object sender, EventArgs e)
        {
            HienThiKhachHangDinhChi();
        }

        private void btnKhoiPhuc_Click(object sender, EventArgs e)
        {
            if (dtgvDataKHDinhChi.Rows.Count == 0)
            {
                return;
            }
            DataGridViewRow row = this.dtgvDataKHDinhChi.Rows[dtgvDataKHDinhChi.CurrentCell.RowIndex];

            DialogResult dr = MessageBox.Show("Bạn có muốn khôi phục dữ liệu này ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    db.KhoiPhuc(dtgvDataKHDinhChi.Rows[dtgvDataKHDinhChi.CurrentCell.RowIndex].Cells[0].Value.ToString());
                    MessageBox.Show("Đã khôi phục thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    HienThiKhachHangDinhChi();
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
