using System.Drawing;
using System.Windows.Forms;

namespace QuanLyQuanThuoc.Models
{
    partial class FormQuanLyNhanVien
    {
        private System.ComponentModel.IContainer? components = null;
        private Panel pnlTieuDe;
        private Label lblTieuDe;
        private Panel pnlNhapLieu;
        private Label lblMaNhanVien;
        private TextBox txtMaNhanVien;
        private Label lblHoTen;
        private TextBox txtHoTen;
        private Label lblGioiTinh;
        private ComboBox cboGioiTinh;
        private Label lblNgaySinh;
        private DateTimePicker dtpNgaySinh;
        private Label lblSoDienThoai;
        private TextBox txtSoDienThoai;
        private Label lblChucVu;
        private ComboBox cboChucVu;
        private Label lblDiaChi;
        private TextBox txtDiaChi;
        private Label lblTrangThai;
        private ComboBox cboTrangThai;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;
        private Panel pnlTimKiem;
        private Label lblTimKiem;
        private TextBox txtTimKiem;
        private Button btnTimKiem;
        private Label lblSoLuong;
        private DataGridView dgvNhanVien;
        private DataGridViewTextBoxColumn colMaNhanVien;
        private DataGridViewTextBoxColumn colHoTen;
        private DataGridViewTextBoxColumn colGioiTinh;
        private DataGridViewTextBoxColumn colNgaySinh;
        private DataGridViewTextBoxColumn colSoDienThoai;
        private DataGridViewTextBoxColumn colChucVu;
        private DataGridViewTextBoxColumn colDiaChi;
        private DataGridViewTextBoxColumn colTrangThai;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pnlTieuDe = new Panel();
            lblTieuDe = new Label();
            pnlNhapLieu = new Panel();
            lblMaNhanVien = new Label();
            txtMaNhanVien = new TextBox();
            lblHoTen = new Label();
            txtHoTen = new TextBox();
            lblGioiTinh = new Label();
            cboGioiTinh = new ComboBox();
            lblNgaySinh = new Label();
            dtpNgaySinh = new DateTimePicker();
            lblSoDienThoai = new Label();
            txtSoDienThoai = new TextBox();
            lblChucVu = new Label();
            cboChucVu = new ComboBox();
            lblDiaChi = new Label();
            txtDiaChi = new TextBox();
            lblTrangThai = new Label();
            cboTrangThai = new ComboBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            pnlTimKiem = new Panel();
            lblTimKiem = new Label();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            lblSoLuong = new Label();
            dgvNhanVien = new DataGridView();
            colMaNhanVien = new DataGridViewTextBoxColumn();
            colHoTen = new DataGridViewTextBoxColumn();
            colGioiTinh = new DataGridViewTextBoxColumn();
            colNgaySinh = new DataGridViewTextBoxColumn();
            colSoDienThoai = new DataGridViewTextBoxColumn();
            colChucVu = new DataGridViewTextBoxColumn();
            colDiaChi = new DataGridViewTextBoxColumn();
            colTrangThai = new DataGridViewTextBoxColumn();
            pnlTieuDe.SuspendLayout();
            pnlNhapLieu.SuspendLayout();
            pnlTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            SuspendLayout();

            pnlTieuDe.Name = "pnlTieuDe";
            lblTieuDe.Name = "lblTieuDe";
            pnlNhapLieu.Name = "pnlNhapLieu";
            lblMaNhanVien.Name = "lblMaNhanVien";
            txtMaNhanVien.Name = "txtMaNhanVien";
            lblHoTen.Name = "lblHoTen";
            txtHoTen.Name = "txtHoTen";
            lblGioiTinh.Name = "lblGioiTinh";
            cboGioiTinh.Name = "cboGioiTinh";
            lblNgaySinh.Name = "lblNgaySinh";
            dtpNgaySinh.Name = "dtpNgaySinh";
            lblSoDienThoai.Name = "lblSoDienThoai";
            txtSoDienThoai.Name = "txtSoDienThoai";
            lblChucVu.Name = "lblChucVu";
            cboChucVu.Name = "cboChucVu";
            lblDiaChi.Name = "lblDiaChi";
            txtDiaChi.Name = "txtDiaChi";
            lblTrangThai.Name = "lblTrangThai";
            cboTrangThai.Name = "cboTrangThai";
            btnThem.Name = "btnThem";
            btnSua.Name = "btnSua";
            btnXoa.Name = "btnXoa";
            btnLamMoi.Name = "btnLamMoi";
            pnlTimKiem.Name = "pnlTimKiem";
            lblTimKiem.Name = "lblTimKiem";
            txtTimKiem.Name = "txtTimKiem";
            btnTimKiem.Name = "btnTimKiem";
            lblSoLuong.Name = "lblSoLuong";
            dgvNhanVien.Name = "dgvNhanVien";
            colMaNhanVien.Name = "colMaNhanVien";
            colHoTen.Name = "colHoTen";
            colGioiTinh.Name = "colGioiTinh";
            colNgaySinh.Name = "colNgaySinh";
            colSoDienThoai.Name = "colSoDienThoai";
            colChucVu.Name = "colChucVu";
            colDiaChi.Name = "colDiaChi";
            colTrangThai.Name = "colTrangThai";

            pnlTieuDe.BackColor = Color.FromArgb(37, 99, 235);
            pnlTieuDe.Dock = DockStyle.Top;
            pnlTieuDe.Size = new Size(1020, 58);
            pnlTieuDe.Controls.Add(lblTieuDe);
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.White;
            lblTieuDe.Location = new Point(18, 12);
            lblTieuDe.Text = "QUẢN LÝ NHÂN VIÊN";

            pnlNhapLieu.BackColor = Color.White;
            pnlNhapLieu.Dock = DockStyle.Top;
            pnlNhapLieu.Size = new Size(1020, 206);
            pnlNhapLieu.Controls.Add(lblMaNhanVien);
            pnlNhapLieu.Controls.Add(txtMaNhanVien);
            pnlNhapLieu.Controls.Add(lblHoTen);
            pnlNhapLieu.Controls.Add(txtHoTen);
            pnlNhapLieu.Controls.Add(lblGioiTinh);
            pnlNhapLieu.Controls.Add(cboGioiTinh);
            pnlNhapLieu.Controls.Add(lblNgaySinh);
            pnlNhapLieu.Controls.Add(dtpNgaySinh);
            pnlNhapLieu.Controls.Add(lblSoDienThoai);
            pnlNhapLieu.Controls.Add(txtSoDienThoai);
            pnlNhapLieu.Controls.Add(lblChucVu);
            pnlNhapLieu.Controls.Add(cboChucVu);
            pnlNhapLieu.Controls.Add(lblDiaChi);
            pnlNhapLieu.Controls.Add(txtDiaChi);
            pnlNhapLieu.Controls.Add(lblTrangThai);
            pnlNhapLieu.Controls.Add(cboTrangThai);
            pnlNhapLieu.Controls.Add(btnThem);
            pnlNhapLieu.Controls.Add(btnSua);
            pnlNhapLieu.Controls.Add(btnXoa);
            pnlNhapLieu.Controls.Add(btnLamMoi);

            lblMaNhanVien.AutoSize = true;
            lblMaNhanVien.Location = new Point(18, 16);
            lblMaNhanVien.Text = "Mã nhân viên";

            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(183, 16);
            lblHoTen.Text = "Họ và tên";

            lblGioiTinh.AutoSize = true;
            lblGioiTinh.Location = new Point(438, 16);
            lblGioiTinh.Text = "Giới tính";

            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Location = new Point(573, 16);
            lblNgaySinh.Text = "Ngày sinh";

            lblSoDienThoai.AutoSize = true;
            lblSoDienThoai.Location = new Point(735, 16);
            lblSoDienThoai.Text = "Số điện thoại";

            lblChucVu.AutoSize = true;
            lblChucVu.Location = new Point(18, 86);
            lblChucVu.Text = "Chức vụ";

            lblDiaChi.AutoSize = true;
            lblDiaChi.Location = new Point(244, 86);
            lblDiaChi.Text = "Địa chỉ";

            lblTrangThai.AutoSize = true;
            lblTrangThai.Location = new Point(589, 86);
            lblTrangThai.Text = "Trạng thái";

            txtMaNhanVien.Location = new Point(18, 40);
            txtMaNhanVien.Size = new Size(145, 28);

            txtHoTen.Location = new Point(183, 40);
            txtHoTen.Size = new Size(235, 28);

            txtSoDienThoai.Location = new Point(735, 40);
            txtSoDienThoai.Size = new Size(175, 28);

            txtDiaChi.Location = new Point(244, 111);
            txtDiaChi.Size = new Size(320, 28);

            cboGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGioiTinh.Location = new Point(438, 40);
            cboGioiTinh.Size = new Size(115, 28);
            cboGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ", "Khác" });

            cboChucVu.DropDownStyle = ComboBoxStyle.DropDownList;
            cboChucVu.Location = new Point(18, 111);
            cboChucVu.Size = new Size(205, 28);
            cboChucVu.Items.AddRange(new object[] { "Dược sĩ", "Nhân viên bán hàng", "Quản lý", "Thu ngân", "Nhân viên kho" });

            cboTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTrangThai.Location = new Point(589, 111);
            cboTrangThai.Size = new Size(180, 28);
            cboTrangThai.Items.AddRange(new object[] { "Đang làm", "Nghỉ việc" });

            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            dtpNgaySinh.Location = new Point(573, 40);
            dtpNgaySinh.Size = new Size(142, 28);

            btnThem.Text = "Thêm";
            btnThem.BackColor = Color.FromArgb(22, 163, 74);
            btnThem.ForeColor = Color.White;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnThem.Cursor = Cursors.Hand;
            btnThem.Location = new Point(18, 158);
            btnThem.Size = new Size(94, 34);
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;

            btnSua.Text = "Sửa";
            btnSua.BackColor = Color.FromArgb(234, 88, 12);
            btnSua.ForeColor = Color.White;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSua.Cursor = Cursors.Hand;
            btnSua.Location = new Point(126, 158);
            btnSua.Size = new Size(94, 34);
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;

            btnXoa.Text = "Xóa";
            btnXoa.BackColor = Color.FromArgb(220, 38, 38);
            btnXoa.ForeColor = Color.White;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnXoa.Cursor = Cursors.Hand;
            btnXoa.Location = new Point(234, 158);
            btnXoa.Size = new Size(94, 34);
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;

            btnLamMoi.Text = "Làm mới";
            btnLamMoi.BackColor = Color.FromArgb(37, 99, 235);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.FlatAppearance.BorderSize = 0;
            btnLamMoi.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLamMoi.Cursor = Cursors.Hand;
            btnLamMoi.Location = new Point(342, 158);
            btnLamMoi.Size = new Size(94, 34);
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;

            pnlTimKiem.BackColor = Color.FromArgb(245, 247, 250);
            pnlTimKiem.Dock = DockStyle.Top;
            pnlTimKiem.Size = new Size(1020, 64);
            pnlTimKiem.Controls.Add(lblTimKiem);
            pnlTimKiem.Controls.Add(txtTimKiem);
            pnlTimKiem.Controls.Add(btnTimKiem);
            pnlTimKiem.Controls.Add(lblSoLuong);
            lblTimKiem.AutoSize = true;
            lblTimKiem.Location = new Point(18, 19);
            lblTimKiem.Text = "Tìm kiếm:";
            txtTimKiem.Location = new Point(105, 15);
            txtTimKiem.Size = new Size(325, 28);
            txtTimKiem.PlaceholderText = "Mã, họ tên, SĐT, chức vụ...";
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.BackColor = Color.FromArgb(37, 99, 235);
            btnTimKiem.ForeColor = Color.White;
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.FlatAppearance.BorderSize = 0;
            btnTimKiem.Cursor = Cursors.Hand;
            btnTimKiem.Location = new Point(445, 14);
            btnTimKiem.Size = new Size(110, 31);
            btnTimKiem.Click += btnTimKiem_Click;
            lblSoLuong.AutoSize = true;
            lblSoLuong.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSoLuong.Location = new Point(798, 19);
            lblSoLuong.Text = "Hiển thị: 0 nhân viên";

            dgvNhanVien.AllowUserToAddRows = false;
            dgvNhanVien.AllowUserToDeleteRows = false;
            dgvNhanVien.AllowUserToResizeRows = false;
            dgvNhanVien.MultiSelect = false;
            dgvNhanVien.BackgroundColor = Color.White;
            dgvNhanVien.BorderStyle = BorderStyle.None;
            dgvNhanVien.Dock = DockStyle.Fill;
            dgvNhanVien.ReadOnly = true;
            dgvNhanVien.RowHeadersVisible = false;
            dgvNhanVien.RowTemplate.Height = 32;
            dgvNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.EnableHeadersVisualStyles = false;
            dgvNhanVien.ColumnHeadersHeight = 38;
            dgvNhanVien.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 99, 235);
            dgvNhanVien.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvNhanVien.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(37, 99, 235);
            dgvNhanVien.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvNhanVien.DefaultCellStyle.ForeColor = Color.FromArgb(31, 41, 55);
            dgvNhanVien.DefaultCellStyle.SelectionBackColor = Color.RoyalBlue;
            dgvNhanVien.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
            dgvNhanVien.CellClick += dgvNhanVien_CellClick;
            dgvNhanVien.Columns.AddRange(new DataGridViewColumn[] {
                colMaNhanVien, colHoTen, colGioiTinh, colNgaySinh,
                colSoDienThoai, colChucVu, colDiaChi, colTrangThai });
            colMaNhanVien.HeaderText = "Mã NV";
            colMaNhanVien.MinimumWidth = 90;
            colMaNhanVien.ReadOnly = true;
            colHoTen.HeaderText = "Họ và tên";
            colHoTen.MinimumWidth = 150;
            colHoTen.ReadOnly = true;
            colGioiTinh.HeaderText = "Giới tính";
            colGioiTinh.MinimumWidth = 75;
            colGioiTinh.ReadOnly = true;
            colNgaySinh.HeaderText = "Ngày sinh";
            colNgaySinh.MinimumWidth = 110;
            colNgaySinh.ReadOnly = true;
            colSoDienThoai.HeaderText = "Điện thoại";
            colSoDienThoai.MinimumWidth = 110;
            colSoDienThoai.ReadOnly = true;
            colChucVu.HeaderText = "Chức vụ";
            colChucVu.MinimumWidth = 160;
            colChucVu.ReadOnly = true;
            colDiaChi.HeaderText = "Địa chỉ";
            colDiaChi.MinimumWidth = 130;
            colDiaChi.ReadOnly = true;
            colTrangThai.HeaderText = "Trạng thái";
            colTrangThai.MinimumWidth = 120;
            colTrangThai.ReadOnly = true;

            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 660);
            BackColor = Color.FromArgb(245, 247, 250);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.FromArgb(31, 41, 55);
            Name = "FormQuanLyNhanVien";
            Text = "Quản lý nhân viên";
            Controls.Add(dgvNhanVien);
            Controls.Add(pnlTimKiem);
            Controls.Add(pnlNhapLieu);
            Controls.Add(pnlTieuDe);
            pnlTieuDe.ResumeLayout(false);
            pnlTieuDe.PerformLayout();
            pnlNhapLieu.ResumeLayout(false);
            pnlNhapLieu.PerformLayout();
            pnlTimKiem.ResumeLayout(false);
            pnlTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            ResumeLayout(false);
        }
    }
}
