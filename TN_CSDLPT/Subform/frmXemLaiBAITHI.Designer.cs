namespace TN_CSDLPT.Subform
{
    partial class frmXemLaiBAITHI
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
            this.cT_BAITHIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cT_BAITHITableAdapter = new TN_CSDLPT.DataSetTableAdapters.CT_BAITHITableAdapter();
            this.tableAdapterManager = new TN_CSDLPT.DataSetTableAdapters.TableAdapterManager();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMaSV = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTraCuuBaiThi = new System.Windows.Forms.DataGridView();
            this.cbbMonHoc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbLanThi = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cT_BAITHIBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraCuuBaiThi)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cT_BAITHIBindingSource
            // 
            this.cT_BAITHIBindingSource.DataMember = "CT_BAITHI";
            this.cT_BAITHIBindingSource.DataSource = this.dataSet;
            // 
            // cT_BAITHITableAdapter
            // 
            this.cT_BAITHITableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BAITHITableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.CT_BAITHITableAdapter = this.cT_BAITHITableAdapter;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TN_CSDLPT.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.cbbLanThi);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cbbMonHoc);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtMaSV);
            this.panel1.Controls.Add(this.txtHoTen);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1054, 185);
            this.panel1.TabIndex = 0;
            // 
            // txtMaSV
            // 
            this.txtMaSV.AutoSize = true;
            this.txtMaSV.Location = new System.Drawing.Point(34, 115);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(113, 19);
            this.txtMaSV.TabIndex = 2;
            this.txtMaSV.Text = "Mã sinh viên : ";
            // 
            // txtHoTen
            // 
            this.txtHoTen.AutoSize = true;
            this.txtHoTen.Location = new System.Drawing.Point(38, 76);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(93, 19);
            this.txtHoTen.TabIndex = 1;
            this.txtHoTen.Text = "Họ và tên : ";
            this.txtHoTen.Click += new System.EventHandler(this.txtHoTen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "XEM LẠI BÀI THI";
            // 
            // dgvTraCuuBaiThi
            // 
            this.dgvTraCuuBaiThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTraCuuBaiThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTraCuuBaiThi.Location = new System.Drawing.Point(0, 185);
            this.dgvTraCuuBaiThi.Name = "dgvTraCuuBaiThi";
            this.dgvTraCuuBaiThi.RowHeadersWidth = 62;
            this.dgvTraCuuBaiThi.RowTemplate.Height = 28;
            this.dgvTraCuuBaiThi.Size = new System.Drawing.Size(1054, 392);
            this.dgvTraCuuBaiThi.TabIndex = 1;
            // 
            // cbbMonHoc
            // 
            this.cbbMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMonHoc.FormattingEnabled = true;
            this.cbbMonHoc.Location = new System.Drawing.Point(418, 74);
            this.cbbMonHoc.Name = "cbbMonHoc";
            this.cbbMonHoc.Size = new System.Drawing.Size(216, 27);
            this.cbbMonHoc.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 19);
            this.label3.TabIndex = 26;
            this.label3.Text = "MÔN HỌC :";
            // 
            // cbbLanThi
            // 
            this.cbbLanThi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLanThi.FormattingEnabled = true;
            this.cbbLanThi.Location = new System.Drawing.Point(839, 74);
            this.cbbLanThi.Name = "cbbLanThi";
            this.cbbLanThi.Size = new System.Drawing.Size(121, 27);
            this.cbbLanThi.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(753, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 19);
            this.label5.TabIndex = 28;
            this.label5.Text = "LẦN THI :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(546, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 45);
            this.button1.TabIndex = 30;
            this.button1.Text = "XEM LẠI BÀI THI";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmXemLaiBAITHI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 577);
            this.Controls.Add(this.dgvTraCuuBaiThi);
            this.Controls.Add(this.panel1);
            this.Name = "frmXemLaiBAITHI";
            this.Text = "frmXemLaiBAITHI";
            this.Load += new System.EventHandler(this.frmXemLaiBAITHI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cT_BAITHIBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraCuuBaiThi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataSet dataSet;
        private System.Windows.Forms.BindingSource cT_BAITHIBindingSource;
        private DataSetTableAdapters.CT_BAITHITableAdapter cT_BAITHITableAdapter;
        private DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtHoTen;
        private System.Windows.Forms.Label txtMaSV;
        private System.Windows.Forms.DataGridView dgvTraCuuBaiThi;
        private System.Windows.Forms.ComboBox cbbMonHoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbLanThi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}