using QLSV.DAO;
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

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
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

            dgvSinhVien.DataSource = svDao.Loc(timkiem, txtTimKiem.Text);
        }
    }
}
