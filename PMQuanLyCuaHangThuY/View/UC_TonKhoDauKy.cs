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
    public partial class UC_TonKhoDauKy : UserControl
    {
        public static UC_TonKhoDauKy ucTonKhoDauKy= new UC_TonKhoDauKy();
        BL_TonKhoDauKy db = new BL_TonKhoDauKy();
        public static Boolean save;
        public static string MAVT;
        public static string DVT;
        public static decimal SOLUONG;
        public static decimal DONGIA;
        public static decimal THANHTIEN;


        private FormTonKhoDKDinhChi formTonKhoDKDinhChi;

        public UC_TonKhoDauKy()
        {
            InitializeComponent();

            // Instantiate the form
            formTonKhoDKDinhChi = new FormTonKhoDKDinhChi();

            // Subscribe to the event
            formTonKhoDKDinhChi.FormClosedEvent += FormTonKhoDKDinhChi_FormClosedEvent;

        }

        private void FormTonKhoDKDinhChi_FormClosedEvent(object sender, EventArgs e)
        {
            // Reload data when the FormTonKhoDKDinhChi is closed
            HienThiTonKhoDauKy();
        }



        private bool formLoaded = false;


        private void HienThiTonKhoDauKy()
        {
            dtgvData.DataSource = db.HienThi(txtMa.Text, txtTen.Text);
            dtgvData.Columns[0].HeaderText = "Mã VT";
            dtgvData.Columns[1].HeaderText = "Tên VT";
            dtgvData.Columns[2].HeaderText = "Đơn vị tính";
            dtgvData.Columns[3].HeaderText = "Số lượng";
            dtgvData.Columns[4].HeaderText = "Đơn giá";
            dtgvData.Columns[5].HeaderText = "Thành tiền";
            dtgvData.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvData.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvData.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvData.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvData.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvData.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;


            dtgvData.Columns[3].DefaultCellStyle.Format = "N2";
            dtgvData.Columns[4].DefaultCellStyle.Format = "N0";
            dtgvData.Columns[5].DefaultCellStyle.Format = "N0";

            // Căn lề các cột "khối lượng", "kích thước", "đơn giá" bên phải
            dtgvData.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dtgvData.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dtgvData.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // Hiển thị tổng số bản ghi ban đầu
            UpdateTotalRecordsLabel(dtgvData.Rows.Count, dtgvData.Rows.Count);

            dtgvData.CellClick += new DataGridViewCellEventHandler(dtgvData_CellClick);
            formLoaded = true; // Đánh dấu rằng form đã được tải
            

            UC_NhanVien.CustomDataGridView(dtgvData);
        }
        private void UC_TonKhoDauKy_Load(object sender, EventArgs e)
        {
            HienThiTonKhoDauKy();
        }

        private void dtgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (formLoaded && e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                UpdateTotalRecordsLabel(e.RowIndex + 1, dtgvData.Rows.Count);
            }
        }


        private void UpdateTotalRecordsLabel(int currentRow, int totalRows)
        {
            lblTotalRecords.Text = $"Bản ghi {currentRow}/{totalRows}";
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            save = true;
            FormTonKhoDauKyThongTin frm = new FormTonKhoDauKyThongTin();
            frm.Text = "Thêm mới tồn kho đầu kỳ";
            frm.ShowDialog();
            HienThiTonKhoDauKy();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dtgvData.Rows.Count == 0)
            {
                return;
            }
            DataGridViewRow row = this.dtgvData.Rows[dtgvData.CurrentCell.RowIndex];
            save = false;
            FormTonKhoDauKyThongTin frm = new FormTonKhoDauKyThongTin();
            MAVT = row.Cells[0].Value.ToString();
            DVT = row.Cells[2].Value.ToString();
            SOLUONG = decimal.Parse(row.Cells[3].Value.ToString());
            DONGIA = decimal.Parse(row.Cells[4].Value.ToString());
            THANHTIEN = decimal.Parse(row.Cells[4].Value.ToString());
            frm.Text = "Sửa thông tin tồn kho đầu kỳ";
            frm.ShowDialog();
            HienThiTonKhoDauKy();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dtgvData.Rows.Count == 0)
            {
                return;
            }
            DialogResult dr = MessageBox.Show("Có chắc chắn xóa dòng dữ liệu này không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    db.DinhChi(dtgvData.Rows[dtgvData.CurrentCell.RowIndex].Cells[0].Value.ToString());
                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    HienThiTonKhoDauKy();
                }
                catch (Exception)
                {
                    MessageBox.Show("Dữ liệu của tồn kho đầu kỳ này đã phát sinh, không xóa được", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
                return;
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            app.Visible = true;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            for (int i = 1; i < dtgvData.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dtgvData.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dtgvData.Rows.Count; i++)
            {
                for (int j = 0; j < dtgvData.Columns.Count; j++)
                {
                    if (dtgvData.Rows[i].Cells[j].Value != null)
                    {
                        worksheet.Cells[i + 2, j + 1] = dtgvData.Rows[i].Cells[j].Value.ToString();
                    }
                    else
                    {
                        worksheet.Cells[i + 2, j + 1] = "";
                    }
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMa.Text = "";
            txtTen.Text = "";
            HienThiTonKhoDauKy();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            HienThiTonKhoDauKy();
        }

        private void dtgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dữLiệuĐìnhChỉToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTonKhoDKDinhChi frm = new FormTonKhoDKDinhChi();
            frm.ShowDialog();
            frm.Text = "Dữ liệu đã đình chỉ";
        }
    }
}
