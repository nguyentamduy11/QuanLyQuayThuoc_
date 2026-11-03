using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyQuanThuoc.Models
{
    partial class FormHoaDon
    {
        private System.ComponentModel.IContainer? components = null;
        private Panel pnlTieuDe;
        private Label lblTieuDe;
        private Panel pnlThongTin;
        private Label lblMaHoaDon, lblNgayLap, lblKhachHang, lblSoDienThoai, lblNhanVien, lblGhiChu;
        private TextBox txtMaHoaDon, txtKhachHang, txtSoDienThoai, txtGhiChu;
        private DateTimePicker dtpNgayLap;
        private ComboBox cboNhanVien;
        private Button btnThem, btnSua, btnXoa, btnLamMoi;
        private Panel pnlNhapChiTiet;
        private Label lblNhapChiTiet, lblThuoc, lblSoLuong, lblDonGia;
        private ComboBox cboThuoc;
        private NumericUpDown nudSoLuong;
        private TextBox txtDonGia;
        private Button btnThemDong, btnXoaDong;
        private Panel pnlChiTiet;
        private DataGridView dgvChiTiet;
        private DataGridViewTextBoxColumn colCTMaThuoc, colCTTenThuoc, colCTDonVi, colCTSoLuong, colCTDonGia, colCTThanhTien;
        private Panel pnlTongTien;
        private Label lblTongTien, lblChuThich;
        private Panel pnlTimKiem;
        private Label lblTimKiem, lblSoHoaDon;
        private TextBox txtTimKiem;
        private Button btnTimKiem;
        private DataGridView dgvHoaDon;
        private DataGridViewTextBoxColumn colMaHD, colNgayLap, colKhachHang, colSDT, colNhanVien, colTongTien;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            pnlTieuDe = new Panel();
            lblTieuDe = new Label();
            pnlThongTin = new Panel();
            btnThanhToan = new Button();
            lblMaHoaDon = new Label();
            txtMaHoaDon = new TextBox();
            lblNgayLap = new Label();
            dtpNgayLap = new DateTimePicker();
            lblKhachHang = new Label();
            txtKhachHang = new TextBox();
            lblSoDienThoai = new Label();
            txtSoDienThoai = new TextBox();
            lblNhanVien = new Label();
            cboNhanVien = new ComboBox();
            lblGhiChu = new Label();
            txtGhiChu = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            pnlNhapChiTiet = new Panel();
            lblNhapChiTiet = new Label();
            lblThuoc = new Label();
            cboThuoc = new ComboBox();
            lblSoLuong = new Label();
            nudSoLuong = new NumericUpDown();
            lblDonGia = new Label();
            txtDonGia = new TextBox();
            btnThemDong = new Button();
            btnXoaDong = new Button();
            pnlChiTiet = new Panel();
            dgvChiTiet = new DataGridView();
            colCTMaThuoc = new DataGridViewTextBoxColumn();
            colCTTenThuoc = new DataGridViewTextBoxColumn();
            colCTDonVi = new DataGridViewTextBoxColumn();
            colCTSoLuong = new DataGridViewTextBoxColumn();
            colCTDonGia = new DataGridViewTextBoxColumn();
            colCTThanhTien = new DataGridViewTextBoxColumn();
            pnlTongTien = new Panel();
            lblChuThich = new Label();
            lblTongTien = new Label();
            pnlTimKiem = new Panel();
            lblTimKiem = new Label();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            lblSoHoaDon = new Label();
            dgvHoaDon = new DataGridView();
            colMaHD = new DataGridViewTextBoxColumn();
            colNgayLap = new DataGridViewTextBoxColumn();
            colKhachHang = new DataGridViewTextBoxColumn();
            colSDT = new DataGridViewTextBoxColumn();
            colNhanVien = new DataGridViewTextBoxColumn();
            colTongTien = new DataGridViewTextBoxColumn();
            pnlTieuDe.SuspendLayout();
            pnlThongTin.SuspendLayout();
            pnlNhapChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoLuong).BeginInit();
            pnlChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).BeginInit();
            pnlTongTien.SuspendLayout();
            pnlTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).BeginInit();
            SuspendLayout();
            // 
            // pnlTieuDe
            // 
            pnlTieuDe.BackColor = Color.FromArgb(37, 99, 235);
            pnlTieuDe.Controls.Add(lblTieuDe);
            pnlTieuDe.Dock = DockStyle.Top;
            pnlTieuDe.Location = new Point(0, 0);
            pnlTieuDe.Name = "pnlTieuDe";
            pnlTieuDe.Size = new Size(1145, 54);
            pnlTieuDe.TabIndex = 6;
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.White;
            lblTieuDe.Location = new Point(18, 10);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(218, 30);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "QUẢN LÝ HÓA ĐƠN";
            // 
            // pnlThongTin
            // 
            pnlThongTin.BackColor = Color.White;
            pnlThongTin.Controls.Add(btnThanhToan);
            pnlThongTin.Controls.Add(lblMaHoaDon);
            pnlThongTin.Controls.Add(txtMaHoaDon);
            pnlThongTin.Controls.Add(lblNgayLap);
            pnlThongTin.Controls.Add(dtpNgayLap);
            pnlThongTin.Controls.Add(lblKhachHang);
            pnlThongTin.Controls.Add(txtKhachHang);
            pnlThongTin.Controls.Add(lblSoDienThoai);
            pnlThongTin.Controls.Add(txtSoDienThoai);
            pnlThongTin.Controls.Add(lblNhanVien);
            pnlThongTin.Controls.Add(cboNhanVien);
            pnlThongTin.Controls.Add(lblGhiChu);
            pnlThongTin.Controls.Add(txtGhiChu);
            pnlThongTin.Controls.Add(btnThem);
            pnlThongTin.Controls.Add(btnSua);
            pnlThongTin.Controls.Add(btnXoa);
            pnlThongTin.Controls.Add(btnLamMoi);
            pnlThongTin.Dock = DockStyle.Top;
            pnlThongTin.Location = new Point(0, 54);
            pnlThongTin.Name = "pnlThongTin";
            pnlThongTin.Size = new Size(1145, 168);
            pnlThongTin.TabIndex = 5;
            // 
            // btnThanhToan
            // 
            btnThanhToan.BackColor = Color.FromArgb(0, 192, 0);
            btnThanhToan.Cursor = Cursors.Hand;
            btnThanhToan.FlatAppearance.BorderSize = 0;
            btnThanhToan.FlatStyle = FlatStyle.Flat;
            btnThanhToan.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnThanhToan.ForeColor = Color.White;
            btnThanhToan.Location = new Point(461, 132);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(145, 33);
            btnThanhToan.TabIndex = 16;
            btnThanhToan.Text = "Thanh Toán";
            btnThanhToan.UseVisualStyleBackColor = false;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // lblMaHoaDon
            // 
            lblMaHoaDon.AutoSize = true;
            lblMaHoaDon.Location = new Point(18, 10);
            lblMaHoaDon.Name = "lblMaHoaDon";
            lblMaHoaDon.Size = new Size(84, 19);
            lblMaHoaDon.TabIndex = 0;
            lblMaHoaDon.Text = "Mã hóa đơn";
            // 
            // txtMaHoaDon
            // 
            txtMaHoaDon.Location = new Point(18, 32);
            txtMaHoaDon.Name = "txtMaHoaDon";
            txtMaHoaDon.Size = new Size(145, 25);
            txtMaHoaDon.TabIndex = 1;
            // 
            // lblNgayLap
            // 
            lblNgayLap.AutoSize = true;
            lblNgayLap.Location = new Point(184, 10);
            lblNgayLap.Name = "lblNgayLap";
            lblNgayLap.Size = new Size(63, 19);
            lblNgayLap.TabIndex = 2;
            lblNgayLap.Text = "Ngày lập";
            // 
            // dtpNgayLap
            // 
            dtpNgayLap.CustomFormat = "dd/MM/yyyy";
            dtpNgayLap.Format = DateTimePickerFormat.Custom;
            dtpNgayLap.Location = new Point(184, 32);
            dtpNgayLap.Name = "dtpNgayLap";
            dtpNgayLap.Size = new Size(144, 25);
            dtpNgayLap.TabIndex = 3;
            // 
            // lblKhachHang
            // 
            lblKhachHang.AutoSize = true;
            lblKhachHang.Location = new Point(347, 10);
            lblKhachHang.Name = "lblKhachHang";
            lblKhachHang.Size = new Size(105, 19);
            lblKhachHang.TabIndex = 4;
            lblKhachHang.Text = "Tên khách hàng";
            // 
            // txtKhachHang
            // 
            txtKhachHang.Location = new Point(347, 32);
            txtKhachHang.Name = "txtKhachHang";
            txtKhachHang.Size = new Size(230, 25);
            txtKhachHang.TabIndex = 5;
            // 
            // lblSoDienThoai
            // 
            lblSoDienThoai.AutoSize = true;
            lblSoDienThoai.Location = new Point(595, 10);
            lblSoDienThoai.Name = "lblSoDienThoai";
            lblSoDienThoai.Size = new Size(89, 19);
            lblSoDienThoai.TabIndex = 6;
            lblSoDienThoai.Text = "Số điện thoại";
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(595, 32);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(144, 25);
            txtSoDienThoai.TabIndex = 7;
            // 
            // lblNhanVien
            // 
            lblNhanVien.AutoSize = true;
            lblNhanVien.Location = new Point(757, 10);
            lblNhanVien.Name = "lblNhanVien";
            lblNhanVien.Size = new Size(98, 19);
            lblNhanVien.TabIndex = 8;
            lblNhanVien.Text = "Nhân viên bán";
            // 
            // cboNhanVien
            // 
            cboNhanVien.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNhanVien.Location = new Point(757, 32);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(250, 25);
            cboNhanVien.TabIndex = 9;
            // 
            // lblGhiChu
            // 
            lblGhiChu.AutoSize = true;
            lblGhiChu.Location = new Point(18, 72);
            lblGhiChu.Name = "lblGhiChu";
            lblGhiChu.Size = new Size(56, 19);
            lblGhiChu.TabIndex = 10;
            lblGhiChu.Text = "Ghi chú";
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(18, 95);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.PlaceholderText = "Ghi chú (không bắt buộc)";
            txtGhiChu.Size = new Size(710, 25);
            txtGhiChu.TabIndex = 11;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(22, 163, 74);
            btnThem.Cursor = Cursors.Hand;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(18, 132);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(90, 32);
            btnThem.TabIndex = 12;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(234, 88, 12);
            btnSua.Cursor = Cursors.Hand;
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(127, 132);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(90, 32);
            btnSua.TabIndex = 13;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(220, 38, 38);
            btnXoa.Cursor = Cursors.Hand;
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(236, 132);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(90, 32);
            btnXoa.TabIndex = 14;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.FromArgb(37, 99, 235);
            btnLamMoi.Cursor = Cursors.Hand;
            btnLamMoi.FlatAppearance.BorderSize = 0;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(339, 132);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(110, 32);
            btnLamMoi.TabIndex = 15;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // pnlNhapChiTiet
            // 
            pnlNhapChiTiet.BackColor = Color.FromArgb(239, 246, 255);
            pnlNhapChiTiet.Controls.Add(lblNhapChiTiet);
            pnlNhapChiTiet.Controls.Add(lblThuoc);
            pnlNhapChiTiet.Controls.Add(cboThuoc);
            pnlNhapChiTiet.Controls.Add(lblSoLuong);
            pnlNhapChiTiet.Controls.Add(nudSoLuong);
            pnlNhapChiTiet.Controls.Add(lblDonGia);
            pnlNhapChiTiet.Controls.Add(txtDonGia);
            pnlNhapChiTiet.Controls.Add(btnThemDong);
            pnlNhapChiTiet.Controls.Add(btnXoaDong);
            pnlNhapChiTiet.Dock = DockStyle.Top;
            pnlNhapChiTiet.Location = new Point(0, 222);
            pnlNhapChiTiet.Name = "pnlNhapChiTiet";
            pnlNhapChiTiet.Size = new Size(1145, 90);
            pnlNhapChiTiet.TabIndex = 4;
            // 
            // lblNhapChiTiet
            // 
            lblNhapChiTiet.AutoSize = true;
            lblNhapChiTiet.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNhapChiTiet.ForeColor = Color.FromArgb(30, 64, 175);
            lblNhapChiTiet.Location = new Point(18, 4);
            lblNhapChiTiet.Name = "lblNhapChiTiet";
            lblNhapChiTiet.Size = new Size(242, 19);
            lblNhapChiTiet.TabIndex = 0;
            lblNhapChiTiet.Text = "CHI TIẾT THUỐC TRONG HÓA ĐƠN";
            // 
            // lblThuoc
            // 
            lblThuoc.AutoSize = true;
            lblThuoc.Location = new Point(18, 28);
            lblThuoc.Name = "lblThuoc";
            lblThuoc.Size = new Size(46, 19);
            lblThuoc.TabIndex = 1;
            lblThuoc.Text = "Thuốc";
            // 
            // cboThuoc
            // 
            cboThuoc.DropDownStyle = ComboBoxStyle.DropDownList;
            cboThuoc.Location = new Point(18, 51);
            cboThuoc.Name = "cboThuoc";
            cboThuoc.Size = new Size(295, 25);
            cboThuoc.TabIndex = 2;
            cboThuoc.SelectedIndexChanged += cboThuoc_SelectedIndexChanged;
            // 
            // lblSoLuong
            // 
            lblSoLuong.AutoSize = true;
            lblSoLuong.Location = new Point(330, 28);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(63, 19);
            lblSoLuong.TabIndex = 3;
            lblSoLuong.Text = "Số lượng";
            // 
            // nudSoLuong
            // 
            nudSoLuong.Location = new Point(330, 51);
            nudSoLuong.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudSoLuong.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudSoLuong.Name = "nudSoLuong";
            nudSoLuong.Size = new Size(100, 25);
            nudSoLuong.TabIndex = 4;
            nudSoLuong.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblDonGia
            // 
            lblDonGia.AutoSize = true;
            lblDonGia.Location = new Point(446, 28);
            lblDonGia.Name = "lblDonGia";
            lblDonGia.Size = new Size(77, 19);
            lblDonGia.TabIndex = 5;
            lblDonGia.Text = "Đơn giá (đ)";
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(446, 51);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.ReadOnly = true;
            txtDonGia.Size = new Size(160, 25);
            txtDonGia.TabIndex = 6;
            // 
            // btnThemDong
            // 
            btnThemDong.BackColor = Color.FromArgb(22, 163, 74);
            btnThemDong.Cursor = Cursors.Hand;
            btnThemDong.FlatAppearance.BorderSize = 0;
            btnThemDong.FlatStyle = FlatStyle.Flat;
            btnThemDong.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnThemDong.ForeColor = Color.White;
            btnThemDong.Location = new Point(628, 49);
            btnThemDong.Name = "btnThemDong";
            btnThemDong.Size = new Size(136, 32);
            btnThemDong.TabIndex = 7;
            btnThemDong.Text = "+ Thêm thuốc";
            btnThemDong.UseVisualStyleBackColor = false;
            btnThemDong.Click += btnThemDong_Click;
            // 
            // btnXoaDong
            // 
            btnXoaDong.BackColor = Color.FromArgb(220, 38, 38);
            btnXoaDong.Cursor = Cursors.Hand;
            btnXoaDong.FlatAppearance.BorderSize = 0;
            btnXoaDong.FlatStyle = FlatStyle.Flat;
            btnXoaDong.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnXoaDong.ForeColor = Color.White;
            btnXoaDong.Location = new Point(778, 49);
            btnXoaDong.Name = "btnXoaDong";
            btnXoaDong.Size = new Size(122, 32);
            btnXoaDong.TabIndex = 8;
            btnXoaDong.Text = "Xóa dòng";
            btnXoaDong.UseVisualStyleBackColor = false;
            btnXoaDong.Click += btnXoaDong_Click;
            // 
            // pnlChiTiet
            // 
            pnlChiTiet.Controls.Add(dgvChiTiet);
            pnlChiTiet.Dock = DockStyle.Top;
            pnlChiTiet.Location = new Point(0, 312);
            pnlChiTiet.Name = "pnlChiTiet";
            pnlChiTiet.Size = new Size(1145, 151);
            pnlChiTiet.TabIndex = 3;
            // 
            // dgvChiTiet
            // 
            dgvChiTiet.AllowUserToAddRows = false;
            dgvChiTiet.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 250, 252);
            dgvChiTiet.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvChiTiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChiTiet.BackgroundColor = Color.White;
            dgvChiTiet.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(37, 99, 235);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(37, 99, 235);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvChiTiet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvChiTiet.ColumnHeadersHeight = 36;
            dgvChiTiet.Columns.AddRange(new DataGridViewColumn[] { colCTMaThuoc, colCTTenThuoc, colCTDonVi, colCTSoLuong, colCTDonGia, colCTThanhTien });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(31, 41, 55);
            dataGridViewCellStyle3.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvChiTiet.DefaultCellStyle = dataGridViewCellStyle3;
            dgvChiTiet.Dock = DockStyle.Fill;
            dgvChiTiet.EnableHeadersVisualStyles = false;
            dgvChiTiet.Location = new Point(0, 0);
            dgvChiTiet.MultiSelect = false;
            dgvChiTiet.Name = "dgvChiTiet";
            dgvChiTiet.ReadOnly = true;
            dgvChiTiet.RowHeadersVisible = false;
            dgvChiTiet.RowTemplate.Height = 31;
            dgvChiTiet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvChiTiet.Size = new Size(1145, 151);
            dgvChiTiet.TabIndex = 0;
            // 
            // colCTMaThuoc
            // 
            colCTMaThuoc.FillWeight = 21F;
            colCTMaThuoc.HeaderText = "Mã thuốc";
            colCTMaThuoc.Name = "colCTMaThuoc";
            colCTMaThuoc.ReadOnly = true;
            // 
            // colCTTenThuoc
            // 
            colCTTenThuoc.FillWeight = 36F;
            colCTTenThuoc.HeaderText = "Tên thuốc";
            colCTTenThuoc.Name = "colCTTenThuoc";
            colCTTenThuoc.ReadOnly = true;
            // 
            // colCTDonVi
            // 
            colCTDonVi.FillWeight = 18F;
            colCTDonVi.HeaderText = "Đơn vị";
            colCTDonVi.Name = "colCTDonVi";
            colCTDonVi.ReadOnly = true;
            // 
            // colCTSoLuong
            // 
            colCTSoLuong.FillWeight = 18F;
            colCTSoLuong.HeaderText = "Số lượng";
            colCTSoLuong.Name = "colCTSoLuong";
            colCTSoLuong.ReadOnly = true;
            // 
            // colCTDonGia
            // 
            colCTDonGia.FillWeight = 22F;
            colCTDonGia.HeaderText = "Đơn giá (đ)";
            colCTDonGia.Name = "colCTDonGia";
            colCTDonGia.ReadOnly = true;
            // 
            // colCTThanhTien
            // 
            colCTThanhTien.FillWeight = 26F;
            colCTThanhTien.HeaderText = "Thành tiền (đ)";
            colCTThanhTien.Name = "colCTThanhTien";
            colCTThanhTien.ReadOnly = true;
            // 
            // pnlTongTien
            // 
            pnlTongTien.BackColor = Color.White;
            pnlTongTien.Controls.Add(lblChuThich);
            pnlTongTien.Controls.Add(lblTongTien);
            pnlTongTien.Dock = DockStyle.Top;
            pnlTongTien.Location = new Point(0, 463);
            pnlTongTien.Name = "pnlTongTien";
            pnlTongTien.Size = new Size(1145, 42);
            pnlTongTien.TabIndex = 2;
            // 
            // lblChuThich
            // 
            lblChuThich.AutoSize = true;
            lblChuThich.ForeColor = Color.FromArgb(100, 116, 139);
            lblChuThich.Location = new Point(18, 11);
            lblChuThich.Name = "lblChuThich";
            lblChuThich.Size = new Size(377, 19);
            lblChuThich.TabIndex = 0;
            lblChuThich.Text = "Hóa đơn được lưu riêng; chưa tự động trừ số lượng tồn kho.";
            // 
            // lblTongTien
            // 
            lblTongTien.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTongTien.AutoSize = true;
            lblTongTien.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTongTien.ForeColor = Color.FromArgb(30, 64, 175);
            lblTongTien.Location = new Point(1735, 6);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(130, 25);
            lblTongTien.TabIndex = 1;
            lblTongTien.Text = "Tổng tiền: 0 đ";
            // 
            // pnlTimKiem
            // 
            pnlTimKiem.BackColor = Color.FromArgb(245, 247, 250);
            pnlTimKiem.Controls.Add(lblTimKiem);
            pnlTimKiem.Controls.Add(txtTimKiem);
            pnlTimKiem.Controls.Add(btnTimKiem);
            pnlTimKiem.Controls.Add(lblSoHoaDon);
            pnlTimKiem.Dock = DockStyle.Top;
            pnlTimKiem.Location = new Point(0, 505);
            pnlTimKiem.Name = "pnlTimKiem";
            pnlTimKiem.Size = new Size(1145, 57);
            pnlTimKiem.TabIndex = 1;
            // 
            // lblTimKiem
            // 
            lblTimKiem.AutoSize = true;
            lblTimKiem.Location = new Point(18, 18);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Size = new Size(89, 19);
            lblTimKiem.TabIndex = 0;
            lblTimKiem.Text = "Tìm hóa đơn:";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(135, 13);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Mã HĐ, khách hàng, nhân viên...";
            txtTimKiem.Size = new Size(294, 25);
            txtTimKiem.TabIndex = 1;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.FromArgb(37, 99, 235);
            btnTimKiem.Cursor = Cursors.Hand;
            btnTimKiem.FlatAppearance.BorderSize = 0;
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnTimKiem.ForeColor = Color.White;
            btnTimKiem.Location = new Point(443, 12);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(105, 32);
            btnTimKiem.TabIndex = 2;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // lblSoHoaDon
            // 
            lblSoHoaDon.AutoSize = true;
            lblSoHoaDon.Location = new Point(576, 20);
            lblSoHoaDon.Name = "lblSoHoaDon";
            lblSoHoaDon.Size = new Size(127, 19);
            lblSoHoaDon.TabIndex = 3;
            lblSoHoaDon.Text = "Hiển thị: 0 hóa đơn";
            // 
            // dgvHoaDon
            // 
            dgvHoaDon.AllowUserToAddRows = false;
            dgvHoaDon.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(248, 250, 252);
            dgvHoaDon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHoaDon.BackgroundColor = Color.White;
            dgvHoaDon.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(37, 99, 235);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(37, 99, 235);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvHoaDon.ColumnHeadersHeight = 36;
            dgvHoaDon.Columns.AddRange(new DataGridViewColumn[] { colMaHD, colNgayLap, colKhachHang, colSDT, colNhanVien, colTongTien });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(31, 41, 55);
            dataGridViewCellStyle6.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvHoaDon.DefaultCellStyle = dataGridViewCellStyle6;
            dgvHoaDon.Dock = DockStyle.Fill;
            dgvHoaDon.EnableHeadersVisualStyles = false;
            dgvHoaDon.Location = new Point(0, 562);
            dgvHoaDon.MultiSelect = false;
            dgvHoaDon.Name = "dgvHoaDon";
            dgvHoaDon.ReadOnly = true;
            dgvHoaDon.RowHeadersVisible = false;
            dgvHoaDon.RowTemplate.Height = 31;
            dgvHoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHoaDon.Size = new Size(1145, 260);
            dgvHoaDon.TabIndex = 0;
            dgvHoaDon.CellClick += dgvHoaDon_CellClick;
            // 
            // colMaHD
            // 
            colMaHD.FillWeight = 22F;
            colMaHD.HeaderText = "Mã hóa đơn";
            colMaHD.Name = "colMaHD";
            colMaHD.ReadOnly = true;
            // 
            // colNgayLap
            // 
            colNgayLap.FillWeight = 20F;
            colNgayLap.HeaderText = "Ngày lập";
            colNgayLap.Name = "colNgayLap";
            colNgayLap.ReadOnly = true;
            // 
            // colKhachHang
            // 
            colKhachHang.FillWeight = 32F;
            colKhachHang.HeaderText = "Khách hàng";
            colKhachHang.Name = "colKhachHang";
            colKhachHang.ReadOnly = true;
            // 
            // colSDT
            // 
            colSDT.FillWeight = 22F;
            colSDT.HeaderText = "Điện thoại";
            colSDT.Name = "colSDT";
            colSDT.ReadOnly = true;
            // 
            // colNhanVien
            // 
            colNhanVien.FillWeight = 30F;
            colNhanVien.HeaderText = "Nhân viên";
            colNhanVien.Name = "colNhanVien";
            colNhanVien.ReadOnly = true;
            // 
            // colTongTien
            // 
            colTongTien.FillWeight = 28F;
            colTongTien.HeaderText = "Tổng tiền (đ)";
            colTongTien.Name = "colTongTien";
            colTongTien.ReadOnly = true;
            // 
            // FormHoaDon
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1145, 822);
            Controls.Add(dgvHoaDon);
            Controls.Add(pnlTimKiem);
            Controls.Add(pnlTongTien);
            Controls.Add(pnlChiTiet);
            Controls.Add(pnlNhapChiTiet);
            Controls.Add(pnlThongTin);
            Controls.Add(pnlTieuDe);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.FromArgb(31, 41, 55);
            Name = "FormHoaDon";
            Text = "Quản lý hóa đơn";
            pnlTieuDe.ResumeLayout(false);
            pnlTieuDe.PerformLayout();
            pnlThongTin.ResumeLayout(false);
            pnlThongTin.PerformLayout();
            pnlNhapChiTiet.ResumeLayout(false);
            pnlNhapChiTiet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoLuong).EndInit();
            pnlChiTiet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).EndInit();
            pnlTongTien.ResumeLayout(false);
            pnlTongTien.PerformLayout();
            pnlTimKiem.ResumeLayout(false);
            pnlTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).EndInit();
            ResumeLayout(false);
        }

        private Button btnThanhToan;
    }
}
