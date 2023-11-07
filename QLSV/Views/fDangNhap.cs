using QLSV.DAO;
using QLSV.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV.Views
{
    public partial class fDangNhap : Form
    {

        public static string currAcc = null;
        public fDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string txt = txtTaiKhoan.Text;
            TaiKhoan tk = TaiKhoanDAO.Instance.layTK(txt);
            if (tk == null)
            {
                MessageBox.Show("Tài khoản tồn tại", "Thông báo");
            }
            else
            {
                currAcc = txtTaiKhoan.ToString();
                if(tk.CapBac == 0)
                {
                    string sv = SinhVienDAO.Instance.Loc(txt).Mssv;
                    fXemPhong f = new fXemPhong(sv);
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else
                {
                    fQuanLy f = new fQuanLy();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }

            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            fDangKy f = new fDangKy();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
