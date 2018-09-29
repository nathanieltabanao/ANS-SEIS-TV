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
using System.Threading;
using System.IO;

namespace ANS_SEIS_TV
{
    public partial class FinalizeDeployment : MetroForm
    {
        int TransactionID { get; set; }
        string Room { get; set; }
        int Teacher { get; set; }
        DateTime DeploymentDate { get; set; }
        int Count;
        int Admin { get; set; }

        GetSomethingFromServer g = new GetSomethingFromServer();

        TransactionLibrary t = new TransactionLibrary();

        StuffLibrary s = new StuffLibrary();

        DataClasses1DataContext db = new DataClasses1DataContext();

        public FinalizeDeployment(int TID, string RoomNo, int TeacherID, DateTime Date, int ItemCount, int AdminID)
        {
            InitializeComponent();
            TransactionID = TID;
            Room = RoomNo;
            lblTransactionID.Text = TID.ToString();
            lblRoomNo.Text = RoomNo;
            lblTransactionDate.Text = Date.ToShortDateString();
            lblNumberItems.Text = ItemCount.ToString();

            g.GetUsername(TeacherID);
            g.GetFullname();

            lblTeacher.Text = g.Fullname;

            g.GetUsername(AdminID);
            g.GetFullname();

            lblProcessedBy.Text = g.Fullname;

            Teacher = TeacherID;
            Admin = AdminID;
            DeploymentDate = Date;
        }

        private void btnFinalize_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy != true) 
            {
                backgroundWorker1.RunWorkerAsync();
                LoadingScreen2 l = new LoadingScreen2();
                l.ShowDialog();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(2000);
            if (InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    Deployment();
                }
                ));
            }
            else
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    Deployment();  
                }
                ));
            }
        }

        private void Deployment()
        {
            t.TransactionID();
            t.NewTransaction(DateTime.Now, "Deployed an Equipment", Admin);
            db.sp_NewDeployment(t.TID, g.GetFacilityID(Room));
            foreach (DataGridViewRow row in dgvDeployList.Rows)
            {
                t.NewBorrowed(t.TID, Teacher, Convert.ToInt32(row.Cells[0].Value), DateTime.Now, Convert.ToInt32(row.Cells[2].Value), false, false);
                t.BorrowableEditQuantity(Convert.ToInt32(row.Cells[0].Value), g.GetEquipmentBorrowableQuantity(Convert.ToInt32(row.Cells[0].Value)) + Convert.ToInt32(row.Cells[2].Value));
            }
            s.GenerateBarcode(t.TID.ToString());

            String strBLOBFilePath = s.SavePath;//Modify this path as needed.

            //Read jpg into file stream, and from there into Byte array.
            FileStream fsBLOBFile = new FileStream(strBLOBFilePath, FileMode.Open, FileAccess.Read);
            Byte[] bytBLOBData = new Byte[fsBLOBFile.Length];
            fsBLOBFile.Read(bytBLOBData, 0, bytBLOBData.Length);
            fsBLOBFile.Close();

            db.sp_NewBorrowBarcodeInsert(t.TID, bytBLOBData, s.SavePath);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MetroMessageBox.Show(this, "Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MetroMessageBox.Show(this, "Transaction Complete", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmDeployment d = new frmDeployment(lblProcessedBy.Text, lblTeacher.Text, Convert.ToDateTime(lblTransactionDate.Text), DeploymentDate, Room, TransactionID.ToString());
                d.ShowDialog();
                this.Dispose();

            }
        }
    }
}
