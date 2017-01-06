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
    public partial class frmQuanLyNguoiDung : frmBaseFull
    {
        public frmQuanLyNguoiDung()
        {
            InitializeComponent();
        }
        BLL_QuanLyNguoiDung nd = new BLL_QuanLyNguoiDung();
        private void frmQuanLyNguoiDung_Load(object sender, EventArgs e)
        {
            EnableLoadForm();
            nd.Loaddgv(dtgvDanhSachNguoiDung);
            nd.Loadcbb(cbbTenNhanVien);
            Functions.Enable_Groupbox(grbNguoiDung, false);
            Functions.Clear(grbNguoiDung);
            lblTongSoNguoiDung.Text = nd.TongSoNguoiDung().ToString();
        }
        protected override void OnAdd()
        {
            Functions.Enable_Groupbox(grbNguoiDung, true);
            Functions.Clear(grbNguoiDung);
            txtTenTaiKhoan.Focus();
        }
        protected override void OnEdit()
        {
            Functions.Enable_Groupbox(grbNguoiDung, true);
            txtTenTaiKhoan.Enabled = false;
        }
        protected override void OnDeleted()
        {
            if (dtgvDanhSachNguoiDung.SelectedRows == null)
                MessageBox.Show("Chọn dữ liệu cần xóa!");
            else
            {
                nd.Delete(dtgvDanhSachNguoiDung);
                nd.Loaddgv(dtgvDanhSachNguoiDung);
                Functions.Clear(grbNguoiDung);
            }
            lblTongSoNguoiDung.Text = nd.TongSoNguoiDung().ToString();
        }
        protected override void OnSaveAdd()
        {
            QL_NguoiDung nguoidung  = new QL_NguoiDung();
            bool hoatDong = true;
            if (rdbCon.Checked)
                hoatDong = true;
            else if (rdbNgung.Checked)
                hoatDong = false;
            nd.Add(txtTenTaiKhoan.Text, cbbTenNhanVien.SelectedValue.ToString(), nguoidung.Encrypt(txtMatKhau.Text), hoatDong);
            lblTongSoNguoiDung.Text = nd.TongSoNguoiDung().ToString();
        }
        protected override void OnSaveEdit()
        {
            QL_NguoiDung nguoidung = new QL_NguoiDung();
            bool hoatDong = true;
            if (rdbCon.Checked)
                hoatDong = true;
            else if (rdbNgung.Checked)
                hoatDong = false;
            nd.Modify(dtgvDanhSachNguoiDung.SelectedCells[2].Value.ToString(), cbbTenNhanVien.SelectedValue.ToString(), nguoidung.Encrypt(txtMatKhau.Text), hoatDong);
                
        }

        protected override void OnSave()
        {
            if (txtTenTaiKhoan.Enabled == true)
                OnSaveAdd();
            else
                OnSaveEdit();
            nd.Loaddgv(dtgvDanhSachNguoiDung);
            Functions.AfterSucess(dtgvDanhSachNguoiDung, this, txtTenTaiKhoan.Text, 0);
            EnableLoadForm();
            Functions.Enable_Groupbox(grbNguoiDung, false);


        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if(txtTimKiem.Text !="Nhập từ khóa cần tìm kiếm...")
            {
                nd.SearchTextBox(dtgvDanhSachNguoiDung, txtTimKiem.Text);
                Functions.Clear(grbNguoiDung);
            }
        }

        private void dtgvDanhSachNguoiDung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           string s = dtgvDanhSachNguoiDung.CurrentRow.Cells["HoatDong"].Value.ToString();
            if(dtgvDanhSachNguoiDung.SelectedRows.Count!=0)
            {
                txtTenTaiKhoan.Text = dtgvDanhSachNguoiDung.SelectedCells[2].Value.ToString();
                if (s == "True")
                {
                    rdbNgung.Checked = false;
                    rdbCon.Checked = true; 
                }
                else
                {
                    rdbCon.Checked = false;
                    rdbNgung.Checked = true;
                }
                cbbTenNhanVien.SelectedValue = dtgvDanhSachNguoiDung.SelectedCells[0].Value.ToString();
               // cbbTenNhanVien.DisplayMember= dtgvDanhSachNguoiDung.CurrentRow.Cells["TenNV"].Value.ToString();
                txtMatKhau.Text = dtgvDanhSachNguoiDung.SelectedCells[3].Value.ToString();
                    
            }
            Enable_DataGridView_CellClick();
            Functions.Enable_Groupbox(grbNguoiDung, false);
        }
        protected override void OnCancel()
        {
            Functions.Clear(grbNguoiDung);
            Functions.Enable_Groupbox(grbNguoiDung, false);
        }
    }
}
