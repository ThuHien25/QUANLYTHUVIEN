using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PhanMemQLThuVien
{
    public partial class frmCauhinh : DevComponents.DotNetBar.Office2007Form
    {
        public frmCauhinh()
        {
            InitializeComponent();
        }
        QL_NguoiDung CauHinh = new QL_NguoiDung();
        private void frmCauhinh_Load(object sender, EventArgs e)
        {
            MinimizeBox = false;
            MaximizeBox = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            CauHinh.SaveConfig(cbbServerName.Text, txtUserName.Text, txtPassword.Text,cbbDatabase.Text);
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbbServerName_DropDown(object sender, EventArgs e)
        {
            cbbServerName.DataSource = CauHinh.GetServerName();
            cbbServerName.DisplayMember = "ServerName";
        }

        private void cbbDatabase_DropDown(object sender, EventArgs e)
        {
            cbbDatabase.DataSource = CauHinh.GetDBName(cbbServerName.Text, txtUserName.Text, txtPassword.Text);
            cbbDatabase.DisplayMember = "name";
        }
    }
}
