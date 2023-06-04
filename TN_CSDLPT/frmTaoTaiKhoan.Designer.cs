namespace TN_CSDLPT
{
    partial class frmTaoTaiKhoan
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtXacNhanMatKhau = new System.Windows.Forms.TextBox();
            this.btnChonGiangVien = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtMaGiangVien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLoginName = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cmbQuyen = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(334, 43);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(235, 39);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "TẠO TÀI KHOẢN";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(137, 119);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(119, 19);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "MÃ GIẢNG VIÊN";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(137, 232);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(80, 19);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "MẬT KHẨU";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(137, 292);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(164, 19);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "XÁC NHẬN MẬT KHẨU";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(324, 229);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(226, 27);
            this.txtMatKhau.TabIndex = 5;
            this.txtMatKhau.Validating += new System.ComponentModel.CancelEventHandler(this.txtMatKhau_Validating);
            // 
            // txtXacNhanMatKhau
            // 
            this.txtXacNhanMatKhau.Location = new System.Drawing.Point(324, 284);
            this.txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
            this.txtXacNhanMatKhau.Size = new System.Drawing.Size(226, 27);
            this.txtXacNhanMatKhau.TabIndex = 6;
            this.txtXacNhanMatKhau.Validating += new System.ComponentModel.CancelEventHandler(this.txtXacNhanMatKhau_Validating);
            // 
            // btnChonGiangVien
            // 
            this.btnChonGiangVien.Location = new System.Drawing.Point(656, 117);
            this.btnChonGiangVien.Name = "btnChonGiangVien";
            this.btnChonGiangVien.Size = new System.Drawing.Size(180, 46);
            this.btnChonGiangVien.TabIndex = 7;
            this.btnChonGiangVien.Text = "CHỌN GIẢNG VIÊN";
            this.btnChonGiangVien.UseVisualStyleBackColor = true;
            this.btnChonGiangVien.Click += new System.EventHandler(this.btnChonGiangVien_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnXacNhan.Location = new System.Drawing.Point(253, 432);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(127, 52);
            this.btnXacNhan.TabIndex = 8;
            this.btnXacNhan.Text = "XÁC NHẬN";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Turquoise;
            this.btnCancel.Location = new System.Drawing.Point(550, 432);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(136, 52);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtMaGiangVien
            // 
            this.txtMaGiangVien.Enabled = false;
            this.txtMaGiangVien.Location = new System.Drawing.Point(324, 117);
            this.txtMaGiangVien.Name = "txtMaGiangVien";
            this.txtMaGiangVien.Size = new System.Drawing.Size(226, 27);
            this.txtMaGiangVien.TabIndex = 10;
            this.txtMaGiangVien.Validating += new System.ComponentModel.CancelEventHandler(this.txtMaGiangVien_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "LOGIN NAME";
            // 
            // txtLoginName
            // 
            this.txtLoginName.Location = new System.Drawing.Point(324, 176);
            this.txtLoginName.Name = "txtLoginName";
            this.txtLoginName.Size = new System.Drawing.Size(226, 27);
            this.txtLoginName.TabIndex = 12;
            this.txtLoginName.Validating += new System.ComponentModel.CancelEventHandler(this.txtLoginName_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(147, 338);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(55, 19);
            this.labelControl5.TabIndex = 13;
            this.labelControl5.Text = "ROLE : ";
            // 
            // cmbQuyen
            // 
            this.cmbQuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQuyen.FormattingEnabled = true;
            this.cmbQuyen.Location = new System.Drawing.Point(324, 328);
            this.cmbQuyen.Name = "cmbQuyen";
            this.cmbQuyen.Size = new System.Drawing.Size(226, 27);
            this.cmbQuyen.TabIndex = 14;
            this.cmbQuyen.SelectedIndexChanged += new System.EventHandler(this.cmbQuyen_SelectedIndexChanged);
            // 
            // frmTaoTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 549);
            this.Controls.Add(this.cmbQuyen);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtLoginName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaGiangVien);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.btnChonGiangVien);
            this.Controls.Add(this.txtXacNhanMatKhau);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmTaoTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTaoTaiKhoan";
            this.Load += new System.EventHandler(this.frmTaoTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtXacNhanMatKhau;
        private System.Windows.Forms.Button btnChonGiangVien;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtMaGiangVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLoginName;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.ComboBox cmbQuyen;
    }
}