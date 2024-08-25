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
    public partial class UC_NhanVien : UserControl
    {
      
        public static UC_NhanVien ucNhanVien = new UC_NhanVien();
        BL_NhanVien db = new BL_NhanVien();
        public static Boolean save;
        public static string manv;
        public static string tennv;
        public static string matkhau;
        public static string dienthoai;
        public static string diachi;
        public UC_NhanVien()
        {
            InitializeComponent();
        }


        private bool formLoaded = false;



        public static void CustomDataGridView(DataGridView dgvMain)
        {
            dgvMain.AllowUserToAddRows = false;
            dgvMain.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMain.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvMain.ColumnHeadersHeight = 30;
            dgvMain.ReadOnly = true;
            dgvMain.ColumnHeadersDefaultCellStyle.BackColor = Color.Moccasin;
            dgvMain.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvMain.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9, FontStyle.Bold);
        }
        private void HienThiNhanVien()
        {
            dtgvData.DataSource = db.HienThi(txtMa.Text, txtTen.Text, txtDiaChi.Text);
            dtgvData.Columns[0].HeaderText = "Mã nhân viên";
            dtgvData.Columns[1].HeaderText = "Tên nhân viên";
            dtgvData.Columns[2].HeaderText = "Điện thoại";
            dtgvData.Columns[3].HeaderText = "Địa chỉ";
            dtgvData.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvData.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvData.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvData.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            // Hiển thị tổng số bản ghi ban đầu
            UpdateTotalRecordsLabel(dtgvData.Rows.Count, dtgvData.Rows.Count);

            dtgvData.CellClick += new DataGridViewCellEventHandler(dtgvData_CellClick);
            formLoaded = true; // Đánh dấu rằng form đã được tải



            CustomDataGridView(dtgvData);
        }
        private void UC_NhanVien_Load(object sender, EventArgs e)
        {
            HienThiNhanVien();
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
            FormNhanVienThongTin frm = new FormNhanVienThongTin();
            frm.Text = "Thêm mới nhân viên";
            frm.ShowDialog();
            HienThiNhanVien();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dtgvData.Rows.Count == 0)
            {
                return;
            }
            DataGridViewRow row = this.dtgvData.Rows[dtgvData.CurrentCell.RowIndex];
            save = false;
            FormNhanVienThongTin frm = new FormNhanVienThongTin();
            manv = row.Cells[0].Value.ToString();
            DataTable dt2 = db.MatKhau(row.Cells[0].Value.ToString());
            matkhau = dt2.Rows[0]["matkhau"].ToString();
            tennv = row.Cells[1].Value.ToString();
            dienthoai = row.Cells[2].Value.ToString();
            diachi = row.Cells[3].Value.ToString();
            frm.Text = "Sửa thông tin nhân viên";
            frm.ShowDialog();
            HienThiNhanVien();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dtgvData.Rows.Count == 0)
            {
                return;
            }
            if (dtgvData.Rows[dtgvData.CurrentCell.RowIndex].Cells[0].Value.ToString() == "ADMIN")
            {
                MessageBox.Show("Không được phép xóa tài khoản ADMIN", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult dr = MessageBox.Show("Có chắc chắn xóa dòng dữ liệu này không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    db.DinhChi(dtgvData.Rows[dtgvData.CurrentCell.RowIndex].Cells[0].Value.ToString());
                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    HienThiNhanVien();
                }
                catch (Exception)
                {
                    MessageBox.Show("Dữ liệu của tài khoản này đã phát sinh, không xóa được", "Thông báo",
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
            HienThiNhanVien();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            HienThiNhanVien();
        }

        private void dtgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblTotalRecords_Click(object sender, EventArgs e)
        {

        }

        private void dữLiệuĐìnhChỉToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNhanVienDinhChi Frm = new FormNhanVienDinhChi();
            Frm.ShowDialog();
            Frm.Text = "Dữ liệu đã đình chỉ";
        }
    }
}
