using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Text.RegularExpressions;


namespace ANS_SEIS_TV
{
    class EquipmentLibrary
    {
        DataClasses1DataContext db = new DataClasses1DataContext();

        public int ID { get; set; }
        public string EquipmentBarcode { get; set; }
        public string EquipmentName { get; set; }
        public int EquipmentTypeID { get; set; }
        public int EquipmentQuantity { get; set; }
        public string EquipmentStatus { get; set; }
        public string IsDesignated { get; set; }
        public string EquipmentDescription { get; set; }
        public int IsBorrowable { get; set; }

        public string SearchKey { get; set; }

        public void EquipmentInsert()
        {
            db.sp_EquipmentRegister(/*EquipmentBarcode,*/ EquipmentName, EquipmentDescription, EquipmentTypeID, EquipmentQuantity,IsBorrowable);
        }

        public void EquipmentUpdate()
        {
            db.sp_EquipmentEdit(ID, /*EquipmentBarcode,*/ EquipmentName, EquipmentDescription, EquipmentTypeID, EquipmentQuantity);
        }

        public void EquipmentDelete()
        {
            db.sp_EquipmentDelete(ID);
        }

        public string IncompleteForms()
        {
            if (string.IsNullOrEmpty(EquipmentBarcode) || string.IsNullOrEmpty(EquipmentName))
            {
                return "Please fill all fields";
            }
            else
            {
                return "";
            }
        }

        public int EquipmentID()
        {
            return Convert.ToInt32(db.sp_EquipmentID());
        }

        public void EquipmentStatusAdd(int EQID, int GoodQuantity)
        {
            db.sp_EquipmentStatusInventoryAdd(EQID, GoodQuantity);
        }

        public void EquipmentStatusEdit(int EQID, int GoodQuantity, int BadQuantity)
        {
            db.sp_EquipmentStatusEdit(EQID, GoodQuantity, BadQuantity);
        }

        public void EquipmentStatusDelete(int EQID)
        {
            db.sp_EquipmentStatusItemDelete(EQID);
        }

        public void NewEquipmentPullOut(int EQID)
        {
            db.sp_PullOutNewEquipment(EQID, 0);
        }

        public void PullOutEquipmentEDIt(int EQID, int Qty)
        {
            db.sp_PullOutEquipment(EQID, Qty);
        }
    }
}
