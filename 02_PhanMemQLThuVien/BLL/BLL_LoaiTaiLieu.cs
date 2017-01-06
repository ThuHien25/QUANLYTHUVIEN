using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BLL
{
    public class BLL_LoaiTaiLieu
    {
        QLThuVienDataContext qlthuvien = new QLThuVienDataContext();
        public void Load(DataGridView x)
        {
            qlthuvien = new QLThuVienDataContext();
            var loaitailieus = from i in qlthuvien.LOAITAILIEUs
                               select i;
            x.DataSource = loaitailieus;
        }
        public void Add(string maLoaiTL, string tenLoaiTL)
        {
            qlthuvien = new QLThuVienDataContext();
            try
            {
                if (maLoaiTL != string.Empty || tenLoaiTL != string.Empty)
                {
                    LOAITAILIEU loaitailieu = new LOAITAILIEU();
                    loaitailieu.MaLoai = maLoaiTL;
                    loaitailieu.TenLoai = tenLoaiTL;

                    qlthuvien.LOAITAILIEUs.InsertOnSubmit(loaitailieu);

                    qlthuvien.SubmitChanges();

                    MessageBox.Show("Thêm thành công!");

                }
                else
                {
                    MessageBox.Show("Thông tin không được bỏ trống");
                }
            }
            catch
            {
                MessageBox.Show("Dữ liệu đã tồn tại!");
            }
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
                        var loaitailieu = qlthuvien.LOAITAILIEUs.Where(p => p.MaLoai == item.Cells[0].Value.ToString()).FirstOrDefault();
                        if (loaitailieu != null)
                        {
                            qlthuvien.LOAITAILIEUs.DeleteOnSubmit(loaitailieu);
                            qlthuvien.SubmitChanges();
                        }
                        else MessageBox.Show("Dữ liệu không tồn tại!");
                    }
                    MessageBox.Show("Xóa dữ liệu thành công!");
                }

            }
            catch { MessageBox.Show("Thông tin này đang được sử dụng!"); }
        }
        public void Modify(string maLoaiTL, string tenLoaiTL)
        {
            qlthuvien = new QLThuVienDataContext();
            try
            {
                var loaitailieu = qlthuvien.LOAITAILIEUs.Where(p => p.MaLoai == maLoaiTL).FirstOrDefault();
                if (loaitailieu != null)
                {
                    loaitailieu.TenLoai = tenLoaiTL;
                    qlthuvien.SubmitChanges();
                    MessageBox.Show("Sửa thành công!");
                }
                else MessageBox.Show("Dự liệu không tồn tại");
            }
            catch { MessageBox.Show("Dữ liệu không tồn tại"); }

        }
        public void SearchTextBox(DataGridView x, string a)
        {
            var tim = from item in qlthuvien.LOAITAILIEUs
                      where item.MaLoai.Contains(a) || item.TenLoai.Contains(a)
                      select item;
            x.DataSource = tim;
        }
    }
}
