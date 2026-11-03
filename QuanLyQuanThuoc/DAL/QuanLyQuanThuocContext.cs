
using Microsoft.EntityFrameworkCore;
using QuanLyQuanThuoc.BLL;

namespace QuanLyQuanThuoc.DAL
{
    public class QuanLyQuanThuocContext : DbContext
    {
        public DbSet<Thuoc> Thuoc => Set<Thuoc>();
        public DbSet<DonViTinh> DonViTinh => Set<DonViTinh>();
        public DbSet<NhanVien> NhanVien => Set<NhanVien>();
        public DbSet<DanhMucThuoc> DanhMucThuocs => Set<DanhMucThuoc>();
        public DbSet<HoaDon> HoaDon => Set<HoaDon>();
        public DbSet<ChiTietHoaDon> ChiTietHoaDon => Set<ChiTietHoaDon>();

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\MSSQLLocalDB;Database=QuanLyQuanThuoc;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(
            ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Thuoc>()
                .HasKey(x => x.MaThuoc);

            modelBuilder.Entity<DonViTinh>()
                .HasKey(x => x.MaDV);

            modelBuilder.Entity<NhanVien>()
                .HasKey(x => x.MaNhanVien);

            modelBuilder.Entity<DanhMucThuoc>()
                .HasKey(x => x.MaDanhMuc);

            modelBuilder.Entity<HoaDon>()
                .HasKey(x => x.MaHoaDon);

            modelBuilder.Entity<HoaDon>()
                .Ignore(x => x.TongTien);

            modelBuilder.Entity<ChiTietHoaDon>()
                .Ignore(x => x.ThanhTien);

            modelBuilder.Entity<ChiTietHoaDon>()
                .Property<string>("MaHoaDon");

            modelBuilder.Entity<ChiTietHoaDon>()
                .HasKey("MaHoaDon", "MaThuoc");

            modelBuilder.Entity<HoaDon>()
                .HasMany(h => h.ChiTiet)
                .WithOne()
                .HasForeignKey("MaHoaDon")
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}

