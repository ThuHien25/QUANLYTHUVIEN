namespace PhanMemQLThuVien
{
    partial class frmQuanLyNhanVien
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
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.lblTongNhanVien = new DevComponents.DotNetBar.LabelX();
            this.grbNhanVien = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblMaDocGia = new DevComponents.DotNetBar.LabelX();
            this.lblHoVaTen = new DevComponents.DotNetBar.LabelX();
            this.txtMaNhanVien = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtTenNhanVien = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblNgaySinh = new DevComponents.DotNetBar.LabelX();
            this.txtChucVuNV = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblEmail = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtDiaChiNhanVien = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtEmail = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtSoDienThoaiNV = new ThuVien.Txt_SoDienThoai_11So(this.components);
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgvQuanLyNhanVien = new GNHHControl.dataGridViewGNHH(this.components);
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT_NV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email_NV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTimKiem = new Controls.TextBoxTimKiem(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.grbNhanVien.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyNhanVien)).BeginInit();
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
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.grbNhanVien, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupPanel2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtTimKiem, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 42);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(808, 445);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel4, 2);
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 183F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel4.Controls.Add(this.labelX1, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblTongNhanVien, 3, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(170, 408);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(622, 24);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // labelX1
            // 
            this.labelX1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelX1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX1.Location = new System.Drawing.Point(360, 3);
            this.labelX1.Name = "labelX1";
            this.labelX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX1.Size = new System.Drawing.Size(177, 18);
            this.labelX1.TabIndex = 12;
            this.labelX1.Text = "Tổng Số Lượng Nhân Viên";
            // 
            // lblTongNhanVien
            // 
            this.lblTongNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTongNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongNhanVien.Location = new System.Drawing.Point(551, 3);
            this.lblTongNhanVien.Name = "lblTongNhanVien";
            this.lblTongNhanVien.PaddingRight = 5;
            this.lblTongNhanVien.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTongNhanVien.Size = new System.Drawing.Size(51, 18);
            this.lblTongNhanVien.TabIndex = 15;
            this.lblTongNhanVien.Text = "0";
            // 
            // grbNhanVien
            // 
            this.grbNhanVien.CanvasColor = System.Drawing.SystemColors.Control;
            this.grbNhanVien.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.grbNhanVien.Controls.Add(this.tableLayoutPanel2);
            this.grbNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbNhanVien.Location = new System.Drawing.Point(170, 43);
            this.grbNhanVien.Name = "grbNhanVien";
            this.grbNhanVien.Size = new System.Drawing.Size(465, 119);
            // 
            // 
            // 
            this.grbNhanVien.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.grbNhanVien.Style.BackColorGradientAngle = 90;
            this.grbNhanVien.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.grbNhanVien.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grbNhanVien.Style.BorderBottomWidth = 1;
            this.grbNhanVien.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.grbNhanVien.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grbNhanVien.Style.BorderLeftWidth = 1;
            this.grbNhanVien.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grbNhanVien.Style.BorderRightWidth = 1;
            this.grbNhanVien.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grbNhanVien.Style.BorderTopWidth = 1;
            this.grbNhanVien.Style.CornerDiameter = 4;
            this.grbNhanVien.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.grbNhanVien.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.grbNhanVien.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.grbNhanVien.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.grbNhanVien.TabIndex = 12;
            this.grbNhanVien.Text = "Thông Tin Nhân Viên";
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
            this.tableLayoutPanel2.Controls.Add(this.lblHoVaTen, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtMaNhanVien, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtTenNhanVien, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblNgaySinh, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtChucVuNV, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblEmail, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelX2, 5, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtDiaChiNhanVien, 7, 2);
            this.tableLayoutPanel2.Controls.Add(this.labelX3, 5, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtEmail, 7, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtSoDienThoaiNV, 7, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(459, 96);
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
            this.lblMaDocGia.Text = "Mã Nhân Viên";
            // 
            // lblHoVaTen
            // 
            this.lblHoVaTen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHoVaTen.Location = new System.Drawing.Point(13, 36);
            this.lblHoVaTen.Name = "lblHoVaTen";
            this.lblHoVaTen.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblHoVaTen.Size = new System.Drawing.Size(94, 24);
            this.lblHoVaTen.TabIndex = 4;
            this.lblHoVaTen.Text = "Tên Nhân Viên";
            // 
            // txtMaNhanVien
            // 
            // 
            // 
            // 
            this.txtMaNhanVien.Border.Class = "TextBoxBorder";
            this.txtMaNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMaNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaNhanVien.Location = new System.Drawing.Point(123, 6);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(98, 22);
            this.txtMaNhanVien.TabIndex = 12;
            // 
            // txtTenNhanVien
            // 
            // 
            // 
            // 
            this.txtTenNhanVien.Border.Class = "TextBoxBorder";
            this.txtTenNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTenNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenNhanVien.Location = new System.Drawing.Point(123, 36);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(98, 22);
            this.txtTenNhanVien.TabIndex = 13;
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNgaySinh.Location = new System.Drawing.Point(13, 66);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblNgaySinh.Size = new System.Drawing.Size(94, 24);
            this.lblNgaySinh.TabIndex = 6;
            this.lblNgaySinh.Text = "Chức Vụ";
            // 
            // txtChucVuNV
            // 
            // 
            // 
            // 
            this.txtChucVuNV.Border.Class = "TextBoxBorder";
            this.txtChucVuNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtChucVuNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtChucVuNV.Location = new System.Drawing.Point(123, 66);
            this.txtChucVuNV.Name = "txtChucVuNV";
            this.txtChucVuNV.Size = new System.Drawing.Size(98, 22);
            this.txtChucVuNV.TabIndex = 25;
            // 
            // lblEmail
            // 
            this.lblEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEmail.Location = new System.Drawing.Point(237, 6);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblEmail.Size = new System.Drawing.Size(94, 24);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Số Điện Thoại";
            // 
            // labelX2
            // 
            this.labelX2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelX2.Location = new System.Drawing.Point(237, 36);
            this.labelX2.Name = "labelX2";
            this.labelX2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX2.Size = new System.Drawing.Size(94, 24);
            this.labelX2.TabIndex = 26;
            this.labelX2.Text = "Địa Chỉ";
            // 
            // txtDiaChiNhanVien
            // 
            // 
            // 
            // 
            this.txtDiaChiNhanVien.Border.Class = "TextBoxBorder";
            this.txtDiaChiNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDiaChiNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDiaChiNhanVien.Location = new System.Drawing.Point(347, 36);
            this.txtDiaChiNhanVien.Name = "txtDiaChiNhanVien";
            this.txtDiaChiNhanVien.Size = new System.Drawing.Size(98, 22);
            this.txtDiaChiNhanVien.TabIndex = 27;
            // 
            // labelX3
            // 
            this.labelX3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelX3.Location = new System.Drawing.Point(237, 66);
            this.labelX3.Name = "labelX3";
            this.labelX3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX3.Size = new System.Drawing.Size(94, 24);
            this.labelX3.TabIndex = 28;
            this.labelX3.Text = "Email";
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.Border.Class = "TextBoxBorder";
            this.txtEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtEmail.Location = new System.Drawing.Point(347, 66);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(98, 22);
            this.txtEmail.TabIndex = 29;
            // 
            // txtSoDienThoaiNV
            // 
            this.txtSoDienThoaiNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSoDienThoaiNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSoDienThoaiNV.Location = new System.Drawing.Point(347, 6);
            this.txtSoDienThoaiNV.Name = "txtSoDienThoaiNV";
            this.txtSoDienThoaiNV.Size = new System.Drawing.Size(98, 22);
            this.txtSoDienThoaiNV.TabIndex = 30;
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.tableLayoutPanel1.SetColumnSpan(this.groupPanel2, 3);
            this.groupPanel2.Controls.Add(this.dgvQuanLyNhanVien);
            this.groupPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel2.Location = new System.Drawing.Point(13, 168);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(779, 234);
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
            this.groupPanel2.TabIndex = 13;
            this.groupPanel2.Text = "Danh Sách Nhân Viên";
            // 
            // dgvQuanLyNhanVien
            // 
            this.dgvQuanLyNhanVien.AllowUserToAddRows = false;
            this.dgvQuanLyNhanVien.AllowUserToDeleteRows = false;
            this.dgvQuanLyNhanVien.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvQuanLyNhanVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQuanLyNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvQuanLyNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanLyNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.TenNV,
            this.ChucVu,
            this.SDT_NV,
            this.DiaChi,
            this.Email_NV});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvQuanLyNhanVien.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvQuanLyNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvQuanLyNhanVien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvQuanLyNhanVien.Location = new System.Drawing.Point(0, 0);
            this.dgvQuanLyNhanVien.Name = "dgvQuanLyNhanVien";
            this.dgvQuanLyNhanVien.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvQuanLyNhanVien.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvQuanLyNhanVien.RowHeadersWidth = 60;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dgvQuanLyNhanVien.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvQuanLyNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQuanLyNhanVien.Size = new System.Drawing.Size(773, 211);
            this.dgvQuanLyNhanVien.TabIndex = 4;
            this.dgvQuanLyNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuanLyNhanVien_CellClick);
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
            // ChucVu
            // 
            this.ChucVu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ChucVu.DataPropertyName = "chucvu";
            this.ChucVu.HeaderText = "Chức Vụ";
            this.ChucVu.Name = "ChucVu";
            this.ChucVu.ReadOnly = true;
            // 
            // SDT_NV
            // 
            this.SDT_NV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SDT_NV.DataPropertyName = "sdt_nv";
            this.SDT_NV.HeaderText = "Số Điện Thoại";
            this.SDT_NV.Name = "SDT_NV";
            this.SDT_NV.ReadOnly = true;
            // 
            // DiaChi
            // 
            this.DiaChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DiaChi.DataPropertyName = "diachi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            // 
            // Email_NV
            // 
            this.Email_NV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Email_NV.DataPropertyName = "email_nv";
            this.Email_NV.HeaderText = "Email";
            this.Email_NV.Name = "Email_NV";
            this.Email_NV.ReadOnly = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.ForeColor = System.Drawing.Color.Gray;
            this.txtTimKiem.Location = new System.Drawing.Point(641, 13);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(151, 22);
            this.txtTimKiem.TabIndex = 21;
            this.txtTimKiem.Text = "Nhập từ khóa cần tìm kiếm...";
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // frmQuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 489);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmQuanLyNhanVien";
            this.Text = "Quản Lý Nhân Viên";
            this.Load += new System.EventHandler(this.frmQuanLyNhanVien_Load);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.grbNhanVien.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyNhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX lblTongNhanVien;
        private DevComponents.DotNetBar.Controls.GroupPanel grbNhanVien;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevComponents.DotNetBar.LabelX lblMaDocGia;
        private DevComponents.DotNetBar.LabelX lblHoVaTen;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaNhanVien;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenNhanVien;
        private DevComponents.DotNetBar.LabelX lblNgaySinh;
        private DevComponents.DotNetBar.Controls.TextBoxX txtChucVuNV;
        private DevComponents.DotNetBar.LabelX lblEmail;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDiaChiNhanVien;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private GNHHControl.dataGridViewGNHH dgvQuanLyNhanVien;
        private Controls.TextBoxTimKiem txtTimKiem;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT_NV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email_NV;
        private ThuVien.Txt_SoDienThoai_11So txtSoDienThoaiNV;


    }
}