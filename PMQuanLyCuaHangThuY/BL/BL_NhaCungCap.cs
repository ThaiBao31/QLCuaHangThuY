using PMQuanLyCuaHangThuY.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMQuanLyCuaHangThuY.BL
{
    public class BL_NhaCungCap
    {
        public DataTable HienThi(string MANCC, string TENNCC, string DIACHI, string MANHOM)
        {
            string Query = "select * from NHACUNGCAP WHERE Isactive=1 " +
                " AND MANCC LIKE N'%" + MANCC + "%' AND TENNCC LIKE N'%" + TENNCC + "%'" +
                " AND DIACHI LIKE N'%" + DIACHI + "%'" +
                " AND MANHOM LIKE N'%" + MANHOM + "%'";
            return DBConnect.Load(Query);
        }

        public DataTable HienThiNCCDinhChi()
        {
            string Query = "select * from NHACUNGCAP WHERE Isactive=0 ";
            return DBConnect.Load(Query);
        }


        public DataTable DanhSachNhom()
        {
            string Query = "select * from NHOM WHERE LOAI = N'NCC'";
            return DBConnect.Load(Query);
        }
        public void Them(string MANCC, string TENNCC, string MANHOM, string DIACHI, string SDT, string FAX, string MASOTHUE)
        {
            string Query = "INSERT INTO NHACUNGCAP(MANCC,TENNCC,MANHOM,DIACHI,SDT,FAX,MASOTHUE)  VALUES ( '" + MANCC + "',N'" + TENNCC + "','" + MANHOM + "',N'" + DIACHI + "',N'" + SDT + "',N'" + FAX + "',N'" + MASOTHUE + "')";
            DBConnect.ExecuteNonQuery(Query);
        }
        public void Sua(string MANCC, string MANCC2, string TENNCC, string MANHOM, string DIACHI, string SDT, string FAX, string MASOTHUE)
        {
            string Query = "UPDATE NHACUNGCAP SET MANCC = '" + MANCC + "',TENNCC=N'" + TENNCC + "',MANHOM = '" + MANHOM + "',DIACHI = N'" + DIACHI + "',SDT = N'" + SDT + "',FAX = N'" + FAX + "',MASOTHUE = N'" + MASOTHUE + "' WHERE MANCC = '" + MANCC2 + "'";
            DBConnect.ExecuteNonQuery(Query);
        }
        public void Xoa(string MANCC)
        {
            string Query = string.Format(@"DELETE NHACUNGCAP WHERE MANCC = '" + MANCC + "'");
            DBConnect.ExecuteNonQuery(Query);
        }

        public void DinhChi(string MANCC)
        {
            string str = string.Format(@"Update NHACUNGCAP SET IsActive=0 WHERE MANCC = '" + MANCC + "'");
            DBConnect.ExecuteNonQuery(str);
        }


        public void KhoiPhuc(string MANCC)
        {
            string str = string.Format(@"Update NHACUNGCAP SET IsActive=1 WHERE MANCC = '" + MANCC + "'");
            DBConnect.ExecuteNonQuery(str);
        }




        public int CheckExits(string MANCC)
        {
            int i = 0;
            string Querys = "SELECT * FROM NHACUNGCAP WHERE MANCC = '" + MANCC + "'";
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
