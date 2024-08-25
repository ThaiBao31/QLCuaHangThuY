using PMQuanLyCuaHangThuY.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMQuanLyCuaHangThuY.BL
{
    public class BL_TonKhoDauKy
    {
        public DataTable HienThi(string MAVT, string TENVT)
        {
            string Query = "select a.MaVT,b.TenVT,a.DVT,a.SoLuong,a.DonGia,a.ThanhTien from TONKHODAUKY a INNER JOIN VATTU b ON a.MAVT = b.MAVT " +
                "WHERE a.Isactive=1 AND a.MAVT LIKE N'%" + MAVT + "%' AND TENVT LIKE N'%" + TENVT + "%'";
            return DBConnect.Load(Query);
        }

        public DataTable HienThiTKDKDinhChi()
        {
            string Query = "select a.MaVT,b.TenVT,a.DVT,a.SoLuong,a.DonGia,a.ThanhTien from TONKHODAUKY a INNER JOIN VATTU b ON a.MAVT = b.MAVT " +
                           "WHERE a.Isactive=0";
            return DBConnect.Load(Query);
        }

        public DataTable DanhSachVatTu()
        {
            string Query = "select * from VATTU WHERE IsActive=1";
            return DBConnect.Load(Query);
        }

        public DataTable VatTuTheoMa(string MAVT)
        {
            string Query = "select * from VATTU where IsActive=1 AND MAVT = '" + MAVT + "'";
            return DBConnect.Load(Query);
        }

        public void Them(string MAVT, string DVT, decimal SoLuong, decimal DonGia,decimal ThanhTien)
        {
            string Query = "INSERT INTO TONKHODAUKY(MAVT,DVT,SoLuong,DonGia,ThanhTien)  VALUES ( '" + MAVT + "',N'" + DVT + "'," + SoLuong + "," + DonGia + "," + ThanhTien + ")";
            DBConnect.ExecuteNonQuery(Query);
        }
        public void Sua(string MAVT, string MAVT2, string DVT, decimal SoLuong, decimal DonGia, decimal ThanhTien)
        {
            string Query = "UPDATE TONKHODAUKY SET MAVT = '" + MAVT + "',DVT=N'" + DVT + "',SoLuong = " + SoLuong + ",DonGia = " + DonGia + ",ThanhTien = " + ThanhTien + " WHERE MAVT = '" + MAVT2 + "'";
            DBConnect.ExecuteNonQuery(Query);
        }
        public void Xoa(string MAVT)
        {
            string Query = string.Format(@"DELETE TONKHODAUKY WHERE MAVT = '" + MAVT + "'");
            DBConnect.ExecuteNonQuery(Query);
        }

        public void DinhChi(string MAVT)
        {
            string str = string.Format(@"Update TONKHODAUKY SET IsActive=0 WHERE MAVT = '" + MAVT + "'");
            DBConnect.ExecuteNonQuery(str);
        }


        public void KhoiPhuc(string MAVT)
        {
            string str = string.Format(@"Update TONKHODAUKY SET IsActive=1 WHERE MAVT = '" + MAVT + "'");
            DBConnect.ExecuteNonQuery(str);
        }



        public int CheckExits(string MAVT)
        {
            int i = 0;
            string Querys = "SELECT * FROM TONKHODAUKY WHERE MAVT = '" + MAVT + "'";
            DataTable dt = DBConnect.Load(Querys);
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
    }
}
