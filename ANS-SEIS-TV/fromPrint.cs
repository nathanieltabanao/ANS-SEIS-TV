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
    public partial class fromPrint : MetroForm
    {
        DataClasses1DataContext db = new DataClasses1DataContext();

        public int TransactionID;
        public string Borrower;
        public DateTime TransactionDate;
        public string Attendant;
        public DataSet Details;

        public fromPrint(int TID, string BorrowerName, DateTime BorrowDate, string AdminName)
        {
            InitializeComponent();

            TransactionID = TID;
            Borrower = BorrowerName;
            TransactionDate = BorrowDate;
            Attendant = AdminName;
            
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            IEnumerable<List> query = from TBLBORROWED in db.TBLBORROWEDs.AsEnumerable()
                                         join TBLEQUIPMENTDETAIL in db.TBLEQUIPMENTDETAILs on TBLBORROWED.EQUIPMENT_ID equals TBLEQUIPMENTDETAIL.EQUIPMENT_ID
                                         join TBLTRANSACTION in db.TBLTRANSACTIONs on TBLBORROWED.TransactionID equals TBLTRANSACTION.TransactionID
                                         join TBLEQUIPMENTBARCODE in db.TBLEQUIPMENTBARCODEs on TBLBORROWED.EQUIPMENT_ID equals TBLEQUIPMENTBARCODE.Equipment_ID
                                         where TBLBORROWED.TransactionID == TransactionID
                                         select new { TBLEQUIPMENTBARCODE.EQBarcodepath, TBLEQUIPMENTDETAIL.EQUIPMENT_ID, TBLEQUIPMENTDETAIL.EQUIPMENT_NAME, TBLBORROWED.Quantity };

            BorrowSlip1.SetDataSource(db.sp_CurrentBorrowed(TransactionID));
            BorrowSlip1.SetParameterValue("pTransactionID", TransactionID);
            BorrowSlip1.SetParameterValue("pBorrower", Borrower);
            BorrowSlip1.SetParameterValue("pDateBorrowed", TransactionDate);
            BorrowSlip1.SetParameterValue("pProcessedBy", Attendant);
            crystalReportViewer.ReportSource = BorrowSlip1;
        }

        private void fromPrint_Load(object sender, EventArgs e)
        {

        }
    }
}
