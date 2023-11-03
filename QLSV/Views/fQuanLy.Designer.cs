namespace QLSV.Views
{
    partial class fQuanLy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabQLSV = new System.Windows.Forms.TabControl();
            this.tbQLSV = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grpDanhSach = new System.Windows.Forms.GroupBox();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpTTSV = new System.Windows.Forms.GroupBox();
            this.grbTimKiem = new System.Windows.Forms.GroupBox();
            this.cboLoaiTimKiem = new System.Windows.Forms.ComboBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.txtMaToa = new System.Windows.Forms.TextBox();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtGT = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtMSV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabQLDN = new System.Windows.Forms.TabPage();
            this.grpHoaDon = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grpTienNuoc = new System.Windows.Forms.GroupBox();
            this.dgvDienNuoc = new System.Windows.Forms.DataGridView();
            this.grpTienDien = new System.Windows.Forms.GroupBox();
            this.cboThangTD = new System.Windows.Forms.ComboBox();
            this.btnXoaTD = new System.Windows.Forms.Button();
            this.btnThemTD = new System.Windows.Forms.Button();
            this.txtTienDien = new System.Windows.Forms.TextBox();
            this.txtDienCuoiThang = new System.Windows.Forms.TextBox();
            this.txtDienDauThang = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMaPhongTD = new System.Windows.Forms.TextBox();
            this.dgvTienDien = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.tabQLSV.SuspendLayout();
            this.tbQLSV.SuspendLayout();
            this.panel2.SuspendLayout();
            this.grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.panel1.SuspendLayout();
            this.grpTTSV.SuspendLayout();
            this.grbTimKiem.SuspendLayout();
            this.tabQLDN.SuspendLayout();
            this.grpHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpTienNuoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDienNuoc)).BeginInit();
            this.grpTienDien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTienDien)).BeginInit();
            this.SuspendLayout();
            // 
            // tabQLSV
            // 
            this.tabQLSV.Controls.Add(this.tbQLSV);
            this.tabQLSV.Controls.Add(this.tabQLDN);
            this.tabQLSV.Location = new System.Drawing.Point(3, 2);
            this.tabQLSV.Name = "tabQLSV";
            this.tabQLSV.SelectedIndex = 0;
            this.tabQLSV.Size = new System.Drawing.Size(1395, 798);
            this.tabQLSV.TabIndex = 0;
            // 
            // tbQLSV
            // 
            this.tbQLSV.Controls.Add(this.panel2);
            this.tbQLSV.Controls.Add(this.panel1);
            this.tbQLSV.Controls.Add(this.label1);
            this.tbQLSV.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbQLSV.Location = new System.Drawing.Point(4, 25);
            this.tbQLSV.Name = "tbQLSV";
            this.tbQLSV.Padding = new System.Windows.Forms.Padding(3);
            this.tbQLSV.Size = new System.Drawing.Size(1387, 769);
            this.tbQLSV.TabIndex = 0;
            this.tbQLSV.Text = "Quản lý sinh viên";
            this.tbQLSV.UseVisualStyleBackColor = true;
            this.tbQLSV.Click += new System.EventHandler(this.tbQLSV_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.grpDanhSach);
            this.panel2.Location = new System.Drawing.Point(476, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(905, 688);
            this.panel2.TabIndex = 2;
            // 
            // grpDanhSach
            // 
            this.grpDanhSach.Controls.Add(this.dgvSinhVien);
            this.grpDanhSach.ForeColor = System.Drawing.Color.Blue;
            this.grpDanhSach.Location = new System.Drawing.Point(3, 3);
            this.grpDanhSach.Name = "grpDanhSach";
            this.grpDanhSach.Size = new System.Drawing.Size(899, 685);
            this.grpDanhSach.TabIndex = 0;
            this.grpDanhSach.TabStop = false;
            this.grpDanhSach.Text = "Danh Sách";
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVien.Location = new System.Drawing.Point(-3, 21);
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.RowHeadersWidth = 51;
            this.dgvSinhVien.RowTemplate.Height = 24;
            this.dgvSinhVien.Size = new System.Drawing.Size(905, 664);
            this.dgvSinhVien.TabIndex = 0;
            this.dgvSinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSinhVien_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grpTTSV);
            this.panel1.Location = new System.Drawing.Point(0, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 691);
            this.panel1.TabIndex = 1;
            // 
            // grpTTSV
            // 
            this.grpTTSV.Controls.Add(this.grbTimKiem);
            this.grpTTSV.Controls.Add(this.btnSua);
            this.grpTTSV.Controls.Add(this.btnXoa);
            this.grpTTSV.Controls.Add(this.txtSdt);
            this.grpTTSV.Controls.Add(this.txtMaToa);
            this.grpTTSV.Controls.Add(this.txtMaPhong);
            this.grpTTSV.Controls.Add(this.txtDiaChi);
            this.grpTTSV.Controls.Add(this.txtGT);
            this.grpTTSV.Controls.Add(this.dtpNgaySinh);
            this.grpTTSV.Controls.Add(this.txtCCCD);
            this.grpTTSV.Controls.Add(this.txtTen);
            this.grpTTSV.Controls.Add(this.txtMSV);
            this.grpTTSV.Controls.Add(this.label4);
            this.grpTTSV.Controls.Add(this.label11);
            this.grpTTSV.Controls.Add(this.label6);
            this.grpTTSV.Controls.Add(this.label7);
            this.grpTTSV.Controls.Add(this.label5);
            this.grpTTSV.Controls.Add(this.label16);
            this.grpTTSV.Controls.Add(this.label2);
            this.grpTTSV.Controls.Add(this.label3);
            this.grpTTSV.Controls.Add(this.label9);
            this.grpTTSV.Controls.Add(this.label12);
            this.grpTTSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTTSV.ForeColor = System.Drawing.Color.Blue;
            this.grpTTSV.Location = new System.Drawing.Point(0, 0);
            this.grpTTSV.Name = "grpTTSV";
            this.grpTTSV.Size = new System.Drawing.Size(470, 691);
            this.grpTTSV.TabIndex = 0;
            this.grpTTSV.TabStop = false;
            this.grpTTSV.Text = "Thông Tin Chi Tiết";
            // 
            // grbTimKiem
            // 
            this.grbTimKiem.Controls.Add(this.cboLoaiTimKiem);
            this.grbTimKiem.Controls.Add(this.txtTimKiem);
            this.grbTimKiem.Controls.Add(this.label8);
            this.grbTimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.grbTimKiem.Location = new System.Drawing.Point(4, 505);
            this.grbTimKiem.Name = "grbTimKiem";
            this.grbTimKiem.Size = new System.Drawing.Size(463, 193);
            this.grbTimKiem.TabIndex = 153;
            this.grbTimKiem.TabStop = false;
            this.grbTimKiem.Text = "Tìm Kiếm";
            // 
            // cboLoaiTimKiem
            // 
            this.cboLoaiTimKiem.FormattingEnabled = true;
            this.cboLoaiTimKiem.Items.AddRange(new object[] {
            "Tên",
            "Mã SV",
            "Phòng",
            "Tòa"});
            this.cboLoaiTimKiem.Location = new System.Drawing.Point(331, 35);
            this.cboLoaiTimKiem.Name = "cboLoaiTimKiem";
            this.cboLoaiTimKiem.Size = new System.Drawing.Size(76, 24);
            this.cboLoaiTimKiem.TabIndex = 151;
            this.cboLoaiTimKiem.SelectedIndexChanged += new System.EventHandler(this.cboLoaiTimKiem_SelectedIndexChanged);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(134, 31);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(192, 28);
            this.txtTimKiem.TabIndex = 150;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(5, 29);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 30);
            this.label8.TabIndex = 142;
            this.label8.Text = "Thông Tin";
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(206, 456);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(114, 43);
            this.btnSua.TabIndex = 152;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(58, 456);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(114, 43);
            this.btnXoa.TabIndex = 151;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtSdt
            // 
            this.txtSdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSdt.Location = new System.Drawing.Point(175, 325);
            this.txtSdt.Margin = new System.Windows.Forms.Padding(2);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(192, 28);
            this.txtSdt.TabIndex = 150;
            // 
            // txtMaToa
            // 
            this.txtMaToa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaToa.Location = new System.Drawing.Point(175, 415);
            this.txtMaToa.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaToa.Name = "txtMaToa";
            this.txtMaToa.Size = new System.Drawing.Size(192, 28);
            this.txtMaToa.TabIndex = 149;
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhong.Location = new System.Drawing.Point(175, 372);
            this.txtMaPhong.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(192, 28);
            this.txtMaPhong.TabIndex = 148;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(175, 278);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(192, 28);
            this.txtDiaChi.TabIndex = 147;
            // 
            // txtGT
            // 
            this.txtGT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGT.Location = new System.Drawing.Point(175, 183);
            this.txtGT.Margin = new System.Windows.Forms.Padding(2);
            this.txtGT.Name = "txtGT";
            this.txtGT.Size = new System.Drawing.Size(192, 28);
            this.txtGT.TabIndex = 146;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(177, 131);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(176, 28);
            this.dtpNgaySinh.TabIndex = 145;
            // 
            // txtCCCD
            // 
            this.txtCCCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCCCD.Location = new System.Drawing.Point(175, 230);
            this.txtCCCD.Margin = new System.Windows.Forms.Padding(2);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(192, 28);
            this.txtCCCD.TabIndex = 144;
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(179, 84);
            this.txtTen.Margin = new System.Windows.Forms.Padding(2);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(188, 28);
            this.txtTen.TabIndex = 143;
            // 
            // txtMSV
            // 
            this.txtMSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMSV.Location = new System.Drawing.Point(179, 35);
            this.txtMSV.Margin = new System.Windows.Forms.Padding(2);
            this.txtMSV.Name = "txtMSV";
            this.txtMSV.Size = new System.Drawing.Size(188, 28);
            this.txtMSV.TabIndex = 142;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(2, 413);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 30);
            this.label4.TabIndex = 141;
            this.label4.Text = "Mã Tòa";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(2, 370);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 36);
            this.label11.TabIndex = 140;
            this.label11.Text = "Mã Phòng";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(2, 325);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 31);
            this.label6.TabIndex = 138;
            this.label6.Text = "SĐT";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(2, 276);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 29);
            this.label7.TabIndex = 139;
            this.label7.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(11, 443);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 30);
            this.label5.TabIndex = 137;
            this.label5.Text = " ";
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(2, 230);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(108, 28);
            this.label16.TabIndex = 135;
            this.label16.Text = "CCCD";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(2, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 24);
            this.label2.TabIndex = 131;
            this.label2.Text = "Mã Sinh Viên";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(2, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 28);
            this.label3.TabIndex = 132;
            this.label3.Text = "Họ Tên";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(2, 181);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 28);
            this.label9.TabIndex = 133;
            this.label9.Text = "Giới Tính";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(2, 129);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(170, 30);
            this.label12.TabIndex = 134;
            this.label12.Text = "Ngày Sinh";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1378, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông Tin Sinh Viên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabQLDN
            // 
            this.tabQLDN.Controls.Add(this.grpHoaDon);
            this.tabQLDN.Controls.Add(this.grpTienNuoc);
            this.tabQLDN.Controls.Add(this.grpTienDien);
            this.tabQLDN.Controls.Add(this.label10);
            this.tabQLDN.Location = new System.Drawing.Point(4, 25);
            this.tabQLDN.Name = "tabQLDN";
            this.tabQLDN.Padding = new System.Windows.Forms.Padding(3);
            this.tabQLDN.Size = new System.Drawing.Size(1387, 769);
            this.tabQLDN.TabIndex = 1;
            this.tabQLDN.Text = "Quản Lý Điện Nước";
            this.tabQLDN.UseVisualStyleBackColor = true;
            // 
            // grpHoaDon
            // 
            this.grpHoaDon.Controls.Add(this.dataGridView1);
            this.grpHoaDon.Location = new System.Drawing.Point(10, 403);
            this.grpHoaDon.Name = "grpHoaDon";
            this.grpHoaDon.Size = new System.Drawing.Size(1371, 363);
            this.grpHoaDon.TabIndex = 4;
            this.grpHoaDon.TabStop = false;
            this.grpHoaDon.Text = "Hóa Đơn";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(923, 336);
            this.dataGridView1.TabIndex = 1;
            // 
            // grpTienNuoc
            // 
            this.grpTienNuoc.Controls.Add(this.dgvDienNuoc);
            this.grpTienNuoc.Location = new System.Drawing.Point(685, 75);
            this.grpTienNuoc.Name = "grpTienNuoc";
            this.grpTienNuoc.Size = new System.Drawing.Size(696, 322);
            this.grpTienNuoc.TabIndex = 3;
            this.grpTienNuoc.TabStop = false;
            this.grpTienNuoc.Text = "Tiền Nước";
            // 
            // dgvDienNuoc
            // 
            this.dgvDienNuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDienNuoc.Location = new System.Drawing.Point(6, 21);
            this.dgvDienNuoc.Name = "dgvDienNuoc";
            this.dgvDienNuoc.RowHeadersWidth = 51;
            this.dgvDienNuoc.RowTemplate.Height = 24;
            this.dgvDienNuoc.Size = new System.Drawing.Size(402, 295);
            this.dgvDienNuoc.TabIndex = 1;
            // 
            // grpTienDien
            // 
            this.grpTienDien.Controls.Add(this.cboThangTD);
            this.grpTienDien.Controls.Add(this.btnXoaTD);
            this.grpTienDien.Controls.Add(this.btnThemTD);
            this.grpTienDien.Controls.Add(this.txtTienDien);
            this.grpTienDien.Controls.Add(this.txtDienCuoiThang);
            this.grpTienDien.Controls.Add(this.txtDienDauThang);
            this.grpTienDien.Controls.Add(this.label18);
            this.grpTienDien.Controls.Add(this.label17);
            this.grpTienDien.Controls.Add(this.label15);
            this.grpTienDien.Controls.Add(this.label14);
            this.grpTienDien.Controls.Add(this.label13);
            this.grpTienDien.Controls.Add(this.txtMaPhongTD);
            this.grpTienDien.Controls.Add(this.dgvTienDien);
            this.grpTienDien.Location = new System.Drawing.Point(3, 75);
            this.grpTienDien.Name = "grpTienDien";
            this.grpTienDien.Size = new System.Drawing.Size(676, 322);
            this.grpTienDien.TabIndex = 2;
            this.grpTienDien.TabStop = false;
            this.grpTienDien.Text = "Tiền Điện";
            // 
            // cboThangTD
            // 
            this.cboThangTD.FormattingEnabled = true;
            this.cboThangTD.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cboThangTD.Location = new System.Drawing.Point(576, 87);
            this.cboThangTD.Name = "cboThangTD";
            this.cboThangTD.Size = new System.Drawing.Size(100, 24);
            this.cboThangTD.TabIndex = 14;
            // 
            // btnXoaTD
            // 
            this.btnXoaTD.Location = new System.Drawing.Point(548, 271);
            this.btnXoaTD.Name = "btnXoaTD";
            this.btnXoaTD.Size = new System.Drawing.Size(75, 23);
            this.btnXoaTD.TabIndex = 12;
            this.btnXoaTD.Text = "Xóa";
            this.btnXoaTD.UseVisualStyleBackColor = true;
            this.btnXoaTD.Click += new System.EventHandler(this.btnXoaTD_Click);
            // 
            // btnThemTD
            // 
            this.btnThemTD.Location = new System.Drawing.Point(447, 271);
            this.btnThemTD.Name = "btnThemTD";
            this.btnThemTD.Size = new System.Drawing.Size(75, 23);
            this.btnThemTD.TabIndex = 11;
            this.btnThemTD.Text = "Thêm";
            this.btnThemTD.UseVisualStyleBackColor = true;
            this.btnThemTD.Click += new System.EventHandler(this.btnThemTD_Click);
            // 
            // txtTienDien
            // 
            this.txtTienDien.Location = new System.Drawing.Point(576, 211);
            this.txtTienDien.Name = "txtTienDien";
            this.txtTienDien.ReadOnly = true;
            this.txtTienDien.Size = new System.Drawing.Size(100, 22);
            this.txtTienDien.TabIndex = 10;
            // 
            // txtDienCuoiThang
            // 
            this.txtDienCuoiThang.Location = new System.Drawing.Point(576, 172);
            this.txtDienCuoiThang.Name = "txtDienCuoiThang";
            this.txtDienCuoiThang.Size = new System.Drawing.Size(100, 22);
            this.txtDienCuoiThang.TabIndex = 9;
            // 
            // txtDienDauThang
            // 
            this.txtDienDauThang.Location = new System.Drawing.Point(576, 130);
            this.txtDienDauThang.Name = "txtDienDauThang";
            this.txtDienDauThang.Size = new System.Drawing.Size(100, 22);
            this.txtDienDauThang.TabIndex = 8;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(431, 211);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(63, 16);
            this.label18.TabIndex = 6;
            this.label18.Text = "Tiền điện";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(430, 172);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(117, 16);
            this.label17.TabIndex = 5;
            this.label17.Text = "Số điện cuối tháng";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(430, 130);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(118, 16);
            this.label15.TabIndex = 4;
            this.label15.Text = "Số  điện đầu tháng";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(430, 87);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 16);
            this.label14.TabIndex = 3;
            this.label14.Text = "Tháng";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(430, 49);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 16);
            this.label13.TabIndex = 2;
            this.label13.Text = "Mã Phòng";
            // 
            // txtMaPhongTD
            // 
            this.txtMaPhongTD.Location = new System.Drawing.Point(576, 46);
            this.txtMaPhongTD.Name = "txtMaPhongTD";
            this.txtMaPhongTD.Size = new System.Drawing.Size(100, 22);
            this.txtMaPhongTD.TabIndex = 1;
            // 
            // dgvTienDien
            // 
            this.dgvTienDien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTienDien.Location = new System.Drawing.Point(7, 21);
            this.dgvTienDien.Name = "dgvTienDien";
            this.dgvTienDien.RowHeadersWidth = 51;
            this.dgvTienDien.RowTemplate.Height = 24;
            this.dgvTienDien.Size = new System.Drawing.Size(402, 295);
            this.dgvTienDien.TabIndex = 0;
            this.dgvTienDien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTienDien_CellClick);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Yellow;
            this.label10.Location = new System.Drawing.Point(3, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(1388, 69);
            this.label10.TabIndex = 1;
            this.label10.Text = "Quản lý điện nước";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1400, 802);
            this.Controls.Add(this.tabQLSV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "fQuanLy";
            this.Text = "Quản Lý";
            this.Load += new System.EventHandler(this.fQuanLy_Load);
            this.tabQLSV.ResumeLayout(false);
            this.tbQLSV.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.grpDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.panel1.ResumeLayout(false);
            this.grpTTSV.ResumeLayout(false);
            this.grpTTSV.PerformLayout();
            this.grbTimKiem.ResumeLayout(false);
            this.grbTimKiem.PerformLayout();
            this.tabQLDN.ResumeLayout(false);
            this.grpHoaDon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpTienNuoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDienNuoc)).EndInit();
            this.grpTienDien.ResumeLayout(false);
            this.grpTienDien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTienDien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabQLSV;
        private System.Windows.Forms.TabPage tbQLSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabQLDN;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpTTSV;
        private System.Windows.Forms.GroupBox grpDanhSach;
        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.TextBox txtMaToa;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtGT;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtMSV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox grbTimKiem;
        private System.Windows.Forms.ComboBox cboLoaiTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox grpHoaDon;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grpTienNuoc;
        private System.Windows.Forms.DataGridView dgvDienNuoc;
        private System.Windows.Forms.GroupBox grpTienDien;
        private System.Windows.Forms.DataGridView dgvTienDien;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTienDien;
        private System.Windows.Forms.TextBox txtDienCuoiThang;
        private System.Windows.Forms.TextBox txtDienDauThang;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtMaPhongTD;
        private System.Windows.Forms.ComboBox cboThangTD;
        private System.Windows.Forms.Button btnXoaTD;
        private System.Windows.Forms.Button btnThemTD;
    }
}