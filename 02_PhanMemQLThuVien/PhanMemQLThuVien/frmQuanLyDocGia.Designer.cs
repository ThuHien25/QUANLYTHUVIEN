namespace PhanMemQLThuVien
{
    partial class frmQuanLyDocGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyDocGia));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.lblTongDocGia = new DevComponents.DotNetBar.LabelX();
            this.grbDocGia = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblMaDocGia = new DevComponents.DotNetBar.LabelX();
            this.lblHanThe = new DevComponents.DotNetBar.LabelX();
            this.lblHoVaTen = new DevComponents.DotNetBar.LabelX();
            this.lblLoaiDocGia = new DevComponents.DotNetBar.LabelX();
            this.txtMaDocGia = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtHoVaTen = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cbbLoaiDocGia = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblNgaySinh = new DevComponents.DotNetBar.LabelX();
            this.dTPngaySinh = new GNHHControl.dateTimePicker(this.components);
            this.lblNgayLapThe = new DevComponents.DotNetBar.LabelX();
            this.dTPngayLapThe = new GNHHControl.dateTimePicker(this.components);
            this.lblTienCoc = new DevComponents.DotNetBar.LabelX();
            this.btnThemLoaiDocGia = new DevComponents.DotNetBar.ButtonX();
            this.txtHanThe = new Controls.TextBoxHienThiSo(this.components);
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtEmail = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblEmail = new DevComponents.DotNetBar.LabelX();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgvQuanLyDocGia = new GNHHControl.dataGridViewGNHH(this.components);
            this.MaDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLapThe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HanThe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienCoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoSachDangMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTimKiem = new Controls.TextBoxTimKiem(this.components);
            this.txtTienCoc = new Controls.TextBoxTien(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.grbDocGia.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dTPngaySinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTPngayLapThe)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyDocGia)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.grbDocGia, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupPanel2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtTimKiem, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 42);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(921, 405);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel4, 3);
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 252F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel4.Controls.Add(this.labelX1, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblTongDocGia, 3, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(17, 363);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(882, 29);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // labelX1
            // 
            this.labelX1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelX1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX1.Location = new System.Drawing.Point(493, 3);
            this.labelX1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelX1.Name = "labelX1";
            this.labelX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX1.Size = new System.Drawing.Size(244, 23);
            this.labelX1.TabIndex = 12;
            this.labelX1.Text = "Tổng Số Lượng Độc Giả";
            // 
            // lblTongDocGia
            // 
            this.lblTongDocGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTongDocGia.Location = new System.Drawing.Point(754, 3);
            this.lblTongDocGia.Name = "lblTongDocGia";
            this.lblTongDocGia.PaddingRight = 5;
            this.lblTongDocGia.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTongDocGia.Size = new System.Drawing.Size(103, 23);
            this.lblTongDocGia.TabIndex = 13;
            this.lblTongDocGia.Text = "0";
            // 
            // grbDocGia
            // 
            this.grbDocGia.CanvasColor = System.Drawing.SystemColors.Control;
            this.grbDocGia.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.grbDocGia.Controls.Add(this.tableLayoutPanel2);
            this.grbDocGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbDocGia.Location = new System.Drawing.Point(195, 43);
            this.grbDocGia.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grbDocGia.Name = "grbDocGia";
            this.grbDocGia.Size = new System.Drawing.Size(526, 164);
            // 
            // 
            // 
            this.grbDocGia.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.grbDocGia.Style.BackColorGradientAngle = 90;
            this.grbDocGia.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.grbDocGia.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grbDocGia.Style.BorderBottomWidth = 1;
            this.grbDocGia.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.grbDocGia.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grbDocGia.Style.BorderLeftWidth = 1;
            this.grbDocGia.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grbDocGia.Style.BorderRightWidth = 1;
            this.grbDocGia.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grbDocGia.Style.BorderTopWidth = 1;
            this.grbDocGia.Style.CornerDiameter = 4;
            this.grbDocGia.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.grbDocGia.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.grbDocGia.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.grbDocGia.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.grbDocGia.TabIndex = 13;
            this.grbDocGia.Text = "Thông Tin Độc Giả";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel2.Controls.Add(this.lblMaDocGia, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblHanThe, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.lblHoVaTen, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblLoaiDocGia, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtMaDocGia, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtHoVaTen, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.cbbLoaiDocGia, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblNgaySinh, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.dTPngaySinh, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblNgayLapThe, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.dTPngayLapThe, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.lblTienCoc, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.btnThemLoaiDocGia, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtHanThe, 3, 4);
            this.tableLayoutPanel2.Controls.Add(this.labelX3, 4, 4);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.txtEmail, 3, 6);
            this.tableLayoutPanel2.Controls.Add(this.lblEmail, 2, 6);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(520, 141);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // lblMaDocGia
            // 
            this.lblMaDocGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMaDocGia.Location = new System.Drawing.Point(4, 3);
            this.lblMaDocGia.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblMaDocGia.Name = "lblMaDocGia";
            this.lblMaDocGia.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMaDocGia.Size = new System.Drawing.Size(92, 24);
            this.lblMaDocGia.TabIndex = 0;
            this.lblMaDocGia.Text = "Mã Độc giả";
            // 
            // lblHanThe
            // 
            this.lblHanThe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHanThe.Location = new System.Drawing.Point(243, 73);
            this.lblHanThe.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblHanThe.Name = "lblHanThe";
            this.lblHanThe.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblHanThe.Size = new System.Drawing.Size(92, 24);
            this.lblHanThe.TabIndex = 11;
            this.lblHanThe.Text = "Hạn Thẻ";
            // 
            // lblHoVaTen
            // 
            this.lblHoVaTen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHoVaTen.Location = new System.Drawing.Point(4, 38);
            this.lblHoVaTen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblHoVaTen.Name = "lblHoVaTen";
            this.lblHoVaTen.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblHoVaTen.Size = new System.Drawing.Size(92, 29);
            this.lblHoVaTen.TabIndex = 4;
            this.lblHoVaTen.Text = "Họ và Tên";
            // 
            // lblLoaiDocGia
            // 
            this.lblLoaiDocGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLoaiDocGia.Location = new System.Drawing.Point(243, 3);
            this.lblLoaiDocGia.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblLoaiDocGia.Name = "lblLoaiDocGia";
            this.lblLoaiDocGia.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblLoaiDocGia.Size = new System.Drawing.Size(92, 24);
            this.lblLoaiDocGia.TabIndex = 8;
            this.lblLoaiDocGia.Text = "Loại Độc giả";
            // 
            // txtMaDocGia
            // 
            // 
            // 
            // 
            this.txtMaDocGia.Border.Class = "TextBoxBorder";
            this.txtMaDocGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMaDocGia.Enabled = false;
            this.txtMaDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaDocGia.Location = new System.Drawing.Point(104, 3);
            this.txtMaDocGia.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMaDocGia.Name = "txtMaDocGia";
            this.txtMaDocGia.Size = new System.Drawing.Size(131, 22);
            this.txtMaDocGia.TabIndex = 12;
            // 
            // txtHoVaTen
            // 
            // 
            // 
            // 
            this.txtHoVaTen.Border.Class = "TextBoxBorder";
            this.txtHoVaTen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHoVaTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtHoVaTen.Location = new System.Drawing.Point(104, 38);
            this.txtHoVaTen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtHoVaTen.Name = "txtHoVaTen";
            this.txtHoVaTen.Size = new System.Drawing.Size(131, 22);
            this.txtHoVaTen.TabIndex = 13;
            // 
            // cbbLoaiDocGia
            // 
            this.cbbLoaiDocGia.DisplayMember = "Text";
            this.cbbLoaiDocGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbLoaiDocGia.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbLoaiDocGia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLoaiDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbLoaiDocGia.FormattingEnabled = true;
            this.cbbLoaiDocGia.ItemHeight = 16;
            this.cbbLoaiDocGia.Location = new System.Drawing.Point(343, 3);
            this.cbbLoaiDocGia.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbbLoaiDocGia.Name = "cbbLoaiDocGia";
            this.cbbLoaiDocGia.Size = new System.Drawing.Size(131, 22);
            this.cbbLoaiDocGia.TabIndex = 16;
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNgaySinh.Location = new System.Drawing.Point(243, 38);
            this.lblNgaySinh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblNgaySinh.Size = new System.Drawing.Size(92, 29);
            this.lblNgaySinh.TabIndex = 6;
            this.lblNgaySinh.Text = "Ngày Sinh";
            // 
            // dTPngaySinh
            // 
            // 
            // 
            // 
            this.dTPngaySinh.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dTPngaySinh.ButtonDropDown.Visible = true;
            this.dTPngaySinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dTPngaySinh.Enabled = false;
            this.dTPngaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dTPngaySinh.Location = new System.Drawing.Point(343, 38);
            this.dTPngaySinh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            // 
            // 
            // 
            this.dTPngaySinh.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dTPngaySinh.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dTPngaySinh.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dTPngaySinh.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dTPngaySinh.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dTPngaySinh.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dTPngaySinh.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dTPngaySinh.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dTPngaySinh.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dTPngaySinh.MonthCalendar.DisplayMonth = new System.DateTime(2016, 10, 1, 0, 0, 0, 0);
            this.dTPngaySinh.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.dTPngaySinh.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dTPngaySinh.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dTPngaySinh.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dTPngaySinh.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dTPngaySinh.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dTPngaySinh.MonthCalendar.TodayButtonVisible = true;
            this.dTPngaySinh.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dTPngaySinh.Name = "dTPngaySinh";
            this.dTPngaySinh.Size = new System.Drawing.Size(131, 22);
            this.dTPngaySinh.TabIndex = 17;
            this.dTPngaySinh.Value = new System.DateTime(2016, 10, 16, 13, 52, 40, 793);
            // 
            // lblNgayLapThe
            // 
            this.lblNgayLapThe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNgayLapThe.Location = new System.Drawing.Point(4, 73);
            this.lblNgayLapThe.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblNgayLapThe.Name = "lblNgayLapThe";
            this.lblNgayLapThe.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblNgayLapThe.Size = new System.Drawing.Size(92, 24);
            this.lblNgayLapThe.TabIndex = 7;
            this.lblNgayLapThe.Text = "Ngày Lập Thẻ";
            // 
            // dTPngayLapThe
            // 
            // 
            // 
            // 
            this.dTPngayLapThe.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dTPngayLapThe.ButtonDropDown.Visible = true;
            this.dTPngayLapThe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dTPngayLapThe.Enabled = false;
            this.dTPngayLapThe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dTPngayLapThe.Location = new System.Drawing.Point(104, 73);
            this.dTPngayLapThe.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            // 
            // 
            // 
            this.dTPngayLapThe.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dTPngayLapThe.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dTPngayLapThe.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dTPngayLapThe.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dTPngayLapThe.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dTPngayLapThe.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dTPngayLapThe.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dTPngayLapThe.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dTPngayLapThe.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dTPngayLapThe.MonthCalendar.DisplayMonth = new System.DateTime(2016, 10, 1, 0, 0, 0, 0);
            this.dTPngayLapThe.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.dTPngayLapThe.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dTPngayLapThe.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dTPngayLapThe.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dTPngayLapThe.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dTPngayLapThe.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dTPngayLapThe.MonthCalendar.TodayButtonVisible = true;
            this.dTPngayLapThe.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dTPngayLapThe.Name = "dTPngayLapThe";
            this.dTPngayLapThe.Size = new System.Drawing.Size(131, 22);
            this.dTPngayLapThe.TabIndex = 14;
            this.dTPngayLapThe.Value = new System.DateTime(2016, 10, 16, 13, 52, 57, 709);
            // 
            // lblTienCoc
            // 
            this.lblTienCoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTienCoc.Location = new System.Drawing.Point(4, 108);
            this.lblTienCoc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblTienCoc.Name = "lblTienCoc";
            this.lblTienCoc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTienCoc.Size = new System.Drawing.Size(92, 29);
            this.lblTienCoc.TabIndex = 10;
            this.lblTienCoc.Text = "Tiền Cọc";
            // 
            // btnThemLoaiDocGia
            // 
            this.btnThemLoaiDocGia.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThemLoaiDocGia.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThemLoaiDocGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThemLoaiDocGia.Image = ((System.Drawing.Image)(resources.GetObject("btnThemLoaiDocGia.Image")));
            this.btnThemLoaiDocGia.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnThemLoaiDocGia.Location = new System.Drawing.Point(482, 3);
            this.btnThemLoaiDocGia.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnThemLoaiDocGia.Name = "btnThemLoaiDocGia";
            this.btnThemLoaiDocGia.Size = new System.Drawing.Size(34, 24);
            this.btnThemLoaiDocGia.TabIndex = 22;
            this.btnThemLoaiDocGia.Click += new System.EventHandler(this.btnThemLoaiDocGia_Click);
            // 
            // txtHanThe
            // 
            this.txtHanThe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHanThe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtHanThe.Location = new System.Drawing.Point(342, 73);
            this.txtHanThe.Name = "txtHanThe";
            this.txtHanThe.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtHanThe.Size = new System.Drawing.Size(133, 22);
            this.txtHanThe.TabIndex = 18;
            this.txtHanThe.Text = "0";
            this.txtHanThe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelX3
            // 
            this.labelX3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelX3.Location = new System.Drawing.Point(481, 73);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(36, 24);
            this.labelX3.TabIndex = 26;
            this.labelX3.Text = "Năm";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.Controls.Add(this.labelX2, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtTienCoc, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(103, 108);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(133, 29);
            this.tableLayoutPanel3.TabIndex = 27;
            // 
            // labelX2
            // 
            this.labelX2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelX2.Location = new System.Drawing.Point(101, 3);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(29, 23);
            this.labelX2.TabIndex = 18;
            this.labelX2.Text = "VNĐ";
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.Border.Class = "TextBoxBorder";
            this.txtEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtEmail.ForeColor = System.Drawing.Color.Silver;
            this.txtEmail.Location = new System.Drawing.Point(343, 108);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtEmail.Size = new System.Drawing.Size(131, 22);
            this.txtEmail.TabIndex = 19;
            // 
            // lblEmail
            // 
            this.lblEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEmail.Location = new System.Drawing.Point(243, 108);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblEmail.Size = new System.Drawing.Size(92, 29);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email";
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.tableLayoutPanel1.SetColumnSpan(this.groupPanel2, 3);
            this.groupPanel2.Controls.Add(this.dgvQuanLyDocGia);
            this.groupPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel2.Location = new System.Drawing.Point(17, 213);
            this.groupPanel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(882, 144);
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
            this.groupPanel2.TabIndex = 14;
            this.groupPanel2.Text = "Danh Sách Độc Giả";
            // 
            // dgvQuanLyDocGia
            // 
            this.dgvQuanLyDocGia.AllowUserToAddRows = false;
            this.dgvQuanLyDocGia.AllowUserToDeleteRows = false;
            this.dgvQuanLyDocGia.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvQuanLyDocGia.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQuanLyDocGia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvQuanLyDocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanLyDocGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDocGia,
            this.TenDocGia,
            this.LoaiDocGia,
            this.NgaySinh,
            this.Email,
            this.NgayLapThe,
            this.HanThe,
            this.TienCoc,
            this.SoSachDangMuon});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvQuanLyDocGia.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvQuanLyDocGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvQuanLyDocGia.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvQuanLyDocGia.Location = new System.Drawing.Point(0, 0);
            this.dgvQuanLyDocGia.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvQuanLyDocGia.Name = "dgvQuanLyDocGia";
            this.dgvQuanLyDocGia.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvQuanLyDocGia.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvQuanLyDocGia.RowHeadersWidth = 60;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dgvQuanLyDocGia.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvQuanLyDocGia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQuanLyDocGia.Size = new System.Drawing.Size(876, 121);
            this.dgvQuanLyDocGia.TabIndex = 3;
            this.dgvQuanLyDocGia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuanLyDocGia_CellClick);
            // 
            // MaDocGia
            // 
            this.MaDocGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaDocGia.DataPropertyName = "MaDocGia";
            this.MaDocGia.HeaderText = "Mã Độc Giả";
            this.MaDocGia.Name = "MaDocGia";
            this.MaDocGia.ReadOnly = true;
            // 
            // TenDocGia
            // 
            this.TenDocGia.DataPropertyName = "TenDocGia";
            this.TenDocGia.HeaderText = "Tên Độc Giả";
            this.TenDocGia.Name = "TenDocGia";
            this.TenDocGia.ReadOnly = true;
            this.TenDocGia.Width = 200;
            // 
            // LoaiDocGia
            // 
            this.LoaiDocGia.DataPropertyName = "tenloaiDG";
            this.LoaiDocGia.HeaderText = "Loại Độc Giả";
            this.LoaiDocGia.Name = "LoaiDocGia";
            this.LoaiDocGia.ReadOnly = true;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "ngaysinh";
            dataGridViewCellStyle3.Format = "dd/MM/yyyy";
            this.NgaySinh.DefaultCellStyle = dataGridViewCellStyle3;
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 250;
            // 
            // NgayLapThe
            // 
            this.NgayLapThe.DataPropertyName = "ngaydangky";
            dataGridViewCellStyle4.Format = "dd/MM/yyyy";
            this.NgayLapThe.DefaultCellStyle = dataGridViewCellStyle4;
            this.NgayLapThe.HeaderText = "Ngày Lập Thẻ";
            this.NgayLapThe.Name = "NgayLapThe";
            this.NgayLapThe.ReadOnly = true;
            // 
            // HanThe
            // 
            this.HanThe.DataPropertyName = "hanthe";
            this.HanThe.HeaderText = "Hạn Thẻ";
            this.HanThe.Name = "HanThe";
            this.HanThe.ReadOnly = true;
            // 
            // TienCoc
            // 
            this.TienCoc.DataPropertyName = "tiencoc";
            dataGridViewCellStyle5.Format = "#,#0";
            this.TienCoc.DefaultCellStyle = dataGridViewCellStyle5;
            this.TienCoc.HeaderText = "Tiền Cọc";
            this.TienCoc.Name = "TienCoc";
            this.TienCoc.ReadOnly = true;
            // 
            // SoSachDangMuon
            // 
            this.SoSachDangMuon.DataPropertyName = "SoSachDangMuon";
            this.SoSachDangMuon.HeaderText = "Số Sách Đang Mượn";
            this.SoSachDangMuon.Name = "SoSachDangMuon";
            this.SoSachDangMuon.ReadOnly = true;
            this.SoSachDangMuon.Width = 150;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.ForeColor = System.Drawing.Color.Gray;
            this.txtTimKiem.Location = new System.Drawing.Point(728, 13);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(172, 22);
            this.txtTimKiem.TabIndex = 20;
            this.txtTimKiem.Text = "Nhập từ khóa cần tìm kiếm...";
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // txtTienCoc
            // 
            this.txtTienCoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTienCoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTienCoc.Location = new System.Drawing.Point(3, 3);
            this.txtTienCoc.Name = "txtTienCoc";
            this.txtTienCoc.Size = new System.Drawing.Size(92, 22);
            this.txtTienCoc.TabIndex = 19;
            this.txtTienCoc.Text = "0";
            this.txtTienCoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmQuanLyDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 449);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmQuanLyDocGia";
            this.Text = "Quản Lý Độc Giả";
            this.Load += new System.EventHandler(this.frmQuanLyDocGia_Load);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.grbDocGia.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dTPngaySinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTPngayLapThe)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.groupPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyDocGia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.GroupPanel grbDocGia;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevComponents.DotNetBar.LabelX lblMaDocGia;
        private DevComponents.DotNetBar.LabelX lblHanThe;
        private DevComponents.DotNetBar.LabelX lblHoVaTen;
        private DevComponents.DotNetBar.LabelX lblEmail;
        private DevComponents.DotNetBar.LabelX lblLoaiDocGia;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaDocGia;
        private DevComponents.DotNetBar.Controls.TextBoxX txtHoVaTen;
        private DevComponents.DotNetBar.Controls.TextBoxX txtEmail;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbbLoaiDocGia;
        private DevComponents.DotNetBar.LabelX lblNgaySinh;
        private GNHHControl.dateTimePicker dTPngaySinh;
        private DevComponents.DotNetBar.LabelX lblNgayLapThe;
        private GNHHControl.dateTimePicker dTPngayLapThe;
        private DevComponents.DotNetBar.LabelX lblTienCoc;
        private DevComponents.DotNetBar.ButtonX btnThemLoaiDocGia;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private GNHHControl.dataGridViewGNHH dgvQuanLyDocGia;
        private Controls.TextBoxTimKiem txtTimKiem;
        private Controls.TextBoxHienThiSo txtHanThe;
        private DevComponents.DotNetBar.LabelX labelX3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLapThe;
        private System.Windows.Forms.DataGridViewTextBoxColumn HanThe;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienCoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoSachDangMuon;
        private DevComponents.DotNetBar.LabelX lblTongDocGia;
        private Controls.TextBoxTien txtTienCoc;

    }
}