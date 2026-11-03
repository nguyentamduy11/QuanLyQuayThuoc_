namespace QuanLyQuanThuoc.GUI
{
    partial class FormThanhToan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThanhToan));
            panel1 = new Panel();
            lblTieuDe = new Label();
            lblMaHoaDon = new Label();
            lblTongTien = new Label();
            picQR = new PictureBox();
            label1 = new Label();
            btnDong = new Button();
            btnXacNhan = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picQR).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(lblTieuDe);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(967, 119);
            panel1.TabIndex = 0;
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblTieuDe.ForeColor = SystemColors.ButtonFace;
            lblTieuDe.Location = new Point(385, 37);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(210, 37);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "Thanh Toán QR";
            // 
            // lblMaHoaDon
            // 
            lblMaHoaDon.AutoSize = true;
            lblMaHoaDon.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblMaHoaDon.Location = new Point(357, 122);
            lblMaHoaDon.Name = "lblMaHoaDon";
            lblMaHoaDon.Size = new Size(0, 30);
            lblMaHoaDon.TabIndex = 1;
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblTongTien.Location = new Point(270, 163);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(0, 30);
            lblTongTien.TabIndex = 2;
            // 
            // picQR
            // 
            picQR.ErrorImage = null;
            picQR.Image = (Image)resources.GetObject("picQR.Image");
            picQR.InitialImage = null;
            picQR.Location = new Point(226, 196);
            picQR.Name = "picQR";
            picQR.Size = new Size(544, 545);
            picQR.SizeMode = PictureBoxSizeMode.Zoom;
            picQR.TabIndex = 3;
            picQR.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(381, 744);
            label1.Name = "label1";
            label1.Size = new Size(240, 28);
            label1.TabIndex = 4;
            label1.Text = "Quét bằng mã ngân hàng ";
            // 
            // btnDong
            // 
            btnDong.BackColor = SystemColors.HotTrack;
            btnDong.FlatStyle = FlatStyle.Flat;
            btnDong.Font = new Font("Segoe UI", 15F);
            btnDong.ForeColor = SystemColors.ButtonHighlight;
            btnDong.Location = new Point(226, 824);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(544, 43);
            btnDong.TabIndex = 5;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = false;
            btnDong.Click += btnDong_Click;
            // 
            // btnXacNhan
            // 
            btnXacNhan.BackColor = SystemColors.HotTrack;
            btnXacNhan.FlatStyle = FlatStyle.Flat;
            btnXacNhan.Font = new Font("Segoe UI", 15F);
            btnXacNhan.ForeColor = SystemColors.ButtonHighlight;
            btnXacNhan.Location = new Point(226, 775);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(544, 43);
            btnXacNhan.TabIndex = 6;
            btnXacNhan.Text = "Xác Nhận Thanh Toán";
            btnXacNhan.UseVisualStyleBackColor = false;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // FormThanhToan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(967, 870);
            Controls.Add(btnXacNhan);
            Controls.Add(btnDong);
            Controls.Add(label1);
            Controls.Add(picQR);
            Controls.Add(lblTongTien);
            Controls.Add(lblMaHoaDon);
            Controls.Add(panel1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "FormThanhToan";
            Text = "FormThanhToan";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picQR).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblTieuDe;
        private Label lblMaHoaDon;
        private Label lblTongTien;
        private PictureBox picQR;
        private Label label1;
        private Button btnDong;
        private Button btnXacNhan;
    }
}