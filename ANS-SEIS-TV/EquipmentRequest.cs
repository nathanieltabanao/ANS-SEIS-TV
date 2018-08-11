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

namespace ANS_SEIS_TV
{
    public partial class NewRequest : MetroForm
    {
        public NewRequest()
        {
            InitializeComponent();

            this.ShadowType = MetroFormShadowType.AeroShadow;
        }

        TransactionLibrary t = new TransactionLibrary();

        UserLibrary u = new UserLibrary();

        public int GENID { get; set; }

        private void EquipmentRequest_Load(object sender, EventArgs e)
        {

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSubject.Text))
            {
                MetroMessageBox.Show(this, "Please enter a Request Subject", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtContent.Text))
            {
                MetroMessageBox.Show(this, "Please enter a Request Message", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                t.RequestContent = txtContent.Text;
                t.RequestDate = DateTime.Now;
                t.RequestStatus = 300;
                t.RequestSubject = txtSubject.Text;


                t.NewEquipmentRequest(GENID, t.RequestSubject, t.RequestContent, t.RequestDate, t.RequestStatus);

                MetroMessageBox.Show(this, "Request Submitted!", "Equipment Request");
                this.Hide();
            }
        }
    }
}
