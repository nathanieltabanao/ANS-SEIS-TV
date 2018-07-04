using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ANS_SEIS_TV
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();            
        }

        UserLibrary u = new UserLibrary();

        DataClasses1DataContext db = new DataClasses1DataContext();

        //loginbutton
        private void button1_Click(object sender, EventArgs e)
        {
            int result = db.sp_UserLogin(txtUsername.Text.Trim(), txtPassword.Text.Trim()).Count();
            if (result==1)
            {
                Form1 f = new Form1();
                this.Hide();
                f.Show();
            }
            else
            {
                MessageBox.Show("lol");
            }

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
