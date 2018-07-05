using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.IO;
using System.Security.Cryptography;

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
        public string GENID { get; set; }
        public string ID { get; set; }
        public string SecurityQuestion { get; set; }
        public string SecurityAnswer { get; set; }
        public int Usertype { get; set; }
        public DateTime Birthdate { get; set; }
        public int Age { get; set; }
        public int LoginResult { get; set; }
        public string Searchkey { get; set; }
        int result;

        public void Clear()
        {
            Address = null;
            Email = null;
            FirstName = null;
            MiddleName = null;
            LastName = null;
            Username = null;
            Password = null;
            GENID = null;
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

        public string EmailError()
        {
            return "Invalid Email!";
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
            string status;

            if (LoginResult == 0)
            {
                status = "Login Success";
            }
            else
            {
                status = "Login Failed";
            }
            db.sp_UserLoginReport(ID, Username, Password, status, DateTime.Now, Usertype);
        }
    }
}
