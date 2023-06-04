namespace TN_CSDLPT.Subform
{
    partial class frmDsKhongCoTK
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataSet = new TN_CSDLPT.DataSet();
            this.sP_DS_NHANVIEN_KHONG_TAI_KHOANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_DS_NHANVIEN_KHONG_TAI_KHOANTableAdapter = new TN_CSDLPT.DataSetTableAdapters.SP_DS_NHANVIEN_KHONG_TAI_KHOANTableAdapter();
            this.tableAdapterManager = new TN_CSDLPT.DataSetTableAdapters.TableAdapterManager();
            this.sP_DS_NHANVIEN_KHONG_TAI_KHOAN1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_DS_NHANVIEN_KHONG_TAI_KHOAN1TableAdapter = new TN_CSDLPT.DataSetTableAdapters.SP_DS_NHANVIEN_KHONG_TAI_KHOAN1TableAdapter();
            this.sP_DS_NHANVIEN_KHONG_TAI_KHOAN1GridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnChon = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DS_NHANVIEN_KHONG_TAI_KHOANBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DS_NHANVIEN_KHONG_TAI_KHOAN1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DS_NHANVIEN_KHONG_TAI_KHOAN1GridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(927, 79);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(305, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH KHÔNG CÓ TÀI KHOẢN";
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sP_DS_NHANVIEN_KHONG_TAI_KHOANBindingSource
            // 
            this.sP_DS_NHANVIEN_KHONG_TAI_KHOANBindingSource.DataMember = "SP_DS_NHANVIEN_KHONG_TAI_KHOAN";
            this.sP_DS_NHANVIEN_KHONG_TAI_KHOANBindingSource.DataSource = this.dataSet;
            // 
            // sP_DS_NHANVIEN_KHONG_TAI_KHOANTableAdapter
            // 
            this.sP_DS_NHANVIEN_KHONG_TAI_KHOANTableAdapter.ClearBeforeFill = true;
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
            // sP_DS_NHANVIEN_KHONG_TAI_KHOAN1BindingSource
            // 
            this.sP_DS_NHANVIEN_KHONG_TAI_KHOAN1BindingSource.DataMember = "SP_DS_NHANVIEN_KHONG_TAI_KHOAN1";
            this.sP_DS_NHANVIEN_KHONG_TAI_KHOAN1BindingSource.DataSource = this.dataSet;
            // 
            // sP_DS_NHANVIEN_KHONG_TAI_KHOAN1TableAdapter
            // 
            this.sP_DS_NHANVIEN_KHONG_TAI_KHOAN1TableAdapter.ClearBeforeFill = true;
            // 
            // sP_DS_NHANVIEN_KHONG_TAI_KHOAN1GridControl
            // 
            this.sP_DS_NHANVIEN_KHONG_TAI_KHOAN1GridControl.DataSource = this.sP_DS_NHANVIEN_KHONG_TAI_KHOAN1BindingSource;
            this.sP_DS_NHANVIEN_KHONG_TAI_KHOAN1GridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.sP_DS_NHANVIEN_KHONG_TAI_KHOAN1GridControl.Location = new System.Drawing.Point(0, 79);
            this.sP_DS_NHANVIEN_KHONG_TAI_KHOAN1GridControl.MainView = this.gridView1;
            this.sP_DS_NHANVIEN_KHONG_TAI_KHOAN1GridControl.Name = "sP_DS_NHANVIEN_KHONG_TAI_KHOAN1GridControl";
            this.sP_DS_NHANVIEN_KHONG_TAI_KHOAN1GridControl.Size = new System.Drawing.Size(927, 262);
            this.sP_DS_NHANVIEN_KHONG_TAI_KHOAN1GridControl.TabIndex = 1;
            this.sP_DS_NHANVIEN_KHONG_TAI_KHOAN1GridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAGV,
            this.colHO,
            this.colTEN});
            this.gridView1.GridControl = this.sP_DS_NHANVIEN_KHONG_TAI_KHOAN1GridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMAGV
            // 
            this.colMAGV.Caption = "MÃ GIẢNG VIÊN";
            this.colMAGV.FieldName = "MAGV";
            this.colMAGV.MinWidth = 30;
            this.colMAGV.Name = "colMAGV";
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
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            this.colHO.Width = 112;
            // 
            // colTEN
            // 
            this.colTEN.Caption = "TÊN";
            this.colTEN.FieldName = "TEN";
            this.colTEN.MinWidth = 30;
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            this.colTEN.Width = 112;
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(201, 376);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(111, 44);
            this.btnChon.TabIndex = 2;
            this.btnChon.Text = "CHỌN";
            this.btnChon.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(470, 376);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(92, 44);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // frmDsKhongCoTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 505);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.sP_DS_NHANVIEN_KHONG_TAI_KHOAN1GridControl);
            this.Controls.Add(this.panel1);
            this.Name = "frmDsKhongCoTK";
            this.Text = "frmDsKhongCoTK";
            this.Load += new System.EventHandler(this.frmDsKhongCoTK_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DS_NHANVIEN_KHONG_TAI_KHOANBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DS_NHANVIEN_KHONG_TAI_KHOAN1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DS_NHANVIEN_KHONG_TAI_KHOAN1GridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource sP_DS_NHANVIEN_KHONG_TAI_KHOANBindingSource;
        private DataSetTableAdapters.SP_DS_NHANVIEN_KHONG_TAI_KHOANTableAdapter sP_DS_NHANVIEN_KHONG_TAI_KHOANTableAdapter;
        private DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource sP_DS_NHANVIEN_KHONG_TAI_KHOAN1BindingSource;
        private DataSetTableAdapters.SP_DS_NHANVIEN_KHONG_TAI_KHOAN1TableAdapter sP_DS_NHANVIEN_KHONG_TAI_KHOAN1TableAdapter;
        private DevExpress.XtraGrid.GridControl sP_DS_NHANVIEN_KHONG_TAI_KHOAN1GridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Button btnChon;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private System.Windows.Forms.Button btnThoat;
    }
}