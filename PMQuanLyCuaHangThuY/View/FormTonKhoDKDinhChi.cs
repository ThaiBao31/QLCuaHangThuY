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
    public partial class FormTonKhoDKDinhChi : Form
    {
        public FormTonKhoDKDinhChi()
        {
            InitializeComponent();
            this.FormClosed += FormTonKhoDKDinhChi_FormClosed;
        }

        // Declare an event to notify when the form is closed
        public event EventHandler FormClosedEvent;

        // ... existing code ...

        private void FormTonKhoDKDinhChi_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Raise the event when the form is closed
            FormClosedEvent?.Invoke(this, EventArgs.Empty);
        }




        BL_TonKhoDauKy db = new BL_TonKhoDauKy();
        private void dtgvDataTKDKDinhChi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void HienThiTonKhoDauKy()
        {
            dtgvDataTKDKDinhChi.DataSource = db.HienThiTKDKDinhChi();
            dtgvDataTKDKDinhChi.Columns[0].HeaderText = "Mã VT";
            dtgvDataTKDKDinhChi.Columns[1].HeaderText = "Tên VT";
            dtgvDataTKDKDinhChi.Columns[2].HeaderText = "Đơn vị tính";
            dtgvDataTKDKDinhChi.Columns[3].HeaderText = "Số lượng";
            dtgvDataTKDKDinhChi.Columns[4].HeaderText = "Đơn giá";
            dtgvDataTKDKDinhChi.Columns[5].HeaderText = "Thành tiền";
            dtgvDataTKDKDinhChi.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvDataTKDKDinhChi.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvDataTKDKDinhChi.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvDataTKDKDinhChi.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvDataTKDKDinhChi.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvDataTKDKDinhChi.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;


            dtgvDataTKDKDinhChi.Columns[3].DefaultCellStyle.Format = "N2";
            dtgvDataTKDKDinhChi.Columns[4].DefaultCellStyle.Format = "N0";
            dtgvDataTKDKDinhChi.Columns[5].DefaultCellStyle.Format = "N0";

            // Căn lề các cột "khối lượng", "kích thước", "đơn giá" bên phải
            dtgvDataTKDKDinhChi.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dtgvDataTKDKDinhChi.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dtgvDataTKDKDinhChi.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

        


            UC_NhanVien.CustomDataGridView(dtgvDataTKDKDinhChi);
        }

        private void FormTonKhoDKDinhChi_Load(object sender, EventArgs e)
        {
            HienThiTonKhoDauKy();
        }

        private void btnKhoiPhuc_Click(object sender, EventArgs e)
        {
            if (dtgvDataTKDKDinhChi.Rows.Count == 0)
            {
                return;
            }
            DataGridViewRow row = this.dtgvDataTKDKDinhChi.Rows[dtgvDataTKDKDinhChi.CurrentCell.RowIndex];

            DialogResult dr = MessageBox.Show("Bạn có muốn khôi phục dữ liệu này ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    db.KhoiPhuc(dtgvDataTKDKDinhChi.Rows[dtgvDataTKDKDinhChi.CurrentCell.RowIndex].Cells[0].Value.ToString());
                    MessageBox.Show("Đã khôi phục thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                    // Raise the FormClosedEvent before reloading data
                    FormClosedEvent?.Invoke(this, EventArgs.Empty);

                    HienThiTonKhoDauKy();
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
