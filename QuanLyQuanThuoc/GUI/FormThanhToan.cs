using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using QuanLyQuanThuoc.BLL;
using System.Linq;

namespace QuanLyQuanThuoc.GUI
{
    public partial class FormThanhToan : Form

    {
        private string maDH = " ";
        public FormThanhToan(string mahoadon, decimal tongtien)
        {
            InitializeComponent();
            maDH = mahoadon;
            lblMaHoaDon.Text = "Ma Hoa Don:  " + mahoadon;
            lblTongTien.Text = $" Tong tien phai thanh toan: {tongtien:N0} VND";
            picQR.SizeMode = PictureBoxSizeMode.Zoom;

        }
        

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            var hd = KhoHoaDon.DanhSach.FirstOrDefault(x =>
     string.Equals(
         x.MaHoaDon?.Trim(),
         maDH.Trim(),
         StringComparison.OrdinalIgnoreCase));
            

            if (hd == null)
            {
                MessageBox.Show("Không tìm thấy hóa đơn!");
                return;
            }

            if (hd.TrangThaiThanhToan == "Đã thanh toán")
            {
                MessageBox.Show("Hóa đơn đã thanh toán!");
                return;
            }

            DialogResult kq = MessageBox.Show(
                "Bạn đã kiểm tra và xác nhận nhận đủ tiền?",
                "Xác nhận thanh toán",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (kq != DialogResult.Yes)
                return;

            string trangThaiCu = hd.TrangThaiThanhToan;

            hd.TrangThaiThanhToan = "Đã thanh toán";

            if (KhoHoaDon.Luu(out string loi))
            {
                MessageBox.Show("Xác nhận thanh toán thành công!");
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                hd.TrangThaiThanhToan = trangThaiCu;
                MessageBox.Show("Lỗi lưu dữ liệu: " + loi);
            }
        }
    }
}
        
    

