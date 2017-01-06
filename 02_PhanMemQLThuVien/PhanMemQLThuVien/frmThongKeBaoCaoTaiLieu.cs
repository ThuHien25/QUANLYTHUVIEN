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
    public partial class frmThongKeBaoCaoTaiLieu : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public frmThongKeBaoCaoTaiLieu()
        {
            InitializeComponent();
        }
        QLThuVienDataContext qlthuvien = new QLThuVienDataContext();
        public void LoadDataGridView()
        {
            dgvDanhSachTaiLieu.DataSource = from i in qlthuvien.TAILIEUs
                                            select new
                                            {
                                                i.MaTaiLieu,
                                                i.TenTaiLieu,
                                                i.SoLuongTon,
                                                i.SoLuongMuon,
                                                i.SoLuongHuHao
                                            };
        }
        int a = 4; //Biến này thay thế bằng 1 textbox nếu thích
        public void Load_SLMuon_ItNhat()
        {
            dgvDanhSachTaiLieu.DataSource = (from i in qlthuvien.TAILIEUs
                                            orderby i.SoLuongMuon ascending
                                            select new
                                            {
                                                i.MaTaiLieu,
                                                i.TenTaiLieu,
                                                i.SoLuongTon,
                                                i.SoLuongMuon,
                                                i.SoLuongHuHao
                                            }).Skip(0).Take(a);
        }
        public void Load_SLMuon_NhieuNhat()
        {
            dgvDanhSachTaiLieu.DataSource = (from i in qlthuvien.TAILIEUs
                                             orderby i.SoLuongMuon descending
                                             select new
                                             {
                                                 i.MaTaiLieu,
                                                 i.TenTaiLieu,
                                                 i.SoLuongTon,
                                                 i.SoLuongMuon,
                                                 i.SoLuongHuHao
                                             }).Skip(0).Take(a);
        }
        
        private void frmThongKeBaoCaoTaiLieu_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            cbbLoaiThongKe.SelectedIndex = 0;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cbbLoaiThongKe.SelectedItem.ToString() == "Tất cả")
                LoadDataGridView();
            if (cbbLoaiThongKe.SelectedItem.ToString() == "Mượn ít nhất")
                Load_SLMuon_ItNhat();
            if (cbbLoaiThongKe.SelectedItem.ToString() == "Mượn nhiều nhất")
                Load_SLMuon_NhieuNhat();
        }
    }
}
