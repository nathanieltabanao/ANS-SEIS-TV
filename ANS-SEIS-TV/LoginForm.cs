﻿using System;
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

                if (g.FirstLogin==0)
                {
                    AdminForm m = new AdminForm();
                    this.Hide();
                    m.CurrentUser = txtUsername.Text;
                    m.Show();
                }
                else
                {
                    FirstLoginForm f = new FirstLoginForm();
                    f.Username = txtUsername.Text;
                    MessageBox.Show("Please setup your account");
                    this.Hide();
                    f.Show();
                }
                
            }
            else
            { 
                MessageBox.Show("Invalid Username or Password!");
                txtPassword.Text = "";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
