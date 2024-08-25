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
    public partial class UC_Nhom : UserControl
    {
        public static UC_Nhom ucNhom = new UC_Nhom();
        BL_Nhom db = new BL_Nhom();
        public static Boolean save;
        public static string MANHOM;
        public static string TENNHOM;
        public static string LOAI;
        public UC_Nhom()
        {
            InitializeComponent();
        }

        private void HienThiNhom()
        {
            dtgvData.DataSource = db.HienThi(txtMa.Text, txtTen.Text, lbkLoai.Text);
            dtgvData.Columns[0].HeaderText = "Mã nhóm";
            dtgvData.Columns[1].HeaderText = "Tên nhóm";
            dtgvData.Columns[2].HeaderText = "Loại";
            dtgvData.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvData.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvData.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            UC_NhanVien.CustomDataGridView(dtgvData);
        }


        private void UC_Nhom_Load(object sender, EventArgs e)
        {
            HienThiNhom();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            save = true;
            FormNhomThongTin frm = new FormNhomThongTin();
            frm.Text = "Thêm mới nhóm";
            frm.ShowDialog();
            HienThiNhom();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dtgvData.Rows.Count == 0)
            {
                return;
            }
            DataGridViewRow row = this.dtgvData.Rows[dtgvData.CurrentCell.RowIndex];
            save = false;
            FormNhomThongTin frm = new FormNhomThongTin();
            MANHOM = row.Cells[0].Value.ToString();
            TENNHOM = row.Cells[1].Value.ToString();
            LOAI = row.Cells[2].Value.ToString();
            frm.Text = "Sửa thông tin nhóm";
            frm.ShowDialog();
            HienThiNhom();
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
                    HienThiNhom();
                }
                catch (Exception)
                {
                    MessageBox.Show("Dữ liệu của nhóm này đã phát sinh, không xóa được", "Thông báo",
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
            HienThiNhom();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            HienThiNhom();
        }

        private void dtgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dữLiệuĐìnhChỉToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDulieuNhomDinhChi frm = new FormDulieuNhomDinhChi();
            frm.ShowDialog();
            frm.Text = "Dữ liệu đã đình chỉ";
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
