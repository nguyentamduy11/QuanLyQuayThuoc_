using QuanLyQuanThuoc.BLL;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyQuanThuoc.Models
{
    public partial class FormQuanLyNhanVien : Form
    {
        // Ghi nhớ đúng nhân viên người dùng chọn để tránh sửa/xóa nhầm.
        private NhanVien? nhanVienDangChon;

        public FormQuanLyNhanVien()
        {
            InitializeComponent();
            if (System.ComponentModel.LicenseManager.UsageMode ==
                System.ComponentModel.LicenseUsageMode.Designtime) return;
            dtpNgaySinh.MaxDate = DateTime.Today;
            dtpNgaySinh.Value = DateTime.Today;
            cboGioiTinh.SelectedIndex = 0;
            cboChucVu.SelectedIndex = 0;
            cboTrangThai.SelectedIndex = 0;
            NapDuLieu();

            if (!string.IsNullOrWhiteSpace(KhoNhanVien.LoiTaiDuLieu))
            {
                MessageBox.Show(KhoNhanVien.LoiTaiDuLieu +
                    "\nKhông lưu được khi kết nối SQL gặp lỗi.",
                    "Không thể tải dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void NapDuLieu()
        {
            string tuKhoa = txtTimKiem.Text.Trim();
            dgvNhanVien.Rows.Clear();

            foreach (NhanVien nv in KhoNhanVien.DanhSach.Where(nv =>
                string.IsNullOrEmpty(tuKhoa)
                || nv.MaNhanVien.Contains(tuKhoa, StringComparison.OrdinalIgnoreCase)
                || nv.HoTen.Contains(tuKhoa, StringComparison.OrdinalIgnoreCase)
                || nv.SoDienThoai.Contains(tuKhoa, StringComparison.OrdinalIgnoreCase)
                || nv.ChucVu.Contains(tuKhoa, StringComparison.OrdinalIgnoreCase)))
            {
                int i = dgvNhanVien.Rows.Add(
                    nv.MaNhanVien,
                    nv.HoTen,
                    nv.GioiTinh,
                    nv.NgaySinh.ToString("dd/MM/yyyy"),
                    nv.SoDienThoai,
                    nv.ChucVu,
                    nv.DiaChi,
                    nv.TrangThai);
                dgvNhanVien.Rows[i].Tag = nv;
            }

            dgvNhanVien.ClearSelection();
            dgvNhanVien.CurrentCell = null;
            lblSoLuong.Text = $"Hiển thị: {dgvNhanVien.Rows.Count} nhân viên";
        }

        private bool KiemTraNhapLieu()
        {
            if (string.IsNullOrWhiteSpace(txtMaNhanVien.Text) ||
                string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên và họ tên.", "Thiếu thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string sdt = txtSoDienThoai.Text.Trim();
            if (sdt.Length != 10 || !sdt.All(char.IsDigit))
            {
                MessageBox.Show("Số điện thoại phải có đúng 10 chữ số.", "Thông tin không hợp lệ",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private NhanVien LayThongTinTuForm()
        {
            return new NhanVien
            {
                MaNhanVien = txtMaNhanVien.Text.Trim(),
                HoTen = txtHoTen.Text.Trim(),
                GioiTinh = cboGioiTinh.Text,
                NgaySinh = dtpNgaySinh.Value.Date,
                SoDienThoai = txtSoDienThoai.Text.Trim(),
                ChucVu = cboChucVu.Text,
                DiaChi = txtDiaChi.Text.Trim(),
                TrangThai = cboTrangThai.Text
            };
        }

        private bool LuuThayDoi()
        {
            if (KhoNhanVien.LuuDuLieu(out string loi))
                return true;

            MessageBox.Show(loi, "Không thể lưu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        private void btnThem_Click(object? sender, EventArgs e)
        {
            if (!KiemTraNhapLieu()) return;

            NhanVien moi = LayThongTinTuForm();
            if (KhoNhanVien.DanhSach.Any(nv =>
                string.Equals(nv.MaNhanVien, moi.MaNhanVien, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Mã nhân viên đã tồn tại!", "Trùng mã",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            KhoNhanVien.DanhSach.Add(moi);
            if (!LuuThayDoi())
            {
                KhoNhanVien.DanhSach.Remove(moi);
                NapDuLieu();
                return;
            }

            LamMoi();
            MessageBox.Show("Thêm nhân viên thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSua_Click(object? sender, EventArgs e)
        {
            if (nhanVienDangChon == null || !KhoNhanVien.DanhSach.Contains(nhanVienDangChon))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa ở bảng bên dưới.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!KiemTraNhapLieu()) return;

            NhanVien cu = nhanVienDangChon;
            int viTri = KhoNhanVien.DanhSach.IndexOf(cu);
            NhanVien daSua = LayThongTinTuForm();
            // Mã nhân viên là khóa định danh và không được sửa.
            daSua.MaNhanVien = cu.MaNhanVien;
            KhoNhanVien.DanhSach[viTri] = daSua;
            if (!LuuThayDoi())
            {
                KhoNhanVien.DanhSach[viTri] = cu;
                return;
            }

            LamMoi();
            MessageBox.Show("Sửa nhân viên thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoa_Click(object? sender, EventArgs e)
        {
            if (nhanVienDangChon == null || !KhoNhanVien.DanhSach.Contains(nhanVienDangChon))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa ở bảng bên dưới.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show($"Bạn có chắc muốn xóa nhân viên '{nhanVienDangChon.HoTen}'?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            NhanVien cu = nhanVienDangChon;
            int viTri = KhoNhanVien.DanhSach.IndexOf(cu);
            KhoNhanVien.DanhSach.RemoveAt(viTri);
            if (!LuuThayDoi())
            {
                KhoNhanVien.DanhSach.Insert(viTri, cu);
                return;
            }

            LamMoi();
            MessageBox.Show("Xóa nhân viên thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLamMoi_Click(object? sender, EventArgs e) => LamMoi();

        private void LamMoi()
        {
            nhanVienDangChon = null;
            txtMaNhanVien.ReadOnly = false;
            txtMaNhanVien.Clear();
            txtHoTen.Clear();
            txtSoDienThoai.Clear();
            txtDiaChi.Clear();
            cboGioiTinh.SelectedIndex = 0;
            cboChucVu.SelectedIndex = 0;
            cboTrangThai.SelectedIndex = 0;
            dtpNgaySinh.Value = DateTime.Today;
            txtTimKiem.Clear();
            NapDuLieu();
            txtMaNhanVien.Focus();
        }

        private void btnTimKiem_Click(object? sender, EventArgs e) => TimKiem();
        private void txtTimKiem_TextChanged(object? sender, EventArgs e) => TimKiem();

        private void TimKiem()
        {
            nhanVienDangChon = null;
            txtMaNhanVien.ReadOnly = false;
            NapDuLieu();
        }

        private void dgvNhanVien_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvNhanVien.Rows[e.RowIndex].Tag is not NhanVien nv)
                return;

            nhanVienDangChon = nv;
            txtMaNhanVien.Text = nv.MaNhanVien;
            txtMaNhanVien.ReadOnly = true;
            txtHoTen.Text = nv.HoTen;
            cboGioiTinh.Text = nv.GioiTinh;
            dtpNgaySinh.Value = nv.NgaySinh.Date > DateTime.Today ? DateTime.Today : nv.NgaySinh.Date;
            txtSoDienThoai.Text = nv.SoDienThoai;
            cboChucVu.Text = nv.ChucVu;
            txtDiaChi.Text = nv.DiaChi;
            cboTrangThai.Text = nv.TrangThai;
        }
    }
}
