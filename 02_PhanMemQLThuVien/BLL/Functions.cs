using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BLL
{
    public class Functions
    {
        /// <summary>
        /// Control: ten groupbox
        /// </summary>
        /// <param name="Container"></param>
        /// <param name="x"></param>
        public static void Enable_Groupbox(Control Container, bool x)
        {
            foreach (Control ctr in Container.Controls)
            {
                if (ctr is TextBox || ctr is ComboBox || ctr is DateTimePicker)
                    ctr.Enabled = x;
                if (ctr.Controls.Count != 0)
                    Enable_Groupbox(ctr, x);
            }
        }
        public static bool IsNumber(string pText)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(pText);
        }
        /// <summary>
        /// Clear textbox chữ, textbox số thì mặc định = 0, datetimepiker ngày hiện tại, combobox lấy index = 0
        ///  groupbox is true: nếu nhấn nút thêm, mở groupbox, false: nếu nhấn nút hủy, đóng groupbox lại
        /// </summary>
        /// <param name="Container"></param>
        /// <param name="x">
        /// </param>
        public static void Clear(Control Container)
        {
            foreach (Control ctr in Container.Controls)
            {
                if (ctr is TextBox)
                {
                    if (IsNumber(ctr.Text))
                        ctr.Text = "0";
                    else
                        ctr.Text = string.Empty;
                }
                else if (ctr is DateTimePicker)
                    ((DateTimePicker)ctr).Value = DateTime.Now;
                else if (ctr is ComboBox)
                {
                    if (((ComboBox)ctr).Items.Count != 0)
                        ((ComboBox)ctr).SelectedIndex = 0;
                }
                if (ctr.Controls.Count != 0)
                    Clear(ctr);
            }
        }
        public static string AutoCode(string Ma)
        {
            return Ma + DateTime.Now.ToString("ddMMyyHHmmss");
        }
        /// <summary>
        /// Sau khi thêm/sửa thành công sẽ trỏ đến dòng mới thêm/sửa
        /// Container: Form đang sử dụng (this)
        /// TextBox: Mã
        /// Thêm: TextBox - Tên, ID - Tên cột
        /// Sửa: TextBox - Mã, ID - Tên cột
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="ID"></param>
        /// <param name="Container"></param>
        /// <param name="t"></param>
        public static void AfterSucess(DataGridView dgv, Control Container, string TextBox, string ID)
        {
            dgv.ClearSelection();
            foreach (DataGridViewRow item in dgv.Rows)
            {
                if (TextBox == item.Cells[ID].Value.ToString())
                    item.Selected = true;
            }
        }
        /// <summary>
        /// Sau khi thêm/sửa thành công sẽ trỏ đến dòng mới thêm/sửa
        /// Container: Form đang sử dụng (this)
        /// TextBox: Mã
        /// Thêm: TextBox - Tên, ID - Tên cột
        /// Sửa: TextBox - Mã, ID - Tên cột
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="ID"></param>
        /// <param name="Container"></param>
        /// <param name="t"></param>
        public static void AfterSucess(DataGridView dgv, Control Container, string TextBox, int ID)
        {
            dgv.ClearSelection();
            foreach (DataGridViewRow item in dgv.Rows)
            {
                if (TextBox == item.Cells[ID].Value.ToString())
                    item.Selected = true;
            }
        }
    }
}
