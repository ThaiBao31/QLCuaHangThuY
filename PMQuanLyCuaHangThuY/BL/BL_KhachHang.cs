using PMQuanLyCuaHangThuY.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMQuanLyCuaHangThuY.BL
{
    public class BL_KhachHang
    {
        public DataTable HienThi(string MAKH, string TENKH, string DIACHI, string MANHOM)
        {
            string Query = "select * from KHACHHANG WHERE Isactive=1 " +
                " AND MAKH LIKE N'%" + MAKH + "%' AND TENKH LIKE N'%" + TENKH + "%' " +
                " AND DIACHI LIKE N'%" + DIACHI + "%'" +
                " AND MANHOM LIKE N'%" + MANHOM + "%'";
            return DBConnect.Load(Query);
        }

        public DataTable HienThiKHDinhChi()
        {
            string Query = "select * from KHACHHANG WHERE Isactive=0 ";
            return DBConnect.Load(Query);
        }

        public void DinhChi(string MAVT)
        {
            string str = string.Format(@"Update KHACHHANG SET IsActive=0 WHERE MAKH = '" + MAVT + "'");
            DBConnect.ExecuteNonQuery(str);
        }


        public void KhoiPhuc(string MAVT)
        {
            string str = string.Format(@"Update KHACHHANG SET IsActive=1 WHERE MAKH = '" + MAVT + "'");
            DBConnect.ExecuteNonQuery(str);
        }

        public DataTable DanhSachNhom()
        {
            string Query = "select * from NHOM WHERE LOAI = N'KH'";
            return DBConnect.Load(Query);
        }
        public void Them(string MAKH, string TENKH, string MANHOM, string NGAYSINH, string GIOITINH, string DIACHI, string SDT)
        {
            string Query = "INSERT INTO KHACHHANG(MAKH,TENKH,MANHOM,NGAYSINH,GIOITINH,DIACHI,SDT)  VALUES ( '" + MAKH + "',N'" + TENKH + "','" + MANHOM + "','" + NGAYSINH + "',N'" + GIOITINH + "',N'" + DIACHI + "',N'" + SDT + "')";
            DBConnect.ExecuteNonQuery(Query);
        }
        public void Sua(string MAKH, string MAKH2, string TENKH, string MANHOM, string NGAYSINH, string GIOITINH, string DIACHI, string SDT)
        {
            string Query = "UPDATE KHACHHANG SET MAKH = '" + MAKH + "',TENKH=N'" + TENKH + "',MANHOM = '" + MANHOM + "',NGAYSINH = '" + NGAYSINH + "',GIOITINH = N'" + GIOITINH + "',DIACHI = N'" + DIACHI + "',SDT = N'" + SDT + "' WHERE MAKH = '" + MAKH2 + "'";
            DBConnect.ExecuteNonQuery(Query);
        }
        public void Xoa(string MAKH)
        {
            string Query = string.Format(@"DELETE KHACHHANG WHERE MAKH = '" + MAKH + "'");
            DBConnect.ExecuteNonQuery(Query);
        }
        public int CheckExits(string MAKH)
        {
            int i = 0;
            string Querys = "SELECT * FROM KHACHHANG WHERE MAKH = '" + MAKH + "'";
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
