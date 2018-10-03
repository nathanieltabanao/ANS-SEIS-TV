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
    public partial class frmEquipmmentStatus : MetroForm
    {
        int AdminID;
        string AdminName;

        GetSomethingFromServer g = new GetSomethingFromServer();

        public frmEquipmmentStatus(int Admin)
        {
            InitializeComponent();

            AdminID = Admin;

            g.GetUsername(AdminID);
            g.GetFullname();
            AdminName = g.Fullname;
        }

        private void crystalReportViewer3_Load(object sender, EventArgs e)
        {
            rptEquipmentStatus1.SetParameterValue("pProcessedBy", AdminName);
            rptEquipmentStatus1.SetParameterValue("pDateBorrowed", DateTime.Now.ToShortDateString());
            crystalReportViewer1.ReportSource = rptEquipmentStatus1;
            
            crystalReportViewer2.ReportSource = rptEquipmentStatus1;
            
            crystalReportViewer3.ReportSource = rptEquipmentStatus1;

        }
    }
}
