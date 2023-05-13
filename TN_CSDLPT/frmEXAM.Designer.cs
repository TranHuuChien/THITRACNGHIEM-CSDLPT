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
            this.lbHoTen = new DevExpress.XtraEditors.LabelControl();
            this.lbMaLop = new System.Windows.Forms.Label();
            this.lbTenLop = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbHoTen
            // 
            this.lbHoTen.Location = new System.Drawing.Point(18, 9);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(74, 19);
            this.lbHoTen.TabIndex = 0;
            this.lbHoTen.Text = "HỌ TÊN : ";
            this.lbHoTen.Click += new System.EventHandler(this.lbHoTen_Click);
            // 
            // lbMaLop
            // 
            this.lbMaLop.AutoSize = true;
            this.lbMaLop.Location = new System.Drawing.Point(14, 52);
            this.lbMaLop.Name = "lbMaLop";
            this.lbMaLop.Size = new System.Drawing.Size(66, 19);
            this.lbMaLop.TabIndex = 1;
            this.lbMaLop.Text = "MÃ LỚP";
            // 
            // lbTenLop
            // 
            this.lbTenLop.AutoSize = true;
            this.lbTenLop.Location = new System.Drawing.Point(19, 100);
            this.lbTenLop.Name = "lbTenLop";
            this.lbTenLop.Size = new System.Drawing.Size(73, 19);
            this.lbTenLop.TabIndex = 2;
            this.lbTenLop.Text = "TÊN LỚP";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lbTenLop);
            this.panelControl1.Controls.Add(this.lbMaLop);
            this.panelControl1.Controls.Add(this.lbHoTen);
            this.panelControl1.Location = new System.Drawing.Point(1007, 3);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(324, 160);
            this.panelControl1.TabIndex = 3;
            // 
            // panelControl2
            // 
            this.panelControl2.Location = new System.Drawing.Point(2, 3);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(385, 157);
            this.panelControl2.TabIndex = 4;
            // 
            // frmEXAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 458);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.IsMdiContainer = true;
            this.Name = "frmEXAM";
            this.Text = "THI";
            this.Load += new System.EventHandler(this.frmEXAM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lbHoTen;
        private System.Windows.Forms.Label lbMaLop;
        private System.Windows.Forms.Label lbTenLop;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
    }
}