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
    public partial class FirstLoginForm : MaterialForm
    {
        public FirstLoginForm()
        {
            InitializeComponent();
        }

        public string Username { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }

        private void FirstLoginForm_Load(object sender, EventArgs e)
        {
            txtUsername.Text = Username;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Username = txtUsername.Text;
            Password = txtPassword.Text;
            Question = drpSecurityQuestion.Text;
            Answer = txtSecurityAnswer.Text;
            ConfirmPassword = txtConfirmPassword.Text;

            if (EmptyLol()==0)
            {
                if (PasswordLol()==0)
                {
                    DataClasses1DataContext db = new DataClasses1DataContext();
                    db.sp_UserFirstLogin(Username, Password, Question, Answer);
                    this.Hide();
                    LoginForm l = new LoginForm();
                    MessageBox.Show("Please login with your new credentials");
                    l.Show();
                }
                else
                {
                    MessageBox.Show("The passwords do not match");
                }
                
            }
            else
            {
                MessageBox.Show("Please fill all fields");
            }
        }

        private int EmptyLol()
        {
            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password) || string.IsNullOrEmpty(ConfirmPassword) || string.IsNullOrEmpty(Question) || string.IsNullOrEmpty(Answer)) 
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        private int PasswordLol()
        {
            if (txtPassword.Text!=txtConfirmPassword.Text)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        ///////////////////////////////////////////////////////////////////
        ///
        /// Useless code below
        /// 
        ///////////////////////////////////////////////////////////////////

        private void kryptonRichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxX1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
