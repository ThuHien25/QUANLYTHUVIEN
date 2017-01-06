namespace PhanMemQLThuVien
{
    partial class frmChuyenNganh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgvDanhSachChuyenNganh = new GNHHControl.dataGridViewGNHH(this.components);
            this.MaChuyenNganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenChuyenNganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupTTLoaiChuyenNganh = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtMaChuyenNganh = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtTenChuyenNganh = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtTimKiem = new Controls.TextBoxTimKiem(this.components);
            this.tableLayoutPanel3.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachChuyenNganh)).BeginInit();
            this.groupTTLoaiChuyenNganh.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel3.Controls.Add(this.groupPanel1, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.groupTTLoaiChuyenNganh, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtTimKiem, 3, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 42);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(711, 343);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.tableLayoutPanel3.SetColumnSpan(this.groupPanel1, 3);
            this.groupPanel1.Controls.Add(this.dgvDanhSachChuyenNganh);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.Location = new System.Drawing.Point(14, 129);
            this.groupPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(682, 200);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel1.TabIndex = 5;
            this.groupPanel1.Text = "Danh Sách Loại Chuyên Ngành";
            // 
            // dgvDanhSachChuyenNganh
            // 
            this.dgvDanhSachChuyenNganh.AllowUserToAddRows = false;
            this.dgvDanhSachChuyenNganh.AllowUserToDeleteRows = false;
            this.dgvDanhSachChuyenNganh.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dgvDanhSachChuyenNganh.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvDanhSachChuyenNganh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvDanhSachChuyenNganh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachChuyenNganh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaChuyenNganh,
            this.TenChuyenNganh});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhSachChuyenNganh.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgvDanhSachChuyenNganh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachChuyenNganh.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvDanhSachChuyenNganh.Location = new System.Drawing.Point(0, 0);
            this.dgvDanhSachChuyenNganh.Name = "dgvDanhSachChuyenNganh";
            this.dgvDanhSachChuyenNganh.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvDanhSachChuyenNganh.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvDanhSachChuyenNganh.RowHeadersWidth = 60;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dgvDanhSachChuyenNganh.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvDanhSachChuyenNganh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachChuyenNganh.Size = new System.Drawing.Size(676, 177);
            this.dgvDanhSachChuyenNganh.TabIndex = 0;
            this.dgvDanhSachChuyenNganh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachNhaXuatBan_CellClick);
            // 
            // MaChuyenNganh
            // 
            this.MaChuyenNganh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaChuyenNganh.DataPropertyName = "MaChuyenNganh";
            this.MaChuyenNganh.HeaderText = "Mã Chuyên Ngành";
            this.MaChuyenNganh.Name = "MaChuyenNganh";
            this.MaChuyenNganh.ReadOnly = true;
            // 
            // TenChuyenNganh
            // 
            this.TenChuyenNganh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenChuyenNganh.DataPropertyName = "TenChuyenNganh";
            this.TenChuyenNganh.HeaderText = "Tên Chuyên Ngành";
            this.TenChuyenNganh.Name = "TenChuyenNganh";
            this.TenChuyenNganh.ReadOnly = true;
            // 
            // groupTTLoaiChuyenNganh
            // 
            this.groupTTLoaiChuyenNganh.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupTTLoaiChuyenNganh.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupTTLoaiChuyenNganh.Controls.Add(this.tableLayoutPanel2);
            this.groupTTLoaiChuyenNganh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupTTLoaiChuyenNganh.Location = new System.Drawing.Point(152, 44);
            this.groupTTLoaiChuyenNganh.Margin = new System.Windows.Forms.Padding(4);
            this.groupTTLoaiChuyenNganh.Name = "groupTTLoaiChuyenNganh";
            this.groupTTLoaiChuyenNganh.Size = new System.Drawing.Size(406, 77);
            // 
            // 
            // 
            this.groupTTLoaiChuyenNganh.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupTTLoaiChuyenNganh.Style.BackColorGradientAngle = 90;
            this.groupTTLoaiChuyenNganh.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupTTLoaiChuyenNganh.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupTTLoaiChuyenNganh.Style.BorderBottomWidth = 1;
            this.groupTTLoaiChuyenNganh.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupTTLoaiChuyenNganh.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupTTLoaiChuyenNganh.Style.BorderLeftWidth = 1;
            this.groupTTLoaiChuyenNganh.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupTTLoaiChuyenNganh.Style.BorderRightWidth = 1;
            this.groupTTLoaiChuyenNganh.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupTTLoaiChuyenNganh.Style.BorderTopWidth = 1;
            this.groupTTLoaiChuyenNganh.Style.CornerDiameter = 4;
            this.groupTTLoaiChuyenNganh.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupTTLoaiChuyenNganh.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupTTLoaiChuyenNganh.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupTTLoaiChuyenNganh.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupTTLoaiChuyenNganh.TabIndex = 6;
            this.groupTTLoaiChuyenNganh.Text = "Thông Tin Loại Chuyên Ngành";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.Controls.Add(this.labelX1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtMaChuyenNganh, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelX2, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtTenChuyenNganh, 5, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(400, 54);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // labelX1
            // 
            this.labelX1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelX1.Location = new System.Drawing.Point(4, 13);
            this.labelX1.Margin = new System.Windows.Forms.Padding(4);
            this.labelX1.Name = "labelX1";
            this.labelX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX1.Size = new System.Drawing.Size(112, 27);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Mã Chuyên Ngành";
            // 
            // txtMaChuyenNganh
            // 
            // 
            // 
            // 
            this.txtMaChuyenNganh.Border.Class = "TextBoxBorder";
            this.txtMaChuyenNganh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMaChuyenNganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaChuyenNganh.Location = new System.Drawing.Point(134, 13);
            this.txtMaChuyenNganh.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaChuyenNganh.Name = "txtMaChuyenNganh";
            this.txtMaChuyenNganh.Size = new System.Drawing.Size(52, 22);
            this.txtMaChuyenNganh.TabIndex = 2;
            // 
            // labelX2
            // 
            this.labelX2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelX2.Location = new System.Drawing.Point(194, 13);
            this.labelX2.Margin = new System.Windows.Forms.Padding(4);
            this.labelX2.Name = "labelX2";
            this.labelX2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX2.Size = new System.Drawing.Size(122, 27);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Tên Chuyên Ngành";
            // 
            // txtTenChuyenNganh
            // 
            // 
            // 
            // 
            this.txtTenChuyenNganh.Border.Class = "TextBoxBorder";
            this.txtTenChuyenNganh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTenChuyenNganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenChuyenNganh.Location = new System.Drawing.Point(334, 13);
            this.txtTenChuyenNganh.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenChuyenNganh.Name = "txtTenChuyenNganh";
            this.txtTenChuyenNganh.Size = new System.Drawing.Size(52, 22);
            this.txtTenChuyenNganh.TabIndex = 3;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.ForeColor = System.Drawing.Color.Gray;
            this.txtTimKiem.Location = new System.Drawing.Point(565, 13);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(132, 22);
            this.txtTimKiem.TabIndex = 7;
            this.txtTimKiem.Text = "Nhập từ khóa cần tìm kiếm...";
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged_1);
            this.txtTimKiem.MouseEnter += new System.EventHandler(this.txtTimKiem_MouseEnter_1);
            // 
            // frmChuyenNganh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 387);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmChuyenNganh";
            this.Text = "Loại chuyên ngành";
            this.Load += new System.EventHandler(this.frmNhaXuatBan_Load);
            this.Controls.SetChildIndex(this.tableLayoutPanel3, 0);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachChuyenNganh)).EndInit();
            this.groupTTLoaiChuyenNganh.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupTTLoaiChuyenNganh;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaChuyenNganh;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenChuyenNganh;
        private GNHHControl.dataGridViewGNHH dgvDanhSachChuyenNganh;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChuyenNganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenChuyenNganh;
        private Controls.TextBoxTimKiem txtTimKiem;

    }
}