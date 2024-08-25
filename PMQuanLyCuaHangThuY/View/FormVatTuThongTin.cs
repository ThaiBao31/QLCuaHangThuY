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
    public partial class FormVatTuThongTin : Form
    {
        BL_VatTu db = new BL_VatTu();
        public FormVatTuThongTin()
        {
            InitializeComponent();
            this.KeyPreview = true; // Bật KeyPreview để form có thể bắt sự kiện phím trước khi các control khác xử lý
            this.KeyDown += new KeyEventHandler(FormVatTuThongTin_KeyDown); // Gắn sự kiện KeyDown cho form

        }

        private void FormVatTuThongTin_Load(object sender, EventArgs e)
        {
            LoadNhom();
            if (UC_VatTu.save == false)
            {
                txtMAVT.Text = UC_VatTu.MAVT;
                txtTENVT.Text = UC_VatTu.TENVT;
                cboMANHOM.SelectedValue = UC_VatTu.MANHOM;
                txtDVT.Text = UC_VatTu.DVT;
                txtMOTA.Text = UC_VatTu.MOTA;
                nmKHOILUONG.Value = UC_VatTu.KHOILUONG;
                nmKICHTHUOC.Value = UC_VatTu.KICHTHUOC;
                nmDonGia.Value = UC_VatTu.DONGIA;
                txtTENVT.Select();
            }
            else
            {
                txtMAVT.Select();
            }
        }
        private void LoadNhom()
        {
            DataTable dataTable = new DataTable();
            dataTable = db.DanhSachNhom();
            cboMANHOM.DataSource = dataTable;
            cboMANHOM.DisplayMember = "TENNHOM";
            cboMANHOM.ValueMember = "MANHOM";
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMAVT.Text == "")
            {
                MessageBox.Show("Mã vật tư không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMAVT.Focus();
                return;
            }
            if (txtTENVT.Text == "")
            {
                MessageBox.Show("Tên vật tư không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTENVT.Focus();
                return;
            }
            if (cboMANHOM.Text == "")
            {
                MessageBox.Show("Nhóm không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboMANHOM.Focus();
                return;
            }
            if (txtDVT.Text == "")
            {
                MessageBox.Show("Đơn vị tính không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDVT.Focus();
                return;
            }
            if (nmDonGia.Value == 0)
            {
                MessageBox.Show("Đơn giá phải lớn hơn 0", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                nmDonGia.Focus();
                return;
            }
            if (UC_VatTu.save == true)
            {
                if (db.CheckExits(txtMAVT.Text) == 0)
                {
                    MessageBox.Show("Thêm thất bại,Vật tư này đã tồn tại trong cơ sở dữ liệu", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                db.Them(txtMAVT.Text.Trim(), txtTENVT.Text.Trim(), cboMANHOM.SelectedValue.ToString(), txtDVT.Text, txtMOTA.Text, nmKHOILUONG.Value, nmKICHTHUOC.Value, nmDonGia.Value);
                MessageBox.Show("Thêm thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                this.Close();
            }
            if (UC_VatTu.save == false)
            {
                if (db.CheckExits(txtMAVT.Text) == 0 && txtMAVT.Text != UC_VatTu.MAVT)
                {
                    MessageBox.Show("Sửa thất bại, Vật tư này đã tồn tại trong cơ sở dữ liệu", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    db.Sua(txtMAVT.Text.Trim(), UC_VatTu.MAVT, txtTENVT.Text.Trim(), cboMANHOM.SelectedValue.ToString(), txtDVT.Text, txtMOTA.Text, nmKHOILUONG.Value, nmKICHTHUOC.Value, nmDonGia.Value);
                    MessageBox.Show("Sửa thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Sửa thất bại, Vật tư này đã phát sinh dữ liệu", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nmKHOILUONG_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FormVatTuThongTin_KeyDown(object sender, KeyEventArgs e)
        {
            // Kiểm tra xem Ctrl và S có được nhấn cùng lúc không
            if (e.Control && e.KeyCode == Keys.S)
            {
                // Xử lý sự kiện lưu ở đây
                btnLuu.PerformClick(); // Kích hoạt sự kiện Click của button Lưu
            }
        }
    }
}
