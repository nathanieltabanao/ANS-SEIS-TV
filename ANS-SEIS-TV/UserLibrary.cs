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
        string Address { get; set; }
        string Email { get; set; }
        string FirstName { get; set; }
        string MiddleName { get; set; }
        string LastName { get; set; }
        string Username { get; set; }
        string Password { get; set; }
        string GENID { get; set; }
        string ID { get; set; }
        string SecurityQuestion { get; set; }
        string SecurityAnswer { get; set; }
        int Usertype { get; set; }
        DateTime Birthdate { get; set; }
        int Age { get; set; }
        int LoginResult { get; set; }

        int result;

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

        public int UserLogin()
        {
            result = db.sp_UserLogin(Username, Password).Count();

            if (result == 1)
            {
                return 0;
            }
            else
            {
                return 1;
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
