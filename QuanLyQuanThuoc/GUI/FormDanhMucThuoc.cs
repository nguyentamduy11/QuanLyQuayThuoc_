using QuanLyQuanThuoc.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyQuanThuoc.Models
{
    public partial class FormDanhMucThuoc : Form
    {
        BindingList<DanhMucThuoc> danhSach = new BindingList<DanhMucThuoc>();
        BindingSource nguonDuLieu = new BindingSource();

        public FormDanhMucThuoc()
        {
            InitializeComponent();
            if (System.ComponentModel.LicenseManager.UsageMode ==
                System.ComponentModel.LicenseUsageMode.Designtime) return;

            danhSach = new BindingList<DanhMucThuoc>(KhoDanhMucThuoc.DanhSach);
            cboTrangThai.Items.AddRange(new string[] { "Hoạt động", "Ngừng hoạt động" });
            cboTrangThai.SelectedIndex = 0;


            dgvDanhMuc.AutoGenerateColumns = false;
            
            ColMaDanhMuc.DataPropertyName = "MaDanhMuc";
            ColTenDanhMuc.DataPropertyName = "TenDanhMuc";
            ColMoTa.DataPropertyName = "MoTa";
            ColTrangThai.DataPropertyName = "TrangThai";
            nguonDuLieu.DataSource = danhSach;
            dgvDanhMuc.DataSource = nguonDuLieu;
            dgvDanhMuc.ClearSelection();
            dgvDanhMuc.CurrentCell = null;
            if (KhoDanhMucThuoc.LoiTaiDuLieu != null)
                MessageBox.Show(KhoDanhMucThuoc.LoiTaiDuLieu,
                    "Lỗi đọc SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }



        private void txtTimKiem_TextChanged(object sender, EventArgs e) => LocDanhMuc();

        private void LocDanhMuc()
        {
            string tim = txtTimKiem.Text.Trim();
            var ketQua = danhSach.Where(x =>
                string.IsNullOrEmpty(tim) ||
                x.MaDanhMuc.Contains(tim, StringComparison.OrdinalIgnoreCase) ||
                x.TenDanhMuc.Contains(tim, StringComparison.OrdinalIgnoreCase)).ToList();
            nguonDuLieu.DataSource = new BindingList<DanhMucThuoc>(ketQua);
            dgvDanhMuc.ClearSelection();
            dgvDanhMuc.CurrentCell = null;
        }

        private bool LuuSql()
        {
            if (KhoDanhMucThuoc.Luu(out string loi)) return true;
            MessageBox.Show(loi, "Lỗi lưu danh mục SQL",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        private void dgvDanhMuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DanhMucThuoc dm =
                dgvDanhMuc.Rows[e.RowIndex].DataBoundItem as DanhMucThuoc;

            if (dm == null) return;

            txtMaDanhMuc.Text = dm.MaDanhMuc;
            txtTenDanhMuc.Text = dm.TenDanhMuc;
            txtMoTa.Text = dm.MoTa;
            cboTrangThai.Text = dm.TrangThai;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaDanhMuc.Text.Trim() == "" ||
       txtTenDanhMuc.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            foreach (DanhMucThuoc dm in danhSach)
            {
                if (dm.MaDanhMuc == txtMaDanhMuc.Text.Trim())
                {
                    MessageBox.Show("Mã danh mục đã tồn tại!");
                    return;
                }
            }

            DanhMucThuoc danhMuc = new DanhMucThuoc
            {
                MaDanhMuc = txtMaDanhMuc.Text.Trim(),
                TenDanhMuc = txtTenDanhMuc.Text.Trim(),
                MoTa = txtMoTa.Text.Trim(),
                TrangThai = cboTrangThai.Text
            };

            danhSach.Add(danhMuc);
            if (!LuuSql()) { danhSach.Remove(danhMuc); return; }
            LocDanhMuc();
            MessageBox.Show("Thêm danh mục thành công!");
            btnLamMoi_Click(sender, e);
        }
        public void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvDanhMuc.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn danh mục để sửa!");
                return;
            }
            DanhMucThuoc danhMuc = dgvDanhMuc.CurrentRow.DataBoundItem as DanhMucThuoc;
            if (danhMuc != null)
            {
                string tenCu = danhMuc.TenDanhMuc;
                string moTaCu = danhMuc.MoTa;
                string trangThaiCu = danhMuc.TrangThai;
                danhMuc.TenDanhMuc = txtTenDanhMuc.Text.Trim();
                danhMuc.MoTa = txtMoTa.Text.Trim();
                danhMuc.TrangThai = cboTrangThai.Text;
                if (!LuuSql())
                {
                    danhMuc.TenDanhMuc = tenCu;
                    danhMuc.MoTa = moTaCu;
                    danhMuc.TrangThai = trangThaiCu;
                    return;
                }
                LocDanhMuc();
                MessageBox.Show("Sửa danh mục thành công!");
                btnLamMoi_Click(sender, e);
            }
        }
        public void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDanhMuc.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn danh mục để xóa!");
                return;
            }
            DanhMucThuoc danhMuc = dgvDanhMuc.CurrentRow.DataBoundItem as DanhMucThuoc;
            if (danhMuc != null)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa danh mục này?", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    int vitri = danhSach.IndexOf(danhMuc);
                    danhSach.Remove(danhMuc);
                    if (!LuuSql()) { danhSach.Insert(vitri, danhMuc); return; }
                    LocDanhMuc();
                    MessageBox.Show("Xóa danh mục thành công!");
                    btnLamMoi_Click(sender, e);
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaDanhMuc.Clear();
            txtTenDanhMuc.Clear();
            txtMoTa.Clear();
            txtTimKiem.Clear();

            cboTrangThai.SelectedIndex = 0;

            LocDanhMuc();

            txtMaDanhMuc.Focus();
        }
    }
}

