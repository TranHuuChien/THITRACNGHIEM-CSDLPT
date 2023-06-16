namespace TN_CSDLPT
{
    partial class FrptXemDiemLop
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
            System.Windows.Forms.Label tENMHLabel;
            this.btnInFile = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.cmbLanThi = new System.Windows.Forms.ComboBox();
            this.cmbTenMonHoc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCoSo = new System.Windows.Forms.ComboBox();
            this.labelCoSo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTenLop = new System.Windows.Forms.ComboBox();
            tENMHLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tENMHLabel
            // 
            tENMHLabel.AutoSize = true;
            tENMHLabel.Location = new System.Drawing.Point(440, 149);
            tENMHLabel.Name = "tENMHLabel";
            tENMHLabel.Size = new System.Drawing.Size(133, 19);
            tENMHLabel.TabIndex = 16;
            tENMHLabel.Text = "TÊN MÔN HỌC : ";
            // 
            // btnInFile
            // 
            this.btnInFile.Location = new System.Drawing.Point(716, 286);
            this.btnInFile.Name = "btnInFile";
            this.btnInFile.Size = new System.Drawing.Size(96, 38);
            this.btnInFile.TabIndex = 20;
            this.btnInFile.Text = "In ra file";
            this.btnInFile.UseVisualStyleBackColor = true;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(281, 286);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(132, 39);
            this.btnPreview.TabIndex = 19;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // cmbLanThi
            // 
            this.cmbLanThi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLanThi.FormattingEnabled = true;
            this.cmbLanThi.Items.AddRange(new object[] {
            "LẦN 1",
            "LẦN 2"});
            this.cmbLanThi.Location = new System.Drawing.Point(958, 149);
            this.cmbLanThi.Name = "cmbLanThi";
            this.cmbLanThi.Size = new System.Drawing.Size(121, 27);
            this.cmbLanThi.TabIndex = 18;
            // 
            // cmbTenMonHoc
            // 
            this.cmbTenMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTenMonHoc.FormattingEnabled = true;
            this.cmbTenMonHoc.Location = new System.Drawing.Point(575, 146);
            this.cmbTenMonHoc.Name = "cmbTenMonHoc";
            this.cmbTenMonHoc.Size = new System.Drawing.Size(212, 27);
            this.cmbTenMonHoc.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(878, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "LẦN THI : ";
            // 
            // cmbCoSo
            // 
            this.cmbCoSo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCoSo.FormattingEnabled = true;
            this.cmbCoSo.Location = new System.Drawing.Point(280, 73);
            this.cmbCoSo.Name = "cmbCoSo";
            this.cmbCoSo.Size = new System.Drawing.Size(236, 27);
            this.cmbCoSo.TabIndex = 13;
            this.cmbCoSo.SelectedIndexChanged += new System.EventHandler(this.cmbCoSo_SelectedIndexChanged);
            // 
            // labelCoSo
            // 
            this.labelCoSo.AutoSize = true;
            this.labelCoSo.Location = new System.Drawing.Point(202, 79);
            this.labelCoSo.Name = "labelCoSo";
            this.labelCoSo.Size = new System.Drawing.Size(73, 19);
            this.labelCoSo.TabIndex = 12;
            this.labelCoSo.Text = "CƠ SỞ : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 21;
            this.label1.Text = "LỚP : ";
            // 
            // cmbTenLop
            // 
            this.cmbTenLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTenLop.FormattingEnabled = true;
            this.cmbTenLop.Location = new System.Drawing.Point(154, 145);
            this.cmbTenLop.Name = "cmbTenLop";
            this.cmbTenLop.Size = new System.Drawing.Size(197, 27);
            this.cmbTenLop.TabIndex = 22;
            // 
            // FrptXemDiemLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 380);
            this.Controls.Add(this.cmbTenLop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInFile);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.cmbLanThi);
            this.Controls.Add(tENMHLabel);
            this.Controls.Add(this.cmbTenMonHoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbCoSo);
            this.Controls.Add(this.labelCoSo);
            this.Name = "FrptXemDiemLop";
            this.Text = "FrptXemDiemLop";
            this.Load += new System.EventHandler(this.FrptXemDiemLop_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInFile;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.ComboBox cmbLanThi;
        private System.Windows.Forms.ComboBox cmbTenMonHoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCoSo;
        private System.Windows.Forms.Label labelCoSo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTenLop;
    }
}