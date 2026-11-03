using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using QuanLyQuanThuoc.DAL;

namespace QuanLyQuanThuoc.BLL
{
    // Dữ liệu đơn vị tính lấy từ SQL Server; giữ API DanhSach/Luu để không phải thiết kế lại Form.
    public static class KhoDonViTinh
    {
        public static string? LoiTaiDuLieu { get; private set; }
        public static List<DonViTinh> DanhSach { get; } = Tai();

        private static List<DonViTinh> Tai()
        {
            try
            {
                using var db = new QuanLyQuanThuocContext();
                return db.DonViTinh.AsNoTracking().OrderBy(x => x.MaDV).ToList();
            }
            catch (Exception ex)
            {
                LoiTaiDuLieu = "Không đọc được bảng dbo.DonViTinh trong SQL Server: " + ex.Message;
                return new List<DonViTinh>();
            }
        }

        // Đồng bộ dữ liệu thay đổi của Form vào bảng dbo.DonViTinh, không dùng JSON.
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
                var trongSql = db.DonViTinh.ToList();
                foreach (var cu in trongSql)
                {
                    var moi = DanhSach.FirstOrDefault(x => x.MaDV == cu.MaDV);
                    if (moi == null) db.DonViTinh.Remove(cu);
                    else db.Entry(cu).CurrentValues.SetValues(moi);
                }
                foreach (var moi in DanhSach)
                    if (!trongSql.Any(x => x.MaDV == moi.MaDV))
                        db.DonViTinh.Add(new DonViTinh
                        {
                            MaDV = moi.MaDV, TenDV = moi.TenDV, MoTa = moi.MoTa
                        });
                db.SaveChanges();
                transaction.Commit();
                return true;
            }
            catch (Exception ex)
            {
                loi = "Lưu dbo.DonViTinh thất bại: " + ex.GetBaseException().Message;
                return false;
            }
        }
    }
}
