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

namespace TN_CSDLPT
{
    public partial class frmBoDe1 : DevExpress.XtraEditors.XtraForm
    {
        public frmBoDe1()
        {
            InitializeComponent();
        }

        private void bODEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bODEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);

        }

        private void frmBoDe1_Load(object sender, EventArgs e)
        {
            this.dataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dataSet.BODE' table. You can move, or remove it, as needed.
            this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
            this.bODETableAdapter.FillTheoGiangVien(this.dataSet.BODE, Program.userName);

        }
    }
}