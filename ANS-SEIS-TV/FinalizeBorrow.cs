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
using System.Globalization;
using System.IO;

namespace ANS_SEIS_TV
{
    public partial class FinalizeTransaction : MetroForm
    {
        public FinalizeTransaction()
        {
            InitializeComponent();

            this.BorderStyle = MetroFormBorderStyle.FixedSingle;
            this.ShadowType = MetroFormShadowType.AeroShadow;

            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
        }

        public DataTable dgv;

        TransactionLibrary t = new TransactionLibrary();

        GetSomethingFromServer g = new GetSomethingFromServer();

        DataClasses1DataContext db = new DataClasses1DataContext();

        fromBorrowSlip f;

        StuffLibrary s = new StuffLibrary();

        public int TransactionID { get; set; }
        public string Borrower { get; set; }
        public string Action { get; set; }
        public string TransactionType { get; set; }
        public int AdminID { get; set; }
        public int BorrowerID { get; set; }
        public string AdminName;
        public string BorrowerName { get; set; }

        public int Done { get; set; }
        

        private void FinalizeTransaction_Load(object sender, EventArgs e)
        {
            g.Username = Borrower;
            g.GetFullname();
            lblBorrower.Text = "Borrower : " + g.Fullname;
            BorrowerName = g.Fullname;
            lblTransactionType.Text = "Transaction Type : " + TransactionType;
            lblTransactionID.Text = "Transaction ID : " + TransactionID;
            lblDate.Text = "Transaction Date :" + DateTime.Now.ToShortDateString();
            Done = 0;
        }

        public DataGridView CopyDataGridView(DataGridView dgv_org)
        {
            DataGridView dgv_copy = new DataGridView();
            try
            {
                if (dgv_copy.Columns.Count == 0)
                {
                    foreach (DataGridViewColumn dgvc in dgv_org.Columns)
                    {
                        dgv_copy.Columns.Add(dgvc.Clone() as DataGridViewColumn);
                    }
                }

                DataGridViewRow row = new DataGridViewRow();

                for (int i = 0; i < dgv_org.Rows.Count; i++)
                {
                    row = (DataGridViewRow)dgv_org.Rows[i].Clone();
                    int intColIndex = 0;
                    foreach (DataGridViewCell cell in dgv_org.Rows[i].Cells)
                    {
                        row.Cells[intColIndex].Value = cell.Value;
                        intColIndex++;
                    }
                    dgv_copy.Rows.Add(row);
                }
                dgv_copy.AllowUserToAddRows = false;
                dgv_copy.Refresh();

            }
            catch (Exception ex)
            {
                //cf.ShowExceptionErrorMsg("Copy DataGridViw", ex);
            }
            return dgv_copy;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy != true)
            {
                backgroundWorker1.RunWorkerAsync();
                LoadingScreen2 l = new LoadingScreen2();
                l.ShowDialog();
                Done = 1;
            }


            //    t.NewTransaction(DateTime.Now, Action, AdminID);

            //    foreach (DataGridViewRow row in dgvTransaction.Rows)
            //    {
            //        t.NewBorrowed(TransactionID, g.GetGENID(Borrower), Convert.ToInt32(row.Cells[0].Value), DateTime.Now, Convert.ToInt32(row.Cells[2].Value),false,false);
            //        t.BorrowableEditQuantity(Convert.ToInt32(row.Cells[0].Value), g.GetEquipmentBorrowableQuantity(Convert.ToInt32(row.Cells[0].Value)) +Convert.ToInt32(row.Cells[2].Value));
            //    }
            //    MetroMessageBox.Show(this, "Transaction Complete", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int Quantity = 0;
            BackgroundWorker worker = sender as BackgroundWorker;

            System.Threading.Thread.Sleep(2000);

            t.NewTransaction(DateTime.Now, Action, AdminID);
            foreach (DataGridViewRow row in dgvTransaction.Rows)
            {
                t.NewBorrowed(TransactionID, g.GetGENID(Borrower), Convert.ToInt32(row.Cells[0].Value), DateTime.Now, Convert.ToInt32(row.Cells[2].Value), false);
                t.BorrowableEditQuantity(Convert.ToInt32(row.Cells[0].Value), g.GetEquipmentBorrowableQuantity(Convert.ToInt32(row.Cells[0].Value)) + Convert.ToInt32(row.Cells[2].Value));
                Quantity = Quantity + Convert.ToInt32(row.Cells[2].Value);
            }
            s.GenerateBarcode(TransactionID.ToString());

            db.sp_UserBorrowAdd(g.GetGENID(Borrower), g.GetTotalAmountBorrowed(g.GetGENID(Borrower)) + Quantity);

            String strBLOBFilePath = s.SavePath;//Modify this path as needed.

            //Read jpg into file stream, and from there into Byte array.
            FileStream fsBLOBFile = new FileStream(strBLOBFilePath, FileMode.Open, FileAccess.Read);
            Byte[] bytBLOBData = new Byte[fsBLOBFile.Length];
            fsBLOBFile.Read(bytBLOBData, 0, bytBLOBData.Length);
            fsBLOBFile.Close();

            db.sp_NewBorrowBarcodeInsert(TransactionID, bytBLOBData, s.SavePath);
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
                f = new fromBorrowSlip(TransactionID, BorrowerName, DateTime.Parse(DateTime.Now.ToShortDateString()), AdminName);
                f.ShowDialog();
                btnSubmit.Enabled = false;
                this.Dispose(); 
            }
        }

        private void dgvTransaction_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
