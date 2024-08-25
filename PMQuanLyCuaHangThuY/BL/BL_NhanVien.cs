using PMQuanLyCuaHangThuY.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMQuanLyCuaHangThuY.BL
{
    public class BL_NhanVien
    {
        public DataTable DangNhap(string manv, string matkhau)
        {
            string Query = "select * from nhanvien where manv='" + manv + "' and matkhau='" + matkhau + "'";
            return DBConnect.Load(Query);
        }
        public DataTable HienThi(string manv, string tennv, string diachi)
        {
            string Query = "select manv,tennv,DienThoai,DiaChi from nhanvien " +
                           "WHERE Isactive=1 AND manv LIKE N'%" + manv + "%' AND tennv LIKE N'%" + tennv + "%' AND diachi LIKE N'%" + diachi + "%'";
            return DBConnect.Load(Query);
        }
        
        public DataTable HienThiNVDinhChi()
        {
            string Query = "select manv,tennv,DienThoai,DiaChi from nhanvien " +
                           "WHERE Isactive=0 ";
            return DBConnect.Load(Query);
        }





        public void Them(string manv, string tennv, string matkhau, string DienThoai, string DiaChi)
        {
            string Query = "INSERT INTO nhanvien(manv,tennv,matkhau,DienThoai,DiaChi)  VALUES ( '" + manv + "',N'" + tennv + "',N'" + matkhau + "','" + DienThoai + "',N'" + DiaChi + "')";
            DBConnect.ExecuteNonQuery(Query);
        }
        public void Sua(string manv, string manv2, string tennv, string matkhau, string DienThoai, string DiaChi)
        {
            string Query = "UPDATE nhanvien SET manv = '" + manv + "',tennv=N'" + tennv + "',matkhau = N'" + matkhau + "',DienThoai='" + DienThoai + "',DiaChi =N'" + DiaChi + "' WHERE manv = '" + manv2 + "'";
            DBConnect.ExecuteNonQuery(Query);
        }
        public void Xoa(string manv)
        {
            string Query = string.Format(@"DELETE nhanvien WHERE manv = '" + manv + "'");
            DBConnect.ExecuteNonQuery(Query);
        }

        public void DinhChi(string manv)
        {
            string str = string.Format(@"Update nhanvien SET IsActive=0 WHERE manv = '" + manv + "'");
            DBConnect.ExecuteNonQuery(str);
        }


        public void KhoiPhuc(string manv)
        {
            string str = string.Format(@"Update nhanvien SET IsActive=1 WHERE manv = '" + manv + "'");
            DBConnect.ExecuteNonQuery(str);
        }




        public int CheckExits(string manv)
        {
            int i = 0;
            string Querys = "SELECT * FROM nhanvien WHERE manv = '" + manv + "'";
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
        public void Doimatkhau(string manv, string matkhau)
        {
            string Querys = string.Format(@"UPDATE nhanvien set matkhau = '" + matkhau + "' where manv = '" + manv + "'");
            DBConnect.ExecuteNonQuery(Querys);
        }
        public DataTable MatKhau(string manv)
        {
            string Query = "select matkhau from nhanvien WHERE manv = '" + manv + "'";
            return DBConnect.Load(Query);
        }
    }
}
