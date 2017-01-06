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
    public partial class frmQuanLyNhaCungCap : frmBaseFull
    {
        public frmQuanLyNhaCungCap()
        {
            InitializeComponent();
        }
        BLL_QuanLyNhaCungCap nhaCC = new BLL_QuanLyNhaCungCap();
        private void frmQuanLyNhaCungCap_Load(object sender, EventArgs e)
        {
            Functions.Enable_Groupbox(grbTTNCC, false);
            nhaCC.Load(dgvQuanLyNhaCungCap);
            Functions.Clear(grbTTNCC);
            labelTongSLNCC.Text = nhaCC.SLNhaCungCap().ToString();
        }

        protected override void OnCancel()
        {
            Functions.Clear(grbTTNCC);
            Functions.Enable_Groupbox(grbTTNCC, false);
        }
        protected override void OnAdd()
        {
            Functions.Enable_Groupbox(grbTTNCC, true);
            Functions.Clear(grbTTNCC);
            txtMaNhaCungCap.Focus();
          
        }
        protected override void OnEdit()
        {
            Functions.Enable_Groupbox(grbTTNCC, true);
            txtMaNhaCungCap.Enabled = false;
        }
        protected override void OnDeleted()
        {
            if (dgvQuanLyNhaCungCap.SelectedRows == null)
                MessageBox.Show("Chọn dữ liệu cần xóa");
            else
            {
                nhaCC.Delete(dgvQuanLyNhaCungCap);
                nhaCC.Load(dgvQuanLyNhaCungCap);

                Functions.Clear(grbTTNCC);
                labelTongSLNCC.Text = nhaCC.SLNhaCungCap().ToString();
            }
        }
        protected override void OnSaveAdd()
        {
            nhaCC.Add(txtMaNhaCungCap.Text, txtTenNhaCungCap.Text, txtSoDienThoaiNCC.Text, txtDiaChiNCC.Text);
            nhaCC.Load(dgvQuanLyNhaCungCap);
            labelTongSLNCC.Text = nhaCC.SLNhaCungCap().ToString();
            Functions.AfterSucess(dgvQuanLyNhaCungCap, this, txtMaNhaCungCap.Text, "MaNhaCungCap");
        }
        protected override void OnSaveEdit()
        {
            nhaCC.Modify(dgvQuanLyNhaCungCap.SelectedCells[0].Value.ToString(), txtTenNhaCungCap.Text, txtSoDienThoaiNCC.Text, txtDiaChiNCC.Text);
            nhaCC.Load(dgvQuanLyNhaCungCap);
            Functions.AfterSucess(dgvQuanLyNhaCungCap, this, txtMaNhaCungCap.Text, "MaNhaCungCap");
        }
        protected override void OnSave()
        {
            if (txtMaNhaCungCap.Enabled == true)
            {
                OnSaveAdd();
            }
            else
            {
                OnSaveEdit();
            }
            EnableLoadForm();
            Functions.Enable_Groupbox(grbTTNCC, false);
        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if(txtTimKiem.Text!="Nhập từ khóa cần tìm kiếm...")
            {
                nhaCC.SearchTextBox(dgvQuanLyNhaCungCap, txtTimKiem.Text);
                Functions.Clear(grbTTNCC);
            }
        }
        private void dgvQuanLyNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvQuanLyNhaCungCap.SelectedRows.Count != 0)
            {
                txtMaNhaCungCap.Text = dgvQuanLyNhaCungCap.SelectedCells[0].Value.ToString();
                txtTenNhaCungCap.Text = dgvQuanLyNhaCungCap.SelectedCells[1].Value.ToString();
                txtSoDienThoaiNCC.Text = dgvQuanLyNhaCungCap.SelectedCells[2].Value.ToString();
                txtDiaChiNCC.Text = dgvQuanLyNhaCungCap.SelectedCells[3].Value.ToString();
            }
            Enable_DataGridView_CellClick();
            Functions.Enable_Groupbox(grbTTNCC, false);
        }
    }
}
