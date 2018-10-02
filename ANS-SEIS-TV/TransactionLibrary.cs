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

        public void NewBorrowed(int TransactionID, int WhoBorrowed, int EQID, DateTime DateBorrowed, int Quantity, bool IsReturned, bool IsGoodCondition)
        {
            db.sp_NewBorrow(TransactionID, WhoBorrowed, EQID, DateBorrowed, Quantity,IsReturned,IsGoodCondition);
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
        
        public void ReturnEquipment(int TransactionID,int EquipmentID, int Quantity, DateTime DateReturned,int GENID)
        {
            db.sp_ReturnEquipments(TransactionID, EquipmentID, Quantity, DateReturned, GENID);
        }

        public void ReturnEquipmentEdit(int TransactionID, int EquipmentID, bool Returned, bool GoodCondition)
        {
            db.sp_EquipmentReturning(TransactionID, EquipmentID, GoodCondition, Returned);
        }

        public void NewEquipmentReservation(int TransactionID, int WhoReserved, int EQID, DateTime DateBorrowed, int Qty, bool IsReturned)
        {
            db.sp_NewReservation(TransactionID, WhoReserved, EQID, DateBorrowed, Qty, IsReturned);
        }

        public void EquipmentReservationReturning(int TransactionID, int EQID, bool IsReturned)
        {
            db.sp_ReturnReservedEquipment(TransactionID, EQID, IsReturned);
        }

        public void DeploymentPullOut(string RoomN, int EQID, int Qty)
        {
            db.sp_DeploymentPullOut(RoomN, EQID, Qty);
        }
    }
}
