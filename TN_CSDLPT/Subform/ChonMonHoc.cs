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
    public partial class ChonMonHoc : DevExpress.XtraEditors.XtraForm
    {
        public ChonMonHoc()
        {
            InitializeComponent();
        }

        private void ChonMonHoc_Load(object sender, EventArgs e)
        {

            try
            {
                this.dataSet.EnforceConstraints = false;
                // TODO: This line of code loads data into the 'dataSet.SP_LAYDANHSACH_MONHOC' table. You can move, or remove it, as needed.
                this.sP_LAYDANHSACH_MONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_LAYDANHSACH_MONHOCTableAdapter.Fill(this.dataSet.SP_LAYDANHSACH_MONHOC);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi Load Chọn Môn Học" + ex.Message, "Thông báo", MessageBoxButtons.OKCancel);

            }

        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCHON_Click(object sender, EventArgs e)
        {
            DataRowView drv = ((DataRowView)(sP_LAYDANHSACH_MONHOCBindingSource.Current));
            Program.MaMonDaChon = drv["MAMH"].ToString().Trim();
            //MessageBox.Show(Program.MaMonDaChon, "THông báo", MessageBoxButtons.OK);
            this.Close();
        }
    }
}