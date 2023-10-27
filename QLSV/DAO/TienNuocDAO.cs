using QLSV.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV.DAO
{
    internal class TienNuocDAO
    {

        private static TienNuocDAO instance;
        public static TienNuocDAO Instance
        {
            get { if (instance == null) instance = new TienNuocDAO(); return TienNuocDAO.instance; }
            private set => TienNuocDAO.instance = value;
        }

        private TienNuocDAO() { }

        public DataTable timTienNuoc(string Maphong, string thang)
        {
            string sql = string.Format("SELECT * FROM tiennuoc WHERE Maphong = N'{0}' and thang = {1}", Maphong, thang);
            DataTable data = DBConnection.Instance.ExecuteQuery(sql);
            return data;
        }
    }
}
