using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BLL
{
    public class BLL_QuanLyDocGia
    {
        QLThuVienDataContext qlthuvien = new QLThuVienDataContext();
        public void Loaddgv(DataGridView x)
        {
            qlthuvien = new QLThuVienDataContext();
            var docgias = from dg in qlthuvien.DOCGIAs
                          join loai in qlthuvien.LOAIDOCGIAs on dg.MaLoaiDG equals loai.MaLoaiDG
                          select new {dg.MaDocGia, dg.TenDocGia, loai.TenLoaiDG, dg.NgaySinh, dg.Email, dg.NgayDangKy, dg.HanThe, dg.TienCoc, dg.SoSachDangMuon };
            x.DataSource = docgias;
        }
        public void LoadCbbLoaiDocGia(ComboBox x)
        {
            qlthuvien = new QLThuVienDataContext();
            var loaidg = from ldg in qlthuvien.LOAIDOCGIAs
                         select ldg;
            x.DataSource = loaidg;
            x.DisplayMember = "TenLoaiDG";
            x.ValueMember = "MaLoaiDG";
        }
        public void Add(string ma, string ten, string maloai, DateTime ngSinh, string email, DateTime ngDangKy, int hanThe, int tienCoc)
        {
            qlthuvien = new QLThuVienDataContext();
            try
            {
                if (ma == string.Empty || ten == string.Empty || maloai == string.Empty || ngSinh == null ||
                email == string.Empty || ngDangKy == null || hanThe == null || tienCoc == null)
                {
                    MessageBox.Show("Thông tin không được bỏ trống!");
                }
                else
                {
                    DOCGIA dg = new DOCGIA();

                    dg.MaDocGia = ma;
                    dg.TenDocGia = ten;
                    dg.MaLoaiDG = maloai;
                    dg.NgaySinh = ngSinh;
                    dg.Email = email;
                    dg.NgayDangKy = ngDangKy;
                    dg.HanThe = hanThe;
                    dg.TienCoc = tienCoc;
                    //------------- Mặc định số sách đang mượn là  0 khi thêm mới một độc giả
                    dg.SoSachDangMuon = 0;

                    qlthuvien.DOCGIAs.InsertOnSubmit(dg);
                    qlthuvien.SubmitChanges();

                    MessageBox.Show("Thêm độc giả thành công!");

                }
            }
            catch(Exception e)
            {
                MessageBox.Show(""+e);
                MessageBox.Show("Thêm độc giả thất bại !"); }

        }
        public void Delete(DataGridView x)
        {
            qlthuvien = new QLThuVienDataContext();
            try
            {
                DialogResult r = MessageBox.Show("Bạn có chắc muốn xóa?", "Thông báo!",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);
                if (r == DialogResult.Yes)
                {
                    foreach (DataGridViewRow item in x.SelectedRows)
                    {
                        var dg = qlthuvien.DOCGIAs.Where(p => p.MaDocGia == x.SelectedCells[0].Value.ToString()).FirstOrDefault();
                        if (dg != null)
                        {
                            qlthuvien.DOCGIAs.DeleteOnSubmit(dg);
                            qlthuvien.SubmitChanges();
                        }
                        else
                        {
                            MessageBox.Show("Dữ liệu không tồn tại!");
                        }
                    }
                    MessageBox.Show("Xóa dữ liệu thành công!");
                }

            }
            catch
            {
                MessageBox.Show("Thông tin này đang được sử dụng!");
            }
        }
        public void Modify(string ma, string ten, string maloai, DateTime ngSinh, string email, DateTime ngDangKy, int hanThe, int tienCoc)
        {

            qlthuvien = new QLThuVienDataContext();
            try
            {
                DialogResult r = MessageBox.Show("Bạn chắc chắn muốn sửa?", "Thông báo!",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);
                if (r == DialogResult.Yes)
                {
                    var dg = qlthuvien.DOCGIAs.Where(p => p.MaDocGia == ma).FirstOrDefault();
                    if (dg != null)
                    {
                        dg.TenDocGia = ten;
                        dg.MaLoaiDG = maloai;
                        dg.NgaySinh = ngSinh;
                        dg.Email = email;
                        dg.NgayDangKy = ngDangKy;
                        dg.HanThe = hanThe;
                        dg.TienCoc = tienCoc;
                       // dg.SoSachDangMuon = soSach;

                        qlthuvien.SubmitChanges();
                        MessageBox.Show("Sửa thành công!");
                    }
                    else MessageBox.Show("Dữ liệu không tồn tại!");
                }
            }
            catch
            {
                MessageBox.Show("Sửa dữ liệu thất bại!");
            }
        }
        public void SearchTextBox(DataGridView x, string a)
        {
            var tim = from dg in qlthuvien.DOCGIAs
                      join loai in qlthuvien.LOAIDOCGIAs on dg.MaLoaiDG equals loai.MaLoaiDG
                      where dg.MaDocGia.Contains(a) || dg.TenDocGia.Contains(a) || loai.MaLoaiDG.Contains(a) || loai.TenLoaiDG.Contains(a) || dg.Email.Contains(a)
                      select new { dg.MaDocGia, dg.TenDocGia, loai.TenLoaiDG, dg.NgaySinh, dg.Email, dg.NgayDangKy, dg.HanThe, dg.TienCoc, dg.SoSachDangMuon };
            x.DataSource = tim;
        }
        public int TongDocGia()
        {
            qlthuvien = new QLThuVienDataContext();
            try
            {
                var dg = (from d in qlthuvien.DOCGIAs
                         select new {d.MaDocGia}).Count();
                return dg;
            }
            catch
            {
                return 0;
            }
        }
    }
}
