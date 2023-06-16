namespace TN_CSDLPT
{
    partial class MonHocForm
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
            System.Windows.Forms.Label mAMHLabel;
            System.Windows.Forms.Label tENMHLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonHocForm));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnTHEM = new DevExpress.XtraBars.BarButtonItem();
            this.btnXOA = new DevExpress.XtraBars.BarButtonItem();
            this.btnGHI = new DevExpress.XtraBars.BarButtonItem();
            this.btnSUA = new DevExpress.XtraBars.BarButtonItem();
            this.btnCANCEL = new DevExpress.XtraBars.BarButtonItem();
            this.btnLAMMOI = new DevExpress.XtraBars.BarButtonItem();
            this.btnHOANTAC = new DevExpress.XtraBars.BarButtonItem();
            this.btnTHOAT = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cmbCoSo = new System.Windows.Forms.ComboBox();
            this.labelCoSo = new System.Windows.Forms.Label();
            this.DataSet = new TN_CSDLPT.DataSet();
            this.bdsMONHOC = new System.Windows.Forms.BindingSource(this.components);
            this.mONHOCTableAdapter = new TN_CSDLPT.DataSetTableAdapters.MONHOCTableAdapter();
            this.tableAdapterManager = new TN_CSDLPT.DataSetTableAdapters.TableAdapterManager();
            this.bAITHITableAdapter = new TN_CSDLPT.DataSetTableAdapters.BAITHITableAdapter();
            this.bODETableAdapter = new TN_CSDLPT.DataSetTableAdapters.BODETableAdapter();
            this.gIAOVIEN_DANGKYTableAdapter = new TN_CSDLPT.DataSetTableAdapters.GIAOVIEN_DANGKYTableAdapter();
            this.gcMonHoc = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelNhapLieu = new DevExpress.XtraEditors.PanelControl();
            this.txtTenMonHoc = new System.Windows.Forms.TextBox();
            this.txtMaMonHoc = new System.Windows.Forms.TextBox();
            this.bdsGIAOVIEN_DANGKI = new System.Windows.Forms.BindingSource(this.components);
            this.bdsBODE = new System.Windows.Forms.BindingSource(this.components);
            this.bdsBAITHI = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            mAMHLabel = new System.Windows.Forms.Label();
            tENMHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMONHOC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelNhapLieu)).BeginInit();
            this.panelNhapLieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGIAOVIEN_DANGKI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBODE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBAITHI)).BeginInit();
            this.SuspendLayout();
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Location = new System.Drawing.Point(237, 83);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(126, 19);
            mAMHLabel.TabIndex = 0;
            mAMHLabel.Text = "MÃ MÔN HỌC : ";
            // 
            // tENMHLabel
            // 
            tENMHLabel.AutoSize = true;
            tENMHLabel.Location = new System.Drawing.Point(574, 80);
            tENMHLabel.Name = "tENMHLabel";
            tENMHLabel.Size = new System.Drawing.Size(128, 19);
            tENMHLabel.TabIndex = 2;
            tENMHLabel.Text = "TÊN MÔN HỌC :";
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
            this.btnGHI,
            this.btnLAMMOI,
            this.btnHOANTAC,
            this.btnTHOAT,
            this.btnSUA,
            this.btnCANCEL});
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGHI, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSUA, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnCANCEL, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLAMMOI, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHOANTAC, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnTHOAT, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
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
            // btnGHI
            // 
            this.btnGHI.Caption = "GHI";
            this.btnGHI.Enabled = false;
            this.btnGHI.Id = 2;
            this.btnGHI.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGHI.ImageOptions.SvgImage")));
            this.btnGHI.Name = "btnGHI";
            this.btnGHI.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGHI_ItemClick);
            // 
            // btnSUA
            // 
            this.btnSUA.Caption = "SỬA";
            this.btnSUA.Id = 6;
            this.btnSUA.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSUA.ImageOptions.Image")));
            this.btnSUA.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSUA.ImageOptions.LargeImage")));
            this.btnSUA.Name = "btnSUA";
            this.btnSUA.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSUA_ItemClick);
            // 
            // btnCANCEL
            // 
            this.btnCANCEL.Caption = "CANCEL";
            this.btnCANCEL.Enabled = false;
            this.btnCANCEL.Id = 7;
            this.btnCANCEL.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCANCEL.ImageOptions.Image")));
            this.btnCANCEL.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCANCEL.ImageOptions.LargeImage")));
            this.btnCANCEL.Name = "btnCANCEL";
            this.btnCANCEL.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCANCEL_ItemClick);
            // 
            // btnLAMMOI
            // 
            this.btnLAMMOI.Caption = "LÀM MỚI";
            this.btnLAMMOI.Id = 3;
            this.btnLAMMOI.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLAMMOI.ImageOptions.SvgImage")));
            this.btnLAMMOI.Name = "btnLAMMOI";
            this.btnLAMMOI.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLAMMOI_ItemClick);
            // 
            // btnHOANTAC
            // 
            this.btnHOANTAC.Caption = "HOÀN TÁC";
            this.btnHOANTAC.Id = 4;
            this.btnHOANTAC.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHOANTAC.ImageOptions.SvgImage")));
            this.btnHOANTAC.Name = "btnHOANTAC";
            this.btnHOANTAC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHOANTAC_ItemClick_1);
            // 
            // btnTHOAT
            // 
            this.btnTHOAT.Caption = "THOÁT";
            this.btnTHOAT.Id = 5;
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
            this.barDockControlTop.Size = new System.Drawing.Size(1257, 55);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 663);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1257, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 55);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 608);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1257, 55);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 608);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cmbCoSo);
            this.panelControl1.Controls.Add(this.labelCoSo);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 55);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1257, 64);
            this.panelControl1.TabIndex = 4;
            // 
            // cmbCoSo
            // 
            this.cmbCoSo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCoSo.FormattingEnabled = true;
            this.cmbCoSo.Location = new System.Drawing.Point(150, 16);
            this.cmbCoSo.Name = "cmbCoSo";
            this.cmbCoSo.Size = new System.Drawing.Size(236, 27);
            this.cmbCoSo.TabIndex = 1;
            this.cmbCoSo.SelectedIndexChanged += new System.EventHandler(this.cmbCoSo_SelectedIndexChanged);
            // 
            // labelCoSo
            // 
            this.labelCoSo.AutoSize = true;
            this.labelCoSo.Location = new System.Drawing.Point(71, 16);
            this.labelCoSo.Name = "labelCoSo";
            this.labelCoSo.Size = new System.Drawing.Size(73, 19);
            this.labelCoSo.TabIndex = 0;
            this.labelCoSo.Text = "CƠ SỞ : ";
            // 
            // DataSet
            // 
            this.DataSet.DataSetName = "DataSet";
            this.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsMONHOC
            // 
            this.bdsMONHOC.DataMember = "MONHOC";
            this.bdsMONHOC.DataSource = this.DataSet;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BAITHITableAdapter = this.bAITHITableAdapter;
            this.tableAdapterManager.BODETableAdapter = this.bODETableAdapter;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.CT_BAITHITableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = this.gIAOVIEN_DANGKYTableAdapter;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = this.mONHOCTableAdapter;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TN_CSDLPT.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bAITHITableAdapter
            // 
            this.bAITHITableAdapter.ClearBeforeFill = true;
            // 
            // bODETableAdapter
            // 
            this.bODETableAdapter.ClearBeforeFill = true;
            // 
            // gIAOVIEN_DANGKYTableAdapter
            // 
            this.gIAOVIEN_DANGKYTableAdapter.ClearBeforeFill = true;
            // 
            // gcMonHoc
            // 
            this.gcMonHoc.DataSource = this.bdsMONHOC;
            this.gcMonHoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcMonHoc.Location = new System.Drawing.Point(0, 119);
            this.gcMonHoc.MainView = this.gridView1;
            this.gcMonHoc.MenuManager = this.barManager1;
            this.gcMonHoc.Name = "gcMonHoc";
            this.gcMonHoc.Size = new System.Drawing.Size(1257, 337);
            this.gcMonHoc.TabIndex = 6;
            this.gcMonHoc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAMH,
            this.colTENMH});
            this.gridView1.GridControl = this.gcMonHoc;
            this.gridView1.Name = "gridView1";
            // 
            // colMAMH
            // 
            this.colMAMH.Caption = "MÃ MÔN HỌC";
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.MinWidth = 30;
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.OptionsColumn.AllowEdit = false;
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 0;
            this.colMAMH.Width = 112;
            // 
            // colTENMH
            // 
            this.colTENMH.Caption = "TÊN MÔN HỌC";
            this.colTENMH.FieldName = "TENMH";
            this.colTENMH.MinWidth = 30;
            this.colTENMH.Name = "colTENMH";
            this.colTENMH.OptionsColumn.AllowEdit = false;
            this.colTENMH.Visible = true;
            this.colTENMH.VisibleIndex = 1;
            this.colTENMH.Width = 112;
            // 
            // panelNhapLieu
            // 
            this.panelNhapLieu.Controls.Add(this.label1);
            this.panelNhapLieu.Controls.Add(tENMHLabel);
            this.panelNhapLieu.Controls.Add(this.txtTenMonHoc);
            this.panelNhapLieu.Controls.Add(mAMHLabel);
            this.panelNhapLieu.Controls.Add(this.txtMaMonHoc);
            this.panelNhapLieu.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panelNhapLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNhapLieu.Enabled = false;
            this.panelNhapLieu.Location = new System.Drawing.Point(0, 456);
            this.panelNhapLieu.Name = "panelNhapLieu";
            this.panelNhapLieu.Size = new System.Drawing.Size(1257, 207);
            this.panelNhapLieu.TabIndex = 7;
            // 
            // txtTenMonHoc
            // 
            this.txtTenMonHoc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsMONHOC, "TENMH", true));
            this.txtTenMonHoc.Location = new System.Drawing.Point(722, 77);
            this.txtTenMonHoc.Name = "txtTenMonHoc";
            this.txtTenMonHoc.Size = new System.Drawing.Size(220, 27);
            this.txtTenMonHoc.TabIndex = 3;
            // 
            // txtMaMonHoc
            // 
            this.txtMaMonHoc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsMONHOC, "MAMH", true));
            this.txtMaMonHoc.Location = new System.Drawing.Point(367, 78);
            this.txtMaMonHoc.Name = "txtMaMonHoc";
            this.txtMaMonHoc.Size = new System.Drawing.Size(180, 27);
            this.txtMaMonHoc.TabIndex = 1;
            // 
            // bdsGIAOVIEN_DANGKI
            // 
            this.bdsGIAOVIEN_DANGKI.DataMember = "FK_GIAOVIEN_DANGKY_MONHOC1";
            this.bdsGIAOVIEN_DANGKI.DataSource = this.bdsMONHOC;
            // 
            // bdsBODE
            // 
            this.bdsBODE.DataMember = "FK_BODE_MONHOC";
            this.bdsBODE.DataSource = this.bdsMONHOC;
            // 
            // bdsBAITHI
            // 
            this.bdsBAITHI.DataMember = "FK_BAITHI_MONHOC1";
            this.bdsBAITHI.DataSource = this.bdsMONHOC;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(408, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "THÔNG TIN MÔN HỌC";
            // 
            // MonHocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 683);
            this.Controls.Add(this.panelNhapLieu);
            this.Controls.Add(this.gcMonHoc);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "MonHocForm";
            this.Text = "MonHocForm";
            this.Load += new System.EventHandler(this.MonHocForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMONHOC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelNhapLieu)).EndInit();
            this.panelNhapLieu.ResumeLayout(false);
            this.panelNhapLieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGIAOVIEN_DANGKI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBODE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBAITHI)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem btnGHI;
        private DevExpress.XtraBars.BarButtonItem btnLAMMOI;
        private DevExpress.XtraBars.BarButtonItem btnHOANTAC;
        private DevExpress.XtraBars.BarButtonItem btnTHOAT;
        private System.Windows.Forms.BindingSource bdsMONHOC;
        private DataSet DataSet;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cmbCoSo;
        private System.Windows.Forms.Label labelCoSo;
        private DataSetTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.PanelControl panelNhapLieu;
        private DevExpress.XtraGrid.GridControl gcMonHoc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH;
        private System.Windows.Forms.TextBox txtTenMonHoc;
        private System.Windows.Forms.TextBox txtMaMonHoc;
        private DataSetTableAdapters.GIAOVIEN_DANGKYTableAdapter gIAOVIEN_DANGKYTableAdapter;
        private System.Windows.Forms.BindingSource bdsGIAOVIEN_DANGKI;
        private DataSetTableAdapters.BODETableAdapter bODETableAdapter;
        private System.Windows.Forms.BindingSource bdsBODE;
        private DataSetTableAdapters.BAITHITableAdapter bAITHITableAdapter;
        private System.Windows.Forms.BindingSource bdsBAITHI;
        private DevExpress.XtraBars.BarButtonItem btnSUA;
        private DevExpress.XtraBars.BarButtonItem btnCANCEL;
        private System.Windows.Forms.Label label1;
    }
}