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
    public partial class frmDsKhongCoTK : DevExpress.XtraEditors.XtraForm
    {
        public frmDsKhongCoTK()
        {
            InitializeComponent();
        }

        private void frmDsKhongCoTK_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.SP_DS_NHANVIEN_KHONG_TAI_KHOAN1' table. You can move, or remove it, as needed.
            this.sP_DS_NHANVIEN_KHONG_TAI_KHOAN1TableAdapter.Fill(this.dataSet.SP_DS_NHANVIEN_KHONG_TAI_KHOAN1);
            // TODO: This line of code loads data into the 'dataSet.SP_DS_NHANVIEN_KHONG_TAI_KHOAN' table. You can move, or remove it, as needed.
            this.sP_DS_NHANVIEN_KHONG_TAI_KHOANTableAdapter.Fill(this.dataSet.SP_DS_NHANVIEN_KHONG_TAI_KHOAN);

        }
    }
}