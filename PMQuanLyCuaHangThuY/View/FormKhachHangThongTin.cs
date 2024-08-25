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
    public partial class FormKhachHangThongTin : Form
    {
        BL_KhachHang db = new BL_KhachHang();
        public FormKhachHangThongTin()
        {
            InitializeComponent();
        }

        private void FormKhachHangThongTin_Load(object sender, EventArgs e)
        {
            LoadNhom();
            LoadGioiTinh();
            if (UC_KhachHang.save == false)
            {
                txtMAKH.Text = UC_KhachHang.MAKH;
                txtTENKH.Text = UC_KhachHang.TENKH;
                cboMANHOM.SelectedValue = UC_KhachHang.MANHOM;
                dtNGAYSINH.Text = UC_KhachHang.NGAYSINH;
                cboGIOITINH.SelectedValue = UC_KhachHang.GIOITINH;
                txtDIACHI.Text = UC_KhachHang.DIACHI;
                txtSDT.Text = UC_KhachHang.SDT;
                txtTENKH.Select();
            }
            else
            {
                txtMAKH.Select();
            }
        }
        private void LoadGioiTinh()
        {
            DataTable dataTable = new DataTable();
            cboGIOITINH.Items.Clear();
            dataTable.Columns.Add("ma", typeof(string));
            dataTable.Columns.Add("ten", typeof(string));
            dataTable.Rows.Add("Nam", "Nam");
            dataTable.Rows.Add("Nữ", "Nữ");
            cboGIOITINH.DataSource = dataTable;
            cboGIOITINH.DisplayMember = "ten";
            cboGIOITINH.ValueMember = "ma";
        }
        private void LoadNhom()
        {
            DataTable dataTable = new DataTable();
            dataTable = db.DanhSachNhom();
            cboMANHOM.DataSource = dataTable;
            cboMANHOM.DisplayMember = "TENNHOM";
            cboMANHOM.ValueMember = "MANHOM";
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMAKH.Text == "")
            {
                MessageBox.Show("Mã khách hàng không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMAKH.Focus();
                return;
            }
            if (txtTENKH.Text == "")
            {
                MessageBox.Show("Tên khách hàng không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTENKH.Focus();
                return;
            }
            if (cboMANHOM.Text == "")
            {
                MessageBox.Show("Nhóm không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboMANHOM.Focus();
                return;
            }
            if (UC_KhachHang.save == true)
            {
                if (db.CheckExits(txtMAKH.Text) == 0)
                {
                    MessageBox.Show("Thêm thất bại,khách hàng này đã tồn tại trong cơ sở dữ liệu", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                db.Them(txtMAKH.Text.Trim(), txtTENKH.Text.Trim(), cboMANHOM.SelectedValue.ToString(), dtNGAYSINH.Value.ToString("yyyy-MM-dd"), cboGIOITINH.SelectedValue.ToString(), txtDIACHI.Text, txtSDT.Text);
                MessageBox.Show("Thêm thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                this.Close();
            }
            if (UC_KhachHang.save == false)
            {
                if (db.CheckExits(txtMAKH.Text) == 0 && txtMAKH.Text != UC_KhachHang.MAKH)
                {
                    MessageBox.Show("Sửa thất bại, khách hàng này đã tồn tại trong cơ sở dữ liệu", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    db.Sua(txtMAKH.Text.Trim(), UC_KhachHang.MAKH, txtTENKH.Text.Trim(), cboMANHOM.SelectedValue.ToString(), dtNGAYSINH.Value.ToString("yyyy-MM-dd"), cboGIOITINH.SelectedValue.ToString(), txtDIACHI.Text, txtSDT.Text);
                    MessageBox.Show("Sửa thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Sửa thất bại, khách hàng này đã phát sinh dữ liệu", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
