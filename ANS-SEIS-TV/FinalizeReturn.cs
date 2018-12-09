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
    public partial class FinalizeReturn : MetroForm
    {
        public FinalizeReturn()
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

            EquipmentLibrary eq = new EquipmentLibrary();

            t.NewTransaction(DateTime.Now, Action, AdminID);

            int GoodEQ = 0, BadEQ=0;

            t.NewTransaction(DateTime.Now, Action, AdminID);

            foreach (DataGridViewRow row in dgvTransaction.Rows)
            {
                int ReturnQty = 0;
                
                
                // bool isSelected = Convert.ToBoolean(row.Cells[3].Value);
                if (Convert.ToBoolean(row.Cells[3].Value)) // should be isSelected but deprecated for speed issues
                {
                    // bool GoodCondition = Convert.ToBoolean(row.Cells[4].Value);
                    

                    if (string.IsNullOrEmpty(row.Cells["QuantityToReturn"].Value.ToString().Trim()))
                    {
                        MetroMessageBox.Show(this, "Please input number of equipment to return", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (int.TryParse(row.Cells["QuantityToReturn"].Value.ToString(),out ReturnQty))
                        {

                            // if checked then count 
                            
                         GoodEQ = Convert.ToInt32(row.Cells[4].Value);
                         BadEQ = Convert.ToInt32(row.Cells[2].Value) - GoodEQ;

                            t.BorrowableEditQuantity(Convert.ToInt32(row.Cells[0].Value), g.GetEquipmentBorrowableQuantity(Convert.ToInt32(row.Cells[0].Value)) - GoodEQ);
                            //g.GetEquipmentBorrowableQuantity(Convert.ToInt32(row.Cells[0].Value)) - Convert.ToInt32(row.Cells[2].Value))
                            //spits total number of that is borrowed then minus the returned number


                            t.ReturnEquipment(TransactionID, Convert.ToInt32(row.Cells[0].Value), GoodEQ, DateTime.Now, BorrowerID);

                            if (Convert.ToInt32(row.Cells[2].Value) == GoodEQ)
                            {
                                t.ReturnEquipmentEdit(OldTransactionID, Convert.ToInt32(row.Cells[0].Value), 0, true);
                            }
                            else
                            {
                                t.ReturnEquipmentEdit(OldTransactionID, Convert.ToInt32(row.Cells[0].Value), 0, false);
                            }

                            // Cell [0] is Equipment ID
                            // Good EQ is always padung deduction so current Good Eq - Bad nga gi returend
                            // Bad EQ is always pasaka kay bad EQ + current nga gi returend
                            eq.EquipmentStatusEdit(Convert.ToInt32(row.Cells[0].Value), g.GetQuantityGoodConditionEQ(Convert.ToInt32(row.Cells[0].Value)) - BadEQ, g.GetQuantityBadConditionEQ(Convert.ToInt32(row.Cells[0].Value)) + BadEQ);
                        }
                    }

                    
                    
                    
                }
                else
                {

                }
                GoodEQ = BadEQ = 0;
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
