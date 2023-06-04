namespace TN_CSDLPT
{
    partial class frmEXAM
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.listCauHoi = new System.Windows.Forms.ListBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtThoiGian = new System.Windows.Forms.TextBox();
            this.btnLayDeThi = new System.Windows.Forms.Button();
            this.cbbMonHoc = new System.Windows.Forms.ComboBox();
            this.ngaythi = new DevExpress.XtraEditors.DateEdit();
            this.cbbLanThi = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbHoTen = new DevExpress.XtraEditors.LabelControl();
            this.lbTenLop = new System.Windows.Forms.Label();
            this.lbMaLop = new System.Windows.Forms.Label();
            this.pcHienThiChiTietCauHoi = new System.Windows.Forms.Panel();
            this.btnFinshTest = new System.Windows.Forms.Button();
            this.Answer1 = new System.Windows.Forms.RadioButton();
            this.Answer4 = new System.Windows.Forms.RadioButton();
            this.Answer3 = new System.Windows.Forms.RadioButton();
            this.Answer2 = new System.Windows.Forms.RadioButton();
            this.Cauhoi = new DevExpress.XtraEditors.LabelControl();
            this.ContentQuestion = new System.Windows.Forms.RichTextBox();
            this.btnCauCuoi = new System.Windows.Forms.Button();
            this.btnCauSau = new System.Windows.Forms.Button();
            this.btnCauTrc = new System.Windows.Forms.Button();
            this.btnCauDau = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ngaythi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngaythi.Properties.CalendarTimeProperties)).BeginInit();
            this.pcHienThiChiTietCauHoi.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.listCauHoi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 677);
            this.panel1.TabIndex = 6;
            // 
            // listCauHoi
            // 
            this.listCauHoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.listCauHoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listCauHoi.FormattingEnabled = true;
            this.listCauHoi.ItemHeight = 19;
            this.listCauHoi.Location = new System.Drawing.Point(0, 0);
            this.listCauHoi.Name = "listCauHoi";
            this.listCauHoi.Size = new System.Drawing.Size(299, 677);
            this.listCauHoi.TabIndex = 0;
            this.listCauHoi.SelectedIndexChanged += new System.EventHandler(this.listCauHoi_SelectedIndexChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtThoiGian);
            this.panel4.Controls.Add(this.btnLayDeThi);
            this.panel4.Controls.Add(this.cbbMonHoc);
            this.panel4.Controls.Add(this.ngaythi);
            this.panel4.Controls.Add(this.cbbLanThi);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.lbHoTen);
            this.panel4.Controls.Add(this.lbTenLop);
            this.panel4.Controls.Add(this.lbMaLop);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(299, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1384, 168);
            this.panel4.TabIndex = 8;
            // 
            // txtThoiGian
            // 
            this.txtThoiGian.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThoiGian.Location = new System.Drawing.Point(1151, 37);
            this.txtThoiGian.Name = "txtThoiGian";
            this.txtThoiGian.Size = new System.Drawing.Size(123, 56);
            this.txtThoiGian.TabIndex = 27;
            this.txtThoiGian.Text = "10:10";
            // 
            // btnLayDeThi
            // 
            this.btnLayDeThi.BackColor = System.Drawing.Color.Green;
            this.btnLayDeThi.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLayDeThi.Location = new System.Drawing.Point(886, 102);
            this.btnLayDeThi.Name = "btnLayDeThi";
            this.btnLayDeThi.Size = new System.Drawing.Size(116, 45);
            this.btnLayDeThi.TabIndex = 26;
            this.btnLayDeThi.Text = "LẤY ĐỀ";
            this.btnLayDeThi.UseVisualStyleBackColor = false;
            this.btnLayDeThi.Click += new System.EventHandler(this.btnLayDeThi_Click);
            // 
            // cbbMonHoc
            // 
            this.cbbMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMonHoc.FormattingEnabled = true;
            this.cbbMonHoc.Location = new System.Drawing.Point(683, 12);
            this.cbbMonHoc.Name = "cbbMonHoc";
            this.cbbMonHoc.Size = new System.Drawing.Size(216, 27);
            this.cbbMonHoc.TabIndex = 25;
            // 
            // ngaythi
            // 
            this.ngaythi.EditValue = null;
            this.ngaythi.Location = new System.Drawing.Point(683, 64);
            this.ngaythi.Name = "ngaythi";
            this.ngaythi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngaythi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngaythi.Size = new System.Drawing.Size(150, 26);
            this.ngaythi.TabIndex = 24;
            // 
            // cbbLanThi
            // 
            this.cbbLanThi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLanThi.FormattingEnabled = true;
            this.cbbLanThi.Location = new System.Drawing.Point(683, 120);
            this.cbbLanThi.Name = "cbbLanThi";
            this.cbbLanThi.Size = new System.Drawing.Size(121, 27);
            this.cbbLanThi.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(597, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 19);
            this.label5.TabIndex = 22;
            this.label5.Text = "LẦN THI :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(584, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 19);
            this.label4.TabIndex = 21;
            this.label4.Text = "NGÀY THI : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(584, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 19);
            this.label3.TabIndex = 20;
            this.label3.Text = "MÔN HỌC :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "THÔNG TIN THÍ SINH";
            // 
            // lbHoTen
            // 
            this.lbHoTen.Location = new System.Drawing.Point(39, 120);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(74, 19);
            this.lbHoTen.TabIndex = 7;
            this.lbHoTen.Text = "HỌ TÊN : ";
            // 
            // lbTenLop
            // 
            this.lbTenLop.AutoSize = true;
            this.lbTenLop.Location = new System.Drawing.Point(337, 54);
            this.lbTenLop.Name = "lbTenLop";
            this.lbTenLop.Size = new System.Drawing.Size(73, 19);
            this.lbTenLop.TabIndex = 9;
            this.lbTenLop.Text = "TÊN LỚP";
            // 
            // lbMaLop
            // 
            this.lbMaLop.AutoSize = true;
            this.lbMaLop.Location = new System.Drawing.Point(35, 54);
            this.lbMaLop.Name = "lbMaLop";
            this.lbMaLop.Size = new System.Drawing.Size(66, 19);
            this.lbMaLop.TabIndex = 8;
            this.lbMaLop.Text = "MÃ LỚP";
            // 
            // pcHienThiChiTietCauHoi
            // 
            this.pcHienThiChiTietCauHoi.BackColor = System.Drawing.Color.Ivory;
            this.pcHienThiChiTietCauHoi.Controls.Add(this.btnFinshTest);
            this.pcHienThiChiTietCauHoi.Controls.Add(this.Answer1);
            this.pcHienThiChiTietCauHoi.Controls.Add(this.Answer4);
            this.pcHienThiChiTietCauHoi.Controls.Add(this.Answer3);
            this.pcHienThiChiTietCauHoi.Controls.Add(this.Answer2);
            this.pcHienThiChiTietCauHoi.Controls.Add(this.Cauhoi);
            this.pcHienThiChiTietCauHoi.Controls.Add(this.ContentQuestion);
            this.pcHienThiChiTietCauHoi.Controls.Add(this.btnCauCuoi);
            this.pcHienThiChiTietCauHoi.Controls.Add(this.btnCauSau);
            this.pcHienThiChiTietCauHoi.Controls.Add(this.btnCauTrc);
            this.pcHienThiChiTietCauHoi.Controls.Add(this.btnCauDau);
            this.pcHienThiChiTietCauHoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcHienThiChiTietCauHoi.Enabled = false;
            this.pcHienThiChiTietCauHoi.Location = new System.Drawing.Point(299, 168);
            this.pcHienThiChiTietCauHoi.Name = "pcHienThiChiTietCauHoi";
            this.pcHienThiChiTietCauHoi.Size = new System.Drawing.Size(1384, 509);
            this.pcHienThiChiTietCauHoi.TabIndex = 9;
            // 
            // btnFinshTest
            // 
            this.btnFinshTest.BackColor = System.Drawing.Color.Green;
            this.btnFinshTest.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinshTest.ForeColor = System.Drawing.Color.Black;
            this.btnFinshTest.Location = new System.Drawing.Point(859, 424);
            this.btnFinshTest.Name = "btnFinshTest";
            this.btnFinshTest.Size = new System.Drawing.Size(155, 51);
            this.btnFinshTest.TabIndex = 30;
            this.btnFinshTest.Text = "NỘP BÀI";
            this.btnFinshTest.UseVisualStyleBackColor = false;
            this.btnFinshTest.Click += new System.EventHandler(this.btnFinshTest_Click);
            // 
            // Answer1
            // 
            this.Answer1.AutoSize = true;
            this.Answer1.Location = new System.Drawing.Point(208, 192);
            this.Answer1.Name = "Answer1";
            this.Answer1.Size = new System.Drawing.Size(45, 23);
            this.Answer1.TabIndex = 29;
            this.Answer1.TabStop = true;
            this.Answer1.Text = "A";
            this.Answer1.UseVisualStyleBackColor = true;
            // 
            // Answer4
            // 
            this.Answer4.AutoSize = true;
            this.Answer4.Location = new System.Drawing.Point(208, 344);
            this.Answer4.Name = "Answer4";
            this.Answer4.Size = new System.Drawing.Size(45, 23);
            this.Answer4.TabIndex = 28;
            this.Answer4.TabStop = true;
            this.Answer4.Text = "D";
            this.Answer4.UseVisualStyleBackColor = true;
            // 
            // Answer3
            // 
            this.Answer3.AutoSize = true;
            this.Answer3.Location = new System.Drawing.Point(208, 295);
            this.Answer3.Name = "Answer3";
            this.Answer3.Size = new System.Drawing.Size(44, 23);
            this.Answer3.TabIndex = 27;
            this.Answer3.TabStop = true;
            this.Answer3.Text = "C";
            this.Answer3.UseVisualStyleBackColor = true;
            // 
            // Answer2
            // 
            this.Answer2.AutoSize = true;
            this.Answer2.Location = new System.Drawing.Point(208, 244);
            this.Answer2.Name = "Answer2";
            this.Answer2.Size = new System.Drawing.Size(43, 23);
            this.Answer2.TabIndex = 26;
            this.Answer2.TabStop = true;
            this.Answer2.Text = "B";
            this.Answer2.UseVisualStyleBackColor = true;
            // 
            // Cauhoi
            // 
            this.Cauhoi.Location = new System.Drawing.Point(194, 26);
            this.Cauhoi.Name = "Cauhoi";
            this.Cauhoi.Size = new System.Drawing.Size(79, 19);
            this.Cauhoi.TabIndex = 25;
            this.Cauhoi.Text = "Câu hỏi 1: ";
            // 
            // ContentQuestion
            // 
            this.ContentQuestion.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.ContentQuestion.Location = new System.Drawing.Point(194, 60);
            this.ContentQuestion.Name = "ContentQuestion";
            this.ContentQuestion.ReadOnly = true;
            this.ContentQuestion.Size = new System.Drawing.Size(820, 96);
            this.ContentQuestion.TabIndex = 24;
            this.ContentQuestion.Text = "";
            // 
            // btnCauCuoi
            // 
            this.btnCauCuoi.Location = new System.Drawing.Point(621, 436);
            this.btnCauCuoi.Name = "btnCauCuoi";
            this.btnCauCuoi.Size = new System.Drawing.Size(112, 37);
            this.btnCauCuoi.TabIndex = 23;
            this.btnCauCuoi.Text = "Câu cuối>>";
            this.btnCauCuoi.UseVisualStyleBackColor = true;
            this.btnCauCuoi.Click += new System.EventHandler(this.btnCauCuoi_Click);
            // 
            // btnCauSau
            // 
            this.btnCauSau.Location = new System.Drawing.Point(457, 436);
            this.btnCauSau.Name = "btnCauSau";
            this.btnCauSau.Size = new System.Drawing.Size(108, 38);
            this.btnCauSau.TabIndex = 22;
            this.btnCauSau.Text = "Câu sau>";
            this.btnCauSau.UseVisualStyleBackColor = true;
            this.btnCauSau.Click += new System.EventHandler(this.btnCauSau_Click);
            // 
            // btnCauTrc
            // 
            this.btnCauTrc.Location = new System.Drawing.Point(305, 437);
            this.btnCauTrc.Name = "btnCauTrc";
            this.btnCauTrc.Size = new System.Drawing.Size(105, 37);
            this.btnCauTrc.TabIndex = 21;
            this.btnCauTrc.Text = "<Câu trước";
            this.btnCauTrc.UseVisualStyleBackColor = true;
            this.btnCauTrc.Click += new System.EventHandler(this.btnCauTrc_Click);
            // 
            // btnCauDau
            // 
            this.btnCauDau.Location = new System.Drawing.Point(126, 437);
            this.btnCauDau.Name = "btnCauDau";
            this.btnCauDau.Size = new System.Drawing.Size(122, 38);
            this.btnCauDau.TabIndex = 20;
            this.btnCauDau.Text = "<<Câu đầu";
            this.btnCauDau.UseVisualStyleBackColor = true;
            this.btnCauDau.Click += new System.EventHandler(this.btnCauDau_Click);
            // 
            // frmEXAM
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1683, 677);
            this.Controls.Add(this.pcHienThiChiTietCauHoi);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "frmEXAM";
            this.Text = "THI";
            this.Load += new System.EventHandler(this.frmEXAM_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ngaythi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngaythi.Properties)).EndInit();
            this.pcHienThiChiTietCauHoi.ResumeLayout(false);
            this.pcHienThiChiTietCauHoi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cbbMonHoc;
        private DevExpress.XtraEditors.DateEdit ngaythi;
        private System.Windows.Forms.ComboBox cbbLanThi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LabelControl lbHoTen;
        private System.Windows.Forms.Label lbTenLop;
        private System.Windows.Forms.Label lbMaLop;
        private System.Windows.Forms.Button btnLayDeThi;
        private System.Windows.Forms.ListBox listCauHoi;
        private System.Windows.Forms.Panel pcHienThiChiTietCauHoi;
        private System.Windows.Forms.Button btnFinshTest;
        private System.Windows.Forms.RadioButton Answer1;
        private System.Windows.Forms.RadioButton Answer4;
        private System.Windows.Forms.RadioButton Answer3;
        private System.Windows.Forms.RadioButton Answer2;
        private DevExpress.XtraEditors.LabelControl Cauhoi;
        private System.Windows.Forms.RichTextBox ContentQuestion;
        private System.Windows.Forms.Button btnCauCuoi;
        private System.Windows.Forms.Button btnCauSau;
        private System.Windows.Forms.Button btnCauTrc;
        private System.Windows.Forms.Button btnCauDau;
        private System.Windows.Forms.TextBox txtThoiGian;
    }
}