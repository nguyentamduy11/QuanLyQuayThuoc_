using System;
using System.Collections.Generic;
using System.Linq;

namespace QuanLyQuanThuoc.BLL
{
   
    public class ChiTietHoaDon
    {
        public string MaThuoc { get; set; } = string.Empty;
        public string TenThuoc { get; set; } = string.Empty;
        public string DonViTinh { get; set; } = string.Empty;
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public decimal ThanhTien => SoLuong * DonGia;

    }

    public class HoaDon
    {
        public string MaHoaDon { get; set; } = string.Empty;
        public DateTime NgayLap { get; set; } = DateTime.Today;
        public string TenKhachHang { get; set; } = string.Empty;
        public string SoDienThoai { get; set; } = string.Empty;
        public string MaNhanVien { get; set; } = string.Empty;
        public string TenNhanVien { get; set; } = string.Empty;
        public string GhiChu { get; set; } = string.Empty;
        public List<ChiTietHoaDon> ChiTiet { get; set; } = new();
        public decimal TongTien => ChiTiet?.Sum(ct => ct.ThanhTien) ?? 0;

        public string TrangThaiThanhToan { get; internal set; } = " chua thanh toan";
    }
}
