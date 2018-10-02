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
    public partial class frmReservationReport : MetroForm
    {
        int AdminID;
        string AdminName;
        DateTime Date;

        GetSomethingFromServer g = new GetSomethingFromServer();

        public frmReservationReport(int Admin, DateTime Now)
        {
            InitializeComponent();

            AdminID = Admin;
            Date = Now;
            g.GetUsername(AdminID);
            g.GetFullname();
            AdminName = g.Fullname;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            rptEquipmentReservation1.SetParameterValue("pProcessedBy", AdminName);
            rptEquipmentReservation1.SetParameterValue("pDateBorrowed", Date);
            crystalReportViewer1.ReportSource = rptEquipmentReservation1;
        }
    }
}
