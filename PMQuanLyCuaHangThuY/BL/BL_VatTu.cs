using PMQuanLyCuaHangThuY.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMQuanLyCuaHangThuY.BL
{
    public class BL_VatTu
    {
        public DataTable HienThi(string MAVT, string TENVT, string DVT, string MANHOM)
        {
            string Query = "SELECT * FROM VATTU WHERE Isactive=1 " +
                           "AND MAVT LIKE N'%" + MAVT + "%' AND TENVT LIKE N'%" + TENVT + "%' " +
                           "AND DVT LIKE N'%" + DVT + "%' AND MANHOM LIKE N'%" + MANHOM + "%' ";
                           //"AND DONGIA BETWEEN " + DonGia1 + " AND " + DonGia2;
            return DBConnect.Load(Query);
        }

        public DataTable HienThiVatTuDinhChi()
        {
            string Query = "SELECT * FROM VATTU WHERE  Isactive=0";
            //"AND DONGIA BETWEEN " + DonGia1 + " AND " + DonGia2;
            return DBConnect.Load(Query);
        }



        public DataTable DanhSachNhom()
        {
            string Query = "select * from NHOM WHERE LOAI = N'VT'";
            return DBConnect.Load(Query);
        }
        public void Them(string MAVT, string TENVT, string MANHOM,string DVT, string MOTA, decimal KHOILUONG,decimal KICHTHUOC,decimal DONGIA)
        {
            string Query = "INSERT INTO VATTU(MAVT,TENVT,MANHOM,DVT,MOTA,KHOILUONG,KICHTHUOC,DONGIA)  VALUES ( '" + MAVT + "',N'" + TENVT + "','" + MANHOM + "',N'"+ DVT + "',N'"+ MOTA + "',"+ KHOILUONG + ","+ KICHTHUOC + ","+ DONGIA + ")";
            DBConnect.ExecuteNonQuery(Query);
        }
        public void Sua(string MAVT,string MAVT2, string TENVT, string MANHOM, string DVT, string MOTA, decimal KHOILUONG, decimal KICHTHUOC,decimal DONGIA)
        {
            string Query = "UPDATE VATTU SET MAVT = '" + MAVT + "',TENVT=N'" + TENVT + "',MANHOM = '" + MANHOM + "',DVT = N'"+ DVT + "',MOTA = N'"+ MOTA + "',KHOILUONG = "+ KHOILUONG + ",KICHTHUOC = "+ KICHTHUOC + ",DONGIA = "+ DONGIA + " WHERE MAVT = '" + MAVT2 + "'";
            DBConnect.ExecuteNonQuery(Query);
        }

        public void Xoa(string MAVT)
        {
            string Query = string.Format(@"DELETE VATTU WHERE MAVT = '" + MAVT + "'");
            DBConnect.ExecuteNonQuery(Query);
        }


        public void DinhChi(string MAVT)
        {
            string str = string.Format(@"Update VATTU SET IsActive=0 WHERE MAVT = '" + MAVT + "'");
            DBConnect.ExecuteNonQuery(str);
        }


        public void KhoiPhuc(string MAVT)
        {
            string str = string.Format(@"Update VATTU SET IsActive=1 WHERE MAVT = '" + MAVT + "'");
            DBConnect.ExecuteNonQuery(str);
        }



        public int CheckExits(string MAVT)
        {
            int i = 0;
            string Querys = "SELECT * FROM VATTU WHERE MAVT = '" + MAVT + "'";
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

        internal DataTable HienThi(string text1, string text2, string text3, string text4, string text5)
        {
            throw new NotImplementedException();
        }
    }
}
