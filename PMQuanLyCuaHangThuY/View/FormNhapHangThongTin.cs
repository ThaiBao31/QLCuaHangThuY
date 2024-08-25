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
    public partial class FormNhapHangThongTin : Form
    {
        BL_NhapHang db = new BL_NhapHang();
        public FormNhapHangThongTin()
        {
            InitializeComponent();
        }

        private void FormNhapHangThongTin_Load(object sender, EventArgs e)
        {
            //HienThiNHACUNGCAP("1=0");
            //HienThiVatTu("1=0");

            HienThiNHACUNGCAP(txtTenKHSearch.Text);
            HienThiVatTu(txtTenVTSearch.Text);

            if (UC_NhapHang.save == true)
            {
                txtMaHD.Text = "NH_" + DateTime.Now.ToString("yyyyMMddhhmmss");
                txtMaNV.Text = FormDangNhap.manv;
                btnLuu.Text = "Thêm mới hóa đơn";
                HienThiChiTietHoaDon(txtMaHD.Text);
            }
            else
            {
                txtMaHD.Text = UC_NhapHang.MaHD;
                DataTable dt = new DataTable();
                dt = db.ThongTinHoaDonTheoMa(UC_NhapHang.MaHD);
                txtMaKH.Text = dt.Rows[0]["MaKH"].ToString();
                txtTenKH.Text = dt.Rows[0]["TENNCC"].ToString();
                txtDiaChi.Text = dt.Rows[0]["DIACHI"].ToString();
                txtDienThoai.Text = dt.Rows[0]["SDT"].ToString();
                txtMaNV.Text = dt.Rows[0]["MaNV"].ToString();
                dtNgayBan.Text = dt.Rows[0]["NGAYHD"].ToString();
                txtDienGiai.Text = dt.Rows[0]["DIENGIAI"].ToString();
                HienThiChiTietHoaDon(txtMaHD.Text);
                btnLuu.Text = "Sửa hóa đơn";
                TongTienHoaDon();
            }
        }
        private void HienThiNHACUNGCAP(string value)
        {
            dtgvDataKH.DataSource = db.HienThiNHACUNGCAP(value);
            dtgvDataKH.Columns[0].HeaderText = "Mã NCC";
            dtgvDataKH.Columns[1].HeaderText = "Tên NCC";
            dtgvDataKH.Columns[2].HeaderText = "Nhóm";
            dtgvDataKH.Columns[3].HeaderText = "Địa chỉ";
            dtgvDataKH.Columns[4].HeaderText = "Số điện thoại";
            dtgvDataKH.Columns[5].HeaderText = "Fax";
            dtgvDataKH.Columns[6].HeaderText = "Mã số thúe";
            dtgvDataKH.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvDataKH.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvDataKH.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvDataKH.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvDataKH.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvDataKH.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvDataKH.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            UC_NhanVien.CustomDataGridView(dtgvDataKH);
        }
        private void HienThiVatTu(string value)
        {
            dtgvDataVT.DataSource = db.HienThiVatTu(value);
            dtgvDataVT.Columns[0].HeaderText = "Mã VT";
            dtgvDataVT.Columns[1].HeaderText = "Tên VT";
            dtgvDataVT.Columns[2].HeaderText = "Nhóm";
            dtgvDataVT.Columns[3].HeaderText = "Đơn vị tính";
            dtgvDataVT.Columns[4].HeaderText = "Mô tả";
            dtgvDataVT.Columns[5].HeaderText = "Khối lượng";
            dtgvDataVT.Columns[6].HeaderText = "Kích thước";
            dtgvDataVT.Columns[7].HeaderText = "Đơn giá";
            dtgvDataVT.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvDataVT.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvDataVT.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvDataVT.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvDataVT.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvDataVT.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvDataVT.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvDataVT.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            UC_NhanVien.CustomDataGridView(dtgvDataVT);
        }
        private void HienThiChiTietHoaDon(string value)
        {
            dtgvDataCTHD.DataSource = db.HienThiCHITIETHOADON(value);
            dtgvDataCTHD.Columns[0].HeaderText = "Mã HĐ";
            dtgvDataCTHD.Columns[1].HeaderText = "Mã VT";
            dtgvDataCTHD.Columns[2].HeaderText = "Tên VT";
            dtgvDataCTHD.Columns[3].HeaderText = "Đơn giá";
            dtgvDataCTHD.Columns[4].HeaderText = "Số lượng";
            dtgvDataCTHD.Columns[5].HeaderText = "Thành tiền";
            dtgvDataCTHD.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvDataCTHD.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvDataCTHD.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvDataCTHD.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvDataCTHD.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvDataCTHD.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            UC_NhanVien.CustomDataGridView(dtgvDataCTHD);
        }
        private void btnTimKH_Click(object sender, EventArgs e)
        {
            HienThiNHACUNGCAP(txtTenKHSearch.Text);
        }

        private void btnTimVT_Click(object sender, EventArgs e)
        {
            HienThiVatTu(txtTenVTSearch.Text);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text == "")
            {
                MessageBox.Show("Chưa chọn NCC để lập hóa đơn", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaKH.Focus();
                return;
            }
            if (UC_NhapHang.save == true)
            {
                db.ThemHoaDon(txtMaHD.Text, txtMaKH.Text, dtNgayBan.Value.ToString("yyyy/MM/dd"), txtMaNV.Text, 0, txtDienGiai.Text);
                MessageBox.Show("Thêm thành công, hãy tiếp tục thêm vật tư cho hóa đơn ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                btnLuu.Enabled = false;
                dtgvDataKH.Enabled = false;
                txtDienGiai.ReadOnly = true;
                dtNgayBan.Enabled = false;
            }
            else
            {
                db.SuaHoaDon(txtMaHD.Text, txtMaKH.Text, dtNgayBan.Value.ToString("yyyy/MM/dd"), txtMaNV.Text, txtDienGiai.Text);
                MessageBox.Show("Sửa thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (db.CheckExitsHoaDon(txtMaHD.Text) == 1)
            {
                MessageBox.Show("Hãy lập hóa đơn trước khi lập chi tiết hóa đơn", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dtgvDataVT.Rows.Count == 0)
            {
                MessageBox.Show("Không có vật tư để tạo phiếu", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataGridViewRow row = this.dtgvDataVT.Rows[dtgvDataVT.CurrentCell.RowIndex];

            string MaVT = row.Cells[0].Value.ToString();
            decimal DonGia = decimal.Parse(row.Cells[7].Value.ToString() + "");
            decimal SoLuong = nmsoluong.Value;
            decimal ThanhTien = DonGia * SoLuong;

            if (db.CheckExits(txtMaHD.Text, MaVT) == 0)
            {
                db.CapNhatSoLuongTienChiTietHoaDon(txtMaHD.Text, MaVT, SoLuong);
            }
            else
            {
                db.ThemChiTietHoaDon(txtMaHD.Text, MaVT, DonGia, SoLuong, ThanhTien);
            }
            HienThiChiTietHoaDon(txtMaHD.Text);
            TongTienHoaDon();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dtgvDataCTHD.Rows.Count == 0) return;
            DataGridViewRow row = this.dtgvDataCTHD.Rows[dtgvDataCTHD.CurrentCell.RowIndex];
            db.XoaChiTietHoaDon(txtMaHD.Text, row.Cells[1].Value.ToString());
            HienThiChiTietHoaDon(txtMaHD.Text);
            TongTienHoaDon();
        }
        public void TongTienHoaDon()
        {
            if (dtgvDataCTHD.Rows.Count == 0)
            {
                return;
            }
            int tien = dtgvDataCTHD.Rows.Count;
            decimal thanhtien = 0;
            for (int i = 0; i < tien; i++)
            {
                thanhtien += decimal.Parse(dtgvDataCTHD.Rows[i].Cells["ThanhTien"].Value.ToString());
            }
            db.CapNhatTongTienHoaDon(txtMaHD.Text, thanhtien);
            txtTongTien.Text = thanhtien.ToString("#,###");
            if (txtTongTien.Text == " VND")
            {
                txtTongTien.Text = "0 VND";
            }
        }
        private void dtgvDataKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgvDataKH.Rows[e.RowIndex];
                txtMaKH.Text = row.Cells[0].Value.ToString();
                txtTenKH.Text = row.Cells[1].Value.ToString();
                txtDienThoai.Text = row.Cells[3].Value.ToString();
                txtDiaChi.Text = row.Cells[4].Value.ToString();
            }
        }

        private void FormNhapHangThongTin_FormClosing(object sender, FormClosingEventArgs e)
        {
            db.XoaHoaDonKhongTonTaiTrongChiTietHoaDon();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (dtgvDataCTHD.Rows.Count == 0)
            {
                return;
            }
            try
            {
                DialogResult ok = new DialogResult();
                ok = MessageBox.Show("Bạn có muốn tính tiền cho hóa đơn này Không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (ok == DialogResult.Yes)
                {
                    MessageBox.Show("TỔNG SỐ TIỀN THANH TOÁN LÀ " + txtTongTien.Text, "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    db.UpdateTrangThaiSauThanhToan(txtMaHD.Text);
                    this.Close();
                }
                else
                {
                    return;
                }
            }
            catch { MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
