using QLSV.DAO;
using QLSV.DTO;
using System;
using System.Windows.Forms;

namespace QLSV
{
    public partial class fDangKy : Form
    {//hello
        public fDangKy()
        {
            InitializeComponent();
            Load();
        }
        void Load()
        {
            LoadDTPK();
            LoadMaToa();
            LoadGioiTinh();
        }

        void LoadDTPK()
        {
            dtpkNgaySinh.Value = new DateTime(2000, 1, 1);
        }
        void LoadGioiTinh()
        {
            cbGioiTinh.Items.Add("Nam");
            cbGioiTinh.Items.Add("Nữ");
        }
        void LoadMaToa()
        {
            cbMaToa.DataSource = ToaDAO.Instance.layMaToa();
            cbMaToa.DisplayMember = "TenToa";
            for (int i = 1; i < 5; i++)
                cbSoKy.Items.Add(i);

        }
        void LoadMaPhong()
        {
            string matoa = (cbMaToa.SelectedItem as Toa).MaToa;
            cbMaPhong.DataSource = PhongDAO.Instance.layMaPhong(matoa);
            cbMaPhong.DisplayMember = "MaPhong";
        }
        private void cbMaToa_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMaPhong();
        }
        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && Convert.ToInt32(e.KeyChar) != 8)
                e.Handled = true;

        }
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string masv = txtMaSv.Text;
            string hoten = txtHoTen.Text;
            string gioitinh = cbGioiTinh.SelectedItem.ToString();
            string cccd = txtCCCD.Text;
            string diachi = txtDiaChi.Text;
            string sdt = txtSDT.Text;
            string matoa = (cbMaToa.SelectedItem as Toa).MaToa;
            string maphong = (cbMaPhong.SelectedItem as Phong).MaPhong;
            int soky = Convert.ToInt32(cbSoKy.SelectedItem.ToString());
            string sql = string.Format("UTP_InsertStudent @masv , @hoten , '{0}-{1}-{2}' , @gioitinh , @cccd , @diachi , @sdt , @matoa , @maphong , @soky ", dtpkNgaySinh.Value.Year, dtpkNgaySinh.Value.Day, dtpkNgaySinh.Value.Month);
            int count = DBConnection.Instance.ExecuteNonQuery(sql, new object[] { masv, hoten, gioitinh, cccd, diachi, sdt, matoa, maphong, soky });
            if (count > 0)
                MessageBox.Show(string.Format("Thêm thành công {0}", count));
            else
                MessageBox.Show("Thêm thất bại ");

        }


    }
}
