
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using QuanLyQuanThuoc.DAL;

namespace QuanLyQuanThuoc.BLL
{
    public static class KhoNhanVien
    {
        public static string? LoiTaiDuLieu { get; private set; }

        // Danh sách nhân viên lấy từ SQL
        public static List<NhanVien> DanhSach { get; }
            = TaiDuLieu();

        // Đọc dữ liệu từ SQL
        private static List<NhanVien> TaiDuLieu()
        {
            try
            {
                using var db = new QuanLyQuanThuocContext();

                return db.NhanVien
                    .AsNoTracking()
                    .ToList();
            }
            catch (Exception ex)
            {
                LoiTaiDuLieu = ex.Message;
                return new List<NhanVien>();
            }
        }

        // Lưu danh sách nhân viên vào SQL
        public static bool LuuDuLieu(out string thongBaoLoi)
        {
            thongBaoLoi = "";

            if (LoiTaiDuLieu != null)
            {
                thongBaoLoi = LoiTaiDuLieu;
                return false;
            }

            try
            {
                using var db = new QuanLyQuanThuocContext();

                var duLieuSQL = db.NhanVien.ToList();

                // Xóa hoặc sửa nhân viên
                foreach (var nvSQL in duLieuSQL)
                {
                    var nvMoi = DanhSach.FirstOrDefault(
                        x => x.MaNhanVien == nvSQL.MaNhanVien);

                    if (nvMoi == null)
                    {
                        db.NhanVien.Remove(nvSQL);
                    }
                    else
                    {
                        db.Entry(nvSQL)
                          .CurrentValues.SetValues(nvMoi);
                    }
                }

                // Thêm nhân viên mới
                foreach (var nv in DanhSach)
                {
                    bool daCo = duLieuSQL.Any(
                        x => x.MaNhanVien == nv.MaNhanVien);

                    if (!daCo)
                    {
                        db.NhanVien.Add(nv);
                    }
                }

                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                thongBaoLoi = ex.Message;
                return false;
            }
        }
    }
}
