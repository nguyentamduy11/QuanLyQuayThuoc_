using QuanLyQuanThuoc.BLL;
using QuanLyQuanThuoc.GUI;
using QuanLyQuanThuoc.DAL;

namespace QuanLyQuanThuoc
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            // Không chạy bằng dữ liệu JSON khi SQL bị mất kết nối.
            if (!KiemTraSql.ThuKetNoi(out string thongBao))
            {
                MessageBox.Show(thongBao, "Lỗi kết nối cơ sở dữ liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Application.Run(new FormDangNhap());
        }
    }
}