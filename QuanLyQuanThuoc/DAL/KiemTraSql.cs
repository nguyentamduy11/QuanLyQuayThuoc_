using System;
using Microsoft.EntityFrameworkCore;

namespace QuanLyQuanThuoc.DAL
{
    public static class KiemTraSql
    {
        // Không tạo hay sửa database tự động: chỉ xác minh database hiện tại có các bảng cần thiết.
        public static bool ThuKetNoi(out string ketQua)
        {
            try
            {
                using var db = new QuanLyQuanThuocContext();
                db.Database.OpenConnection();
                using var cmd = db.Database.GetDbConnection().CreateCommand();
                cmd.CommandText = @"SELECT CASE WHEN
                    OBJECT_ID(N'dbo.Thuoc', N'U') IS NOT NULL AND
                    OBJECT_ID(N'dbo.DonViTinh', N'U') IS NOT NULL AND
                    OBJECT_ID(N'dbo.HoaDon', N'U') IS NOT NULL AND
                    OBJECT_ID(N'dbo.ChiTietHoaDon', N'U') IS NOT NULL AND
                    OBJECT_ID(N'dbo.NhanVien', N'U') IS NOT NULL AND
                    OBJECT_ID(N'dbo.DanhMucThuocs', N'U') IS NOT NULL
                    THEN 1 ELSE 0 END";
                bool duBang = Convert.ToInt32(cmd.ExecuteScalar()) == 1;
                ketQua = duBang
                    ? "Kết nối thành công: (localdb)\\MSSQLLocalDB / QuanLyQuanThuoc."
                    : "Đã kết nối SQL nhưng thiếu bảng. Kiểm tra dbo.Thuoc, DonViTinh, HoaDon, ChiTietHoaDon, NhanVien, DanhMucThuocs.";
                return duBang;
            }
            catch (Exception ex)
            {
                ketQua = "Không kết nối được SQL Server (localdb)\\MSSQLLocalDB, database QuanLyQuanThuoc.\n" +
                    ex.GetBaseException().Message;
                return false;
            }
        }
    }
}
