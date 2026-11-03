namespace QuanLyQuanThuoc.Models
{
    partial class FormTrangChu
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
            lblTieuDe = new Label();
            tblThongKe = new TableLayoutPanel();
            pnlTongThuoc = new Panel();
            lblTongThuoc = new Label();
            pnlThuocSapHet = new Panel();
            lblThuocSapHet = new Label();
            pnlNhaCungCap = new Panel();
            lblNhaCungCap = new Label();
            pnlDoanhThu = new Panel();
            lblDoanhThu = new Label();
            lblCanhBao = new Label();
            dgvCanhBao = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            tblThongKe.SuspendLayout();
            pnlTongThuoc.SuspendLayout();
            pnlThuocSapHet.SuspendLayout();
            pnlNhaCungCap.SuspendLayout();
            pnlDoanhThu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCanhBao).BeginInit();
            SuspendLayout();
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Dock = DockStyle.Top;
            lblTieuDe.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.FromArgb(30, 64, 175);
            lblTieuDe.Location = new Point(0, 0);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(124, 30);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "Trang Chủ ";
            // 
            // tblThongKe
            // 
            tblThongKe.ColumnCount = 2;
            tblThongKe.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblThongKe.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblThongKe.Controls.Add(pnlTongThuoc, 0, 0);
            tblThongKe.Controls.Add(pnlThuocSapHet, 1, 0);
            tblThongKe.Controls.Add(pnlNhaCungCap, 0, 1);
            tblThongKe.Controls.Add(pnlDoanhThu, 1, 1);
            tblThongKe.Dock = DockStyle.Top;
            tblThongKe.Location = new Point(0, 30);
            tblThongKe.Margin = new Padding(3, 2, 3, 2);
            tblThongKe.Name = "tblThongKe";
            tblThongKe.RowCount = 2;
            tblThongKe.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblThongKe.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblThongKe.Size = new Size(700, 255);
            tblThongKe.TabIndex = 1;
            // 
            // pnlTongThuoc
            // 
            pnlTongThuoc.BackColor = Color.FromArgb(219, 234, 254);
            pnlTongThuoc.Controls.Add(lblTongThuoc);
            pnlTongThuoc.Dock = DockStyle.Fill;
            pnlTongThuoc.Location = new Point(10, 9);
            pnlTongThuoc.Margin = new Padding(10, 9, 10, 9);
            pnlTongThuoc.Name = "pnlTongThuoc";
            pnlTongThuoc.Size = new Size(330, 109);
            pnlTongThuoc.TabIndex = 0;
            // 
            // lblTongThuoc
            // 
            lblTongThuoc.AutoSize = true;
            lblTongThuoc.Dock = DockStyle.Top;
            lblTongThuoc.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTongThuoc.ForeColor = Color.Black;
            lblTongThuoc.Location = new Point(0, 0);
            lblTongThuoc.Name = "lblTongThuoc";
            lblTongThuoc.Size = new Size(109, 20);
            lblTongThuoc.TabIndex = 0;
            lblTongThuoc.Text = "Tổng số thuốc";
            // 
            // pnlThuocSapHet
            // 
            pnlThuocSapHet.BackColor = Color.FromArgb(254, 226, 226);
            pnlThuocSapHet.Controls.Add(lblThuocSapHet);
            pnlThuocSapHet.Dock = DockStyle.Fill;
            pnlThuocSapHet.Location = new Point(360, 9);
            pnlThuocSapHet.Margin = new Padding(10, 9, 10, 9);
            pnlThuocSapHet.Name = "pnlThuocSapHet";
            pnlThuocSapHet.Size = new Size(330, 109);
            pnlThuocSapHet.TabIndex = 1;
            // 
            // lblThuocSapHet
            // 
            lblThuocSapHet.AutoSize = true;
            lblThuocSapHet.Dock = DockStyle.Top;
            lblThuocSapHet.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblThuocSapHet.ForeColor = Color.Black;
            lblThuocSapHet.Location = new Point(0, 0);
            lblThuocSapHet.Name = "lblThuocSapHet";
            lblThuocSapHet.Size = new Size(107, 20);
            lblThuocSapHet.TabIndex = 0;
            lblThuocSapHet.Text = "Thuốc sắp hết";
            // 
            // pnlNhaCungCap
            // 
            pnlNhaCungCap.BackColor = Color.FromArgb(209, 250, 229);
            pnlNhaCungCap.Controls.Add(lblNhaCungCap);
            pnlNhaCungCap.Dock = DockStyle.Fill;
            pnlNhaCungCap.Location = new Point(10, 136);
            pnlNhaCungCap.Margin = new Padding(10, 9, 10, 9);
            pnlNhaCungCap.Name = "pnlNhaCungCap";
            pnlNhaCungCap.Size = new Size(330, 110);
            pnlNhaCungCap.TabIndex = 2;
            // 
            // lblNhaCungCap
            // 
            lblNhaCungCap.AutoSize = true;
            lblNhaCungCap.Dock = DockStyle.Top;
            lblNhaCungCap.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblNhaCungCap.ForeColor = Color.Black;
            lblNhaCungCap.Location = new Point(0, 0);
            lblNhaCungCap.Name = "lblNhaCungCap";
            lblNhaCungCap.Size = new Size(104, 20);
            lblNhaCungCap.TabIndex = 0;
            lblNhaCungCap.Text = "Nhà cung cấp";
            // 
            // pnlDoanhThu
            // 
            pnlDoanhThu.BackColor = Color.FromArgb(237, 233, 254);
            pnlDoanhThu.Controls.Add(lblDoanhThu);
            pnlDoanhThu.Dock = DockStyle.Fill;
            pnlDoanhThu.Location = new Point(360, 136);
            pnlDoanhThu.Margin = new Padding(10, 9, 10, 9);
            pnlDoanhThu.Name = "pnlDoanhThu";
            pnlDoanhThu.Size = new Size(330, 110);
            pnlDoanhThu.TabIndex = 3;
            // 
            // lblDoanhThu
            // 
            lblDoanhThu.AutoSize = true;
            lblDoanhThu.Dock = DockStyle.Top;
            lblDoanhThu.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblDoanhThu.ForeColor = Color.Black;
            lblDoanhThu.Location = new Point(0, 0);
            lblDoanhThu.Name = "lblDoanhThu";
            lblDoanhThu.Size = new Size(148, 20);
            lblDoanhThu.TabIndex = 0;
            lblDoanhThu.Text = "Doanh thu hôm nay";
            // 
            // lblCanhBao
            // 
            lblCanhBao.AutoSize = true;
            lblCanhBao.Dock = DockStyle.Top;
            lblCanhBao.Font = new Font("Segoe UI", 12F);
            lblCanhBao.Location = new Point(0, 285);
            lblCanhBao.Name = "lblCanhBao";
            lblCanhBao.Size = new Size(121, 21);
            lblCanhBao.TabIndex = 2;
            lblCanhBao.Text = "Thuốc cần chú ý";
            // 
            // dgvCanhBao
            // 
            dgvCanhBao.AllowUserToAddRows = false;
            dgvCanhBao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCanhBao.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(37, 99, 235);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(37, 99, 235);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCanhBao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCanhBao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCanhBao.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(31, 41, 55);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(31, 41, 55);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvCanhBao.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCanhBao.Dock = DockStyle.Fill;
            dgvCanhBao.EnableHeadersVisualStyles = false;
            dgvCanhBao.GridColor = Color.FromArgb(209, 213, 219);
            dgvCanhBao.Location = new Point(0, 306);
            dgvCanhBao.Margin = new Padding(3, 2, 3, 2);
            dgvCanhBao.Name = "dgvCanhBao";
            dgvCanhBao.ReadOnly = true;
            dgvCanhBao.RowHeadersVisible = false;
            dgvCanhBao.RowHeadersWidth = 51;
            dgvCanhBao.Size = new Size(700, 207);
            dgvCanhBao.TabIndex = 3;
            // 
            // Column1
            // 
            Column1.HeaderText = "Tên Thuốc ";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Số Lượng";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Ngày Hết Hạn";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Tình Trạng";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // FormTrangChu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(700, 513);
            Controls.Add(dgvCanhBao);
            Controls.Add(lblCanhBao);
            Controls.Add(tblThongKe);
            Controls.Add(lblTieuDe);
            ForeColor = Color.FromArgb(31, 41, 55);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormTrangChu";
            Text = "FormTrangChu";
            Load += FormTrangChu_Load;
            tblThongKe.ResumeLayout(false);
            pnlTongThuoc.ResumeLayout(false);
            pnlTongThuoc.PerformLayout();
            pnlThuocSapHet.ResumeLayout(false);
            pnlThuocSapHet.PerformLayout();
            pnlNhaCungCap.ResumeLayout(false);
            pnlNhaCungCap.PerformLayout();
            pnlDoanhThu.ResumeLayout(false);
            pnlDoanhThu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCanhBao).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTieuDe;
        private TableLayoutPanel tblThongKe;
        private Panel pnlTongThuoc;
        private Panel pnlThuocSapHet;
        private Panel pnlNhaCungCap;
        private Panel pnlDoanhThu;
        private Label lblTongThuoc;
        private Label lblThuocSapHet;
        private Label lblNhaCungCap;
        private Label lblDoanhThu;
        private Label lblCanhBao;
        private DataGridView dgvCanhBao;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}