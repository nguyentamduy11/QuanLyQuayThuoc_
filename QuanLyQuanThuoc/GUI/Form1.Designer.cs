namespace QuanLyQuanThuoc
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelContent = new Panel();
            panelNoiDung = new Panel();
            panelHeader = new Panel();
            lblPhuDe = new Label();
            lblTieuDe = new Label();
            panelMenu = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnTrangChu = new Button();
            btnThuoc = new Button();
            btnDanhMuc = new Button();
            btnDonViTinh = new Button();
            btnHoaDon = new Button();
            btnNhanVien = new Button();
            btnThoat = new Button();
            panelContent.SuspendLayout();
            panelHeader.SuspendLayout();
            panelMenu.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelContent
            // 
            panelContent.Controls.Add(panelNoiDung);
            panelContent.Controls.Add(panelHeader);
            panelContent.Controls.Add(panelMenu);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Font = new Font("Segoe UI", 11F);
            panelContent.ForeColor = Color.White;
            panelContent.Location = new Point(0, 0);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1442, 866);
            panelContent.TabIndex = 0;
            // 
            // panelNoiDung
            // 
            panelNoiDung.Dock = DockStyle.Fill;
            panelNoiDung.Location = new Point(230, 99);
            panelNoiDung.Name = "panelNoiDung";
            panelNoiDung.Size = new Size(1212, 767);
            panelNoiDung.TabIndex = 2;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.RoyalBlue;
            panelHeader.Controls.Add(lblPhuDe);
            panelHeader.Controls.Add(lblTieuDe);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(230, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1212, 99);
            panelHeader.TabIndex = 1;
            // 
            // lblPhuDe
            // 
            lblPhuDe.AutoSize = true;
            lblPhuDe.Location = new Point(345, 55);
            lblPhuDe.Name = "lblPhuDe";
            lblPhuDe.Size = new Size(247, 25);
            lblPhuDe.TabIndex = 1;
            lblPhuDe.Text = "Hệ thống quản lý nhà thuốc";
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Segoe UI", 20F);
            lblTieuDe.ForeColor = Color.White;
            lblTieuDe.Location = new Point(256, 9);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(416, 46);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "✚ QUẢN LÝ QUẦY THUỐC";
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(240, 247, 255);
            panelMenu.Controls.Add(flowLayoutPanel1);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(230, 866);
            panelMenu.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnTrangChu);
            flowLayoutPanel1.Controls.Add(btnThuoc);
            flowLayoutPanel1.Controls.Add(btnDanhMuc);
            flowLayoutPanel1.Controls.Add(btnDonViTinh);
            flowLayoutPanel1.Controls.Add(btnHoaDon);
            flowLayoutPanel1.Controls.Add(btnNhanVien);
            flowLayoutPanel1.Controls.Add(btnThoat);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(15, 20, 0, 0);
            flowLayoutPanel1.Size = new Size(230, 866);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.WrapContents = false;
            // 
            // btnTrangChu
            // 
            btnTrangChu.BackColor = Color.CornflowerBlue;
            btnTrangChu.FlatStyle = FlatStyle.Flat;
            btnTrangChu.Location = new Point(15, 20);
            btnTrangChu.Margin = new Padding(0, 0, 0, 14);
            btnTrangChu.Name = "btnTrangChu";
            btnTrangChu.Size = new Size(200, 46);
            btnTrangChu.TabIndex = 0;
            btnTrangChu.Text = "Trang Chủ ";
            btnTrangChu.UseVisualStyleBackColor = false;
            btnTrangChu.Click += btnTrangChu_Click;
            // 
            // btnThuoc
            // 
            btnThuoc.BackColor = Color.CornflowerBlue;
            btnThuoc.FlatStyle = FlatStyle.Flat;
            btnThuoc.Location = new Point(15, 80);
            btnThuoc.Margin = new Padding(0, 0, 0, 14);
            btnThuoc.Name = "btnThuoc";
            btnThuoc.Size = new Size(200, 46);
            btnThuoc.TabIndex = 1;
            btnThuoc.Text = "Quản Lý Thuốc ";
            btnThuoc.UseVisualStyleBackColor = false;
            btnThuoc.Click += btnThuoc_Click;
            // 
            // btnDanhMuc
            // 
            btnDanhMuc.BackColor = Color.CornflowerBlue;
            btnDanhMuc.FlatStyle = FlatStyle.Flat;
            btnDanhMuc.Location = new Point(15, 140);
            btnDanhMuc.Margin = new Padding(0, 0, 0, 14);
            btnDanhMuc.Name = "btnDanhMuc";
            btnDanhMuc.Size = new Size(200, 46);
            btnDanhMuc.TabIndex = 2;
            btnDanhMuc.Text = "Danh Mục Thuốc ";
            btnDanhMuc.UseVisualStyleBackColor = false;
            btnDanhMuc.Click += btnDanhMuc_Click;
            // 
            // btnDonViTinh
            // 
            btnDonViTinh.BackColor = Color.CornflowerBlue;
            btnDonViTinh.FlatStyle = FlatStyle.Flat;
            btnDonViTinh.Location = new Point(15, 200);
            btnDonViTinh.Margin = new Padding(0, 0, 0, 14);
            btnDonViTinh.Name = "btnDonViTinh";
            btnDonViTinh.Size = new Size(200, 46);
            btnDonViTinh.TabIndex = 3;
            btnDonViTinh.Text = "Đơn Vị Tính";
            btnDonViTinh.UseVisualStyleBackColor = false;
            btnDonViTinh.Click += btnDonViTinh_Click;
            // 
            // btnHoaDon
            // 
            btnHoaDon.BackColor = Color.CornflowerBlue;
            btnHoaDon.FlatStyle = FlatStyle.Flat;
            btnHoaDon.Location = new Point(15, 260);
            btnHoaDon.Margin = new Padding(0, 0, 0, 14);
            btnHoaDon.Name = "btnHoaDon";
            btnHoaDon.Size = new Size(200, 46);
            btnHoaDon.TabIndex = 4;
            btnHoaDon.Text = "Hoá Đơn";
            btnHoaDon.UseVisualStyleBackColor = false;
            btnHoaDon.Click += btnHoaDon_Click;
            // 
            // btnNhanVien
            // 
            btnNhanVien.BackColor = Color.CornflowerBlue;
            btnNhanVien.FlatStyle = FlatStyle.Flat;
            btnNhanVien.Location = new Point(15, 320);
            btnNhanVien.Margin = new Padding(0, 0, 0, 14);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Size = new Size(200, 46);
            btnNhanVien.TabIndex = 5;
            btnNhanVien.Text = "Nhân Viên";
            btnNhanVien.UseVisualStyleBackColor = false;
            btnNhanVien.Click += btnNhanVien_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.CornflowerBlue;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(15, 380);
            btnThoat.Margin = new Padding(0, 0, 0, 14);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(200, 46);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1442, 866);
            Controls.Add(panelContent);
            Font = new Font("Segoe UI", 10F);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panelContent.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelMenu.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);

            // Các thuộc tính giao diện này có thể chỉnh bằng Properties (F4) trong View Designer.
            panelContent.BackColor = Color.FromArgb(245, 247, 250);
            panelMenu.BackColor = Color.FromArgb(15, 23, 42);
            panelHeader.BackColor = Color.FromArgb(30, 64, 175);
            lblTieuDe.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblPhuDe.Font = new Font("Segoe UI", 11F);
            lblPhuDe.ForeColor = Color.FromArgb(219, 234, 254);
            btnTrangChu.BackColor = Color.FromArgb(37, 99, 235);
            btnTrangChu.FlatStyle = FlatStyle.Flat;
            btnTrangChu.FlatAppearance.BorderSize = 0;
            btnTrangChu.ForeColor = Color.White;
            btnTrangChu.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnTrangChu.Cursor = Cursors.Hand;
            btnThuoc.BackColor = Color.FromArgb(37, 99, 235);
            btnThuoc.FlatStyle = FlatStyle.Flat;
            btnThuoc.FlatAppearance.BorderSize = 0;
            btnThuoc.ForeColor = Color.White;
            btnThuoc.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnThuoc.Cursor = Cursors.Hand;
            btnDanhMuc.BackColor = Color.FromArgb(37, 99, 235);
            btnDanhMuc.FlatStyle = FlatStyle.Flat;
            btnDanhMuc.FlatAppearance.BorderSize = 0;
            btnDanhMuc.ForeColor = Color.White;
            btnDanhMuc.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDanhMuc.Cursor = Cursors.Hand;
            btnDonViTinh.BackColor = Color.FromArgb(37, 99, 235);
            btnDonViTinh.FlatStyle = FlatStyle.Flat;
            btnDonViTinh.FlatAppearance.BorderSize = 0;
            btnDonViTinh.ForeColor = Color.White;
            btnDonViTinh.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDonViTinh.Cursor = Cursors.Hand;
            btnHoaDon.BackColor = Color.FromArgb(37, 99, 235);
            btnHoaDon.FlatStyle = FlatStyle.Flat;
            btnHoaDon.FlatAppearance.BorderSize = 0;
            btnHoaDon.ForeColor = Color.White;
            btnHoaDon.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnHoaDon.Cursor = Cursors.Hand;
            btnNhanVien.BackColor = Color.FromArgb(37, 99, 235);
            btnNhanVien.FlatStyle = FlatStyle.Flat;
            btnNhanVien.FlatAppearance.BorderSize = 0;
            btnNhanVien.ForeColor = Color.White;
            btnNhanVien.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNhanVien.Cursor = Cursors.Hand;
            btnThoat.BackColor = Color.FromArgb(37, 99, 235);
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.FlatAppearance.BorderSize = 0;
            btnThoat.ForeColor = Color.White;
            btnThoat.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnThoat.Cursor = Cursors.Hand;
            btnThoat.BackColor = Color.FromArgb(220, 38, 38);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContent;
        private Panel panelNoiDung;
        private Panel panelHeader;
        private Panel panelMenu;
        private Label lblTieuDe;
        private Label lblPhuDe;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnTrangChu;
        private Button btnThuoc;
        private Button btnDanhMuc;
        private Button btnDonViTinh;
        private Button btnHoaDon;
        private Button btnNhanVien;
        private Button btnThoat;
    }
}
