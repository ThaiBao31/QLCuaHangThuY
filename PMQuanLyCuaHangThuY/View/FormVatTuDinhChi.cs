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
    public partial class FormVatTuDinhChi : Form
    {
        public FormVatTuDinhChi()
        {
            InitializeComponent();
        }

        BL_VatTu db = new BL_VatTu();


        private void dtgvDataVatTuDinhChi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void HienThiVatTuDinhchi()
        {
                  
            dtgvDataVatTuDinhChi.DataSource = db.HienThiVatTuDinhChi();

            DataTable data = db.HienThiVatTuDinhChi();
            dtgvDataVatTuDinhChi.DataSource = data;

            dtgvDataVatTuDinhChi.Columns[0].HeaderText = "Mã VT";
            dtgvDataVatTuDinhChi.Columns[1].HeaderText = "Tên VT";
            dtgvDataVatTuDinhChi.Columns[2].HeaderText = "Nhóm"; 
            dtgvDataVatTuDinhChi.Columns[3].HeaderText = "Đơn vị tính";
            dtgvDataVatTuDinhChi.Columns[4].HeaderText = "Mô tả";
            dtgvDataVatTuDinhChi.Columns[5].HeaderText = "Khối lượng";
            dtgvDataVatTuDinhChi.Columns[6].HeaderText = "Kích thước";
            dtgvDataVatTuDinhChi.Columns[7].HeaderText = "Đơn giá";

            dtgvDataVatTuDinhChi.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvDataVatTuDinhChi.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvDataVatTuDinhChi.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvDataVatTuDinhChi.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvDataVatTuDinhChi.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvDataVatTuDinhChi.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvDataVatTuDinhChi.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvDataVatTuDinhChi.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            //thêm định dạng số
            dtgvDataVatTuDinhChi.Columns[5].DefaultCellStyle.Format = "N2"; // Khối lượng
            dtgvDataVatTuDinhChi.Columns[6].DefaultCellStyle.Format = "N2"; // Kích thước
            dtgvDataVatTuDinhChi.Columns[7].DefaultCellStyle.Format = "N0"; // Đơn giá

            // Căn lề các cột "khối lượng", "kích thước", "đơn giá" bên phải
            dtgvDataVatTuDinhChi.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dtgvDataVatTuDinhChi.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dtgvDataVatTuDinhChi.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dtgvDataVatTuDinhChi.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#ADC7E7"); // Màu nền cho tiêu đề cột
            dtgvDataVatTuDinhChi.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black; // Màu chữ cho tiêu đề cột
            dtgvDataVatTuDinhChi.EnableHeadersVisualStyles = false; // Vô hiệu hóa màu mặc định cho tiêu đề cột

            // Để in đậm tiêu đề cột, sử dụng FontStyle.Bold cho Font của tiêu đề
            dtgvDataVatTuDinhChi.ColumnHeadersDefaultCellStyle.Font = new Font(dtgvDataVatTuDinhChi.Font, FontStyle.Bold);

            UC_NhanVien.CustomDataGridView(dtgvDataVatTuDinhChi);
        }

        private void FormVatTuDinhChi_Load(object sender, EventArgs e)
        {
            HienThiVatTuDinhchi();
        }

        private void btnKhoiPhuc_Click(object sender, EventArgs e)
        {
            if (dtgvDataVatTuDinhChi.Rows.Count == 0)
            {
                return;
            }
            DataGridViewRow row = this.dtgvDataVatTuDinhChi.Rows[dtgvDataVatTuDinhChi.CurrentCell.RowIndex];

            DialogResult dr = MessageBox.Show("Bạn có muốn khôi phục dữ liệu này ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    db.KhoiPhuc(dtgvDataVatTuDinhChi.Rows[dtgvDataVatTuDinhChi.CurrentCell.RowIndex].Cells[0].Value.ToString());
                    MessageBox.Show("Đã khôi phục thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    HienThiVatTuDinhchi();
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
