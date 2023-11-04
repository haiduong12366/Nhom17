﻿using QLSV.DAO;
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
    public partial class fTaiKhoan : Form
    {
        string taikhoan = null;
        TaiKhoan tk;
        public fTaiKhoan()
        {
            InitializeComponent();
        }

        private void fTaiKhoan_Load(object sender, EventArgs e)
        {
            taikhoan = fQuanLy.masv;
            txtTaiKhoan.Text = taikhoan;
            tk = TaiKhoanDAO.Instance.layTK(taikhoan);
            txtMatKhau.Text = tk.MatKhau;

        }

        private void btnResetPW_Click(object sender, EventArgs e)
        {
            bool t;
            t = TaiKhoanDAO.Instance.sua(taikhoan, taikhoan);
            txtMatKhau.Text = taikhoan;
        }
    }
}
