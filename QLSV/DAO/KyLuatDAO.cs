using QLSV.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV.DAO
{
    internal class KyLuatDAO
    {
        DBConnection dbConnec = new DBConnection();
        public DataTable DanhSach(string Toa)
        {
            string lenh = string.Format("select * from KyLuat where MaToa = '{0}'", Toa);
            return dbConnec.FormLoad(lenh);
        }

        public void Them(KyLuat ns)
        {
            string sqlStr = string.Format("INSERT INTO KyLuat VALUES('{0}', '{1}', '{2}', '{3}', '{4}')",ns.MaKL,ns.MaSV,ns.MaToa,ns.LoiViPham,ns.NgayViPham );
            dbConnec.ThucThi(sqlStr);

        }
        public void Xoa(KyLuat ns)
        {
            string sqlStr = string.Format("Delete from KyLuat where MaKL = '{0}' and MaToa = '{1}'", ns.MaKL,ns.MaToa);
            dbConnec.ThucThi(sqlStr);

        }

        public DataTable Loc(string KL,string Toa)
        {

            string lenh = string.Format("select * from KyLuat where MaToa = '"+ Toa+ "' and MaSV like N'%" + KL + "%'");
            return dbConnec.FormLoad(lenh);
        }
    }
}
