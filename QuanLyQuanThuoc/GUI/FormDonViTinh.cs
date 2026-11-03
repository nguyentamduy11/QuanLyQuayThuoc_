using QuanLyQuanThuoc.BLL;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyQuanThuoc.Models
{
    public partial class FormDonViTinh : Form
    {
        private DonViTinh? donViDangChon;

        public FormDonViTinh()
        {
            InitializeComponent();
            if (System.ComponentModel.LicenseManager.UsageMode ==
                System.ComponentModel.LicenseUsageMode.Designtime) return;
            NapDuLieu();
            if (KhoDonViTinh.LoiTaiDuLieu != null)
                MessageBox.Show(KhoDonViTinh.LoiTaiDuLieu + "\nKhông lưu khi dữ liệu SQL chưa tải được.",
                    "Lỗi dữ liệu SQL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void NapDuLieu()
        {
            string tim = txtTimKiem.Text.Trim();
            dgvDonViTinh.Rows.Clear();
            foreach (DonViTinh dv in KhoDonViTinh.DanhSach.Where(dv =>
                string.IsNullOrEmpty(tim) ||
                dv.MaDV.Contains(tim, StringComparison.OrdinalIgnoreCase) ||
                dv.TenDV.Contains(tim, StringComparison.OrdinalIgnoreCase) ||
                dv.MoTa.Contains(tim, StringComparison.OrdinalIgnoreCase)))
            {
                int index = dgvDonViTinh.Rows.Add(dv.MaDV, dv.TenDV, dv.MoTa);
                dgvDonViTinh.Rows[index].Tag = dv;
            }
            dgvDonViTinh.ClearSelection();
            dgvDonViTinh.CurrentCell = null;
            lblSoLuong.Text = $"Hiển thị: {dgvDonViTinh.Rows.Count} đơn vị";
        }

        private bool KiemTra(DonViTinh? boQua = null)
        {
            if (string.IsNullOrWhiteSpace(txtMaDV.Text) ||
                string.IsNullOrWhiteSpace(txtTenDV.Text))
            {
                MessageBox.Show("Vui lòng nhập mã và tên đơn vị tính.");
                return false;
            }
            if (KhoDonViTinh.DanhSach.Any(dv => !ReferenceEquals(dv, boQua) &&
                dv.MaDV.Equals(txtMaDV.Text.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Mã đơn vị tính đã tồn tại!");
                return false;
            }
            if (KhoDonViTinh.DanhSach.Any(dv => !ReferenceEquals(dv, boQua) &&
                dv.TenDV.Equals(txtTenDV.Text.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Tên đơn vị tính đã tồn tại!");
                return false;
            }
            return true;
        }

        private bool Luu()
        {
            if (KhoDonViTinh.Luu(out string loi)) return true;
            MessageBox.Show(loi, "Lỗi lưu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        private void btnThem_Click(object? sender, EventArgs e)
        {
            if (!KiemTra()) return;
            DonViTinh moi = new()
            {
                MaDV = txtMaDV.Text.Trim(),
                TenDV = txtTenDV.Text.Trim(),
                MoTa = txtMoTa.Text.Trim()
            };
            KhoDonViTinh.DanhSach.Add(moi);
            if (!Luu()) { KhoDonViTinh.DanhSach.Remove(moi); return; }
            LamMoi();
            MessageBox.Show("Thêm đơn vị tính thành công!");
        }

        private void btnSua_Click(object? sender, EventArgs e)
        {
            if (donViDangChon == null || !KhoDonViTinh.DanhSach.Contains(donViDangChon))
            {
                MessageBox.Show("Hãy chọn đơn vị cần sửa trong bảng.");
                return;
            }
            if (!KiemTra(donViDangChon)) return;
            string tenCu = donViDangChon.TenDV;
            var sua = new DonViTinh
            {
                MaDV = donViDangChon.MaDV,
                TenDV = txtTenDV.Text.Trim(),
                MoTa = txtMoTa.Text.Trim()
            };
            int i = KhoDonViTinh.DanhSach.IndexOf(donViDangChon);
            DonViTinh cu = donViDangChon;
            KhoDonViTinh.DanhSach[i] = sua;
            if (!Luu()) { KhoDonViTinh.DanhSach[i] = cu; return; }

            // Đồng bộ tên đơn vị trong thuốc và lưu để không bị mất sau khi khởi động lại.
            var thuocLienQuan = KhoThuoc.DanhSach.Where(t =>
                t.DonViTinh.Equals(tenCu, StringComparison.OrdinalIgnoreCase)).ToList();
            foreach (Thuoc thuoc in thuocLienQuan) thuoc.DonViTinh = sua.TenDV;
            if (thuocLienQuan.Count > 0 && !KhoThuoc.Luu(out string loiThuoc))
            {
                foreach (Thuoc thuoc in thuocLienQuan) thuoc.DonViTinh = tenCu;
                KhoDonViTinh.DanhSach[i] = cu;
                KhoDonViTinh.Luu(out _);
                MessageBox.Show("Không thể đồng bộ tên đơn vị trong thuốc: " + loiThuoc,
                    "Không thể lưu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            LamMoi();
            MessageBox.Show("Sửa đơn vị tính thành công!");
        }

        private void btnXoa_Click(object? sender, EventArgs e)
        {
            if (donViDangChon == null || !KhoDonViTinh.DanhSach.Contains(donViDangChon))
            {
                MessageBox.Show("Hãy chọn đơn vị cần xóa trong bảng.");
                return;
            }
            if (KhoThuoc.DanhSach.Any(t => t.DonViTinh.Equals(donViDangChon.TenDV,
                StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Đơn vị này đang được sử dụng bởi thuốc, không thể xóa.");
                return;
            }
            if (MessageBox.Show("Bạn có chắc muốn xóa đơn vị tính này?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            DonViTinh cu = donViDangChon;
            int i = KhoDonViTinh.DanhSach.IndexOf(cu);
            KhoDonViTinh.DanhSach.RemoveAt(i);
            if (!Luu()) { KhoDonViTinh.DanhSach.Insert(i, cu); return; }
            LamMoi();
            MessageBox.Show("Xóa đơn vị tính thành công!");
        }

        private void btnLamMoi_Click(object? sender, EventArgs e) => LamMoi();

        private void LamMoi()
        {
            donViDangChon = null;
            txtMaDV.ReadOnly = false;
            txtMaDV.Clear();
            txtTenDV.Clear();
            txtMoTa.Clear();
            txtTimKiem.Clear();
            NapDuLieu();
            txtMaDV.Focus();
        }

        private void btnTimKiem_Click(object? sender, EventArgs e) => NapDuLieu();
        private void txtTimKiem_TextChanged(object? sender, EventArgs e)
        {
            donViDangChon = null;
            txtMaDV.ReadOnly = false;
            NapDuLieu();
        }

        private void dgvDonViTinh_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvDonViTinh.Rows[e.RowIndex].Tag is not DonViTinh dv) return;
            donViDangChon = dv;
            txtMaDV.Text = dv.MaDV;
            txtMaDV.ReadOnly = true;
            txtTenDV.Text = dv.TenDV;
            txtMoTa.Text = dv.MoTa;
        }
    }
}
