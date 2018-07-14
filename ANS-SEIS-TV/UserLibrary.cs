using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.IO;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace ANS_SEIS_TV
{
    class UserLibrary
    {
        //Initate SQL Connection
        DataClasses1DataContext db = new DataClasses1DataContext();

        

        //Declare Variables
        public string Address { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int GENID { get; set; }
        public string ID { get; set; }
        public string SecurityQuestion { get; set; }
        public string SecurityAnswer { get; set; }
        public int Usertype { get; set; }
        public DateTime Birthdate { get; set; }
        public int Age { get; set; }
        public int LoginResult { get; set; }
        public string Searchkey { get; set; }
        int result;
        public int CurrentUserID { get; set; }
        public string CurrentUsername { get; set; }
        public int CurrentUsertype { get; set; }
        public string Action { get; set; }
        public string status;

        public void Clear()
        {
            Address = null;
            Email = null;
            FirstName = null;
            MiddleName = null;
            LastName = null;
            Username = null;
            Password = null;
            //GENID = null;
            ID = null;
            SecurityAnswer = null;
            SecurityQuestion = null;
            Username = null;
            //Age = null;
            //LoginResult = null;
        }

        public int LoginIsEmpty()
        {
            if (string.IsNullOrEmpty(Username)||string.IsNullOrEmpty(Password))
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }

        public int IncompleteUserData()
        {
            if (string.IsNullOrEmpty(Address) || string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(FirstName) || string.IsNullOrEmpty(MiddleName) || string.IsNullOrEmpty(LastName) || string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password) || string.IsNullOrEmpty(SecurityAnswer) || string.IsNullOrEmpty(SecurityQuestion)) 
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public string UserRegistered()
        {
            return "User Registered!";
        }

        public string LoginSuccess()
        {
            return "Login Success";
        }

        public string LoginFailed()
        {
            return "Invalid Username or Password!";
        }

        public string ActionFailed()
        {
            return "Error!";
        }

        public int EmailError()
        {
            if (IsValidEmail(Email))
            {
                return 0;
            }
            else
            { 
            return 1;
            }
        }

        public string InvalidEmail()
        {
            return "Invalid Email Address!";
        }

        bool IsValidEmail(string strIn)//Do not Delete
        {
            // Return true if strIn is in valid e-mail format.
            return Regex.IsMatch(strIn, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }

        public string EmptyUsername()
        {
            
            return "Please fill your username!";
        }



        public string EmptyPassword()
        {
            return "Please fill password!";
        }

        public void CalculateAge()
        {
            TimeSpan age = DateTime.Now - Birthdate;
            int years = DateTime.Now.Year - Birthdate.Year;
            if (Birthdate.AddYears(years) > DateTime.Now)
            {
                years--;
            }

            Age = years;
        }

        public string PasswordHashing(string password, string salt)
        {
            SHA256Managed sha = new SHA256Managed();
            //compute has from the bytes of text

            sha.ComputeHash(ASCIIEncoding.ASCII.GetBytes(salt + password + salt));
            //get hash result after computation


            byte[] result = sha.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                // change it into 2 hex digits
                //for each type

                strBuilder.Append(result[i].ToString("x2"));
            }
            return strBuilder.ToString();
        }

        public void UserInsert()
        {
            db.sp_UserInsert(null, ID, Username, Password, FirstName, MiddleName, LastName, Address, Birthdate, Email, SecurityQuestion, SecurityAnswer, Usertype);
            //db.sp_UserActionReport(CurrentUserID, CurrentUsername, "Registered a user", DateTime.Now); //for testing
        }

        public void UserEdit()
        {
            db.sp_UserEdit(ID, Username, Password, FirstName, MiddleName, LastName, Address, Birthdate, Email, SecurityQuestion, SecurityAnswer);
        }

        public void UserDelete()
        {
            db.sp_UserDelete(ID);
        }

        public void UserLogin(/*string Username,string Password*/)
        {
            result = db.sp_UserLogin(Username, Password).Count();

            if (result == 1)
            {
                LoginResult = 1;
            }
            else
            {
                LoginResult = 0;
            }
        }

        public void UserLoginLog()
        {

            if (LoginResult == 0)
            {
                status = "Login Success";
            }
            else
            {
                status = "Login Failed";
            }

            //log for user login that doesn't work
            //db.sp_UserLoginReport(GENID, Username, Password, status, DateTime.Now, CurrentUsertype);
        }

        public int UserID()
        {
            return Convert.ToInt32(db.sp_UserID());
        }


        //dunno why this doens't work
        //public int ReturnUserID()
        //{
        //    return Convert.ToInt32(db.sp_UserReturnID(Username, Usertype));
        //}

        public void ActionReport()
        {
            CurrentUsertype = 110;
            db.sp_UserLoginReport(CurrentUserID, CurrentUsername, Password, Action, DateTime.Now, CurrentUsertype);
        }
    }
}
