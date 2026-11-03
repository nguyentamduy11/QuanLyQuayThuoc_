QUẢN LÝ QUẦY THUỐC - GIAO DIỆN CHỈNH BẰNG VISUAL STUDIO DESIGNER
.NET 10 - C# Windows Forms

THAY ĐỔI
- PHIÊN BẢN SQL: kiểm tra DAL/KiemTraSql.cs và HUONG_DAN_SQL_SERVER.txt.
- Đã bỏ các hàm tự tạo giao diện: DatNhan, DatText, DatNut, DatCot, CaiDatBang.
- Đã bỏ phần tự tô màu/định dạng control trong các constructor và hàm CaiThienGiaoDien/CaiDatNut.
- Đã chuyển màu sắc, Font, vị trí, kích thước, định dạng bảng/nút sang Form*.Designer.cs.
- Giữ code nghiệp vụ trong Form*.cs (Thêm, Sửa, Xóa, Tìm kiếm, đăng nhập và lưu SQL Server).
- Có thêm bảo vệ để không truy vấn SQL Server khi mở Form bằng Visual Studio Designer.
- Không đóng gói thư mục .vs, bin, obj và các tệp chỉ dùng trên máy cũ.

CÁCH MỞ VÀ CHỈNH FORM BẰNG GIAO DIỆN (KHÔNG CẦN GÕ CODE)
1. Giải nén ZIP, mở QuanLyQuanThuoc.slnx trong Visual Studio có hỗ trợ .NET 10 / Windows Forms.
2. Solution Explorer > QuanLyQuanThuoc > GUI.
3. Bấm chuột phải vào Form1.cs, FormQuanLyThuoc.cs, FormDanhMucThuoc.cs,
   FormQuanLyNhanVien.cs, FormDonViTinh.cs hoặc FormHoaDon.cs > View Designer.
   Hoặc chọn file .cs và nhấn Shift + F7.
4. Nhấp nút/nhãn/ô nhập/bảng trên Form; nhấn F4 để mở cửa sổ Properties.
5. Thay màu BackColor, màu chữ ForeColor, Font, Text, Size, Location,
   FlatStyle... bằng Properties. Kéo-thả để chỉnh vị trí control.
6. Ctrl + S để lưu; Visual Studio sẽ tự sinh mã ở Form*.Designer.cs.
7. F5 để chạy chương trình, kiểm tra nút và dữ liệu vẫn hoạt động.

LƯU Ý
- Không xóa Form*.Designer.cs: Windows Forms Designer luôn tự quản lý file này.
- Không cần chỉnh định dạng bằng cách sửa các file Form*.cs.
- Code trong Form*.cs được giữ lại vì cần thiết để chức năng hoạt động.
- Chưa có khả năng biên dịch thử WinForms trên Windows trong môi trường tạo file;
  hãy dùng Visual Studio và gửi lỗi cụ thể nếu gặp vấn đề.
