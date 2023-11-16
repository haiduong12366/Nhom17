using QLSV.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV.DAO
{
    internal class HopDongDAO
    {

        DBConnection dbConnec = new DBConnection();

        public DataTable DanhSach(string toa)
        {
            return dbConnec.FormLoad("SELECT * FROM SuKienDatPhong where MaPhong like N'%" + toa + "%'");
        }

        public DataTable TimKiem(string tk, string value,string ql)
        {

            string lenh = string.Format("SELECT * FROM SuKienDatPhong WHERE " +tk + " like N'%" + value+ "%' and MaQL = '" +ql +"'");
            return dbConnec.FormLoad(lenh);
        }

    }
}
