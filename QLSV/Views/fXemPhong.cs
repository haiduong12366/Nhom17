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


    internal partial class fXemPhong : Form
    {
        private TaiKhoan tk;

        internal TaiKhoan Tk { get => tk; set => tk = value; }

        public fXemPhong()
        {
            InitializeComponent();
            Load();
        }

        void Load()
        {
            DateTime today = DateTime.Now;
            for (int i = 1; i <= 12; i++)
            {
                cbThang.Items.Add(i);
                cbThang2.Items.Add(i);
            }
            SinhVien sv = SinhVienDAO.Instance.Loc("20142487");
            txtTen.Text = sv.Ten;
            txtMaPhong.Text = sv.Maphong;
            cbThang.Text = today.Month.ToString();
            txtTen2.Text = sv.Ten;
            txtMaPhong2.Text = sv.Maphong;
            cbThang2.Text = today.Month.ToString();
            LoadSV();



        }

        void LoadSV()
        {
            SinhVien sv = SinhVienDAO.Instance.Loc("20142487");
            txtMaSv.Text = sv.Mssv;
            txtHoTen.Text = sv.Ten;
            dtpkNgaySinh.Value = sv.ngaySinh;
            txtCCCD.Text = sv.Cccd;
            txtDiaChi.Text = sv.Diachi;
            txtGioiTinh.Text = sv.Gioitinh;
            txtSDT.Text = sv.Sdt;
            txtMaToa.Text = sv.Matoa;
            txtPhong.Text = sv.Maphong;
        }

        private void btnXemDien_Click(object sender, EventArgs e)
        {
            string MaPhong = txtMaPhong.Text;
            string thang = cbThang.Text;
            dtgvDien.DataSource = TienDienDAO.Instance.timTienDien(MaPhong, thang);
        }

        private void btnXem2_Click(object sender, EventArgs e)
        {
            string MaPhong = txtMaPhong2.Text;
            string thang = cbThang2.Text;
            dtgvNuoc.DataSource = TienNuocDAO.Instance.timTienNuoc(MaPhong, thang);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string masv = txtMaSv.Text;
            string hoten = txtHoTen.Text;
            string gioitinh = txtGioiTinh.Text;
            string cccd = txtCCCD.Text;
            string diachi = txtDiaChi.Text;
            string sdt = txtSDT.Text;
            string ngaysinh = String.Format("{0}-{1}-{2}", dtpkNgaySinh.Value.Year, dtpkNgaySinh.Value.Day, dtpkNgaySinh.Value.Month);
            int count = SinhVienDAO.Instance.Sua(hoten, ngaysinh, gioitinh, cccd, diachi, sdt, masv);
            if (count > 0)
            {
                MessageBox.Show("Sửa thành công");
                LoadSV();
            }
            else
                MessageBox.Show("Sửa thất bại");
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            SinhVien sv = SinhVienDAO.Instance.Loc("20142487");
            this.Tk = TaiKhoanDAO.Instance.layTK(sv.Mssv);
            fDoiMatKhau f = new fDoiMatKhau(sv);
            f.UpdateTK += F_UpdateTK;
            f.ShowDialog();
        }

        private void F_UpdateTK(object sender, SVEvent e)
        {
            
            if (tk.MatKhau != e.Sv.MatKhau)
            {
                MessageBox.Show("Vui lòng đăng nhập lại","Thông Báo");
                this.Close();
                btnDangXuat.Click += btnDangXuat_Click;
            }    
        }
    }
}
