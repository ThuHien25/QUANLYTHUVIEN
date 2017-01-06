namespace PhanMemQLThuVien
{
    partial class frmQuanLyNguoiDung
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dtgvDanhSachNguoiDung = new GNHHControl.dataGridViewGNHH(this.components);
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoatDong = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.grbNguoiDung = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblMaDocGia = new DevComponents.DotNetBar.LabelX();
            this.cbbTenNhanVien = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelx = new DevComponents.DotNetBar.LabelX();
            this.labelx12 = new DevComponents.DotNetBar.LabelX();
            this.txtTenTaiKhoan = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMatKhau = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.rdbCon = new System.Windows.Forms.RadioButton();
            this.rdbNgung = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.lblTongSoNguoiDung = new DevComponents.DotNetBar.LabelX();
            this.txtTimKiem = new Controls.TextBoxTimKiem(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachNguoiDung)).BeginInit();
            this.grbNguoiDung.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.tableLayoutPanel1.Controls.Add(this.groupPanel2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.grbNguoiDung, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtTimKiem, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 42);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(766, 439);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.tableLayoutPanel1.SetColumnSpan(this.groupPanel2, 3);
            this.groupPanel2.Controls.Add(this.dtgvDanhSachNguoiDung);
            this.groupPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel2.Location = new System.Drawing.Point(13, 143);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(739, 253);
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
            this.groupPanel2.TabIndex = 12;
            this.groupPanel2.Text = "Danh Sách Người Dùng";
            // 
            // dtgvDanhSachNguoiDung
            // 
            this.dtgvDanhSachNguoiDung.AllowUserToAddRows = false;
            this.dtgvDanhSachNguoiDung.AllowUserToDeleteRows = false;
            this.dtgvDanhSachNguoiDung.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtgvDanhSachNguoiDung.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvDanhSachNguoiDung.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvDanhSachNguoiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDanhSachNguoiDung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.TenNV,
            this.TenTaiKhoan,
            this.MatKhau,
            this.HoatDong});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvDanhSachNguoiDung.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvDanhSachNguoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvDanhSachNguoiDung.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dtgvDanhSachNguoiDung.Location = new System.Drawing.Point(0, 0);
            this.dtgvDanhSachNguoiDung.Name = "dtgvDanhSachNguoiDung";
            this.dtgvDanhSachNguoiDung.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtgvDanhSachNguoiDung.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvDanhSachNguoiDung.RowHeadersWidth = 60;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtgvDanhSachNguoiDung.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgvDanhSachNguoiDung.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvDanhSachNguoiDung.Size = new System.Drawing.Size(733, 230);
            this.dtgvDanhSachNguoiDung.TabIndex = 4;
            this.dtgvDanhSachNguoiDung.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDanhSachNguoiDung_CellClick);
            // 
            // MaNV
            // 
            this.MaNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaNV.DataPropertyName = "manv";
            this.MaNV.HeaderText = "Mã Nhân Viên";
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            // 
            // TenNV
            // 
            this.TenNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenNV.DataPropertyName = "tennv";
            this.TenNV.HeaderText = "Tên Nhân Viên";
            this.TenNV.Name = "TenNV";
            this.TenNV.ReadOnly = true;
            // 
            // TenTaiKhoan
            // 
            this.TenTaiKhoan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenTaiKhoan.DataPropertyName = "tentaikhoan";
            this.TenTaiKhoan.HeaderText = "Tên Tài Khoản";
            this.TenTaiKhoan.Name = "TenTaiKhoan";
            this.TenTaiKhoan.ReadOnly = true;
            // 
            // MatKhau
            // 
            this.MatKhau.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MatKhau.DataPropertyName = "matkhau";
            this.MatKhau.HeaderText = "Mật Khẩu";
            this.MatKhau.Name = "MatKhau";
            this.MatKhau.ReadOnly = true;
            // 
            // HoatDong
            // 
            this.HoatDong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HoatDong.DataPropertyName = "hoatdong";
            this.HoatDong.HeaderText = "Hoạt Động";
            this.HoatDong.Name = "HoatDong";
            this.HoatDong.ReadOnly = true;
            this.HoatDong.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.HoatDong.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // grbNguoiDung
            // 
            this.grbNguoiDung.CanvasColor = System.Drawing.SystemColors.Control;
            this.grbNguoiDung.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.grbNguoiDung.Controls.Add(this.tableLayoutPanel2);
            this.grbNguoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbNguoiDung.Location = new System.Drawing.Point(162, 43);
            this.grbNguoiDung.Name = "grbNguoiDung";
            this.grbNguoiDung.Size = new System.Drawing.Size(441, 94);
            // 
            // 
            // 
            this.grbNguoiDung.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.grbNguoiDung.Style.BackColorGradientAngle = 90;
            this.grbNguoiDung.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.grbNguoiDung.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grbNguoiDung.Style.BorderBottomWidth = 1;
            this.grbNguoiDung.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.grbNguoiDung.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grbNguoiDung.Style.BorderLeftWidth = 1;
            this.grbNguoiDung.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grbNguoiDung.Style.BorderRightWidth = 1;
            this.grbNguoiDung.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grbNguoiDung.Style.BorderTopWidth = 1;
            this.grbNguoiDung.Style.CornerDiameter = 4;
            this.grbNguoiDung.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.grbNguoiDung.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.grbNguoiDung.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.grbNguoiDung.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.grbNguoiDung.TabIndex = 11;
            this.grbNguoiDung.Text = "Thông Tin Người Dùng";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 9;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.tableLayoutPanel2.Controls.Add(this.lblMaDocGia, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.cbbTenNhanVien, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelx, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelx12, 5, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtTenTaiKhoan, 7, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtMatKhau, 7, 3);
            this.tableLayoutPanel2.Controls.Add(this.labelX2, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel6, 3, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(435, 71);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // lblMaDocGia
            // 
            this.lblMaDocGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMaDocGia.Location = new System.Drawing.Point(13, 6);
            this.lblMaDocGia.Name = "lblMaDocGia";
            this.lblMaDocGia.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMaDocGia.Size = new System.Drawing.Size(94, 24);
            this.lblMaDocGia.TabIndex = 0;
            this.lblMaDocGia.Text = "Tên Nhân Viên";
            // 
            // cbbTenNhanVien
            // 
            this.cbbTenNhanVien.DisplayMember = "Text";
            this.cbbTenNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbTenNhanVien.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbTenNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbTenNhanVien.FormattingEnabled = true;
            this.cbbTenNhanVien.ItemHeight = 16;
            this.cbbTenNhanVien.Location = new System.Drawing.Point(123, 6);
            this.cbbTenNhanVien.Name = "cbbTenNhanVien";
            this.cbbTenNhanVien.Size = new System.Drawing.Size(86, 22);
            this.cbbTenNhanVien.TabIndex = 15;
            // 
            // labelx
            // 
            this.labelx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelx.Location = new System.Drawing.Point(225, 6);
            this.labelx.Name = "labelx";
            this.labelx.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelx.Size = new System.Drawing.Size(94, 24);
            this.labelx.TabIndex = 4;
            this.labelx.Text = "Tên Tài Khản";
            // 
            // labelx12
            // 
            this.labelx12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelx12.Location = new System.Drawing.Point(225, 41);
            this.labelx12.Name = "labelx12";
            this.labelx12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelx12.Size = new System.Drawing.Size(94, 24);
            this.labelx12.TabIndex = 5;
            this.labelx12.Text = "Mật Khẩu";
            // 
            // txtTenTaiKhoan
            // 
            // 
            // 
            // 
            this.txtTenTaiKhoan.Border.Class = "TextBoxBorder";
            this.txtTenTaiKhoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTenTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenTaiKhoan.Location = new System.Drawing.Point(335, 6);
            this.txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            this.txtTenTaiKhoan.Size = new System.Drawing.Size(86, 22);
            this.txtTenTaiKhoan.TabIndex = 13;
            // 
            // txtMatKhau
            // 
            // 
            // 
            // 
            this.txtMatKhau.Border.Class = "TextBoxBorder";
            this.txtMatKhau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMatKhau.Location = new System.Drawing.Point(335, 41);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(86, 22);
            this.txtMatKhau.TabIndex = 14;
            // 
            // labelX2
            // 
            this.labelX2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelX2.Location = new System.Drawing.Point(13, 41);
            this.labelX2.Name = "labelX2";
            this.labelX2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX2.Size = new System.Drawing.Size(94, 24);
            this.labelX2.TabIndex = 16;
            this.labelX2.Text = "Hoạt Động";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.rdbCon, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.rdbNgung, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(123, 41);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(86, 24);
            this.tableLayoutPanel6.TabIndex = 11;
            // 
            // rdbCon
            // 
            this.rdbCon.AutoSize = true;
            this.rdbCon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdbCon.ForeColor = System.Drawing.Color.Navy;
            this.rdbCon.Location = new System.Drawing.Point(3, 3);
            this.rdbCon.Name = "rdbCon";
            this.rdbCon.Size = new System.Drawing.Size(37, 18);
            this.rdbCon.TabIndex = 17;
            this.rdbCon.TabStop = true;
            this.rdbCon.Text = "Còn";
            this.rdbCon.UseVisualStyleBackColor = true;
            // 
            // rdbNgung
            // 
            this.rdbNgung.AutoSize = true;
            this.rdbNgung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdbNgung.ForeColor = System.Drawing.Color.Navy;
            this.rdbNgung.Location = new System.Drawing.Point(46, 3);
            this.rdbNgung.Name = "rdbNgung";
            this.rdbNgung.Size = new System.Drawing.Size(37, 18);
            this.rdbNgung.TabIndex = 18;
            this.rdbNgung.TabStop = true;
            this.rdbNgung.Text = "Ngừng";
            this.rdbNgung.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel4, 2);
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 206F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel4.Controls.Add(this.labelX1, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblTongSoNguoiDung, 3, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(162, 402);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(590, 24);
            this.tableLayoutPanel4.TabIndex = 17;
            // 
            // labelX1
            // 
            this.labelX1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(302, 3);
            this.labelX1.Name = "labelX1";
            this.labelX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX1.Size = new System.Drawing.Size(200, 18);
            this.labelX1.TabIndex = 12;
            this.labelX1.Text = "Tổng Số Lượng Người Dùng";
            // 
            // lblTongSoNguoiDung
            // 
            this.lblTongSoNguoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTongSoNguoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTongSoNguoiDung.Location = new System.Drawing.Point(516, 3);
            this.lblTongSoNguoiDung.Name = "lblTongSoNguoiDung";
            this.lblTongSoNguoiDung.PaddingRight = 5;
            this.lblTongSoNguoiDung.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTongSoNguoiDung.Size = new System.Drawing.Size(54, 18);
            this.lblTongSoNguoiDung.TabIndex = 13;
            this.lblTongSoNguoiDung.Text = "0";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.ForeColor = System.Drawing.Color.Gray;
            this.txtTimKiem.Location = new System.Drawing.Point(611, 14);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(139, 22);
            this.txtTimKiem.TabIndex = 18;
            this.txtTimKiem.Text = "Nhập từ khóa cần tìm kiếm...";
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // frmQuanLyNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 483);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmQuanLyNguoiDung";
            this.Text = "Quản Lý Người Dùng";
            this.Load += new System.EventHandler(this.frmQuanLyNguoiDung_Load);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachNguoiDung)).EndInit();
            this.grbNguoiDung.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private GNHHControl.dataGridViewGNHH dtgvDanhSachNguoiDung;
        private DevComponents.DotNetBar.Controls.GroupPanel grbNguoiDung;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevComponents.DotNetBar.LabelX lblMaDocGia;
        private DevComponents.DotNetBar.LabelX labelx;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenTaiKhoan;
        private DevComponents.DotNetBar.LabelX labelx12;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMatKhau;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.RadioButton rdbCon;
        private System.Windows.Forms.RadioButton rdbNgung;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbbTenNhanVien;
        private DevComponents.DotNetBar.LabelX labelX2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX lblTongSoNguoiDung;
        private Controls.TextBoxTimKiem txtTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatKhau;
        private System.Windows.Forms.DataGridViewCheckBoxColumn HoatDong;


    }
}