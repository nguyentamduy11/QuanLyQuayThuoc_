USE [QuanLyQuanThuoc];
GO
SELECT DB_NAME() AS DatabaseDangDung, @@SERVERNAME AS ServerDangDung;
SELECT N'DonViTinh' AS Bang, COUNT(*) AS SoBanGhi FROM dbo.DonViTinh
UNION ALL SELECT N'Thuoc', COUNT(*) FROM dbo.Thuoc
UNION ALL SELECT N'HoaDon', COUNT(*) FROM dbo.HoaDon
UNION ALL SELECT N'ChiTietHoaDon', COUNT(*) FROM dbo.ChiTietHoaDon
UNION ALL SELECT N'NhanVien', COUNT(*) FROM dbo.NhanVien
UNION ALL SELECT N'DanhMucThuocs', COUNT(*) FROM dbo.DanhMucThuocs;
SELECT TOP (100) * FROM dbo.DonViTinh ORDER BY MaDV;
SELECT TOP (100) * FROM dbo.Thuoc ORDER BY MaThuoc;
SELECT TOP (100) * FROM dbo.HoaDon ORDER BY NgayLap DESC;
SELECT TOP (100) * FROM dbo.ChiTietHoaDon;
