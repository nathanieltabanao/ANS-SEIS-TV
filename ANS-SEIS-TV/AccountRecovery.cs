using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using MetroFramework;
using MetroFramework.Forms;

namespace ANS_SEIS_TV
{
    public partial class AccountRecovery : MetroForm
    {
        public AccountRecovery()
        {
            InitializeComponent();
        }

        DataClasses1DataContext db = new DataClasses1DataContext();

        UserLibrary u = new UserLibrary();

        public string Username { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Username = txtUsername.Text;
            Question = drpQuestion.Text;
            Answer = txtSecurityAnswer.Text;

            if (u.AccountRecoveryVerification(Username, Question, Answer) == 1) 
            {
                ChangePassword c = new ChangePassword();
                c.Username = Username;
                this.Hide();
                c.Show();
            }
            else
            {
                MetroMessageBox.Show(this, "Account Not Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void AccountRecovery_Load(object sender, EventArgs e)
        {
            txtUsername.Text = Username;
        }
    }
}
