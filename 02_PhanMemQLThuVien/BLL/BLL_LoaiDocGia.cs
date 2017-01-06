using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class BLL_LoaiDocGia
    {
        QLThuVienDataContext qlthuvien = new QLThuVienDataContext();

        public void Load(DataGridView x)
        {
            QLThuVienDataContext qlthuvien = new QLThuVienDataContext();
            var d = from item in qlthuvien.LOAIDOCGIAs select item;
            x.DataSource = d;
        }
        public void Add(string maloaidg, string tenloaidg)
        {
            QLThuVienDataContext qlthuvien = new QLThuVienDataContext();
            try
            {
                if (maloaidg == string.Empty || tenloaidg == string.Empty)
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin!");
                }
                else
                {
                    //B1: Tao 1 the hien tu 1 thuc the
                    LOAIDOCGIA a = new LOAIDOCGIA();
                    //B2: Gan du lieu vao thuoc tinh 
                    a.MaLoaiDG = maloaidg;
                    a.TenLoaiDG = tenloaidg;
                    //B3: Add du lieu vao bang QL_NGUOIDUNG
                    qlthuvien.LOAIDOCGIAs.InsertOnSubmit(a);
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
                            var dg = qlthuvien.LOAIDOCGIAs.Where(p => p.MaLoaiDG == item.Cells[0].Value.ToString()).FirstOrDefault();
                            if (dg != null)
                            {
                                qlthuvien.LOAIDOCGIAs.DeleteOnSubmit(dg);
                                qlthuvien.SubmitChanges();
                            }
                            else MessageBox.Show("Dữ liệu không tồn tại!");
                        }
                        MessageBox.Show("Xóa dữ liệu thành công!");
                    
                }
            }
            catch { MessageBox.Show("Thông tin này đang được sử dụng!"); }
        }
        public void Modify(string maloaidg, string tenloaidg)
        {
            QLThuVienDataContext qlthuvien = new QLThuVienDataContext();
            try
            {
                if (tenloaidg == string.Empty)
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin!");
                    return;
                }
                var dg = qlthuvien.LOAIDOCGIAs.Where(p => p.MaLoaiDG == maloaidg).FirstOrDefault();
                if (dg != null)
                {
                    dg.TenLoaiDG = tenloaidg;
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
            var dg = from item in qlthuvien.LOAIDOCGIAs
                     where item.MaLoaiDG.Contains(a) || item.TenLoaiDG.Contains(a)
                     select item;
            x.DataSource = dg;
        }
    }
}
