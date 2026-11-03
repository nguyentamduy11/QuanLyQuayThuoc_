namespace QuanLyQuanThuoc.GUI
{
    partial class FormDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDangNhap));
            panelTrai = new Panel();
            picLogo = new PictureBox();
            panelPhai = new Panel();
            btnThoat = new Button();
            btnDangNhap = new Button();
            chkHienMatKhau = new CheckBox();
            txtMatKhau = new TextBox();
            lblMatKhau = new Label();
            txtTaiKhoan = new TextBox();
            lblTaiKhoan = new Label();
            lblTieuDe = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            panelTrai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            panelPhai.SuspendLayout();
            SuspendLayout();
            // 
            // panelTrai
            // 
            panelTrai.BackColor = Color.RoyalBlue;
            panelTrai.Controls.Add(picLogo);
            panelTrai.Dock = DockStyle.Left;
            panelTrai.Location = new Point(0, 0);
            panelTrai.MinimumSize = new Size(360, 0);
            panelTrai.Name = "panelTrai";
            panelTrai.Size = new Size(360, 522);
            panelTrai.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.Transparent;
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(26, 89);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(299, 309);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // panelPhai
            // 
            panelPhai.Controls.Add(btnThoat);
            panelPhai.Controls.Add(btnDangNhap);
            panelPhai.Controls.Add(chkHienMatKhau);
            panelPhai.Controls.Add(txtMatKhau);
            panelPhai.Controls.Add(lblMatKhau);
            panelPhai.Controls.Add(txtTaiKhoan);
            panelPhai.Controls.Add(lblTaiKhoan);
            panelPhai.Controls.Add(lblTieuDe);
            panelPhai.Dock = DockStyle.Fill;
            panelPhai.Font = new Font("Segoe UI", 12F);
            panelPhai.Location = new Point(360, 0);
            panelPhai.Name = "panelPhai";
            panelPhai.Size = new Size(524, 522);
            panelPhai.TabIndex = 1;
            panelPhai.Paint += panelPhai_Paint;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(112, 367);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(206, 36);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnDangNhap
            // 
            btnDangNhap.Location = new Point(112, 326);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(206, 35);
            btnDangNhap.TabIndex = 6;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // chkHienMatKhau
            // 
            chkHienMatKhau.AutoSize = true;
            chkHienMatKhau.Font = new Font("Microsoft Sans Serif", 8.25F);
            chkHienMatKhau.Location = new Point(65, 288);
            chkHienMatKhau.Name = "chkHienMatKhau";
            chkHienMatKhau.Size = new Size(98, 17);
            chkHienMatKhau.TabIndex = 5;
            chkHienMatKhau.Text = "Hiện mật khẩu ";
            chkHienMatKhau.UseVisualStyleBackColor = true;
            chkHienMatKhau.CheckedChanged += chkHienMatKhau_CheckedChanged;
            // 
            // txtMatKhau
            // 
            txtMatKhau.BorderStyle = BorderStyle.FixedSingle;
            txtMatKhau.Location = new Point(65, 253);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PlaceholderText = "Nhập mật khẩu...";
            txtMatKhau.Size = new Size(300, 29);
            txtMatKhau.TabIndex = 4;
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Font = new Font("Segoe UI", 11F);
            lblMatKhau.Location = new Point(65, 220);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(80, 20);
            lblMatKhau.TabIndex = 3;
            lblMatKhau.Text = "Mật Khẩu  ";
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.BorderStyle = BorderStyle.FixedSingle;
            txtTaiKhoan.Location = new Point(65, 175);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.PlaceholderText = "Nhập tài khoản...";
            txtTaiKhoan.Size = new Size(300, 29);
            txtTaiKhoan.TabIndex = 2;
            // 
            // lblTaiKhoan
            // 
            lblTaiKhoan.AutoSize = true;
            lblTaiKhoan.Font = new Font("Segoe UI", 11F);
            lblTaiKhoan.Location = new Point(65, 145);
            lblTaiKhoan.Name = "lblTaiKhoan";
            lblTaiKhoan.Size = new Size(71, 20);
            lblTaiKhoan.TabIndex = 1;
            lblTaiKhoan.Text = "Tài khoản";
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Segoe UI", 22F);
            lblTieuDe.Location = new Point(144, 54);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(188, 41);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "ĐĂNG NHẬP";
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // FormDangNhap
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(884, 522);
            Controls.Add(panelPhai);
            Controls.Add(panelTrai);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Quầy Thuốc";
            panelTrai.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            panelPhai.ResumeLayout(false);
            panelPhai.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTrai;
        private PictureBox picLogo;
        private Panel panelPhai;
        private Label lblTieuDe;
        private Label lblTaiKhoan;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private TextBox txtMatKhau;
        private Label lblMatKhau;
        private TextBox txtTaiKhoan;
        private CheckBox chkHienMatKhau;
        private Button btnThoat;
        private Button btnDangNhap;
    }
}