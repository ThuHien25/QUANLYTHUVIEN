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
    public partial class frmHoaDonTaiLieu : frmBaseFull
    {
        public frmHoaDonTaiLieu()
        {
            InitializeComponent();
        }
        BLL_HoaDon hoadon = new BLL_HoaDon();
        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            Visible_Sua(false);
            Functions.Enable_Groupbox(groupTTHoaDon, false);
            Functions.Enable_Groupbox(groupTTChiTietHoaDon, false);

            hoadon.LoadComboBox_NhaCungCap(cmbNhaCungCap);
            hoadon.LoadComboBox_TaiLieu(cmbTenTaiLieu);
            hoadon.LoadDataGridView(dgvDanhSachHoaDon);

            labelTongGiaTriSach.Text = (hoadon.TongGiaTriHD()).ToString("#,#0");

            Functions.Clear(groupTTHoaDon);
            Functions.Clear(groupTTChiTietHoaDon);
        }
        protected override void OnAdd()
        {
            Functions.Enable_Groupbox(groupTTHoaDon, true);
            txtTongTien.Enabled = false;
            Functions.Clear(groupTTHoaDon);
            cmbNhaCungCap.Focus();
        }
        protected override void OnDeleted()
        {
            if (dgvDanhSachHoaDon.SelectedRows == null)
                MessageBox.Show("Chọn dữ liệu cần xóa");
            else
            {
                hoadon.Delete(dgvDanhSachHoaDon);
                hoadon.LoadDataGridView(dgvDanhSachHoaDon);

                Functions.Clear(groupTTHoaDon);
             }
        }
        protected override void OnCancel()
        {
            Functions.Clear(groupTTHoaDon);
            Functions.Enable_Groupbox(groupTTHoaDon, false);
        }
        protected override void OnSaveAdd()
        {
            hoadon.Add(cmbNhaCungCap.SelectedValue.ToString(), int.Parse(txtTongTien.Text));
            hoadon.LoadDataGridView(dgvDanhSachHoaDon);
        }
        protected override void OnSave()
        {
            OnSaveAdd();
            EnableLoadForm();
            Functions.Enable_Groupbox(groupTTHoaDon, false);
            Functions.Enable_Groupbox(groupTTChiTietHoaDon, false);
        }
        private void dgvDanhSachHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDanhSachHoaDon.SelectedRows.Count != 0)
            {
                cmbNhaCungCap.Text = dgvDanhSachHoaDon.CurrentRow.Cells["TenNCC"].Value.ToString();
                txtTongTien.Text = dgvDanhSachHoaDon.CurrentRow.Cells["TongTien"].Value.ToString();
            
            }
            Enable_DataGridView_CellClick();
            Functions.Enable_Groupbox(groupTTHoaDon, false);
            Functions.Enable_Groupbox(groupTTChiTietHoaDon, false);
        }
        private void cmbTenTaiLieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaTaiLieu.Text = cmbTenTaiLieu.SelectedValue.ToString();
        }

        private void dgvDanhSachHoaDon_SelectionChanged(object sender, EventArgs e)
        {
            hoadon.LoadCTHD(dgvDanhSachChiTietHoaDon, dgvDanhSachHoaDon.CurrentRow.Cells["MaHoaDon"].Value.ToString());
            btnThemCTHD.Enabled = true;
        }

        private void btnThemCTHD_Click(object sender, EventArgs e)
        {
            if (btnThemCTHD.Text == "Thêm")
            {
                Functions.Clear(groupTTChiTietHoaDon);
                Functions.Enable_Groupbox(groupTTChiTietHoaDon, true);
                txtMaTaiLieu.Enabled = txtThanhTien.Enabled = false;
                btnXoaCTHD.Enabled = false;
                btnThemCTHD.Text = "Lưu";
            }
            else
            {
                if (txtSoLuong.Text == string.Empty || txtDonGia.Text == string.Empty)
                    MessageBox.Show("Vui lòng nhập đủ thông tin.");
                else
                {
                    hoadon.AddCTHD(dgvDanhSachHoaDon.CurrentRow.Cells["MaHoaDon"].Value.ToString(), txtMaTaiLieu.Text, int.Parse(txtSoLuong.Text), int.Parse(txtDonGia.Text), int.Parse(txtThanhTien.Text));

                    btnThemCTHD.Text = "Thêm";
                    Functions.Enable_Groupbox(groupTTChiTietHoaDon, false);
                    Functions.AfterSucess(dgvDanhSachChiTietHoaDon, this, txtMaTaiLieu.Text, "MaTL");
                    
                    hoadon.update(dgvDanhSachHoaDon.CurrentRow.Cells["MaHoaDon"].Value.ToString());
                    hoadon.LoadDataGridView(dgvDanhSachHoaDon);
                    labelTongGiaTriSach.Text = (hoadon.TongGiaTriHD()).ToString("#,#0");
                    
                }
                
            }
        }

        private void btnXoaCTHD_Click(object sender, EventArgs e)
        {
            btnThemCTHD.Enabled = false;
            hoadon.DeleteCTHD(dgvDanhSachChiTietHoaDon);
            
            labelTongGiaTriSach.Text = (hoadon.TongGiaTriHD()).ToString("#,#0");
            hoadon.update(dgvDanhSachHoaDon.CurrentRow.Cells["MaHoaDon"].Value.ToString());
            hoadon.LoadDataGridView(dgvDanhSachHoaDon);
        }

        private void dgvDanhSachChiTietHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbTenTaiLieu.Text = dgvDanhSachChiTietHoaDon.CurrentRow.Cells["TenTaiLieu"].Value.ToString();
            txtMaTaiLieu.Text = dgvDanhSachChiTietHoaDon.CurrentRow.Cells["MaTL"].Value.ToString();
            txtDonGia.Text = dgvDanhSachChiTietHoaDon.CurrentRow.Cells["DonGia"].Value.ToString();
            txtSoLuong.Text = dgvDanhSachChiTietHoaDon.CurrentRow.Cells["SoLuong"].Value.ToString();
            txtThanhTien.Text = dgvDanhSachChiTietHoaDon.CurrentRow.Cells["ThanhTien"].Value.ToString();

            btnXoaCTHD.Enabled = btnThemCTHD.Enabled = true;
        }

        
        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSoLuong.Text != string.Empty && txtDonGia.Text != string.Empty)
                {
                    int a = int.Parse(txtSoLuong.Text),
                    b = int.Parse(txtDonGia.Text);
                    if (a > 0 && b > 0)
                        txtThanhTien.Text = (a * b).ToString();
                }
            }
            catch { }
            
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text != "Nhập từ khóa cần tìm kiếm...")
            {
                hoadon.SearchTextBox(dgvDanhSachHoaDon, txtTimKiem.Text);
                Functions.Clear(groupTTHoaDon);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (DateTime.Compare(dtpNgayBD.Value, dtpNgayKT.Value) > 0)
            {
                MessageBox.Show("Ngày kết thúc >= Ngày bắt đầu");
                dtpNgayBD.Value = dtpNgayKT.Value = DateTime.Now;
            }
            else
                hoadon.SearchDate(dgvDanhSachHoaDon, dtpNgayBD.Value, dtpNgayKT.Value);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        
    }
}
