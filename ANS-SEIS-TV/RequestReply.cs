using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using MetroFramework;
using MetroFramework.Forms;

namespace ANS_SEIS_TV
{
    public partial class RequestReply : MetroForm
    {
        public RequestReply()
        {
            InitializeComponent();
        }

        public int Reply { get; set; }
        public int CurrentGENID { get; set; }

        DataClasses1DataContext db = new DataClasses1DataContext();

        private void btnReply_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtReply.Text))
            {
                Reply = 0;
                MetroMessageBox.Show(this, "Please do not leave the reply box empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Reply = 1;
                db.sp_RequestReply(CurrentGENID, txtReply.Text);

                MetroMessageBox.Show(this, "Reply Submitted!", "Request Reply");
                this.Hide();
            }
        }
    }
}
