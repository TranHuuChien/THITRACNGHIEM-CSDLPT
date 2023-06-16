namespace TN_CSDLPT
{
    partial class FrptDanhSachDangKiTHI
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
            this.cmbCoSo = new System.Windows.Forms.ComboBox();
            this.labelCoSo = new System.Windows.Forms.Label();
            this.txtNgayBD = new DevExpress.XtraEditors.DateEdit();
            this.txtNgayKT = new DevExpress.XtraEditors.DateEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayBD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayBD.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayKT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayKT.Properties.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCoSo
            // 
            this.cmbCoSo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCoSo.FormattingEnabled = true;
            this.cmbCoSo.Location = new System.Drawing.Point(276, 109);
            this.cmbCoSo.Name = "cmbCoSo";
            this.cmbCoSo.Size = new System.Drawing.Size(236, 27);
            this.cmbCoSo.TabIndex = 15;
            // 
            // labelCoSo
            // 
            this.labelCoSo.AutoSize = true;
            this.labelCoSo.Location = new System.Drawing.Point(198, 115);
            this.labelCoSo.Name = "labelCoSo";
            this.labelCoSo.Size = new System.Drawing.Size(73, 19);
            this.labelCoSo.TabIndex = 14;
            this.labelCoSo.Text = "CƠ SỞ : ";
            // 
            // txtNgayBD
            // 
            this.txtNgayBD.EditValue = null;
            this.txtNgayBD.Location = new System.Drawing.Point(351, 174);
            this.txtNgayBD.Name = "txtNgayBD";
            this.txtNgayBD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgayBD.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgayBD.Size = new System.Drawing.Size(150, 26);
            this.txtNgayBD.TabIndex = 16;
            // 
            // txtNgayKT
            // 
            this.txtNgayKT.EditValue = null;
            this.txtNgayKT.Location = new System.Drawing.Point(354, 222);
            this.txtNgayKT.Name = "txtNgayKT";
            this.txtNgayKT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgayKT.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgayKT.Size = new System.Drawing.Size(150, 26);
            this.txtNgayKT.TabIndex = 17;
            
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "NGÀY BẮT ĐẦU : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "NGÀY KẾT THÚC :";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(193, 25);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(504, 34);
            this.labelControl1.TabIndex = 20;
            this.labelControl1.Text = "TRA CỨU DANH SÁCH ĐĂNG KÍ THI ";
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(164, 325);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(131, 41);
            this.btnPreview.TabIndex = 21;
            this.btnPreview.Text = "PREVIEW";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(515, 325);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(114, 41);
            this.btnThoat.TabIndex = 22;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // FrptDanhSachDangKiTHI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 435);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNgayKT);
            this.Controls.Add(this.txtNgayBD);
            this.Controls.Add(this.cmbCoSo);
            this.Controls.Add(this.labelCoSo);
            this.Name = "FrptDanhSachDangKiTHI";
            this.Text = "FrptDanhSachDangKiTHI";
            this.Load += new System.EventHandler(this.FrptDanhSachDangKiTHI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayBD.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayBD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayKT.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayKT.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCoSo;
        private System.Windows.Forms.Label labelCoSo;
        private DevExpress.XtraEditors.DateEdit txtNgayBD;
        private DevExpress.XtraEditors.DateEdit txtNgayKT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnThoat;
    }
}