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
    public partial class frmReservationSlip : MetroForm
    {
        int TransactionID,AdminID,TeacherID;
        string AdminName, TeacherName;
        
        DateTime DateRequested;

        GetSomethingFromServer g = new GetSomethingFromServer();

        public frmReservationSlip(int TID, int Admin, int Teacher, DateTime DateR)
        {
            InitializeComponent();

            TransactionID = TID;
            AdminID = Admin;
            g.GetUsername(AdminID);
            g.GetFullname();
            AdminName = g.Fullname;

            TeacherID = Teacher;
            g.GetUsername(TeacherID);
            g.GetFullname();
            TeacherName = g.Fullname;

            DateRequested = DateR;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            rptReservationSlip1.SetParameterValue("pTransactionID", TransactionID);
            rptReservationSlip1.SetParameterValue("pBorrower", TeacherName);
            rptReservationSlip1.SetParameterValue("pDateBorrowed", DateTime.Now.ToShortDateString());
            rptReservationSlip1.SetParameterValue("pProcessedBy", AdminName);
            rptReservationSlip1.SetParameterValue("pDateRequested", DateRequested);
            rptReservationSlip1.SetParameterValue("@TransactionID", TransactionID);
            rptReservationSlip1.SetParameterValue("@SearchBarcode", TransactionID);
            crystalReportViewer1.ReportSource = rptReservationSlip1;
        }
    }
}
