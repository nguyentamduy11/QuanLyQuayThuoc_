using QuanLyQuanThuoc.BLL;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyQuanThuoc.Models
{
    public partial class FormQuanLyThuoc : Form
    {
        private Thuoc? thuocDangChon;

        public FormQuanLyThuoc()
        {
            InitializeComponent();
            if (System.ComponentModel.LicenseManager.UsageMode ==
                System.ComponentModel.LicenseUsageMode.Designtime) return;
            NapDonViTinh();
            NapDuLieu();
            if (KhoThuoc.LoiTaiDuLieu != null)
                MessageBox.Show(KhoThuoc.LoiTaiDuLieu + "\nKhông ghi đè file lỗi.",
                    "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void NapDonViTinh()
        {
            cboDonViTinh.Items.Clear();
            foreach (DonViTinh dv in KhoDonViTinh.DanhSach)
                cboDonViTinh.Items.Add(dv.TenDV);
            if (cboDonViTinh.Items.Count > 0) cboDonViTinh.SelectedIndex = 0;
        }



        private void NapDuLieu()
        {
            string tim = txtTimKiem.Text.Trim();
            dgvThuoc.Rows.Clear();
            foreach (Thuoc t in KhoThuoc.DanhSach.Where(t =>
                string.IsNullOrEmpty(tim) ||
                t.MaThuoc.Contains(tim, StringComparison.OrdinalIgnoreCase) ||
                t.TenThuoc.Contains(tim, StringComparison.OrdinalIgnoreCase)))
            {
                int i = dgvThuoc.Rows.Add(t.MaThuoc, t.TenThuoc, t.DonViTinh,
                    t.SoLuong, t.DonGia, t.HanSuDung.ToString("dd/MM/yyyy"));
                dgvThuoc.Rows[i].Tag = t;
            }
            dgvThuoc.ClearSelection();
            dgvThuoc.CurrentCell = null;
        }

        private bool KiemTraNhap(Thuoc? boQua = null)
        {
            if (string.IsNullOrWhiteSpace(txtMaThuoc.Text) || string.IsNullOrWhiteSpace(txtTenThuoc.Text))
            {
                MessageBox.Show("Vui lòng nhập mã thuốc và tên thuốc.");
                return false;
            }
            if (cboDonViTinh.SelectedIndex < 0)
            {
                MessageBox.Show("Hãy tạo ít nhất một đơn vị tính ở mục Đơn Vị Tính.");
                return false;
            }
            if (KhoThuoc.DanhSach.Any(t => !ReferenceEquals(t, boQua) &&
                t.MaThuoc.Equals(txtMaThuoc.Text.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Mã thuốc đã tồn tại.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDonGia.Text) ||
                txtDonGia.Text.Any(c => !char.IsDigit(c) && c != '.' && c != ',') ||
                !decimal.TryParse(new string(txtDonGia.Text.Where(char.IsDigit).ToArray()), out decimal gia) ||
                gia <= 0)
            {
                MessageBox.Show("Đơn giá phải là số tiền dương, ví dụ 8000 hoặc 8.000.");
                return false;
            }
            return true;
        }

        private Thuoc LayThuoc() => new()
        {
            MaThuoc = txtMaThuoc.Text.Trim(),
            TenThuoc = txtTenThuoc.Text.Trim(),
            DonViTinh = cboDonViTinh.Text,
            SoLuong = (int)nudSoLuong.Value,
            DonGia = txtDonGia.Text.Trim(),
            HanSuDung = dtpHanSuDung.Value.Date
        };

        private bool Luu()
        {
            if (KhoThuoc.Luu(out string loi)) return true;
            MessageBox.Show(loi, "Không thể lưu thuốc", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KiemTraNhap()) return;
            Thuoc moi = LayThuoc();
            KhoThuoc.DanhSach.Add(moi);
            if (!Luu()) { KhoThuoc.DanhSach.Remove(moi); return; }
            XoaThongTin();
            NapDuLieu();
            MessageBox.Show("Đã thêm thuốc!");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (thuocDangChon == null || !KhoThuoc.DanhSach.Contains(thuocDangChon))
            {
                MessageBox.Show("Vui lòng chọn thuốc cần sửa trong danh sách.");
                return;
            }
            if (!KiemTraNhap(thuocDangChon)) return;
            int i = KhoThuoc.DanhSach.IndexOf(thuocDangChon);
            Thuoc cu = thuocDangChon;
            Thuoc sua = LayThuoc();
            sua.MaThuoc = cu.MaThuoc;
            KhoThuoc.DanhSach[i] = sua;
            if (!Luu()) { KhoThuoc.DanhSach[i] = cu; return; }
            XoaThongTin();
            NapDuLieu();
            MessageBox.Show("Đã sửa thuốc!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (thuocDangChon == null || !KhoThuoc.DanhSach.Contains(thuocDangChon))
            {
                MessageBox.Show("Vui lòng chọn thuốc cần xóa trong danh sách.");
                return;
            }
            if (MessageBox.Show("Bạn muốn xóa thuốc này?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            int i = KhoThuoc.DanhSach.IndexOf(thuocDangChon);
            Thuoc cu = thuocDangChon;
            KhoThuoc.DanhSach.RemoveAt(i);
            if (!Luu()) { KhoThuoc.DanhSach.Insert(i, cu); return; }
            XoaThongTin();
            NapDuLieu();
            MessageBox.Show("Đã xóa thuốc!");
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            XoaThongTin();
            NapDuLieu();
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            thuocDangChon = null;
            txtMaThuoc.ReadOnly = false;
            NapDuLieu();
        }

        private void dgvThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvThuoc.Rows[e.RowIndex].Tag is not Thuoc t) return;
            thuocDangChon = t;
            txtMaThuoc.Text = t.MaThuoc;
            txtMaThuoc.ReadOnly = true;
            txtTenThuoc.Text = t.TenThuoc;
            if (!cboDonViTinh.Items.Contains(t.DonViTinh))
                cboDonViTinh.Items.Add(t.DonViTinh);
            cboDonViTinh.SelectedItem = t.DonViTinh;
            nudSoLuong.Value = Math.Max(nudSoLuong.Minimum,
                Math.Min(nudSoLuong.Maximum, t.SoLuong));
            txtDonGia.Text = t.DonGia;
            if (t.HanSuDung >= dtpHanSuDung.MinDate && t.HanSuDung <= dtpHanSuDung.MaxDate)
                dtpHanSuDung.Value = t.HanSuDung;
        }

        private void XoaThongTin()
        {
            thuocDangChon = null;
            txtMaThuoc.ReadOnly = false;
            txtMaThuoc.Clear();
            txtTenThuoc.Clear();
            if (cboDonViTinh.Items.Count > 0) cboDonViTinh.SelectedIndex = 0;
            nudSoLuong.Value = 0;
            txtDonGia.Clear();
            dtpHanSuDung.Value = DateTime.Today;
        }

        private void pnlNhapLieu_Paint(object sender, PaintEventArgs e) { }

        private void cboDonViTinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
