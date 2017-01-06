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
    public partial class frmThongKeBaoCaoDocGia : DevComponents.DotNetBar.Office2007RibbonForm
    {
        QLThuVienDataContext qlthuvien = new QLThuVienDataContext();   
        public frmThongKeBaoCaoDocGia()
        {
            InitializeComponent();
            
        }
        private void frmThongKeBaoCaoDocGia_Load(object sender, EventArgs e)
        {
            dgvDanhSachDocGia.DataSource = from i in qlthuvien.view_ThongKeDOCGIAs select i;
            cmbTinhTrangDG.SelectedIndex = 0;
        }
        public void SearchTextBox_All(string a)
        {
            dgvDanhSachDocGia.DataSource = from i in qlthuvien.view_ThongKeDOCGIAs
                                           where i.MaDocGia.Contains(a) || i.TenDocGia.Contains(a)
                                           select i;
        }
        public void SearchTextBox_HetHan(string a)
        {
            dgvDanhSachDocGia.DataSource = from i in qlthuvien.view_ThongKeDOCGIAs
                                           where (i.NgayHetHan < DateTime.Now && i.MaDocGia.Contains(a)) || (i.TenDocGia.Contains(a) && i.NgayHetHan < DateTime.Now)
                                           select i;
        }
        public void SearchTextBox_ConHan(string a)
        {
            dgvDanhSachDocGia.DataSource = from i in qlthuvien.view_ThongKeDOCGIAs
                                           where (i.NgayHetHan >= DateTime.Now && i.MaDocGia.Contains(a)) || (i.TenDocGia.Contains(a) && i.NgayHetHan >= DateTime.Now)
                                           select i;
        }
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if (cmbTinhTrangDG.SelectedItem.ToString() == "Tất cả")
                SearchTextBox_All(txtMaDocGia.Text);
            if (cmbTinhTrangDG.SelectedItem.ToString() == "Hết hạn")
                SearchTextBox_HetHan(txtMaDocGia.Text);
            if (cmbTinhTrangDG.SelectedItem.ToString() == "Còn hạn")
                SearchTextBox_ConHan(txtMaDocGia.Text);
        }

    }
}
