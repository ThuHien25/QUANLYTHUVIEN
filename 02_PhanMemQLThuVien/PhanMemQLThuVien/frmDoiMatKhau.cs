using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
namespace PhanMemQLThuVien
{
    public partial class frmDoiMatKhau : DevComponents.DotNetBar.Office2007Form
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
            this.AcceptButton = btnDoiMatKhau;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        QL_NguoiDung CauHinh = new QL_NguoiDung();
        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {

        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            int kt = KiemTraTextbox();
            if (kt == 1)
            {
                MessageBox.Show("Thông tin chưa được điền đầy đủ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (kt == 2)
            {
                MessageBox.Show(label_PassOld.Text + " không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (kt == 3)
            { 
                MessageBox.Show(label_PassNew1.Text + " và " + label_PassNew2.Text + " không khớp với nhau!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                return; 
            }
            else if (kt == 4)
            { 
                MessageBox.Show("Độ dài " + label_PassNew1.Text + " phải lớn hơn hoặc bằng 6 ký tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                return; 
            }
            else if (kt == 5)
            { 
                MessageBox.Show(label_PassNew1.Text + " phải có ít nhất 1 ký tự đặc biệt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                return;
            }
            else
                Modify(ThongTinNguoiDung.TenNguoiDung, CauHinh.Encrypt(txtMatKhauMoi.Text));
            
            
            
        }
        QLThuVienDataContext qltv = new QLThuVienDataContext();
        public void Modify(string tendangnhap, string matkhau)
        {
            NGUOIDUNG nguoidung = qltv.NGUOIDUNGs.Where(p => p.TenTaiKhoan == tendangnhap).FirstOrDefault();
            if (nguoidung != null)
            {
                nguoidung.MatKhau = matkhau;
                qltv.SubmitChanges();
                MessageBox.Show("Đổi mật khẩu thành công!");
            }
        }

        private void txtMatKhauMoi_MouseLeave(object sender, EventArgs e)
        {

        }

        private void txtNhapLaiMatKhauMoi_MouseLeave(object sender, EventArgs e)
        {

        }
        private int KiemTraTextbox()
        {
            string s = txtMatKhauMoi.Text;
            int dem = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (!char.IsDigit(s[i]) && !char.IsLetter(s[i]))
                    dem++;
            }
            if (txtMatKhauCu.Text == string.Empty || txtNhapLaiMatKhauMoi.Text == string.Empty || txtMatKhauMoi.Text == string.Empty)
                return 1;
            if (CauHinh.Encrypt(txtMatKhauCu.Text) != ThongTinNguoiDung.MatKhau)
                return 2;
            if (txtMatKhauMoi.Text != txtNhapLaiMatKhauMoi.Text)
                return 3;
            if (s.Length < 6)
                return 4;
            if (dem == 0)
                return 5;
            return 0;
        }
    }
}
