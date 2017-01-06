using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BLL
{
    public class BLL_ChuyenNganh
    {
        QLThuVienDataContext qlthuvien = new QLThuVienDataContext();

        public void Load(DataGridView x)
        {
            QLThuVienDataContext qlthuvien = new QLThuVienDataContext();
            x.DataSource = from item in qlthuvien.CHUYENNGANHs select item;
        }
        public void Add(string machuyennganh, string tenchuyennganh)
        {
            QLThuVienDataContext qlthuvien = new QLThuVienDataContext();
            try
            {
                if (machuyennganh == string.Empty || tenchuyennganh == string.Empty)
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin!");
                }
                else
                {
                    //B1: Tao 1 the hien tu 1 thuc the
                    CHUYENNGANH a = new CHUYENNGANH();
                    //B2: Gan du lieu vao thuoc tinh 
                    a.MaChuyenNganh = machuyennganh;
                    a.TenChuyenNganh = tenchuyennganh;
                    //B3: Add du lieu vao bang QL_NGUOIDUNG
                    qlthuvien.CHUYENNGANHs.InsertOnSubmit(a);
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
                        var dg = qlthuvien.CHUYENNGANHs.Where(p => p.MaChuyenNganh == item.Cells[0].Value.ToString()).FirstOrDefault();
                        if (dg != null)
                        {
                            qlthuvien.CHUYENNGANHs.DeleteOnSubmit(dg);
                            qlthuvien.SubmitChanges();
                        }
                        else MessageBox.Show("Dữ liệu không tồn tại!");
                    }
                    MessageBox.Show("Xóa dữ liệu thành công!");

                }
            }
            catch { MessageBox.Show("Thông tin này đang được sử dụng!"); }
        }
        public void Modify(string machuyennganh, string tenchuyennganh)
        {
            QLThuVienDataContext qlthuvien = new QLThuVienDataContext();
            try
            {
                if (tenchuyennganh == string.Empty)
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin!");
                    return;
                }
                var dg = qlthuvien.CHUYENNGANHs.Where(p => p.MaChuyenNganh == machuyennganh).FirstOrDefault();
                if (dg != null)
                {
                    dg.TenChuyenNganh = tenchuyennganh;
                    qlthuvien.SubmitChanges();
                    MessageBox.Show("Sửa thành công!");
                }
                else
                    MessageBox.Show("Dữ liệu không tồn tại!");
            }
            catch { MessageBox.Show("Dữ liệu không tồn tại!"); }
        }
        public void SearchTextBox(DataGridView x, string a)
        {
            x.DataSource = from item in qlthuvien.CHUYENNGANHs
                     where item.TenChuyenNganh.Contains(a) || item.MaChuyenNganh.Contains(a)
                     select item;
        }
    }
}
