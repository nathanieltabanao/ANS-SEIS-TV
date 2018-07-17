using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;


namespace ANS_SEIS_TV
{
    class EquipmentLibrary
    {
        DataClasses1DataContext db = new DataClasses1DataContext();

        public int EquipmentID { get; set; }
        public string EquipmentBarcode { get; set; }
        public string EquipmentName { get; set; }
        public int EquipmentTypeID { get; set; }
        public int EquipmentQuantity { get; set; }
        public string EquipmentStatus { get; set; }
        public string IsDesignated { get; set; }

        public string SearchKey { get; set; }

        public void EquipmentInsert()
        {
            //db.sp_EquipmentInsert(EquipmentBarcode, EquipmentName, EquipmentTypeID, EquipmentStatus, IsDesignated);
        }

        public void EquipmentUpdate()
        {
            //db.sp_EquipmentUpdate(EquipmentID, EquipmentName, EquipmentTypeID, EquipmentStatus, IsDesignated);
        }

        public void EquipmentDelete()
        {
            //db.sp_EquipmentDelete(EquipmentBarcode);
        }

        public string IncompleteForms()
        {
            if (string.IsNullOrEmpty(EquipmentBarcode)||string.IsNullOrEmpty(EquipmentName))
            {
                return "Please fill all fields";
            }
            else
            {
                return "";
            }
        }
    }
}
