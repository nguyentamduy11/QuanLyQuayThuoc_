using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyQuanThuoc.Models
{
    partial class FormDonViTinh
    {
        private System.ComponentModel.IContainer? components = null;
        private Panel pnlTieuDe;
        private Label lblTieuDe;
        private Panel pnlNhap;
        private Label lblMaDV;
        private Label lblTenDV;
        private Label lblMoTa;
        private TextBox txtMaDV;
        private TextBox txtTenDV;
        private TextBox txtMoTa;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;
        private Panel pnlTimKiem;
        private Label lblTimKiem;
        private TextBox txtTimKiem;
        private Button btnTimKiem;
        private Label lblSoLuong;
        private DataGridView dgvDonViTinh;
        private DataGridViewTextBoxColumn colMaDV;
        private DataGridViewTextBoxColumn colTenDV;
        private DataGridViewTextBoxColumn colMoTa;

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
            pnlTieuDe = new Panel();
            lblTieuDe = new Label();
            pnlNhap = new Panel();
            lblMaDV = new Label();
            txtMaDV = new TextBox();
            lblTenDV = new Label();
            txtTenDV = new TextBox();
            lblMoTa = new Label();
            txtMoTa = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            pnlTimKiem = new Panel();
            lblTimKiem = new Label();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            lblSoLuong = new Label();
            dgvDonViTinh = new DataGridView();
            colMaDV = new DataGridViewTextBoxColumn();
            colTenDV = new DataGridViewTextBoxColumn();
            colMoTa = new DataGridViewTextBoxColumn();
            pnlTieuDe.SuspendLayout();
            pnlNhap.SuspendLayout();
            pnlTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDonViTinh).BeginInit();
            SuspendLayout();
            // 
            // pnlTieuDe
            // 
            pnlTieuDe.BackColor = Color.FromArgb(37, 99, 235);
            pnlTieuDe.Controls.Add(lblTieuDe);
            pnlTieuDe.Dock = DockStyle.Top;
            pnlTieuDe.Location = new Point(0, 0);
            pnlTieuDe.Name = "pnlTieuDe";
            pnlTieuDe.Size = new Size(1020, 58);
            pnlTieuDe.TabIndex = 3;
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.White;
            lblTieuDe.Location = new Point(18, 12);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(310, 37);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "QUẢN LÝ ĐƠN VỊ TÍNH";
            // 
            // pnlNhap
            // 
            pnlNhap.BackColor = Color.White;
            pnlNhap.Controls.Add(lblMaDV);
            pnlNhap.Controls.Add(txtMaDV);
            pnlNhap.Controls.Add(lblTenDV);
            pnlNhap.Controls.Add(txtTenDV);
            pnlNhap.Controls.Add(lblMoTa);
            pnlNhap.Controls.Add(txtMoTa);
            pnlNhap.Controls.Add(btnThem);
            pnlNhap.Controls.Add(btnSua);
            pnlNhap.Controls.Add(btnXoa);
            pnlNhap.Controls.Add(btnLamMoi);
            pnlNhap.Dock = DockStyle.Top;
            pnlNhap.Location = new Point(0, 58);
            pnlNhap.Name = "pnlNhap";
            pnlNhap.Size = new Size(1020, 162);
            pnlNhap.TabIndex = 2;
            // 
            // lblMaDV
            // 
            lblMaDV.AutoSize = true;
            lblMaDV.Location = new Point(18, 19);
            lblMaDV.Name = "lblMaDV";
            lblMaDV.Size = new Size(86, 23);
            lblMaDV.TabIndex = 0;
            lblMaDV.Text = "Mã đơn vị";
            // 
            // txtMaDV
            // 
            txtMaDV.Location = new Point(18, 48);
            txtMaDV.Name = "txtMaDV";
            txtMaDV.Size = new Size(180, 30);
            txtMaDV.TabIndex = 1;
            // 
            // lblTenDV
            // 
            lblTenDV.AutoSize = true;
            lblTenDV.Location = new Point(225, 19);
            lblTenDV.Name = "lblTenDV";
            lblTenDV.Size = new Size(123, 23);
            lblTenDV.TabIndex = 2;
            lblTenDV.Text = "Tên đơn vị tính";
            // 
            // txtTenDV
            // 
            txtTenDV.Location = new Point(225, 48);
            txtTenDV.Name = "txtTenDV";
            txtTenDV.Size = new Size(245, 30);
            txtTenDV.TabIndex = 3;
            // 
            // lblMoTa
            // 
            lblMoTa.AutoSize = true;
            lblMoTa.Location = new Point(505, 19);
            lblMoTa.Name = "lblMoTa";
            lblMoTa.Size = new Size(55, 23);
            lblMoTa.TabIndex = 4;
            lblMoTa.Text = "Mô tả";
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(505, 48);
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(286, 30);
            txtMoTa.TabIndex = 5;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(22, 163, 74);
            btnThem.Cursor = Cursors.Hand;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(18, 102);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(98, 34);
            btnThem.TabIndex = 6;
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
            btnSua.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(130, 102);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(98, 34);
            btnSua.TabIndex = 7;
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
            btnXoa.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(242, 102);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(98, 34);
            btnXoa.TabIndex = 8;
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
            btnLamMoi.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(354, 102);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(98, 34);
            btnLamMoi.TabIndex = 9;
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
            pnlTimKiem.Controls.Add(lblSoLuong);
            pnlTimKiem.Dock = DockStyle.Top;
            pnlTimKiem.Location = new Point(0, 220);
            pnlTimKiem.Name = "pnlTimKiem";
            pnlTimKiem.Size = new Size(1020, 64);
            pnlTimKiem.TabIndex = 1;
            // 
            // lblTimKiem
            // 
            lblTimKiem.AutoSize = true;
            lblTimKiem.Location = new Point(18, 21);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Size = new Size(83, 23);
            lblTimKiem.TabIndex = 0;
            lblTimKiem.Text = "Tìm kiếm:";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(113, 16);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Mã, tên hoặc mô tả đơn vị...";
            txtTimKiem.Size = new Size(305, 30);
            txtTimKiem.TabIndex = 1;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.FromArgb(37, 99, 235);
            btnTimKiem.Cursor = Cursors.Hand;
            btnTimKiem.FlatAppearance.BorderSize = 0;
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.ForeColor = Color.White;
            btnTimKiem.Location = new Point(435, 16);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(110, 31);
            btnTimKiem.TabIndex = 2;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // lblSoLuong
            // 
            lblSoLuong.AutoSize = true;
            lblSoLuong.Location = new Point(800, 21);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(140, 23);
            lblSoLuong.TabIndex = 3;
            lblSoLuong.Text = "Hiển thị: 0 đơn vị";
            // 
            // dgvDonViTinh
            // 
            dgvDonViTinh.AllowUserToAddRows = false;
            dgvDonViTinh.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 250, 252);
            dgvDonViTinh.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvDonViTinh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDonViTinh.BackgroundColor = Color.White;
            dgvDonViTinh.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(37, 99, 235);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(37, 99, 235);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvDonViTinh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvDonViTinh.ColumnHeadersHeight = 38;
            dgvDonViTinh.Columns.AddRange(new DataGridViewColumn[] { colMaDV, colTenDV, colMoTa });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(31, 41, 55);
            dataGridViewCellStyle3.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvDonViTinh.DefaultCellStyle = dataGridViewCellStyle3;
            dgvDonViTinh.Dock = DockStyle.Fill;
            dgvDonViTinh.EnableHeadersVisualStyles = false;
            dgvDonViTinh.Location = new Point(0, 284);
            dgvDonViTinh.MultiSelect = false;
            dgvDonViTinh.Name = "dgvDonViTinh";
            dgvDonViTinh.ReadOnly = true;
            dgvDonViTinh.RowHeadersVisible = false;
            dgvDonViTinh.RowHeadersWidth = 51;
            dgvDonViTinh.RowTemplate.Height = 32;
            dgvDonViTinh.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDonViTinh.Size = new Size(1020, 376);
            dgvDonViTinh.TabIndex = 0;
            dgvDonViTinh.CellClick += dgvDonViTinh_CellClick;
            // 
            // colMaDV
            // 
            colMaDV.FillWeight = 22F;
            colMaDV.HeaderText = "Mã đơn vị";
            colMaDV.MinimumWidth = 6;
            colMaDV.Name = "colMaDV";
            colMaDV.ReadOnly = true;
            // 
            // colTenDV
            // 
            colTenDV.FillWeight = 35F;
            colTenDV.HeaderText = "Tên đơn vị tính";
            colTenDV.MinimumWidth = 6;
            colTenDV.Name = "colTenDV";
            colTenDV.ReadOnly = true;
            // 
            // colMoTa
            // 
            colMoTa.FillWeight = 65F;
            colMoTa.HeaderText = "Mô tả";
            colMoTa.MinimumWidth = 6;
            colMoTa.Name = "colMoTa";
            colMoTa.ReadOnly = true;
            // 
            // FormDonViTinh
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1020, 660);
            Controls.Add(dgvDonViTinh);
            Controls.Add(pnlTimKiem);
            Controls.Add(pnlNhap);
            Controls.Add(pnlTieuDe);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.FromArgb(31, 41, 55);
            Name = "FormDonViTinh";
            Text = "Quản lý đơn vị tính";
            pnlTieuDe.ResumeLayout(false);
            pnlTieuDe.PerformLayout();
            pnlNhap.ResumeLayout(false);
            pnlNhap.PerformLayout();
            pnlTimKiem.ResumeLayout(false);
            pnlTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDonViTinh).EndInit();
            ResumeLayout(false);
        }

    }
}
