using QuanLyQuanThuoc.Models;
using System;
using System.Windows.Forms;


namespace QuanLyQuanThuoc
{

    public partial class Form1 : Form
    {
        private Form? formHienTai;

        public Form1()
        {
            InitializeComponent();
        }



        private void MoForm(Form f)
        {
            if (formHienTai != null)
            {
                formHienTai.Close();
                formHienTai.Dispose();
            }

            formHienTai = f;
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;



            panelNoiDung.Controls.Clear();
            panelNoiDung.Controls.Add(f);
            f.Show();
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            MoForm(new FormTrangChu());
        }

        private void btnThuoc_Click(object sender, EventArgs e)
        {
            MoForm(new FormQuanLyThuoc());
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            MoForm(new FormDanhMucThuoc());
        }

        private void btnDonViTinh_Click(object sender, EventArgs e)
        {
            MoForm(new FormDonViTinh());
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            MoForm(new FormHoaDon());
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            MoForm(new FormQuanLyNhanVien());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MoForm(new FormTrangChu());
        }
    }
}