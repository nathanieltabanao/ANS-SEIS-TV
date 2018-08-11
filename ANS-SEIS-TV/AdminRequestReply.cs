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
using MaterialSkin.Controls;
using MaterialSkin;


namespace ANS_SEIS_TV
{
    public partial class AdminRequestReply : MetroForm
    {
        public AdminRequestReply()
        {
            InitializeComponent();
        }

        public int RequestID { get; set; }
        public DateTime DateRequested { get; set; }
        public DateTime DateReplied { get; set; }
        public string RequestStatus { get; set; }
        public int AdminID { get; set; }
        public string AdminName { get; set; }
        public string RequestTitle { get; set; }
        public string ReplyContent { get; set; }

        private void AdminRequestReply_Load(object sender, EventArgs e)
        {
            lblAdmin.Text = "Processed By : " + AdminName;
            lblRequestID.Text = "Request ID : " + RequestID;
            lblDateRequested.Text = "Date Requested : " + DateRequested;
            lblDateReplied.Text = "Date Replied : " + DateReplied;
            lblSubject.Text = "Re : " + RequestTitle;
            txtAdminReply.Text = ReplyContent;
            lblRequestStatus.Text = "Request Status : " + RequestStatus;
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
