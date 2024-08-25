using PMQuanLyCuaHangThuY.BL;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace PMQuanLyCuaHangThuY.View
{
    public partial class UC_VatTu : UserControl
    {
        public static UC_VatTu ucVatTu = new UC_VatTu();
        BL_VatTu db = new BL_VatTu();
        public static Boolean save;
        public static string MAVT;
        public static string TENVT;
        public static string MANHOM;
        public static string DVT;
        public static string MOTA;
        public static decimal KHOILUONG;
        public static decimal KICHTHUOC;
        public static decimal DONGIA;
        public UC_VatTu()
        {
            InitializeComponent();
            this.nHOMTableAdapter.Fill(this.ds_NhomVt.NHOM);


        }


        private bool formLoaded = false;



        private void HienThiVatTu()
        {
            // Giá trị mặc định cho lbkLoai
            lbkLoai.SelectedIndex = -1; // Chọn giá trị mặc định trống

                 


            dtgvData.DataSource = db.HienThi(txtMa.Text, txtTen.Text, txtDvt.Text, "");

            DataTable data = db.HienThi(txtMa.Text, txtTen.Text, txtDvt.Text, "");
            dtgvData.DataSource = data;

            dtgvData.Columns[0].HeaderText = "Mã VT";
            dtgvData.Columns[1].HeaderText = "Tên VT";
            dtgvData.Columns[2].HeaderText = "Nhóm";
            dtgvData.Columns[3].HeaderText = "Đơn vị tính";
            dtgvData.Columns[4].HeaderText = "Mô tả";
            dtgvData.Columns[5].HeaderText = "Khối lượng";
            dtgvData.Columns[6].HeaderText = "Kích thước";
            dtgvData.Columns[7].HeaderText = "Đơn giá";

            dtgvData.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvData.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvData.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvData.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvData.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvData.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvData.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvData.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            //thêm định dạng số
            dtgvData.Columns[5].DefaultCellStyle.Format = "N2"; // Khối lượng
            dtgvData.Columns[6].DefaultCellStyle.Format = "N2"; // Kích thước
            dtgvData.Columns[7].DefaultCellStyle.Format = "N0"; // Đơn giá

            // Căn lề các cột "khối lượng", "kích thước", "đơn giá" bên phải
            dtgvData.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dtgvData.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dtgvData.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dtgvData.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#ADC7E7"); // Màu nền cho tiêu đề cột
            dtgvData.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black; // Màu chữ cho tiêu đề cột
            dtgvData.EnableHeadersVisualStyles = false; // Vô hiệu hóa màu mặc định cho tiêu đề cột

            // Để in đậm tiêu đề cột, sử dụng FontStyle.Bold cho Font của tiêu đề
            dtgvData.ColumnHeadersDefaultCellStyle.Font = new Font(dtgvData.Font, FontStyle.Bold);

            // Hiển thị tổng số bản ghi ban đầu
            UpdateTotalRecordsLabel(dtgvData.Rows.Count, dtgvData.Rows.Count);

            dtgvData.CellClick += new DataGridViewCellEventHandler(dtgvData_CellClick);
            formLoaded = true; // Đánh dấu rằng form đã được tải

            UC_NhanVien.CustomDataGridView(dtgvData);
        }




        private void UC_VatTu_Load(object sender, EventArgs e)
        {
            HienThiVatTu();
            // TODO: This line of code loads data into the 'ds_VatTu.VATTU' table. You can move, or remove it, as needed.


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
            FormVatTuThongTin frm = new FormVatTuThongTin();
            frm.Text = "Thêm mới vật tư";
            frm.ShowDialog();
            HienThiVatTu();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dtgvData.Rows.Count == 0)
            {
                return;
            }
            DataGridViewRow row = this.dtgvData.Rows[dtgvData.CurrentCell.RowIndex];
            save = false;
            FormVatTuThongTin frm = new FormVatTuThongTin();
            MAVT = row.Cells[0].Value.ToString();
            TENVT = row.Cells[1].Value.ToString();
            MANHOM = row.Cells[2].Value.ToString();
            DVT = row.Cells[3].Value.ToString();
            MOTA = row.Cells[4].Value.ToString();
            KHOILUONG = decimal.Parse(row.Cells[5].Value.ToString());
            KICHTHUOC = decimal.Parse(row.Cells[6].Value.ToString());
            DONGIA = decimal.Parse(row.Cells[7].Value.ToString());
            frm.Text = "Sửa thông tin vật tư";
            frm.ShowDialog();
            HienThiVatTu();
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
                    HienThiVatTu();
                }
                catch (Exception)
                {
                    MessageBox.Show("Dữ liệu của vật tư này đã phát sinh, không xóa được", "Thông báo",
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
            HienThiVatTu();
        }

        private bool btnTimClicked = false;


        private string selectedNhomValue;



        private void btnTim_Click(object sender, EventArgs e)
        {

            //btnTimClicked = true;

            //// Save the selected value before filtering
            //string previousSelectedValue = selectedNhomValue;

            //HienThiVatTu();

            //// Restore the selected value after filtering
            //selectedNhomValue = previousSelectedValue;
            //lbkLoai.SelectedValue = selectedNhomValue;

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

            HienThiVatTu();

            // Restore the selected value after filtering (if needed)
            lbkLoai.SelectedValue = selectedNhomValue;


        }

        private void dtgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtMa_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTotalRecords_Click(object sender, EventArgs e)
        {

        }

        private void lbkLoai_SelectedIndexChanged(object sender, EventArgs e)
        {

            //// Kiểm tra xem có giá trị được chọn hay không
            //if (lbkLoai.SelectedIndex != -1)
            //{
            //    // Nếu có giá trị được chọn, thực hiện lọc dữ liệu và cập nhật DataSource cho dtgvData
            //    string selectedValue = lbkLoai.SelectedValue.ToString();
            //    DataTable data = db.HienThi(txtMa.Text, txtTen.Text, txtDvt.Text, selectedValue);
            //    dtgvData.DataSource = data;
            //}
            //else
            //{
            //    // Nếu không có giá trị được chọn, hiển thị toàn bộ dữ liệu
            //    DataTable allData = db.HienThi(txtMa.Text, txtTen.Text, txtDvt.Text, "");
            //    dtgvData.DataSource = allData;
            //}

            if (lbkLoai.SelectedIndex != -1)
            {
                selectedNhomValue = lbkLoai.SelectedValue.ToString();
                DataTable data = db.HienThi(txtMa.Text, txtTen.Text, txtDvt.Text, selectedNhomValue);
                dtgvData.DataSource = data;
            }
            else
            {
                DataTable allData = db.HienThi(txtMa.Text, txtTen.Text, txtDvt.Text, "");
                dtgvData.DataSource = allData;
            }




        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dữLiệuĐìnhChỉToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVatTuDinhChi frm = new FormVatTuDinhChi();
            frm.ShowDialog();
            frm.Text = "Dữ liệu đã đình chỉ";
        }
    }
}