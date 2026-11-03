using QuanLyQuanThuoc.BLL;
using QuanLyQuanThuoc.GUI;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyQuanThuoc.Models
{
    public partial class FormHoaDon : Form
    {
        // Bản nháp riêng biệt để bấm Hủy/Làm mới không làm thay đổi hóa đơn đã lưu.
        private readonly List<ChiTietHoaDon> chiTietNhap = new();
        private HoaDon? hoaDonDangChon;
        private static readonly CultureInfo TienVietNam = CultureInfo.GetCultureInfo("vi-VN");

        public FormHoaDon()
        {
            InitializeComponent();
            if (System.ComponentModel.LicenseManager.UsageMode ==
                System.ComponentModel.LicenseUsageMode.Designtime) return;
            NapNhanVien();
            NapThuoc();
            NapHoaDon();
            dtpNgayLap.Value = DateTime.Today;
            if (KhoHoaDon.LoiTaiDuLieu != null)
                MessageBox.Show(KhoHoaDon.LoiTaiDuLieu + "\nKhông lưu khi dữ liệu SQL chưa tải được.",
                    "Lỗi dữ liệu SQL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private static string Tien(decimal gia) => gia.ToString("N0", TienVietNam);

        private static decimal ChuyenGia(string gia)
        {
            // Đơn giá thuốc trong project gốc là chuỗi VND: ví dụ "8.000".
            string chiLaySo = new string((gia ?? string.Empty).Where(char.IsDigit).ToArray());
            return decimal.TryParse(chiLaySo, out decimal so) ? so : 0;
        }

        private void NapNhanVien()
        {
            cboNhanVien.Items.Clear();
            cboNhanVien.DisplayMember = nameof(NhanVien.HoTen);
            foreach (NhanVien nv in KhoNhanVien.DanhSach)
                if (nv.TrangThai == "Đang làm") cboNhanVien.Items.Add(nv);
            if (cboNhanVien.Items.Count > 0) cboNhanVien.SelectedIndex = 0;
        }

        private void NapThuoc()
        {
            cboThuoc.Items.Clear();
            cboThuoc.DisplayMember = nameof(Thuoc.TenThuoc);
            foreach (Thuoc thuoc in KhoThuoc.DanhSach)
                cboThuoc.Items.Add(thuoc);
            if (cboThuoc.Items.Count > 0) cboThuoc.SelectedIndex = 0;
            CapNhatGia();
        }

        private void cboThuoc_SelectedIndexChanged(object? sender, EventArgs e) => CapNhatGia();

        private void CapNhatGia()
        {
            txtDonGia.Text = cboThuoc.SelectedItem is Thuoc thuoc
                ? Tien(ChuyenGia(thuoc.DonGia)) : string.Empty;
        }

        private void NapHoaDon()
        {
            string tuKhoa = txtTimKiem.Text.Trim();
            dgvHoaDon.Rows.Clear();
            foreach (HoaDon hd in KhoHoaDon.DanhSach.Where(hd =>
                string.IsNullOrEmpty(tuKhoa) ||
                hd.MaHoaDon.Contains(tuKhoa, StringComparison.OrdinalIgnoreCase) ||
                hd.TenKhachHang.Contains(tuKhoa, StringComparison.OrdinalIgnoreCase) ||
                hd.TenNhanVien.Contains(tuKhoa, StringComparison.OrdinalIgnoreCase) ||
                hd.SoDienThoai.Contains(tuKhoa, StringComparison.OrdinalIgnoreCase)))
            {
                int i = dgvHoaDon.Rows.Add(hd.MaHoaDon,
                    hd.NgayLap.ToString("dd/MM/yyyy"), hd.TenKhachHang,
                    hd.SoDienThoai, hd.TenNhanVien, Tien(hd.TongTien));
                dgvHoaDon.Rows[i].Tag = hd;
            }
            dgvHoaDon.ClearSelection();
            dgvHoaDon.CurrentCell = null;
            lblSoHoaDon.Text = $"Hiển thị: {dgvHoaDon.Rows.Count} hóa đơn";
        }

        private void NapChiTiet()
        {
            dgvChiTiet.Rows.Clear();
            foreach (ChiTietHoaDon ct in chiTietNhap)
            {
                int i = dgvChiTiet.Rows.Add(ct.MaThuoc, ct.TenThuoc, ct.DonViTinh,
                    ct.SoLuong, Tien(ct.DonGia), Tien(ct.ThanhTien));
                dgvChiTiet.Rows[i].Tag = ct;
            }
            dgvChiTiet.ClearSelection();
            dgvChiTiet.CurrentCell = null;
            lblTongTien.Text = "Tổng tiền: " + Tien(chiTietNhap.Sum(ct => ct.ThanhTien)) + " đ";
        }

        private void btnThemDong_Click(object? sender, EventArgs e)
        {
            if (cboThuoc.SelectedItem is not Thuoc thuoc)
            {
                MessageBox.Show("Chưa có thuốc. Vui lòng thêm thuốc ở mục Quản lý thuốc.");
                return;
            }
            decimal gia = ChuyenGia(thuoc.DonGia);
            if (gia <= 0)
            {
                MessageBox.Show("Đơn giá thuốc chưa hợp lệ. Hãy sửa giá trong Quản lý thuốc.");
                return;
            }
            int soLuong = (int)nudSoLuong.Value;
            ChiTietHoaDon? daCo = chiTietNhap.FirstOrDefault(ct =>
                ct.MaThuoc.Equals(thuoc.MaThuoc, StringComparison.OrdinalIgnoreCase));
            if (daCo != null)
            {
                if (daCo.SoLuong > int.MaxValue - soLuong)
                {
                    MessageBox.Show("Số lượng quá lớn.");
                    return;
                }
                daCo.SoLuong += soLuong;
                daCo.DonGia = gia;
                daCo.TenThuoc = thuoc.TenThuoc;
                daCo.DonViTinh = thuoc.DonViTinh;
            }
            else
            {
                chiTietNhap.Add(new ChiTietHoaDon
                {
                    MaThuoc = thuoc.MaThuoc,
                    TenThuoc = thuoc.TenThuoc,
                    DonViTinh = thuoc.DonViTinh,
                    SoLuong = soLuong,
                    DonGia = gia
                });
            }
            nudSoLuong.Value = 1;
            NapChiTiet();
        }

        private void btnXoaDong_Click(object? sender, EventArgs e)
        {
            if (dgvChiTiet.CurrentRow?.Tag is not ChiTietHoaDon ct)
            {
                MessageBox.Show("Hãy chọn một dòng thuốc trong bảng chi tiết để xóa.");
                return;
            }
            chiTietNhap.Remove(ct);
            NapChiTiet();
        }

        private bool KiemTraNhap()
        {
            if (string.IsNullOrWhiteSpace(txtMaHoaDon.Text) ||
                string.IsNullOrWhiteSpace(txtKhachHang.Text))
            {
                MessageBox.Show("Vui lòng nhập mã hóa đơn và tên khách hàng.");
                return false;
            }
            if (!string.IsNullOrWhiteSpace(txtSoDienThoai.Text) &&
                (txtSoDienThoai.Text.Trim().Length != 10 ||
                !txtSoDienThoai.Text.Trim().All(char.IsDigit)))
            {
                MessageBox.Show("Số điện thoại phải gồm 10 chữ số (hoặc để trống).");
                return false;
            }
            if (cboNhanVien.SelectedItem is not NhanVien)
            {
                MessageBox.Show("Vui lòng có ít nhất một nhân viên để lập hóa đơn.");
                return false;
            }
            if (chiTietNhap.Count == 0)
            {
                MessageBox.Show("Hãy thêm ít nhất một loại thuốc vào chi tiết hóa đơn.");
                return false;
            }
            if (chiTietNhap.Any(ct => ct.SoLuong <= 0 || ct.DonGia <= 0))
            {
                MessageBox.Show("Chi tiết hóa đơn có số lượng hoặc đơn giá không hợp lệ.");
                return false;
            }
            return true;
        }

        private HoaDon LayHoaDon()
        {
            NhanVien nv = (NhanVien)cboNhanVien.SelectedItem!;
            return new HoaDon
            {
                MaHoaDon = txtMaHoaDon.Text.Trim(),
                NgayLap = dtpNgayLap.Value.Date,
                TenKhachHang = txtKhachHang.Text.Trim(),
                SoDienThoai = txtSoDienThoai.Text.Trim(),
                MaNhanVien = nv.MaNhanVien,
                TenNhanVien = nv.HoTen,
                GhiChu = txtGhiChu.Text.Trim(),
                TrangThaiThanhToan = " chua thanh toan",
                ChiTiet = chiTietNhap.Select(ct => new ChiTietHoaDon
                {
                    MaThuoc = ct.MaThuoc,
                    TenThuoc = ct.TenThuoc,
                    DonViTinh = ct.DonViTinh,
                    SoLuong = ct.SoLuong,
                    DonGia = ct.DonGia
                }).ToList()
            };
        }

        private bool Luu()
        {
            if (KhoHoaDon.Luu(out string loi)) return true;
            MessageBox.Show(loi, "Lỗi lưu hóa đơn", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        private void btnThem_Click(object? sender, EventArgs e)
        {
            if (!KiemTraNhap()) return;
            HoaDon moi = LayHoaDon();
            if (KhoHoaDon.DanhSach.Any(hd =>
                hd.MaHoaDon.Equals(moi.MaHoaDon, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Mã hóa đơn đã tồn tại.");
                return;
            }
            KhoHoaDon.DanhSach.Add(moi);
            if (!Luu()) { KhoHoaDon.DanhSach.Remove(moi); return; }
            LamMoi();
            MessageBox.Show("Thêm hóa đơn thành công!");
        }

        private void btnSua_Click(object? sender, EventArgs e)
        {
            if (hoaDonDangChon == null || !KhoHoaDon.DanhSach.Contains(hoaDonDangChon))
            {
                MessageBox.Show("Hãy chọn hóa đơn cần sửa trong danh sách bên dưới.");
                return;
            }
            if (!KiemTraNhap()) return;
            int viTri = KhoHoaDon.DanhSach.IndexOf(hoaDonDangChon);
            HoaDon cu = hoaDonDangChon;
            HoaDon sua = LayHoaDon();
            // Mã hóa đơn là khóa, không cho thay đổi khi sửa.
            sua.MaHoaDon = cu.MaHoaDon;
            sua.TrangThaiThanhToan = cu.TrangThaiThanhToan;
            KhoHoaDon.DanhSach[viTri] = sua;
            if (!Luu()) { KhoHoaDon.DanhSach[viTri] = cu; return; }
            LamMoi();
            MessageBox.Show("Cập nhật hóa đơn thành công!");
        }

        private void btnXoa_Click(object? sender, EventArgs e)
        {
            if (hoaDonDangChon == null || !KhoHoaDon.DanhSach.Contains(hoaDonDangChon))
            {
                MessageBox.Show("Hãy chọn hóa đơn cần xóa trong danh sách bên dưới.");
                return;
            }
            if (MessageBox.Show($"Xóa hóa đơn '{hoaDonDangChon.MaHoaDon}'?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            HoaDon cu = hoaDonDangChon;
            int i = KhoHoaDon.DanhSach.IndexOf(cu);
            KhoHoaDon.DanhSach.RemoveAt(i);
            if (!Luu()) { KhoHoaDon.DanhSach.Insert(i, cu); return; }
            LamMoi();
            MessageBox.Show("Đã xóa hóa đơn!");
        }

        private void btnLamMoi_Click(object? sender, EventArgs e) => LamMoi();
        private void LamMoi()
        {
            hoaDonDangChon = null;
            txtMaHoaDon.ReadOnly = false;
            txtMaHoaDon.Clear();
            txtKhachHang.Clear();
            txtSoDienThoai.Clear();
            txtGhiChu.Clear();
            dtpNgayLap.Value = DateTime.Today;
            NapNhanVien();
            NapThuoc();
            chiTietNhap.Clear();
            NapChiTiet();
            txtTimKiem.Clear();
            NapHoaDon();
            txtMaHoaDon.Focus();
        }

        private void txtTimKiem_TextChanged(object? sender, EventArgs e)
        {
            // Đổi điều kiện lọc bỏ trạng thái chọn cũ để không sửa nhầm bản ghi.
            hoaDonDangChon = null;
            txtMaHoaDon.ReadOnly = false;
            NapHoaDon();
        }
        private void btnTimKiem_Click(object? sender, EventArgs e) => NapHoaDon();

        private void dgvHoaDon_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvHoaDon.Rows[e.RowIndex].Tag is not HoaDon hd) return;
            hoaDonDangChon = hd;
            txtMaHoaDon.Text = hd.MaHoaDon;
            txtMaHoaDon.ReadOnly = true;
            dtpNgayLap.Value = hd.NgayLap;
            txtKhachHang.Text = hd.TenKhachHang;
            txtSoDienThoai.Text = hd.SoDienThoai;
            txtGhiChu.Text = hd.GhiChu;

            NhanVien? nv = cboNhanVien.Items.Cast<NhanVien>().FirstOrDefault(nv =>
                nv.MaNhanVien.Equals(hd.MaNhanVien, StringComparison.OrdinalIgnoreCase));
            if (nv == null)
            {
                // Nhân viên cũ đã nghỉ/xóa vẫn có thể xem, sửa hóa đơn lịch sử.
                nv = new NhanVien
                {
                    MaNhanVien = hd.MaNhanVien,
                    HoTen = hd.TenNhanVien,
                    TrangThai = "Nghỉ việc"
                };
                cboNhanVien.Items.Add(nv);
            }
            cboNhanVien.SelectedItem = nv;

            chiTietNhap.Clear();
            foreach (ChiTietHoaDon ct in hd.ChiTiet ?? new List<ChiTietHoaDon>())
                chiTietNhap.Add(new ChiTietHoaDon
                {
                    MaThuoc = ct.MaThuoc,
                    TenThuoc = ct.TenThuoc,
                    DonViTinh = ct.DonViTinh,
                    SoLuong = ct.SoLuong,
                    DonGia = ct.DonGia
                });
            NapChiTiet();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (hoaDonDangChon == null)
            {
                MessageBox.Show("Vui long chon hoa don");
                return;
            }
            FormThanhToan frm = new FormThanhToan(hoaDonDangChon.MaHoaDon, hoaDonDangChon.TongTien);
            frm.ShowDialog(this);
        }
    }
}
