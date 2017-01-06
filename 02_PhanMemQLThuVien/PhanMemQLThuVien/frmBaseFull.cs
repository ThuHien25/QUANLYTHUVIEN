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
    public partial class frmBaseFull : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public frmBaseFull()
        {
            InitializeComponent();
        }
        public virtual void Enable_DataGridView_CellClick()
        {
            btnSua.Enabled = btnXoa.Enabled = btnThem.Enabled = true;
            btnLuu.Enabled = btnHuy.Enabled = false;
        }
        public virtual void EnableLoadForm()
        {
            btnXoa.Enabled = btnLuu.Enabled = btnSua.Enabled = btnHuy.Enabled = false;
            btnThem.Enabled = true;
        }
        private void frmBaseFull_Load(object sender, EventArgs e)
        {
            Visible_In(false);
            Visible_Close(false);
            EnableLoadForm();    
        }
        
        public virtual void Enable_Them(bool x) { btnThem.Enabled = x; }
        public virtual void Enable_Xoa(bool x) { btnXoa.Enabled = x; }
        public virtual void Enable_All(bool x) { btnThem.Enabled = btnXoa.Enabled = btnHuy.Enabled = btnLuu.Enabled = x; }

        public virtual void Visible_Them(bool x) { btnThem.Visible = x; }
        public virtual void Visible_In(bool x) { btnInReport.Visible = x;}
        public virtual void Visible_Sua(bool x) { btnSua.Visible = x;}
        public virtual void Visible_Close(bool x) { btnClose.Visible = x; }

        protected virtual void OnAdd() {}
        protected virtual void OnDeleted(){}
        protected virtual void OnEdit(){}
        protected virtual void OnSave(){}
        protected virtual void OnCancel(){}
        protected virtual void OnSaveAdd() { }
        protected virtual void OnSaveEdit() { }
        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc chắn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (r == DialogResult.Yes)
                this.Close();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            btnXoa.Enabled = btnSua.Enabled = btnThem.Enabled = false;
            btnLuu.Enabled = btnHuy.Enabled = true;
            OnAdd();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //btnXoa.Enabled = btnSua.Enabled = btnThem.Enabled = false;
            OnDeleted();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnXoa.Enabled = btnThem.Enabled = btnSua.Enabled = false;
            btnLuu.Enabled = btnHuy.Enabled = true;
            OnEdit();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnLuu.Enabled = btnHuy.Enabled = false;
            OnCancel();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            OnSave();
        }
    }
}
