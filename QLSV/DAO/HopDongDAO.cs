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

        public DataTable DanhSach()
        {
            return dbConnec.FormLoad("SELECT * FROM SuKienDatPhong");
        }

        public DataTable TimKiem(string tk, string value)
        {

            string lenh = string.Format("SELECT * FROM SuKienDatPhong WHERE " +tk + " = '" +value+"'" );
            return dbConnec.FormLoad(lenh);
        }

    }
}
