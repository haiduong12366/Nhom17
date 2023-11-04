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

        TienNuocDAO tnDao = new TienNuocDAO();
        TienNuoc TienNuoc = new TienNuoc();

        HoaDonDAO hdDAO = new HoaDonDAO();
        HoaDonDN hd = new HoaDonDN();

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
            dgvTienNuoc.DataSource = tnDao.DanhSach();
            dgvHoaDon.DataSource = hdDAO.DanhSach();
            DoiTenDN();
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

            SinhVienDAO.Instance.CapNhat(ns);
          
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
        private void DoiTenDN()
        {
            string[] thuoctinh = { "Mã Phòng", "Tháng", "Số Điện đàu tháng", "Số điện cuối tháng", "Tiền Điện" };
            for (int i = 0; i < thuoctinh.Length; i++)
            {
                dgvTienDien.Columns[i].HeaderText = thuoctinh[i];
            }
            string[] thuoctinh1 = { "Mã Phòng", "Tháng", "Số Nước đàu tháng", "Số Nước cuối tháng", "Tiền Nước" };
            for (int i = 0; i < thuoctinh1.Length; i++)
            {
                dgvTienNuoc.Columns[i].HeaderText = thuoctinh1[i];
            }

            string[] thuoctinh2 = { "Mã Hóa Đơn", "Mã Phòng", "Tháng", "Tổng Tiền", "Trạng Thái" };
            for (int i = 0; i < thuoctinh2.Length; i++)
            {
                dgvHoaDon.Columns[i].HeaderText = thuoctinh2[i];
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
            if (txtTimKiem.Text == "")
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
            TienDien = new TienDien(txtMaPhongTD.Text, int.Parse(cboThangTD.Text), int.Parse(txtDienDauThang.Text), int.Parse(txtDienCuoiThang.Text));
            tdDao.Them(TienDien);
            dgvTienDien.DataSource = tdDao.DanhSach();
        }

        private void btnXoaTD_Click(object sender, EventArgs e)
        {
            TienDien = new TienDien(txtMaPhongTD.Text, int.Parse(cboThangTD.Text), int.Parse(txtDienDauThang.Text), int.Parse(txtDienCuoiThang.Text));
            tdDao.Xoa(TienDien);
            dgvTienDien.DataSource = tdDao.DanhSach();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (cboLoaiTimKiem.Text == "") return;
            if (txtTimKiem.Text == "")
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

        private void btnTimKiemTD_Click(object sender, EventArgs e)
        {
            try
            {
                dgvTienDien.DataSource = tdDao.timTienDien(txtMaPhongTD.Text, cboThangTD.Text);

            }
            catch { }
        } 

        private void dgvTienNuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow a = dgvTienNuoc.SelectedRows[0];

                txtMaPhongTN.Text = a.Cells[0].Value.ToString();
                cboThangTN.Text = a.Cells[1].Value.ToString();
                txtNuocDauThang.Text = a.Cells[2].Value.ToString();
                txtNuocCuoiThang.Text = a.Cells[3].Value.ToString();
                txtTienNuoc.Text = a.Cells[4].Value.ToString();
            }
            catch { }
        }

        private void btnThemTN_Click(object sender, EventArgs e)
        {
            TienNuoc = new TienNuoc(txtMaPhongTN.Text, int.Parse(cboThangTN.Text), int.Parse(txtNuocDauThang.Text), int.Parse(txtNuocCuoiThang.Text));
            tnDao.Them(TienNuoc);
            dgvTienNuoc.DataSource = tnDao.DanhSach();
        }

        private void btnXoaTN_Click(object sender, EventArgs e)
        {
            TienNuoc = new TienNuoc(txtMaPhongTN.Text, int.Parse(cboThangTN.Text), int.Parse(txtNuocDauThang.Text), int.Parse(txtNuocCuoiThang.Text));
            tnDao.Xoa(TienNuoc);
            dgvTienNuoc.DataSource = tnDao.DanhSach();
        }

        private void btnTimKiemTN_Click(object sender, EventArgs e)
        {
            try
            {
                dgvTienNuoc.DataSource = tnDao.timTienNuoc(txtMaPhongTN.Text, cboThangTN.Text);
            }
            catch
            { }
         }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow a = dgvHoaDon.SelectedRows[0];

                txtMaHD.Text = a.Cells[0].Value.ToString();
                txtMaPhongHD.Text= a.Cells[1].Value.ToString();
                cboThangHD.Text = a.Cells[2].Value.ToString();
                txtTongTien.Text = a.Cells[3].Value.ToString();
                txtTrangThai.Text = a.Cells[4].Value.ToString();
            }
            catch { }
        }

        private void btnTaoHD_Click(object sender, EventArgs e)
        {
            hdDAO.Them(Convert.ToInt32(txtMaHD.Text),txtMaPhongHD.Text,Convert.ToInt32(cboThangHD.Text));
            dgvHoaDon.DataSource = hdDAO.DanhSach();
        }

        private void btnXacNhanDT_Click(object sender, EventArgs e)
        {
            hdDAO.XacNhan(Convert.ToInt32(txtMaHD.Text), txtMaPhongHD.Text, Convert.ToInt32(cboThangHD.Text));
            dgvHoaDon.DataSource = hdDAO.DanhSach();
        }

        private void btnCD_Click(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;

            int second = currentTime.Second;
            int minute = currentTime.Minute;
            int hour = currentTime.Hour;
            int day = currentTime.Day;
            int month = currentTime.Month;

            int ramdomNumber = second + minute * 60 + hour * 60 * 60 + day * 24 * 60 * 60 + month * 30 * 24 * 60 * 60;
            
            txtMaHD.Text = ramdomNumber.ToString();
            txtMaPhongHD.Text = txtMaPhongTN.Text;
            cboThangHD.Text = cboThangTN.Text;

        }

        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            hdDAO.Xoa(Convert.ToInt32(txtMaHD.Text));
            dgvHoaDon.DataSource = hdDAO.DanhSach();
        }

        private void btnTimKiemHD_Click(object sender, EventArgs e)
        {
            int ktr = 0;
            int thang;
          
            if (cboLoai.Text == "Đã Đóng Tiền") ktr = 1;
            if (cboLoai.Text == "Chưa Đóng Tiền") ktr = 2;
            if (cboThangHD.Text == "") thang = -1;
            else thang = Convert.ToInt32(cboThangHD.Text);

            dgvHoaDon.DataSource = hdDAO.TimKiem(ktr,txtMaPhongHD.Text,thang);
        }
    }   
}
