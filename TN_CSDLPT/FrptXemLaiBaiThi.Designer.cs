namespace TN_CSDLPT
{
    partial class FrptXemLaiBaiThi
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
            System.Windows.Forms.Label tENMHLabel;
            this.cmbCoSo = new System.Windows.Forms.ComboBox();
            this.labelCoSo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbMaSV = new System.Windows.Forms.Label();
            this.dataSet = new TN_CSDLPT.DataSet();
            this.dS_MH_THITRACNGHIEMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_MH_THITRACNGHIEMTableAdapter = new TN_CSDLPT.DataSetTableAdapters.DS_MH_THITRACNGHIEMTableAdapter();
            this.tableAdapterManager = new TN_CSDLPT.DataSetTableAdapters.TableAdapterManager();
            this.cmbTenMonHoc = new System.Windows.Forms.ComboBox();
            this.cmbLanThi = new System.Windows.Forms.ComboBox();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnInFile = new System.Windows.Forms.Button();
            tENMHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_MH_THITRACNGHIEMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tENMHLabel
            // 
            tENMHLabel.AutoSize = true;
            tENMHLabel.Location = new System.Drawing.Point(403, 117);
            tENMHLabel.Name = "tENMHLabel";
            tENMHLabel.Size = new System.Drawing.Size(68, 19);
            tENMHLabel.TabIndex = 7;
            tENMHLabel.Text = "TENMH:";
            // 
            // cmbCoSo
            // 
            this.cmbCoSo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCoSo.FormattingEnabled = true;
            this.cmbCoSo.Location = new System.Drawing.Point(183, 41);
            this.cmbCoSo.Name = "cmbCoSo";
            this.cmbCoSo.Size = new System.Drawing.Size(236, 27);
            this.cmbCoSo.TabIndex = 3;
            this.cmbCoSo.SelectedIndexChanged += new System.EventHandler(this.cmbCoSo_SelectedIndexChanged);
            // 
            // labelCoSo
            // 
            this.labelCoSo.AutoSize = true;
            this.labelCoSo.Location = new System.Drawing.Point(104, 44);
            this.labelCoSo.Name = "labelCoSo";
            this.labelCoSo.Size = new System.Drawing.Size(73, 19);
            this.labelCoSo.TabIndex = 2;
            this.labelCoSo.Text = "CƠ SỞ : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(773, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Lần Thi";
            // 
            // lbMaSV
            // 
            this.lbMaSV.AutoSize = true;
            this.lbMaSV.Location = new System.Drawing.Point(108, 114);
            this.lbMaSV.Name = "lbMaSV";
            this.lbMaSV.Size = new System.Drawing.Size(117, 19);
            this.lbMaSV.TabIndex = 4;
            this.lbMaSV.Text = "Mã Sinh Viên : ";
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dS_MH_THITRACNGHIEMBindingSource
            // 
            this.dS_MH_THITRACNGHIEMBindingSource.DataMember = "DS_MH_THITRACNGHIEM";
            this.dS_MH_THITRACNGHIEMBindingSource.DataSource = this.dataSet;
            // 
            // dS_MH_THITRACNGHIEMTableAdapter
            // 
            this.dS_MH_THITRACNGHIEMTableAdapter.ClearBeforeFill = true;
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
            // cmbTenMonHoc
            // 
            this.cmbTenMonHoc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dS_MH_THITRACNGHIEMBindingSource, "TENMH", true));
            this.cmbTenMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTenMonHoc.FormattingEnabled = true;
            this.cmbTenMonHoc.Location = new System.Drawing.Point(477, 111);
            this.cmbTenMonHoc.Name = "cmbTenMonHoc";
            this.cmbTenMonHoc.Size = new System.Drawing.Size(212, 27);
            this.cmbTenMonHoc.TabIndex = 8;
            this.cmbTenMonHoc.SelectedIndexChanged += new System.EventHandler(this.cmbTenMonHoc_SelectedIndexChanged);
            // 
            // cmbLanThi
            // 
            this.cmbLanThi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLanThi.FormattingEnabled = true;
            this.cmbLanThi.Items.AddRange(new object[] {
            "LẦN 1",
            "LẦN 2"});
            this.cmbLanThi.Location = new System.Drawing.Point(871, 114);
            this.cmbLanThi.Name = "cmbLanThi";
            this.cmbLanThi.Size = new System.Drawing.Size(121, 27);
            this.cmbLanThi.TabIndex = 9;
            this.cmbLanThi.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(183, 251);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(132, 39);
            this.btnPreview.TabIndex = 10;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnInFile
            // 
            this.btnInFile.Location = new System.Drawing.Point(618, 251);
            this.btnInFile.Name = "btnInFile";
            this.btnInFile.Size = new System.Drawing.Size(131, 38);
            this.btnInFile.TabIndex = 11;
            this.btnInFile.Text = "In ra file";
            this.btnInFile.UseVisualStyleBackColor = true;
            this.btnInFile.Click += new System.EventHandler(this.btnInFile_Click);
            // 
            // FrptXemLaiBaiThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 365);
            this.Controls.Add(this.btnInFile);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.cmbLanThi);
            this.Controls.Add(tENMHLabel);
            this.Controls.Add(this.cmbTenMonHoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbMaSV);
            this.Controls.Add(this.cmbCoSo);
            this.Controls.Add(this.labelCoSo);
            this.Name = "FrptXemLaiBaiThi";
            this.Text = "XrptXemLaiBaiThi";
            this.Load += new System.EventHandler(this.XrptXemLaiBaiThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_MH_THITRACNGHIEMBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCoSo;
        private System.Windows.Forms.Label labelCoSo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbMaSV;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource dS_MH_THITRACNGHIEMBindingSource;
        private DataSetTableAdapters.DS_MH_THITRACNGHIEMTableAdapter dS_MH_THITRACNGHIEMTableAdapter;
        private DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cmbTenMonHoc;
        private System.Windows.Forms.ComboBox cmbLanThi;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnInFile;
    }
}