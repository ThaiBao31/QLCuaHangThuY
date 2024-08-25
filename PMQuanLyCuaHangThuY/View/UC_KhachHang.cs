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
    public partial class UC_KhachHang : UserControl
    {
        public static UC_KhachHang ucKhachHang = new UC_KhachHang();
        BL_KhachHang db = new BL_KhachHang();
        public static Boolean save;
        public static string MAKH;
        public static string TENKH;
        public static string MANHOM;
        public static string NGAYSINH;
        public static string GIOITINH;
        public static string DIACHI;
        public static string SDT;
        public UC_KhachHang()
        {
            InitializeComponent();
            this.nHOMTableAdapter.Fill(this.ds_NhomKH.NHOM);

        }

        private bool formLoaded = false;


        private void HienThiKhachHang()
        {
            // Giá trị mặc định cho lbkLoai
            lbkLoai.SelectedIndex = -1; // Chọn giá trị mặc định trống

            dtgvData.DataSource = db.HienThi(txtMa.Text, txtTen.Text, txtDiaChi.Text, "");

            dtgvData.Columns[0].HeaderText = "Mã KH";
            dtgvData.Columns[1].HeaderText = "Tên KH";
            dtgvData.Columns[2].HeaderText = "Nhóm";
            dtgvData.Columns[3].HeaderText = "Ngày sinh";
            dtgvData.Columns[4].HeaderText = "Giới tính";
            dtgvData.Columns[5].HeaderText = "Địa chỉ";
            dtgvData.Columns[6].HeaderText = "Số điện thoại";
            dtgvData.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvData.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvData.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvData.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvData.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvData.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvData.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            // Hiển thị tổng số bản ghi ban đầu
            UpdateTotalRecordsLabel(dtgvData.Rows.Count, dtgvData.Rows.Count);

            dtgvData.CellClick += new DataGridViewCellEventHandler(dtgvData_CellClick);
            formLoaded = true; // Đánh dấu rằng form đã được tải

            UC_NhanVien.CustomDataGridView(dtgvData);
        }

        private void UC_KhachHang_Load(object sender, EventArgs e)
        {
            HienThiKhachHang();
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
            FormKhachHangThongTin frm = new FormKhachHangThongTin();
            frm.Text = "Thêm mới khách hàng";
            frm.ShowDialog();
            HienThiKhachHang();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dtgvData.Rows.Count == 0)
            {
                return;
            }
            DataGridViewRow row = this.dtgvData.Rows[dtgvData.CurrentCell.RowIndex];
            save = false;
            FormKhachHangThongTin frm = new FormKhachHangThongTin();
            MAKH = row.Cells[0].Value.ToString();
            TENKH = row.Cells[1].Value.ToString();
            MANHOM = row.Cells[2].Value.ToString();
            NGAYSINH = row.Cells[3].Value.ToString();
            GIOITINH = row.Cells[4].Value.ToString();
            DIACHI = row.Cells[5].Value.ToString();
            SDT = row.Cells[6].Value.ToString();
            frm.Text = "Sửa thông tin khách hàng";
            frm.ShowDialog();
            HienThiKhachHang();
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
                    HienThiKhachHang();
                }
                catch (Exception)
                {
                    MessageBox.Show("Dữ liệu của khách hàng này đã phát sinh, không xóa được", "Thông báo",
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
            HienThiKhachHang();
        }


        private bool btnTimClicked = false;


        private string selectedNhomValue;


        private void btnTim_Click(object sender, EventArgs e)
        {

            btnTimClicked = true;

            // Check if a value is selected in lbkLoai
            if (lbkLoai.SelectedIndex != -1)
            {
                // If a value is selected, use that value for filtering
                selectedNhomValue = lbkLoai.SelectedValue.ToString();
            }
            else
            {
                // If no value is selected, set selectedNhomValue to an empty string to show all data
                selectedNhomValue = "";
            }

            HienThiKhachHang();
            // Restore the selected value after filtering (if needed)
            lbkLoai.SelectedValue = selectedNhomValue;

            
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lbkLoai_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lbkLoai.SelectedIndex != -1)
            {
                selectedNhomValue = lbkLoai.SelectedValue.ToString();
                DataTable data = db.HienThi(txtMa.Text, txtTen.Text,txtDiaChi.Text, selectedNhomValue);
                dtgvData.DataSource = data;
            }
            else
            {
                DataTable allData = db.HienThi(txtMa.Text, txtTen.Text,txtDiaChi.Text, "");
                dtgvData.DataSource = allData;
            }


        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void dữLiệuĐìnhChỉToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKhachHangDinhChi frm = new FormKhachHangDinhChi();
            frm.ShowDialog();
            frm.Text = "Dữ liệu đã đình chỉ";
        }
    }
}
