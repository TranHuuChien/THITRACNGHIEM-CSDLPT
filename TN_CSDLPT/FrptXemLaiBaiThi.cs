using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using TN_CSDLPT.Report;
using TN_CSDLPT.Class;
using System.IO;

namespace TN_CSDLPT
{
    public partial class FrptXemLaiBaiThi : DevExpress.XtraEditors.XtraForm
    {
        string MaMonHoc = "";
        string Malop = "";
        string TenLop = "";
        string masv = "";
        string MonHoc = "";
        int lanthi = 0;
        public FrptXemLaiBaiThi()
        {
            InitializeComponent();
        }

        private void XrptXemLaiBaiThi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.DS_MH_THITRACNGHIEM' table. You can move, or remove it, as needed.
            //this.dS_MH_THITRACNGHIEMTableAdapter.Connection.ConnectionString = Program.connstr;
            //this.dS_MH_THITRACNGHIEMTableAdapter.Fill(this.dataSet.DS_MH_THITRACNGHIEM);

            cmbCoSo.DataSource = Program.bds_DSCS;
            cmbCoSo.DisplayMember = "TENCS";
            cmbCoSo.ValueMember = "TENSERVER";
            cmbCoSo.SelectedIndex = Program.mCoSo;
            lbMaSV.Text += Program.AuthLogin;

            cmbLanThi.SelectedItem = 0;

            Program.myReader.Close();
            string dsmohoc = "SELECT MAMH, TENMH FROM MONHOC WHERE MAMH IN (SELECT MAMH FROM GIAOVIEN_DANGKY) ";
            DataTable dt = Program.ExecDataTable(dsmohoc);
            cmbTenMonHoc.DataSource = dt;
            cmbTenMonHoc.DisplayMember = "TENMH";
            cmbTenMonHoc.ValueMember = "MAMH";
            cmbTenMonHoc.SelectedIndex = 0;
            Program.myReader.Close();


            List<LanThi> lanthis = new List<LanThi> {
                new LanThi("1", "Lần 1"),
                new LanThi("2", "Lần 2"),

             };
            cmbLanThi.DataSource = lanthis;
            cmbLanThi.DisplayMember = "SOLAN";
            cmbLanThi.ValueMember = "TENLAN";
            cmbLanThi.SelectedValue = 0;


            if (Program.AuthGroup == "TRUONG")
            {
                cmbCoSo.Enabled = true;
            }
            else
            {
                cmbCoSo.Enabled = false;
            }

        }

        private void cmbCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // nếu combobox không có gì kết thúc chương trình luon
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
                this.dS_MH_THITRACNGHIEMTableAdapter.Connection.ConnectionString = Program.connstr;
                this.dS_MH_THITRACNGHIEMTableAdapter.Fill(this.dataSet.DS_MH_THITRACNGHIEM);
            }
        }

        private void cmbTenMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                MaMonHoc = cmbTenMonHoc.SelectedValue.ToString();
            }
            catch (Exception ex) { 
                
            }
            

        }
        private void btnPreview_Click(object sender, EventArgs e)
        {
            string truyvan = "SELECT MALOP, TENLOP FROM LOP WHERE MALOP = (SELECT MALOP FROM SINHVIEN WHERE MASV ='" + Program.AuthLogin + "')";
            try
            {
                Program.myReader = Program.ExecSqlDataReader(truyvan);
                if (Program.myReader == null)
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thực thi database thất bại " + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Program.myReader.Read();
            Malop = Program.myReader.GetValue(0).ToString();
            TenLop = Program.myReader.GetValue(1).ToString();
            MaMonHoc = cmbTenMonHoc.SelectedValue.ToString();
            masv = Program.AuthLogin.ToString();

            //lanthi = int.Parse(cmbLanThi.SelectedValue.ToString());
            lanthi = 1;
            XrptXemChiTietBaiThi1 rpt = new XrptXemChiTietBaiThi1(masv,MaMonHoc, lanthi);
            rpt.xrHovaTen.Text += Program.AuthHoten;
            rpt.xrLop.Text += Malop + ":" + TenLop;
            rpt.xrMonThi.Text += MonHoc;
            rpt.xrLanThi.Text += lanthi.ToString();
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();

           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnInFile_Click(object sender, EventArgs e)
        {
            XrptXemChiTietBaiThi1 report = new XrptXemChiTietBaiThi1(masv, MaMonHoc, lanthi);

            try{
                if(File.Exists(@"D:\ReportXemLaiBaiThi.pdf"))
                {
                    DialogResult dr = MessageBox.Show("File ReportXemLaiBaiThi.pdf tại ổ đĩa D đã có \n Bạn có muốn tại lại",
                    "Xác nhận", MessageBoxButtons.YesNo ,MessageBoxIcon.Information);
                    if(dr == DialogResult.Yes)
                    {
                        report.ExportToPdf(@"D:\ReportXemLaiBaiThi.pdf");
                        MessageBox.Show("File ReportXemLaiBaiThi.pdf đã được ghi thành công", "Xác nhận",MessageBoxButtons.OK);
                    }
                    
                }
                else
                {
                    report.ExportToPdf(@"D:\ReportXemLaiBaiThi.pdf");
                    MessageBox.Show("File ReportXemLaiBaiThi.pdf đã được ghi thành công", "Xác nhận", MessageBoxButtons.OK);
                }
            }
            catch(Exception ex)
            {
                return;
            }

        }
    }
}