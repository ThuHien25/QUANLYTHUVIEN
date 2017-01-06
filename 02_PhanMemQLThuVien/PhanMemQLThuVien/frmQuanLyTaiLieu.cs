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
    public partial class frmQuanLyTaiLieu : frmBaseFull
    {

        public frmQuanLyTaiLieu()
        {
            InitializeComponent();
        }
        BLL_QuanLyTaiLieu qltl = new BLL_QuanLyTaiLieu();
        private void frmQuanLyTaiLieu_Load(object sender, EventArgs e)
        {
            Functions.Enable_Groupbox(grbThongTinTaiLieu, false);
            qltl.Load(dgvQuanLyTaiLieu);
            qltl.LoadCbbTheLoai(cbbLoaiTaiLieu);
            qltl.LoadCbbChuyenNganh(cbbChuyenNganh);
            Functions.Clear(grbThongTinTaiLieu);

            lblTongSLTaiLieu.Text = qltl.SLTaiLieu().ToString();
        }
        protected override void OnAdd()
        {
            Functions.Enable_Groupbox(grbThongTinTaiLieu, true);
            Functions.Clear(grbThongTinTaiLieu);
            txtMaTaiLieu.Focus();
        }
        protected override void OnEdit()
        {
            Functions.Enable_Groupbox(grbThongTinTaiLieu, true);
            txtMaTaiLieu.Enabled = false;
        }
        protected override void OnDeleted()
        {
            if (dgvQuanLyTaiLieu.SelectedRows == null)
                MessageBox.Show("Chọn dữ liệu cần xóa");
            else
            {
                qltl.Delete(dgvQuanLyTaiLieu);
                qltl.Load(dgvQuanLyTaiLieu);
                Functions.Clear(grbThongTinTaiLieu);
                lblTongSLTaiLieu.Text = qltl.SLTaiLieu().ToString();
            }
        }
        protected override void OnCancel()
        {
            Functions.Clear(grbThongTinTaiLieu);
            Functions.Enable_Groupbox(grbThongTinTaiLieu, false);
        }
        protected override void OnSaveAdd()
        {
            qltl.Add(txtMaTaiLieu.Text, txtTenTaiLieu.Text, cbbLoaiTaiLieu.SelectedValue.ToString(), txtTacGia.Text, int.Parse(txtNamXuatBan.Text), cbbChuyenNganh.SelectedValue.ToString(), txtMoTaTaiLieu.Text);
            qltl.Load(dgvQuanLyTaiLieu);
            Functions.AfterSucess(dgvQuanLyTaiLieu, this, txtMaTaiLieu.Text, 0);
            lblTongSLTaiLieu.Text = qltl.SLTaiLieu().ToString();
        }
        protected override void OnSaveEdit()
        {
            string ma = dgvQuanLyTaiLieu.SelectedCells[0].Value.ToString();
            string ten = txtTenTaiLieu.Text;
            string loai = cbbLoaiTaiLieu.SelectedValue.ToString();
            string tacgia = txtTacGia.Text;
            int namXB = int.Parse(txtNamXuatBan.Text);
            string chuyennganh = cbbChuyenNganh.SelectedValue.ToString();
            string mota = txtMoTaTaiLieu.Text;

            qltl.Modify(ma, ten, loai, tacgia, namXB, chuyennganh, mota);
            qltl.Load(dgvQuanLyTaiLieu);
            Functions.AfterSucess(dgvQuanLyTaiLieu, this, txtMaTaiLieu.Text, 0);
        }
        protected override void OnSave()
        {
            if (txtMaTaiLieu.Enabled == true)
                OnSaveAdd();
            else
                OnSaveEdit();
            EnableLoadForm();
            Functions.Enable_Groupbox(grbThongTinTaiLieu, false);
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "Nhập từ khóa cần tìm kiếm...")
            {
                qltl.SearchTextBox(dgvQuanLyTaiLieu, txtTimKiem.Text);
                Functions.Clear(grbThongTinTaiLieu);
            }
        }

        private void dgvQuanLyTaiLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvQuanLyTaiLieu.SelectedRows.Count != 0)
            {
                txtMaTaiLieu.Text = dgvQuanLyTaiLieu.SelectedCells[0].Value.ToString();
                txtTenTaiLieu.Text = dgvQuanLyTaiLieu.SelectedCells[1].Value.ToString();
                cbbLoaiTaiLieu.Text = dgvQuanLyTaiLieu.CurrentRow.Cells["TenLoai"].Value.ToString();
                cbbChuyenNganh.Text = dgvQuanLyTaiLieu.CurrentRow.Cells["TenChuyenNganh"].Value.ToString();
                txtTacGia.Text = dgvQuanLyTaiLieu.CurrentRow.Cells["TacGia"].Value.ToString();
                txtNamXuatBan.Text = dgvQuanLyTaiLieu.CurrentRow.Cells["NamXuatBan"].Value.ToString();
                txtMoTaTaiLieu.Text = dgvQuanLyTaiLieu.CurrentRow.Cells["MoTa"].Value.ToString();
            }
            Enable_DataGridView_CellClick();
            Functions.Enable_Groupbox(grbThongTinTaiLieu, false);
        }

        private void btnThemLoaiTaiLieu_Click(object sender, EventArgs e)
        {
            frmLoaiTaiLieu frm = new frmLoaiTaiLieu();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            qltl.LoadCbbTheLoai(cbbLoaiTaiLieu);
        }
        private void btnThemNhaXuatBan_Click(object sender, EventArgs e)
        {
            frmChuyenNganh frm = new frmChuyenNganh();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            qltl.LoadCbbChuyenNganh(cbbChuyenNganh);
        }
        private void tableLayoutPanel3_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.Show("Tìm kiếm theo mã tài liệu, tên tài liệu, thể loại, tác giả, chuyên ngành",txtTimKiem);
        }

    }
}