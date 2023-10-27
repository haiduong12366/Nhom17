using QLSV.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV.DAO
{
    internal class TienDienDAO
    {

        private static TienDienDAO instance;
        public static TienDienDAO Instance
        {
            get { if (instance == null) instance = new TienDienDAO(); return TienDienDAO.instance; }
            private set => TienDienDAO.instance = value;
        }

        private TienDienDAO() { }

        public DataTable timTienDien(string Maphong, string thang)
        {
            string sql = string.Format("SELECT * FROM tiendien WHERE Maphong = N'{0}' and thang = {1}", Maphong, thang);
            DataTable data = DBConnection.Instance.ExecuteQuery(sql);
            TienDien td = new TienDien();
            foreach (DataRow row in data.Rows)
                td = new TienDien(row);
            return data;
        }
    }
}
