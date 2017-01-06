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
    public partial class frmMuonTra : frmBaseFull
    {
        public frmMuonTra()
        {
            InitializeComponent();
        }
        BLL_QuanLyMuonTra muontra = new BLL_QuanLyMuonTra();
        public void LoadDate()
        {
            Visible_Sua(false);
            Enable_Them(false);

            dtpNgayMuon.Text = DateTime.Now.ToString();
            dtpTuNgay.Text = DateTime.Now.ToString();
            dtpDenNgay.Text = DateTime.Now.ToString();
            dtpNgayTra.Text = DateTime.Now.ToString();
            dtpNgayTra.Enabled = false;
        }
        private void frmMuonTra_Load(object sender, EventArgs e)
        {
            LoadDate();
            Functions.Enable_Groupbox(groupTTPhieuMuon, false);
            Functions.Enable_Groupbox(groupTTChiTietPhieuMuon, false);

            muontra.LoadComBoBox_DocGia(cbbTenDG);
            muontra.LoadComBoBox_TaiLieu(cbbTenTL);
            muontra.LoadDataGridView_MuonTra(dgvDanhSachMuonTra);

            Functions.Clear(groupTTPhieuMuon);
            Functions.Clear(groupTTChiTietPhieuMuon);
            txtHanTra.Text = "10";
        }
        protected override void OnAdd()
        {
            Functions.Enable_Groupbox(groupTTPhieuMuon, false);
            cbbTenDG.Enabled = true;
            Functions.Clear(groupTTPhieuMuon);
            cbbTenDG.Focus();
        }
        protected override void OnDeleted()
        {
            if (dgvDanhSachMuonTra.SelectedRows == null)
                MessageBox.Show("Chọn dữ liệu cần xóa");
            else
            {
                muontra.Delete(dgvDanhSachMuonTra);
                muontra.LoadDataGridView_MuonTra(dgvDanhSachMuonTra);

                Functions.Clear(groupTTPhieuMuon);
            }
        }
        protected override void OnCancel()
        {
            Functions.Clear(groupTTPhieuMuon);
            Functions.Enable_Groupbox(groupTTPhieuMuon, false);
        }
        protected override void OnSaveAdd()
        {
            muontra.Add(txtMaDG.Text);
            muontra.LoadDataGridView_MuonTra(dgvDanhSachMuonTra);
        }
        protected override void OnSave()
        {
            OnSaveAdd();
            EnableLoadForm();
            Functions.Enable_Groupbox(groupTTPhieuMuon, false);
            Functions.Enable_Groupbox(groupTTChiTietPhieuMuon, false);
        }
        private void dgvDanhSachMuonTra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDanhSachMuonTra.SelectedRows.Count != 0)
            {
                cbbTenDG.Text = dgvDanhSachMuonTra.CurrentRow.Cells["MaDocGia"].Value.ToString();
                dtpNgayMuon.Text = dgvDanhSachMuonTra.CurrentRow.Cells["NgayMuon"].Value.ToString();
            }
            if (rdbMuon.Checked)
                Enable_DataGridView_CellClick();
            else
                Enable_Xoa(true);
            Functions.Enable_Groupbox(groupTTPhieuMuon, false);
            Functions.Enable_Groupbox(groupTTChiTietPhieuMuon, false);
        }
        private void cbbTenTL_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaTL.Text = cbbTenTL.SelectedValue.ToString();
        }
        private void cbbMaDG_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaDG.Text = cbbTenDG.SelectedValue.ToString();
        }
        public void RadioButton_Check()
        {
            if (rdbMuon.Checked)
                btnXoa.Enabled = btnThem.Enabled = true;
            if (rdbTra.Checked || rdbGiaHan.Checked)
                btnSua.Enabled = true;
            
        }
        private void dgvDanhSachMuonTra_SelectionChanged(object sender, EventArgs e)
        {
            muontra.LoadDataGridView_CTMuonTra(dgvDSChiTietMuonTra, dgvDanhSachMuonTra.CurrentRow.Cells["MaPhieuMuon"].Value.ToString());
            RadioButton_Check();
            TongTien_Label();
        }
        public void TongTien_Label()
        {
            lblTongTienPhat.Text = (muontra.TongTienPhat(dgvDanhSachMuonTra.CurrentRow.Cells["MaPhieuMuon"].Value.ToString())).ToString("#,#0");
            lblTongBoiThuong.Text = (muontra.TongTienBoiThuong(dgvDanhSachMuonTra.CurrentRow.Cells["MaPhieuMuon"].Value.ToString())).ToString("#,#0");
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm")
            {
                Functions.Clear(groupTTChiTietPhieuMuon);
                txtHanTra.Text = "10";
                Functions.Enable_Groupbox(groupTTChiTietPhieuMuon, false);
                cbbTenTL.Enabled = txtHanTra.Enabled = true;
                dtpNgayTra.Enabled = btnXoa.Enabled = btnSua.Enabled = false;
                btnThem.Text = "Lưu";
            }
            else
            {
                muontra.AddCTPhieuMuon(dgvDanhSachMuonTra.CurrentRow.Cells["MaPhieuMuon"].Value.ToString(), txtMaTL.Text, int.Parse(txtHanTra.Text));
                btnThem.Text = "Thêm";
                Functions.Enable_Groupbox(groupTTChiTietPhieuMuon, false);
                
                TongTien_Label();
                dgvDanhSachMuonTra_SelectionChanged(sender, e);
                Functions.AfterSucess(dgvDSChiTietMuonTra, this, txtMaTL.Text, "MaTaiLieu");
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (btnSua.Text == "Sửa")
            {
                if (rdbGiaHan.Checked) //Gia hạn
                {
                    Functions.Enable_Groupbox(groupTTChiTietPhieuMuon, false);
                    txtHanTra.Enabled = true;
                }
                else// Trả sách
                {
                    Functions.Enable_Groupbox(groupTTChiTietPhieuMuon, false);
                    txtTienBoiThuong.Enabled = true;
                }
                btnSua.Text = "Lưu";
            }
            else
            {
                if (rdbGiaHan.Checked)
                {
                    muontra.SuaCTPhieuMuon_GiaHan(dgvDanhSachMuonTra.CurrentRow.Cells["MaPhieuMuon"].Value.ToString(), txtMaTL.Text, int.Parse(txtHanTra.Text));
                }
                else
                {
                    int a = muontra.TraSach_TienPhat(dtpNgayTra.Value, dtpNgayMuon.Value, int.Parse(txtHanTra.Text));
                    muontra.SuaCTPhieuMuon(dgvDanhSachMuonTra.CurrentRow.Cells["MaPhieuMuon"].Value.ToString(), txtMaTL.Text, int.Parse(txtHanTra.Text), a, int.Parse(txtTienBoiThuong.Text));
                }
                btnSua.Text = "Sửa";
                Functions.Enable_Groupbox(groupTTChiTietPhieuMuon, false);
                dtpNgayTra.Enabled = false;
                
                TongTien_Label();
                dgvDanhSachMuonTra_SelectionChanged(sender, e);
                Functions.AfterSucess(dgvDSChiTietMuonTra, this, txtMaTL.Text, "MaTaiLieu");
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = btnSua.Enabled = false;
            muontra.DeleteCTPhieuMuon(dgvDSChiTietMuonTra);
            
            TongTien_Label();
            dgvDanhSachMuonTra_SelectionChanged(sender, e);
        }

        private void dgvDanhSachChiTietmuontra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbbTenTL.Text = dgvDSChiTietMuonTra.CurrentRow.Cells["TenTaiLieu"].Value.ToString();
            txtMaTL.Text = dgvDSChiTietMuonTra.CurrentRow.Cells["MaTaiLieu"].Value.ToString();
            txtHanTra.Text = dgvDSChiTietMuonTra.CurrentRow.Cells["HanTra"].Value.ToString();

            dtpNgayTra.Text = dgvDSChiTietMuonTra.CurrentRow.Cells["NgayTra"].Value == null ? DateTime.Now.ToString() : dgvDSChiTietMuonTra.CurrentRow.Cells["NgayTra"].Value.ToString();
            txtTienBoiThuong.Text = dgvDSChiTietMuonTra.CurrentRow.Cells["TienBoiThuong"].Value == null ? "0" : dgvDSChiTietMuonTra.CurrentRow.Cells["TienBoiThuong"].Value.ToString();

            if (rdbMuon.Checked)
                btnXoa.Enabled = btnThem.Enabled = true;
            if (rdbTra.Checked || rdbGiaHan.Checked)
            {
                if (muontra.CheckNgayTra(dgvDSChiTietMuonTra.CurrentRow.Cells["MaPM"].Value.ToString(), dgvDSChiTietMuonTra.CurrentRow.Cells["MaTaiLieu"].Value.ToString()))
                    MessageBox.Show("Tài liệu này đã trả rồi, không được chỉnh sửa");
                else
                    btnSua.Enabled = true;
            }
        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text != "Nhập từ khóa cần tìm kiếm...")
            {
                muontra.SearchTextBox_PhieuMuon(dgvDanhSachMuonTra, txtTimKiem.Text);
                Functions.Clear(groupTTPhieuMuon);
            }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (DateTime.Compare(dtpTuNgay.Value, dtpDenNgay.Value) > 0)
            {
                MessageBox.Show("Ngày kết thúc >= Ngày bắt đầu");
                dtpTuNgay.Value = dtpDenNgay.Value = DateTime.Now;
                return;
            }
            muontra.SearchDate(dgvDanhSachMuonTra, dtpTuNgay.Value, dtpDenNgay.Value);
        }

        private void txtTimKiem_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.Show("Tìm kiếm theo mã phiếu mượn, mã độc giả, tên độc giả, tên nhân viên, tình trạng phiếu mượn", txtTimKiem);
        }
        public void TraSach()
        {
            Enable_All(false);
            btnThem.Visible = btnXoa.Visible = false;
            btnSua.Visible = true;
            muontra.SearchTinhTrang_ChuaTraSach(dgvDanhSachMuonTra);
        }
        public void MuonSach()
        {
            Enable_Them(true);
            btnSua.Visible = false;
            btnThem.Visible = btnXoa.Visible = true;
            muontra.LoadDataGridView_MuonTra(dgvDanhSachMuonTra);
        }
        private void rdbMuon_CheckedChanged(object sender, EventArgs e) { MuonSach(); }
        private void rdbTra_CheckedChanged(object sender, EventArgs e) { TraSach(); }
        private void rdbGiaHan_CheckedChanged(object sender, EventArgs e) { TraSach(); }
        
    }
}
