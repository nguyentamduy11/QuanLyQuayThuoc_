using System;

namespace QuanLyQuanThuoc.BLL
{
    // Thông tin của một nhân viên trong quầy thuốc.
    public class NhanVien
    {
        public string MaNhanVien { get; set; } = string.Empty;
        public string HoTen { get; set; } = string.Empty;
        public string GioiTinh { get; set; } = string.Empty;
        public DateTime NgaySinh { get; set; }
        public string SoDienThoai { get; set; } = string.Empty;
        public string ChucVu { get; set; } = string.Empty;
        public string DiaChi { get; set; } = string.Empty;
        public string TrangThai { get; set; } = string.Empty;
    }
}
