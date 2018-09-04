using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace ANS_SEIS_TV
{
    public partial class ChangePassword : MetroForm
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        public string Username { get; set; }

        UserLibrary u = new UserLibrary();

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            txtUsername.Text = Username;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text==txtConfirmPassword.Text)
            {
                u.ChangePassword(txtUsername.Text, txtPassword.Text);
                MetroMessageBox.Show(this, "Password Change Success!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                LoginForm l = new LoginForm();
                l.Show();
            }
            else
            {
                MetroMessageBox.Show(this, "Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
