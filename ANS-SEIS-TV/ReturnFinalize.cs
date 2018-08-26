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
    public partial class ReturnFinalize : MetroForm
    {
        public ReturnFinalize()
        {
            InitializeComponent();

            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
        }

        public DataTable dgv;

        TransactionLibrary t = new TransactionLibrary();

        GetSomethingFromServer g = new GetSomethingFromServer();

        public int TransactionID { get; set; }
        public string Borrower { get; set; }
        public string Action { get; set; }
        public string TransactionType { get; set; }
        public int AdminID { get; set; }
        public int BorrowerID { get; set; }
        public int OldTransactionID { get; set; }

        private void ReturnFinalize_Load(object sender, EventArgs e)
        {
            g.Username = Borrower;
            g.GetFullname();
            lblBorrower.Text = "Borrower : " + g.Fullname;
            lblTransactionType.Text = "Transaction Type : " + TransactionType;
            lblTransactionID.Text = "Transaction ID : " + TransactionID;
            lblDate.Text = "Transaction Date :" + DateTime.Now.ToShortDateString();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy != true)
            {
                backgroundWorker1.RunWorkerAsync();
                LoadingScreen l = new LoadingScreen();
                l.ShowDialog();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            System.Threading.Thread.Sleep(2000);

            t.NewTransaction(DateTime.Now, Action, AdminID);
            foreach (DataGridViewRow row in dgvTransaction.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells[3].Value);
                if (isSelected)
                {
                    bool GoodCondition = Convert.ToBoolean(row.Cells[4].Value);

                    t.NewTransaction(DateTime.Now, Action, AdminID);
                    t.BorrowableEditQuantity(Convert.ToInt32(row.Cells[0].Value), g.GetEquipmentBorrowableQuantity(Convert.ToInt32(row.Cells[0].Value)) - Convert.ToInt32(row.Cells[2].Value));
                    t.ReturnEquipment(TransactionID, Convert.ToInt32(row.Cells[0].Value), Convert.ToInt32(row.Cells[2].Value), DateTime.Now, BorrowerID);
                    t.ReturnEquipmentEdit(OldTransactionID, Convert.ToInt32(row.Cells[0].Value), true,GoodCondition);
                }
            }
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
                this.Close();
            }
        }

        private void backgroundWorker1_RunWorkerCompleted_1(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MetroMessageBox.Show(this, "Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            else
            {
                MetroMessageBox.Show(this, "Transaction Complete", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
