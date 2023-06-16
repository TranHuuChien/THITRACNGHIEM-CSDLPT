namespace TN_CSDLPT.Subform
{
    partial class frmChonLop
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
            this.dataSet = new TN_CSDLPT.DataSet();
            this.sP_LAY_DANH_SACH_LOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_LAY_DANH_SACH_LOPTableAdapter = new TN_CSDLPT.DataSetTableAdapters.SP_LAY_DANH_SACH_LOPTableAdapter();
            this.tableAdapterManager = new TN_CSDLPT.DataSetTableAdapters.TableAdapterManager();
            this.sP_LAY_DANH_SACH_LOPGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENLOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnChon = new System.Windows.Forms.Button();
            this.cmbCoSo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LAY_DANH_SACH_LOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LAY_DANH_SACH_LOPGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sP_LAY_DANH_SACH_LOPBindingSource
            // 
            this.sP_LAY_DANH_SACH_LOPBindingSource.DataMember = "SP_LAY_DANH_SACH_LOP";
            this.sP_LAY_DANH_SACH_LOPBindingSource.DataSource = this.dataSet;
            // 
            // sP_LAY_DANH_SACH_LOPTableAdapter
            // 
            this.sP_LAY_DANH_SACH_LOPTableAdapter.ClearBeforeFill = true;
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
            // sP_LAY_DANH_SACH_LOPGridControl
            // 
            this.sP_LAY_DANH_SACH_LOPGridControl.DataSource = this.sP_LAY_DANH_SACH_LOPBindingSource;
            this.sP_LAY_DANH_SACH_LOPGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.sP_LAY_DANH_SACH_LOPGridControl.Location = new System.Drawing.Point(0, 0);
            this.sP_LAY_DANH_SACH_LOPGridControl.MainView = this.gridView1;
            this.sP_LAY_DANH_SACH_LOPGridControl.Name = "sP_LAY_DANH_SACH_LOPGridControl";
            this.sP_LAY_DANH_SACH_LOPGridControl.Size = new System.Drawing.Size(1178, 346);
            this.sP_LAY_DANH_SACH_LOPGridControl.TabIndex = 2;
            this.sP_LAY_DANH_SACH_LOPGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALOP,
            this.colTENLOP,
            this.colMAKH});
            this.gridView1.GridControl = this.sP_LAY_DANH_SACH_LOPGridControl;
            this.gridView1.Name = "gridView1";
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
            // colMAKH
            // 
            this.colMAKH.Caption = "MÃ KHOA";
            this.colMAKH.FieldName = "MAKH";
            this.colMAKH.MinWidth = 30;
            this.colMAKH.Name = "colMAKH";
            this.colMAKH.OptionsColumn.AllowEdit = false;
            this.colMAKH.Visible = true;
            this.colMAKH.VisibleIndex = 2;
            this.colMAKH.Width = 112;
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(282, 380);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(153, 51);
            this.btnChon.TabIndex = 3;
            this.btnChon.Text = "CHỌN";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click_1);
            // 
            // cmbCoSo
            // 
            this.cmbCoSo.FormattingEnabled = true;
            this.cmbCoSo.Location = new System.Drawing.Point(732, 402);
            this.cmbCoSo.Name = "cmbCoSo";
            this.cmbCoSo.Size = new System.Drawing.Size(121, 27);
            this.cmbCoSo.TabIndex = 4;
            // 
            // frmChonLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 532);
            this.Controls.Add(this.cmbCoSo);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.sP_LAY_DANH_SACH_LOPGridControl);
            this.Name = "frmChonLop";
            this.Text = "frmChonLop";
            this.Load += new System.EventHandler(this.frmChonLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LAY_DANH_SACH_LOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LAY_DANH_SACH_LOPGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource sP_LAY_DANH_SACH_LOPBindingSource;
        private DataSetTableAdapters.SP_LAY_DANH_SACH_LOPTableAdapter sP_LAY_DANH_SACH_LOPTableAdapter;
        private DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl sP_LAY_DANH_SACH_LOPGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private DevExpress.XtraGrid.Columns.GridColumn colTENLOP;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.ComboBox cmbCoSo;
    }
}