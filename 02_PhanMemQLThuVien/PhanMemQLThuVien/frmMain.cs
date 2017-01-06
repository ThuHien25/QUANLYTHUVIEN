using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;



namespace PhanMemQLThuVien
{
    public partial class frmMain : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
        private bool CheckFormOpen(string name)
        {
            foreach (TabItem item in tabControl1.Tabs)
            {
                if (item.Text == name)
                {
                    tabControl1.SelectedTab = item;
                    return true;
                }
            }
            return false;
        }
        private void MoFromCon(Form frm)
        {
            if (CheckFormOpen(frm.Text))
                return;
            TabItem tb = tabControl1.CreateTab(frm.Text);
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            tb.AttachedControl.Controls.Add(frm);
            frm.Show();
            tabControl1.SelectedTab = tb;
        }
        private void btnTaiLieu_Click(object sender, EventArgs e)
        {
            frmQuanLyTaiLieu frm = new frmQuanLyTaiLieu();
            MoFromCon(frm);

        }
        private void btnLoaiTaiLieu_Click(object sender, EventArgs e)
        {
            frmLoaiTaiLieu frm = new frmLoaiTaiLieu();
            MoFromCon(frm);
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            frmQuanLyNhaCungCap frm = new frmQuanLyNhaCungCap();
            MoFromCon(frm);
        }

        private void btnNhaXuatBan_Click(object sender, EventArgs e)
        {
            frmChuyenNganh frm = new frmChuyenNganh();
            MoFromCon(frm);
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            frmQuanLyNhanVien frm = new frmQuanLyNhanVien();
            MoFromCon(frm);
        }

        private void btnDocGia_Click(object sender, EventArgs e)
        {
            frmQuanLyDocGia frm = new frmQuanLyDocGia();
            MoFromCon(frm);
        }

        private void btnLoaiDocGia_Click(object sender, EventArgs e)
        {
            frmLoaiDocGia frm = new frmLoaiDocGia();
            MoFromCon(frm);
        }

        private void btnNhapTaiLieu_Click(object sender, EventArgs e)
        {
            frmHoaDonTaiLieu frm = new frmHoaDonTaiLieu();
            MoFromCon(frm);
        }

        private void btnMuonTra_Click(object sender, EventArgs e)
        {
            frmMuonTra frm = new frmMuonTra();
            MoFromCon(frm);
        }

        private void btnTimKiemDocGia_Click(object sender, EventArgs e)
        {
            frmTimKiemDocGia frm = new frmTimKiemDocGia();
            MoFromCon(frm);
        }

        private void btnTimKiemTaiLieu_Click(object sender, EventArgs e)
        {
            frmTimKiemTaiLieu frm = new frmTimKiemTaiLieu();
            MoFromCon(frm);
        }

        private void btnTimKiemNhaCungCap_Click(object sender, EventArgs e)
        {
            frmTimKiemNhaCungCap frm = new frmTimKiemNhaCungCap();
            MoFromCon(frm);
        }

        private void btnQLNguoiDung_Click(object sender, EventArgs e)
        {
            frmQuanLyNguoiDung frm = new frmQuanLyNguoiDung();
            MoFromCon(frm);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmDangNhap frm = new frmDangNhap();
            frm.Show();

        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau frm = new frmDoiMatKhau();
            frm.ShowDialog(this);
            //openFrom(frm, "frmDoiMatKhau", "");
        }

       

        private void btnDocGiaQuaHan_Click(object sender, EventArgs e)
        {
            frmThongKeBaoCaoDocGia frm = new frmThongKeBaoCaoDocGia();
            MoFromCon(frm);
        }

        private void btnSachMuon_Click(object sender, EventArgs e)
        {
            frmThongKeBaoCaoMuonTra frm = new frmThongKeBaoCaoMuonTra();
            MoFromCon(frm);
        }

        private void btnSoLuongTaiLieu_Click(object sender, EventArgs e)
        {
            frmThongKeBaoCaoTaiLieu frm = new frmThongKeBaoCaoTaiLieu();
            MoFromCon(frm);
        }

        private void btnPhanQuyen_Click(object sender, EventArgs e)
        {
            frmPhanQuyenTheoNhomDung frm = new frmPhanQuyenTheoNhomDung();
            MoFromCon(frm);
        }

        private void btnQLNhomNguoiDung_Click(object sender, EventArgs e)
        {
            frmQuanLyNhomNguoiDung frm = new frmQuanLyNhomNguoiDung();
            MoFromCon(frm);
        }

        private void btnThemNguoiDungVaoNhom_Click(object sender, EventArgs e)
        {
            frmThemNguoiDungVaoNhom frm = new frmThemNguoiDungVaoNhom();
            MoFromCon(frm);
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
            Program.loginForm.Close();
        }

        private void btnHuongDanSuDung_Click_1(object sender, EventArgs e)
        {
            frmGioiThieu frm = new frmGioiThieu();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }
    }
}
