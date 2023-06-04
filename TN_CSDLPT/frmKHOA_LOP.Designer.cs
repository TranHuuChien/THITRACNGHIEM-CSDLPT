namespace TN_CSDLPT
{
    partial class frmKHOA_LOP
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
            System.Windows.Forms.Label mACSLabel;
            System.Windows.Forms.Label tENKHLabel;
            System.Windows.Forms.Label mAKHLabel;
            System.Windows.Forms.Label tENLOPLabel;
            System.Windows.Forms.Label mALOPLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKHOA_LOP));
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnTHEM_KHOA = new DevExpress.XtraBars.BarButtonItem();
            this.btnSuaKhoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnGHI_KHOA = new DevExpress.XtraBars.BarButtonItem();
            this.btnXOA_KHOA = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.btnHOANTAC_KHOA = new DevExpress.XtraBars.BarButtonItem();
            this.btnLAMMOI_KHOA = new DevExpress.XtraBars.BarButtonItem();
            this.btnCancelKhoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnTHOAT = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.btnTHEM_LOP = new DevExpress.XtraBars.BarButtonItem();
            this.btnXOA_LOP = new DevExpress.XtraBars.BarButtonItem();
            this.btnGHI_LOP = new DevExpress.XtraBars.BarButtonItem();
            this.btnHOANTAC_LOP = new DevExpress.XtraBars.BarButtonItem();
            this.btnLAMMOI_LOP = new DevExpress.XtraBars.BarButtonItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cmbCoSo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataSet = new TN_CSDLPT.DataSet();
            this.tableAdapterManager = new TN_CSDLPT.DataSetTableAdapters.TableAdapterManager();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.label4 = new System.Windows.Forms.Label();
            this.panelLop = new System.Windows.Forms.Panel();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.bdsLop = new System.Windows.Forms.BindingSource(this.components);
            this.bdsKHOA = new System.Windows.Forms.BindingSource(this.components);
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.panelKhoa = new System.Windows.Forms.Panel();
            this.txtMaCS = new System.Windows.Forms.TextBox();
            this.txtMaKhoa = new System.Windows.Forms.TextBox();
            this.txtTenKhoa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kHOATableAdapter = new TN_CSDLPT.DataSetTableAdapters.KHOATableAdapter();
            this.kHOAGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lOPGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENLOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKH1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lOPTableAdapter = new TN_CSDLPT.DataSetTableAdapters.LOPTableAdapter();
            this.bdsGiangVien = new System.Windows.Forms.BindingSource(this.components);
            this.gIAOVIENTableAdapter = new TN_CSDLPT.DataSetTableAdapters.GIAOVIENTableAdapter();
            this.bdsSinhVien = new System.Windows.Forms.BindingSource(this.components);
            this.sINHVIENTableAdapter = new TN_CSDLPT.DataSetTableAdapters.SINHVIENTableAdapter();
            this.bdsGiaoVien_DangKi = new System.Windows.Forms.BindingSource(this.components);
            this.gIAOVIEN_DANGKYTableAdapter = new TN_CSDLPT.DataSetTableAdapters.GIAOVIEN_DANGKYTableAdapter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnThemLop = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGhiLop = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSuaLop = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXoaLop = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHoanTacLop = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCancelLop = new System.Windows.Forms.ToolStripMenuItem();
            mACSLabel = new System.Windows.Forms.Label();
            tENKHLabel = new System.Windows.Forms.Label();
            mAKHLabel = new System.Windows.Forms.Label();
            tENLOPLabel = new System.Windows.Forms.Label();
            mALOPLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.panelLop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKHOA)).BeginInit();
            this.panelKhoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kHOAGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOPGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGiangVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGiaoVien_DangKi)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mACSLabel
            // 
            mACSLabel.AutoSize = true;
            mACSLabel.Location = new System.Drawing.Point(310, 55);
            mACSLabel.Name = "mACSLabel";
            mACSLabel.Size = new System.Drawing.Size(85, 19);
            mACSLabel.TabIndex = 29;
            mACSLabel.Text = "MÃ CƠ SỞ";
            // 
            // tENKHLabel
            // 
            tENKHLabel.AutoSize = true;
            tENKHLabel.Location = new System.Drawing.Point(13, 93);
            tENKHLabel.Name = "tENKHLabel";
            tENKHLabel.Size = new System.Drawing.Size(87, 19);
            tENKHLabel.TabIndex = 27;
            tENKHLabel.Text = "Tên Khoa :";
            // 
            // mAKHLabel
            // 
            mAKHLabel.AutoSize = true;
            mAKHLabel.Location = new System.Drawing.Point(28, 34);
            mAKHLabel.Name = "mAKHLabel";
            mAKHLabel.Size = new System.Drawing.Size(80, 19);
            mAKHLabel.TabIndex = 25;
            mAKHLabel.Text = "Mã Khoa :";
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.AutoSize = true;
            tENLOPLabel.Location = new System.Drawing.Point(85, 76);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(89, 19);
            tENLOPLabel.TabIndex = 12;
            tENLOPLabel.Text = "TÊN LỚP : ";
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Location = new System.Drawing.Point(99, 8);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(77, 19);
            mALOPLabel.TabIndex = 10;
            mALOPLabel.Text = "MÃ LỚP :";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
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
            this.barButtonItem1,
            this.btnTHEM_KHOA,
            this.btnXOA_KHOA,
            this.barButtonItem3,
            this.btnHOANTAC_KHOA,
            this.btnLAMMOI_KHOA,
            this.btnGHI_KHOA,
            this.btnTHOAT,
            this.barButtonItem2,
            this.barButtonItem4,
            this.btnTHEM_LOP,
            this.btnXOA_LOP,
            this.btnGHI_LOP,
            this.btnHOANTAC_LOP,
            this.btnLAMMOI_LOP,
            this.btnCancelKhoa,
            this.btnSuaKhoa});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 17;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnTHEM_KHOA, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSuaKhoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGHI_KHOA, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXOA_KHOA, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHOANTAC_KHOA, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLAMMOI_KHOA, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnCancelKhoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnTHOAT, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btnTHEM_KHOA
            // 
            this.btnTHEM_KHOA.Caption = "THÊM KHOA";
            this.btnTHEM_KHOA.Id = 1;
            this.btnTHEM_KHOA.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTHEM_KHOA.ImageOptions.SvgImage")));
            this.btnTHEM_KHOA.Name = "btnTHEM_KHOA";
            this.btnTHEM_KHOA.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTHEM_KHOA_ItemClick);
            // 
            // btnSuaKhoa
            // 
            this.btnSuaKhoa.Caption = "SỬA";
            this.btnSuaKhoa.Id = 16;
            this.btnSuaKhoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaKhoa.ImageOptions.Image")));
            this.btnSuaKhoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSuaKhoa.ImageOptions.LargeImage")));
            this.btnSuaKhoa.Name = "btnSuaKhoa";
            this.btnSuaKhoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSuaKhoa_ItemClick);
            // 
            // btnGHI_KHOA
            // 
            this.btnGHI_KHOA.Caption = "GHI KHOA";
            this.btnGHI_KHOA.Enabled = false;
            this.btnGHI_KHOA.Id = 6;
            this.btnGHI_KHOA.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGHI_KHOA.ImageOptions.SvgImage")));
            this.btnGHI_KHOA.Name = "btnGHI_KHOA";
            this.btnGHI_KHOA.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGHI_KHOA_ItemClick);
            // 
            // btnXOA_KHOA
            // 
            this.btnXOA_KHOA.Caption = "XÓA KHOA";
            this.btnXOA_KHOA.Id = 2;
            this.btnXOA_KHOA.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXOA_KHOA.ImageOptions.SvgImage")));
            this.btnXOA_KHOA.Name = "btnXOA_KHOA";
            this.btnXOA_KHOA.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXOA_KHOA_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Id = 3;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // btnHOANTAC_KHOA
            // 
            this.btnHOANTAC_KHOA.Caption = "HOÀN TÁC";
            this.btnHOANTAC_KHOA.Id = 4;
            this.btnHOANTAC_KHOA.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHOANTAC_KHOA.ImageOptions.SvgImage")));
            this.btnHOANTAC_KHOA.Name = "btnHOANTAC_KHOA";
            this.btnHOANTAC_KHOA.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHOANTAC_KHOA_ItemClick);
            // 
            // btnLAMMOI_KHOA
            // 
            this.btnLAMMOI_KHOA.Caption = "LÀM MỚI";
            this.btnLAMMOI_KHOA.Id = 5;
            this.btnLAMMOI_KHOA.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLAMMOI_KHOA.ImageOptions.SvgImage")));
            this.btnLAMMOI_KHOA.Name = "btnLAMMOI_KHOA";
            this.btnLAMMOI_KHOA.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLAMMOI_KHOA_ItemClick);
            // 
            // btnCancelKhoa
            // 
            this.btnCancelKhoa.Caption = "CANCEL";
            this.btnCancelKhoa.Enabled = false;
            this.btnCancelKhoa.Id = 15;
            this.btnCancelKhoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelKhoa.ImageOptions.Image")));
            this.btnCancelKhoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCancelKhoa.ImageOptions.LargeImage")));
            this.btnCancelKhoa.Name = "btnCancelKhoa";
            this.btnCancelKhoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCancelKhoa_ItemClick);
            // 
            // btnTHOAT
            // 
            this.btnTHOAT.Caption = "THOÁT";
            this.btnTHOAT.Id = 7;
            this.btnTHOAT.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTHOAT.ImageOptions.SvgImage")));
            this.btnTHOAT.Name = "btnTHOAT";
            this.btnTHOAT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTHOAT_ItemClick);
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 1;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Id = 8;
            this.barButtonItem2.Name = "barButtonItem2";
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
            this.barDockControlTop.Size = new System.Drawing.Size(1336, 35);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 721);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1336, 73);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 35);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 686);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1336, 35);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 686);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "barButtonItem4";
            this.barButtonItem4.Id = 9;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // btnTHEM_LOP
            // 
            this.btnTHEM_LOP.Caption = "THÊM LỚP";
            this.btnTHEM_LOP.Id = 10;
            this.btnTHEM_LOP.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTHEM_LOP.ImageOptions.SvgImage")));
            this.btnTHEM_LOP.Name = "btnTHEM_LOP";
            // 
            // btnXOA_LOP
            // 
            this.btnXOA_LOP.Caption = "XÓA LỚP";
            this.btnXOA_LOP.Id = 11;
            this.btnXOA_LOP.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXOA_LOP.ImageOptions.SvgImage")));
            this.btnXOA_LOP.Name = "btnXOA_LOP";
            this.btnXOA_LOP.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXOA_LOP_ItemClick);
            // 
            // btnGHI_LOP
            // 
            this.btnGHI_LOP.Caption = "GHI LỚP";
            this.btnGHI_LOP.Id = 12;
            this.btnGHI_LOP.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGHI_LOP.ImageOptions.SvgImage")));
            this.btnGHI_LOP.Name = "btnGHI_LOP";
            // 
            // btnHOANTAC_LOP
            // 
            this.btnHOANTAC_LOP.Caption = "HOÀN TÁC";
            this.btnHOANTAC_LOP.Id = 13;
            this.btnHOANTAC_LOP.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHOANTAC_LOP.ImageOptions.SvgImage")));
            this.btnHOANTAC_LOP.Name = "btnHOANTAC_LOP";
            this.btnHOANTAC_LOP.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHOANTAC_LOP_ItemClick);
            // 
            // btnLAMMOI_LOP
            // 
            this.btnLAMMOI_LOP.Caption = "LÀM MỚI";
            this.btnLAMMOI_LOP.Id = 14;
            this.btnLAMMOI_LOP.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLAMMOI_LOP.ImageOptions.SvgImage")));
            this.btnLAMMOI_LOP.Name = "btnLAMMOI_LOP";
            this.btnLAMMOI_LOP.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLAMMOI_LOP_ItemClick);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cmbCoSo);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 35);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1336, 51);
            this.panelControl1.TabIndex = 5;
            // 
            // cmbCoSo
            // 
            this.cmbCoSo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCoSo.FormattingEnabled = true;
            this.cmbCoSo.Location = new System.Drawing.Point(218, 12);
            this.cmbCoSo.Name = "cmbCoSo";
            this.cmbCoSo.Size = new System.Drawing.Size(172, 27);
            this.cmbCoSo.TabIndex = 1;
            this.cmbCoSo.SelectedIndexChanged += new System.EventHandler(this.cmbCoSo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "CƠ SỞ : ";
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.label4);
            this.panelControl2.Controls.Add(this.panelLop);
            this.panelControl2.Controls.Add(this.panelKhoa);
            this.panelControl2.Controls.Add(this.label3);
            this.panelControl2.Controls.Add(this.label2);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(597, 415);
            this.panelControl2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(174, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(249, 29);
            this.label4.TabIndex = 14;
            this.label4.Text = "THÔNG TIN VỀ LỚP";
            // 
            // panelLop
            // 
            this.panelLop.Controls.Add(tENLOPLabel);
            this.panelLop.Controls.Add(this.txtTenLop);
            this.panelLop.Controls.Add(mALOPLabel);
            this.panelLop.Controls.Add(this.txtMaLop);
            this.panelLop.Enabled = false;
            this.panelLop.Location = new System.Drawing.Point(28, 304);
            this.panelLop.Name = "panelLop";
            this.panelLop.Size = new System.Drawing.Size(541, 105);
            this.panelLop.TabIndex = 13;
            // 
            // txtTenLop
            // 
            this.txtTenLop.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsLop, "TENLOP", true));
            this.txtTenLop.Location = new System.Drawing.Point(188, 73);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(154, 27);
            this.txtTenLop.TabIndex = 13;
            // 
            // bdsLop
            // 
            this.bdsLop.DataMember = "FK_LOP_KHOA";
            this.bdsLop.DataSource = this.bdsKHOA;
            // 
            // bdsKHOA
            // 
            this.bdsKHOA.DataMember = "KHOA";
            this.bdsKHOA.DataSource = this.dataSet;
            // 
            // txtMaLop
            // 
            this.txtMaLop.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsLop, "MALOP", true));
            this.txtMaLop.Location = new System.Drawing.Point(186, 5);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(156, 27);
            this.txtMaLop.TabIndex = 11;
            // 
            // panelKhoa
            // 
            this.panelKhoa.Controls.Add(mACSLabel);
            this.panelKhoa.Controls.Add(mAKHLabel);
            this.panelKhoa.Controls.Add(this.txtMaCS);
            this.panelKhoa.Controls.Add(this.txtMaKhoa);
            this.panelKhoa.Controls.Add(tENKHLabel);
            this.panelKhoa.Controls.Add(this.txtTenKhoa);
            this.panelKhoa.Enabled = false;
            this.panelKhoa.Location = new System.Drawing.Point(28, 77);
            this.panelKhoa.Name = "panelKhoa";
            this.panelKhoa.Size = new System.Drawing.Size(541, 132);
            this.panelKhoa.TabIndex = 12;
            // 
            // txtMaCS
            // 
            this.txtMaCS.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKHOA, "MACS", true));
            this.txtMaCS.Enabled = false;
            this.txtMaCS.Location = new System.Drawing.Point(404, 51);
            this.txtMaCS.Name = "txtMaCS";
            this.txtMaCS.Size = new System.Drawing.Size(100, 27);
            this.txtMaCS.TabIndex = 30;
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKHOA, "MAKH", true));
            this.txtMaKhoa.Location = new System.Drawing.Point(110, 29);
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Size = new System.Drawing.Size(165, 27);
            this.txtMaKhoa.TabIndex = 26;
            // 
            // txtTenKhoa
            // 
            this.txtTenKhoa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKHOA, "TENKH", true));
            this.txtTenKhoa.Location = new System.Drawing.Point(111, 90);
            this.txtTenKhoa.Name = "txtTenKhoa";
            this.txtTenKhoa.Size = new System.Drawing.Size(164, 27);
            this.txtTenKhoa.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "THÔNG TIN LỚP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(185, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "THÔNG TIN KHOA";
            // 
            // kHOATableAdapter
            // 
            this.kHOATableAdapter.ClearBeforeFill = true;
            // 
            // kHOAGridControl
            // 
            this.kHOAGridControl.DataSource = this.bdsKHOA;
            this.kHOAGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.kHOAGridControl.Location = new System.Drawing.Point(0, 86);
            this.kHOAGridControl.MainView = this.gridView1;
            this.kHOAGridControl.MenuManager = this.barManager1;
            this.kHOAGridControl.Name = "kHOAGridControl";
            this.kHOAGridControl.Size = new System.Drawing.Size(1336, 220);
            this.kHOAGridControl.TabIndex = 19;
            this.kHOAGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAKH,
            this.colTENKH,
            this.colMACS});
            this.gridView1.GridControl = this.kHOAGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMAKH
            // 
            this.colMAKH.Caption = "MÃ KHOA";
            this.colMAKH.FieldName = "MAKH";
            this.colMAKH.MinWidth = 30;
            this.colMAKH.Name = "colMAKH";
            this.colMAKH.OptionsColumn.AllowEdit = false;
            this.colMAKH.Visible = true;
            this.colMAKH.VisibleIndex = 0;
            this.colMAKH.Width = 112;
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
            this.colMACS.Caption = "CƠ SỞ";
            this.colMACS.FieldName = "MACS";
            this.colMACS.MinWidth = 30;
            this.colMACS.Name = "colMACS";
            this.colMACS.OptionsColumn.AllowEdit = false;
            this.colMACS.Visible = true;
            this.colMACS.VisibleIndex = 2;
            this.colMACS.Width = 112;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lOPGridControl);
            this.panel1.Controls.Add(this.panelControl2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 306);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1336, 415);
            this.panel1.TabIndex = 20;
            // 
            // lOPGridControl
            // 
            this.lOPGridControl.DataSource = this.bdsLop;
            this.lOPGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lOPGridControl.Location = new System.Drawing.Point(597, 0);
            this.lOPGridControl.MainView = this.gridView2;
            this.lOPGridControl.MenuManager = this.barManager1;
            this.lOPGridControl.Name = "lOPGridControl";
            this.lOPGridControl.Size = new System.Drawing.Size(739, 415);
            this.lOPGridControl.TabIndex = 8;
            this.lOPGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALOP,
            this.colTENLOP,
            this.colMAKH1});
            this.gridView2.GridControl = this.lOPGridControl;
            this.gridView2.Name = "gridView2";
            // 
            // colMALOP
            // 
            this.colMALOP.Caption = "MÃ LỚP";
            this.colMALOP.FieldName = "MALOP";
            this.colMALOP.MinWidth = 30;
            this.colMALOP.Name = "colMALOP";
            this.colMALOP.OptionsColumn.AllowEdit = false;
            this.colMALOP.Visible = true;
            this.colMALOP.VisibleIndex = 0;
            this.colMALOP.Width = 112;
            // 
            // colTENLOP
            // 
            this.colTENLOP.Caption = "TÊN LỚP";
            this.colTENLOP.FieldName = "TENLOP";
            this.colTENLOP.MinWidth = 30;
            this.colTENLOP.Name = "colTENLOP";
            this.colTENLOP.OptionsColumn.AllowEdit = false;
            this.colTENLOP.Visible = true;
            this.colTENLOP.VisibleIndex = 1;
            this.colTENLOP.Width = 112;
            // 
            // colMAKH1
            // 
            this.colMAKH1.Caption = "MÃ KHOA";
            this.colMAKH1.FieldName = "MAKH";
            this.colMAKH1.MinWidth = 30;
            this.colMAKH1.Name = "colMAKH1";
            this.colMAKH1.OptionsColumn.AllowEdit = false;
            this.colMAKH1.Visible = true;
            this.colMAKH1.VisibleIndex = 2;
            this.colMAKH1.Width = 112;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // bdsGiangVien
            // 
            this.bdsGiangVien.DataMember = "FK_GIAOVIEN_KHOA";
            this.bdsGiangVien.DataSource = this.bdsKHOA;
            // 
            // gIAOVIENTableAdapter
            // 
            this.gIAOVIENTableAdapter.ClearBeforeFill = true;
            // 
            // bdsSinhVien
            // 
            this.bdsSinhVien.DataMember = "FK_SINHVIEN_LOP";
            this.bdsSinhVien.DataSource = this.bdsLop;
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // bdsGiaoVien_DangKi
            // 
            this.bdsGiaoVien_DangKi.DataMember = "FK_GIAOVIEN_DANGKY_LOP";
            this.bdsGiaoVien_DangKi.DataSource = this.bdsLop;
            // 
            // gIAOVIEN_DANGKYTableAdapter
            // 
            this.gIAOVIEN_DANGKYTableAdapter.ClearBeforeFill = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThemLop,
            this.btnGhiLop,
            this.btnSuaLop,
            this.btnXoaLop,
            this.btnHoanTacLop,
            this.btnCancelLop});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(241, 229);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // btnThemLop
            // 
            this.btnThemLop.Name = "btnThemLop";
            this.btnThemLop.Size = new System.Drawing.Size(240, 32);
            this.btnThemLop.Text = "THÊM LỚP";
            this.btnThemLop.Click += new System.EventHandler(this.btnThemLop_Click);
            // 
            // btnGhiLop
            // 
            this.btnGhiLop.Enabled = false;
            this.btnGhiLop.Name = "btnGhiLop";
            this.btnGhiLop.Size = new System.Drawing.Size(240, 32);
            this.btnGhiLop.Text = "GHI LỚP";
            this.btnGhiLop.Click += new System.EventHandler(this.btnGhiLop_Click);
            // 
            // btnSuaLop
            // 
            this.btnSuaLop.Name = "btnSuaLop";
            this.btnSuaLop.Size = new System.Drawing.Size(240, 32);
            this.btnSuaLop.Text = "SỬA LỚP";
            this.btnSuaLop.Click += new System.EventHandler(this.btnSuaLop_Click);
            // 
            // btnXoaLop
            // 
            this.btnXoaLop.Name = "btnXoaLop";
            this.btnXoaLop.Size = new System.Drawing.Size(240, 32);
            this.btnXoaLop.Text = "XÓA LỚP";
            this.btnXoaLop.Click += new System.EventHandler(this.btnXoaLop_Click);
            // 
            // btnHoanTacLop
            // 
            this.btnHoanTacLop.Name = "btnHoanTacLop";
            this.btnHoanTacLop.Size = new System.Drawing.Size(240, 32);
            this.btnHoanTacLop.Text = "HOÀN TÁC ";
            this.btnHoanTacLop.Click += new System.EventHandler(this.btnHoanTacLop_Click);
            // 
            // btnCancelLop
            // 
            this.btnCancelLop.Enabled = false;
            this.btnCancelLop.Name = "btnCancelLop";
            this.btnCancelLop.Size = new System.Drawing.Size(240, 32);
            this.btnCancelLop.Text = "CANCEL";
            this.btnCancelLop.Click += new System.EventHandler(this.btnCancelLop_Click);
            // 
            // frmKHOA_LOP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 794);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kHOAGridControl);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IsMdiContainer = true;
            this.Name = "frmKHOA_LOP";
            this.Text = "KHOA&&LỚP";
            this.Load += new System.EventHandler(this.frmKHOA_LOP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            this.panelLop.ResumeLayout(false);
            this.panelLop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKHOA)).EndInit();
            this.panelKhoa.ResumeLayout(false);
            this.panelKhoa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kHOAGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lOPGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGiangVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGiaoVien_DangKi)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnTHEM_KHOA;
        private DevExpress.XtraBars.BarButtonItem btnXOA_KHOA;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem btnHOANTAC_KHOA;
        private DevExpress.XtraBars.BarButtonItem btnLAMMOI_KHOA;
        private DevExpress.XtraBars.BarButtonItem btnGHI_KHOA;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraBars.BarButtonItem btnTHOAT;
        private DataSet dataSet;
        private System.Windows.Forms.ComboBox cmbCoSo;
        private DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem btnTHEM_LOP;
        private DevExpress.XtraBars.BarButtonItem btnXOA_LOP;
        private DevExpress.XtraBars.BarButtonItem btnGHI_LOP;
        private DevExpress.XtraBars.BarButtonItem btnHOANTAC_LOP;
        private DevExpress.XtraBars.BarButtonItem btnLAMMOI_LOP;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private System.Windows.Forms.BindingSource bdsKHOA;
        private DataSetTableAdapters.KHOATableAdapter kHOATableAdapter;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl kHOAGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENKH;
        private DevExpress.XtraGrid.Columns.GridColumn colMACS;
        private System.Windows.Forms.BindingSource bdsLop;
        private DataSetTableAdapters.LOPTableAdapter lOPTableAdapter;
        private DevExpress.XtraGrid.GridControl lOPGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.BindingSource bdsGiangVien;
        private DataSetTableAdapters.GIAOVIENTableAdapter gIAOVIENTableAdapter;
        private System.Windows.Forms.BindingSource bdsSinhVien;
        private DataSetTableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private System.Windows.Forms.BindingSource bdsGiaoVien_DangKi;
        private DataSetTableAdapters.GIAOVIEN_DANGKYTableAdapter gIAOVIEN_DANGKYTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private DevExpress.XtraGrid.Columns.GridColumn colTENLOP;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraBars.BarButtonItem btnSuaKhoa;
        private DevExpress.XtraBars.BarButtonItem btnCancelKhoa;
        private System.Windows.Forms.Panel panelKhoa;
        private System.Windows.Forms.TextBox txtMaCS;
        private System.Windows.Forms.TextBox txtMaKhoa;
        private System.Windows.Forms.TextBox txtTenKhoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelLop;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnThemLop;
        private System.Windows.Forms.ToolStripMenuItem btnGhiLop;
        private System.Windows.Forms.ToolStripMenuItem btnSuaLop;
        private System.Windows.Forms.ToolStripMenuItem btnXoaLop;
        private System.Windows.Forms.ToolStripMenuItem btnHoanTacLop;
        private System.Windows.Forms.ToolStripMenuItem btnCancelLop;
    }
}