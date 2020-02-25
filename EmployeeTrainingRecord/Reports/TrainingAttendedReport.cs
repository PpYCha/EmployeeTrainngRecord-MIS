using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Windows.Forms;

namespace EmployeeTrainingRecord.Reports
{
    public partial class TrainingAttendedReport : Form
    {
        public TrainingAttendedReport()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load((Application.StartupPath + "\\ByParticpants.rpt"));
            crystalReportViewer1.ReportSource = cryRpt;




        }



    }
}
