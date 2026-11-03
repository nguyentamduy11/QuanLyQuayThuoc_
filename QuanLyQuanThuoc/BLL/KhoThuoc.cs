using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using QuanLyQuanThuoc.DAL;

namespace QuanLyQuanThuoc.BLL
{
    // Nguồn dữ liệu thuốc duy nhất: bảng dbo.Thuoc của SQL Server.
    public static class KhoThuoc
    {
        public static string? LoiTaiDuLieu { get; private set; }
        public static List<Thuoc> DanhSach { get; } = Tai();

        private static List<Thuoc> Tai()
        {
            try
            {
                using var db = new QuanLyQuanThuocContext();
                return db.Thuoc.AsNoTracking().OrderBy(x => x.MaThuoc).ToList();
            }
            catch (Exception ex)
            {
                LoiTaiDuLieu = "Không đọc được bảng dbo.Thuoc trong SQL Server: " + ex.Message;
                return new List<Thuoc>();
            }
        }

        public static bool Luu(out string loi)
        {
            loi = string.Empty;
            if (LoiTaiDuLieu != null)
            {
                loi = LoiTaiDuLieu + "\nKhông thể lưu khi dữ liệu SQL chưa tải được.";
                return false;
            }
            try
            {
                using var db = new QuanLyQuanThuocContext();
                using var transaction = db.Database.BeginTransaction();
                var trongSql = db.Thuoc.ToList();
                foreach (var cu in trongSql)
                {
                    var moi = DanhSach.FirstOrDefault(x => x.MaThuoc == cu.MaThuoc);
                    if (moi == null) db.Thuoc.Remove(cu);
                    else db.Entry(cu).CurrentValues.SetValues(moi);
                }
                foreach (var moi in DanhSach)
                    if (!trongSql.Any(x => x.MaThuoc == moi.MaThuoc))
                        db.Thuoc.Add(new Thuoc
                        {
                            MaThuoc = moi.MaThuoc, TenThuoc = moi.TenThuoc,
                            DonViTinh = moi.DonViTinh, SoLuong = moi.SoLuong,
                            DonGia = moi.DonGia, HanSuDung = moi.HanSuDung
                        });
                db.SaveChanges();
                transaction.Commit();
                return true;
            }
            catch (Exception ex)
            {
                loi = "Lưu dbo.Thuoc thất bại: " + ex.GetBaseException().Message;
                return false;
            }
        }
    }
}
