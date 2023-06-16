namespace TN_CSDLPT
{
    partial class frmKhoaAndLop
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
            System.Windows.Forms.Label mAKHLabel;
            System.Windows.Forms.Label tENKHLabel;
            System.Windows.Forms.Label mALOPLabel;
            System.Windows.Forms.Label tENLOPLabel;
            System.Windows.Forms.Label mACSLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhoaAndLop));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnTHEM_KHOA = new DevExpress.XtraBars.BarButtonItem();
            this.btnSuaKhoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnGHI_KHOA = new DevExpress.XtraBars.BarButtonItem();
            this.btnXOA_KHOA = new DevExpress.XtraBars.BarButtonItem();
            this.btnCancelKhoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnHOANTAC_KHOA = new DevExpress.XtraBars.BarButtonItem();
            this.btnLAMMOI_KHOA = new DevExpress.XtraBars.BarButtonItem();
            this.btnTHOAT = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cmbCoSo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.label2 = new System.Windows.Forms.Label();
            this.dataSet = new TN_CSDLPT.DataSet();
            this.bdsKHOA = new System.Windows.Forms.BindingSource(this.components);
            this.kHOATableAdapter = new TN_CSDLPT.DataSetTableAdapters.KHOATableAdapter();
            this.tableAdapterManager = new TN_CSDLPT.DataSetTableAdapters.TableAdapterManager();
            this.gIAOVIEN_DANGKYTableAdapter = new TN_CSDLPT.DataSetTableAdapters.GIAOVIEN_DANGKYTableAdapter();
            this.gIAOVIENTableAdapter = new TN_CSDLPT.DataSetTableAdapters.GIAOVIENTableAdapter();
            this.lOPTableAdapter = new TN_CSDLPT.DataSetTableAdapters.LOPTableAdapter();
            this.sINHVIENTableAdapter = new TN_CSDLPT.DataSetTableAdapters.SINHVIENTableAdapter();
            this.kHOAGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.label4 = new System.Windows.Forms.Label();
            this.panelLop = new System.Windows.Forms.Panel();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.bdsLop = new System.Windows.Forms.BindingSource(this.components);
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.panelKhoa = new System.Windows.Forms.Panel();
            this.txtMaCS = new System.Windows.Forms.TextBox();
            this.txtTenKhoa = new System.Windows.Forms.TextBox();
            this.txtMaKhoa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bdsGiangVien = new System.Windows.Forms.BindingSource(this.components);
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.label6 = new System.Windows.Forms.Label();
            this.lOPGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENLOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKH1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bdsSinhVien = new System.Windows.Forms.BindingSource(this.components);
            this.bdsGiaoVien_DangKi = new System.Windows.Forms.BindingSource(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnThemLop = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGhiLop = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSuaLop = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXoaLop = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHoanTacLop = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCancelLop = new System.Windows.Forms.ToolStripMenuItem();
            mAKHLabel = new System.Windows.Forms.Label();
            tENKHLabel = new System.Windows.Forms.Label();
            mALOPLabel = new System.Windows.Forms.Label();
            tENLOPLabel = new System.Windows.Forms.Label();
            mACSLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKHOA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOAGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            this.panelLop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).BeginInit();
            this.panelKhoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGiangVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOPGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGiaoVien_DangKi)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mAKHLabel
            // 
            mAKHLabel.AutoSize = true;
            mAKHLabel.Location = new System.Drawing.Point(82, 6);
            mAKHLabel.Name = "mAKHLabel";
            mAKHLabel.Size = new System.Drawing.Size(58, 19);
            mAKHLabel.TabIndex = 0;
            mAKHLabel.Text = "MAKH:";
            // 
            // tENKHLabel
            // 
            tENKHLabel.AutoSize = true;
            tENKHLabel.Location = new System.Drawing.Point(80, 54);
            tENKHLabel.Name = "tENKHLabel";
            tENKHLabel.Size = new System.Drawing.Size(65, 19);
            tENKHLabel.TabIndex = 2;
            tENKHLabel.Text = "TENKH:";
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Location = new System.Drawing.Point(102, 15);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(67, 19);
            mALOPLabel.TabIndex = 0;
            mALOPLabel.Text = "MALOP:";
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.AutoSize = true;
            tENLOPLabel.Location = new System.Drawing.Point(100, 62);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(74, 19);
            tENLOPLabel.TabIndex = 2;
            tENLOPLabel.Text = "TENLOP:";
            // 
            // mACSLabel
            // 
            mACSLabel.AutoSize = true;
            mACSLabel.Location = new System.Drawing.Point(405, 41);
            mACSLabel.Name = "mACSLabel";
            mACSLabel.Size = new System.Drawing.Size(57, 19);
            mACSLabel.TabIndex = 4;
            mACSLabel.Text = "MACS:";
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
            this.btnTHEM_KHOA,
            this.btnSuaKhoa,
            this.btnGHI_KHOA,
            this.btnXOA_KHOA,
            this.btnCancelKhoa,
            this.btnHOANTAC_KHOA,
            this.btnLAMMOI_KHOA,
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnTHEM_KHOA, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSuaKhoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGHI_KHOA, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXOA_KHOA, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnCancelKhoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHOANTAC_KHOA, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLAMMOI_KHOA, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnTHOAT, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnTHEM_KHOA
            // 
            this.btnTHEM_KHOA.Caption = "THÊM KHOA";
            this.btnTHEM_KHOA.Id = 0;
            this.btnTHEM_KHOA.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTHEM_KHOA.ImageOptions.Image")));
            this.btnTHEM_KHOA.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTHEM_KHOA.ImageOptions.LargeImage")));
            this.btnTHEM_KHOA.Name = "btnTHEM_KHOA";
            this.btnTHEM_KHOA.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTHEM_KHOA_ItemClick);
            // 
            // btnSuaKhoa
            // 
            this.btnSuaKhoa.Caption = "SỬA";
            this.btnSuaKhoa.Id = 1;
            this.btnSuaKhoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSuaKhoa.ImageOptions.SvgImage")));
            this.btnSuaKhoa.Name = "btnSuaKhoa";
            this.btnSuaKhoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSuaKhoa_ItemClick);
            // 
            // btnGHI_KHOA
            // 
            this.btnGHI_KHOA.Caption = "GHI";
            this.btnGHI_KHOA.Enabled = false;
            this.btnGHI_KHOA.Id = 2;
            this.btnGHI_KHOA.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGHI_KHOA.ImageOptions.SvgImage")));
            this.btnGHI_KHOA.Name = "btnGHI_KHOA";
            this.btnGHI_KHOA.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGHI_KHOA_ItemClick);
            // 
            // btnXOA_KHOA
            // 
            this.btnXOA_KHOA.Caption = "XÓA";
            this.btnXOA_KHOA.Id = 3;
            this.btnXOA_KHOA.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXOA_KHOA.ImageOptions.Image")));
            this.btnXOA_KHOA.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXOA_KHOA.ImageOptions.LargeImage")));
            this.btnXOA_KHOA.Name = "btnXOA_KHOA";
            this.btnXOA_KHOA.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXOA_KHOA_ItemClick);
            // 
            // btnCancelKhoa
            // 
            this.btnCancelKhoa.Caption = "HỦY";
            this.btnCancelKhoa.Enabled = false;
            this.btnCancelKhoa.Id = 4;
            this.btnCancelKhoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCancelKhoa.ImageOptions.SvgImage")));
            this.btnCancelKhoa.Name = "btnCancelKhoa";
            this.btnCancelKhoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCancelKhoa_ItemClick);
            // 
            // btnHOANTAC_KHOA
            // 
            this.btnHOANTAC_KHOA.Caption = "HOÀN TÁC";
            this.btnHOANTAC_KHOA.Id = 5;
            this.btnHOANTAC_KHOA.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHOANTAC_KHOA.ImageOptions.SvgImage")));
            this.btnHOANTAC_KHOA.Name = "btnHOANTAC_KHOA";
            this.btnHOANTAC_KHOA.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHOANTAC_KHOA_ItemClick);
            // 
            // btnLAMMOI_KHOA
            // 
            this.btnLAMMOI_KHOA.Caption = "LÀM MỚI";
            this.btnLAMMOI_KHOA.Id = 6;
            this.btnLAMMOI_KHOA.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLAMMOI_KHOA.ImageOptions.SvgImage")));
            this.btnLAMMOI_KHOA.Name = "btnLAMMOI_KHOA";
            this.btnLAMMOI_KHOA.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLAMMOI_KHOA_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1294, 55);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 652);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1294, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 55);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 597);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1294, 55);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 597);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cmbCoSo);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 55);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1294, 51);
            this.panelControl1.TabIndex = 6;
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
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.label2);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 106);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1294, 39);
            this.panelControl2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(437, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "THÔNG TIN VỀ KHOA";
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsKHOA
            // 
            this.bdsKHOA.DataMember = "KHOA";
            this.bdsKHOA.DataSource = this.dataSet;
            // 
            // kHOATableAdapter
            // 
            this.kHOATableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BAITHITableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.CT_BAITHITableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = this.gIAOVIEN_DANGKYTableAdapter;
            this.tableAdapterManager.GIAOVIENTableAdapter = this.gIAOVIENTableAdapter;
            this.tableAdapterManager.KHOATableAdapter = this.kHOATableAdapter;
            this.tableAdapterManager.LOPTableAdapter = this.lOPTableAdapter;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = this.sINHVIENTableAdapter;
            this.tableAdapterManager.UpdateOrder = TN_CSDLPT.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gIAOVIEN_DANGKYTableAdapter
            // 
            this.gIAOVIEN_DANGKYTableAdapter.ClearBeforeFill = true;
            // 
            // gIAOVIENTableAdapter
            // 
            this.gIAOVIENTableAdapter.ClearBeforeFill = true;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // kHOAGridControl
            // 
            this.kHOAGridControl.DataSource = this.bdsKHOA;
            this.kHOAGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.kHOAGridControl.Location = new System.Drawing.Point(0, 145);
            this.kHOAGridControl.MainView = this.gridView1;
            this.kHOAGridControl.MenuManager = this.barManager1;
            this.kHOAGridControl.Name = "kHOAGridControl";
            this.kHOAGridControl.Size = new System.Drawing.Size(1294, 203);
            this.kHOAGridControl.TabIndex = 8;
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
            this.colMACS.Caption = "MÃ CƠ SỞ";
            this.colMACS.FieldName = "MACS";
            this.colMACS.MinWidth = 30;
            this.colMACS.Name = "colMACS";
            this.colMACS.OptionsColumn.AllowEdit = false;
            this.colMACS.Visible = true;
            this.colMACS.VisibleIndex = 2;
            this.colMACS.Width = 112;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.label4);
            this.panelControl3.Controls.Add(this.panelLop);
            this.panelControl3.Controls.Add(this.panelKhoa);
            this.panelControl3.Controls.Add(this.label5);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl3.Location = new System.Drawing.Point(0, 348);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(655, 304);
            this.panelControl3.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(156, 147);
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
            this.panelLop.Location = new System.Drawing.Point(10, 180);
            this.panelLop.Name = "panelLop";
            this.panelLop.Size = new System.Drawing.Size(541, 106);
            this.panelLop.TabIndex = 13;
            // 
            // txtTenLop
            // 
            this.txtTenLop.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsLop, "TENLOP", true));
            this.txtTenLop.Location = new System.Drawing.Point(180, 59);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(300, 27);
            this.txtTenLop.TabIndex = 3;
            // 
            // bdsLop
            // 
            this.bdsLop.DataMember = "FK_LOP_KHOA";
            this.bdsLop.DataSource = this.bdsKHOA;
            // 
            // txtMaLop
            // 
            this.txtMaLop.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsLop, "MALOP", true));
            this.txtMaLop.Location = new System.Drawing.Point(175, 12);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(161, 27);
            this.txtMaLop.TabIndex = 1;
            // 
            // panelKhoa
            // 
            this.panelKhoa.Controls.Add(mACSLabel);
            this.panelKhoa.Controls.Add(this.txtMaCS);
            this.panelKhoa.Controls.Add(tENKHLabel);
            this.panelKhoa.Controls.Add(this.txtTenKhoa);
            this.panelKhoa.Controls.Add(mAKHLabel);
            this.panelKhoa.Controls.Add(this.txtMaKhoa);
            this.panelKhoa.Enabled = false;
            this.panelKhoa.Location = new System.Drawing.Point(28, 40);
            this.panelKhoa.Name = "panelKhoa";
            this.panelKhoa.Size = new System.Drawing.Size(595, 98);
            this.panelKhoa.TabIndex = 12;
            // 
            // txtMaCS
            // 
            this.txtMaCS.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKHOA, "MACS", true));
            this.txtMaCS.Enabled = false;
            this.txtMaCS.Location = new System.Drawing.Point(468, 38);
            this.txtMaCS.Name = "txtMaCS";
            this.txtMaCS.Size = new System.Drawing.Size(100, 27);
            this.txtMaCS.TabIndex = 5;
            // 
            // txtTenKhoa
            // 
            this.txtTenKhoa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKHOA, "TENKH", true));
            this.txtTenKhoa.Location = new System.Drawing.Point(151, 51);
            this.txtTenKhoa.Name = "txtTenKhoa";
            this.txtTenKhoa.Size = new System.Drawing.Size(166, 27);
            this.txtTenKhoa.TabIndex = 3;
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKHOA, "MAKH", true));
            this.txtMaKhoa.Location = new System.Drawing.Point(151, 3);
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Size = new System.Drawing.Size(166, 27);
            this.txtMaKhoa.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(185, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "THÔNG TIN KHOA";
            // 
            // bdsGiangVien
            // 
            this.bdsGiangVien.DataMember = "FK_GIAOVIEN_KHOA";
            this.bdsGiangVien.DataSource = this.bdsKHOA;
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.label6);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl4.Location = new System.Drawing.Point(655, 348);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(639, 35);
            this.panelControl4.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(223, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(225, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "THÔNG TIN VỀ LỚP";
            // 
            // lOPGridControl
            // 
            this.lOPGridControl.DataSource = this.bdsLop;
            this.lOPGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lOPGridControl.Location = new System.Drawing.Point(655, 383);
            this.lOPGridControl.MainView = this.gridView2;
            this.lOPGridControl.MenuManager = this.barManager1;
            this.lOPGridControl.Name = "lOPGridControl";
            this.lOPGridControl.Size = new System.Drawing.Size(639, 269);
            this.lOPGridControl.TabIndex = 10;
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
            // bdsSinhVien
            // 
            this.bdsSinhVien.DataMember = "FK_SINHVIEN_LOP";
            this.bdsSinhVien.DataSource = this.bdsLop;
            // 
            // bdsGiaoVien_DangKi
            // 
            this.bdsGiaoVien_DangKi.DataMember = "FK_GIAOVIEN_DANGKY_LOP";
            this.bdsGiaoVien_DangKi.DataSource = this.bdsLop;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThemLop,
            this.btnGhiLop,
            this.btnSuaLop,
            this.btnXoaLop,
            this.btnHoanTacLop,
            this.btnCancelLop});
            this.contextMenuStrip2.Name = "contextMenuStrip1";
            this.contextMenuStrip2.Size = new System.Drawing.Size(178, 196);
            this.contextMenuStrip2.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip2_Opening);
            // 
            // btnThemLop
            // 
            this.btnThemLop.Name = "btnThemLop";
            this.btnThemLop.Size = new System.Drawing.Size(177, 32);
            this.btnThemLop.Text = "THÊM LỚP";
            this.btnThemLop.Click += new System.EventHandler(this.btnThemLop_Click);
            // 
            // btnGhiLop
            // 
            this.btnGhiLop.Enabled = false;
            this.btnGhiLop.Name = "btnGhiLop";
            this.btnGhiLop.Size = new System.Drawing.Size(177, 32);
            this.btnGhiLop.Text = "GHI LỚP";
            this.btnGhiLop.Click += new System.EventHandler(this.btnGhiLop_Click);
            // 
            // btnSuaLop
            // 
            this.btnSuaLop.Name = "btnSuaLop";
            this.btnSuaLop.Size = new System.Drawing.Size(177, 32);
            this.btnSuaLop.Text = "SỬA LỚP";
            this.btnSuaLop.Click += new System.EventHandler(this.btnSuaLop_Click);
            // 
            // btnXoaLop
            // 
            this.btnXoaLop.Name = "btnXoaLop";
            this.btnXoaLop.Size = new System.Drawing.Size(177, 32);
            this.btnXoaLop.Text = "XÓA LỚP";
            this.btnXoaLop.Click += new System.EventHandler(this.btnXoaLop_Click);
            // 
            // btnHoanTacLop
            // 
            this.btnHoanTacLop.Name = "btnHoanTacLop";
            this.btnHoanTacLop.Size = new System.Drawing.Size(177, 32);
            this.btnHoanTacLop.Text = "HOÀN TÁC ";
            this.btnHoanTacLop.Click += new System.EventHandler(this.btnHoanTacLop_Click);
            // 
            // btnCancelLop
            // 
            this.btnCancelLop.Enabled = false;
            this.btnCancelLop.Name = "btnCancelLop";
            this.btnCancelLop.Size = new System.Drawing.Size(177, 32);
            this.btnCancelLop.Text = "CANCEL";
            this.btnCancelLop.Click += new System.EventHandler(this.btnCancelLop_Click);
            // 
            // frmKhoaAndLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 672);
            this.ContextMenuStrip = this.contextMenuStrip2;
            this.Controls.Add(this.lOPGridControl);
            this.Controls.Add(this.panelControl4);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.kHOAGridControl);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmKhoaAndLop";
            this.Text = "frmKhoaAndLop";
            this.Load += new System.EventHandler(this.frmKhoaAndLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKHOA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOAGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            this.panelLop.ResumeLayout(false);
            this.panelLop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).EndInit();
            this.panelKhoa.ResumeLayout(false);
            this.panelKhoa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGiangVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOPGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGiaoVien_DangKi)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnTHEM_KHOA;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnSuaKhoa;
        private DevExpress.XtraBars.BarButtonItem btnGHI_KHOA;
        private DevExpress.XtraBars.BarButtonItem btnXOA_KHOA;
        private DevExpress.XtraBars.BarButtonItem btnCancelKhoa;
        private DevExpress.XtraBars.BarButtonItem btnHOANTAC_KHOA;
        private DevExpress.XtraBars.BarButtonItem btnLAMMOI_KHOA;
        private DevExpress.XtraBars.BarButtonItem btnTHOAT;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cmbCoSo;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource bdsKHOA;
        private DataSet dataSet;
        private DataSetTableAdapters.KHOATableAdapter kHOATableAdapter;
        private DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl kHOAGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENKH;
        private DevExpress.XtraGrid.Columns.GridColumn colMACS;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelLop;
        private System.Windows.Forms.Panel panelKhoa;
        private System.Windows.Forms.TextBox txtTenKhoa;
        private System.Windows.Forms.TextBox txtMaKhoa;
        private System.Windows.Forms.Label label5;
        private DataSetTableAdapters.GIAOVIENTableAdapter gIAOVIENTableAdapter;
        private System.Windows.Forms.BindingSource bdsGiangVien;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private System.Windows.Forms.Label label6;
        private DataSetTableAdapters.LOPTableAdapter lOPTableAdapter;
        private System.Windows.Forms.BindingSource bdsLop;
        private DevExpress.XtraGrid.GridControl lOPGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private DevExpress.XtraGrid.Columns.GridColumn colTENLOP;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH1;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.TextBox txtMaLop;
        private DataSetTableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private System.Windows.Forms.BindingSource bdsSinhVien;
        private DataSetTableAdapters.GIAOVIEN_DANGKYTableAdapter gIAOVIEN_DANGKYTableAdapter;
        private System.Windows.Forms.BindingSource bdsGiaoVien_DangKi;
        private System.Windows.Forms.TextBox txtMaCS;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem btnThemLop;
        private System.Windows.Forms.ToolStripMenuItem btnGhiLop;
        private System.Windows.Forms.ToolStripMenuItem btnSuaLop;
        private System.Windows.Forms.ToolStripMenuItem btnXoaLop;
        private System.Windows.Forms.ToolStripMenuItem btnHoanTacLop;
        private System.Windows.Forms.ToolStripMenuItem btnCancelLop;
    }
}