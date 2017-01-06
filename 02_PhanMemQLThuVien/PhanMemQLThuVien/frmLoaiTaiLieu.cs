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
    public partial class frmLoaiTaiLieu : frmBaseFull
    {
        public frmLoaiTaiLieu()
        {
            InitializeComponent();
        }

        BLL_LoaiTaiLieu LoaiTL = new BLL_LoaiTaiLieu();
        private void frmLoaiTaiLieu_Load(object sender, EventArgs e)
        {
            Visible_Close(true);
            Functions.Enable_Groupbox(groupLoaiTL, false);
            LoaiTL.Load(dgvDanhSachLoaiTaiLieu);
            Functions.Clear(groupLoaiTL);
        }
        protected override void OnAdd()
        {
            Functions.Enable_Groupbox(groupLoaiTL, true);
            Functions.Clear(groupLoaiTL);
            txtMaLoaiTaiLieu.Focus();
        }
        protected override void OnEdit()
        {
            Functions.Enable_Groupbox(groupLoaiTL, true);
            txtMaLoaiTaiLieu.Enabled = false;
        }
        protected override void OnCancel()
        {
            Functions.Clear(groupLoaiTL);
            Functions.Enable_Groupbox(groupLoaiTL, false);
        }
        protected override void OnDeleted()
        {
            if (dgvDanhSachLoaiTaiLieu.SelectedRows == null)
            {
                MessageBox.Show("Chọn dữ liệu cần xóa");
            }
            else
            {
                LoaiTL.Delete(dgvDanhSachLoaiTaiLieu);
                LoaiTL.Load(dgvDanhSachLoaiTaiLieu);

                Functions.Clear(groupLoaiTL);
            }
        }
        protected override void OnSaveAdd()
        {
            LoaiTL.Add(txtMaLoaiTaiLieu.Text, txtTenLoaiTaiLieu.Text);
            LoaiTL.Load(dgvDanhSachLoaiTaiLieu);
            Functions.AfterSucess(dgvDanhSachLoaiTaiLieu, this, txtMaLoaiTaiLieu.Text, 0);
        }
        protected override void OnSaveEdit()
        {
            LoaiTL.Modify(dgvDanhSachLoaiTaiLieu.SelectedCells[0].Value.ToString(), txtTenLoaiTaiLieu.Text);
            LoaiTL.Load(dgvDanhSachLoaiTaiLieu);
            Functions.AfterSucess(dgvDanhSachLoaiTaiLieu, this, txtMaLoaiTaiLieu.Text, 0);
        }
        protected override void OnSave()
        {
            if (txtMaLoaiTaiLieu.Enabled == true)
                OnSaveAdd();
            else
                OnSaveEdit();

            EnableLoadForm();
            Functions.Enable_Groupbox(groupLoaiTL, false);
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text != "Nhập từ khóa cần tìm kiếm...")
            {
                LoaiTL.SearchTextBox(dgvDanhSachLoaiTaiLieu, txtTimKiem.Text);
                Functions.Enable_Groupbox(groupLoaiTL, false);
            }
        }

        private void dgvDanhSachLoaiTaiLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDanhSachLoaiTaiLieu.SelectedRows.Count != 0)
            {
                txtMaLoaiTaiLieu.Text = dgvDanhSachLoaiTaiLieu.SelectedCells[0].Value.ToString();
                txtTenLoaiTaiLieu.Text = dgvDanhSachLoaiTaiLieu.SelectedCells[1].Value.ToString();

            }
            Enable_DataGridView_CellClick();
            Functions.Enable_Groupbox(groupLoaiTL, false);
        }
    }
}
