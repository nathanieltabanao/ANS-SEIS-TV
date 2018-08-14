using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;

namespace ANS_SEIS_TV
{
    class TransactionLibrary
    {
        DataClasses1DataContext db = new DataClasses1DataContext();

        public string RequestSubject { get; set; }
        public int RequestID { get; set; }
        public string RequestContent { get; set; }
        public DateTime RequestDate { get; set; }
        public int RequestStatus { get; set; }
        public string Action { get; set; }
        public int TID { get; set; }

        public void NewEquipmentRequest(int GENID, string Subject, string Content, DateTime Date, int StatusID)
        {
            db.sp_NewRequest(GENID, Subject, Content, Date, StatusID,0);
        }

        public void NewBorrowed(int TransactionID, int WhoBorrowed, int EQID, DateTime DateBorrowed, int Quantity)
        {
            db.sp_NewBorrow(TransactionID, WhoBorrowed, EQID, DateBorrowed, Quantity);
        }

        public void NewTransaction(DateTime DateTransacted,string Action,int AdminID)
        {
            TransactionID();
            db.sp_NewTransation(DateTransacted, Action, AdminID);
        }

        public void TransactionID()
        {
            TID = db.sp_NewTransactionID();
        }

        public void DeleteDeletedEquipment(int EQID)
        {
            db.sp_DeleteDeletedEquipment(EQID);
        }

        public void NewEquipmentAdded(int EquipmentID, int Quantity)
        {
            db.sp_NewBorrowQuantityAdded(EquipmentID, Quantity);
        }

        public void BorrowableEditQuantity(int EquipmentID, int Quantity)
        {
            db.sp_BorrowAddQuantity(EquipmentID, Quantity);
        }
    }
}
