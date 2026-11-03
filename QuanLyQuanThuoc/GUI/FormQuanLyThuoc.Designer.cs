using System.Drawing;
using System.Windows.Forms;

namespace QuanLyQuanThuoc.Models
{
    partial class FormQuanLyThuoc
    {
        private System.ComponentModel.IContainer components = null;
        private Panel pnlTieuDe;
        private Label lblTieuDe;
        private Panel pnlNhapLieu;
        private Label lblMaThuoc;
        private TextBox txtMaThuoc;
        private Label lblTenThuoc;
        private TextBox txtTenThuoc;
        private Label lblDonViTinh;
        private ComboBox cboDonViTinh;
        private Label lblSoLuong;
        private NumericUpDown nudSoLuong;
        private Label lblDonGia;
        private TextBox txtDonGia;
        private Label lblHanSuDung;
        private DateTimePicker dtpHanSuDung;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;
        private Panel pnlTimKiem;
        private Label lblTimKiem;
        private TextBox txtTimKiem;
        private Button btnTimKiem;
        private DataGridView dgvThuoc;
        private DataGridViewTextBoxColumn colMaThuoc;
        private DataGridViewTextBoxColumn colTenThuoc;
        private DataGridViewTextBoxColumn colDonViTinh;
        private DataGridViewTextBoxColumn colSoLuong;
        private DataGridViewTextBoxColumn colDonGia;
        private DataGridViewTextBoxColumn colHanSuDung;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pnlTieuDe = new Panel();
            lblTieuDe = new Label();
            pnlNhapLieu = new Panel();
            lblMaThuoc = new Label();
            txtMaThuoc = new TextBox();
            lblTenThuoc = new Label();
            txtTenThuoc = new TextBox();
            lblDonViTinh = new Label();
            cboDonViTinh = new ComboBox();
            lblSoLuong = new Label();
            nudSoLuong = new NumericUpDown();
            lblDonGia = new Label();
            txtDonGia = new TextBox();
            lblHanSuDung = new Label();
            dtpHanSuDung = new DateTimePicker();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            pnlTimKiem = new Panel();
            lblTimKiem = new Label();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            dgvThuoc = new DataGridView();
            colMaThuoc = new DataGridViewTextBoxColumn();
            colTenThuoc = new DataGridViewTextBoxColumn();
            colDonViTinh = new DataGridViewTextBoxColumn();
            colSoLuong = new DataGridViewTextBoxColumn();
            colDonGia = new DataGridViewTextBoxColumn();
            colHanSuDung = new DataGridViewTextBoxColumn();
            pnlTieuDe.SuspendLayout();
            pnlNhapLieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoLuong).BeginInit();
            pnlTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThuoc).BeginInit();
            SuspendLayout();
            // 
            // pnlTieuDe
            // 
            pnlTieuDe.BackColor = Color.FromArgb(37, 99, 235);
            pnlTieuDe.Controls.Add(lblTieuDe);
            pnlTieuDe.Dock = DockStyle.Top;
            pnlTieuDe.Location = new Point(0, 0);
            pnlTieuDe.Name = "pnlTieuDe";
            pnlTieuDe.Size = new Size(1000, 58);
            pnlTieuDe.TabIndex = 3;
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.White;
            lblTieuDe.Location = new Point(18, 12);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(234, 37);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "QUẢN LÝ THUỐC";
            // 
            // pnlNhapLieu
            // 
            pnlNhapLieu.BackColor = Color.White;
            pnlNhapLieu.Controls.Add(lblMaThuoc);
            pnlNhapLieu.Controls.Add(txtMaThuoc);
            pnlNhapLieu.Controls.Add(lblTenThuoc);
            pnlNhapLieu.Controls.Add(txtTenThuoc);
            pnlNhapLieu.Controls.Add(lblDonViTinh);
            pnlNhapLieu.Controls.Add(cboDonViTinh);
            pnlNhapLieu.Controls.Add(lblSoLuong);
            pnlNhapLieu.Controls.Add(nudSoLuong);
            pnlNhapLieu.Controls.Add(lblDonGia);
            pnlNhapLieu.Controls.Add(txtDonGia);
            pnlNhapLieu.Controls.Add(lblHanSuDung);
            pnlNhapLieu.Controls.Add(dtpHanSuDung);
            pnlNhapLieu.Controls.Add(btnThem);
            pnlNhapLieu.Controls.Add(btnSua);
            pnlNhapLieu.Controls.Add(btnXoa);
            pnlNhapLieu.Controls.Add(btnLamMoi);
            pnlNhapLieu.Dock = DockStyle.Top;
            pnlNhapLieu.Location = new Point(0, 58);
            pnlNhapLieu.Name = "pnlNhapLieu";
            pnlNhapLieu.Size = new Size(1000, 152);
            pnlNhapLieu.TabIndex = 2;
            // 
            // lblMaThuoc
            // 
            lblMaThuoc.AutoSize = true;
            lblMaThuoc.Location = new Point(18, 16);
            lblMaThuoc.Name = "lblMaThuoc";
            lblMaThuoc.Size = new Size(83, 23);
            lblMaThuoc.TabIndex = 0;
            lblMaThuoc.Text = "Mã thuốc";
            // 
            // txtMaThuoc
            // 
            txtMaThuoc.Location = new Point(18, 39);
            txtMaThuoc.Name = "txtMaThuoc";
            txtMaThuoc.Size = new Size(150, 30);
            txtMaThuoc.TabIndex = 1;
            // 
            // lblTenThuoc
            // 
            lblTenThuoc.AutoSize = true;
            lblTenThuoc.Location = new Point(185, 16);
            lblTenThuoc.Name = "lblTenThuoc";
            lblTenThuoc.Size = new Size(85, 23);
            lblTenThuoc.TabIndex = 2;
            lblTenThuoc.Text = "Tên thuốc";
            // 
            // txtTenThuoc
            // 
            txtTenThuoc.Location = new Point(185, 39);
            txtTenThuoc.Name = "txtTenThuoc";
            txtTenThuoc.Size = new Size(245, 30);
            txtTenThuoc.TabIndex = 3;
            // 
            // lblDonViTinh
            // 
            lblDonViTinh.AutoSize = true;
            lblDonViTinh.Location = new Point(450, 16);
            lblDonViTinh.Name = "lblDonViTinh";
            lblDonViTinh.Size = new Size(94, 23);
            lblDonViTinh.TabIndex = 4;
            lblDonViTinh.Text = "Đơn vị tính";
            // 
            // cboDonViTinh
            // 
            cboDonViTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDonViTinh.Items.AddRange(new object[] { "Hộp ", "Vỉ", "Chai", "Tuýt", "Bao" });
            cboDonViTinh.Location = new Point(450, 39);
            cboDonViTinh.Name = "cboDonViTinh";
            cboDonViTinh.Size = new Size(125, 31);
            cboDonViTinh.TabIndex = 5;
            cboDonViTinh.SelectedIndexChanged += cboDonViTinh_SelectedIndexChanged;
            // 
            // lblSoLuong
            // 
            lblSoLuong.AutoSize = true;
            lblSoLuong.Location = new Point(590, 16);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(78, 23);
            lblSoLuong.TabIndex = 6;
            lblSoLuong.Text = "Số lượng";
            // 
            // nudSoLuong
            // 
            nudSoLuong.Location = new Point(590, 39);
            nudSoLuong.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudSoLuong.Name = "nudSoLuong";
            nudSoLuong.Size = new Size(110, 30);
            nudSoLuong.TabIndex = 7;
            // 
            // lblDonGia
            // 
            lblDonGia.AutoSize = true;
            lblDonGia.Location = new Point(715, 16);
            lblDonGia.Name = "lblDonGia";
            lblDonGia.Size = new Size(70, 23);
            lblDonGia.TabIndex = 8;
            lblDonGia.Text = "Đơn giá";
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(715, 39);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(125, 30);
            txtDonGia.TabIndex = 9;
            // 
            // lblHanSuDung
            // 
            lblHanSuDung.AutoSize = true;
            lblHanSuDung.Location = new Point(855, 16);
            lblHanSuDung.Name = "lblHanSuDung";
            lblHanSuDung.Size = new Size(108, 23);
            lblHanSuDung.TabIndex = 10;
            lblHanSuDung.Text = "Hạn sử dụng";
            // 
            // dtpHanSuDung
            // 
            dtpHanSuDung.Format = DateTimePickerFormat.Short;
            dtpHanSuDung.Location = new Point(855, 39);
            dtpHanSuDung.Name = "dtpHanSuDung";
            dtpHanSuDung.Size = new Size(130, 30);
            dtpHanSuDung.TabIndex = 11;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(22, 163, 74);
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(18, 97);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(83, 33);
            btnThem.TabIndex = 12;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(234, 88, 12);
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(125, 97);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(83, 33);
            btnSua.TabIndex = 13;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(220, 38, 38);
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(240, 97);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(83, 33);
            btnXoa.TabIndex = 14;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.FromArgb(37, 99, 235);
            btnLamMoi.FlatAppearance.BorderSize = 0;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(347, 97);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(83, 33);
            btnLamMoi.TabIndex = 15;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // pnlTimKiem
            // 
            pnlTimKiem.BackColor = Color.FromArgb(245, 247, 250);
            pnlTimKiem.Controls.Add(lblTimKiem);
            pnlTimKiem.Controls.Add(txtTimKiem);
            pnlTimKiem.Controls.Add(btnTimKiem);
            pnlTimKiem.Dock = DockStyle.Top;
            pnlTimKiem.Location = new Point(0, 210);
            pnlTimKiem.Name = "pnlTimKiem";
            pnlTimKiem.Size = new Size(1000, 58);
            pnlTimKiem.TabIndex = 1;
            // 
            // lblTimKiem
            // 
            lblTimKiem.AutoSize = true;
            lblTimKiem.Location = new Point(18, 18);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Size = new Size(83, 23);
            lblTimKiem.TabIndex = 0;
            lblTimKiem.Text = "Tìm kiếm:";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(90, 13);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(300, 30);
            txtTimKiem.TabIndex = 1;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.FromArgb(37, 99, 235);
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.ForeColor = Color.White;
            btnTimKiem.Location = new Point(400, 12);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(100, 30);
            btnTimKiem.TabIndex = 2;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // dgvThuoc
            // 
            dgvThuoc.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 250, 252);
            dgvThuoc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvThuoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvThuoc.BackgroundColor = Color.White;
            dgvThuoc.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(37, 99, 235);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvThuoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvThuoc.ColumnHeadersHeight = 38;
            dgvThuoc.Columns.AddRange(new DataGridViewColumn[] { colMaThuoc, colTenThuoc, colDonViTinh, colSoLuong, colDonGia, colHanSuDung });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(31, 41, 55);
            dataGridViewCellStyle3.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvThuoc.DefaultCellStyle = dataGridViewCellStyle3;
            dgvThuoc.Dock = DockStyle.Fill;
            dgvThuoc.EnableHeadersVisualStyles = false;
            dgvThuoc.Font = new Font("Segoe UI", 10F);
            dgvThuoc.GridColor = Color.FromArgb(226, 232, 240);
            dgvThuoc.Location = new Point(0, 268);
            dgvThuoc.Name = "dgvThuoc";
            dgvThuoc.ReadOnly = true;
            dgvThuoc.RowHeadersVisible = false;
            dgvThuoc.RowHeadersWidth = 51;
            dgvThuoc.RowTemplate.Height = 32;
            dgvThuoc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvThuoc.Size = new Size(1000, 382);
            dgvThuoc.TabIndex = 0;
            dgvThuoc.CellClick += dgvThuoc_CellClick;
            // 
            // colMaThuoc
            // 
            colMaThuoc.HeaderText = "Mã thuốc";
            colMaThuoc.MinimumWidth = 6;
            colMaThuoc.Name = "colMaThuoc";
            colMaThuoc.ReadOnly = true;
            // 
            // colTenThuoc
            // 
            colTenThuoc.HeaderText = "Tên thuốc";
            colTenThuoc.MinimumWidth = 6;
            colTenThuoc.Name = "colTenThuoc";
            colTenThuoc.ReadOnly = true;
            // 
            // colDonViTinh
            // 
            colDonViTinh.HeaderText = "Đơn vị tính";
            colDonViTinh.MinimumWidth = 6;
            colDonViTinh.Name = "colDonViTinh";
            colDonViTinh.ReadOnly = true;
            // 
            // colSoLuong
            // 
            colSoLuong.HeaderText = "Số lượng";
            colSoLuong.MinimumWidth = 6;
            colSoLuong.Name = "colSoLuong";
            colSoLuong.ReadOnly = true;
            // 
            // colDonGia
            // 
            colDonGia.HeaderText = "Đơn giá";
            colDonGia.MinimumWidth = 6;
            colDonGia.Name = "colDonGia";
            colDonGia.ReadOnly = true;
            // 
            // colHanSuDung
            // 
            colHanSuDung.HeaderText = "Hạn sử dụng";
            colHanSuDung.MinimumWidth = 6;
            colHanSuDung.Name = "colHanSuDung";
            colHanSuDung.ReadOnly = true;
            // 
            // FormQuanLyThuoc
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1000, 650);
            Controls.Add(dgvThuoc);
            Controls.Add(pnlTimKiem);
            Controls.Add(pnlNhapLieu);
            Controls.Add(pnlTieuDe);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.FromArgb(31, 41, 55);
            Name = "FormQuanLyThuoc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý thuốc";
            pnlTieuDe.ResumeLayout(false);
            pnlTieuDe.PerformLayout();
            pnlNhapLieu.ResumeLayout(false);
            pnlNhapLieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoLuong).EndInit();
            pnlTimKiem.ResumeLayout(false);
            pnlTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThuoc).EndInit();
            ResumeLayout(false);
        }

    }
}
