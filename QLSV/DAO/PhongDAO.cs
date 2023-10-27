using QLSV.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV.DAO
{
    class PhongDAO
    {

        private static PhongDAO instance;
        public static PhongDAO Instance
        {
            get { if (instance == null) instance = new PhongDAO(); return PhongDAO.instance; }
            private set => PhongDAO.instance = value;
        }

        private PhongDAO() { }

        public List<Phong> layMaPhong(string matoa)
        {
            List<Phong> list = new List<Phong>();
            string query = string.Format("select * from phong where matoa = '{0}'", matoa);

            DataTable data = DBConnection.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                Phong phong = new Phong(row);
                list.Add(phong);
            }

            return list;
        }

        public List<Phong> layPhong()
        {
            List<Phong> list = new List<Phong>();
            string query = "select * from phong ";

            DataTable data = DBConnection.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                Phong phong = new Phong(row);
                list.Add(phong);
            }

            return list;
        }
    }
}
