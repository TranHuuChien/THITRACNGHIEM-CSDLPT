using DevExpress.XtraEditors;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TN_CSDLPT
{
    public partial class frmEXAM : DevExpress.XtraEditors.XtraForm
    {
        bool isSinhVien = false;
        public frmEXAM()
        {
            InitializeComponent();
        }

        private void frmEXAM_Load(object sender, EventArgs e)
        {





            string truyvan = "SELECT MALOP, TENLOP FROM LOP WHERE MALOP = (SELECT MALOP FROM SINHVIEN WHERE MASV ='" + Program.AuthLogin + "')";
            string truyvan1 ="SELECT MALOP FROM SINHVIEN WHERE MASV ='" + Program.AuthLogin + "'";

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
            string Malop = Program.myReader.GetValue(0).ToString();
            string TenLop = Program.myReader.GetValue(1).ToString();
            lbMaLop.Text = "MÃ LỚP : " + Malop; 
            lbHoTen.Text = "HỌ VÀ TÊN : " + Program.AuthHoten;
            lbTenLop.Text = "TÊN LỚP : " + TenLop;
        }

        public void LoadCAUHOI()
        {

        }

        private void lbHoTen_Click(object sender, EventArgs e)
        {

        }
    }
}