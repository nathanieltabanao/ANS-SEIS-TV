﻿using System;
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
        public string RequestContent { get; set; }
        public string Content { get; set; }
        public int RequestID { get; set; }

        public int EquipmentID { get; set; }
        public string EquipmentName { get; set; }


        //public void GetUserType()
        //{   
        //    var results = from TBLUSERDETAIL in db.TBLUSERDETAILs
        //                  where TBLUSERDETAIL.USERNAME == Username
        //                  select TBLUSERDETAIL.USERTYPE_ID;
        //    UsertypeID = int.Parse(results.FirstOrDefault().Value.ToString());
        //}

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

            var temp = results?.FirstOrDefault()?.ToString();
            if (temp==null)
            {
                ID = null;
            }
            else
            {
                ID = results.FirstOrDefault().ToString();
            }
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

        public int GetGENID(string Username)
        {
            var results = from TBLUSERDETAIL in db.TBLUSERDETAILs
                          where TBLUSERDETAIL.USERNAME == Username
                          select TBLUSERDETAIL.GENID;

            GENID = int.Parse(results.FirstOrDefault().ToString());

            return GENID;
        }

        public void GetRequestContent()
        {
            var results = from TBLREQUESTTABLE in db.TBLREQUESTTABLEs
                          where TBLREQUESTTABLE.REQUESTID == GENID // the ID here refers to the request ID
                          select TBLREQUESTTABLE.REQUESTCONTENT;

            RequestContent = results.FirstOrDefault().ToString();
        }

        public void GetRequestStatus()
        {
            var results = from TBLREQUESTTABLE in db.TBLREQUESTTABLEs
                          where TBLREQUESTTABLE.REQUESTID == GENID // the ID here refers to the request ID
                          select TBLREQUESTTABLE.REQUESTCONTENT;
        }

        public void GetAdminRequestPerson(int RequestID)
        {
            var results = from TBLREQUESTREPLY in db.TBLREQUESTREPLies
                          where TBLREQUESTREPLY.REQUESTID == RequestID // id of the request
                          select TBLREQUESTREPLY.GENID;

            GENID = int.Parse(results.FirstOrDefault().Value.ToString());
        }

        public void GetUsername(int GENID)
        {
            var results = from TBLUSERDETAIL in db.TBLUSERDETAILs
                          where TBLUSERDETAIL.GENID == GENID
                          select TBLUSERDETAIL.USERNAME;

            Username = results.FirstOrDefault().ToString();
        }
        
        public string GetRequestReply(int RequestID)
        {
            var results = from TBLREQUESTREPLY in db.TBLREQUESTREPLies
                          where TBLREQUESTREPLY.REQUESTID == RequestID
                          select TBLREQUESTREPLY.ReplyContent;

           return results.FirstOrDefault().ToString();
        }

        public DateTime GetDateReplied(int RequestID)
        {
            var results = from TBLREQUESTREPLY in db.TBLREQUESTREPLies
                          where TBLREQUESTREPLY.REQUESTID == RequestID
                          select TBLREQUESTREPLY.DateReplied;

            return DateTime.Parse(results.FirstOrDefault().Value.ToString());
        }

        public string GetEquipmentName(int EquipmentID)
        {
            var results = from TBLEQUIPMENTDETAIL in db.TBLEQUIPMENTDETAILs
                          where TBLEQUIPMENTDETAIL.EQUIPMENT_ID == EquipmentID
                          select TBLEQUIPMENTDETAIL.EQUIPMENT_NAME;

            return results.FirstOrDefault().ToString();
        }

        public int GetEquipmentBorrowableQuantity(int EquipmentID)
        {
            var results = from TBLBORROWQUANTITY in db.TBLBORROWQUANTITies
                          where TBLBORROWQUANTITY.EQUIPMENT_ID == EquipmentID
                          select TBLBORROWQUANTITY.QUANTITY;
            return int.Parse(results.FirstOrDefault().Value.ToString());
        }
    }
}
