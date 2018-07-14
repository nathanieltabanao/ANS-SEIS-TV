using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace ANS_SEIS_TV
{
    public partial class LoginForm : MaterialForm
    {
        public LoginForm()
        {
            InitializeComponent();   
            
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }

        public void Clear()
        {

        }

        UserLibrary u = new UserLibrary();

        DataClasses1DataContext db = new DataClasses1DataContext();

        //loginbutton
        private void button1_Click(object sender, EventArgs e)
        {
            u.Username = txtUsername.Text;
            u.Password = txtPassword.Text;

            u.UserLogin(/*txtUsername.Text, txtPassword.Text*/);

            if (u.LoginResult == 1)
            {
                this.Hide();
                UserRegistration r = new UserRegistration();
                u.CurrentUsername = u.Username;
                //u.CurrentUserID = u.ReturnUserID();
                //u.UserLoginLog();
                r.Show();
                
            }
            else
            { 
                MessageBox.Show("Invalid Username or Password");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
