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

namespace PMQuanLyCuaHangThuY
{
    public partial class FormDangNhap : Form
    {
        BL_NhanVien db = new BL_NhanVien();
        public static string manv;
        public static string matkhau;
        private int soLanNhapSai = 0; // Thêm biến để đếm số lần nhập sai

        public FormDangNhap()
        {
            InitializeComponent();
            // Đăng ký sự kiện KeyPress cho form
            this.KeyPress += FormDangNhap_KeyPress;
        }

        private void FormDangNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem phím nhấn có phải là Enter không
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Gọi phương thức xử lý sự kiện đăng nhập
                btnDangNhap.PerformClick();
            }

            if (e.KeyChar == (char)Keys.Escape)
            {
                // Gọi phương thức xử lý sự kiện thoát
                btnThoat.PerformClick();
            }



        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtmanv.Text == "")
            {
                MessageBox.Show("Mã đăng nhập không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmanv.Focus();
                return;
            }

            if (txtmatkhau.Text == "")
            {
                MessageBox.Show("Mật khẩu không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmatkhau.Focus();
                return;
            }

            DataTable dt = new DataTable();
            dt = db.DangNhap(txtmanv.Text.Trim(), txtmatkhau.Text.Trim());

            if (dt != null && dt.Rows.Count > 0)
            {
                manv = txtmanv.Text.Trim();
                matkhau = txtmatkhau.Text.Trim();
                FormTrangChu frm = new FormTrangChu();
                frm.ShowDialog();
                this.Close();
            }
            else
            {
                soLanNhapSai++; // Tăng số lần nhập sai

                if (soLanNhapSai >= 5)
                {
                    MessageBox.Show("Bạn đã nhập sai quá số lần cho phép, chương trình sẽ tự đóng.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close(); // Đóng form khi nhập sai quá 5 lần
                }
                else
                {
                    MessageBox.Show("Không đúng tên người dùng hoặc mật khẩu", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtmanv.Focus();
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát chương trình ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
            else
                return;
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}