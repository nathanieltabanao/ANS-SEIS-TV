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
    public partial class TransactionDetails : MetroForm
    {
        public TransactionDetails(int TransID, DateTime TDate, string AdminName, int AdID, string TType)
        {
            InitializeComponent();
            TransactionID = TransID;
            TransactionDate = TDate;
            AdminFullname = AdminName;
            AdminID = AdID;
            TransactionType = TType;
        }

        DataClasses1DataContext db = new DataClasses1DataContext();

        public int TransactionID { get; set; }
        public DateTime TransactionDate { get; set; }
        public string AdminFullname { get; set; }
        public int AdminID { get; set; }
        public string TransactionType { get; set; }


        private void TransactionDetails_Load(object sender, EventArgs e)
        {
            lblProcessedBY.Text = AdminFullname;
            lblTransactionDate.Text = TransactionDate.ToShortDateString();
            lblTransactionID.Text = TransactionID.ToString();
            lblTransactionType.Text = TransactionType;

            if (TransactionType== "Borrowed an Equipment")
            {
                dgvTransactionDetails.DataSource = db.sp_ViewBorrowedEquipment(TransactionID);
            }
        }
    }
}
