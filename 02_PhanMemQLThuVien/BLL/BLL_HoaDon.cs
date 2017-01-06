using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BLL
{
    public class BLL_HoaDon
    {
        QLThuVienDataContext qlthuvien = new QLThuVienDataContext();
        public void LoadComboBox_NhaCungCap(ComboBox x)
        {
            var a = from item in qlthuvien.NHACUNGCAPs select new { item.MaNCC, item.TenNCC };
            x.DataSource = a;
            x.DisplayMember = "TenNCC";
            x.ValueMember = "MaNCC";
        }
        public void LoadComboBox_TaiLieu(ComboBox x)
        {
            x.DataSource = from item in qlthuvien.TAILIEUs select new { item.MaTaiLieu, item.TenTaiLieu };
            x.DisplayMember = "TenTaiLieu";
            x.ValueMember = "MaTaiLieu";
        }
        public void LoadDataGridView(DataGridView x)
        {
            QLThuVienDataContext qlthuvien = new QLThuVienDataContext();
            x.DataSource = from hd in qlthuvien.HOADONs
                           join ncc in qlthuvien.NHACUNGCAPs on hd.MaNCC equals ncc.MaNCC
                           join n in qlthuvien.NHANVIENs on hd.MaNV equals n.MaNV
                           select new { hd.MaHD, hd.MaNCC, hd.MaNV, n.TenNV, ncc.TenNCC, hd.NgayLap, hd.TongTien };

        }
        public void LoadCTHD(DataGridView x, string a)
        {
            QLThuVienDataContext qlThuVien = new QLThuVienDataContext();
            x.DataSource = from cthd in qlThuVien.CHITIETHDs
                           join tl in qlThuVien.TAILIEUs on cthd.MaTaiLieu equals tl.MaTaiLieu
                           where cthd.MaHD == a
                           select new { cthd.MaHD, cthd.MaTaiLieu, tl.TenTaiLieu, cthd.SoLuong, cthd.DonGia, cthd.ThanhTien };
        }
        public void Add(string mancc, int tongtien)
        {
            QLThuVienDataContext qlthuvien = new QLThuVienDataContext();
            try
            {
                if (mancc == string.Empty) { MessageBox.Show("Vui lòng nhập đủ thông tin!"); }
                else
                {
                    //B1: Tao 1 the hien tu 1 thuc the
                    HOADON a = new HOADON();
                    //B2: Gan du lieu vao thuoc tinh 
                    a.MaHD = Functions.AutoCode("HD");
                    a.MaNCC = mancc;
                    a.MaNV = ThongTinNguoiDung.MaNhanVien;
                    a.NgayLap = DateTime.Now;
                    a.TongTien = tongtien;
                    //B3: Add du lieu vao bang QL_NGUOIDUNG
                    qlthuvien.HOADONs.InsertOnSubmit(a);
                    //B4: Cap nhat xuong co so du lieu
                    qlthuvien.SubmitChanges();
                    //B5: Load lai du lieu ten Form
                    //B6: Thong bao
                    MessageBox.Show("Thêm thành công!");
                }
            }
            catch { MessageBox.Show("Dữ liệu này đã tồn tại!"); }
        }
        public void AddCTHD(string mahoadon, string matailieu, int soluong, int dongia, int thanhtien)
        {
            QLThuVienDataContext qlthuvien = new QLThuVienDataContext();
            try
            {
                if (matailieu == string.Empty || soluong == null || dongia == null) { MessageBox.Show("Vui lòng nhập đủ thông tin!");}
                else if (soluong <= 0 || dongia <= 0) { MessageBox.Show("Số lượng, đơn giá phải lớn hơn 0!"); }
                else
                {

                    //B1: Tao 1 the hien tu 1 thuc the
                    CHITIETHD a = new CHITIETHD();
                    //B2: Gan du lieu vao thuoc tinh 
                    a.MaHD = mahoadon;
                    a.MaTaiLieu = matailieu;
                    a.SoLuong = soluong;
                    a.DonGia = dongia;
                    a.ThanhTien = thanhtien;
                    //B3: Add du lieu vao bang QL_NGUOIDUNG
                    qlthuvien.CHITIETHDs.InsertOnSubmit(a);
                    //B4: Cap nhat xuong co so du lieu
                    qlthuvien.SubmitChanges();
                    //B5: Load lai du lieu ten Form
                    //B6: Thong bao
                    MessageBox.Show("Thêm thành công!");
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
                        var dg = qlthuvien.HOADONs.Where(p => p.MaHD == item.Cells["MaHoaDon"].Value.ToString()).FirstOrDefault();
                        if (dg != null)
                        {
                            qlthuvien.HOADONs.DeleteOnSubmit(dg);
                            qlthuvien.SubmitChanges();
                        }
                        else MessageBox.Show("Dữ liệu không tồn tại!");
                    }
                    MessageBox.Show("Xóa dữ liệu thành công!");
                }
            }
            catch { MessageBox.Show("Thông tin này đang được sử dụng!"); }
        }
        public void DeleteCTHD(DataGridView x)
        {
            QLThuVienDataContext qlthuvien = new QLThuVienDataContext();
            try
            {
                DialogResult r = MessageBox.Show("Bạn có chắc chắn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (r == DialogResult.Yes)
                {
                    foreach (DataGridViewRow item in x.SelectedRows)
                    {
                        var dg = qlthuvien.CHITIETHDs.Where(p => p.MaHD == item.Cells["MaHD"].Value.ToString() && p.MaTaiLieu == item.Cells["MaTL"].Value.ToString()).FirstOrDefault();
                        if (dg != null)
                        {
                            qlthuvien.CHITIETHDs.DeleteOnSubmit(dg);
                            qlthuvien.SubmitChanges();
                        }
                        else MessageBox.Show("Dữ liệu không tồn tại!");
                    }
                    MessageBox.Show("Xóa dữ liệu thành công!");
                }
            }
            catch { MessageBox.Show("Thông tin này đang được sử dụng!"); }
        }
        public int TongTien(string s)
        {
            QLThuVienDataContext qlthuvien = new QLThuVienDataContext();
            try
            {
                var tongs = (from cthd in qlthuvien.CHITIETHDs where cthd.MaHD == s select cthd.ThanhTien).Sum();
                return int.Parse(tongs.ToString());
            }
            catch { return 0; }
        }
        public void update(string s)
        {
            QLThuVienDataContext qlthuvien = new QLThuVienDataContext();
            HOADON hd = qlthuvien.HOADONs.Where(p => p.MaHD == s).FirstOrDefault();
            hd.TongTien = TongTien(s);
            qlthuvien.SubmitChanges();
        }
        public int TongGiaTriHD()
        {
            QLThuVienDataContext qlthuvien = new QLThuVienDataContext();
            try
            {
                var tongs = (from hd in qlthuvien.HOADONs select hd.TongTien).Sum();
                return int.Parse(tongs.ToString());
            }
            catch { return 0; }
        }
        public void SearchDate(DataGridView x, DateTime ngaybd, DateTime ngaykt)
        {
            QLThuVienDataContext qlthuvien = new QLThuVienDataContext();
            x.DataSource = (from hd in qlthuvien.HOADONs
                           join ncc in qlthuvien.NHACUNGCAPs on hd.MaNCC equals ncc.MaNCC
                           join n in qlthuvien.NHANVIENs on hd.MaNV equals n.MaNV
                           where hd.NgayLap >= ngaybd && hd.NgayLap <= ngaykt
                           select new { hd.MaHD, hd.MaNCC, hd.MaNV, n.TenNV, ncc.TenNCC, hd.NgayLap, hd.TongTien });
                          
        }
        public void SearchTextBox(DataGridView x, string a)
        {
            x.DataSource = from hd in qlthuvien.HOADONs
                           join ncc in qlthuvien.NHACUNGCAPs on hd.MaNCC equals ncc.MaNCC
                           join n in qlthuvien.NHANVIENs on hd.MaNV equals n.MaNV
                           where hd.MaHD.Contains(a) || ncc.TenNCC.Contains(a) || n.TenNV.Contains(a)
                           select new { hd.MaHD, hd.MaNCC, hd.MaNV, n.TenNV, ncc.TenNCC, hd.NgayLap, hd.TongTien };
        }
    }
}
