using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
namespace PhanMemQLThuVien
{
    public partial class frmThongKeBaoCaoMuonTra : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public frmThongKeBaoCaoMuonTra()
        {
            InitializeComponent();
        }
        QLThuVienDataContext qlthuvien = new QLThuVienDataContext();
        public void Load_TangDan()
        {
            dgvDSDocGiaMuonQuaHan.DataSource = from i in qlthuvien.view_ThongKe_MUONTRAs
                                               join dg in qlthuvien.DOCGIAs on i.MaDocGia equals dg.MaDocGia
                                               join tl in qlthuvien.TAILIEUs on i.MaTaiLieu equals tl.MaTaiLieu
                                               orderby i.SoNgayQuaHan ascending
                                               select new
                                               {
                                                   i.MaDocGia,
                                                   dg.TenDocGia,
                                                   i.MaTaiLieu,
                                                   tl.TenTaiLieu,
                                                   i.NgayMuon,
                                                   i.HanTra,
                                                   i.NgayTraDuKien,
                                                   i.SoNgayQuaHan
                                               };
        }
        public void Load_GiamDan()
        {
            dgvDSDocGiaMuonQuaHan.DataSource = from i in qlthuvien.view_ThongKe_MUONTRAs
                                               join dg in qlthuvien.DOCGIAs on i.MaDocGia equals dg.MaDocGia
                                               join tl in qlthuvien.TAILIEUs on i.MaTaiLieu equals tl.MaTaiLieu
                                               orderby i.SoNgayQuaHan descending
                                               select new
                                               {
                                                   i.MaDocGia,
                                                   dg.TenDocGia,
                                                   i.MaTaiLieu,
                                                   tl.TenTaiLieu,
                                                   i.NgayMuon,
                                                   i.HanTra,
                                                   i.NgayTraDuKien,
                                                   i.SoNgayQuaHan
                                               };
        }
        public void LoadDataGridView()
        {
            dgvDSDocGiaMuonQuaHan.DataSource = from i in qlthuvien.view_ThongKe_MUONTRAs
                                               join dg in qlthuvien.DOCGIAs on i.MaDocGia equals dg.MaDocGia
                                               join tl in qlthuvien.TAILIEUs on i.MaTaiLieu equals tl.MaTaiLieu
                                               select new
                                               {
                                                   i.MaDocGia,
                                                   dg.TenDocGia,
                                                   i.MaTaiLieu,
                                                   tl.TenTaiLieu,
                                                   i.NgayMuon,
                                                   i.HanTra,
                                                   i.NgayTraDuKien,
                                                   i.SoNgayQuaHan
                                               };
        }
        private void frmThongKeBaoCaoMuonTra_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            cmbSapXepSoNgay.SelectedIndex = 0;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cmbSapXepSoNgay.SelectedItem.ToString() == "Tăng Dần")
                Load_TangDan();
            if (cmbSapXepSoNgay.SelectedItem.ToString() == "Giảm Dần")
                Load_GiamDan();
        }
        public void TimKiem(string a)
        { 
            dgvDSDocGiaMuonQuaHan.DataSource = from i in qlthuvien.view_ThongKe_MUONTRAs
                                               join dg in qlthuvien.DOCGIAs on i.MaDocGia equals dg.MaDocGia
                                               join tl in qlthuvien.TAILIEUs on i.MaTaiLieu equals tl.MaTaiLieu
                                               where i.MaDocGia.Contains(a) || dg.TenDocGia.Contains(a) || tl.TenTaiLieu.Contains(a) 
                                               select new
                                               {
                                                   i.MaDocGia,
                                                   dg.TenDocGia,
                                                   i.MaTaiLieu,
                                                   tl.TenTaiLieu,
                                                   i.NgayMuon,
                                                   i.HanTra,
                                                   i.NgayTraDuKien,
                                                   i.SoNgayQuaHan
                                               };
        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text != "Nhập từ khóa cần tìm kiếm...")
            {
                TimKiem(txtTimKiem.Text);
            }
        }

        private void dgvDSDocGiaMuonQuaHan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
