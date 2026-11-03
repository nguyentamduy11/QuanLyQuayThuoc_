namespace QuanLyQuanThuoc.Models
{
    partial class FormDanhMucThuoc
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            grpDanhMucThuoc = new GroupBox();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            cboTrangThai = new ComboBox();
            txtMoTa = new TextBox();
            txtTenDanhMuc = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtMaDanhMuc = new TextBox();
            label1 = new Label();
            dgvDanhMuc = new DataGridView();
            ColMaDanhMuc = new DataGridViewTextBoxColumn();
            ColTenDanhMuc = new DataGridViewTextBoxColumn();
            ColMoTa = new DataGridViewTextBoxColumn();
            ColTrangThai = new DataGridViewTextBoxColumn();
            lblDanhSach = new Label();
            txtTimKiem = new TextBox();
            grpDanhMucThuoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhMuc).BeginInit();
            SuspendLayout();
            // 
            // grpDanhMucThuoc
            // 
            grpDanhMucThuoc.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpDanhMucThuoc.BackColor = Color.White;
            grpDanhMucThuoc.Controls.Add(btnLamMoi);
            grpDanhMucThuoc.Controls.Add(btnXoa);
            grpDanhMucThuoc.Controls.Add(btnSua);
            grpDanhMucThuoc.Controls.Add(btnThem);
            grpDanhMucThuoc.Controls.Add(cboTrangThai);
            grpDanhMucThuoc.Controls.Add(txtMoTa);
            grpDanhMucThuoc.Controls.Add(txtTenDanhMuc);
            grpDanhMucThuoc.Controls.Add(label4);
            grpDanhMucThuoc.Controls.Add(label3);
            grpDanhMucThuoc.Controls.Add(label2);
            grpDanhMucThuoc.Controls.Add(txtMaDanhMuc);
            grpDanhMucThuoc.Controls.Add(label1);
            grpDanhMucThuoc.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpDanhMucThuoc.ForeColor = Color.FromArgb(30, 64, 175);
            grpDanhMucThuoc.Location = new Point(0, 20);
            grpDanhMucThuoc.Margin = new Padding(3, 4, 3, 4);
            grpDanhMucThuoc.Name = "grpDanhMucThuoc";
            grpDanhMucThuoc.Padding = new Padding(3, 4, 3, 4);
            grpDanhMucThuoc.Size = new Size(1118, 264);
            grpDanhMucThuoc.TabIndex = 0;
            grpDanhMucThuoc.TabStop = false;
            grpDanhMucThuoc.Text = "Danh Mục Thuốc ";
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.FromArgb(37, 99, 235);
            btnLamMoi.Cursor = Cursors.Hand;
            btnLamMoi.FlatAppearance.BorderSize = 0;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(448, 160);
            btnLamMoi.Margin = new Padding(3, 4, 3, 4);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(86, 31);
            btnLamMoi.TabIndex = 11;
            btnLamMoi.Text = "Làm Mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(220, 38, 38);
            btnXoa.Cursor = Cursors.Hand;
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(318, 160);
            btnXoa.Margin = new Padding(3, 4, 3, 4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(86, 31);
            btnXoa.TabIndex = 10;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(234, 88, 12);
            btnSua.Cursor = Cursors.Hand;
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(176, 160);
            btnSua.Margin = new Padding(3, 4, 3, 4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(86, 31);
            btnSua.TabIndex = 9;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(22, 163, 74);
            btnThem.Cursor = Cursors.Hand;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(45, 160);
            btnThem.Margin = new Padding(3, 4, 3, 4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(86, 31);
            btnThem.TabIndex = 8;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // cboTrangThai
            // 
            cboTrangThai.FormattingEnabled = true;
            cboTrangThai.Location = new Point(433, 85);
            cboTrangThai.Margin = new Padding(3, 4, 3, 4);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(157, 31);
            cboTrangThai.TabIndex = 7;
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(72, 85);
            txtMoTa.Margin = new Padding(3, 4, 3, 4);
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(189, 30);
            txtMoTa.TabIndex = 6;
            // 
            // txtTenDanhMuc
            // 
            txtTenDanhMuc.Location = new Point(499, 35);
            txtTenDanhMuc.Margin = new Padding(3, 4, 3, 4);
            txtTenDanhMuc.Name = "txtTenDanhMuc";
            txtTenDanhMuc.Size = new Size(189, 30);
            txtTenDanhMuc.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(318, 91);
            label4.Name = "label4";
            label4.Size = new Size(87, 23);
            label4.TabIndex = 4;
            label4.Text = "Trạng thái";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(14, 91);
            label3.Name = "label3";
            label3.Size = new Size(55, 23);
            label3.TabIndex = 3;
            label3.Text = "Mô tả";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(352, 35);
            label2.Name = "label2";
            label2.Size = new Size(118, 23);
            label2.TabIndex = 2;
            label2.Text = "Tên danh mục";
            // 
            // txtMaDanhMuc
            // 
            txtMaDanhMuc.Location = new Point(136, 32);
            txtMaDanhMuc.Margin = new Padding(3, 4, 3, 4);
            txtMaDanhMuc.Name = "txtMaDanhMuc";
            txtMaDanhMuc.Size = new Size(189, 30);
            txtMaDanhMuc.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(14, 35);
            label1.Name = "label1";
            label1.Size = new Size(116, 23);
            label1.TabIndex = 0;
            label1.Text = "Mã danh mục";
            // 
            // dgvDanhMuc
            // 
            dgvDanhMuc.AllowUserToAddRows = false;
            dgvDanhMuc.AllowUserToDeleteRows = false;
            dgvDanhMuc.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 250, 252);
            dgvDanhMuc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvDanhMuc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDanhMuc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhMuc.BackgroundColor = Color.White;
            dgvDanhMuc.BorderStyle = BorderStyle.None;
            dgvDanhMuc.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(37, 99, 235);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(37, 99, 235);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvDanhMuc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvDanhMuc.ColumnHeadersHeight = 38;
            dgvDanhMuc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvDanhMuc.Columns.AddRange(new DataGridViewColumn[] { ColMaDanhMuc, ColTenDanhMuc, ColMoTa, ColTrangThai });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(37, 99, 235);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvDanhMuc.DefaultCellStyle = dataGridViewCellStyle3;
            dgvDanhMuc.EnableHeadersVisualStyles = false;
            dgvDanhMuc.Font = new Font("Segoe UI", 10F);
            dgvDanhMuc.GridColor = Color.FromArgb(209, 213, 219);
            dgvDanhMuc.Location = new Point(17, 347);
            dgvDanhMuc.Margin = new Padding(3, 4, 3, 4);
            dgvDanhMuc.Name = "dgvDanhMuc";
            dgvDanhMuc.ReadOnly = true;
            dgvDanhMuc.RowHeadersVisible = false;
            dgvDanhMuc.RowHeadersWidth = 51;
            dgvDanhMuc.RowTemplate.Height = 32;
            dgvDanhMuc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDanhMuc.Size = new Size(1118, 419);
            dgvDanhMuc.TabIndex = 1;
            dgvDanhMuc.CellClick += dgvDanhMuc_CellClick;
            // 
            // ColMaDanhMuc
            // 
            ColMaDanhMuc.HeaderText = "Mã Danh Mục";
            ColMaDanhMuc.MinimumWidth = 100;
            ColMaDanhMuc.Name = "ColMaDanhMuc";
            ColMaDanhMuc.ReadOnly = true;
            // 
            // ColTenDanhMuc
            // 
            ColTenDanhMuc.HeaderText = "Tên Danh Mục ";
            ColTenDanhMuc.MinimumWidth = 180;
            ColTenDanhMuc.Name = "ColTenDanhMuc";
            ColTenDanhMuc.ReadOnly = true;
            // 
            // ColMoTa
            // 
            ColMoTa.HeaderText = "Mô Tả";
            ColMoTa.MinimumWidth = 220;
            ColMoTa.Name = "ColMoTa";
            ColMoTa.ReadOnly = true;
            // 
            // ColTrangThai
            // 
            ColTrangThai.HeaderText = "Trạng Thái ";
            ColTrangThai.MinimumWidth = 140;
            ColTrangThai.Name = "ColTrangThai";
            ColTrangThai.ReadOnly = true;
            // 
            // lblDanhSach
            // 
            lblDanhSach.AutoSize = true;
            lblDanhSach.Font = new Font("Segoe UI", 10F);
            lblDanhSach.Location = new Point(14, 288);
            lblDanhSach.Name = "lblDanhSach";
            lblDanhSach.Size = new Size(221, 23);
            lblDanhSach.TabIndex = 2;
            lblDanhSach.Text = "Danh sách danh mục thuốc";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(223, 292);
            txtTimKiem.Margin = new Padding(3, 4, 3, 4);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(367, 27);
            txtTimKiem.TabIndex = 3;
            // 
            // FormDanhMucThuoc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1403, 817);
            Controls.Add(txtTimKiem);
            Controls.Add(lblDanhSach);
            Controls.Add(dgvDanhMuc);
            Controls.Add(grpDanhMucThuoc);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormDanhMucThuoc";
            Text = "FormDanhMucThuoc";
            grpDanhMucThuoc.ResumeLayout(false);
            grpDanhMucThuoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhMuc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpDanhMucThuoc;
        private TextBox txtMaDanhMuc;
        private Label label1;
        private TextBox txtMoTa;
        private TextBox txtTenDanhMuc;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnLamMoi;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private ComboBox cboTrangThai;
        private DataGridView dgvDanhMuc;
        private Label lblDanhSach;
        private TextBox txtTimKiem;
        private DataGridViewTextBoxColumn ColMaDanhMuc;
        private DataGridViewTextBoxColumn ColTenDanhMuc;
        private DataGridViewTextBoxColumn ColMoTa;
        private DataGridViewTextBoxColumn ColTrangThai;
    }
}