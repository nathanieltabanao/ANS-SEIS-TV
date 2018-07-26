using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ANS_SEIS_TV
{
    class GetSomethingFromServer
    {
        DataClasses1DataContext db = new DataClasses1DataContext();

        public string Username { get; set; }

        public void GetSomething()
        {
            Username = "nathan";
            var results = from TBLUSERDETAIL in db.TBLUSERDETAILs
                          where TBLUSERDETAIL.USERNAME == Username
                          select TBLUSERDETAIL.USERTYPE_ID;

            string usertypeid = results.FirstOrDefault().Value.ToString();
        }
    }
}
