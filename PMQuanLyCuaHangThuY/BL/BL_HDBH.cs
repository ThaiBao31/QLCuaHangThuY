using PMQuanLyCuaHangThuY.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMQuanLyCuaHangThuY.BL
{
    public class BL_HDBH
    {
        public DataTable ThongTinHoaDonTheoMa(string MaHD)
        {
            string Query = "SELECT a.MAHD,a.MAKH,b.TENKH,b.DIACHI,b.SDT,a.NGAYHD,a.MANV,c.TENNV,TONGTIEN,TRANGTHAI,DIENGIAI FROM HOADON a INNER JOIN KHACHHANG b ON a.MAKH = b.MAKH INNER JOIN NHANVIEN c ON a.MANV = c.MANV " +
                "WHERE a.Isactive=1 AND a.MaHD = '" + MaHD + "'";
            return DBConnect.Load(Query);
        }
        public DataTable HienThiHOADON(string Ngay1, string Ngay2, string KhachHang)
        {
            string Query = "SELECT a.MAHD,a.MAKH,b.TENKH,a.NGAYHD,a.MANV,c.TENNV,TONGTIEN,TRANGTHAI,DIENGIAI FROM HOADON a INNER JOIN KHACHHANG b ON a.MAKH = b.MAKH INNER JOIN NHANVIEN c ON a.MANV = c.MANV " +
                "WHERE a.MACT = 'HD' AND a.IsActive = 1 " +
                " AND (a.MAKH = '"+KhachHang+ "' OR ISNULL('"+KhachHang+"','')='') " +
                " AND NGAYHD BETWEEN '" + Ngay1+"' AND '"+Ngay2+"'";
            return DBConnect.Load(Query);
        }

        public DataTable HienThiHOADONDinhChi()
        {
            string Query = "SELECT a.MAHD,a.MAKH,b.TENKH,a.NGAYHD,a.MANV,c.TENNV,TONGTIEN,TRANGTHAI,DIENGIAI FROM HOADON a INNER JOIN KHACHHANG b ON a.MAKH = b.MAKH INNER JOIN NHANVIEN c ON a.MANV = c.MANV " +
                           "WHERE a.MACT = 'HD' AND a.IsActive=0";
            return DBConnect.Load(Query);
        }


        public DataTable HienThiCHITIETHOADON(string MaHD)
        {
            string Query = "SELECT a.MaHD,a.MaVT,b.TenVT,a.DonGia,a.SoLuong,a.ThanhTien FROM CHITIETHOADON a INNER JOIN VATTU b ON a.MaVT = b.MaVT " +
                "WHERE  a.MaHD = '"+MaHD+"'";
            return DBConnect.Load(Query);
        }

       

        public DataTable HienThiKhachHang(string TenKH)
        {
            string Query = "SELECT * FROM KHACHHANG  " +
                "WHERE Isactive=1 " +
                "AND (TENKH LIKE N'%" + TenKH + "%' " +
                        "OR MAKH LIKE N'%" + TenKH + "%'" +
                        "OR MANHOM LIKE N'%" + TenKH + "%')";
            return DBConnect.Load(Query);
        }
        public DataTable HienThiVatTu(string TenVT)
        {
            string Query = "SELECT * FROM VATTU  " +
                "WHERE  Isactive=1 AND (TenVT LIKE N'%" + TenVT + "%' " +
                                        " OR MAVT  LIKE N'%" + TenVT + "%'" +
                                        " OR MANHOM LIKE N'%" + TenVT + "%')";
            return DBConnect.Load(Query);
        }


        public void ThemHoaDon(string MaHD, string makh, string NgayHD, string manv, decimal TongTien,string DienGiai)
        {
            string str = "INSERT INTO HoaDon(MaHD,makh,NgayHD,manv,TongTien,trangthai,DIENGIAI,MACT)  VALUES ( '" + MaHD + "','" + makh + "','" + NgayHD + "','" + manv + "'," + TongTien + ",N'Chưa thanh toán',N'"+DienGiai+"','HD')";
            DBConnect.ExecuteNonQuery(str);
        }
        public void ThemChiTietHoaDon(string MaHD, string MAVT, decimal DonGia, decimal SoLuong, decimal ThanhTien)
        {
            string str = " INSERT INTO ChiTietHoaDon(MaHD,MAVT,DonGia,SoLuong,ThanhTien)  VALUES ( '" + MaHD + "','" + MAVT + "'," + DonGia + "," + SoLuong + "," + ThanhTien + ")";
            DBConnect.ExecuteNonQuery(str);
        }
        public int CheckExits(string MaHD, string MaVT)
        {
            int i = 0;
            string s = "SELECT * FROM ChiTietHoaDon WHERE MaHD = '" + MaHD + "' AND MaVT = '" + MaVT + "'";
            DataTable dt = DBConnect.Load(s);
            if (dt == null || dt.Rows.Count > 0)
            {
                i = 0;
            }
            else
            {
                i = 1;
            }
            return i;
        }
        public int CheckExitsHoaDon(string MaHD)
        {
            int i = 0;
            string s = "SELECT * FROM HoaDon WHERE MaHD = '" + MaHD + "'";
            DataTable dt = DBConnect.Load(s);
            if (dt == null || dt.Rows.Count > 0)
            {
                i = 0;
            }
            else
            {
                i = 1;
            }
            return i;
        }
        public void CapNhatTongTienHoaDon(string MaHD,decimal TongTien)
        {
            string sqlUpdate = "UPDATE HoaDon SET TongTien =  " + TongTien + " WHERE MaHD = '" + MaHD + "'";
            DBConnect.ExecuteNonQuery(sqlUpdate);
        }
        public void CapNhatSoLuongTienChiTietHoaDon(string MaHD, string MaVT, decimal soluong)
        {
            string sqlUpdate = "UPDATE ChiTietHoaDon SET SoLuong = SoLuong + " + soluong + " WHERE MaHD = '" + MaHD + "' And MaVT = '" + MaVT + "'";
            sqlUpdate += " UPDATE ChiTietHoaDon SET ThanhTien = SoLuong * DonGia WHERE MaHD = '" + MaHD + "' And MaVT = '" + MaVT + "'";
            DBConnect.ExecuteNonQuery(sqlUpdate);
        }
        public void XoaChiTietHoaDon(string MaHD, string MaVT)
        {
            string str = string.Format(@"DELETE ChiTietHoaDon WHERE MaHD = '" + MaHD + "' AND MaVT = '" + MaVT + "'");
            DBConnect.ExecuteNonQuery(str);
        }
        public void XoaHoaDonKhongTonTaiTrongChiTietHoaDon()
        {
            string s = "DELETE HoaDon WHERE MaHD NOT IN (SELECT MaHD From ChiTietHoaDon)";
            DBConnect.ExecuteNonQuery(s);
        }
      

        public void Xoa(string MaHD)
        {
            string str = string.Format(@"DELETE ChiTietHoaDon WHERE MaHD = '" + MaHD + "'");
            str += string.Format(@"DELETE HoaDon WHERE MaHD = '" + MaHD + "'");
            DBConnect.ExecuteNonQuery(str);
        }

        public void DinhChi(string MaHD)
        {
            string str = string.Format(@"UPDATE HOADON SET IsActive=0 WHERE MaHD = '" + MaHD + "'");
            str += string.Format(@"UPDATE CHITIETHOADON SET IsActive=0 WHERE MaHD = '" + MaHD + "'");
            DBConnect.ExecuteNonQuery(str);
        }

        public void KhoiPhuc(string MaHD)
        {
            string str = string.Format(@"Update HOADON SET IsActive=1 WHERE MaHD = '" + MaHD + "'");
            str += string.Format(@"UPDATE CHITIETHOADON SET IsActive=1 WHERE MaHD = '" + MaHD + "'");
            DBConnect.ExecuteNonQuery(str);
        }



        public void SuaHoaDon(string MaHD, string makh, string NgayHD, string manv, string DienGiai)
        {
            string str = "UPDATE HoaDon SET makh = '" + makh + "', NgayHD = '" + NgayHD + "',manv='" + manv + "',DienGiai = N'"+ DienGiai + "' WHERE MaHD='" + MaHD + "'";
            DBConnect.ExecuteNonQuery(str);
        }
        public void UpdateTrangThaiSauThanhToan(string MaHD)
        {
            string s = "UPDATE HoaDon SET trangthai =  N'Đã thanh toán' WHERE MaHD = '" + MaHD + "'";
            DBConnect.ExecuteNonQuery(s);
        }
    }
}
