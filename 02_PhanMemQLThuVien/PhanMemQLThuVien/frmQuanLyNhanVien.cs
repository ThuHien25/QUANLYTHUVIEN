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
    public partial class frmQuanLyNhanVien : frmBaseFull
    {
        public frmQuanLyNhanVien()
        {
            InitializeComponent();
        }
        BLL_QuanLyNhanVien nv = new BLL_QuanLyNhanVien();
        private void frmQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            nv.Loaddgv(dgvQuanLyNhanVien);
            Functions.Enable_Groupbox(grbNhanVien, false);
            Functions.Clear(grbNhanVien);
            lblTongNhanVien.Text = nv.TongNhanVien().ToString();
        }
        protected override void OnAdd()
        {
            Functions.Enable_Groupbox(grbNhanVien, true);
            Functions.Clear(grbNhanVien);
           // txtMaNhanVien.Enabled = false;
            txtMaNhanVien.Focus();
        }
        protected override void OnEdit()
        {
            Functions.Enable_Groupbox(grbNhanVien, true);
            txtMaNhanVien.Enabled = false;
        }
        protected override void OnDeleted()
        {
            if (dgvQuanLyNhanVien.SelectedRows.Count == 0)
                MessageBox.Show("Chọn dữ liệu cần xóa!");
            else
            {
                nv.Delete(dgvQuanLyNhanVien);
                nv.Loaddgv(dgvQuanLyNhanVien);
                Functions.Clear(grbNhanVien);
            }
        }
        protected override void OnSaveAdd()
        {
            //string ma = Functions.AutoCode("NV");
            nv.Add(txtMaNhanVien.Text, txtTenNhanVien.Text, txtChucVuNV.Text, txtSoDienThoaiNV.Text, txtDiaChiNhanVien.Text, txtEmail.Text);
            lblTongNhanVien.Text = nv.TongNhanVien().ToString();
        }
        protected override void OnSaveEdit()
        {
            nv.Modify(dgvQuanLyNhanVien.SelectedCells[0].Value.ToString(), txtTenNhanVien.Text, txtChucVuNV.Text, txtSoDienThoaiNV.Text, txtDiaChiNhanVien.Text, txtEmail.Text);
            lblTongNhanVien.Text = nv.TongNhanVien().ToString();
        }
        protected override void OnSave()
        {
            if (txtMaNhanVien.Enabled == true)
                OnSaveAdd();
            else
                OnSaveEdit();
            nv.Loaddgv(dgvQuanLyNhanVien);
            Functions.AfterSucess(dgvQuanLyNhanVien, this, txtMaNhanVien.Text, 0);
            EnableLoadForm();
            Functions.Enable_Groupbox(grbNhanVien, false);
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if(txtTimKiem.Text != "Nhập từ khóa cần tìm kiếm...")
            {
                nv.SearchTextBox(dgvQuanLyNhanVien, txtTimKiem.Text);
                Functions.Clear(dgvQuanLyNhanVien);
            }
        }

        private void dgvQuanLyNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvQuanLyNhanVien.SelectedRows.Count != 0)
            {
                txtMaNhanVien.Text = dgvQuanLyNhanVien.SelectedCells[0].Value.ToString();
                txtTenNhanVien.Text = dgvQuanLyNhanVien.SelectedCells[1].Value.ToString();
                txtChucVuNV.Text = dgvQuanLyNhanVien.SelectedCells[2].Value.ToString();
                txtSoDienThoaiNV.Text = dgvQuanLyNhanVien.SelectedCells[3].Value.ToString();
                txtDiaChiNhanVien.Text = dgvQuanLyNhanVien.SelectedCells[4].Value.ToString();
                txtEmail.Text = dgvQuanLyNhanVien.SelectedCells[5].Value.ToString();
            }
            Enable_DataGridView_CellClick();// hiện xóa sửa
            Functions.Enable_Groupbox(grbNhanVien, false);

        }
        protected override void OnCancel()
        {
            Functions.Clear(grbNhanVien);
            Functions.Enable_Groupbox(grbNhanVien, false);
        }

    }
}
