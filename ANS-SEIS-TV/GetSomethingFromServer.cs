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
        public string ID { get; set; }
        public int FirstLogin { get; set; }
        public int UsertypeID { get; set; }
        public int GENID { get; set; }
        public string Fullname { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }


        public void GetSomething()
        {
            Username = "nathan";
            var results = from TBLUSERDETAIL in db.TBLUSERDETAILs
                          where TBLUSERDETAIL.USERNAME == Username
                          select TBLUSERDETAIL.USERTYPE_ID;

            //string usertypeid = results.FirstOrDefault().Value.ToString();
        }

        public void GetFirstLogin()
        {
            var results = from TBLUSERDETAIL in db.TBLUSERDETAILs
                          where TBLUSERDETAIL.USERNAME == Username
                          select TBLUSERDETAIL.ISFIRSTLOGIN;

            FirstLogin = int.Parse(results.FirstOrDefault().Value.ToString());
        }

        public void GetUserType()
        {
            var results = from TBLUSERDETAIL in db.TBLUSERDETAILs
                          where TBLUSERDETAIL.USERNAME == Username
                          select TBLUSERDETAIL.USERTYPE_ID;

            UsertypeID = int.Parse(results.FirstOrDefault().ToString());
        }

        public void GetUserID()
        {
            var results = from TBLUSERDETAIL in db.TBLUSERDETAILs
                          where TBLUSERDETAIL.USERNAME == Username
                          select TBLUSERDETAIL.ID;

            GENID = int.Parse(results.FirstOrDefault().ToString());
        }

        public void GetFullname()
        {
            //var results = from TBLUSERDETAIL in db.TBLUSERDETAILs
            //              where TBLUSERDETAIL.USERNAME == Username
            //              select new { Fullname = TBLUSERDETAIL.FIRSTNAME + " " + TBLUSERDETAIL.MIDDLENAME + " " + TBLUSERDETAIL.LASTNAME };

            //Fullname = results.FirstOrDefault().ToString();

            GetFirstName();
            GetMiddleName();
            GetLastName();
            Fullname = FirstName + " " + MiddleName + " " + LastName;
        }

        public void GetFirstName()
        {
            var results = from TBLUSERDETAIL in db.TBLUSERDETAILs
                          where TBLUSERDETAIL.USERNAME == Username
                          select TBLUSERDETAIL.FIRSTNAME;
                
            FirstName = results.FirstOrDefault().ToString();
        }

        public void GetMiddleName()
        {
            var results = from TBLUSERDETAIL in db.TBLUSERDETAILs
                          where TBLUSERDETAIL.USERNAME == Username
                          select TBLUSERDETAIL.MIDDLENAME;

            MiddleName = results.FirstOrDefault().ToString();
        }

        public void GetLastName()
        {
            var results = from TBLUSERDETAIL in db.TBLUSERDETAILs
                          where TBLUSERDETAIL.USERNAME == Username
                          select TBLUSERDETAIL.LASTNAME;

            LastName = results.FirstOrDefault().ToString();
        }

        public void GetGENID()
        {
            var results = from TBLUSERDETAIL in db.TBLUSERDETAILs
                          where TBLUSERDETAIL.USERNAME == Username
                          select TBLUSERDETAIL.GENID;

            GENID = int.Parse(results.FirstOrDefault().ToString());
        }
    }
}
