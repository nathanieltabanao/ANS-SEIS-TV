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


        //Main form Constructor
        public Main()
        {
            InitializeComponent();

            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }


        //Main form load 
        private void Main_Load(object sender, EventArgs e)
        {
            ViewUser();
            ViewEquipment();
            txtUsername.Enabled = false;
            txtPassword.Enabled = false;
            g.Username = CurrentUser;
            g.GetFullname();
            lblCurrentUser.Text = "Current User : " + g.Fullname;
        }

        

        //initialize Connection

        DataClasses1DataContext db = new DataClasses1DataContext();

        UserLibrary u = new UserLibrary();

        EquipmentLibrary eq = new EquipmentLibrary();

        GetSomethingFromServer g = new GetSomethingFromServer();


        public string CurrentUser { get; set; }

        

        ///////////////////////////////////////////////////////////////////
        ///
        ///Code for Users Starts Below
        /// 
        ///////////////////////////////////////////////////////////////////

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
            u.ContactNumber = txtContactNumber.Text;

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

            

            u.GENID = int.Parse(dgvUserRegister.CurrentRow.Cells[0].Value.ToString());
            txtUserID.Text = dgvUserRegister.CurrentRow.Cells[1].Value.ToString();
            txtUsername.Text = dgvUserRegister.CurrentRow.Cells[2].Value.ToString();
            txtFirstName.Text = dgvUserRegister.CurrentRow.Cells[3].Value.ToString();
            txtMiddleName.Text = dgvUserRegister.CurrentRow.Cells[4].Value.ToString();
            txtLastName.Text = dgvUserRegister.CurrentRow.Cells[5].Value.ToString();
            txtContactNumber.Text = dgvUserRegister.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            AddUser();
            u.ID = txtUserID.Text;
            u.UserDelete();
            ClearUser();
            ViewUser();
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {

        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            txtUsername.Text = txtFirstName.Text.Substring(0, 1) + txtLastName.Text;
        }

        ///////////////////////////////////////////////////////////////////
        ///
        ///Code for Users Ends Here
        /// 
        ///////////////////////////////////////////////////////////////////


        ///////////////////////////////////////////////////////////////////
        ///
        ///Code for Equipment Starts Below
        /// 
        ///////////////////////////////////////////////////////////////////

        int EquipmentTypeID = 0;

        //Search Equipment
        private void txtSearchEquipment_TextChanged(object sender, EventArgs e)
        {
            eq.SearchKey = txtSearchEquipment.Text;
            dgvEquipment.DataSource = db.sp_EquipmentView(eq.SearchKey);
        }

        //Load Equipment
        public void ViewEquipment()
        {
            eq.SearchKey = "";
            txtEquipmentID.Text = eq.EquipmentID().ToString();
            dgvEquipment.DataSource = db.sp_EquipmentView(eq.SearchKey);
        }

        private void AddingEquipment()
        {
            btnEditEquipment.Enabled = false;
            btnDeleteEquipment.Enabled = false;
            btnClearEquipment.Enabled = true;
            btnAddEquipment.Enabled = true;
        }

        private void EditEquipment()
        {
            btnEditEquipment.Enabled = true;
            btnDeleteEquipment.Enabled = true;
            btnClearEquipment.Enabled = true;
            btnAddEquipment.Enabled = false;
        }

        //Clear Equipment
        private void EquipmentClear()
        {
            AddingEquipment();
            ViewEquipment();
            drpEquipmentType.Text = "";
            txtEquipmentName.Text = "";
            txtEquipmentDescription.Text = "";
            numQuantity.Value = 1;
        }


        //btnAddEquipment
        private void kryptonButton7_Click(object sender, EventArgs e)
        {
            ViewEquipment();

            //int EquipmentTypeID = 0;

            switch (int.Parse(drpEquipmentType.Text.Substring(0, 3)))
            {
                case 200:
                    EquipmentTypeID = 200;
                    break;

                case 201:
                    EquipmentTypeID = 201;
                    break;

                case 202:
                    EquipmentTypeID = 202;
                    break;

                case 203:
                    EquipmentTypeID = 203;
                    break;

                default:
                    break;
            }

            txtEquipmentID.Text = eq.EquipmentID().ToString();
            eq.EquipmentBarcode = txtEquipmentID.Text;
            eq.EquipmentName = txtEquipmentName.Text;
            eq.EquipmentDescription = txtEquipmentDescription.Text;
            eq.EquipmentTypeID = EquipmentTypeID; // int.Parse(drpEquipmentType.Text.Substring(0,3));
            eq.EquipmentQuantity = int.Parse(numQuantity.Value.ToString());
            eq.EquipmentInsert();
            ViewEquipment();
            EquipmentClear();
        }


        //load selected 
        private void dgvEquipment_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtEquipmentID.Text = dgvEquipment.CurrentRow.Cells[0].Value.ToString();
            txtEquipmentName.Text = dgvEquipment.CurrentRow.Cells[1].Value.ToString();
            txtEquipmentDescription.Text = dgvEquipment.CurrentRow.Cells[2].Value.ToString();
            drpEquipmentType.Text = dgvEquipment.CurrentRow.Cells[3].Value.ToString();
            EquipmentTypeID = int.Parse(dgvEquipment.CurrentRow.Cells[3].Value.ToString());
            numQuantity.Value = decimal.Parse(dgvEquipment.CurrentRow.Cells[4].Value.ToString());
            EditEquipment();
        }


        //Edit
        private void btnEditEquipment_Click(object sender, EventArgs e)
        {
            eq.ID = int.Parse(txtEquipmentID.Text);
            eq.EquipmentBarcode = txtEquipmentID.Text;
            eq.EquipmentName = txtEquipmentName.Text;
            eq.EquipmentDescription = txtEquipmentDescription.Text;
            eq.EquipmentTypeID = EquipmentTypeID;
            eq.EquipmentQuantity = int.Parse(numQuantity.Value.ToString());
            eq.EquipmentUpdate();
            EquipmentClear();

        }

        private void btnDeleteEquipment_Click(object sender, EventArgs e)
        {
            eq.ID = int.Parse(txtEquipmentID.Text);
            eq.EquipmentDelete();
            ViewEquipment();
            EquipmentClear();
        }



        private void btnClearEquipment_Click(object sender, EventArgs e)
        {
            EquipmentClear();
        }

        private void Main_Leave(object sender, EventArgs e)
        {
            LoginForm l = new LoginForm();
            l.Show();
        }



        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm l = new LoginForm();
            l.Show();
        }

        ///////////////////////////////////////////////////////////////////
        ///
        ///Code for Equipment Ends Here
        /// 
        ///////////////////////////////////////////////////////////////////



        ///////////////////////////////////////////////////////////////////
        ///
        /// Useless dump of code goes down
        /// 
        ///////////////////////////////////////////////////////////////////


        //txtConfirmPassword.Enabled = true;
        //drpSecurityQuestion.Enabled = true;
        //txtSecurityAnswer.Enabled = true;

        //drpSecurityQuestion.Enabled = false;
        //txtSecurityAnswer.Enabled = false;
        //txtConfirmPassword.Enabled = false;
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

        private void txtSearchEquipment_Click(object sender, EventArgs e)
        {

        }

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

        private void dataGridViewX2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
