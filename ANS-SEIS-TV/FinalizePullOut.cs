using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Threading;

namespace ANS_SEIS_TV
{
    public partial class FinalizePullOut : MetroForm
    {
        int AdminID, TeacherID, TID;
        public int Done { get; set; }
        string TeacherName, AdminName, RoomNumber, RoomName;
        

        GetSomethingFromServer g = new GetSomethingFromServer();

        TransactionLibrary t = new TransactionLibrary();

        EquipmentLibrary eq = new EquipmentLibrary();
        

        public FinalizePullOut(int Admin, int Teacher, string RMNUm, string RMName)
        {
            InitializeComponent();
            

            AdminID = Admin;
            g.GetUsername(AdminID);
            g.GetFullname();
            AdminName = g.Fullname;

            TeacherID = Teacher;
            g.GetUsername(TeacherID);
            g.GetFullname();
            TeacherName = g.Fullname;

            RoomNumber = RMNUm;
            RoomName = RMName;
            Done = 0;
        }

        private void FinalizePullOut_Load(object sender, EventArgs e)
        {
            t.TransactionID();

            lblTransactionID.Text = t.TID.ToString();
            lblProcessedBy.Text = AdminName;
            lblRoomNumber.Text = RoomNumber;
            lblTeacherName.Text = TeacherName;
            lblTransactionDate.Text = DateTime.Now.ToShortDateString();
            lblTransactionType.Text = "Equipment Pull-Out";
        }

        private void btnSubmitPullOut_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy != true)
            {
                Done = 1;
                backgroundWorker1.RunWorkerAsync();
                LoadingScreen2 l = new LoadingScreen2();
                l.ShowDialog();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(2000);

            int BadEQ = 0;

            foreach (DataGridViewRow row in dgvPullOutFinal.Rows)
            {
                bool isSeleted = Convert.ToBoolean(row.Cells[3].Value);
                if (isSeleted)
                {
                    if (string.IsNullOrEmpty(row.Cells["PullOutQty"].Value.ToString().Trim()))
                    {
                        MetroMessageBox.Show(this, "Please input number of equipment to pull-out", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (int.TryParse(row.Cells["PullOutQty"].Value.ToString(), out BadEQ))
                        {
                            int Avail = Convert.ToInt32(row.Cells[2].Value.ToString());
                            if (Avail >= BadEQ)
                            {
                                int Value = g.GetPullOutQuantity(Convert.ToInt32(row.Cells[0].Value.ToString())); // this will be the one to modify this shit
                                eq.PullOutEquipmentEDIt(Convert.ToInt32(row.Cells[0].Value.ToString()), (Value - BadEQ));

                                t.DeploymentPullOut(RoomNumber, Convert.ToInt32(row.Cells[0].Value.ToString()), BadEQ);
                            }
                            else
                            {
                                MetroMessageBox.Show(this, "You cannot Pull-Out more than what is available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MetroMessageBox.Show(this, "Please input an whole number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {

                }
            }
        }


        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MetroMessageBox.Show(this, "Deployment Record Updated!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
        }
    }
}
