using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class BLL_QuanLyNhaCungCap
    {
        QLThuVienDataContext qlthuvien = new QLThuVienDataContext();
        public void Load(DataGridView x)
        {
            QLThuVienDataContext qlthuvien = new QLThuVienDataContext();
            var d = from item in qlthuvien.NHACUNGCAPs
                    select new { item.MaNCC, item.TenNCC, item.SDT, item.DiaChiNCC };
            x.DataSource = d;
        }
   
        public int SLNhaCungCap()
        {
            QLThuVienDataContext qlthuvien = new QLThuVienDataContext();
            try
            {
                int ncc = (from i in qlthuvien.NHACUNGCAPs
                           select new { i.MaNCC }).Count();
                return ncc;
            }
            catch { return 0; }
        }
        public void Add(string maNhaCC, string tenNhaCC, string sdt, string diaChi)
        {
            QLThuVienDataContext qlthuvien = new QLThuVienDataContext();
            try
            {
                if (maNhaCC == string.Empty || tenNhaCC == string.Empty || sdt == string.Empty || diaChi == string.Empty)
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin!");
                }
                else
                {
                    NHACUNGCAP a = new NHACUNGCAP();
                    a.MaNCC = maNhaCC;
                    a.TenNCC = tenNhaCC;
                    a.SDT = sdt;
                    a.DiaChiNCC = diaChi;

                    qlthuvien.NHACUNGCAPs.InsertOnSubmit(a);

                    qlthuvien.SubmitChanges();
                    MessageBox.Show("Thêm Thành công!");
                }
            }
            catch { MessageBox.Show("Dữ liệu đã tồn tại"); }
        }
        public void Delete(DataGridView x)
        {
            QLThuVienDataContext qlthuvien = new QLThuVienDataContext();
            try
            {
                DialogResult r = MessageBox.Show("Bạn có Chắc chắn xóa?", "Thông Báo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);
                if (r == DialogResult.Yes)
                {
                    foreach (DataGridViewRow item in x.SelectedRows)
                    {
                        string mancc = item.Cells[0].Value.ToString();

                        // TAILIEU tailieu = qlthuvien.TAILIEUs.Where(p=>p.)
                        var ncc = qlthuvien.NHACUNGCAPs.Where(p => p.MaNCC == mancc).FirstOrDefault();
                        if (ncc != null)
                        {
                            qlthuvien.NHACUNGCAPs.DeleteOnSubmit(ncc);
                            qlthuvien.SubmitChanges();
                        }
                        else { MessageBox.Show("Dữ liệu không tồn tại"); }
                    }
                    MessageBox.Show("Xóa dữ liệu thàng công!");
                }
            }
            catch { MessageBox.Show("Thông tin này đang được sử dụng!"); }
        }
        public void Modify(string maNCC, string tenNCC, string sdt, string diaChi)
        {
            QLThuVienDataContext qlthuvien = new QLThuVienDataContext();
            try
            {
                if (tenNCC == string.Empty || sdt == string.Empty || diaChi == string.Empty)
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin!");
                    return;
                }
                var ncc = qlthuvien.NHACUNGCAPs.Where(p => p.MaNCC == maNCC).FirstOrDefault();
                if (ncc != null)
                {
                    ncc.TenNCC = tenNCC;
                    ncc.SDT = sdt;
                    ncc.DiaChiNCC = diaChi;

                    qlthuvien.SubmitChanges();
                    MessageBox.Show("Sửa thành công!");
                }
                else MessageBox.Show("Dữ liệu không tồn tại!");
            }
            catch
            {
                MessageBox.Show("Dữ liệu không tồn tại!");
            }
        }

        public void SearchTextBox(DataGridView x, string a)
        {
            var ncc = from item in qlthuvien.NHACUNGCAPs
                      where item.MaNCC.Contains(a) || item.TenNCC.Contains(a) || item.SDT.Contains(a) || item.DiaChiNCC.Contains(a)
                      select item;
            x.DataSource = ncc;
        }

       
    }


}
