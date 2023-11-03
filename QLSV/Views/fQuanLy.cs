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
    public partial class fQuanLy : Form
    {
        SinhVienDAO svDao = new SinhVienDAO();
        SinhVien ns = new SinhVien();
        TienDienDAO tdDao = new TienDienDAO();
        TienDien TienDien = new TienDien();
        public fQuanLy()
        {
            InitializeComponent();
        }

        private void tbQLSV_Click(object sender, EventArgs e)
        {

        }

        private void fQuanLy_Load(object sender, EventArgs e)
        {
            dgvSinhVien.DataSource = svDao.DanhSach();
            DoiTenGV();
            dgvTienDien.DataSource = tdDao.DanhSach();
            DoiTenTD();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ns = new SinhVien(txtMSV.Text, txtTen.Text, dtpNgaySinh.Value.Date, txtGT.Text, txtCCCD.Text, txtDiaChi.Text, txtSdt.Text, txtMaPhong.Text, txtMaToa.Text);
            svDao.Xoa(ns);
            dgvSinhVien.DataSource = svDao.DanhSach();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ns = new SinhVien(txtMSV.Text, txtTen.Text, dtpNgaySinh.Value.Date, txtGT.Text, txtCCCD.Text, txtDiaChi.Text, txtSdt.Text, txtMaPhong.Text, txtMaToa.Text);
            svDao.Sua(ns);
            dgvSinhVien.DataSource = svDao.DanhSach();
        }
        private void DoiTenGV()
        {
            string[] thuoctinh = { "Mã Sinh Viên", "Họ Tên", "Ngày Sinh", "Giới tính", "CCCD", "Địa Chỉ", "Số điện thoại", "Mã Phòng", "Mã Tòa" };
            for (int i = 0; i < thuoctinh.Length; i++)
            {
                dgvSinhVien.Columns[i].HeaderText = thuoctinh[i];
            }
        }
        private void DoiTenTD()
        {
            string[] thuoctinh = { "Mã Phòng", "Tháng", "Số Điện đàu tháng", "Số điện cuối tháng", "Tiền Điện" };
            for (int i = 0; i < thuoctinh.Length; i++)
            {
                dgvTienDien.Columns[i].HeaderText = thuoctinh[i];
            }
        }

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow r = dgvSinhVien.SelectedRows[0];

                txtMSV.Text = r.Cells[0].Value.ToString();
                txtTen.Text = r.Cells[1].Value.ToString();
                dtpNgaySinh.Text = r.Cells[2].Value.ToString();
                txtGT.Text = r.Cells[3].Value.ToString();
                txtCCCD.Text = r.Cells[4].Value.ToString();
                txtDiaChi.Text = r.Cells[5].Value.ToString();
                txtSdt.Text = r.Cells[6].Value.ToString();
                txtMaPhong.Text = r.Cells[7].Value.ToString();
                txtMaToa.Text = r.Cells[8].Value.ToString();
            }
            catch { }
        }

        private void cboLoaiTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(txtTimKiem.Text == "")
            {
                dgvSinhVien.DataSource = svDao.DanhSach();
                return;
            }
            string timkiem = "";
            if (cboLoaiTimKiem.Text == "Tên") timkiem = "HoTen";
            if (cboLoaiTimKiem.Text == "Mã SV") timkiem = "MaSV";
            if (cboLoaiTimKiem.Text == "Phòng") timkiem = "MaPhong";
            if (cboLoaiTimKiem.Text == "Tòa") timkiem = "MaToa";

            dgvSinhVien.DataSource = svDao.Search(timkiem, txtTimKiem.Text);
        }



        private void dgvTienDien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow a = dgvTienDien.SelectedRows[0];

                txtMaPhongTD.Text = a.Cells[0].Value.ToString();
                cboThangTD.Text = a.Cells[1].Value.ToString();
                txtDienDauThang.Text = a.Cells[2].Value.ToString();
                txtDienCuoiThang.Text = a.Cells[3].Value.ToString();
                txtTienDien.Text = a.Cells[4].Value.ToString();
            }
            catch { }
        }

        private void btnThemTD_Click(object sender, EventArgs e)
        {
            TienDien = new TienDien(txtMaPhongTD.Text,int.Parse(cboThangTD.Text),int.Parse(txtDienDauThang.Text),int.Parse(txtDienCuoiThang.Text));
            tdDao.Them(TienDien);
            dgvTienDien.DataSource = tdDao.DanhSach();
        }

        private void btnXoaTD_Click(object sender, EventArgs e)
        {
            TienDien = new TienDien(txtMaPhongTD.Text, int.Parse(cboThangTD.Text), int.Parse(txtDienDauThang.Text), int.Parse(txtDienCuoiThang.Text));
            tdDao.Xoa(TienDien);
            dgvTienDien.DataSource = tdDao.DanhSach();
        }
    }
}
