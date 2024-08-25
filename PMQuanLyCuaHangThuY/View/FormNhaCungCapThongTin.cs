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
    public partial class FormNhaCungCapThongTin : Form
    {
        BL_NhaCungCap db = new BL_NhaCungCap();
        public FormNhaCungCapThongTin()
        {
            InitializeComponent();
        }

        private void FormNhaCungCapThongTin_Load(object sender, EventArgs e)
        {
            LoadNhom();
            if (UC_NhaCungCap.save == false)
            {
                txtMANCC.Text = UC_NhaCungCap.MANCC;
                txtTENNCC.Text = UC_NhaCungCap.TENNCC;
                cboMANHOM.SelectedValue = UC_NhaCungCap.MANHOM;
                txtDIACHI.Text = UC_NhaCungCap.DIACHI;
                txtSDT.Text = UC_NhaCungCap.SDT;
                txtFAX.Text = UC_NhaCungCap.FAX;
                txtMASOTHUE.Text = UC_NhaCungCap.MASOTHUE;
                txtTENNCC.Select();
            }
            else
            {
                txtMANCC.Select();
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
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMANCC.Text == "")
            {
                MessageBox.Show("Mã nhà cung cấp không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMANCC.Focus();
                return;
            }
            if (txtTENNCC.Text == "")
            {
                MessageBox.Show("Tên nhà cung cấp không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTENNCC.Focus();
                return;
            }
            if (cboMANHOM.Text == "")
            {
                MessageBox.Show("Nhóm không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboMANHOM.Focus();
                return;
            }
            if (UC_NhaCungCap.save == true)
            {
                if (db.CheckExits(txtMANCC.Text) == 0)
                {
                    MessageBox.Show("Thêm thất bại,nhà cung cấp này đã tồn tại trong cơ sở dữ liệu", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                db.Them(txtMANCC.Text.Trim(), txtTENNCC.Text.Trim(), cboMANHOM.SelectedValue.ToString(), txtDIACHI.Text, txtSDT.Text, txtFAX.Text, txtMASOTHUE.Text);
                MessageBox.Show("Thêm thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                this.Close();
            }
            if (UC_NhaCungCap.save == false)
            {
                if (db.CheckExits(txtMANCC.Text) == 0 && txtMANCC.Text != UC_NhaCungCap.MANCC)
                {
                    MessageBox.Show("Sửa thất bại, nhà cung cấp này đã tồn tại trong cơ sở dữ liệu", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    db.Sua(txtMANCC.Text.Trim(), UC_NhaCungCap.MANCC, txtTENNCC.Text.Trim(), cboMANHOM.SelectedValue.ToString(), txtDIACHI.Text, txtSDT.Text, txtFAX.Text, txtMASOTHUE.Text);
                    MessageBox.Show("Sửa thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Sửa thất bại, nhà cung cấp này đã phát sinh dữ liệu", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
