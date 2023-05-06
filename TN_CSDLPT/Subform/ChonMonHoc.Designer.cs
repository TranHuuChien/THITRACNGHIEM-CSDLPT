namespace TN_CSDLPT.Subform
{
    partial class ChonMonHoc
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
            this.sP_LAYDANHSACH_MONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_LAYDANHSACH_MONHOCTableAdapter = new TN_CSDLPT.DataSetTableAdapters.SP_LAYDANHSACH_MONHOCTableAdapter();
            this.tableAdapterManager = new TN_CSDLPT.DataSetTableAdapters.TableAdapterManager();
            this.sP_LAYDANHSACH_MONHOCGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnTHOAT = new System.Windows.Forms.Button();
            this.btnCHON = new System.Windows.Forms.Button();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LAYDANHSACH_MONHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LAYDANHSACH_MONHOCGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sP_LAYDANHSACH_MONHOCBindingSource
            // 
            this.sP_LAYDANHSACH_MONHOCBindingSource.DataMember = "SP_LAYDANHSACH_MONHOC";
            this.sP_LAYDANHSACH_MONHOCBindingSource.DataSource = this.dataSet;
            // 
            // sP_LAYDANHSACH_MONHOCTableAdapter
            // 
            this.sP_LAYDANHSACH_MONHOCTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.SP_LAY_DS_LOP_THEO_KHOATableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TN_CSDLPT.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sP_LAYDANHSACH_MONHOCGridControl
            // 
            this.sP_LAYDANHSACH_MONHOCGridControl.DataSource = this.sP_LAYDANHSACH_MONHOCBindingSource;
            this.sP_LAYDANHSACH_MONHOCGridControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sP_LAYDANHSACH_MONHOCGridControl.Location = new System.Drawing.Point(0, 481);
            this.sP_LAYDANHSACH_MONHOCGridControl.MainView = this.gridView1;
            this.sP_LAYDANHSACH_MONHOCGridControl.Name = "sP_LAYDANHSACH_MONHOCGridControl";
            this.sP_LAYDANHSACH_MONHOCGridControl.Size = new System.Drawing.Size(794, 280);
            this.sP_LAYDANHSACH_MONHOCGridControl.TabIndex = 1;
            this.sP_LAYDANHSACH_MONHOCGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAMH,
            this.colTENMH});
            this.gridView1.GridControl = this.sP_LAYDANHSACH_MONHOCGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMAMH
            // 
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.MinWidth = 30;
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 0;
            this.colMAMH.Width = 112;
            // 
            // colTENMH
            // 
            this.colTENMH.FieldName = "TENMH";
            this.colTENMH.MinWidth = 30;
            this.colTENMH.Name = "colTENMH";
            this.colTENMH.Visible = true;
            this.colTENMH.VisibleIndex = 1;
            this.colTENMH.Width = 112;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnTHOAT);
            this.panelControl1.Controls.Add(this.btnCHON);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(794, 165);
            this.panelControl1.TabIndex = 2;
            // 
            // btnTHOAT
            // 
            this.btnTHOAT.Location = new System.Drawing.Point(448, 103);
            this.btnTHOAT.Name = "btnTHOAT";
            this.btnTHOAT.Size = new System.Drawing.Size(143, 37);
            this.btnTHOAT.TabIndex = 2;
            this.btnTHOAT.Text = "THOÁT";
            this.btnTHOAT.UseVisualStyleBackColor = true;
            this.btnTHOAT.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCHON
            // 
            this.btnCHON.Location = new System.Drawing.Point(146, 102);
            this.btnCHON.Name = "btnCHON";
            this.btnCHON.Size = new System.Drawing.Size(135, 38);
            this.btnCHON.TabIndex = 1;
            this.btnCHON.Text = "CHỌN";
            this.btnCHON.UseVisualStyleBackColor = true;
            this.btnCHON.Click += new System.EventHandler(this.btnCHON_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(146, 30);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(445, 53);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "DANH SÁCH MÔN HỌC";
            // 
            // ChonMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 761);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.sP_LAYDANHSACH_MONHOCGridControl);
            this.Name = "ChonMonHoc";
            this.Text = "ChonMonHoc";
            this.Load += new System.EventHandler(this.ChonMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LAYDANHSACH_MONHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LAYDANHSACH_MONHOCGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataSet dataSet;
        private System.Windows.Forms.BindingSource sP_LAYDANHSACH_MONHOCBindingSource;
        private DataSetTableAdapters.SP_LAYDANHSACH_MONHOCTableAdapter sP_LAYDANHSACH_MONHOCTableAdapter;
        private DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl sP_LAYDANHSACH_MONHOCGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH;
        private System.Windows.Forms.Button btnCHON;
        private System.Windows.Forms.Button btnTHOAT;
    }
}