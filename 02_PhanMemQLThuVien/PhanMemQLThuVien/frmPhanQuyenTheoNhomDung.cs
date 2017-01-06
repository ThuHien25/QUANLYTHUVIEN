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
    public partial class frmPhanQuyenTheoNhomDung : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public frmPhanQuyenTheoNhomDung()
        {
            InitializeComponent();
        }

        private void trV_danhsach_AfterExpand(object sender, TreeViewEventArgs e)
        {
           //if(e.Node.Nodes.)
            //if (e.Node.Checked == true)
            //{
            //    TreeNodeCollection node = e.Node.Nodes;
            //    foreach (TreeNode item in node)
            //    {
            //        item.Checked = true;
            //    }
            //}
           // int n = 0;
        }

        private void trV_danhsach_AfterCheck(object sender, TreeViewEventArgs e)
        {

          //  int n = 0;
            TreeNodeCollection node = e.Node.Nodes;
            if (e.Node.Checked == true)
            {
              
                foreach (TreeNode item in node)
                {
                    item.Checked = true;
                }
            }
            else
            {
                foreach (TreeNode item in node)
                {
                    item.Checked = false;
                }
            }

        }
        

    }
}