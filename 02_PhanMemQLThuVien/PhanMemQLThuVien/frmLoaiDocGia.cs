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
    public partial class frmLoaiDocGia : frmBaseFull
    {
        public frmLoaiDocGia()
        {
            InitializeComponent();
        }
        BLL_LoaiDocGia loaidg = new BLL_LoaiDocGia();
        private void frmLoaiDocGia_Load(object sender, EventArgs e)
        {
            Visible_Close(true);
            Functions.Enable_Groupbox(groupTTLoaiDocGia, false);
            loaidg.Load(dgvDanhSachLoaiDocGia);
            Functions.Clear(groupTTLoaiDocGia);
            Visible_Close(true);
        }
        protected override void OnAdd()
        {
            Functions.Enable_Groupbox(groupTTLoaiDocGia, true);
            Functions.Clear(groupTTLoaiDocGia);
            txtMaLoaiDocGia.Focus();
        }
        protected override void OnEdit()
        {
            Functions.Enable_Groupbox(groupTTLoaiDocGia, true);
            txtMaLoaiDocGia.Enabled = false;
        }
        protected override void OnCancel()
        {
            Functions.Clear(groupTTLoaiDocGia);
            Functions.Enable_Groupbox(groupTTLoaiDocGia, false);
        }
        protected override void OnDeleted()
        {
            if (dgvDanhSachLoaiDocGia.SelectedRows == null)
                MessageBox.Show("Chọn dữ liệu cần xóa");
            else
            {
                loaidg.Delete(dgvDanhSachLoaiDocGia);
                loaidg.Load(dgvDanhSachLoaiDocGia);

                Functions.Clear(groupTTLoaiDocGia);
                //btnThem.Enabled = true;
                //btnCancel.Enabled = false;
            }
        }
        protected override void OnSaveAdd() 
        { 
            loaidg.Add(txtMaLoaiDocGia.Text, txtTenLoaiDocGia.Text);
            loaidg.Load(dgvDanhSachLoaiDocGia);
            Functions.AfterSucess(dgvDanhSachLoaiDocGia, this, txtMaLoaiDocGia.Text, 0);
        }
        protected override void OnSaveEdit() 
        { 
            loaidg.Modify(dgvDanhSachLoaiDocGia.SelectedCells[0].Value.ToString(), txtTenLoaiDocGia.Text);
            loaidg.Load(dgvDanhSachLoaiDocGia);
            Functions.AfterSucess(dgvDanhSachLoaiDocGia, this, txtMaLoaiDocGia.Text, 0);
        }
        protected override void OnSave() 
        {
            if (txtMaLoaiDocGia.Enabled == true) //Thêm 
                OnSaveAdd(); 
            else OnSaveEdit(); 
            EnableLoadForm();    
            Functions.Enable_Groupbox(groupTTLoaiDocGia, false); 
        }
        private void dtgvDanhSachLoaiDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDanhSachLoaiDocGia.SelectedRows.Count != 0)
            {
                txtMaLoaiDocGia.Text = dgvDanhSachLoaiDocGia.SelectedCells[0].Value.ToString();
                txtTenLoaiDocGia.Text = dgvDanhSachLoaiDocGia.SelectedCells[1].Value.ToString();
            }
            Enable_DataGridView_CellClick();
            Functions.Enable_Groupbox(groupTTLoaiDocGia, false);
        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text != "Nhập từ khóa cần tìm kiếm...")
            {
                loaidg.SearchTextBox(dgvDanhSachLoaiDocGia, txtTimKiem.Text);
                Functions.Clear(groupTTLoaiDocGia);
            }
        }

        private void txtTimKiem_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.Show("Tìm kiếm theo mã loại, tên loại.", txtTimKiem);
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
        
    }
}
