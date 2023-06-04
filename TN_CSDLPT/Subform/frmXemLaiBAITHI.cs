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
using TN_CSDLPT.Class;

namespace TN_CSDLPT.Subform
{
    public partial class frmXemLaiBAITHI : DevExpress.XtraEditors.XtraForm
    {
        public frmXemLaiBAITHI()
        {
            InitializeComponent();
        }

        private void cT_BAITHIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cT_BAITHIBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);

        }

        private void frmXemLaiBAITHI_Load(object sender, EventArgs e)
        {
            
            txtHoTen.Text += Program.AuthHoten;
            txtMaSV.Text += Program.AuthLogin;
            // IN RA DANH SÁCH MÔN THI
            string dsmohoc = "SELECT MAMH, TENMH FROM MONHOC WHERE MAMH IN (SELECT MAMH FROM GIAOVIEN_DANGKY) ";
            DataTable dt = Program.ExecDataTable(dsmohoc);
            cbbMonHoc.DataSource = dt;
            cbbMonHoc.DisplayMember = "TENMH";
            cbbMonHoc.ValueMember = "MAMH";
            cbbMonHoc.SelectedIndex = 0;


            List<LanThi> lanthis = new List<LanThi> {
                new LanThi("1", "Lần 1"),
                new LanThi("2", "Lần 2"),

             };
            cbbLanThi.DataSource = lanthis;
            cbbLanThi.DisplayMember = "SOLAN";
            cbbLanThi.ValueMember = "TENLAN";

        }
        private void txtHoTen_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string truyvan = "exec SP_TAO_BAITHI 'AT2','001', 'AVCB',1";
            String truyvan = "EXEC SP_TRAVE_ID_BAITHI '" + Program.AuthLogin + "','" + cbbMonHoc.SelectedValue.ToString() + "'," + cbbLanThi.SelectedValue.ToString();
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
            string id_baithi = Program.myReader.GetValue(0).ToString();
            Program.myReader.Close();

            string hql = "select STT, CT_BAITHI.CAUHOI,NOIDUNG,DAP_AN,DACHON FROM CT_BAITHI INNER JOIN BODE ON CT_BAITHI.CAUHOI = BODE.CAUHOI AND ID_BAITHI = " + id_baithi;
            dgvTraCuuBaiThi.DataSource = Program.ExecDataTable(hql);
            /*foreach (DataGridViewRow row in dgvTraCuuBaiThi.Rows)
            {
                string DACHON = Convert.ToString(row.Cells[4].Value);
                string DAPAN = Convert.ToString(row.Cells[5].Value);
                if (DAPAN.Equals(DACHON))
                {
                    row.DefaultCellStyle.BackColor = Color.Green;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
            }*/
        }
    }
}