using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using MetroFramework;

namespace ANS_SEIS_TV
{
    public partial class TeacherForm : MaterialForm
    {
        public TeacherForm()
        {
            InitializeComponent();
        }

        EquipmentLibrary e = new EquipmentLibrary();

        UserLibrary u = new UserLibrary();

        DataClasses1DataContext db = new DataClasses1DataContext();

        GetSomethingFromServer g = new GetSomethingFromServer();

        TransactionLibrary t = new TransactionLibrary();

        public string CurrentUsername { get; set; }
         
        public int CurrentGENID { get; set; }

        private void TeacherForm_Load(object sender, EventArgs e)
        {
            g.Username = CurrentUsername;
            g.GetFullname();
            lblCurrentUser.Text = "Welcome Teacher! : " + g.Fullname;

            g.GetGENID(CurrentUsername);
            CurrentGENID = g.GENID;

            UpdateAllTable();
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm l = new LoginForm();
            u.Action = "User Logout";
            u.UserLoginLog();
            l.Show();
        }

        ///////////////////////////////////////////////////////////////////
        ///
        ///Code for User starts Here
        /// 
        ///////////////////////////////////////////////////////////////////




        ///////////////////////////////////////////////////////////////////
        ///
        ///Code for User ends Here
        /// 
        ///////////////////////////////////////////////////////////////////








        ///////////////////////////////////////////////////////////////////
        ///
        ///Code for Equipment starts Here
        /// 
        ///////////////////////////////////////////////////////////////////







        ///////////////////////////////////////////////////////////////////
        ///
        ///Code for Equipment ends Here
        /// 
        ///////////////////////////////////////////////////////////////////







        ///////////////////////////////////////////////////////////////////
        ///
        ///Code for Transaction starts Here
        /// 
        ///////////////////////////////////////////////////////////////////

        //new Request
        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            NewRequest n = new NewRequest();
            n.GENID = CurrentGENID;
            n.ShowDialog();
            
            UpdateAllTable();
        }

        //Request Views
        private void rdoAllRequest_CheckedChanged(object sender, EventArgs e)
        {
            dgvRequest.DataSource = db.sp_TeacherViewAllRequest(CurrentGENID);
        }


        private void rdoAllRequest_CheckedChanged_1(object sender, EventArgs e)
        {
            dgvRequest.DataSource = db.sp_TeacherViewAllRequest(CurrentGENID);
        }
        //
        private void rdoOpenRequest_CheckedChanged_1(object sender, EventArgs e)
        {
            dgvRequest.DataSource = db.sp_TeacherViewOpenRequest(CurrentGENID);
        }
        private void rdoOpenRequest_CheckedChanged(object sender, EventArgs e)
        {
            dgvRequest.DataSource = db.sp_TeacherViewOpenRequest(CurrentGENID);
        }
        //

        private void rdoPendingRequest_CheckedChanged(object sender, EventArgs e)
        {
            dgvRequest.DataSource = db.sp_TeacherViewPendingRequest(CurrentGENID);
        }

        private void rdoPendingRequest_CheckedChanged_1(object sender, EventArgs e)
        {
            dgvRequest.DataSource = db.sp_TeacherViewPendingRequest(CurrentGENID);
        }
        //
        private void btnClosedRequest_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rdoDenied_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rdoDenied_CheckedChanged_1(object sender, EventArgs e)
        {
            dgvRequest.DataSource = db.sp_ViewDeniedRequest();
        }

        private void rdoApproved_CheckedChanged(object sender, EventArgs e)
        {
            dgvRequest.DataSource = db.sp_ViewApprovedRequest();
        }
        //Request Views




        private void dgvRequest_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AdminRequestReply a = new AdminRequestReply();
            a.RequestID = int.Parse(dgvRequest.CurrentRow.Cells[0].Value.ToString());
            a.RequestTitle = dgvRequest.CurrentRow.Cells[2].Value.ToString();
            a.DateRequested = DateTime.Parse(dgvRequest.CurrentRow.Cells[3].Value.ToString());
            a.RequestStatus = dgvRequest.CurrentRow.Cells[4].Value.ToString();
            if (a.RequestStatus == "OPEN" || a.RequestStatus == "PENDING") 
            {
                MetroMessageBox.Show(this, "The admin has not yet to replied your request", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                g.GetAdminRequestPerson(a.RequestID);
                g.GetUsername(g.GENID);
                g.GetFullname();
                a.AdminName = g.Fullname;
                a.DateReplied = g.GetDateReplied(a.RequestID);
                a.ReplyContent = g.GetRequestReply(a.RequestID);
                a.ShowDialog();
            }
        }

        ///////////////////////////////////////////////////////////////////
        ///
        ///Code for Transaction ends Here
        /// 
        ///////////////////////////////////////////////////////////////////

        private void UpdateAllTable()
        {
            dgvRequest.DataSource = db.sp_TeacherViewAllRequest(CurrentGENID);
        }
    }
}
