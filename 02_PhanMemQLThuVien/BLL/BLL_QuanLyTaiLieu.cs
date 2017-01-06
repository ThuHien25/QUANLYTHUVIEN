using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class BLL_QuanLyTaiLieu
    {
        QLThuVienDataContext qlthuvien;
        public void Load(DataGridView x)
        {
            qlthuvien = new QLThuVienDataContext();
            x.DataSource = from tl in qlthuvien.TAILIEUs
                           join l in qlthuvien.LOAITAILIEUs on tl.MaLoai equals l.MaLoai
                           join cn in qlthuvien.CHUYENNGANHs on tl.MaChuyenNganh equals cn.MaChuyenNganh
                           select new
                           {
                               tl.MaTaiLieu,
                               tl.TenTaiLieu,
                               l.TenLoai,
                               tl.TacGia,
                               tl.NamSanXuat,
                               cn.TenChuyenNganh,
                               tl.MoTa,
                               tl.DonGiaTL,
                               tl.SoLuongHuHao,
                               tl.SoLuongMuon,
                               tl.SoLuongTon
                           };
        }
        public void Add(string MaTL, string TenTL, string maloai, string tacgia, int namsx, string machuyennganh, string mota)
        {
            qlthuvien = new QLThuVienDataContext();
            try
            {
                if (MaTL == string.Empty || TenTL == string.Empty || maloai == string.Empty || tacgia == string.Empty || namsx == null || machuyennganh == string.Empty || mota == string.Empty)
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin!");
                }
                else
                {
                    TAILIEU tl = new TAILIEU();

                    tl.MaTaiLieu = MaTL;
                    tl.TenTaiLieu = TenTL;
                    tl.MaLoai = maloai;
                    tl.MaChuyenNganh = machuyennganh;
                    tl.NamSanXuat = namsx;
                    tl.TacGia = tacgia;
                    tl.MoTa = mota;
                    tl.DonGiaTL = 0;
                    tl.SoLuongTon = 0;
                    tl.SoLuongHuHao = 0;
                    tl.SoLuongMuon = 0;

                    qlthuvien.TAILIEUs.InsertOnSubmit(tl);
                    qlthuvien.SubmitChanges();

                    MessageBox.Show("Thêm thành công!");
                }
            }
            catch
            { MessageBox.Show("Dữ liệu này đã tồn tại!"); }

        }
        public void Delete(DataGridView x)
        {
            qlthuvien = new QLThuVienDataContext();
            try
            {
                DialogResult r = MessageBox.Show("Bạn có chắc chắn xóa?", "Thông báo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);
                if (r == DialogResult.Yes)
                {
                    foreach (DataGridView item in x.SelectedRows)
                    {
                        var tl = qlthuvien.TAILIEUs.Where(t => t.MaTaiLieu == x.SelectedCells[0].Value.ToString()).FirstOrDefault();
                        if (tl != null)
                        {
                            qlthuvien.TAILIEUs.DeleteOnSubmit(tl);
                            qlthuvien.SubmitChanges();
                        }
                        else MessageBox.Show("Dữ liệu không tồn tại!");
                    }
                    MessageBox.Show("Xóa dự liệu thành công!");
                }

            }
            catch { MessageBox.Show("Dữ liệu không tồn tại!"); }
        }
        public void Modify(string matl, string TenTL, string maloai, string tacgia, int namsx, string machuyennganh, string mota)
        {
            qlthuvien = new QLThuVienDataContext();
            try
            {
                var tl = qlthuvien.TAILIEUs.Where(t => t.MaTaiLieu == matl).FirstOrDefault();
                if (tl != null)
                {
                    tl.TenTaiLieu = TenTL;
                    tl.MaLoai = maloai;
                    tl.TacGia = tacgia;
                    tl.NamSanXuat = namsx;
                    tl.MaChuyenNganh = machuyennganh;
                    tl.MoTa = mota;

                    qlthuvien.SubmitChanges();
                    MessageBox.Show("Sửa thành công");
                }
                else MessageBox.Show("Dữ liệu không tồn tại");
            }
            catch { MessageBox.Show("Dữ liệu không tồn tại"); }
        }
        public void SearchTextBox(DataGridView x, string a)
        {
            x.DataSource = from tl in qlthuvien.TAILIEUs
                          join l in qlthuvien.LOAITAILIEUs on tl.MaLoai equals l.MaLoai
                          join cn in qlthuvien.CHUYENNGANHs on tl.MaChuyenNganh equals cn.MaChuyenNganh
                          where tl.MaTaiLieu.Contains(a) || tl.TenTaiLieu.Contains(a) || l.TenLoai.Contains(a) || cn.TenChuyenNganh.Contains(a) || tl.TacGia.Contains(a)
                           select new
                           {
                               tl.MaTaiLieu,
                               tl.TenTaiLieu,
                               l.TenLoai,
                               tl.TacGia,
                               tl.NamSanXuat,
                               cn.TenChuyenNganh,
                               tl.MoTa,
                               tl.DonGiaTL,
                               tl.SoLuongHuHao,
                               tl.SoLuongMuon,
                               tl.SoLuongTon
                           };
        }
        public void LoadCbbTheLoai(ComboBox cbb)
        {
            cbb.DataSource = from l in qlthuvien.LOAITAILIEUs
                             select new {l.MaLoai, l.TenLoai};
            cbb.DisplayMember = "TenLoai";
            cbb.ValueMember = "MaLoai";
        }
        public void LoadCbbChuyenNganh(ComboBox cbb)
        {
            cbb.DataSource = from item in qlthuvien.CHUYENNGANHs
                              select new { item.MaChuyenNganh, item.TenChuyenNganh };
            cbb.DisplayMember = "TenChuyenNganh";
            cbb.ValueMember = "MaChuyenNganh";
        }
        public int SLTaiLieu()
        {
            QLThuVienDataContext qlthuvien = new QLThuVienDataContext();
            try
            {
                return (from i in qlthuvien.TAILIEUs
                           select new { i.MaTaiLieu }).Count();
            }
            catch { return 0; }
        }
    }
}
