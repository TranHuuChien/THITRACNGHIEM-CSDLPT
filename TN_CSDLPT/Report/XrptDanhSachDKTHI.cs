using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace TN_CSDLPT.Report
{
    public partial class XrptDanhSachDKTHI : DevExpress.XtraReports.UI.XtraReport
    {
        public XrptDanhSachDKTHI()
        {
            InitializeComponent();
        }
        public XrptDanhSachDKTHI(int MaCoSo, string NgayBatDau, string NgayKetThuc)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = MaCoSo;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = NgayBatDau;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = NgayKetThuc;
            this.sqlDataSource1.Fill();
        }

    }
}
