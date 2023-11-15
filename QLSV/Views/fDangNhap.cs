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
            if (tk == null || tk.MatKhau != txtMatKhau.Text)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng");
            }
            else
            {
                currAcc = tk.Taikhoan.ToString();
               
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
                    DBConnection.DangNhap(tk.Taikhoan, tk.Taikhoan);
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
