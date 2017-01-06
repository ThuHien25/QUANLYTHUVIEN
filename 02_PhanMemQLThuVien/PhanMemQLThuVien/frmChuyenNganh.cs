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
    public partial class frmChuyenNganh : frmBaseFull
    {
        public frmChuyenNganh()
        {
            InitializeComponent();
        }
        BLL_ChuyenNganh chuyennganh = new BLL_ChuyenNganh();
        private void frmNhaXuatBan_Load(object sender, EventArgs e)
        {
            Visible_Close(true);
            Functions.Enable_Groupbox(groupTTLoaiChuyenNganh, false);
            chuyennganh.Load(dgvDanhSachChuyenNganh);
            Functions.Clear(groupTTLoaiChuyenNganh);
        }
        
        protected override void OnAdd()
        {
            Functions.Enable_Groupbox(groupTTLoaiChuyenNganh, true);
            Functions.Clear(groupTTLoaiChuyenNganh);
            txtMaChuyenNganh.Focus();
        }
        protected override void OnEdit()
        {
            Functions.Enable_Groupbox(groupTTLoaiChuyenNganh, true);
            txtMaChuyenNganh.Enabled = false;
        }
        protected override void OnCancel()
        {
            Functions.Clear(groupTTLoaiChuyenNganh);
            Functions.Enable_Groupbox(groupTTLoaiChuyenNganh, false);
        }
        protected override void OnDeleted()
        {
            if (dgvDanhSachChuyenNganh.SelectedRows == null)
                MessageBox.Show("Chọn dữ liệu cần xóa");
            else
            {
                chuyennganh.Delete(dgvDanhSachChuyenNganh);
                chuyennganh.Load(dgvDanhSachChuyenNganh);

                Functions.Clear(groupTTLoaiChuyenNganh);
            }
        }
        protected override void OnSaveAdd()
        {
            chuyennganh.Add(txtMaChuyenNganh.Text, txtTenChuyenNganh.Text);
            chuyennganh.Load(dgvDanhSachChuyenNganh);
            Functions.AfterSucess(dgvDanhSachChuyenNganh, this, txtMaChuyenNganh.Text, 0);
        }
        protected override void OnSaveEdit()
        {
            chuyennganh.Modify(dgvDanhSachChuyenNganh.SelectedCells[0].Value.ToString(), txtTenChuyenNganh.Text);
            chuyennganh.Load(dgvDanhSachChuyenNganh);
            Functions.AfterSucess(dgvDanhSachChuyenNganh, this, txtMaChuyenNganh.Text, 0);
        }
        protected override void OnSave()
        {
            if (txtMaChuyenNganh.Enabled == true) //Thêm 
                OnSaveAdd();
            else OnSaveEdit();
            EnableLoadForm();
            Functions.Enable_Groupbox(groupTTLoaiChuyenNganh, false);
        }
        private void dgvDanhSachNhaXuatBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDanhSachChuyenNganh.SelectedRows.Count != 0)
            {
                txtMaChuyenNganh.Text = dgvDanhSachChuyenNganh.SelectedCells[0].Value.ToString();
                txtTenChuyenNganh.Text = dgvDanhSachChuyenNganh.SelectedCells[1].Value.ToString();
            }
            Enable_DataGridView_CellClick();
            Functions.Enable_Groupbox(groupTTLoaiChuyenNganh, false);
        }

        private void txtTimKiem_TextChanged_1(object sender, EventArgs e)
        {
            if (txtTimKiem.Text != "Nhập từ khóa cần tìm kiếm...")
            {
                chuyennganh.SearchTextBox(dgvDanhSachChuyenNganh, txtTimKiem.Text);
                Functions.Clear(groupTTLoaiChuyenNganh);
            }
        }

        private void txtTimKiem_MouseEnter_1(object sender, EventArgs e)
        {
            toolTip1.Show("Tìm kiếm theo mã chuyên ngành, tên chuyên ngành", txtTimKiem);
        }
    }
}
