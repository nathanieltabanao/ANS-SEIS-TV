using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
using MaterialSkin;
using MaterialSkin.Controls;

namespace ANS_SEIS_TV
{
    public partial class frmRequestReport : MetroForm
    {
        int New, Pending = 0;
        string AdminName = null;

        GetSomethingFromServer g = new GetSomethingFromServer();
        

        public frmRequestReport(int GENID)
        {
            InitializeComponent();

            g.GetUsername(GENID);
            g.GetFullname();
            AdminName = g.Fullname;

            New = g.GetNewRequests();
            Pending = g.GetPendingRequests();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            rptRequests rptRequests1 = new rptRequests();

            rptRequests1.SetParameterValue("pProcessedBy", AdminName);
            rptRequests1.SetParameterValue("pDateBorrowed", DateTime.Now.ToShortDateString());
            rptRequests1.SetParameterValue("pPending", Pending);
            rptRequests1.SetParameterValue("pNew", New);
            crystalReportViewer1.ReportSource = rptRequests1;
        }
    }
}
