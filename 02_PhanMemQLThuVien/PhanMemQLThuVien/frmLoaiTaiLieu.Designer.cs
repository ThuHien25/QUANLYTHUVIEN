namespace PhanMemQLThuVien
{
    partial class frmLoaiTaiLieu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupLoaiTL = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblMa = new DevComponents.DotNetBar.LabelX();
            this.txtMaLoaiTaiLieu = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtTenLoaiTaiLieu = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblTen = new DevComponents.DotNetBar.LabelX();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgvDanhSachLoaiTaiLieu = new GNHHControl.dataGridViewGNHH(this.components);
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTimKiem = new Controls.TextBoxTimKiem(this.components);
            this.tableLayoutPanel3.SuspendLayout();
            this.groupLoaiTL.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachLoaiTaiLieu)).BeginInit();
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
            this.tableLayoutPanel3.Controls.Add(this.groupLoaiTL, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.groupPanel2, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.txtTimKiem, 3, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 42);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(730, 312);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // groupLoaiTL
            // 
            this.groupLoaiTL.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupLoaiTL.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupLoaiTL.Controls.Add(this.tableLayoutPanel2);
            this.groupLoaiTL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupLoaiTL.Location = new System.Drawing.Point(156, 46);
            this.groupLoaiTL.Margin = new System.Windows.Forms.Padding(4);
            this.groupLoaiTL.Name = "groupLoaiTL";
            this.groupLoaiTL.Size = new System.Drawing.Size(418, 62);
            // 
            // 
            // 
            this.groupLoaiTL.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupLoaiTL.Style.BackColorGradientAngle = 90;
            this.groupLoaiTL.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupLoaiTL.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupLoaiTL.Style.BorderBottomWidth = 1;
            this.groupLoaiTL.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupLoaiTL.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupLoaiTL.Style.BorderLeftWidth = 1;
            this.groupLoaiTL.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupLoaiTL.Style.BorderRightWidth = 1;
            this.groupLoaiTL.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupLoaiTL.Style.BorderTopWidth = 1;
            this.groupLoaiTL.Style.CornerDiameter = 4;
            this.groupLoaiTL.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupLoaiTL.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupLoaiTL.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupLoaiTL.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupLoaiTL.TabIndex = 10;
            this.groupLoaiTL.Text = "Thông Tin Loại Tài Liệu";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel2.Controls.Add(this.lblMa, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtMaLoaiTaiLieu, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtTenLoaiTaiLieu, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblTen, 3, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(412, 39);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // lblMa
            // 
            this.lblMa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMa.Location = new System.Drawing.Point(4, 8);
            this.lblMa.Margin = new System.Windows.Forms.Padding(4);
            this.lblMa.Name = "lblMa";
            this.lblMa.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMa.Size = new System.Drawing.Size(92, 22);
            this.lblMa.TabIndex = 0;
            this.lblMa.Text = "Mã Thể Loại";
            // 
            // txtMaLoaiTaiLieu
            // 
            // 
            // 
            // 
            this.txtMaLoaiTaiLieu.Border.Class = "TextBoxBorder";
            this.txtMaLoaiTaiLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMaLoaiTaiLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaLoaiTaiLieu.Location = new System.Drawing.Point(119, 8);
            this.txtMaLoaiTaiLieu.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaLoaiTaiLieu.Name = "txtMaLoaiTaiLieu";
            this.txtMaLoaiTaiLieu.Size = new System.Drawing.Size(79, 22);
            this.txtMaLoaiTaiLieu.TabIndex = 2;
            // 
            // txtTenLoaiTaiLieu
            // 
            // 
            // 
            // 
            this.txtTenLoaiTaiLieu.Border.Class = "TextBoxBorder";
            this.txtTenLoaiTaiLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTenLoaiTaiLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenLoaiTaiLieu.Location = new System.Drawing.Point(321, 8);
            this.txtTenLoaiTaiLieu.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenLoaiTaiLieu.Name = "txtTenLoaiTaiLieu";
            this.txtTenLoaiTaiLieu.Size = new System.Drawing.Size(79, 22);
            this.txtTenLoaiTaiLieu.TabIndex = 3;
            // 
            // lblTen
            // 
            this.lblTen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTen.Location = new System.Drawing.Point(206, 8);
            this.lblTen.Margin = new System.Windows.Forms.Padding(4);
            this.lblTen.Name = "lblTen";
            this.lblTen.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTen.Size = new System.Drawing.Size(92, 22);
            this.lblTen.TabIndex = 1;
            this.lblTen.Text = "Tên Thể Loại";
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.tableLayoutPanel3.SetColumnSpan(this.groupPanel2, 3);
            this.groupPanel2.Controls.Add(this.dgvDanhSachLoaiTaiLieu);
            this.groupPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupPanel2.Location = new System.Drawing.Point(13, 115);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(704, 182);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel2.TabIndex = 11;
            this.groupPanel2.Text = "Danh Sách Loại Tài Liệu";
            // 
            // dgvDanhSachLoaiTaiLieu
            // 
            this.dgvDanhSachLoaiTaiLieu.AllowUserToAddRows = false;
            this.dgvDanhSachLoaiTaiLieu.AllowUserToDeleteRows = false;
            this.dgvDanhSachLoaiTaiLieu.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dgvDanhSachLoaiTaiLieu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvDanhSachLoaiTaiLieu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDanhSachLoaiTaiLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachLoaiTaiLieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhSachLoaiTaiLieu.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDanhSachLoaiTaiLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachLoaiTaiLieu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvDanhSachLoaiTaiLieu.Location = new System.Drawing.Point(0, 0);
            this.dgvDanhSachLoaiTaiLieu.Name = "dgvDanhSachLoaiTaiLieu";
            this.dgvDanhSachLoaiTaiLieu.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvDanhSachLoaiTaiLieu.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDanhSachLoaiTaiLieu.RowHeadersWidth = 60;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dgvDanhSachLoaiTaiLieu.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDanhSachLoaiTaiLieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachLoaiTaiLieu.Size = new System.Drawing.Size(698, 159);
            this.dgvDanhSachLoaiTaiLieu.TabIndex = 0;
            this.dgvDanhSachLoaiTaiLieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachLoaiTaiLieu_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "maloai";
            this.Column1.HeaderText = "Mã Thể Loại";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "tenloai";
            this.Column2.HeaderText = "Tên Thể Loại";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.ForeColor = System.Drawing.Color.Gray;
            this.txtTimKiem.Location = new System.Drawing.Point(581, 15);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(136, 22);
            this.txtTimKiem.TabIndex = 12;
            this.txtTimKiem.Text = "Nhập từ khóa cần tìm kiếm...";
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // frmLoaiTaiLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 356);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Name = "frmLoaiTaiLieu";
            this.Text = "Quản Lý Loại Tài Liệu";
            this.Load += new System.EventHandler(this.frmLoaiTaiLieu_Load);
            this.Controls.SetChildIndex(this.tableLayoutPanel3, 0);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.groupLoaiTL.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachLoaiTaiLieu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private DevComponents.DotNetBar.Controls.GroupPanel groupLoaiTL;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevComponents.DotNetBar.LabelX lblMa;
        private DevComponents.DotNetBar.LabelX lblTen;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaLoaiTaiLieu;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenLoaiTaiLieu;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private GNHHControl.dataGridViewGNHH dgvDanhSachLoaiTaiLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private Controls.TextBoxTimKiem txtTimKiem;


    }
}