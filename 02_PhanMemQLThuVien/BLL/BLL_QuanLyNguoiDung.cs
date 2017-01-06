using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BLL
{
    public class BLL_QuanLyNguoiDung
    {
        QLThuVienDataContext qlthuvien = new QLThuVienDataContext();
        public void Loadcbb(ComboBox x)
        {
            qlthuvien = new QLThuVienDataContext();
            var nv = from i in qlthuvien.NHANVIENs
                     select i;
            x.DataSource = nv;
            x.DisplayMember = "TenNV";
            x.ValueMember = "MaNV";

        }
        public int TongSoNguoiDung()
        {
            qlthuvien = new QLThuVienDataContext();
            try
            {
                var nd = (from i in qlthuvien.NGUOIDUNGs
                          select new { i.TenTaiKhoan }).Count();
                return nd;
            }
            catch
            { return 0; }

        }
        public void Loaddgv(DataGridView x)
        {
            qlthuvien = new QLThuVienDataContext();
            var nd = from i in qlthuvien.NGUOIDUNGs
                     join nv in qlthuvien.NHANVIENs on i.MaNV equals nv.MaNV
                     select new { i.MaNV, nv.TenNV, i.TenTaiKhoan, i.MatKhau, i.HoatDong };
            x.DataSource = nd;
        }
        public void SearchTextBox(DataGridView x, string s)
        {

            qlthuvien = new QLThuVienDataContext();
            var nd = from i in qlthuvien.NGUOIDUNGs
                     join nv in qlthuvien.NHANVIENs on i.MaNV equals nv.MaNV
                     where i.MaNV.Contains(s) || nv.TenNV.Contains(s) || i.TenTaiKhoan.Contains(s)
                     select new { i.MaNV, nv.TenNV, i.TenTaiKhoan, i.MatKhau, i.HoatDong };
            x.DataSource = nd;
        }
        public void Add(string tentaikhoan, string manv, string matkhau, bool hoatdong)
        {
            qlthuvien = new QLThuVienDataContext();
            try
            {
                if (tentaikhoan == string.Empty || manv == string.Empty || matkhau == string.Empty || hoatdong == null)
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin!");
                    
                }
                else
                {
                    NGUOIDUNG nd = new NGUOIDUNG();
                    nd.TenTaiKhoan = tentaikhoan;
                    nd.MaNV = manv;
                    nd.MatKhau = matkhau;
                    nd.HoatDong = hoatdong;

                    qlthuvien.NGUOIDUNGs.InsertOnSubmit(nd);
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
                DialogResult r = MessageBox.Show("Bạn chắc chắn muốn xóa?", "Thông báo!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
                if (r == DialogResult.Yes)
                {
                    foreach (DataGridViewRow item in x.SelectedRows)
                    {
                        var nd = qlthuvien.NGUOIDUNGs.Where(t => t.TenTaiKhoan == item.Cells[0].Value.ToString()).FirstOrDefault();
                        if (nd != null)
                        {
                            qlthuvien.NGUOIDUNGs.DeleteOnSubmit(nd);
                            qlthuvien.SubmitChanges();
                        }
                        else MessageBox.Show("Dữ liệu không tồn tại!");

                    }
                    MessageBox.Show("Xóa dữ liệu thành công!");
                }
            }
            catch { MessageBox.Show("Dữ liệu này đang được sử dụng!"); }
        }
        public void Modify(string tentaikhoan, string manv, string matkhau, bool hoatdong)
        {
            DialogResult r = MessageBox.Show("Bạn chắc chắn muốn sửa?", "Thông báo!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (r == DialogResult.Yes)
            {
                try
                {
                    if (tentaikhoan == string.Empty || manv == string.Empty || matkhau == string.Empty || hoatdong == null)
                    {
                        MessageBox.Show("Vui lòng nhập đủ thông tin!");
                      
                    }
                    else
                    {

                        var nd = qlthuvien.NGUOIDUNGs.Where(t => t.TenTaiKhoan == tentaikhoan).FirstOrDefault();
                        if (nd != null)
                        {
                            nd.MaNV = manv;
                            nd.MatKhau = matkhau;
                            nd.HoatDong = hoatdong;
                            qlthuvien.SubmitChanges();
                            MessageBox.Show("Sửa thành công!");
                        }
                        else MessageBox.Show("Dữ liệu không tồn tại!");
                    }
                }
                catch
                {
                    MessageBox.Show("Dữ liệu không tồn tại!");
                }
            }

        }
    }
}
