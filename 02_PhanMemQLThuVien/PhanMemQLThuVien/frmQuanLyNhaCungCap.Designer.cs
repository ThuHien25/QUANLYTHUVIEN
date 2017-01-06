namespace PhanMemQLThuVien
{
    partial class frmQuanLyNhaCungCap
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
            this.txtTimKiem = new Controls.TextBoxTimKiem(this.components);
            this.grbTTNCC = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblMaDocGia = new DevComponents.DotNetBar.LabelX();
            this.lblHoVaTen = new DevComponents.DotNetBar.LabelX();
            this.txtMaNhaCungCap = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtTenNhaCungCap = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblEmail = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtSoDienThoaiNCC = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDiaChiNCC = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgvQuanLyNhaCungCap = new GNHHControl.dataGridViewGNHH(this.components);
            this.MaNhaCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhaCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.labelTongSLNCC = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.tableLayoutPanel1.SuspendLayout();
            this.grbTTNCC.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyNhaCungCap)).BeginInit();
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel1.Controls.Add(this.txtTimKiem, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.grbTTNCC, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupPanel2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 2, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 42);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(973, 379);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.ForeColor = System.Drawing.Color.Gray;
            this.txtTimKiem.Location = new System.Drawing.Point(774, 14);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(182, 22);
            this.txtTimKiem.TabIndex = 4;
            this.txtTimKiem.Text = "Nhập từ khóa cần tìm kiếm...";
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // grbTTNCC
            // 
            this.grbTTNCC.CanvasColor = System.Drawing.SystemColors.Control;
            this.grbTTNCC.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.grbTTNCC.Controls.Add(this.tableLayoutPanel2);
            this.grbTTNCC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbTTNCC.Location = new System.Drawing.Point(204, 42);
            this.grbTTNCC.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.grbTTNCC.Name = "grbTTNCC";
            this.grbTTNCC.Size = new System.Drawing.Size(562, 96);
            // 
            // 
            // 
            this.grbTTNCC.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.grbTTNCC.Style.BackColorGradientAngle = 90;
            this.grbTTNCC.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.grbTTNCC.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grbTTNCC.Style.BorderBottomWidth = 1;
            this.grbTTNCC.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.grbTTNCC.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grbTTNCC.Style.BorderLeftWidth = 1;
            this.grbTTNCC.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grbTTNCC.Style.BorderRightWidth = 1;
            this.grbTTNCC.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grbTTNCC.Style.BorderTopWidth = 1;
            this.grbTTNCC.Style.CornerDiameter = 4;
            this.grbTTNCC.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.grbTTNCC.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.grbTTNCC.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.grbTTNCC.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.grbTTNCC.TabIndex = 6;
            this.grbTTNCC.Text = "Thông Tin Nhà Cung Cấp";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.lblMaDocGia, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblHoVaTen, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtMaNhaCungCap, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtTenNhaCungCap, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblEmail, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelX2, 4, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtSoDienThoaiNCC, 6, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtDiaChiNCC, 6, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(556, 73);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // lblMaDocGia
            // 
            this.lblMaDocGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMaDocGia.Location = new System.Drawing.Point(4, 6);
            this.lblMaDocGia.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.lblMaDocGia.Name = "lblMaDocGia";
            this.lblMaDocGia.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMaDocGia.Size = new System.Drawing.Size(122, 26);
            this.lblMaDocGia.TabIndex = 0;
            this.lblMaDocGia.Text = "Mã Nhà Cung Cấp";
            // 
            // lblHoVaTen
            // 
            this.lblHoVaTen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHoVaTen.Location = new System.Drawing.Point(4, 41);
            this.lblHoVaTen.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.lblHoVaTen.Name = "lblHoVaTen";
            this.lblHoVaTen.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblHoVaTen.Size = new System.Drawing.Size(122, 26);
            this.lblHoVaTen.TabIndex = 4;
            this.lblHoVaTen.Text = "Tên Nhà Cung Cấp";
            // 
            // txtMaNhaCungCap
            // 
            // 
            // 
            // 
            this.txtMaNhaCungCap.Border.Class = "TextBoxBorder";
            this.txtMaNhaCungCap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMaNhaCungCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaNhaCungCap.Location = new System.Drawing.Point(144, 6);
            this.txtMaNhaCungCap.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtMaNhaCungCap.Name = "txtMaNhaCungCap";
            this.txtMaNhaCungCap.Size = new System.Drawing.Size(140, 22);
            this.txtMaNhaCungCap.TabIndex = 12;
            // 
            // txtTenNhaCungCap
            // 
            // 
            // 
            // 
            this.txtTenNhaCungCap.Border.Class = "TextBoxBorder";
            this.txtTenNhaCungCap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTenNhaCungCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenNhaCungCap.Location = new System.Drawing.Point(144, 41);
            this.txtTenNhaCungCap.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtTenNhaCungCap.Name = "txtTenNhaCungCap";
            this.txtTenNhaCungCap.Size = new System.Drawing.Size(140, 22);
            this.txtTenNhaCungCap.TabIndex = 13;
            // 
            // lblEmail
            // 
            this.lblEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEmail.Location = new System.Drawing.Point(302, 6);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblEmail.Size = new System.Drawing.Size(92, 26);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Số Điện Thoại";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            this.labelX2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelX2.Location = new System.Drawing.Point(302, 41);
            this.labelX2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelX2.Name = "labelX2";
            this.labelX2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX2.Size = new System.Drawing.Size(92, 26);
            this.labelX2.TabIndex = 26;
            this.labelX2.Text = "Địa Chỉ";
            // 
            // txtSoDienThoaiNCC
            // 
            // 
            // 
            // 
            this.txtSoDienThoaiNCC.Border.Class = "TextBoxBorder";
            this.txtSoDienThoaiNCC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSoDienThoaiNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSoDienThoaiNCC.Location = new System.Drawing.Point(412, 6);
            this.txtSoDienThoaiNCC.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtSoDienThoaiNCC.Name = "txtSoDienThoaiNCC";
            this.txtSoDienThoaiNCC.Size = new System.Drawing.Size(140, 22);
            this.txtSoDienThoaiNCC.TabIndex = 14;
            // 
            // txtDiaChiNCC
            // 
            // 
            // 
            // 
            this.txtDiaChiNCC.Border.Class = "TextBoxBorder";
            this.txtDiaChiNCC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDiaChiNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDiaChiNCC.Location = new System.Drawing.Point(412, 41);
            this.txtDiaChiNCC.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtDiaChiNCC.Name = "txtDiaChiNCC";
            this.txtDiaChiNCC.Size = new System.Drawing.Size(140, 22);
            this.txtDiaChiNCC.TabIndex = 27;
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.tableLayoutPanel1.SetColumnSpan(this.groupPanel2, 3);
            this.groupPanel2.Controls.Add(this.dgvQuanLyNhaCungCap);
            this.groupPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel2.Location = new System.Drawing.Point(14, 142);
            this.groupPanel2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(942, 195);
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
            this.groupPanel2.TabIndex = 7;
            this.groupPanel2.Text = "Danh Sách Nhà Cung Cấp";
            // 
            // dgvQuanLyNhaCungCap
            // 
            this.dgvQuanLyNhaCungCap.AllowUserToAddRows = false;
            this.dgvQuanLyNhaCungCap.AllowUserToDeleteRows = false;
            this.dgvQuanLyNhaCungCap.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvQuanLyNhaCungCap.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQuanLyNhaCungCap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvQuanLyNhaCungCap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanLyNhaCungCap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNhaCungCap,
            this.TenNhaCungCap,
            this.SoDienThoai,
            this.DiaChi});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvQuanLyNhaCungCap.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvQuanLyNhaCungCap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvQuanLyNhaCungCap.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvQuanLyNhaCungCap.Location = new System.Drawing.Point(0, 0);
            this.dgvQuanLyNhaCungCap.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dgvQuanLyNhaCungCap.Name = "dgvQuanLyNhaCungCap";
            this.dgvQuanLyNhaCungCap.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvQuanLyNhaCungCap.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvQuanLyNhaCungCap.RowHeadersWidth = 60;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dgvQuanLyNhaCungCap.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvQuanLyNhaCungCap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQuanLyNhaCungCap.Size = new System.Drawing.Size(936, 172);
            this.dgvQuanLyNhaCungCap.TabIndex = 4;
            this.dgvQuanLyNhaCungCap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuanLyNhaCungCap_CellClick);
            // 
            // MaNhaCungCap
            // 
            this.MaNhaCungCap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaNhaCungCap.DataPropertyName = "mancc";
            this.MaNhaCungCap.HeaderText = "Mã Nhà Cung Cấp";
            this.MaNhaCungCap.Name = "MaNhaCungCap";
            this.MaNhaCungCap.ReadOnly = true;
            // 
            // TenNhaCungCap
            // 
            this.TenNhaCungCap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenNhaCungCap.DataPropertyName = "tenncc";
            this.TenNhaCungCap.HeaderText = "Tên Nhà Cung Cấp";
            this.TenNhaCungCap.Name = "TenNhaCungCap";
            this.TenNhaCungCap.ReadOnly = true;
            // 
            // SoDienThoai
            // 
            this.SoDienThoai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoDienThoai.DataPropertyName = "sdt";
            this.SoDienThoai.HeaderText = "Số Điện Thoại";
            this.SoDienThoai.Name = "SoDienThoai";
            this.SoDienThoai.ReadOnly = true;
            // 
            // DiaChi
            // 
            this.DiaChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DiaChi.DataPropertyName = "diachincc";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(4, 4);
            this.tableLayoutPanel3.TabIndex = 8;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel4, 2);
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel4.Controls.Add(this.labelTongSLNCC, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.labelX3, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(203, 342);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(754, 24);
            this.tableLayoutPanel4.TabIndex = 9;
            // 
            // labelTongSLNCC
            // 
            this.labelTongSLNCC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTongSLNCC.Location = new System.Drawing.Point(677, 3);
            this.labelTongSLNCC.Name = "labelTongSLNCC";
            this.labelTongSLNCC.Size = new System.Drawing.Size(74, 18);
            this.labelTongSLNCC.TabIndex = 0;
            this.labelTongSLNCC.Text = "0";
            // 
            // labelX3
            // 
            this.labelX3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelX3.Location = new System.Drawing.Point(477, 3);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(194, 18);
            this.labelX3.TabIndex = 1;
            this.labelX3.Text = "Tổng số nhà cung cấp ";
            // 
            // frmQuanLyNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 423);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmQuanLyNhaCungCap";
            this.Text = "Quản Lý Nhà Cung Cấp";
            this.Load += new System.EventHandler(this.frmQuanLyNhaCungCap_Load);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.grbTTNCC.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyNhaCungCap)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevComponents.DotNetBar.Controls.GroupPanel grbTTNCC;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevComponents.DotNetBar.LabelX lblMaDocGia;
        private DevComponents.DotNetBar.LabelX lblHoVaTen;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaNhaCungCap;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenNhaCungCap;
        private DevComponents.DotNetBar.LabelX lblEmail;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSoDienThoaiNCC;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDiaChiNCC;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private GNHHControl.dataGridViewGNHH dgvQuanLyNhaCungCap;
        private Controls.TextBoxTimKiem txtTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private DevComponents.DotNetBar.LabelX labelTongSLNCC;
        private DevComponents.DotNetBar.LabelX labelX3;


    }
}