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
    public partial class UserRegistration : MaterialForm
    {
        private MaterialRadioButton rdoAdmin;
        private GroupBox groupBox1;
        private MaterialRadioButton rdoStudent;
        private MaterialRadioButton rdoTeacher;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtID;
        private MaterialLabel materialLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtFirstName;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtMiddleName;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtLastName;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtAddress;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtEmail;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private MaterialLabel materialLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtUsername;
        private MaterialLabel materialLabel10;
        private MaterialLabel materialLabel11;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtConfirmPassword;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPassword;
        private GroupBox groupBox4;
        private MaterialLabel materialLabel12;
        private MaterialLabel materialLabel13;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtSecurityAnswer;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvView;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnEdit;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private MaterialLabel materialLabel5;
        private MaterialLabel materialLabel6;
        private MaterialLabel materialLabel7;
        private MaterialLabel materialLabel8;
        private MaterialLabel materialLabel9;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnInsert;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDelete;
        private DateTimePicker dtpBirthdate;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnClear;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox drpSecurityQuestion;
        private MaterialSingleLineTextField txtSearch;

        public UserRegistration()
        {
            InitializeComponent();
        }

        

        private void UserRegistration_Load(object sender, EventArgs e)
        {

        }

        //initialize instance
        DataClasses1DataContext db = new DataClasses1DataContext();

        //User Library
        UserLibrary u = new UserLibrary();

        public void ViewData()
        {
            dgvView.DataSource = db.sp_UserSearch(u.Searchkey);
        }

        // This causes error if run dunno why
        //private void InitializeComponent()
        //{
        //    this.SuspendLayout();
        //    // 
        //    // UserRegistration
        //    // 
        //    this.ClientSize = new System.Drawing.Size(284, 261);
        //    this.Name = "UserRegistration";
        //    this.Load += new System.EventHandler(this.UserRegistration_Load_1);
        //    this.ResumeLayout(false);

        //}

        private void UserRegistration_Load_1(object sender, EventArgs e)
        {

        }

        public void Clear()
        {
            txtConfirmPassword.Text = null;
            txtAddress.Text = null;
            txtEmail.Text = null;
            txtFirstName.Text = null;
            //txtFname.Text = null;
            txtFirstName.Text = null;
            txtID.Text = null;
            txtLastName.Text = null;
            txtMiddleName.Text = null;
            txtPassword.Text = null;
            txtSecurityAnswer.Text = null;
            txtUsername.Text = null;
            rdoAdmin.Checked = true;
            dtpBirthdate.Value = DateTime.Today;
            drpSecurityQuestion.Text = "";

            u.Address = null;
            u.FirstName = null;
            u.MiddleName = null;
            u.LastName = null;
            u.ID = null;
            u.Username = null;
            u.Password = null;
            u.SecurityAnswer = null;
            u.SecurityQuestion = null;
            u.Usertype = 0;
            u.Email = null;

            InsertMode();

        }

        

        private void kryptonGroupBox1_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserRegistration_Load_2(object sender, EventArgs e)
        {
            //ViewData();
            View();
            rdoAdmin.Checked = true;
            InsertMode();
        }

        public void View()
        {
            dgvView.DataSource = db.sp_UserView();
        }

        public void Admin()
        {
            if (u.UserID() == 1)
            {
                txtID.Text = "AD-" + (u.UserID().ToString().PadLeft(5, '0'));
            }
            else
            {
                txtID.Text = "AD-" + (u.UserID() + 1).ToString().PadLeft(5, '0');
            }
            u.Usertype = 110;
        }

        public void Teacher()
        {
            if (u.UserID() == 1)
            {
                txtID.Text = "TR-" + (u.UserID().ToString().PadLeft(5, '0'));
            }
            else
            {
                txtID.Text = "TR-" + (u.UserID() + 1).ToString().PadLeft(5, '0');
            }
            u.Usertype = 111;
        }

        public void Student()
        {
            if (u.UserID() == 1)
            {
                txtID.Text = "ST-" + (u.UserID().ToString().PadLeft(5, '0'));
            }
            else
            {
                txtID.Text = "ST-" + (u.UserID() + 1).ToString().PadLeft(5, '0');
            }
            u.Usertype = 112;
        }

        private void dgvview1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void rdoAdmin_CheckedChanged(object sender, EventArgs e)
        {
            Admin();
        }

        private void rdoTeacher_CheckedChanged(object sender, EventArgs e)
        {
            Teacher();
        }

        private void rdoStudent_CheckedChanged(object sender, EventArgs e)
        {
            Student();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            u.Username = txtUsername.Text;
            u.Password = txtPassword.Text;
            u.FirstName = txtFirstName.Text;
            u.MiddleName = txtMiddleName.Text;
            u.LastName = txtLastName.Text;
            u.Address = txtAddress.Text;
            u.Email = txtEmail.Text;
            u.Birthdate = dtpBirthdate.Value;
            u.SecurityQuestion = drpSecurityQuestion.Text;
            u.SecurityAnswer = txtSecurityAnswer.Text;
            u.ID = txtID.Text;

            if (u.IncompleteUserData()==1)
            {
                MessageBox.Show("Please fill all boxes!");
            }
            else if(u.EmailError()==1)
            {
                MessageBox.Show(u.InvalidEmail());
            }
            else
            {
                u.UserInsert();
                rdoAdmin.Checked = true;
                View();
                Clear();
            }
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            //u.Searchkey = txtSearch.Text;
            //dgvView.DataSource = db.sp_UserSearch(txtSearch.Text);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            u.Searchkey = txtSearch.Text;
            dgvView.DataSource = db.sp_UserSearch(u.Searchkey);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            Admin();
        }

        private void dgvView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            u.GENID = int.Parse(dgvView.CurrentRow.Cells[0].Value.ToString());
            u.ID = dgvView.CurrentRow.Cells[1].Value.ToString();
            u.Username = dgvView.CurrentRow.Cells[2].Value.ToString();
            u.FirstName = dgvView.CurrentRow.Cells[3].Value.ToString();
            u.MiddleName = dgvView.CurrentRow.Cells[4].Value.ToString();
            u.LastName = dgvView.CurrentRow.Cells[5].Value.ToString();
            u.Address = dgvView.CurrentRow.Cells[6].Value.ToString();
            u.Birthdate = DateTime.Parse(dgvView.CurrentRow.Cells[7].Value.ToString());
            u.Email = dgvView.CurrentRow.Cells[8].Value.ToString();
            u.Usertype = int.Parse(dgvView.CurrentRow.Cells[9].Value.ToString());

            //this Line doesn't work LOL
            if (u.Usertype==110)
            {
                rdoAdmin.Checked = true;
            }
            else if (u.Usertype == 111)
            {
                rdoTeacher.Checked = true;
            }
            else if (u.Usertype == 112)
            {
                rdoStudent.Checked = true;
            }

            txtID.Text = u.ID;
            txtUsername.Text = u.Username;
            txtFirstName.Text = u.FirstName;
            txtMiddleName.Text = u.MiddleName;
            txtLastName.Text = u.LastName;
            txtAddress.Text = u.Address;
            dtpBirthdate.Value = u.Birthdate.Date; //i dont understand why this hags
            txtEmail.Text = u.Email;
            EditMode();
        }

        public void EditMode()
        {
            btnClear.Enabled = true;
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
            btnInsert.Enabled = false;
        }

        public void InsertMode()
        {
            btnInsert.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnDelete.Enabled = false;
        }


        //WATEVER MAY HAPEN PLIZ DO NAT TACH DIZ AREA OF CODE IF YOU DONT WANA DAY



        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rdoAdmin = new MaterialSkin.Controls.MaterialRadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoStudent = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdoTeacher = new MaterialSkin.Controls.MaterialRadioButton();
            this.txtID = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtFirstName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtMiddleName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtLastName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtAddress = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtEmail = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpBirthdate = new System.Windows.Forms.DateTimePicker();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtUsername = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.txtConfirmPassword = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtPassword = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.drpSecurityQuestion = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.txtSecurityAnswer = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dgvView = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.btnEdit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtSearch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnInsert = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnDelete = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnClear = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drpSecurityQuestion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).BeginInit();
            this.SuspendLayout();
            // 
            // rdoAdmin
            // 
            this.rdoAdmin.AutoSize = true;
            this.rdoAdmin.Depth = 0;
            this.rdoAdmin.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdoAdmin.Location = new System.Drawing.Point(2, 13);
            this.rdoAdmin.Margin = new System.Windows.Forms.Padding(0);
            this.rdoAdmin.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdoAdmin.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdoAdmin.Name = "rdoAdmin";
            this.rdoAdmin.Ripple = true;
            this.rdoAdmin.Size = new System.Drawing.Size(114, 30);
            this.rdoAdmin.TabIndex = 2;
            this.rdoAdmin.Text = "Administrator";
            this.rdoAdmin.UseVisualStyleBackColor = true;
            this.rdoAdmin.CheckedChanged += new System.EventHandler(this.rdoAdmin_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.rdoStudent);
            this.groupBox1.Controls.Add(this.rdoTeacher);
            this.groupBox1.Controls.Add(this.rdoAdmin);
            this.groupBox1.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 51);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Type";
            // 
            // rdoStudent
            // 
            this.rdoStudent.AutoSize = true;
            this.rdoStudent.Depth = 0;
            this.rdoStudent.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdoStudent.Location = new System.Drawing.Point(195, 13);
            this.rdoStudent.Margin = new System.Windows.Forms.Padding(0);
            this.rdoStudent.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdoStudent.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdoStudent.Name = "rdoStudent";
            this.rdoStudent.Ripple = true;
            this.rdoStudent.Size = new System.Drawing.Size(77, 30);
            this.rdoStudent.TabIndex = 4;
            this.rdoStudent.Text = "Student";
            this.rdoStudent.UseVisualStyleBackColor = true;
            this.rdoStudent.CheckedChanged += new System.EventHandler(this.rdoStudent_CheckedChanged);
            // 
            // rdoTeacher
            // 
            this.rdoTeacher.AutoSize = true;
            this.rdoTeacher.Depth = 0;
            this.rdoTeacher.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdoTeacher.Location = new System.Drawing.Point(116, 13);
            this.rdoTeacher.Margin = new System.Windows.Forms.Padding(0);
            this.rdoTeacher.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdoTeacher.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdoTeacher.Name = "rdoTeacher";
            this.rdoTeacher.Ripple = true;
            this.rdoTeacher.Size = new System.Drawing.Size(79, 30);
            this.rdoTeacher.TabIndex = 3;
            this.rdoTeacher.Text = "Teacher";
            this.rdoTeacher.UseVisualStyleBackColor = true;
            this.rdoTeacher.CheckedChanged += new System.EventHandler(this.rdoTeacher_CheckedChanged);
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(86, 163);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(210, 23);
            this.txtID.TabIndex = 4;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(14, 74);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(111, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Register a User";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(145, 24);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(233, 23);
            this.txtFirstName.TabIndex = 2;
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Location = new System.Drawing.Point(145, 53);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(233, 23);
            this.txtMiddleName.TabIndex = 3;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(145, 82);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(233, 23);
            this.txtLastName.TabIndex = 4;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(145, 111);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(233, 23);
            this.txtAddress.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(145, 167);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(233, 23);
            this.txtEmail.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox2.Controls.Add(this.dtpBirthdate);
            this.groupBox2.Controls.Add(this.bunifuCustomLabel3);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.txtFirstName);
            this.groupBox2.Controls.Add(this.materialLabel5);
            this.groupBox2.Controls.Add(this.txtAddress);
            this.groupBox2.Controls.Add(this.materialLabel6);
            this.groupBox2.Controls.Add(this.txtLastName);
            this.groupBox2.Controls.Add(this.materialLabel7);
            this.groupBox2.Controls.Add(this.txtMiddleName);
            this.groupBox2.Controls.Add(this.materialLabel8);
            this.groupBox2.Controls.Add(this.materialLabel9);
            this.groupBox2.Location = new System.Drawing.Point(12, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(384, 199);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User Details";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // dtpBirthdate
            // 
            this.dtpBirthdate.CalendarTitleBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtpBirthdate.CalendarTrailingForeColor = System.Drawing.SystemColors.WindowFrame;
            this.dtpBirthdate.Location = new System.Drawing.Point(145, 136);
            this.dtpBirthdate.Name = "dtpBirthdate";
            this.dtpBirthdate.Size = new System.Drawing.Size(233, 25);
            this.dtpBirthdate.TabIndex = 6;
            this.dtpBirthdate.Value = new System.DateTime(2018, 7, 6, 7, 41, 9, 0);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.SystemColors.Window;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(48, 24);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(91, 19);
            this.bunifuCustomLabel3.TabIndex = 24;
            this.bunifuCustomLabel3.Text = "First Name :";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.BackColor = System.Drawing.SystemColors.Window;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(34, 53);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(106, 19);
            this.materialLabel5.TabIndex = 8;
            this.materialLabel5.Text = "Middle Name :";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.BackColor = System.Drawing.SystemColors.Window;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(51, 82);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(90, 19);
            this.materialLabel6.TabIndex = 9;
            this.materialLabel6.Text = "Last Name :";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.BackColor = System.Drawing.SystemColors.Window;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(67, 111);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(72, 19);
            this.materialLabel7.TabIndex = 10;
            this.materialLabel7.Text = "Address :";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.BackColor = System.Drawing.SystemColors.Window;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(64, 140);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(77, 19);
            this.materialLabel8.TabIndex = 11;
            this.materialLabel8.Text = "Birthdate :";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.BackColor = System.Drawing.SystemColors.Window;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(25, 167);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(114, 19);
            this.materialLabel9.TabIndex = 12;
            this.materialLabel9.Text = "Email Address :";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox3.Controls.Add(this.materialLabel3);
            this.groupBox3.Controls.Add(this.txtUsername);
            this.groupBox3.Controls.Add(this.materialLabel10);
            this.groupBox3.Controls.Add(this.materialLabel11);
            this.groupBox3.Controls.Add(this.txtConfirmPassword);
            this.groupBox3.Controls.Add(this.txtPassword);
            this.groupBox3.Location = new System.Drawing.Point(16, 397);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(380, 117);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Account Details";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.SystemColors.Window;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(57, 21);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(85, 19);
            this.materialLabel3.TabIndex = 7;
            this.materialLabel3.Text = "Username :";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(148, 22);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(226, 23);
            this.txtUsername.TabIndex = 8;
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.BackColor = System.Drawing.SystemColors.Window;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(59, 51);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(83, 19);
            this.materialLabel10.TabIndex = 8;
            this.materialLabel10.Text = "Password :";
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.BackColor = System.Drawing.SystemColors.Window;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel11.Location = new System.Drawing.Point(1, 80);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(141, 19);
            this.materialLabel11.TabIndex = 9;
            this.materialLabel11.Text = "Confirm Password :";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(148, 80);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '●';
            this.txtConfirmPassword.Size = new System.Drawing.Size(226, 23);
            this.txtConfirmPassword.TabIndex = 10;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(148, 51);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(226, 23);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox4.Controls.Add(this.drpSecurityQuestion);
            this.groupBox4.Controls.Add(this.materialLabel12);
            this.groupBox4.Controls.Add(this.materialLabel13);
            this.groupBox4.Controls.Add(this.txtSecurityAnswer);
            this.groupBox4.Location = new System.Drawing.Point(18, 520);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(378, 90);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Account Recovery";
            // 
            // drpSecurityQuestion
            // 
            this.drpSecurityQuestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpSecurityQuestion.DropDownWidth = 224;
            this.drpSecurityQuestion.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Ribbon;
            this.drpSecurityQuestion.Items.AddRange(new object[] {
            "In what city were you born?",
            "What high school did you attend?",
            "What is the first and last name of your first boyfriend or girlfriend?",
            "What is the name of your favorite pet?",
            "What is the name of your first grade teacher?",
            "What is the name of your first school?",
            "What is your father\'s middle name?",
            "What is your favorite color?",
            "what is your favorite forum",
            "What is your favorite movie?",
            "what is your favorite online platform",
            "what is your favorite social media website",
            "what is your favorite website",
            "What is your mother\'s maiden name?",
            "What street did you grow up on?",
            "What was the make of your first car?",
            "What was your favorite place to visit as a child?",
            "What was your high school mascot?",
            "When is your anniversary?",
            "Which is your favorite web browser?",
            "Which phone number do you remember most from your childhood?",
            "Who is your favorite actor, musician, or artist?"});
            this.drpSecurityQuestion.Location = new System.Drawing.Point(148, 21);
            this.drpSecurityQuestion.Name = "drpSecurityQuestion";
            this.drpSecurityQuestion.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.drpSecurityQuestion.Size = new System.Drawing.Size(224, 21);
            this.drpSecurityQuestion.TabIndex = 11;
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.BackColor = System.Drawing.SystemColors.Window;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel12.Location = new System.Drawing.Point(7, 21);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(135, 19);
            this.materialLabel12.TabIndex = 7;
            this.materialLabel12.Text = "Security Question :";
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.BackColor = System.Drawing.SystemColors.Window;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel13.Location = new System.Drawing.Point(17, 51);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(125, 19);
            this.materialLabel13.TabIndex = 8;
            this.materialLabel13.Text = "Security Answer :";
            // 
            // txtSecurityAnswer
            // 
            this.txtSecurityAnswer.Location = new System.Drawing.Point(148, 51);
            this.txtSecurityAnswer.Name = "txtSecurityAnswer";
            this.txtSecurityAnswer.Size = new System.Drawing.Size(224, 23);
            this.txtSecurityAnswer.TabIndex = 12;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Roboto Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(17, 163);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(66, 20);
            this.bunifuCustomLabel1.TabIndex = 23;
            this.bunifuCustomLabel1.Text = "User ID :";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.SystemColors.Window;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(931, 75);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(63, 19);
            this.bunifuCustomLabel2.TabIndex = 24;
            this.bunifuCustomLabel2.Text = "Search :";
            // 
            // dgvView
            // 
            this.dgvView.AllowUserToAddRows = false;
            this.dgvView.AllowUserToDeleteRows = false;
            this.dgvView.AllowUserToOrderColumns = true;
            this.dgvView.AllowUserToResizeColumns = false;
            this.dgvView.AllowUserToResizeRows = false;
            this.dgvView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvView.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvView.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvView.Location = new System.Drawing.Point(402, 103);
            this.dgvView.Name = "dgvView";
            this.dgvView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvView.Size = new System.Drawing.Size(790, 536);
            this.dgvView.TabIndex = 25;
            this.dgvView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvView_CellContentDoubleClick);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(210, 614);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(90, 25);
            this.btnEdit.TabIndex = 26;
            this.btnEdit.Values.Text = "Edit User";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Depth = 0;
            this.txtSearch.Hint = "";
            this.txtSearch.Location = new System.Drawing.Point(991, 75);
            this.txtSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.Size = new System.Drawing.Size(201, 23);
            this.txtSearch.TabIndex = 28;
            this.txtSearch.UseSystemPasswordChar = false;
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(306, 614);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(90, 25);
            this.btnInsert.TabIndex = 29;
            this.btnInsert.Values.Text = "Add User";
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(114, 614);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 25);
            this.btnDelete.TabIndex = 30;
            this.btnDelete.Values.Text = "Delete User";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(18, 614);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 25);
            this.btnClear.TabIndex = 31;
            this.btnClear.Values.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // UserRegistration
            // 
            this.ClientSize = new System.Drawing.Size(1204, 647);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dgvView);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.materialLabel1);
            this.Font = new System.Drawing.Font("Roboto Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UserRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Registration";
            this.Load += new System.EventHandler(this.UserRegistration_Load_2);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drpSecurityQuestion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
