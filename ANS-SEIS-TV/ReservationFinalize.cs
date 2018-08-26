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

namespace ANS_SEIS_TV
{
    public partial class ReservationFinalize : MetroForm
    {
        public ReservationFinalize()
        {
            InitializeComponent();
        }

        TransactionLibrary t = new TransactionLibrary();

        GetSomethingFromServer g = new GetSomethingFromServer();

        public int TransactionID { get; set; }
        public string Reservee { get; set; }
        public string Action { get; set; }
        public string TransactionType { get; set; }
        public int AdminID { get; set; }
        public int ReserveeID { get; set; }
        public DateTime ReservationDate { get; set; }

        private void ReservationFinalize_Load(object sender, EventArgs e)
        {
            g.Username = Reservee;
            g.GetFullname();
            lblReservee.Text = "Reservee :" + g.Fullname;
            lblReservationID.Text = "Transaction ID :" + TransactionID;
            lblReservationDate.Text = "Reservation Date :" + ReservationDate.ToShortDateString();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            t.NewTransaction(DateTime.Now, Action, AdminID);
            foreach (DataGridViewRow row  in dgvReservation.Rows)
            {
                t.NewEquipmentReservation(TransactionID, ReserveeID, Convert.ToInt32(row.Cells[0].Value), ReservationDate, Convert.ToInt32(row.Cells[2].Value), false);
                t.BorrowableEditQuantity(Convert.ToInt32(row.Cells[0].Value), g.GetEquipmentBorrowableQuantity(Convert.ToInt32(row.Cells[0].Value)) + Convert.ToInt32(row.Cells[2].Value));
            }
            MetroMessageBox.Show(this, "Transaction Complete", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
