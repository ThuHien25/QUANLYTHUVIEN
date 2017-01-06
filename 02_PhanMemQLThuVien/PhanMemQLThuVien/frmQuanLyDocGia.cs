using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
namespace PhanMemQLThuVien
{
    public partial class frmQuanLyDocGia : frmBaseFull
    {
        public frmQuanLyDocGia()
        {
            InitializeComponent();
            
        }
        BLL_QuanLyDocGia dg = new BLL_QuanLyDocGia();
        private void frmQuanLyDocGia_Load(object sender, EventArgs e)
        {
            Functions.Enable_Groupbox(grbDocGia, false);
            LoadDate();
            dg.Loaddgv(dgvQuanLyDocGia);
            dg.LoadCbbLoaiDocGia(cbbLoaiDocGia);
            Functions.Clear(grbDocGia);
            lblTongDocGia.Text = dg.TongDocGia().ToString();
        }
        /// <summary>
        /// Kiểm tra hạn thẻ và tiền cọc phải lớn hơn 0 
        /// </summary>
        private void KT()
        {
            int HanThe = int.Parse(txtHanThe.Text);
            int TienCoc = int.Parse(txtTienCoc.Text);
            if(HanThe <=0)
            {
                MessageBox.Show("Hạn thẻ phải lớn hơn 0!");
                return;
            } 
            if(TienCoc<=0)
            {
                MessageBox.Show("Tiền cọc phải lơn hơn 0");
                return;
            }
        }
        protected override void OnAdd()
        {
            Functions.Enable_Groupbox(grbDocGia, true);
            Functions.Clear(grbDocGia);
            LoadDate();
            txtMaDocGia.Focus();
            dTPngaySinh.Enabled = true;
        }
        protected override void OnEdit()
        {
            Functions.Enable_Groupbox(grbDocGia, true);
            txtMaDocGia.Enabled = false;
            dTPngayLapThe.Enabled = true;
            dTPngaySinh.Enabled = true;
        }
        protected override void OnDeleted()
        {
            if (dgvQuanLyDocGia.SelectedRows == null)
                MessageBox.Show("Chọn dữ liệu cần xóa");
            else
            {
                dg.Delete(dgvQuanLyDocGia);
                dg.Loaddgv(dgvQuanLyDocGia);
                Functions.Clear(grbDocGia);
            }
            lblTongDocGia.Text = dg.TongDocGia().ToString();
        }
        protected override void OnSaveAdd()
        {
            KT();

            string ma, ten, maLoai, email;
            int hanThe, tienCoc;
            DateTime ngSinh, ngDangKy;

            ma = txtMaDocGia.Text;
            ten = txtHoVaTen.Text;
            ngSinh = dTPngaySinh.Value;
            maLoai = cbbLoaiDocGia.SelectedValue.ToString();
            email = txtEmail.Text;
            ngDangKy = dTPngayLapThe.Value;
            hanThe = int.Parse(txtHanThe.Text);
            tienCoc = int.Parse(txtTienCoc.Text);

            dg.Add(ma, ten, maLoai, ngSinh, email, ngDangKy, hanThe, tienCoc);

            lblTongDocGia.Text = dg.TongDocGia().ToString();            
        }
        protected override void OnSaveEdit()
        {
            KT();

            string ma, ten, maLoai, email;
            int hanThe, tienCoc;
            DateTime ngSinh, ngDangKy;

            ma = dgvQuanLyDocGia.SelectedCells[0].Value.ToString();
            ten = txtHoVaTen.Text;
            ngSinh = dTPngaySinh.Value;
            maLoai = cbbLoaiDocGia.SelectedValue.ToString();
            email = txtEmail.Text;
            ngDangKy = dTPngayLapThe.Value;
            hanThe = int.Parse(txtHanThe.Text);
            tienCoc = int.Parse(txtTienCoc.Text);

            dg.Modify(ma, ten, maLoai, ngSinh, email, ngDangKy, hanThe, tienCoc);
        }
        protected override void OnSave()
        {
            if (txtMaDocGia.Enabled == true)
                OnSaveAdd();
            else
                OnSaveEdit();
            dg.Loaddgv(dgvQuanLyDocGia);
            Functions.AfterSucess(dgvQuanLyDocGia, this, txtMaDocGia.Text, 0);
            EnableLoadForm();
            Functions.Enable_Groupbox(grbDocGia, false);
        }
        protected override void OnCancel()
        {
            Functions.Clear(grbDocGia);
            Functions.Enable_Groupbox(grbDocGia, false);
            dTPngayLapThe.Enabled = dTPngaySinh.Enabled = false;
            
        }
        private void btnThemLoaiDocGia_Click(object sender, EventArgs e)
        {
            frmLoaiDocGia frm = new frmLoaiDocGia();
            frm.Visible_Close(true);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }
        private void LoadDate()
        {
            dTPngayLapThe.Text = DateTime.Now.ToString();
            dTPngaySinh.Text = DateTime.Now.ToString();
        }
        
        private void dgvQuanLyDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvQuanLyDocGia.SelectedRows.Count != 0)
            {
                

                txtMaDocGia.Text = dgvQuanLyDocGia.CurrentRow.Cells["MaDocGia"].Value.ToString();
                txtHoVaTen.Text = dgvQuanLyDocGia.CurrentRow.Cells["TenDocGia"].Value.ToString();
                txtEmail.Text = dgvQuanLyDocGia.CurrentRow.Cells["Email"].Value.ToString();

                dTPngayLapThe.Text = dgvQuanLyDocGia.CurrentRow.Cells["NgayLapThe"].Value.ToString();
                txtTienCoc.Text = dgvQuanLyDocGia.CurrentRow.Cells["TienCoc"].Value.ToString();

                cbbLoaiDocGia.DisplayMember = dgvQuanLyDocGia.CurrentRow.Cells["LoaiDocGia"].Value.ToString();
                dTPngaySinh.Text = dgvQuanLyDocGia.CurrentRow.Cells["NgaySinh"].Value.ToString(); 
                txtHanThe.Text = dgvQuanLyDocGia.CurrentRow.Cells["HanThe"].Value.ToString();
            }
            Enable_DataGridView_CellClick();
            Functions.Enable_Groupbox(grbDocGia, false);
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if(txtTimKiem.Text != "Nhập từ khóa cần tìm kiếm...")
            {
                dg.SearchTextBox(dgvQuanLyDocGia, txtTimKiem.Text);
                Functions.Clear(grbDocGia);
            }
        }
    }
}
