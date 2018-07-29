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

namespace ANS_SEIS_TV
{
    public partial class Main : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;

        public Main()
        {
            InitializeComponent();

            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Red200, Primary.Red200, Primary.Red200, Accent.Red100, TextShade.WHITE);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            ViewUser();
            ViewEquipment();
            txtUsername.Enabled = false;
            txtPassword.Enabled = false;
        }



        public void ViewEquipment()
        {
            u.Searchkey = "";
            txtEquipmentID.Text = e.EquipmentID().ToString();
            dgvEquipment.DataSource = db.sp_EquipmentView(u.Searchkey);
        }

        //initialize Connection

        DataClasses1DataContext db = new DataClasses1DataContext();

        UserLibrary u = new UserLibrary();

        EquipmentLibrary e = new EquipmentLibrary();


        // This Area is for the Users
        //The Following Code Directly affects users

        /// <summary>
        /// This area here is for the users form only
        /// Please be specific with the variables
        /// </summary>
        /// 

        private void ClearUser()
        {
            txtLastName.Text = null;
            //txtConfirmPassword.Text = null;
            txtContactNumber.Text = null;
            txtFirstName.Text = null;
            txtMiddleName.Text = null;
            txtPassword.Text = null;
            txtUsername.Text = null;
            rdoAdmin.Checked = true;
            txtPassword.Text = "1234";

        }

        private void EditUsers()
        {
            btnAddUser.Enabled = false;
            btnDeleteUser.Enabled = true;
            btnUserClear.Enabled = true;
            btnEditUser.Enabled = true;
        }

        private void AddUser()
        {
            btnAddUser.Enabled = true;
            btnEditUser.Enabled = false;
            btnDeleteUser.Enabled = false;
            btnUserClear.Enabled = true;
        }

        private void ViewUser()
        {
            dgvUserRegister.DataSource = db.sp_UserView();
        }

        public void Teacher()
        {
            if (u.UserID() == 1)
            {
                txtUserID.Text = "TR-" + (u.UserID().ToString().PadLeft(5, '0'));
            }
            else
            {
                txtUserID.Text = "TR-" + (u.UserID() + 1).ToString().PadLeft(5, '0');
            }
            u.Usertype = 111;
            txtUsername.Enabled = false;
            txtPassword.Enabled = false;
            //drpSecurityQuestion.Enabled = false;
            //txtSecurityAnswer.Enabled = false;
            //txtConfirmPassword.Enabled = false;
        }

        public void Admin()
        {
            if (u.UserID() == 1)
            {
                txtUserID.Text = "AD-" + (u.UserID().ToString().PadLeft(5, '0'));
            }
            else
            {
                txtUserID.Text = "AD-" + (u.UserID() + 1).ToString().PadLeft(5, '0');
            }
            u.Usertype = 110;
            txtUsername.Enabled = true;
            txtPassword.Enabled = true;
            //txtConfirmPassword.Enabled = true;
            //drpSecurityQuestion.Enabled = true;
            //txtSecurityAnswer.Enabled = true;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddUser();

            u.GENID = u.UserID();
            u.ID = txtUserID.Text;
            u.Username = txtUsername.Text;
            u.Password = txtPassword.Text;
            u.FirstName = txtFirstName.Text;
            u.MiddleName = txtMiddleName.Text;
            u.LastName = txtLastName.Text;
            ////u.Address = txtAddress.Text;
            ////u.Email = txtEmail.Text;
            ////u.Birthdate = dtpBirthdate.Value;
            ////u.SecurityQuestion = drpSecurityQuestion.Text;
            ////u.SecurityAnswer = txtSecurityAnswer.Text;
            //u.ID = txtUserID.Text;

            //if (u.IncompleteUserData() == 1)
            //{
            //    MessageBox.Show("Please fill all boxes!");
            //}
            //else if (u.EmailError() == 1)
            //{
            //    MessageBox.Show(u.InvalidEmail());
            //}
            //else
            //{
            //    u.UserInsert();
            //    rdoAdmin.Checked = true;
            //    ViewUser();
            //    ClearUser();
            //}

            u.UserInsert();
            ClearUser();
            ViewUser();
        }



        private void materialTabSelector2_Click(object sender, EventArgs e)
        {
            rdoAdmin.Checked = true;
            txtUsername.Enabled = false;
            txtPassword.Enabled = false;
            txtPassword.Text = "1234";

            GetSomethingFromServer g = new GetSomethingFromServer();
            g.GetSomething();
        }

        private void btnUserClear_Click(object sender, EventArgs e)
        {
            AddUser();
        }

        private void txtSearchUser_TextChanged(object sender, EventArgs e)
        {
            dgvUserRegister.DataSource = db.sp_UserSearch(txtSearchUser.Text);
        }


        private void rdoAdmin_CheckedChanged_1(object sender, EventArgs e)
        {
            Admin();
        }

        private void rdoTeacher_CheckedChanged_1(object sender, EventArgs e)
        {
            Teacher();
        }

        private void dgvUserRegister_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditUsers();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            AddUser();
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Code for user Ends Here
        /// </summary>

        
        ///////////////////////////////////////////////////////////////////
        ///
        ///Code for Equipment Starts Below
        /// 
        ///////////////////////////////////////////////////////////////////


        private void txtMiddleName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void rdoStudent_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoTeacher_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoAdmin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dgvView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage25_Click(object sender, EventArgs e)
        {

        }


        private void tabPage14_Click(object sender, EventArgs e)
        {

        }

        private void kryptonButton7_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridViewX2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            txtUsername.Text = txtFirstName.Text.Substring(0, 1) + txtLastName.Text;
        }

    }
}
