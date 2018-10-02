using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
using MaterialSkin;
using MaterialSkin.Controls;


namespace ANS_SEIS_TV
{
    public partial class fromBorrowSlip : MetroForm
    {
        DataClasses1DataContext db = new DataClasses1DataContext();

        public int TransactionID;
        public string Borrower;
        public DateTime TransactionDate;
        public string Attendant;
        public DataSet Details;

        public fromBorrowSlip(int TID, string BorrowerName, DateTime BorrowDate, string AdminName)
        {
            InitializeComponent();

            TransactionID = TID;
            Borrower = BorrowerName;
            TransactionDate = BorrowDate;
            Attendant = AdminName;
            
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            BorrowSlip1.SetParameterValue("@TransactionID", TransactionID);
            BorrowSlip1.SetParameterValue("pTransactionID", TransactionID);
            BorrowSlip1.SetParameterValue("pBorrower", Borrower);
            BorrowSlip1.SetParameterValue("pDateBorrowed", TransactionDate);
            BorrowSlip1.SetParameterValue("pProcessedBy", Attendant);
            BorrowSlip1.SetParameterValue("@SearchBarcode", TransactionID);
            crystalReportViewer.ReportSource = BorrowSlip1;
        }

        private void fromPrint_Load(object sender, EventArgs e)
        {

        }
    }
}
