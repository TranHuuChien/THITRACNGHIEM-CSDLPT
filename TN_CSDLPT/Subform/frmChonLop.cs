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

namespace TN_CSDLPT.Subform
{
    public partial class frmChonLop : DevExpress.XtraEditors.XtraForm
    {
        string malop = "";
        public frmChonLop()
        {
            InitializeComponent();
        }

        private void frmChonLop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.SP_LAY_DANH_SACH_LOP' table. You can move, or remove it, as needed.
            this.dataSet.EnforceConstraints = false;
            this.sP_LAY_DANH_SACH_LOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_LAY_DANH_SACH_LOPTableAdapter.Fill(this.dataSet.SP_LAY_DANH_SACH_LOP);

            cmbCoSo.Enabled = false;

            cmbCoSo.DataSource = Program.bds_DSCS;
            cmbCoSo.DisplayMember = "TENCS";
            cmbCoSo.ValueMember = "TENSERVER";
            cmbCoSo.SelectedIndex = Program.mCoSo;

            if(Program.AuthGroup == "TRUONG")
            {
                cmbCoSo.Enabled = true;
            }    
        }

        private void cmbCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbCoSo.SelectedValue.ToString() == "System.Data.DataRowView")
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
                // đăng nhập vào 
              
                this.sP_LAY_DANH_SACH_LOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_LAY_DANH_SACH_LOPTableAdapter.Fill(this.dataSet.SP_LAY_DANH_SACH_LOP);
            }

        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            DataRowView drv = ((DataRowView)(sP_LAY_DANH_SACH_LOPBindingSource.Current));
            malop = drv["MALOP"].ToString().Trim();
            Program.MaLopDuocChon = malop;
            this.Close();

        }

        private void btnChon_Click_1(object sender, EventArgs e)
        {
            DataRowView drv = ((DataRowView)(sP_LAY_DANH_SACH_LOPBindingSource.Current));
            malop = drv["MALOP"].ToString().Trim();
            Program.MaLopDuocChon = malop;
            this.Close();

        }
    }
}