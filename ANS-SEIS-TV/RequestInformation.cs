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
using MetroFramework.Forms;

namespace ANS_SEIS_TV
{
    public partial class RequestInformation : MetroForm
    {
        public int RequestID { get; set; }
        public string RequestFullname { get; set; }
        public DateTime DateRequested { get; set; }
        public string RequestStatus { get; set; }
        public string RequestTitle { get; set; }
        public string RequestMessage { get; set; }
        public int Reply { get; set; }
        public int CurrentGENID { get; set; }
        public int Response { get; set; }

        public RequestInformation()
        {
            InitializeComponent();

            
        }

        private void RequestInformation_Load(object sender, EventArgs e)
        {
            if (RequestStatus=="APPROVED"||RequestStatus=="DENIED")
            {
                btnReply.Enabled = false;
                btnReply.BackColor = Color.WhiteSmoke;
            }
            lblRequestID.Text = "Request ID : " + RequestID;
            lblRequestName.Text = "Requested By: " + RequestFullname;
            lblDateRequested.Text = "Date Requested : " + DateRequested.ToShortDateString();
            lblRequestStatus.Text = "Request Status : " + RequestStatus;
            txtRequestMessage.Text = RequestMessage;
            txtRequestSubject.Text = RequestTitle;
            txtRequestMessage.ReadOnly = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            RequestReply r = new RequestReply();
            r.CurrentGENID = CurrentGENID;
            r.RequestID = RequestID;
            r.ShowDialog();
            Reply = r.Reply;
            Response = r.Response;
            btnReply.Enabled = false;
        }
    }
}
