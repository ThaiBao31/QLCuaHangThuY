using PMQuanLyCuaHangThuY.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMQuanLyCuaHangThuY.BL
{
    public class BL_BaoCao
    {
        public DataTable BCSoCTBH(string Ngay1, string Ngay2, string Mavt)
        {
            string Query = "EXEC pr_BCSoCTBH '" + Ngay1 + "', '" + Ngay2 + "','" + Mavt + "'";
            return DBConnect.Load(Query);
        }
        public DataTable BCDSBH(string Ngay1, string Ngay2,string Mavt)
        {
            string Query = "EXEC pr_BCDSBH '" + Ngay1 + "', '" + Ngay2 + "','"+Mavt+"'";
            return DBConnect.Load(Query);
        }

        public DataTable BCCN(string Ngay1, string Ngay2, string DoiTuong)
        {
            string Query = "EXEC usp_BaoCaoCongNo '" + Ngay1 + "', '" + Ngay2 + "','" + DoiTuong + "'";
            return DBConnect.Load(Query);
        }


        public DataTable SOCTVT(string Ngay1, string Ngay2, string VatTu)
        {
            string Query = "EXEC usp_NXT '" + Ngay1 + "', '" + Ngay2 + "','" + VatTu + "'";
            return DBConnect.Load(Query);
        }

        public DataTable MauInHDBH(string MaHD)
        {
            string Query = "EXEC usp_MauInHDBH '" +MaHD+ "'";
            return DBConnect.Load(Query);
        }

        public DataTable LayThongTinTheoMaHD(string MaHD)
        {
            string Query = "SELECT hd.NGAYHD, hd.MACT, hd.TONGTIEN, ISNULL(kh.TENKH, ncc.TENNCC) AS TENKH, " +
                           "ISNULL(KH.DIACHI,ncc.DIACHI) AS DIACHI, ISNULL(kh.SDT,ncc.SDT) AS SDT, hd.DIENGIAI, nv.TENNV " +
                           "FROM CHITIETHOADON ct LEFT JOIN " +
                                "HOADON hd ON hd.MAHD=ct.MAHD LEFT JOIN " +
                                "NHANVIEN nv ON nv.MANV=hd.MANV LEFT JOIN " +
                                "KHACHHANG kh ON kh.MAKH=hd.MAKH LEFT JOIN " +
                                "NHACUNGCAP ncc ON ncc.MANCC=hd.MAKH " +
                           "WHERE hd.MAHD= '" + MaHD + "'";
            return DBConnect.Load(Query);
        }




        public DataTable BangKeCT(string Ngay1, string Ngay2, string ChungTu)
        {
            string Query = "EXEC usp_BangKeCt '" + Ngay1 + "', '" + Ngay2 + "','" + ChungTu + "'";
            return DBConnect.Load(Query);
        }


        // Thêm một phương thức mới để lấy mã và tên vật tư
        public DataTable GetMaTenVatTu(string MaVt)
        {
            string Query = "SELECT MAVT + ' - ' + TENVT AS MaTenVatTu FROM VATTU WHERE MAVT = '" + MaVt + "'";
            return DBConnect.Load(Query);
        }


        public DataTable HoaDonBH(string Ngay1, string Ngay2, string MaNv)
        {
            string Query = "EXEC usp_HoaDonBH '" + Ngay1 + "', '" + Ngay2 + "','" + MaNv + "'";
            return DBConnect.Load(Query);
        }

        public DataTable TopNVatTu(int TopN, string Sort)
        {
            string Query = "EXEC usp_TopNVatTu '" + TopN + "', '" + Sort + "'";
            return DBConnect.Load(Query);
        }


        public DataTable TopNKH(int TopN, string Sort)
        {
            string Query = "EXEC usp_TopNKH '" + TopN + "', '" + Sort + "'";
            return DBConnect.Load(Query);
        }


        public DataTable BGDSNHOMHANG(string Ngay1, string Ngay2)
        {
            string Query = "EXEC usp_BcDsTheoNhomHang '" + Ngay1 + "', '" + Ngay2 + "'";
            return DBConnect.Load(Query);
        }


        public DataTable BCDSVTTT(string Ngay1, string Ngay2, string VatTu)
        {
            string Query = "EXEC usp_DoanhThuVatTuTheoThang '" + Ngay1 + "', '" + Ngay2 + "','" + VatTu + "'";
            return DBConnect.Load(Query);
        }



    }
}
