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
using MetroFramework.Forms;

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

        UserLibrary u = new UserLibrary();

        DataClasses1DataContext db = new DataClasses1DataContext();

        GetSomethingFromServer g = new GetSomethingFromServer();

        int FailedCount;

        //loginbutton
        private void button1_Click(object sender, EventArgs e)
        {
            u.Username = txtUsername.Text;
            u.Password = txtPassword.Text;
            
            g.Username = u.Username;

            u.CurrentUsername = u.Username;

            g.GetUserID();

            u.ID = g.ID;

            //g.GetUserType();

            u.Usertype = g.UsertypeID;

            u.UserLogin(/*txtUsername.Text, txtPassword.Text*/);


            if (u.LoginResult == 1)
            {

                this.Hide();
                
                u.CurrentUsername = u.Username;
                //u.CurrentUserID = u.ReturnUserID();
                //u.UserLoginLog();

                
                g.GetFirstLogin();

                this.Hide();

                if (g.FirstLogin==0)
                {
                    g.GetUserType();
                    if (g.UsertypeID==110)
                    {
                        AdminLogin();
                    }
                    else if (g.UsertypeID==111)
                    {
                        TeacherLogin();
                    }
                    else if (g.UsertypeID==112)
                    {
                        StudentLogin();
                    }
                }
                else
                {
                    FirstLogin();
                }
                
            }
            else
            { 
                MessageBox.Show("Invalid Username or Password!");
                txtPassword.Text = "";
                FailedCount++;
                if (FailedCount >= 3) 
                {
                    lblForgot.Text = "Forgot Password?";
                }
            }
        }

        private void TeacherLogin()
        {
            TeacherForm t = new TeacherForm();
            t.CurrentUsername = txtUsername.Text;
            t.Show();
        }

        private void AdminLogin()
        {
            Main m = new Main();
            m.CurrentUser = txtUsername.Text;
            m.Show();
        }

        private void StudentLogin()
        {
            student stu = new student();
            stu.CurrentUsername = txtUsername.Text;
            stu.Show();
        }

        private void FirstLogin()
        {
            FirstLoginForm f = new FirstLoginForm();
            f.Username = txtUsername.Text;
            MessageBox.Show("Please setup your account");
            //this.Hide();
            f.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblForgot_LinkClicked(object sender, EventArgs e)
        {
            this.Hide();
            AccountRecovery a = new AccountRecovery();
            a.Username = txtUsername.Text;
            a.Show();
        }
    }
}
