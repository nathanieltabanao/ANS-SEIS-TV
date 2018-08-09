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

        public void NewEquipmentRequest(int GENID, string Subject, string Content, DateTime Date, int StatusID)
        {
            db.sp_NewRequest(GENID, Subject, Content, Date, StatusID,0);
        }
    }
}
