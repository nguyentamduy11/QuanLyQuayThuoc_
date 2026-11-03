using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using QuanLyQuanThuoc.DAL;

namespace QuanLyQuanThuoc.BLL
{
    // Lưu hóa đơn và chi tiết vào hai bảng SQL bằng cùng một giao dịch.
    public static class KhoHoaDon
    {
        public static string? LoiTaiDuLieu { get; private set; }
        public static List<HoaDon> DanhSach { get; } = Tai();

        private static List<HoaDon> Tai()
        {
            try
            {
                using var db = new QuanLyQuanThuocContext();
                return db.HoaDon.AsNoTracking().Include(x => x.ChiTiet)
                    .OrderByDescending(x => x.NgayLap).ToList();
            }
            catch (Exception ex)
            {
                LoiTaiDuLieu = "Không đọc được dbo.HoaDon/ChiTietHoaDon trong SQL Server: " + ex.Message;
                return new List<HoaDon>();
            }
        }

        public static bool Luu(out string loi)
        {
            loi = string.Empty;
            if (LoiTaiDuLieu != null)
            {
                loi = LoiTaiDuLieu;  return false;
            }
            try
            {
                using var db = new QuanLyQuanThuocContext();
                using var transaction = db.Database.BeginTransaction();
                var trongSql = db.HoaDon.Include(h => h.ChiTiet).ToList();

                foreach (var cu in trongSql)
                {
                    HoaDon? moi = DanhSach.FirstOrDefault(x => x.MaHoaDon == cu.MaHoaDon);
                    if (moi == null)
                    {
                        db.HoaDon.Remove(cu); // ChiTietHoaDon được xóa theo quan hệ cascade.
                        continue;
                    }
                    db.Entry(cu).CurrentValues.SetValues(moi);
                    // Cập nhật các dòng chi tiết theo khóa (MaHoaDon, MaThuoc).
                    foreach (var ctCu in cu.ChiTiet.ToList())
                    {
                        var ctMoi = moi.ChiTiet.FirstOrDefault(x => x.MaThuoc == ctCu.MaThuoc);
                        if (ctMoi == null) db.ChiTietHoaDon.Remove(ctCu);
                        else db.Entry(ctCu).CurrentValues.SetValues(ctMoi);
                    }
                    foreach (var ctMoi in moi.ChiTiet)
                        if (!cu.ChiTiet.Any(x => x.MaThuoc == ctMoi.MaThuoc))
                            cu.ChiTiet.Add(SaoChep(ctMoi));
                }
                foreach (var moi in DanhSach)
                {
                    if (trongSql.Any(x => x.MaHoaDon == moi.MaHoaDon)) continue;
                    var them = new HoaDon
                    {
                        MaHoaDon = moi.MaHoaDon,
                        NgayLap = moi.NgayLap,
                        TenKhachHang = moi.TenKhachHang,
                        SoDienThoai = moi.SoDienThoai,
                        MaNhanVien = moi.MaNhanVien,
                        TenNhanVien = moi.TenNhanVien,
                        GhiChu = moi.GhiChu,
                        ChiTiet = moi.ChiTiet.Select(SaoChep).ToList()
                    };
                    db.HoaDon.Add(them);
                }
                db.SaveChanges();
                transaction.Commit();
                return true;
            }
            catch (Exception ex)
            {
                loi = "Lưu dbo.HoaDon/ChiTietHoaDon thất bại: " + ex.GetBaseException().Message;
                return false;
            }
        }

        private static ChiTietHoaDon SaoChep(ChiTietHoaDon ct) => new()
        {
            MaThuoc = ct.MaThuoc,
            TenThuoc = ct.TenThuoc,
            DonViTinh = ct.DonViTinh,
            SoLuong = ct.SoLuong,
            DonGia = ct.DonGia
        };
    }
}
