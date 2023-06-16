using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace TN_CSDLPT.Report
{
    public partial class XrptXemChiTietBaiThi : DevExpress.XtraReports.UI.XtraReport
    {
        public XrptXemChiTietBaiThi(string MaSV, string MonHoc, int lan)
        {
            InitializeComponent();

            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = MaSV;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = MonHoc;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = lan;
            this.sqlDataSource1.Fill();
        }

    }
}
