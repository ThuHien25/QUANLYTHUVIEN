using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using BLL;

namespace PhanMemQLThuVien
{
    public partial class frmDangNhap : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public frmDangNhap()
        {
            InitializeComponent();
            this.AcceptButton = btnDangNhap;
        }
        QL_NguoiDung CauHinh = new QL_NguoiDung();
        frmCauhinh ProcessConfig = null;

        QLThuVienDataContext qlThuVien = new QLThuVienDataContext();
        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            //this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;

            MaximizeBox = false;
            MinimizeBox = false;
        }


        public void ProcessLogin()
        {
            LoginResult result;
            result = CauHinh.Check_User(txtTaiKhoan.Text, CauHinh.Encrypt(txtMatKhau.Text));    //CauHinh.Encrypt(txtMatKhau.Text)         //Check_User viết trong Class QL_NguoiDung
            // Wrong username or pass
            if (result == LoginResult.Invalid)
            {
                MessageBox.Show("Sai " + lblTaiKhoan.Text + " Hoặc " +
                lblMatKhau.Text);
                return;
            }
            // Account had been disabled
            else if (result == LoginResult.Disabled)
            {
                MessageBox.Show("Tài khoản bị khóa");
                return;
            }
            if (Program.mainForm == null || Program.mainForm.IsDisposed)
            {
                Program.mainForm = new frmMain();
            }
            this.Visible = false;

            ThongTinNguoiDung.TenNguoiDung = txtTaiKhoan.Text;
            ThongTinNguoiDung.MatKhau = CauHinh.Encrypt(txtMatKhau.Text);

            var nd = (from n in qlThuVien.NGUOIDUNGs
                            join nv in qlThuVien.NHANVIENs on n.MaNV equals nv.MaNV
                            where n.TenTaiKhoan.Equals(txtTaiKhoan.Text)
                            select new { n.MaNV, nv.TenNV}).SingleOrDefault();

            ThongTinNguoiDung.MaNhanVien = nd.MaNV;
            ThongTinNguoiDung.TenNhanVien = nd.TenNV;

            Program.mainForm.Show();

        }

        private void btnDangNhap_Click_1(object sender, EventArgs e)
        {
            if (lblTaiKhoan.Text == "")
            {
                MessageBox.Show("Không được bỏ trống tài khoản");
                this.lblTaiKhoan.Focus();
                return;
            }
            if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Không được bỏ trống mật khẩu");
                this.txtMatKhau.Focus();
                return;
            }
            int kq = CauHinh.Check_Config(); //hàm Check_Config() thuộc Class QL_NguoiDung
            if (kq == 0)
            {

                ProcessLogin();// Cấu hình phù hợp xử lý đăng nhập
            }
            if (kq == 1)// Xử lý cấu hình
            {
                MessageBox.Show("Chuỗi cấu hình không tồn tại");
                ProcessConfig = new frmCauhinh();
                ProcessConfig.Show();
            }
            if (kq == 2)// Xử lý cấu hình
            {
                MessageBox.Show("Chuỗi cấu hình không phù hợp");
                ProcessConfig = new frmCauhinh();
                ProcessConfig.Show();
            }


        }

        private void btnHuy_Click_1(object sender, EventArgs e)
        {
            //txtTaiKhoan.Text  =  CauHinh.Encrypt(txtTaiKhoan.Text);
            this.Close();
            //Program.mainForm.Close();
        }
    }
}
