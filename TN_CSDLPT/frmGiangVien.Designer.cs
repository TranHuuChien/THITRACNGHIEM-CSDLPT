namespace TN_CSDLPT
{
    partial class frmGiangVien
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
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label mAGVLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiangVien));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnTHEM = new DevExpress.XtraBars.BarButtonItem();
            this.btnXOA = new DevExpress.XtraBars.BarButtonItem();
            this.btnSUA = new DevExpress.XtraBars.BarButtonItem();
            this.btnGHI = new DevExpress.XtraBars.BarButtonItem();
            this.btnHOANTAC = new DevExpress.XtraBars.BarButtonItem();
            this.btnCANCEL = new DevExpress.XtraBars.BarButtonItem();
            this.btnLAMMOI = new DevExpress.XtraBars.BarButtonItem();
            this.btnTHOAT = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.pc1 = new System.Windows.Forms.Panel();
            this.panelNhapLieu = new DevExpress.XtraEditors.PanelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.bdsGiaoVien = new System.Windows.Forms.BindingSource(this.components);
            this.bdsKhoa = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet = new TN_CSDLPT.DataSet();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.txtMaGV = new System.Windows.Forms.TextBox();
            this.kHOAGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAKH1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableAdapterManager = new TN_CSDLPT.DataSetTableAdapters.TableAdapterManager();
            this.kHOATableAdapter = new TN_CSDLPT.DataSetTableAdapters.KHOATableAdapter();
            this.gIAOVIENTableAdapter = new TN_CSDLPT.DataSetTableAdapters.GIAOVIENTableAdapter();
            this.gcGiaoVien = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.bdsGiaoVien_DangKi = new System.Windows.Forms.BindingSource(this.components);
            this.gIAOVIEN_DANGKYTableAdapter = new TN_CSDLPT.DataSetTableAdapters.GIAOVIEN_DANGKYTableAdapter();
            this.bdsBoDe = new System.Windows.Forms.BindingSource(this.components);
            this.bODETableAdapter = new TN_CSDLPT.DataSetTableAdapters.BODETableAdapter();
            dIACHILabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            mAGVLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.pc1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelNhapLieu)).BeginInit();
            this.panelNhapLieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGiaoVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOAGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcGiaoVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGiaoVien_DangKi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBoDe)).BeginInit();
            this.SuspendLayout();
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(365, 98);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(76, 19);
            dIACHILabel.TabIndex = 22;
            dIACHILabel.Text = "Địa Chỉ : ";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(46, 189);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(52, 19);
            tENLabel.TabIndex = 20;
            tENLabel.Text = "Tên : ";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(51, 128);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(48, 19);
            hOLabel.TabIndex = 18;
            hOLabel.Text = "HỌ : ";
            // 
            // mAGVLabel
            // 
            mAGVLabel.AutoSize = true;
            mAGVLabel.Location = new System.Drawing.Point(46, 74);
            mAGVLabel.Name = "mAGVLabel";
            mAGVLabel.Size = new System.Drawing.Size(127, 19);
            mAGVLabel.TabIndex = 17;
            mAGVLabel.Text = "Mã Giảng Viên : ";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnTHEM,
            this.btnXOA,
            this.btnSUA,
            this.btnGHI,
            this.btnHOANTAC,
            this.btnCANCEL,
            this.btnLAMMOI,
            this.btnTHOAT});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 8;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnTHEM, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXOA, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSUA, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGHI, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHOANTAC, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnCANCEL, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLAMMOI, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnTHOAT)});
            this.bar1.Text = "Tools";
            // 
            // btnTHEM
            // 
            this.btnTHEM.Caption = "THÊM";
            this.btnTHEM.Id = 0;
            this.btnTHEM.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTHEM.ImageOptions.SvgImage")));
            this.btnTHEM.Name = "btnTHEM";
            this.btnTHEM.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTHEM_ItemClick);
            // 
            // btnXOA
            // 
            this.btnXOA.Caption = "XÓA";
            this.btnXOA.Id = 1;
            this.btnXOA.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXOA.ImageOptions.SvgImage")));
            this.btnXOA.Name = "btnXOA";
            this.btnXOA.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXOA_ItemClick);
            // 
            // btnSUA
            // 
            this.btnSUA.Caption = "SỬA";
            this.btnSUA.Id = 2;
            this.btnSUA.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSUA.ImageOptions.Image")));
            this.btnSUA.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSUA.ImageOptions.LargeImage")));
            this.btnSUA.Name = "btnSUA";
            this.btnSUA.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSUA_ItemClick);
            // 
            // btnGHI
            // 
            this.btnGHI.Caption = "GHI";
            this.btnGHI.Enabled = false;
            this.btnGHI.Id = 3;
            this.btnGHI.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGHI.ImageOptions.SvgImage")));
            this.btnGHI.Name = "btnGHI";
            this.btnGHI.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGHI_ItemClick);
            // 
            // btnHOANTAC
            // 
            this.btnHOANTAC.Caption = "HOÀN TÁC";
            this.btnHOANTAC.Id = 4;
            this.btnHOANTAC.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHOANTAC.ImageOptions.Image")));
            this.btnHOANTAC.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHOANTAC.ImageOptions.LargeImage")));
            this.btnHOANTAC.Name = "btnHOANTAC";
            this.btnHOANTAC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHOANTAC_ItemClick);
            // 
            // btnCANCEL
            // 
            this.btnCANCEL.Caption = "CANCEL";
            this.btnCANCEL.Enabled = false;
            this.btnCANCEL.Id = 5;
            this.btnCANCEL.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCANCEL.ImageOptions.Image")));
            this.btnCANCEL.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCANCEL.ImageOptions.LargeImage")));
            this.btnCANCEL.Name = "btnCANCEL";
            this.btnCANCEL.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCANCEL_ItemClick);
            // 
            // btnLAMMOI
            // 
            this.btnLAMMOI.Caption = "LÀM MỚI";
            this.btnLAMMOI.Id = 6;
            this.btnLAMMOI.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLAMMOI.ImageOptions.SvgImage")));
            this.btnLAMMOI.Name = "btnLAMMOI";
            // 
            // btnTHOAT
            // 
            this.btnTHOAT.Caption = "THOÁT";
            this.btnTHOAT.Id = 7;
            this.btnTHOAT.Name = "btnTHOAT";
            this.btnTHOAT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTHOAT_ItemClick);
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1344, 55);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 576);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1344, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 55);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 521);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1344, 55);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 521);
            // 
            // pc1
            // 
            this.pc1.Controls.Add(this.panelNhapLieu);
            this.pc1.Controls.Add(this.kHOAGridControl);
            this.pc1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pc1.Location = new System.Drawing.Point(0, 55);
            this.pc1.Name = "pc1";
            this.pc1.Size = new System.Drawing.Size(676, 521);
            this.pc1.TabIndex = 4;
            // 
            // panelNhapLieu
            // 
            this.panelNhapLieu.Controls.Add(this.label1);
            this.panelNhapLieu.Controls.Add(dIACHILabel);
            this.panelNhapLieu.Controls.Add(this.txtDiaChi);
            this.panelNhapLieu.Controls.Add(tENLabel);
            this.panelNhapLieu.Controls.Add(this.txtTen);
            this.panelNhapLieu.Controls.Add(hOLabel);
            this.panelNhapLieu.Controls.Add(this.txtHo);
            this.panelNhapLieu.Controls.Add(mAGVLabel);
            this.panelNhapLieu.Controls.Add(this.txtMaGV);
            this.panelNhapLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNhapLieu.Enabled = false;
            this.panelNhapLieu.Location = new System.Drawing.Point(0, 293);
            this.panelNhapLieu.Name = "panelNhapLieu";
            this.panelNhapLieu.Size = new System.Drawing.Size(676, 228);
            this.panelNhapLieu.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 19);
            this.label1.TabIndex = 27;
            this.label1.Text = "THÔNG TIN GIẢNG VIÊN";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsGiaoVien, "DIACHI", true));
            this.txtDiaChi.Location = new System.Drawing.Point(441, 95);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(189, 27);
            this.txtDiaChi.TabIndex = 25;
            // 
            // bdsGiaoVien
            // 
            this.bdsGiaoVien.DataMember = "FK_GIAOVIEN_KHOA";
            this.bdsGiaoVien.DataSource = this.bdsKhoa;
            // 
            // bdsKhoa
            // 
            this.bdsKhoa.DataMember = "KHOA";
            this.bdsKhoa.DataSource = this.DataSet;
            // 
            // DataSet
            // 
            this.DataSet.DataSetName = "DataSet";
            this.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtTen
            // 
            this.txtTen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsGiaoVien, "TEN", true));
            this.txtTen.Location = new System.Drawing.Point(106, 186);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(166, 27);
            this.txtTen.TabIndex = 23;
            // 
            // txtHo
            // 
            this.txtHo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsGiaoVien, "HO", true));
            this.txtHo.Location = new System.Drawing.Point(106, 125);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(166, 27);
            this.txtHo.TabIndex = 21;
            // 
            // txtMaGV
            // 
            this.txtMaGV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsGiaoVien, "MAGV", true));
            this.txtMaGV.Location = new System.Drawing.Point(180, 71);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(100, 27);
            this.txtMaGV.TabIndex = 19;
            // 
            // kHOAGridControl
            // 
            this.kHOAGridControl.DataSource = this.bdsKhoa;
            this.kHOAGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.kHOAGridControl.Location = new System.Drawing.Point(0, 0);
            this.kHOAGridControl.MainView = this.gridView1;
            this.kHOAGridControl.MenuManager = this.barManager1;
            this.kHOAGridControl.Name = "kHOAGridControl";
            this.kHOAGridControl.Size = new System.Drawing.Size(676, 293);
            this.kHOAGridControl.TabIndex = 10;
            this.kHOAGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.kHOAGridControl.Click += new System.EventHandler(this.kHOAGridControl_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAKH1,
            this.colTENKH,
            this.colMACS});
            this.gridView1.GridControl = this.kHOAGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMAKH1
            // 
            this.colMAKH1.Caption = "MÃ KHOA";
            this.colMAKH1.FieldName = "MAKH";
            this.colMAKH1.MinWidth = 30;
            this.colMAKH1.Name = "colMAKH1";
            this.colMAKH1.OptionsColumn.AllowEdit = false;
            this.colMAKH1.Visible = true;
            this.colMAKH1.VisibleIndex = 0;
            this.colMAKH1.Width = 112;
            // 
            // colTENKH
            // 
            this.colTENKH.Caption = "TÊN KHOA";
            this.colTENKH.FieldName = "TENKH";
            this.colTENKH.MinWidth = 30;
            this.colTENKH.Name = "colTENKH";
            this.colTENKH.OptionsColumn.AllowEdit = false;
            this.colTENKH.Visible = true;
            this.colTENKH.VisibleIndex = 1;
            this.colTENKH.Width = 112;
            // 
            // colMACS
            // 
            this.colMACS.Caption = "MÃ CƠ SỞ";
            this.colMACS.FieldName = "MACS";
            this.colMACS.MinWidth = 30;
            this.colMACS.Name = "colMACS";
            this.colMACS.OptionsColumn.AllowEdit = false;
            this.colMACS.Visible = true;
            this.colMACS.VisibleIndex = 2;
            this.colMACS.Width = 112;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BAITHITableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.CT_BAITHITableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TN_CSDLPT.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // kHOATableAdapter
            // 
            this.kHOATableAdapter.ClearBeforeFill = true;
            // 
            // gIAOVIENTableAdapter
            // 
            this.gIAOVIENTableAdapter.ClearBeforeFill = true;
            // 
            // gcGiaoVien
            // 
            this.gcGiaoVien.DataSource = this.bdsGiaoVien;
            this.gcGiaoVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcGiaoVien.Location = new System.Drawing.Point(676, 55);
            this.gcGiaoVien.MainView = this.gridView2;
            this.gcGiaoVien.MenuManager = this.barManager1;
            this.gcGiaoVien.Name = "gcGiaoVien";
            this.gcGiaoVien.Size = new System.Drawing.Size(668, 521);
            this.gcGiaoVien.TabIndex = 9;
            this.gcGiaoVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAGV,
            this.colHO,
            this.colTEN,
            this.colDIACHI,
            this.colMAKH});
            this.gridView2.GridControl = this.gcGiaoVien;
            this.gridView2.Name = "gridView2";
            // 
            // colMAGV
            // 
            this.colMAGV.Caption = "MÃ GIẢNG VIÊN";
            this.colMAGV.FieldName = "MAGV";
            this.colMAGV.MinWidth = 30;
            this.colMAGV.Name = "colMAGV";
            this.colMAGV.OptionsColumn.AllowEdit = false;
            this.colMAGV.Visible = true;
            this.colMAGV.VisibleIndex = 0;
            this.colMAGV.Width = 112;
            // 
            // colHO
            // 
            this.colHO.Caption = "HỌ";
            this.colHO.FieldName = "HO";
            this.colHO.MinWidth = 30;
            this.colHO.Name = "colHO";
            this.colHO.OptionsColumn.AllowEdit = false;
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            this.colHO.Width = 112;
            // 
            // colTEN
            // 
            this.colTEN.Caption = "TÊN ";
            this.colTEN.FieldName = "TEN";
            this.colTEN.MinWidth = 30;
            this.colTEN.Name = "colTEN";
            this.colTEN.OptionsColumn.AllowEdit = false;
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            this.colTEN.Width = 112;
            // 
            // colDIACHI
            // 
            this.colDIACHI.Caption = "ĐỊA CHỈ";
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.MinWidth = 30;
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.OptionsColumn.AllowEdit = false;
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 3;
            this.colDIACHI.Width = 112;
            // 
            // colMAKH
            // 
            this.colMAKH.Caption = "MÃ KHOA";
            this.colMAKH.FieldName = "MAKH";
            this.colMAKH.MinWidth = 30;
            this.colMAKH.Name = "colMAKH";
            this.colMAKH.OptionsColumn.AllowEdit = false;
            this.colMAKH.Visible = true;
            this.colMAKH.VisibleIndex = 4;
            this.colMAKH.Width = 112;
            // 
            // panelControl1
            // 
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(676, 55);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(668, 56);
            this.panelControl1.TabIndex = 10;
            // 
            // bdsGiaoVien_DangKi
            // 
            this.bdsGiaoVien_DangKi.DataMember = "FK_GIAOVIEN_DANGKY_GIAOVIEN1";
            this.bdsGiaoVien_DangKi.DataSource = this.bdsGiaoVien;
            // 
            // gIAOVIEN_DANGKYTableAdapter
            // 
            this.gIAOVIEN_DANGKYTableAdapter.ClearBeforeFill = true;
            // 
            // bdsBoDe
            // 
            this.bdsBoDe.DataMember = "FK_BODE_GIAOVIEN";
            this.bdsBoDe.DataSource = this.bdsGiaoVien;
            // 
            // bODETableAdapter
            // 
            this.bODETableAdapter.ClearBeforeFill = true;
            // 
            // frmGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 596);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gcGiaoVien);
            this.Controls.Add(this.pc1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmGiangVien";
            this.Text = "QUẢN LÝ GIẢNG VIÊN";
            this.Load += new System.EventHandler(this.frmGiangVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.pc1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelNhapLieu)).EndInit();
            this.panelNhapLieu.ResumeLayout(false);
            this.panelNhapLieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGiaoVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOAGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcGiaoVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGiaoVien_DangKi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBoDe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnTHEM;
        private DevExpress.XtraBars.BarButtonItem btnXOA;
        private DevExpress.XtraBars.BarButtonItem btnSUA;
        private DataSet DataSet;
        private System.Windows.Forms.Panel pc1;
        private DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraBars.BarButtonItem btnGHI;
        private DevExpress.XtraBars.BarButtonItem btnHOANTAC;
        private DevExpress.XtraBars.BarButtonItem btnCANCEL;
        private DevExpress.XtraBars.BarButtonItem btnLAMMOI;
        private DevExpress.XtraBars.BarButtonItem btnTHOAT;
        private System.Windows.Forms.BindingSource bdsKhoa;
        private DataSetTableAdapters.KHOATableAdapter kHOATableAdapter;
        private DevExpress.XtraGrid.GridControl kHOAGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource bdsGiaoVien;
        private DataSetTableAdapters.GIAOVIENTableAdapter gIAOVIENTableAdapter;
        private DevExpress.XtraGrid.GridControl gcGiaoVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH1;
        private DevExpress.XtraGrid.Columns.GridColumn colTENKH;
        private DevExpress.XtraGrid.Columns.GridColumn colMACS;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelNhapLieu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.TextBox txtMaGV;
        private System.Windows.Forms.BindingSource bdsGiaoVien_DangKi;
        private DataSetTableAdapters.GIAOVIEN_DANGKYTableAdapter gIAOVIEN_DANGKYTableAdapter;
        private System.Windows.Forms.BindingSource bdsBoDe;
        private DataSetTableAdapters.BODETableAdapter bODETableAdapter;
    }
}