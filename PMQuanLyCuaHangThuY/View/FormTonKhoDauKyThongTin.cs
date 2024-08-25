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
    public partial class FormTonKhoDauKyThongTin : Form
    {
        BL_TonKhoDauKy db = new BL_TonKhoDauKy();
        public FormTonKhoDauKyThongTin()
        {
            InitializeComponent();
        }

        private void FormTonKhoDauKyThongTin_Load(object sender, EventArgs e)
        {
            LoadTonKhoDauKy();
            if (UC_TonKhoDauKy.save == false)
            {
                cboMAVT.SelectedValue = UC_TonKhoDauKy.MAVT;
                txtDVT.Text = UC_TonKhoDauKy.DVT;
                nmSOLUONG.Value = UC_TonKhoDauKy.SOLUONG;
                nmDONGIA.Value = UC_TonKhoDauKy.DONGIA;
                nmTHANHTIEN.Value = UC_TonKhoDauKy.THANHTIEN;
                nmSOLUONG.Select();
            }
            else
            {
                DataTable dt = new DataTable();
                dt = db.VatTuTheoMa(cboMAVT.SelectedValue.ToString());
                if (dt.Rows.Count > 0)
                {
                    txtDVT.Text = dt.Rows[0]["DVT"].ToString();
                }

                cboMAVT.Select();
            }
        }
        private void LoadTonKhoDauKy()
        {
            DataTable dataTable = new DataTable();
            dataTable = db.DanhSachVatTu();
            cboMAVT.DataSource = dataTable;
            cboMAVT.DisplayMember = "TENVT";
            cboMAVT.ValueMember = "MAVT";
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cboMAVT.Text == "")
            {
                MessageBox.Show("Mã vật tư không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboMAVT.Focus();
                return;
            }
            if (nmSOLUONG.Value == 0)
            {
                MessageBox.Show("Số lượng không được bằng 0", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                nmSOLUONG.Focus();
                return;
            }
    
            if (UC_TonKhoDauKy.save == true)
            {
                if (db.CheckExits(cboMAVT.SelectedValue.ToString()) == 0)
                {
                    MessageBox.Show("Thêm thất bại,Tồn kho đầu kỳ vật tư này đã tồn tại trong cơ sở dữ liệu", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                db.Them(cboMAVT.SelectedValue.ToString(), txtDVT.Text.Trim(), nmSOLUONG.Value, nmDONGIA.Value, nmTHANHTIEN.Value);
                MessageBox.Show("Thêm thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                this.Close();
            }
            if (UC_TonKhoDauKy.save == false)
            {
                if (db.CheckExits(cboMAVT.SelectedValue.ToString()) == 0 && cboMAVT.SelectedValue.ToString() != UC_TonKhoDauKy.MAVT)
                {
                    MessageBox.Show("Sửa thất bại, Tồn kho đầu kỳ vật tư này đã tồn tại trong cơ sở dữ liệu", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    db.Sua(cboMAVT.SelectedValue.ToString(), UC_TonKhoDauKy.MAVT, txtDVT.Text.Trim(), nmSOLUONG.Value, nmDONGIA.Value, nmTHANHTIEN.Value);
                    MessageBox.Show("Sửa thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Sửa thất bại, Tồn kho đầu kỳ vật tư này đã phát sinh dữ liệu", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboMAVT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMAVT.Text == "")
            {
                return;
            }
            DataTable dt = new DataTable();
            dt = db.VatTuTheoMa(cboMAVT.SelectedValue.ToString());
            if (dt.Rows.Count > 0)
            {
                txtDVT.Text = dt.Rows[0]["DVT"].ToString();
            }
        }

        private void nmSOLUONG_Validated(object sender, EventArgs e)
        {
            nmTHANHTIEN.Value = nmSOLUONG.Value * nmDONGIA.Value;
        }

        private void nmDONGIA_Validated(object sender, EventArgs e)
        {
            nmTHANHTIEN.Value = nmSOLUONG.Value * nmDONGIA.Value;
        }
    }
}
