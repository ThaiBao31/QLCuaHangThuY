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
    public partial class FormNhomThongTin : Form
    {
        BL_Nhom db = new BL_Nhom();
        public FormNhomThongTin()
        {
            InitializeComponent();
        }

        private void FormNhomThongTin_Load(object sender, EventArgs e)
        {
            LoadLoai();
            if (UC_Nhom.save == false)
            {
                txtMANHOM.Text = UC_Nhom.MANHOM;
                txtTENNHOM.Text = UC_Nhom.TENNHOM;
                cboLOAI.SelectedValue = UC_Nhom.LOAI;
                txtTENNHOM.Select();
            }
            else
            {
                txtMANHOM.Select();
            }
        }
        private void LoadLoai()
        {
            DataTable dataTable = new DataTable();
            cboLOAI.Items.Clear();
            dataTable.Columns.Add("ma", typeof(string));
            dataTable.Columns.Add("ten", typeof(string));
            dataTable.Rows.Add("VT", "Vật tư");
            dataTable.Rows.Add("KH", "Khách hàng");
            dataTable.Rows.Add("NCC", "Nhà cung cấp");
            cboLOAI.DataSource = dataTable;
            cboLOAI.DisplayMember = "ten";
            cboLOAI.ValueMember = "ma";
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMANHOM.Text == "")
            {
                MessageBox.Show("Mã nhóm không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMANHOM.Focus();
                return;
            }
            if (txtTENNHOM.Text == "")
            {
                MessageBox.Show("Tên nhóm không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTENNHOM.Focus();
                return;
            }
            if (UC_Nhom.save == true)
            {
                if (db.CheckExits(txtMANHOM.Text) == 0)
                {
                    MessageBox.Show("Thêm thất bại,Nhóm này đã tồn tại trong cơ sở dữ liệu", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                db.Them(txtMANHOM.Text.Trim(), txtTENNHOM.Text.Trim(), cboLOAI.SelectedValue.ToString());
                MessageBox.Show("Thêm thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                this.Close();
            }
            if (UC_Nhom.save == false)
            {
                if (db.CheckExits(txtMANHOM.Text) == 0 && txtMANHOM.Text != UC_Nhom.MANHOM)
                {
                    MessageBox.Show("Sửa thất bại, Nhóm này đã tồn tại trong cơ sở dữ liệu", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    db.Sua(txtMANHOM.Text.Trim(), UC_Nhom.MANHOM, txtTENNHOM.Text.Trim(), cboLOAI.SelectedValue.ToString());
                    MessageBox.Show("Sửa thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Sửa thất bại, Nhóm này đã phát sinh dữ liệu", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
