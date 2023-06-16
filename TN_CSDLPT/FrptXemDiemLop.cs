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
    public partial class FrptXemDiemLop : DevExpress.XtraEditors.XtraForm
    {
        public FrptXemDiemLop()
        {
            InitializeComponent();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            string MaLOP = cmbTenLop.SelectedValue.ToString();
            string MaMH = cmbTenMonHoc.SelectedValue.ToString();
            XrptXemDiemLop report = new XrptXemDiemLop(MaLOP, MaMH, 1);
            ReportPrintTool print = new ReportPrintTool(report);
            print.ShowPreviewDialog();

        }

        private void FrptXemDiemLop_Load(object sender, EventArgs e)
        {
            cmbCoSo.DataSource = Program.bds_DSCS;
            cmbCoSo.DisplayMember = "TENCS";
            cmbCoSo.ValueMember = "TENSERVER";
            cmbCoSo.SelectedIndex = Program.mCoSo;

            Program.myReader.Close();
            string dsmohoc = "SELECT MAMH, TENMH FROM MONHOC WHERE MAMH IN (SELECT MAMH FROM GIAOVIEN_DANGKY) ";
            DataTable dt = Program.ExecDataTable(dsmohoc);
            cmbTenMonHoc.DataSource = dt;
            cmbTenMonHoc.DisplayMember = "TENMH";
            cmbTenMonHoc.ValueMember = "MAMH";
            cmbTenMonHoc.SelectedIndex = 0;
            Program.myReader.Close();

            string dsLop = "SELECT MALOP,TENLOP FROM LOP";
            DataTable dtLop = Program.ExecDataTable(dsLop);
            cmbTenLop.DataSource = dtLop;
            cmbTenLop.DisplayMember = "TENLOP";
            cmbTenLop.ValueMember = "MALOP";
            cmbTenLop.SelectedIndex = 0;
            Program.myReader.Close();
        }

        private void cmbCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCoSo.SelectedValue.ToString() == "System.Data.DataRowView")
            {
                return;
            }


            Program.serverName = cmbCoSo.SelectedValue.ToString();

            if (cmbCoSo.SelectedIndex != Program.mCoSo)// chọn cơ sở khác với cơ sở lúc đăng nhập
            {
                Program.ServerLogin = Program.remoteLogin;
                Program.ServerPassword = Program.remotePassword;

            }
            else
            {
                Program.ServerLogin = Program.AuthLogin;
                Program.ServerPassword = Program.AuthPassword;

            }

            if (Program.KetNoi() == 0)// lỗi
            {
                MessageBox.Show("Xảy ra lỗi kết nối với chi nhánh hiện tại", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                
            }
        }
    }
}