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
    public partial class UC_ThongTinCaNhan : UserControl
    {
        public static UC_ThongTinCaNhan ucThongTinCaNhan = new UC_ThongTinCaNhan();
        BL_NhanVien db = new BL_NhanVien();
        public UC_ThongTinCaNhan()
        {
            InitializeComponent();
        }

        private void UC_ThongTinCaNhan_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = db.DangNhap(FormDangNhap.manv, FormDangNhap.matkhau);
            if (dt.Rows.Count > 0)
            {
                txtMaNV.Text = dt.Rows[0][0].ToString();
                txtTenNV.Text = dt.Rows[0][1].ToString();
                txtSoDienThoai.Text = dt.Rows[0][3].ToString();
                txtDiaChi.Text = dt.Rows[0][4].ToString();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMatKhau_Cu.Text == "")
            {
                MessageBox.Show("Mật khẩu cũ không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau_Cu.Focus();
                return;
            }
            if (txtMatKhau_Moi.Text == "")
            {
                MessageBox.Show("Mật khẩu mới không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau_Moi.Focus();
                return;
            }
            if ((txtMatKhau_Moi.Text != txtMatKhau_NhapLai.Text))
            {
                MessageBox.Show("Nhập lại mật khẩu không trùng khớp", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau_Moi.Focus();
                return;
            }
            if (txtMatKhau_Cu.Text != FormDangNhap.matkhau)
            {
                MessageBox.Show("Mật khẩu cũ không chính xác", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau_Cu.Focus();
                return;
            }
            db.Doimatkhau(txtMaNV.Text, txtMatKhau_Moi.Text);
            MessageBox.Show("Đổi mật khẩu thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }
    }
}
