using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;


namespace ANS_SEIS_TV
{
    class TestClass
    {
        //Temporary Class for Equipment since I can't get the Equipment Class working

        DataClasses1DataContext db = new DataClasses1DataContext();

        public int ID { get; set; }
        public string EquipmentBarcode { get; set; }
        public string EquipmentName { get; set; }
        public int EquipmentTypeID { get; set; }
        public int EquipmentQuantity { get; set; }
        public string EquipmentStatus { get; set; }
        public string IsDesignated { get; set; }
        public string EquipmentDescription { get; set; }

        public string SearchKey { get; set; }

        public void EquipmentInsert()
        {
            db.sp_EquipmentRegister(EquipmentBarcode, EquipmentName, EquipmentDescription, EquipmentTypeID, EquipmentQuantity);
        }

        public void EquipmentUpdate()
        {
            db.sp_EquipmentEdit(ID, EquipmentBarcode, EquipmentName, EquipmentDescription, EquipmentTypeID, EquipmentQuantity);
        }

        public void EquipmentDelete()
        {
            db.sp_EquipmentDelete(ID);
        }

        public string IncompleteForms()
        {
            if (string.IsNullOrEmpty(EquipmentBarcode) || string.IsNullOrEmpty(EquipmentName)||string.IsNullOrEmpty(EquipmentDescription))
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
    }
}
