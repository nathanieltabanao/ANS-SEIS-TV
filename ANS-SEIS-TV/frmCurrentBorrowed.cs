using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
using MaterialSkin;
using MaterialSkin.Controls;

namespace ANS_SEIS_TV
{
    public partial class frmCurrentBorrowed : MetroForm
    {
        string Admin;
        DateTime DateNow;


        public frmCurrentBorrowed(string CurrentAdmin, DateTime Now)
        {
            InitializeComponent();

            Admin = CurrentAdmin;
            DateNow = Now;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            rptCurrentBorrowed1.SetParameterValue("pProcessedBy", Admin);
            rptCurrentBorrowed1.SetParameterValue("pDateBorrowed", DateNow);

            crystalReportViewer1.ReportSource = rptCurrentBorrowed1;
        }
    }
}
