using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BLL
{
    public class BLL_QuanLyNhanVien
    {
        QLThuVienDataContext qlthuvien = new QLThuVienDataContext();
        public void Loaddgv(DataGridView x)
        {
            qlthuvien = new QLThuVienDataContext();
            var nv = from i in qlthuvien.NHANVIENs
                     select new { i.MaNV, i.TenNV, i.ChucVu, i.SDT_NV, i.DiaChi, i.Email_NV };
            x.DataSource = nv;
        }
        public int TongNhanVien()
        {
            try
            {
                var nv = (from i in qlthuvien.NHANVIENs
                          select new { i.MaNV }).Count();
                return nv;
            }
            catch
            {
                return 0;
            }
            
        }
        public void Add(string ma, string ten, string chucvu, string sdt, string diachi, string email)
        {
            qlthuvien = new QLThuVienDataContext();
            if (ma == string.Empty || ten == string.Empty || chucvu == string.Empty || sdt == string.Empty || diachi == string.Empty|| email == string.Empty)
            {
                MessageBox.Show("Thông tin không được bỏ trống!", "Thông báo!");
                return;
            }
            try
            {
                NHANVIEN nhanviens = new NHANVIEN();

                nhanviens.MaNV = ma;
                nhanviens.TenNV = ten;
                nhanviens.ChucVu = chucvu;
                nhanviens.SDT_NV = sdt;
                nhanviens.DiaChi = diachi;
                nhanviens.Email_NV = email;
                qlthuvien.NHANVIENs.InsertOnSubmit(nhanviens);
                qlthuvien.SubmitChanges();

                MessageBox.Show("Thêm thành công!");
            }
            catch
            {
                MessageBox.Show("Thêm thất bại!");
            }

        }
        public void Delete(DataGridView x)
        {
            qlthuvien = new QLThuVienDataContext();
            DialogResult r = MessageBox.Show("Bạn có chắc chắn xóa?", "Thông Báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (r == DialogResult.Yes)
            {
                try
                {
                    foreach (DataGridViewRow item in x.SelectedRows)
                    {
                        var nv = qlthuvien.NHANVIENs.Where(t => t.MaNV == item.Cells[0].Value.ToString()).FirstOrDefault();
                        if (nv != null)
                        {
                            qlthuvien.NHANVIENs.DeleteOnSubmit(nv);
                            qlthuvien.SubmitChanges();
                        }
                        else { MessageBox.Show("Dữ liệu không tồn tại!"); }
                    }
                    MessageBox.Show("Xóa thành công!");
                }
                catch
                {
                    MessageBox.Show("Dữ liệu này đang được sử dụng");
                }
            }
        }
        public void Modify(string ma, string ten, string chucvu, string sdt, string diachi, string email)
        {
            qlthuvien = new QLThuVienDataContext();
            if (ma == string.Empty || ten == string.Empty || chucvu == string.Empty || sdt == string.Empty || diachi == string.Empty|| email == string.Empty)
            {
                MessageBox.Show("Thông tin không được bỏ trống!", "Thông báo!");
                return;
            }
            DialogResult r = MessageBox.Show("Bạn chắc chắn muốn sửa?", "Thông báo!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (r == DialogResult.Yes)
            {
                try
                {
                   

                    var nv = qlthuvien.NHANVIENs.Where(t => t.MaNV == ma).FirstOrDefault();
                    if (nv != null)
                    {
                        nv.TenNV = ten;
                        nv.ChucVu = chucvu;
                        nv.SDT_NV = sdt;
                        nv.DiaChi = diachi;
                        nv.Email_NV = email;
                        
                        qlthuvien.SubmitChanges();

                        MessageBox.Show("Sửa thành công!");
                    }
                    else
                        MessageBox.Show("Dữ liệu không tồn tại!");
                }
                catch
                {
                    MessageBox.Show("Sửa thất bại!");
                }
            }
        }
        public void SearchTextBox(DataGridView x, string s)
        {
            var nv = from i in qlthuvien.NHANVIENs
                     where i.MaNV.Contains(s) || i.TenNV.Contains(s) || i.ChucVu.Contains(s) || i.DiaChi.Contains(s) || i.SDT_NV.Contains(s)  ||i.Email_NV.Contains(s)
                     select i;
            x.DataSource = nv;
        }
    }
}
