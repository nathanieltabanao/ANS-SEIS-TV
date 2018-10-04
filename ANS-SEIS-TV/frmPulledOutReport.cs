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
    public partial class frmPulledOutReport : MetroForm
    {
        string AdminName = null;

        GetSomethingFromServer g = new GetSomethingFromServer();

        public frmPulledOutReport(int GENID)
        {
            InitializeComponent();

            g.GetUsername(GENID);
            g.GetFullname();
            AdminName = g.Fullname;

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            rptPulledOutEquipment rptPulledOutEquipment1 = new rptPulledOutEquipment();

            rptPulledOutEquipment1.SetParameterValue("pProcessedBy", AdminName);
            rptPulledOutEquipment1.SetParameterValue("pDateBorrowed", DateTime.Now);
            crystalReportViewer1.ReportSource = rptPulledOutEquipment1;
        }
    }
}
