namespace KHO
{
    partial class frmCongTy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCongTy));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnLuuFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnThoat = new System.Windows.Forms.ToolStripButton();
            this.cONGTYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtpHD = new System.Windows.Forms.DateTimePicker();
            this.cbTinhTrang = new System.Windows.Forms.ComboBox();
            this.cbLoaiHinh = new System.Windows.Forms.ComboBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtNguoiDD = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtMaThue = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.entityServerModeSource1 = new DevExpress.Data.Linq.EntityServerModeSource();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.gvDanhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TENCTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MASO_THUE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DIA_CHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGUOI_DD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DIEN_THOAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAY_HD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LOAI_HINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TINH_TRANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDanhSach = new DevExpress.XtraGrid.GridControl();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cONGTYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.entityServerModeSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThem,
            this.toolStripSeparator1,
            this.btnSua,
            this.toolStripSeparator2,
            this.btnXoa,
            this.toolStripSeparator3,
            this.btnLuuFile,
            this.toolStripSeparator4,
            this.btnThoat});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1270, 64);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(60, 59);
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnThem.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 64);
            // 
            // btnSua
            // 
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(46, 59);
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 64);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(47, 59);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 64);
            // 
            // btnLuuFile
            // 
            this.btnLuuFile.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuFile.Image")));
            this.btnLuuFile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnLuuFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLuuFile.Name = "btnLuuFile";
            this.btnLuuFile.Size = new System.Drawing.Size(73, 59);
            this.btnLuuFile.Text = "Lưu file";
            this.btnLuuFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLuuFile.Click += new System.EventHandler(this.btnLuuFile_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 64);
            // 
            // btnThoat
            // 
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThoat.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(61, 59);
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnSave);
            this.groupControl1.Controls.Add(this.dtpHD);
            this.groupControl1.Controls.Add(this.cbTinhTrang);
            this.groupControl1.Controls.Add(this.cbLoaiHinh);
            this.groupControl1.Controls.Add(this.txtSDT);
            this.groupControl1.Controls.Add(this.txtNguoiDD);
            this.groupControl1.Controls.Add(this.txtDiaChi);
            this.groupControl1.Controls.Add(this.txtMaThue);
            this.groupControl1.Controls.Add(this.txtTen);
            this.groupControl1.Controls.Add(this.label9);
            this.groupControl1.Controls.Add(this.label8);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Location = new System.Drawing.Point(0, 473);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1270, 246);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Thông tin";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1175, 93);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 43);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtpHD
            // 
            this.dtpHD.Location = new System.Drawing.Point(173, 147);
            this.dtpHD.Name = "dtpHD";
            this.dtpHD.Size = new System.Drawing.Size(268, 27);
            this.dtpHD.TabIndex = 17;
            // 
            // cbTinhTrang
            // 
            this.cbTinhTrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTinhTrang.FormattingEnabled = true;
            this.cbTinhTrang.Items.AddRange(new object[] {
            "Đang hoạt động",
            "Ngừng hoạt động"});
            this.cbTinhTrang.Location = new System.Drawing.Point(937, 152);
            this.cbTinhTrang.Name = "cbTinhTrang";
            this.cbTinhTrang.Size = new System.Drawing.Size(223, 27);
            this.cbTinhTrang.TabIndex = 16;
            // 
            // cbLoaiHinh
            // 
            this.cbLoaiHinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiHinh.FormattingEnabled = true;
            this.cbLoaiHinh.Items.AddRange(new object[] {
            "Công ty trách nhiệm hữu hạn",
            "Công ty cổ phần",
            "Công ty hợp danh",
            "Doanh nghiệp tư nhân"});
            this.cbLoaiHinh.Location = new System.Drawing.Point(546, 152);
            this.cbLoaiHinh.Name = "cbLoaiHinh";
            this.cbLoaiHinh.Size = new System.Drawing.Size(273, 27);
            this.cbLoaiHinh.TabIndex = 15;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(950, 103);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(219, 27);
            this.txtSDT.TabIndex = 14;
            // 
            // txtNguoiDD
            // 
            this.txtNguoiDD.Location = new System.Drawing.Point(546, 103);
            this.txtNguoiDD.Name = "txtNguoiDD";
            this.txtNguoiDD.Size = new System.Drawing.Size(293, 27);
            this.txtNguoiDD.TabIndex = 13;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(100, 102);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(293, 27);
            this.txtDiaChi.TabIndex = 12;
            // 
            // txtMaThue
            // 
            this.txtMaThue.Location = new System.Drawing.Point(867, 57);
            this.txtMaThue.Name = "txtMaThue";
            this.txtMaThue.Size = new System.Drawing.Size(293, 27);
            this.txtMaThue.TabIndex = 11;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(141, 57);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(596, 27);
            this.txtTen.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(839, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 22);
            this.label9.TabIndex = 8;
            this.label9.Text = "Tình trạng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(458, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 22);
            this.label8.TabIndex = 7;
            this.label8.Text = "Loại hình";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(853, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "Điện thoại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ngày hoạt động";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên công ty";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(415, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Người đại diện";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(763, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã số thuế";
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.Name = "sqlDataSource1";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // entityServerModeSource1
            // 
            this.entityServerModeSource1.ElementType = typeof(DataLayer.CONGTY);
            this.entityServerModeSource1.KeyExpression = "MACTY";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // gvDanhSach
            // 
            this.gvDanhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.TENCTY,
            this.MASO_THUE,
            this.DIA_CHI,
            this.NGUOI_DD,
            this.DIEN_THOAI,
            this.NGAY_HD,
            this.LOAI_HINH,
            this.TINH_TRANG});
            this.gvDanhSach.GridControl = this.gcDanhSach;
            this.gvDanhSach.Name = "gvDanhSach";
            this.gvDanhSach.OptionsView.ShowGroupPanel = false;
            this.gvDanhSach.Click += new System.EventHandler(this.gvDanhSach_Click);
            // 
            // TENCTY
            // 
            this.TENCTY.Caption = "Tên ";
            this.TENCTY.FieldName = "TENCTY";
            this.TENCTY.MinWidth = 30;
            this.TENCTY.Name = "TENCTY";
            this.TENCTY.Visible = true;
            this.TENCTY.VisibleIndex = 0;
            this.TENCTY.Width = 197;
            // 
            // MASO_THUE
            // 
            this.MASO_THUE.Caption = "Mã số thuế";
            this.MASO_THUE.FieldName = "MASO_THUE";
            this.MASO_THUE.MinWidth = 30;
            this.MASO_THUE.Name = "MASO_THUE";
            this.MASO_THUE.Visible = true;
            this.MASO_THUE.VisibleIndex = 1;
            this.MASO_THUE.Width = 101;
            // 
            // DIA_CHI
            // 
            this.DIA_CHI.Caption = "Địa chỉ";
            this.DIA_CHI.FieldName = "DIA_CHI";
            this.DIA_CHI.MinWidth = 30;
            this.DIA_CHI.Name = "DIA_CHI";
            this.DIA_CHI.Visible = true;
            this.DIA_CHI.VisibleIndex = 2;
            this.DIA_CHI.Width = 139;
            // 
            // NGUOI_DD
            // 
            this.NGUOI_DD.Caption = "Người đại diện";
            this.NGUOI_DD.FieldName = "NGUOI_DD";
            this.NGUOI_DD.MinWidth = 30;
            this.NGUOI_DD.Name = "NGUOI_DD";
            this.NGUOI_DD.Visible = true;
            this.NGUOI_DD.VisibleIndex = 3;
            this.NGUOI_DD.Width = 139;
            // 
            // DIEN_THOAI
            // 
            this.DIEN_THOAI.Caption = "Điện thoại";
            this.DIEN_THOAI.FieldName = "DIEN_THOAI";
            this.DIEN_THOAI.MinWidth = 30;
            this.DIEN_THOAI.Name = "DIEN_THOAI";
            this.DIEN_THOAI.Visible = true;
            this.DIEN_THOAI.VisibleIndex = 4;
            this.DIEN_THOAI.Width = 101;
            // 
            // NGAY_HD
            // 
            this.NGAY_HD.Caption = "Ngày hoạt động";
            this.NGAY_HD.FieldName = "NGAY_HD";
            this.NGAY_HD.MinWidth = 30;
            this.NGAY_HD.Name = "NGAY_HD";
            this.NGAY_HD.ShowUnboundExpressionMenu = true;
            this.NGAY_HD.Visible = true;
            this.NGAY_HD.VisibleIndex = 5;
            this.NGAY_HD.Width = 155;
            // 
            // LOAI_HINH
            // 
            this.LOAI_HINH.Caption = "Loại hình";
            this.LOAI_HINH.FieldName = "LOAI_HINH";
            this.LOAI_HINH.MinWidth = 30;
            this.LOAI_HINH.Name = "LOAI_HINH";
            this.LOAI_HINH.Visible = true;
            this.LOAI_HINH.VisibleIndex = 6;
            this.LOAI_HINH.Width = 243;
            // 
            // TINH_TRANG
            // 
            this.TINH_TRANG.Caption = "Tình trạng";
            this.TINH_TRANG.FieldName = "TINH_TRANG";
            this.TINH_TRANG.MinWidth = 30;
            this.TINH_TRANG.Name = "TINH_TRANG";
            this.TINH_TRANG.Visible = true;
            this.TINH_TRANG.VisibleIndex = 7;
            this.TINH_TRANG.Width = 159;
            // 
            // gcDanhSach
            // 
            gridLevelNode1.RelationName = "Level1";
            gridLevelNode2.RelationName = "Level2";
            this.gcDanhSach.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1,
            gridLevelNode2});
            this.gcDanhSach.Location = new System.Drawing.Point(0, 67);
            this.gcDanhSach.MainView = this.gvDanhSach;
            this.gcDanhSach.Name = "gcDanhSach";
            this.gcDanhSach.Size = new System.Drawing.Size(1270, 400);
            this.gcDanhSach.TabIndex = 2;
            this.gcDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSach});
            // 
            // frmCongTy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 680);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gcDanhSach);
            this.Controls.Add(this.toolStrip2);
            this.Name = "frmCongTy";
            this.Text = "frmCongTy";
            this.Load += new System.EventHandler(this.frmCongTy_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cONGTYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.entityServerModeSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripButton btnLuuFile;
        private System.Windows.Forms.ToolStripButton btnThoat;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtMaThue;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtNguoiDD;
        private System.Windows.Forms.ComboBox cbTinhTrang;
        private System.Windows.Forms.ComboBox cbLoaiHinh;
        private System.Windows.Forms.DateTimePicker dtpHD;
        private System.Windows.Forms.Button btnSave;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private DevExpress.Data.Linq.EntityServerModeSource entityServerModeSource1;
        private System.Windows.Forms.BindingSource cONGTYBindingSource;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSach;
        private DevExpress.XtraGrid.Columns.GridColumn TENCTY;
        private DevExpress.XtraGrid.Columns.GridColumn MASO_THUE;
        private DevExpress.XtraGrid.Columns.GridColumn DIA_CHI;
        private DevExpress.XtraGrid.Columns.GridColumn NGUOI_DD;
        private DevExpress.XtraGrid.Columns.GridColumn DIEN_THOAI;
        private DevExpress.XtraGrid.Columns.GridColumn NGAY_HD;
        private DevExpress.XtraGrid.Columns.GridColumn LOAI_HINH;
        private DevExpress.XtraGrid.Columns.GridColumn TINH_TRANG;
        private DevExpress.XtraGrid.GridControl gcDanhSach;
    }
}