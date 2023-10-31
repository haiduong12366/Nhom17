using QLSV.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV.DAO
{
    internal class SinhVienDAO
    {
        private static SinhVienDAO instance;
        public static SinhVienDAO Instance
        {
            get { if (instance == null) instance = new SinhVienDAO(); return SinhVienDAO.instance; }
            private set => SinhVienDAO.instance = value;
        }


        DBConnection dbConnec = new DBConnection();
        public DataTable DanhSach()
        {
            return dbConnec.FormLoad("SELECT * FROM SinhVien");
        }

        public DataTable Loc(string col, string value)
        {
            string lenh = string.Format("SELECT * FROM SinhVien WHERE {0} = N'{1}'", col, value);
            return dbConnec.FormLoad(lenh);
        }
        public void Them(SinhVien ns)
        {
            string sqlStr = string.Format("INSERT INTO SinhVien(MaSV, HoTen, NgaySinh,GioiTinh, CCCD,DiaChi, SDT, MaPhong, MaToa) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')", ns.Mssv,ns.Ten,ns.ngaySinh,ns.Gioitinh,ns.Cccd,ns.Diachi,ns.Sdt,ns.Maphong,ns.Matoa);
            dbConnec.ThucThi(sqlStr);

        }

        public void Xoa(SinhVien ns)
        {
            string sqlStr = string.Format("DELETE FROM SinhVien WHERE MaSV = '{0}';", ns.Mssv);
            dbConnec.ThucThi(sqlStr);

        }

        public void Sua(SinhVien ns)
        {
            string sqlStr = string.Format("UPDATE SinhVien SET HoTen = '{0}',NgaySinh = '{1}',GioiTinh = '{2}', CCCD = '{3}', DiaChi = '{4}', SDT = '{5}', MaPhong = '{6}',MaToa = '{7}' WHERE MaSV = '{8}';", ns.Ten, ns.ngaySinh, ns.Gioitinh, ns.Cccd, ns.Diachi, ns.Sdt, ns.Maphong, ns.Matoa, ns.Mssv);
            dbConnec.ThucThi(sqlStr);

        }

        public SinhVien Loc(string masv)
        {
            
            string sql = string.Format("SELECT * FROM SinhVien WHERE masv = N'{0}'", masv);
            DataTable data = DBConnection.Instance.ExecuteQuery(sql);  
            SinhVien sv = new SinhVien(data.Rows[0]);
            return sv;
        }
        public int Sua(string ten,DateTime ngaysinh,string gioitinh,string cccd,string diachi, string sdt,byte[] anh ,string mssv)
        {
            string sqlStr = string.Format("UTP_SuaSV @Hoten , @Ngaysinh , @gioitinh , @cccd , @diachi , @sdt , @anh , @MaSV");
            int count = DBConnection.Instance.ExecuteNonQuery(sqlStr, new object[] { ten,ngaysinh,gioitinh,cccd,diachi,sdt,anh,mssv });
            return count;
        }

    }
}
