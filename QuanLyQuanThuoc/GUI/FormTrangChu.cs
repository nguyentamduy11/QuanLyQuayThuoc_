using QuanLyQuanThuoc.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyQuanThuoc.Models
{
    public partial class FormTrangChu : Form
    {
        public FormTrangChu()
        {
            InitializeComponent();

        }

        private void FormTrangChu_Load(object sender, EventArgs e)
        {
            int tongSoLuong = 0;
            int soThuocSapHet = 0;
            int sodoanhthu = 0;

            foreach (Thuoc thuoc in KhoThuoc.DanhSach)
            {
                tongSoLuong += thuoc.SoLuong;

                if (thuoc.SoLuong <= 10)
                {
                    soThuocSapHet++;
                }
            }

            lblTongThuoc.Text = $"Tổng Số Thuốc: {tongSoLuong}";
            lblThuocSapHet.Text = $"Thuốc sắp hết: {soThuocSapHet}";
            lblNhaCungCap.Text = "Nhà cung cấp: 12";
            lblDoanhThu.Text = $"Doanh thu hôm nay: {sodoanhthu}";

            dgvCanhBao.Rows.Clear();

            foreach (Thuoc thuoc in KhoThuoc.DanhSach)
            {
                string tinhTrang = thuoc.SoLuong <= 10 ? "Sắp hết hàng" : "Bình thường";
                dgvCanhBao.Rows.Add(
                    thuoc.TenThuoc,
                    thuoc.SoLuong,
                    thuoc.HanSuDung.ToString("dd/MM/yyyy"),
                    tinhTrang);
            }
        }
    }
}

