using PMQuanLyCuaHangThuY.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMQuanLyCuaHangThuY.BL
{
    public class BL_Nhom
    {
        public DataTable HienThi(string MANHOM, string TENNHOM, string LOAI)
        {
            string Query = "select MANHOM, TENNHOM, LOAI from NHOM WHERE Isactive=1 " +
                "AND MANHOM LIKE N'%" + MANHOM + "%' " +
                "AND TENNHOM LIKE N'%" + TENNHOM + "%' " +
                "AND LOAI LIKE N'%" + LOAI + "%'";
            return DBConnect.Load(Query);
        }


        public DataTable HienThiNhomDinhChi()
        {
            string Query = "select MANHOM, TENNHOM, LOAI from NHOM WHERE Isactive=0";
            return DBConnect.Load(Query);
        }



        public void Them(string MANHOM, string TENNHOM, string LOAI)
        {
            string Query = "INSERT INTO NHOM(MANHOM,TENNHOM,LOAI)  VALUES ( '" + MANHOM + "',N'" + TENNHOM + "',N'" + LOAI + "')";
            DBConnect.ExecuteNonQuery(Query);
        }

        public void Sua(string MANHOM, string MANHOM2, string TENNHOM, string LOAI)
        {
            string Query = "UPDATE NHOM SET MANHOM = '" + MANHOM + "',TENNHOM=N'" + TENNHOM + "',LOAI = N'" + LOAI + "' WHERE MANHOM = '" + MANHOM2 + "'";
            DBConnect.ExecuteNonQuery(Query);
        }
        public void Xoa(string MANHOM)
        {
            string Query = string.Format(@"DELETE NHOM WHERE MANHOM = '" + MANHOM + "'");
            DBConnect.ExecuteNonQuery(Query);
        }

        public void DinhChi(string MANHOM)
        {
            string str = string.Format(@"Update NHOM SET IsActive=0 WHERE MANHOM = '" + MANHOM + "'");
            DBConnect.ExecuteNonQuery(str);
        }



        public void KhoiPhuc(string MANHOM)
        {
            string str = string.Format(@"Update NHOM SET IsActive=1 WHERE MANHOM = '" + MANHOM + "'");
            DBConnect.ExecuteNonQuery(str);
        }



        public int CheckExits(string MANHOM)
        {
            int i = 0;
            string Querys = "SELECT * FROM NHOM WHERE MANHOM = '" + MANHOM + "'";
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
