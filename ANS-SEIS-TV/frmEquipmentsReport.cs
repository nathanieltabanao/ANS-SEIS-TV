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
    public partial class frmEquipmentsReport : MetroForm
    {
        GetSomethingFromServer g = new GetSomethingFromServer();

        string AdminName, TeacherName;

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            rptReturnedEquipmentsReport rptReturnedEquipmentsReport1 = new rptReturnedEquipmentsReport();

            rptReturnedEquipmentsReport1.SetParameterValue("pProcessedBy", AdminName);
            rptReturnedEquipmentsReport1.SetParameterValue("pDateBorrowed", DateTime.Now);
            crystalReportViewer1.ReportSource = rptReturnedEquipmentsReport1;
        }

        public frmEquipmentsReport(int Admin)
        {
            InitializeComponent();

            g.GetUsername(Admin);
            g.GetFullname();
            AdminName = g.Fullname;
        }
    }
}
