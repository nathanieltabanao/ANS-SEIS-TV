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
    public partial class frmDeployment : MetroForm
    {
        string AdminName, TeacherName, RoomNo, TransactionID;
        DateTime ProcessDate, DeploymentDate;

        public frmDeployment(string Admin,string Teacher, DateTime now, DateTime deployment, string room, string TID)
        {
            InitializeComponent();

            AdminName = Admin;
            TeacherName = Teacher;
            ProcessDate = now;
            DeploymentDate = deployment;
            RoomNo = room;
            TransactionID = TID;
        }

        private void frmDeployment_Load(object sender, EventArgs e)
        {
            rptDeployment rptDeployment1 = new rptDeployment();

            rptDeployment1.SetParameterValue("pProcessedBy", AdminName);
            rptDeployment1.SetParameterValue("pDateBorrowed", ProcessDate);
            rptDeployment1.SetParameterValue("pTeacher", TeacherName);
            rptDeployment1.SetParameterValue("pRoomNo", RoomNo);
            rptDeployment1.SetParameterValue("pTransactionID", TransactionID);
            rptDeployment1.SetParameterValue("pDateDeployed", DeploymentDate);
            rptDeployment1.SetParameterValue("@TransactionID", TransactionID);
            rptDeployment1.SetParameterValue("@SearchBarcode", TransactionID);
            crystalReportViewer1.ReportSource = rptDeployment1;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
