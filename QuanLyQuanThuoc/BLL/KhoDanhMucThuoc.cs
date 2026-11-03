using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using QuanLyQuanThuoc.DAL;

namespace QuanLyQuanThuoc.BLL
{
    public static class KhoDanhMucThuoc
    {
        public static string? LoiTaiDuLieu { get; private set; }
        public static List<DanhMucThuoc> DanhSach { get; } = Tai();

        private static List<DanhMucThuoc> Tai()
        {
            try
            {
                using var db = new QuanLyQuanThuocContext();
                return db.DanhMucThuocs.AsNoTracking().OrderBy(x => x.MaDanhMuc).ToList();
            }
            catch (Exception ex)
            {
                LoiTaiDuLieu = "Không đọc được bảng dbo.DanhMucThuocs: " + ex.Message;
                return new List<DanhMucThuoc>();
            }
        }

        public static bool Luu(out string loi)
        {
            loi = string.Empty;
            if (LoiTaiDuLieu != null)
            {
                loi = LoiTaiDuLieu;
                return false;
            }
            try
            {
                using var db = new QuanLyQuanThuocContext();
                using var trans = db.Database.BeginTransaction();
                var sql = db.DanhMucThuocs.ToList();
                foreach (var cu in sql)
                {
                    var moi = DanhSach.FirstOrDefault(x => x.MaDanhMuc == cu.MaDanhMuc);
                    if (moi == null) db.DanhMucThuocs.Remove(cu);
                    else db.Entry(cu).CurrentValues.SetValues(moi);
                }
                foreach (var moi in DanhSach)
                    if (!sql.Any(x => x.MaDanhMuc == moi.MaDanhMuc))
                        db.DanhMucThuocs.Add(new DanhMucThuoc
                        {
                            MaDanhMuc = moi.MaDanhMuc, TenDanhMuc = moi.TenDanhMuc,
                            MoTa = moi.MoTa, TrangThai = moi.TrangThai
                        });
                db.SaveChanges();
                trans.Commit();
                return true;
            }
            catch (Exception ex)
            {
                loi = "Lưu bảng dbo.DanhMucThuocs thất bại: " + ex.GetBaseException().Message;
                return false;
            }
        }
    }
}
