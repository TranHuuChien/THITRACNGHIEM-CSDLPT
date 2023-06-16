using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace TN_CSDLPT.Report
{
    public partial class XrptXemDiemLop : DevExpress.XtraReports.UI.XtraReport
    {
        public XrptXemDiemLop()
        {
            InitializeComponent();
        }

        public XrptXemDiemLop(string MaLop, string MaMonHoc, int lan)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = MaLop;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = MaMonHoc;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = lan;
            this.sqlDataSource1.Fill();
        }
    }
}
