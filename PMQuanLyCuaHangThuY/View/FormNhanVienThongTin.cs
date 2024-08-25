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
    public partial class FormNhanVienThongTin : Form
    {
        BL_NhanVien db = new BL_NhanVien();
        public FormNhanVienThongTin()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtmanv.Text == "")
            {
                MessageBox.Show("Mã nhân viên không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmanv.Focus();
                return;
            }
            if (txttennv.Text == "")
            {
                MessageBox.Show("Tên nhân viên không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txttennv.Focus();
                return;
            }
            if (txtmatkhau.Text == "")
            {
                MessageBox.Show("Mật khẩu không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmatkhau.Focus();
                return;
            }
            if ((txtmatkhau.Text != txtnlmatkhau.Text))
            {
                MessageBox.Show("Nhập lại mật khẩu không trùng khớp", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtnlmatkhau.Focus();
                return;
            }
            if (UC_NhanVien.save == true)
            {
                if (db.CheckExits(txtmanv.Text) == 0)
                {
                    MessageBox.Show("Thêm thất bại,Nhân viên này đã tồn tại trong cơ sở dữ liệu", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                db.Them(txtmanv.Text.Trim(), txttennv.Text.Trim(), txtmatkhau.Text.Trim(), txtdienthoai.Text.Trim(), txtdiachi.Text.Trim());
                MessageBox.Show("Thêm thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                this.Close();
            }
            if (UC_NhanVien.save == false)
            {
                if (db.CheckExits(txtmanv.Text) == 0 && txtmanv.Text != UC_NhanVien.manv)
                {
                    MessageBox.Show("Sửa thất bại, Nhân viên này đã tồn tại trong cơ sở dữ liệu", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    db.Sua(txtmanv.Text.Trim(), UC_NhanVien.manv, txttennv.Text.Trim(), txtmatkhau.Text.Trim(), txtdienthoai.Text.Trim(), txtdiachi.Text.Trim());
                    MessageBox.Show("Sửa thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Sửa thất bại, Nhân viên này đã phát sinh dữ liệu", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FormNhanVienThongTin_Load(object sender, EventArgs e)
        {
            if (UC_NhanVien.save == false)
            {
                txtmanv.Text = UC_NhanVien.manv;
                txtmatkhau.Text = UC_NhanVien.matkhau;
                txtnlmatkhau.Text = UC_NhanVien.matkhau;
                txttennv.Text = UC_NhanVien.tennv;
                txtdienthoai.Text = UC_NhanVien.dienthoai;
                txtdiachi.Text = UC_NhanVien.diachi;
                txttennv.Select();
            }
            else
            {
                txtmanv.Select();
            }    
        }
    }
}
