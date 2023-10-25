using QLSV.DAO;
using QLSV.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV.Views
{
    internal partial class fDoiMatKhau : Form
    {

        private SinhVien sinhVien;
        internal SinhVien SinhVien { get => sinhVien; set => sinhVien = value; }
        public fDoiMatKhau(SinhVien sv)
        {
            InitializeComponent();
            this.SinhVien = sv;
        }
        private event EventHandler<SVEvent> updateTK;
        public event EventHandler<SVEvent> UpdateTK
        {
            add { updateTK += value; }
            remove { updateTK -= value; }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void UpdateAccountInfo()
        {
            string password = txbPassWord.Text;
            string newpass = txbNewPass.Text;
            string reenterPass = txbReEnterPass.Text;

            if (!newpass.Equals(reenterPass))
                MessageBox.Show("Vui lòng nhập lại mật khẩu đúng với mật khẩu mới");
            else
            {
                if (TaiKhoanDAO.Instance.sua(SinhVien.Mssv, newpass))
                {
                    MessageBox.Show("Cập nhật thành công");
                    if (updateTK != null)
                        updateTK(this, new SVEvent(TaiKhoanDAO.Instance.layTK(SinhVien.Mssv)));
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sai mật khẩu");
                }
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateAccountInfo();
        }
    }
    public class SVEvent : EventArgs
    {
        private TaiKhoan sv;

        internal TaiKhoan Sv { get => sv; set => sv = value; }

        internal SVEvent(TaiKhoan sv)
        {
            this.Sv = sv;
        }

        
    }
}
