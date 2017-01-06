using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BLL
{
    public class BLL_QuanLyMuonTra
    {
        QLThuVienDataContext qlthuvien = new QLThuVienDataContext();
//--------------------------------------Load Data--------------------------------------
        public void LoadDataGridView_MuonTra(DataGridView x)
        {
            QLThuVienDataContext qlthuvien = new QLThuVienDataContext();
            x.DataSource = from i in qlthuvien.PHIEUMUONs
                           join dg in qlthuvien.DOCGIAs on i.MaDocGia equals dg.MaDocGia
                           join nv in qlthuvien.NHANVIENs on i.MaNV equals nv.MaNV
                           select new { i.MaPM, i.MaNV, i.MaDocGia, dg.TenDocGia, nv.TenNV, i.NgayMuon, i.TinhTrang };
        }
        public void LoadDataGridView_CTMuonTra(DataGridView x, string a)
        {
            qlthuvien = new QLThuVienDataContext();
            x.DataSource = from i in qlthuvien.PHIEUMUONs
                           join ct in qlthuvien.CHITIETPHIEUMUONs on i.MaPM equals ct.MaPM
                           join tl in qlthuvien.TAILIEUs on ct.MaTaiLieu equals tl.MaTaiLieu
                           where ct.MaPM == a
                           select new { ct.MaPM, ct.MaTaiLieu, tl.TenTaiLieu, ct.NgayTra, ct.TienPhat, ct.TienBoiThuong, ct.HanTra};
        }
        public void LoadComBoBox_DocGia(ComboBox x)
        {
            x.DataSource = from i in qlthuvien.DOCGIAs select new { i.MaDocGia, i.TenDocGia };
            x.DisplayMember = "TenDocGia";
            x.ValueMember = "MaDocGia";
        }
        public void LoadComBoBox_TaiLieu(ComboBox x)
        {
            x.DataSource = from i in qlthuvien.TAILIEUs select new { i.MaTaiLieu, i.TenTaiLieu };
            x.DisplayMember = "TenTaiLieu";
            x.ValueMember = "MaTaiLieu";
        }
//--------------------------------------Search Data--------------------------------------
        public void SearchDate(DataGridView x, DateTime ngaybd, DateTime ngaykt)
        {
            QLThuVienDataContext qlthuvien = new QLThuVienDataContext();
            x.DataSource = from i in qlthuvien.PHIEUMUONs
                           join dg in qlthuvien.DOCGIAs on i.MaDocGia equals dg.MaDocGia
                           join nv in qlthuvien.NHANVIENs on i.MaNV equals nv.MaNV
                           where i.NgayMuon >= ngaybd && i.NgayMuon <= ngaykt
                           select new { i.MaPM, i.MaNV, i.MaDocGia, dg.TenDocGia, nv.TenNV, i.NgayMuon, i.TinhTrang };
        }
        public void SearchTextBox_PhieuMuon(DataGridView x, string a)
        {
            x.DataSource = from i in qlthuvien.PHIEUMUONs
                           join dg in qlthuvien.DOCGIAs on i.MaDocGia equals dg.MaDocGia
                           join nv in qlthuvien.NHANVIENs on i.MaNV equals nv.MaNV
                           where i.MaPM.Contains(a) || i.MaNV.Contains(a) || i.MaDocGia.Contains(a) || dg.TenDocGia.Contains(a) || nv.TenNV.Contains(a) || i.TinhTrang.Contains(a)
                           select new { i.MaPM, i.MaNV, i.MaDocGia, dg.TenDocGia, nv.TenNV, i.NgayMuon, i.TinhTrang };
        }
        public void SearchTinhTrang_ChuaTraSach(DataGridView x)
        {
            x.DataSource = from i in qlthuvien.PHIEUMUONs
                           join dg in qlthuvien.DOCGIAs on i.MaDocGia equals dg.MaDocGia
                           join nv in qlthuvien.NHANVIENs on i.MaNV equals nv.MaNV
                           where i.TinhTrang == "Chưa trả"
                           select new { i.MaPM, i.MaNV, i.MaDocGia, dg.TenDocGia, nv.TenNV, i.NgayMuon, i.TinhTrang };
        }
        public bool SearchTextBox_CheckDocGia(string a)
        {
            DOCGIA dg1 = qlthuvien.DOCGIAs.Where(t => t.MaDocGia == a && t.SoSachDangMuon >= 3).FirstOrDefault();
            return dg1 == null ? true : false;
        }
        public bool SearchTextBox_CheckTaiLieu(string a)
        {
            TAILIEU tl = qlthuvien.TAILIEUs.Where(t => t.MaTaiLieu == a && t.SoLuongTon <= 0).FirstOrDefault();
            return tl == null ? true : false;
        }
        public bool CheckNgayTra(string mapm, string matailieu)
        {
            CHITIETPHIEUMUON pm = qlthuvien.CHITIETPHIEUMUONs.Where(t => t.MaPM == mapm && t.MaTaiLieu == matailieu && t.NgayTra == null).FirstOrDefault();
            return pm == null ? true : false;
        }
//--------------------------------------Add, Deleted, Modyfid Data--------------------------------------
        public void Add(string madg)
        {
            QLThuVienDataContext qlthuvien = new QLThuVienDataContext();
            try
            {
                if (madg == string.Empty) { MessageBox.Show("Vui lòng nhập đủ thông tin!"); }
                else if (!SearchTextBox_CheckDocGia(madg))
                {
                    MessageBox.Show("Độc giả này chưa trả sách, không được mượn thêm");
                }
                else
                {
                    //B1: Tao 1 the hien tu 1 thuc the
                    PHIEUMUON a = new PHIEUMUON();
                    //B2: Gan du lieu vao thuoc tinh 
                    a.MaPM = Functions.AutoCode("PM");
                    a.MaDocGia = madg;
                    a.MaNV = ThongTinNguoiDung.MaNhanVien;
                    a.NgayMuon = DateTime.Now;
                    //B3: Add du lieu vao bang QL_NGUOIDUNG
                    qlthuvien.PHIEUMUONs.InsertOnSubmit(a);
                    //B4: Cap nhat xuong co so du lieu
                    qlthuvien.SubmitChanges();
                    //B5: Load lai du lieu ten Form
                    //B6: Thong bao
                    MessageBox.Show("Thêm thành công!");
                }
            }
            catch { MessageBox.Show("Dữ liệu này đã tồn tại!"); }
        }
        public void AddCTPhieuMuon(string mapm, string matailieu, int hantra)
        {
            QLThuVienDataContext qlthuvien = new QLThuVienDataContext();
            try
            {
                if (matailieu == string.Empty || hantra == null) { MessageBox.Show("Vui lòng nhập đủ thông tin!"); }
                else if (!SearchTextBox_CheckTaiLieu(matailieu))
                {
                    MessageBox.Show("Tài liệu này đã hết, không được mượn");
                }
                else
                {

                    //B1: Tao 1 the hien tu 1 thuc the
                    CHITIETPHIEUMUON a = new CHITIETPHIEUMUON();
                    //B2: Gan du lieu vao thuoc tinh 
                    a.MaPM = mapm;
                    a.MaTaiLieu = matailieu;
                    a.HanTra = hantra;
                    //B3: Add du lieu vao bang QL_NGUOIDUNG
                    qlthuvien.CHITIETPHIEUMUONs.InsertOnSubmit(a);
                    //B4: Cap nhat xuong co so du lieu
                    qlthuvien.SubmitChanges();
                    //B5: Load lai du lieu ten Form
                    //B6: Thong bao
                    MessageBox.Show("Mượn sách thành công!");
                }
            }
            catch { MessageBox.Show("Dữ liệu này đã tồn tại!"); }
        }
        public void Delete(DataGridView x)
        {
            QLThuVienDataContext qlthuvien = new QLThuVienDataContext();
            try
            {
                DialogResult r = MessageBox.Show("Bạn có chắc chắn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (r == DialogResult.Yes)
                {
                    foreach (DataGridViewRow item in x.SelectedRows)
                    {
                        var pm = qlthuvien.PHIEUMUONs.Where(p => p.MaPM == item.Cells["MaPhieuMuon"].Value.ToString()).FirstOrDefault();
                        if (pm != null)
                        {
                            qlthuvien.PHIEUMUONs.DeleteOnSubmit(pm);
                            qlthuvien.SubmitChanges();
                        }
                        else MessageBox.Show("Dữ liệu không tồn tại!");
                    }
                    MessageBox.Show("Xóa dữ liệu thành công!");
                }
            }
            catch { MessageBox.Show("Thông tin này đang được sử dụng!"); }
        }
        public void DeleteCTPhieuMuon(DataGridView x)
        {
            QLThuVienDataContext qlthuvien = new QLThuVienDataContext();
            try
            {
                DialogResult r = MessageBox.Show("Bạn có chắc chắn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (r == DialogResult.Yes)
                {
                    foreach (DataGridViewRow item in x.SelectedRows)
                    {
                        var dg = qlthuvien.CHITIETPHIEUMUONs.Where(p => p.MaPM == item.Cells["MaPM"].Value.ToString() && p.MaTaiLieu == item.Cells["MaTaiLieu"].Value.ToString()).FirstOrDefault();
                        if (dg != null)
                        {
                            qlthuvien.CHITIETPHIEUMUONs.DeleteOnSubmit(dg);
                            qlthuvien.SubmitChanges();
                        }
                        else MessageBox.Show("Dữ liệu không tồn tại!");
                    }
                    MessageBox.Show("Xóa dữ liệu thành công!");
                }
            }
            catch { MessageBox.Show("Thông tin này đang được sử dụng!"); }
        }

        public void SuaCTPhieuMuon(string mapm, string matailieu, int hantra, int tienphat, int tienboithuong)
        {
            QLThuVienDataContext qlthuvien = new QLThuVienDataContext();
            try
            {
                if (hantra == 0)
                {
                    MessageBox.Show("Vui lòng nhập thông tin hạn trả!");
                    return;
                }
                var a = qlthuvien.CHITIETPHIEUMUONs.Where(p => p.MaPM == mapm  && p.MaTaiLieu == matailieu).FirstOrDefault();
                if (a != null)
                {
                    a.HanTra = hantra;
                    a.NgayTra = DateTime.Now;
                    a.TienPhat = tienphat;
                    a.TienBoiThuong = tienboithuong;
                    qlthuvien.SubmitChanges();
                    MessageBox.Show("Trả sách thành công!");
                }
                else
                    MessageBox.Show("Dữ liệu không tồn tại!");
            }
            catch { MessageBox.Show("Dữ liệu không tồn tại!"); }
        }
        public void SuaCTPhieuMuon_GiaHan(string mapm, string matailieu, int hantra)
        {
            QLThuVienDataContext qlthuvien = new QLThuVienDataContext();
            try
            {
                if (hantra == 0)
                {
                    MessageBox.Show("Vui lòng nhập thông tin hạn trả!");
                    return;
                }
                var a = qlthuvien.CHITIETPHIEUMUONs.Where(p => p.MaPM == mapm && p.MaTaiLieu == matailieu).FirstOrDefault();
                if (a != null)
                {
                    a.HanTra = hantra;
                    qlthuvien.SubmitChanges();
                    MessageBox.Show("Gia hạn thành công!");
                }
                else
                    MessageBox.Show("Dữ liệu không tồn tại!");
            }
            catch { MessageBox.Show("Dữ liệu không tồn tại!"); }
        }
        
//--------------------------------------Sum Data--------------------------------------
        public int TongTienBoiThuong(string b)
        {
            QLThuVienDataContext qlthuvien = new QLThuVienDataContext();
            try { return int.Parse((from a in qlthuvien.CHITIETPHIEUMUONs where a.MaPM == b select a.TienBoiThuong).Sum().ToString()); }
            catch { return 0; }
        }
        public int TongTienPhat(string b)
        {
            QLThuVienDataContext qlthuvien = new QLThuVienDataContext();
            try { return int.Parse((from a in qlthuvien.CHITIETPHIEUMUONs where a.MaPM == b select a.TienPhat).Sum().ToString()); }
            catch { return 0; }
        }
        public int TraSach_TienPhat(DateTime NgayTra, DateTime NgayMuon, int HanTra)
        {
           TimeSpan songay = (NgayTra - NgayMuon);
           int ngay = int.Parse(songay.Days.ToString()) + 1;
           return ngay > HanTra ? (ngay - HanTra) * 500 : 0;
        }
        
    }
}
