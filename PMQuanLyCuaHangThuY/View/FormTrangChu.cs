using PMQuanLyCuaHangThuY.View;
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
    public partial class FormTrangChu : Form
    {
        public FormTrangChu()
        {
            InitializeComponent();
        }
        internal static List<byte> typePages = new List<byte>();
        public void ThemTabPages(UserControl uct, byte typeControl, string tenTab)
        {
            for (int i = 0; i < TabHienThiDL.TabPages.Count; i++)
            {
                if (TabHienThiDL.TabPages[i].Contains(uct) == true)
                {
                    TabHienThiDL.SelectedTab = TabHienThiDL.TabPages[i];
                    return;
                }
            }
            TabPage tab = new TabPage();
            typePages.Add(typeControl);
            tab.Name = uct.Name;
            tab.Size = TabHienThiDL.Size;
            tab.Text = tenTab;
            tab.Font = TabHienThiDL.Font;
            TabHienThiDL.TabPages.Add(tab);
            TabHienThiDL.SelectedTab = tab;
            uct.Dock = DockStyle.Fill;
            tab.Controls.Add(uct);
            uct.Focus();

        }
        public void DongTabHienTai()
        {
            TabHienThiDL.TabPages.Remove(TabHienThiDL.SelectedTab);
        }
        public void DongAllTab()
        {
            while (TabHienThiDL.TabPages.Count > 0)
            {
                DongTabHienTai();
            }
        }
        private void danhMụcNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DongAllTab();
            ThemTabPages(View.UC_NhanVien.ucNhanVien, 4, "DANH MỤC NHÂN VIÊN");
        }

        private void menuItemDongTrang_Click(object sender, EventArgs e)
        {
            DongTabHienTai();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DongAllTab();
            ThemTabPages(View.UC_ThongTinCaNhan.ucThongTinCaNhan, 4, "THÔNG TIN CÁ NHÂN");
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát chương trình ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
            else
                return;
        }

        private void danhMụcNhómToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DongAllTab();
            ThemTabPages(View.UC_Nhom.ucNhom, 4, "DANH MỤC NHÓM");
        }

        private void danhMụcVậtTưHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DongAllTab();
            ThemTabPages(View.UC_VatTu.ucVatTu, 4, "DANH MỤC VẬT TƯ HÀNG HÓA");
        }

        private void danhMụcKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DongAllTab();
            ThemTabPages(View.UC_KhachHang.ucKhachHang, 4, "DANH MỤC KHÁCH HÀNG");
        }

        private void danhMụcNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DongAllTab();
            ThemTabPages(View.UC_NhaCungCap.ucNhaCungCap, 4, "DANH MỤC NHÀ CUNG CẤP");
        }

        private void FormTrangChu_Load(object sender, EventArgs e)
        {
            DongAllTab();
            ThemTabPages(View.UC_Main.ucMain, 4, "HOME");
            ThemTabPages(View.UC_BCNhanh.ucBCNhanh, 5, "BÁO CÁO NHANH");
        }

        private void danhMụcTồnKhoĐầuKỳToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DongAllTab();
            ThemTabPages(View.UC_TonKhoDauKy.ucTonKhoDauKy, 4, "DANH MỤC TỒN KHO ĐẦU KỲ");
        }

        private void hóaĐơnBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DongAllTab();
            ThemTabPages(View.UC_HDBH.ucHDBH, 4, "HÓA ĐƠN BÁN HÀNG");
        }

        private void phiếuNhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DongAllTab();
            ThemTabPages(View.UC_NhapHang.ucNhapHang, 4, "PHIẾU NHẬP HÀNG");
        }

        private void phiếuHàngBánTrảLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DongAllTab();
            ThemTabPages(View.UC_HBTL.ucHBTL, 4, "PHIẾU HÀNG BÁN TRẢ LẠI");
        }

        private void báoCáoSổChiTiếtBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DongAllTab();
            ThemTabPages(View.UC_BCSoCTBH.ucBCSoCTBH, 4, "BÁO CÁO SỔ CHI TIẾT BÁN HÀNG");
        }

        private void báoCáoDoanhSốBánHàngTheoVTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DongAllTab();
            ThemTabPages(View.UC_BCDSBH.ucBCDSBH, 4, "BÁO CÁO PHÂN TÍCH DOANH SỐ BÁN HÀNG");
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void TabHienThi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DongAllTab();
            ThemTabPages(View.UC_Main.ucMain, 4, "HOME");
            ThemTabPages(View.UC_BCNhanh.ucBCNhanh, 5, "BÁO CÁO NHANH");
        }

        private void báoCáoCôngNợToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DongAllTab();
            ThemTabPages(View.UC_BCCN.ucBCCN, 4, "BÁO CÁO CÔNG NỢ");
        }

        private void danhSáchVậtTưHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DongAllTab();
            ThemTabPages(UC_DanhSachVatTu.ucDSVT, 4, "DANH SÁCH VẬT TƯ HÀNG HÓA");
        }

        private void sổChiTiếtVậtTưToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DongAllTab();
            ThemTabPages(UC_SOCTVT.ucSCTVT, 4, "SỔ CHI TIẾT VẬT TƯ");
        }

        private void doanhSốNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DongAllTab();
            ThemTabPages(UC_DoanhSoNhanVien.ucDSNV, 4, "DOANH SỐ THEO NHÂN VIÊN");
        }

        private void doanhSốTheoNhómVậtTưToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DongAllTab();
            ThemTabPages(UC_DoanhSoTheoNhomHang.ucDoanhSoTheoNhomHang, 4, "DOANH SỐ THEO NHÓM VẬT TƯ");
        }

        private void doanhSốVậtTưTheoThángToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DongAllTab();
            ThemTabPages(UC_BaoCaoDoanhSoVTTheoThangcs.UcBCDSVTTT, 4, "DOANH SỐ VẬT TƯ THEO THÁNG");
        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_2(object sender, EventArgs e)
        {

        }

        private void bảngKêChứngTừToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DongAllTab();
            ThemTabPages(UC_BangKeCt.ucBangkeCt, 4, "BẢNG KÊ CHỨNG TỪ");
        }
    }
}
