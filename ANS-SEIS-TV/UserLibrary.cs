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
        public string ContactNumber { get; set; }
        public string CurrentID { get; set; }

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
            int IsFirstLogin = 1;
            
            db.sp_UserInsert(ID, Username, Password, FirstName, MiddleName, LastName, ContactNumber, null, null, Usertype, IsFirstLogin);
            db.sp_AddUserToStatics(GENID, 0);
        }

        public void UserEdit()
        {
            db.sp_UserEdit(GENID, ID, Username, Password, FirstName, MiddleName, LastName, ContactNumber, SecurityQuestion, SecurityAnswer, Usertype);
        }

        public void UserDelete()
        {
            db.sp_UserDelete(ID,GENID);
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

            UserLoginLog();
        }

        public int AccountRecoveryVerification(string Username, string Question, string Answer)
        {
            result = db.sp_AccountRecovery(Username, Question, Answer).Count();

            return result;
        }

        public void ChangePassword (string Username, string Password)
        {
            db.sp_ChangePassword(Username, Password);
        }

        public void UserLoginLog()
        {

            if (LoginResult == 1)
            {
                Action = "Login Success";
            }
            else
            {
                Action = "Login Failed";
            }

            db.sp_UserLoginReport(ID, Password, Action, DateTime.Now);

            ActionReport();
        }

        public int UserID()
        {
            return Convert.ToInt32(db.sp_UserID());
        }

        public int BlankID()
        {
            if (string.IsNullOrEmpty(ID))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public void ActionReport()
        {
            db.sp_UserActionReport(ID, Action, DateTime.Now);
        }

        public void AddUserToStatistics(int ID)
        {
            db.sp_AddUserToStatics(ID, 0);
        }
    }
}
