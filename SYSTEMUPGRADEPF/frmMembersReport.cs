using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SYSTEMUPGRADEPF
{
    public partial class frmMembersReport : Form
    {
        public frmMembersReport()
        {
            InitializeComponent();
        }

        private void frmMembersReport_Load(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load("C: /Users/User/Documents/Visual Studio 2015/Projects/POWER FINANCIAL SYSTEM UPGRADE/SYSTEMUPGRADEPF/Reports/MembersCrystalReport.rpt");
            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();
        }
    }
}
