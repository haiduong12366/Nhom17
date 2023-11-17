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
        private static HopDongDAO instance;
        public static HopDongDAO Instance
        {
            get { if (instance == null) instance = new HopDongDAO(); return HopDongDAO.instance; }
            private set => HopDongDAO.instance = value;
        }
        public DataTable DanhSach()
        {
            return dbConnec.FormLoad("SELECT * FROM SuKienDatPhong");
        }

        public DataTable TimKiem(string tk, string value)
        {
            string lenh = string.Format("SELECT * FROM SuKienDatPhong WHERE " +tk + " = '" +value+"'" );
            return dbConnec.FormLoad(lenh);
        }

        internal HopDong TimKiemHopDongTheoSV(string mssv)
        {
            DataTable data = DBConnection.Instance.ExecuteQuery("USP_TimKiemHopDongTheoSV @mssv ",new object[] { mssv });
            if(data != null)
            {
                HopDong hopDong = new HopDong(data.Rows[0]);
                return hopDong;
            }    
            return null;
        }
    }
}
