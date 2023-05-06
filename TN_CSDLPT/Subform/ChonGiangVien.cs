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
    public partial class ChonGiangVien : DevExpress.XtraEditors.XtraForm
    {
        public ChonGiangVien()
        {
            InitializeComponent();
        }

        private void gIAOVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsGIANGVIEN.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);

        }

        private void ChonGiangVien_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'dataSet.GIAOVIEN' table. You can move, or remove it, as needed.
            this.dataSet.EnforceConstraints = false;
            this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIENTableAdapter.Fill(this.dataSet.GIAOVIEN);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRowView drv = ((DataRowView)(bdsGIANGVIEN.Current));
            string MaGV = drv["MAGV"].ToString().Trim();
            Program.MaGVDaChon = MaGV;
            this.Close();
        }
    }
}