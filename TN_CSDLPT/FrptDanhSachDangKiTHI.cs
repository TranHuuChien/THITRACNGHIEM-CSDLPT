using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TN_CSDLPT.Report;

namespace TN_CSDLPT
{
    public partial class FrptDanhSachDangKiTHI : DevExpress.XtraEditors.XtraForm
    {
        public FrptDanhSachDangKiTHI()
        {
            InitializeComponent();
        }

        private void FrptDanhSachDangKiTHI_Load(object sender, EventArgs e)
        {
            cmbCoSo.DataSource = Program.bds_DSCS;
            cmbCoSo.DisplayMember = "TENCS";
            cmbCoSo.ValueMember = "TENSERVER";
            cmbCoSo.SelectedIndex = Program.mCoSo;
        }

      
        private void btnPreview_Click(object sender, EventArgs e)
        {
            int MaCoSo = cmbCoSo.SelectedIndex;
            string NgayBatDau = txtNgayBD.Text;
            string NgayKetThuc = txtNgayKT.Text;
            XrptDanhSachDKTHI report = new XrptDanhSachDKTHI(MaCoSo,NgayBatDau,NgayKetThuc);
            ReportPrintTool print = new ReportPrintTool(report);
            print.ShowPreviewDialog();
        }
    }
}