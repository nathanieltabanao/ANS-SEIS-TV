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
        private MaterialLabel materialLabel4;
        private MaterialLabel materialLabel5;
        private MaterialLabel materialLabel6;
        private MaterialLabel materialLabel7;
        private MaterialLabel materialLabel8;
        private MaterialLabel materialLabel9;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtMiddleName;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtLastName;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtAddress;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker kryptonDateTimePicker1;
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
        private DevComponents.DotNetBar.Controls.TextBoxDropDown drpSecurityQuestion;
        private MaterialLabel materialLabel12;
        private MaterialLabel materialLabel13;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtSecurityAnswer;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvView;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtSearch;

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

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rdoAdmin = new MaterialSkin.Controls.MaterialRadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoStudent = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdoTeacher = new MaterialSkin.Controls.MaterialRadioButton();
            this.txtID = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtFirstName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.txtMiddleName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtLastName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtAddress = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonDateTimePicker1 = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.txtEmail = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtUsername = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.txtConfirmPassword = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtPassword = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.txtSecurityAnswer = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.drpSecurityQuestion = new DevComponents.DotNetBar.Controls.TextBoxDropDown();
            this.txtSearch = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dgvView = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            this.groupBox1.TabIndex = 3;
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
            this.txtFirstName.Enabled = false;
            this.txtFirstName.Location = new System.Drawing.Point(145, 24);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(210, 23);
            this.txtFirstName.TabIndex = 6;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.SystemColors.Window;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(48, 24);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(91, 19);
            this.materialLabel4.TabIndex = 7;
            this.materialLabel4.Text = "First Name :";
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
            this.materialLabel9.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(25, 167);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(97, 20);
            this.materialLabel9.TabIndex = 12;
            this.materialLabel9.Text = "Email Address :";
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Enabled = false;
            this.txtMiddleName.Location = new System.Drawing.Point(145, 53);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(210, 23);
            this.txtMiddleName.TabIndex = 13;
            // 
            // txtLastName
            // 
            this.txtLastName.Enabled = false;
            this.txtLastName.Location = new System.Drawing.Point(145, 82);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(210, 23);
            this.txtLastName.TabIndex = 14;
            // 
            // txtAddress
            // 
            this.txtAddress.Enabled = false;
            this.txtAddress.Location = new System.Drawing.Point(145, 111);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(210, 23);
            this.txtAddress.TabIndex = 15;
            // 
            // kryptonDateTimePicker1
            // 
            this.kryptonDateTimePicker1.Location = new System.Drawing.Point(145, 140);
            this.kryptonDateTimePicker1.Name = "kryptonDateTimePicker1";
            this.kryptonDateTimePicker1.Size = new System.Drawing.Size(210, 21);
            this.kryptonDateTimePicker1.TabIndex = 16;
            this.kryptonDateTimePicker1.ValueNullable = new System.DateTime(2018, 7, 5, 22, 41, 20, 0);
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(145, 167);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(210, 23);
            this.txtEmail.TabIndex = 17;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox2.Controls.Add(this.materialLabel4);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.txtFirstName);
            this.groupBox2.Controls.Add(this.kryptonDateTimePicker1);
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
            this.groupBox2.Size = new System.Drawing.Size(367, 199);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User Details";
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
            this.groupBox3.Size = new System.Drawing.Size(363, 117);
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
            this.txtUsername.Enabled = false;
            this.txtUsername.Location = new System.Drawing.Point(148, 22);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(210, 23);
            this.txtUsername.TabIndex = 6;
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
            this.txtConfirmPassword.Enabled = false;
            this.txtConfirmPassword.Location = new System.Drawing.Point(148, 80);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(210, 23);
            this.txtConfirmPassword.TabIndex = 14;
            // 
            // txtPassword
            // 
            this.txtPassword.Enabled = false;
            this.txtPassword.Location = new System.Drawing.Point(148, 51);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(210, 23);
            this.txtPassword.TabIndex = 13;
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
            this.groupBox4.Size = new System.Drawing.Size(361, 90);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Account Recovery";
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
            this.txtSecurityAnswer.Enabled = false;
            this.txtSecurityAnswer.Location = new System.Drawing.Point(148, 51);
            this.txtSecurityAnswer.Name = "txtSecurityAnswer";
            this.txtSecurityAnswer.Size = new System.Drawing.Size(210, 23);
            this.txtSecurityAnswer.TabIndex = 13;
            // 
            // drpSecurityQuestion
            // 
            // 
            // 
            // 
            this.drpSecurityQuestion.BackgroundStyle.Class = "TextBoxBorder";
            this.drpSecurityQuestion.ButtonDropDown.Visible = true;
            this.drpSecurityQuestion.Location = new System.Drawing.Point(148, 20);
            this.drpSecurityQuestion.Name = "drpSecurityQuestion";
            this.drpSecurityQuestion.Size = new System.Drawing.Size(210, 25);
            this.drpSecurityQuestion.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.drpSecurityQuestion.TabIndex = 14;
            this.drpSecurityQuestion.Text = "";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(909, 74);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(210, 23);
            this.txtSearch.TabIndex = 22;
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
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.SystemColors.Window;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(840, 75);
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
            this.dgvView.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvView.Location = new System.Drawing.Point(385, 103);
            this.dgvView.Name = "dgvView";
            this.dgvView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvView.Size = new System.Drawing.Size(734, 507);
            this.dgvView.TabIndex = 25;
            // 
            // UserRegistration
            // 
            this.ClientSize = new System.Drawing.Size(1128, 642);
            this.Controls.Add(this.dgvView);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.txtSearch);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void kryptonGroupBox1_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserRegistration_Load_2(object sender, EventArgs e)
        {
            //ViewData();
            dgvView.DataSource = db.sp_UserView();

        }

        private void dgvview1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
