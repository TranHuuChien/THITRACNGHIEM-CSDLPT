namespace TN_CSDLPT
{
    partial class frmDangNhap
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cbx_CoSo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_DangNhap = new System.Windows.Forms.Button();
            this.radioButtonGiangVien = new System.Windows.Forms.RadioButton();
            this.radioButtonSinhVien = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÀI KHOẢN";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(201, 83);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(262, 27);
            this.txtTaiKhoan.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "MẬT KHẨU";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(201, 144);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(262, 27);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // cbx_CoSo
            // 
            this.cbx_CoSo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_CoSo.FormattingEnabled = true;
            this.cbx_CoSo.Location = new System.Drawing.Point(201, 17);
            this.cbx_CoSo.Name = "cbx_CoSo";
            this.cbx_CoSo.Size = new System.Drawing.Size(262, 27);
            this.cbx_CoSo.TabIndex = 4;
            this.cbx_CoSo.SelectedIndexChanged += new System.EventHandler(this.cbx_CoSo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "CƠ SỞ";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cbx_CoSo);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.txtPassword);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.txtTaiKhoan);
            this.panelControl1.Location = new System.Drawing.Point(122, 66);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(538, 202);
            this.panelControl1.TabIndex = 6;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(427, 297);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(158, 51);
            this.btn_Thoat.TabIndex = 7;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.Location = new System.Drawing.Point(179, 297);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(142, 51);
            this.btn_DangNhap.TabIndex = 8;
            this.btn_DangNhap.Text = "Đăng Nhập";
            this.btn_DangNhap.UseVisualStyleBackColor = true;
            this.btn_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click);
            // 
            // radioButtonGiangVien
            // 
            this.radioButtonGiangVien.AutoSize = true;
            this.radioButtonGiangVien.Checked = true;
            this.radioButtonGiangVien.Location = new System.Drawing.Point(223, 22);
            this.radioButtonGiangVien.Name = "radioButtonGiangVien";
            this.radioButtonGiangVien.Size = new System.Drawing.Size(111, 23);
            this.radioButtonGiangVien.TabIndex = 9;
            this.radioButtonGiangVien.TabStop = true;
            this.radioButtonGiangVien.Text = "Giảng Viên";
            this.radioButtonGiangVien.UseVisualStyleBackColor = true;
            // 
            // radioButtonSinhVien
            // 
            this.radioButtonSinhVien.AutoSize = true;
            this.radioButtonSinhVien.Location = new System.Drawing.Point(460, 22);
            this.radioButtonSinhVien.Name = "radioButtonSinhVien";
            this.radioButtonSinhVien.Size = new System.Drawing.Size(101, 23);
            this.radioButtonSinhVien.TabIndex = 10;
            this.radioButtonSinhVien.Text = "Sinh Viên";
            this.radioButtonSinhVien.UseVisualStyleBackColor = true;
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 402);
            this.Controls.Add(this.radioButtonSinhVien);
            this.Controls.Add(this.radioButtonGiangVien);
            this.Controls.Add(this.btn_DangNhap);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmDangNhap";
            this.Text = "ĐăngNhập";
            this.Load += new System.EventHandler(this.ĐăngNhập_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox cbx_CoSo;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_DangNhap;
        private System.Windows.Forms.RadioButton radioButtonGiangVien;
        private System.Windows.Forms.RadioButton radioButtonSinhVien;
    }
}