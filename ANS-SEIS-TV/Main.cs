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
using System.Data.Linq;
using System.Threading;
using System.IO;


namespace ANS_SEIS_TV
{
    public partial class Main : MaterialForm
    {
        // private readonly MaterialSkinManager materialSkinManager;
        
        //Main form Constructor
        public Main()
        {
            // Create new Thread For Pre Loading and Load Screen Splash
            Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();

            Thread.Sleep(5000);
            
            // Load everything here at FormLoad()
            InitializeComponent();

            // for background worker 1
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;

            // Not advised but cge nalang
            t.Abort();

            bgwEquipmentRegistration.WorkerReportsProgress = true;
            bgwEquipmentRegistration.WorkerSupportsCancellation = true;
        }

        // Splash screen and Loadscreen at once
        public void StartForm()
        {
            Application.Run(new SplashScreen());
        }

        // Direct Database Access for Tables
        DataClasses1DataContext db = new DataClasses1DataContext();

        //  To access user library Class
        UserLibrary u = new UserLibrary();

        // To acces Equipment Library Class
        EquipmentLibrary eq = new EquipmentLibrary();

        // To access LINQ classes nga akong gihimo
        GetSomethingFromServer g = new GetSomethingFromServer();

        // To access stuffs related to transaction
        TransactionLibrary t = new TransactionLibrary();

        // Naa diri ang barcode hahahah
        StuffLibrary s = new StuffLibrary();

        // Lodeng sukureen nga gorobal
        LoadingScreen2 l = new LoadingScreen2();

        public string CurrentUser { get; set; }
        public string CurrentUserID { get; set; }
        public string SearchKey { get; set; }
        public int CurrentGENID { get; set; }

        public int DeployEquipmentCount { get; set; }


        //Main form load 
        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aNS_SEIS_TVDataSet5.TBLFACILITIES' table. You can move, or remove it, as needed.
            this.tBLFACILITIESTableAdapter.Fill(this.aNS_SEIS_TVDataSet5.TBLFACILITIES);
            // Set searchkey to "" para ma usa ra ang search and view
            SearchKey = "";

            // Username and Password sa user is false
            // Username is auto generated
            // Password is Default
            txtUsername.Enabled = false;
            txtPassword.Enabled = false;

            DeployEquipmentCount = 0;

            // Current Username
            g.Username = CurrentUser;

            // Get Current Fullname of Current User
            g.GetFullname();

            // Welcome stuff
            lblCurrentUser.Text = "Welcome Admin : " + g.Fullname;
            u.CurrentUsername = CurrentUser;
            g.GetUserID();
            CurrentUserID = g.ID;
            u.CurrentID = CurrentUserID;

            // Sets the view of Request to New Request
            rdoOpenRequest.Checked = true;
            
            CurrentGENID = g.GetGENID(CurrentUser);

            // Set the mode of Inventory to be ready for registration
            AddingEquipment();

            // Updates all "Tables"
            RequestGridUpdate();

            // Sets the user table to be ready for registration
            AddUser();

            // Another one to update all table
            UpdateAllTable();

            // Set the Equipment ID 
            txtEquipmentID.Text = db.sp_EquipmentID().ToString();

            // Sets the table for Transaction History
            dgvTransactionHistory.DataSource = db.sp_TransactionViewAll();

            // Sets the max and min dates for Transaction Date Range
            dtpTransactionTo.MaxDate = DateTime.Now;
            dtpReseravationDate.MinDate = DateTime.Now.AddDays(1);

            // Sets min dates for Deployment
            dtpDeploymentDate.MinDate = DateTime.Now;

            // Update Final
            TableUpdate();
        }

        // Method to update all table daw
        private void UpdateAllTable()
        {
            // Sets the table ready for viewing
            ViewEquipment();

            rdoOpenRequest.Checked = true;


            dgvUserRegister.DataSource = db.sp_UserView();

            dgvToBeBorrowed.DataSource = db.sp_EquipmentBorrowableView(SearchKey);

            dgvEquipmentReservation.DataSource = db.sp_EquipmentBorrowableView(SearchKey);

            dgvDeployEquipment.DataSource = db.sp_EquipmentBorrowableView(SearchKey);

            //Update ID's
            t.TransactionID();
            lblDeployTransactionID.Text = t.TID.ToString();
        }

        //Load Equipment
        public void ViewEquipment()
        {
            eq.SearchKey = "";
            txtEquipmentID.Text = eq.EquipmentID().ToString();
            dgvEquipment.DataSource = db.sp_EquipmentView(eq.SearchKey);
        }

        ///////////////////////////////////////////////////////////////////
        ///
        ///Code for Users Starts Below
        /// 
        ///////////////////////////////////////////////////////////////////

        // Method to clear all fields and ready for registration
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

        // Sets the User tab ready for Editing Users
        private void EditUsers()
        {
            btnAddUser.Enabled = false;
            btnDeleteUser.Enabled = true;
            btnUserClear.Enabled = true;
            btnEditUser.Enabled = true;
        }

        // Sets the User Tab ready for User Registration
        private void AddUser()
        {
            btnAddUser.Enabled = true;
            btnEditUser.Enabled = false;
            btnDeleteUser.Enabled = false;
            btnUserClear.Enabled = true;
        }

        // Method for teacher prefix
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

        // Method for Admin Prefix
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
            txtUsername.Enabled = false;
            txtPassword.Enabled = false;
        }

        private void rdoStudent_CheckedChanged_1(object sender, EventArgs e)
        {
            if (u.UserID() == 1)
            {
                txtUserID.Text = "ST-" + (u.UserID().ToString().PadLeft(5, '0'));
            }
            else
            {
                txtUserID.Text = "ST-" + (u.UserID() + 1).ToString().PadLeft(5, '0');
            }
            u.Usertype = 112;
            txtUsername.Enabled = false;
            txtPassword.Enabled = false;
        }

        // Nethod for user registration
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text.Trim()) || string.IsNullOrEmpty(txtFirstName.Text.Trim()) || string.IsNullOrEmpty(txtLastName.Text.Trim()) || string.IsNullOrEmpty(txtContactNumber.Text.Trim())) 
            {
                MetroMessageBox.Show(this, "Please fill all necessary information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                AddUser();

                // Load everything to user Library
                u.GENID = u.UserID();
                u.ID = txtUserID.Text;
                u.Username = txtUsername.Text;
                u.Password = txtPassword.Text;
                u.FirstName = txtFirstName.Text;
                u.MiddleName = txtMiddleName.Text;
                u.LastName = txtLastName.Text;
                u.ContactNumber = txtContactNumber.Text;

                // The actual method to insert the user
                u.UserInsert();

                // CLears the fields
                ClearUser();

                // Update dayun table
                UpdateAllTable();

                // Update User ID
                u.ID = u.CurrentID;
                u.Action = "Registered a new User";

                // Action Report duhhh
                u.ActionReport();
                rdoAdmin.Checked = true;
            }
        }
        

        private void materialTabSelector2_Click(object sender, EventArgs e)
        {
            rdoAdmin.Checked = true;
            txtUsername.Enabled = false;
            txtPassword.Enabled = false;
            txtPassword.Text = "1234";

            GetSomethingFromServer g = new GetSomethingFromServer();
            //g.GetSomething();
        }

        private void btnUserClear_Click(object sender, EventArgs e)
        {
            txtContactNumber.Text = txtFirstName.Text = txtLastName.Text = txtMiddleName.Text = txtSearchUser.Text = txtUsername.Text = null;
            AddUser();
        }

        // Search a User
        private void txtSearchUser_TextChanged(object sender, EventArgs e)
        {
            dgvUserRegister.DataSource = db.sp_UserSearch(txtSearchUser.Text);
        }

        // Rdo sa admin
        private void rdoAdmin_CheckedChanged_1(object sender, EventArgs e)
        {
            Admin();
        }


        // RDO sa Teacher
        private void rdoTeacher_CheckedChanged_1(object sender, EventArgs e)
        {
            Teacher();
        }

        // Inig double click sa content sa cell then load for editing
        private void dgvUserRegister_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Set the Tab for Edit mode
            EditUsers();
            
            // Load values to the mao to
            u.GENID = int.Parse(dgvUserRegister.CurrentRow.Cells[0].Value.ToString());
            txtUserID.Text = dgvUserRegister.CurrentRow.Cells[1].Value.ToString();
            txtUsername.Text = dgvUserRegister.CurrentRow.Cells[2].Value.ToString();
            txtFirstName.Text = dgvUserRegister.CurrentRow.Cells[3].Value.ToString();
            txtMiddleName.Text = dgvUserRegister.CurrentRow.Cells[4].Value.ToString();
            txtLastName.Text = dgvUserRegister.CurrentRow.Cells[5].Value.ToString();
            txtContactNumber.Text = dgvUserRegister.CurrentRow.Cells[6].Value.ToString();
        }

        // Delete user
        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            AddUser();
            u.ID = txtUserID.Text;

            // Actual stuff nga mu delete
            u.UserDelete();
            ClearUser();
            UpdateAllTable();

            u.ID = u.CurrentID;
            u.Action = "Deleted a user";
            u.ActionReport();
            Admin();
        }

        // I think this doesn't work
        private void btnEditUser_Click(object sender, EventArgs e)
        {
            u.ID = u.CurrentID;
            u.Action = "Edited a user detail";
            u.ActionReport();

            Admin();
        }

        // This thing here autogenerates username
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

        // Add Equipment Mode
        private void AddingEquipment()
        {
            btnEditEquipment.Enabled = false;
            btnDeleteEquipment.Enabled = false;
            btnClearEquipment.Enabled = true;
            btnAddEquipment.Enabled = true;
        }

        // Edit Equipment Mode
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

            if (string.IsNullOrWhiteSpace(drpEquipmentType.Text))
            {
                MetroMessageBox.Show(this, "Please choose Equipment Type!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
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

                // Check if fields kay blank
                // Dapat --> OR || < -- either anang duha para inig true doesn't go down
                if (string.IsNullOrEmpty(txtEquipmentName.Text) || string.IsNullOrEmpty(txtEquipmentDescription.Text) || string.IsNullOrEmpty(txtEquipmentID.Text))
                {
                    MetroMessageBox.Show(this, "Please fill all necessary information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // For User Action
                    u.Action = "Registered a new Equipment";
                    txtEquipmentID.Text = db.sp_EquipmentID().ToString();
                    eq.ID = db.sp_EquipmentID(); // Get Equipment ID
                    
                    // Load stuff sa Equipment Library
                    eq.EquipmentBarcode = txtEquipmentID.Text;
                    eq.EquipmentName = txtEquipmentName.Text;
                    eq.EquipmentDescription = txtEquipmentDescription.Text;
                    eq.EquipmentTypeID = EquipmentTypeID; // int.Parse(drpEquipmentType.Text.Substring(0,3));
                    eq.EquipmentQuantity = int.Parse(numQuantity.Value.ToString());

                    eq.EquipmentInsert(); // Save data to Database

                    // Generate barocodo
                    s.GenerateBarcode(eq.EquipmentBarcode.ToString());


                    String strBLOBFilePath = s.SavePath;//Modify this path as needed.

                    //Read jpg into file stream, and from there into Byte array.
                    FileStream fsBLOBFile = new FileStream(strBLOBFilePath, FileMode.Open, FileAccess.Read);
                    Byte[] bytBLOBData = new Byte[fsBLOBFile.Length];
                    fsBLOBFile.Read(bytBLOBData, 0, bytBLOBData.Length);
                    fsBLOBFile.Close();

                    // Insert Barcode sa databse
                    db.sp_NewEquipmentBarcodeInsert(Convert.ToInt32(eq.EquipmentBarcode), bytBLOBData, s.SavePath);

                    t.NewEquipmentAdded(eq.ID, 0);
                    t.Action = "Registered an Equipment";
                    t.NewTransaction(DateTime.Now, t.Action, CurrentGENID);

                    //commented cuz ok na
                    t.NewBorrowed(t.TID, CurrentGENID, eq.ID, DateTime.Now, 0, true, true);
                    t.NewEquipmentAdded(eq.ID, 0);

                    //for the borrowing
                    // for status btaw na hahahaha
                    eq.EquipmentStatusAdd(eq.ID, eq.EquipmentQuantity);

                    // for PullOut
                    eq.NewEquipmentPullOut(eq.ID);

                    EquipmentClear();

                    u.ID = u.CurrentID;

                    u.Action = "Registered a new Equipment";

                    t.TransactionID();
                    ViewEquipment();

                    u.ActionReport();

                    UpdateAllTable();
                    MetroMessageBox.Show(this, "Equipment Succesfully Registered", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // Defunct na ni siya kay error 
        private void bgwEquipmentRegistration_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            System.Threading.Thread.Sleep(2000);
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

        // Either up or down but I think mao ni ang mugana
        private void dgvEquipment_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtEquipmentID.Text = dgvEquipment.CurrentRow.Cells[0].Value.ToString();
            txtEquipmentName.Text = dgvEquipment.CurrentRow.Cells[1].Value.ToString();
            txtEquipmentDescription.Text = dgvEquipment.CurrentRow.Cells[2].Value.ToString();
            drpEquipmentType.Text = dgvEquipment.CurrentRow.Cells[3].Value.ToString();
            EquipmentTypeID = g.GetEquipmentTypeID(dgvEquipment.CurrentRow.Cells[3].Value.ToString());
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

            u.ID = u.CurrentID;
            u.Action = "Edited a detail of an Equipment";
            u.ActionReport();

            eq.EquipmentStatusEdit(eq.ID, eq.EquipmentQuantity, 0); // zero jud na siya kay basta mao na hahaha but for real zero na siya kay always da mu deduct sa good equipment

            UpdateAllTable();
        }

        // Derets ekuwepment
        private void btnDeleteEquipment_Click(object sender, EventArgs e)
        {
            eq.ID = int.Parse(txtEquipmentID.Text);
            t.DeleteDeletedEquipment(eq.ID);

            eq.EquipmentDelete();
            ViewEquipment();
            EquipmentClear();
            UpdateAllTable();
            u.ID = u.CurrentID;
            u.Action = "Deleted an Equipment";
            u.ActionReport();
            eq.EquipmentStatusDelete(eq.ID);
            UpdateAllTable();
        }
        
        // Kurers the ekuwepment
        private void btnClearEquipment_Click(object sender, EventArgs e)
        {
            EquipmentClear();
        }

        // dozent werk
        private void Main_Leave(object sender, EventArgs e)
        {
            LoginForm l = new LoginForm();
            l.Show();
        }
        
        // Logout
        private void btnLogout_Click(object sender, EventArgs e)
        {
            // I dispose jud nimo ang form sama sa pag dispose niya sa imong gugma para kaniya
            this.Dispose();
            LoginForm l = new LoginForm();
            u.Action = "User Logout";
            u.UserLoginLog();
            l.Show();
        }


        private void kryptonButton5_Click(object sender, EventArgs e)
        {
            SearchUser s = new SearchUser();
            s.ShowDialog();
            txtBorrowerUsername.Text = s.Username;
            txtBorrowerFullname.Text = s.Fullname;            
        }

        private void txtSearchBorrow_TextChanged(object sender, EventArgs e)
        {
            SearchKey = txtSearchBorrow.Text;
            dgvToBeBorrowed.DataSource = db.sp_EquipmentBorrowableView(SearchKey);
        }

        private void kryptonRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dgvRequest.DataSource = db.sp_ViewAllRequest();
        }

        private void rdoOpenRequest_CheckedChanged(object sender, EventArgs e)
        {
            dgvRequest.DataSource = db.sp_ViewOpenRequest();
        }

        private void rdoPendingRequest_CheckedChanged(object sender, EventArgs e)
        {
            dgvRequest.DataSource = db.sp_ViewPendingRequest();
        }

        private void btnClosedRequest_CheckedChanged(object sender, EventArgs e)
        {
            dgvRequest.DataSource = db.sp_ViewApprovedRequest();
        }

        private void rdoDenied_CheckedChanged(object sender, EventArgs e)
        {
            dgvRequest.DataSource = db.sp_ViewDeniedRequest();
        }

        // Request Load
        private void dgvRequest_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            RequestInformation r = new RequestInformation();

            r.RequestID = int.Parse(dgvRequest.CurrentRow.Cells[0].Value.ToString());
            g.Username = dgvRequest.CurrentRow.Cells[1].Value.ToString();
            g.GetFullname();
            r.RequestFullname = g.Fullname;
            r.RequestTitle = dgvRequest.CurrentRow.Cells[2].Value.ToString();
            r.DateRequested = DateTime.Parse(dgvRequest.CurrentRow.Cells[3].Value.ToString());
            r.RequestStatus = dgvRequest.CurrentRow.Cells[4].Value.ToString();
            g.GENID = r.RequestID;
            g.GetRequestContent();
            r.RequestMessage = g.RequestContent;
            r.CurrentGENID = CurrentGENID;

            if (r.RequestStatus=="NEW REQUEST")
            {
                db.sp_RequestViewed(r.RequestID);
                r.RequestStatus = "PENDING";
                r.ShowDialog();
            }
            else
            {
                r.ShowDialog();
            }

            //inig close niya naay reply kay i set niya as closed na
            if (r.Reply == 1)
            {
                db.sp_RequestReplied(r.RequestID,r.Response);
            }

            dgvRequest.DataSource = db.sp_ViewAllRequest();
            RequestGridUpdate();
        }
        
        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            //dgvBorrowList.Rows.Insert(0, dgvToBeBorrowed.CurrentRow.Cells[0].Value.ToString(), g.GetEquipmentName(int.Parse(dgvToBeBorrowed.CurrentRow.Cells[0].Value.ToString())), 1);
            g.EquipmentID = int.Parse(dgvToBeBorrowed.CurrentRow.Cells[0].Value.ToString());

            bool Found = false;
            int Qty = 1;

            //rows is not blanks
            if (dgvBorrowList.Rows.Count > 0)
            {
                //Check if the product exists
                foreach (DataGridViewRow row in dgvBorrowList.Rows)
                {
                    if (Convert.ToString(row.Cells[0].Value)== dgvToBeBorrowed.CurrentRow.Cells[0].Value.ToString())
                    {
                        if (Convert.ToInt32(row.Cells[2].Value.ToString()) < Convert.ToInt32(dgvToBeBorrowed.CurrentRow.Cells[3].Value.ToString()))
                        {
                            row.Cells[2].Value = Convert.ToString(1 + Convert.ToInt32(row.Cells[2].Value));
                        }
                        else
                        {
                            MetroMessageBox.Show(this, "You cannot add more than what is available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        //row.Cells[2].Value = Convert.ToString(1 + Convert.ToInt32(row.Cells[2].Value));
                        Found = true;
                    }
                }
                if (!Found)
                {
                    //Add new text
                    dgvBorrowList.Rows.Insert(0, dgvToBeBorrowed.CurrentRow.Cells[0].Value.ToString(), g.GetEquipmentName(int.Parse(dgvToBeBorrowed.CurrentRow.Cells[0].Value.ToString())), 1);
                }
            }
            else
            {
                //add the first row if
                dgvBorrowList.Rows.Insert(0, dgvToBeBorrowed.CurrentRow.Cells[0].Value.ToString(), g.GetEquipmentName(int.Parse(dgvToBeBorrowed.CurrentRow.Cells[0].Value.ToString())), 1);
            }
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dgvBorrowList.SelectedRows)
            {
                dgvBorrowList.Rows.RemoveAt(item.Index);
            }
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            dgvBorrowList.Rows.Clear();
        }

        private void kryptonButton6_Click(object sender, EventArgs e)
        {
            if (dgvBorrowList.Rows.Count==0)
            {
                MetroMessageBox.Show(this, "Borrowlist is Empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FinalizeTransaction f = new FinalizeTransaction();

                if (string.IsNullOrEmpty(txtBorrowerFullname.Text) || string.IsNullOrEmpty(txtBorrowerUsername.Text))
                {
                    MetroMessageBox.Show(this, "Please select a borrower!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DataGridViewRow row = new DataGridViewRow();

                    for (int i = 0; i < dgvBorrowList.Rows.Count; i++)
                    {
                        row = (DataGridViewRow)dgvBorrowList.Rows[i].Clone();
                        int intColIndex = 0;
                        foreach (DataGridViewCell cell in dgvBorrowList.Rows[i].Cells)
                        {
                            row.Cells[intColIndex].Value = cell.Value;
                            intColIndex++;
                        }
                        f.dgvTransaction.Rows.Add(row);
                    }
                    t.TransactionID();
                    f.dgvTransaction.AllowUserToAddRows = false;
                    f.dgvTransaction.Refresh();
                    f.TransactionID = t.TID;
                    f.Borrower = txtBorrowerUsername.Text;
                    f.Action = "Borrowed an Equipment";
                    f.TransactionType = "Equipment Borrowing";
                    f.AdminID = CurrentGENID;
                    f.AdminName = g.Fullname;

                    f.ShowDialog();
                    dgvBorrowList.Rows.Clear();
                    txtBorrowerFullname.Text = null;
                    txtBorrowerUsername.Text = null;
                    UpdateAllTable();
                }
            }
        }

        int OTID;

        //search for transaction
        private void btnReturnSearch_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtReturnID.Text))
            {
                MetroMessageBox.Show(this, "Please fill correct transaction ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dgvCurrentBorrowed.DataSource = db.sp_ViewBorrowedEquipment(int.Parse(txtReturnID.Text));
                OTID = Convert.ToInt32(txtReturnID.Text);
                txtReturnID.Text = null;
            }
        }

        private void btnReturnSelected_Click(object sender, EventArgs e)
        {
            if (dgvCurrentBorrowed.Rows.Count==0)
            {
                MetroMessageBox.Show(this, "Please check your Transaction ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FinalizeReturn r = new FinalizeReturn();

                DataGridViewRow row = new DataGridViewRow();

                for (int i = 0; i < dgvCurrentBorrowed.Rows.Count; i++)
                {
                    row = (DataGridViewRow)dgvCurrentBorrowed.Rows[i].Clone();
                    //bool IsSelected = Convert.ToBoolean(row.Cells[3].Value);
                    //if (IsSelected)
                    //{
                    int intColIndex = 0;
                    foreach (DataGridViewCell cell in dgvCurrentBorrowed.Rows[i].Cells)
                    {
                        row.Cells[intColIndex].Value = cell.Value;
                        intColIndex++;
                    }
                    //}
                    r.dgvTransaction.Rows.Add(row);
                }

                r.OldTransactionID = OTID;
                t.TransactionID();
                r.dgvTransaction.AllowUserToAddRows = false;
                r.dgvTransaction.Refresh();
                r.TransactionID = t.TID;
                r.BorrowerID = g.GetBorrowerGENID(OTID);
                g.GetUsername(r.BorrowerID);
                r.Borrower = g.Username;
                r.Action = "Returning an Equipment";
                r.TransactionType = "Equipment Returning";
                r.AdminID = CurrentGENID;

                r.ShowDialog();
                dgvCurrentBorrowed.Rows.Clear();
                txtReturnID.Text = null;
            }
        }

        //Search User for Reservation
        private void kryptonButton1_Click_1(object sender, EventArgs e)
        {
            SearchUser s = new SearchUser();
            s.ShowDialog();
            txtReserverUsername.Text = s.Username;
            txtReserverFullname.Text = s.Fullname;
        }

        //Search of Equipment to be Reserved
        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            SearchKey = txtEquipmentReserveSearch.Text;
            dgvEquipmentReservation.DataSource = db.sp_EquipmentBorrowableView(SearchKey);
        }

        private void kryptonButton1_Click_2(object sender, EventArgs e)
        {
            //dgvEquipmentReservation source
            //dgvEquipmentToReserve dest

            //to be borrowed source
            //borrow list dest

            g.EquipmentID = int.Parse(dgvEquipmentReservation.CurrentRow.Cells[0].Value.ToString());

            bool Found = false;
            int Qty = 1;

            //rows is not blanks
            if (dgvEquipmentToReserve.Rows.Count > 0)
            {
                //Check if the product exists
                foreach (DataGridViewRow row in dgvEquipmentToReserve.Rows)
                {
                    if (Convert.ToString(row.Cells[0].Value) == dgvEquipmentReservation.CurrentRow.Cells[0].Value.ToString())
                    {
                        if (Convert.ToInt32(row.Cells[2].Value.ToString()) < Convert.ToInt32(dgvEquipmentReservation.CurrentRow.Cells[3].Value.ToString()))
                        {
                            row.Cells[2].Value = Convert.ToString(1 + Convert.ToInt32(row.Cells[2].Value));
                        }
                        else
                        {
                            MetroMessageBox.Show(this, "You cannot add more than what is available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        //row.Cells[2].Value = Convert.ToString(1 + Convert.ToInt32(row.Cells[2].Value));
                        Found = true;
                    }
                }
                if (!Found)
                {
                    //Add new text
                    dgvEquipmentToReserve.Rows.Insert(0, dgvEquipmentReservation.CurrentRow.Cells[0].Value.ToString(), g.GetEquipmentName(int.Parse(dgvEquipmentReservation.CurrentRow.Cells[0].Value.ToString())), 1);
                }
            }
            else
            {
                //add the first row if
                dgvEquipmentToReserve.Rows.Insert(0, dgvEquipmentReservation.CurrentRow.Cells[0].Value.ToString(), g.GetEquipmentName(int.Parse(dgvEquipmentReservation.CurrentRow.Cells[0].Value.ToString())), 1);
            }
        }

        // Save Reservation Info
        private void btnFinalizeReservation_Click(object sender, EventArgs e)
        {
            if (dgvEquipmentToReserve.Rows.Count==0)
            {
                MetroMessageBox.Show(this, "Reservation list is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtReserverFullname.Text.Trim())|| string.IsNullOrEmpty(txtReserverUsername.Text.Trim()))
            {
                MetroMessageBox.Show(this, "Please select client!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FinalizeReservation r = new FinalizeReservation();

                DataGridViewRow row = new DataGridViewRow();

                for (int i = 0; i < dgvEquipmentToReserve.Rows.Count; i++)
                {
                    row = (DataGridViewRow)dgvEquipmentToReserve.Rows[i].Clone();
                    int intColindex = 0;
                    foreach (DataGridViewCell cell in dgvEquipmentToReserve.Rows[i].Cells)
                    {
                        row.Cells[intColindex].Value = cell.Value;
                        intColindex++;
                    }
                    r.dgvReservation.Rows.Add(row);
                }

                t.TransactionID();
                r.dgvReservation.Refresh();
                r.TransactionID = t.TID;
                r.Reservee = txtReserverUsername.Text;
                r.Action = "Reserved an Equipment";
                r.TransactionType = "Equipment Reservation";
                r.AdminID = CurrentGENID;
                r.ReservationDate = dtpReseravationDate.Value;
                r.ShowDialog();

                dgvEquipmentToReserve.Rows.Clear();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy != true)
            {
                //this.Close();
                backgroundWorker1.RunWorkerAsync();
                l.ShowDialog();
            }
        }
        

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(2000);
            if (InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    TableUpdate();
                }
                ));
            }
            else
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    TableUpdate();
                }
                ));
            }
        }

        private void TableUpdate()
        {
            dgvToBeBorrowed.DataSource = db.sp_EquipmentBorrowableView(SearchKey);

            dgvEquipmentReservation.DataSource = db.sp_EquipmentBorrowableView(SearchKey);

            dgvTransactionHistory.DataSource = db.sp_TransactionViewAll();

            dgvUserRegister.DataSource = db.sp_UserView();

            dgvRequest.DataSource = db.sp_ViewOpenRequest();

            dgvBorrowReport.DataSource = db.sp_BorrowedReport();

            dgvReservationReport.DataSource = db.sp_EquipmentReservationReport(DateTime.Now, DateTime.Now.AddDays(7));

            dgvEquipmentStatusReport.DataSource = db.sp_EquipmentStatusReport();

            dgvPullOutReports.DataSource = db.sp_PulledEquipmentsView();

            dgvReturnedReport.DataSource = db.sp_ReturnedReport();

            dgvDeployReport.DataSource = db.sp_DeploymentReport(); ;

            eq.SearchKey = "";
            txtEquipmentID.Text = eq.EquipmentID().ToString();

            dgvEquipment.DataSource = db.sp_EquipmentView(eq.SearchKey);

            lblSumEquipments.Text = g.GetTotalEquipmentQuantity().ToString();
            lblNewRequests.Text = g.GetTotalNumberOfNewRequests().ToString();
            lblSumBorrowed.Text = g.GetTotalEquipmentBorrowedQuantity().ToString() + " / " + g.GetTotalEquipmentQuantity().ToString();
            lblTotalDamaged.Text = g.GetTotalNumberOfDamagedEquipment().ToString();
            lblTotalNumberOfReservations.Text = g.GetTotalNumberOfReservations().ToString();

            int totalborrowed = g.GetTotalEquipmentBorrowedQuantity();
            int totalquantity = g.GetTotalEquipmentQuantity();
            int totaldamaged = g.GetTotalNumberOfDamagedEquipment();

            if (totalquantity==0)
            {
                totalquantity = totaldamaged = totalborrowed = 0;
            }
            else
            {
                double borrowed = ((double)totalborrowed / (double)totalquantity) * 100;

                double damaged = ((double)totaldamaged / (double)totalquantity) * 100;

                cpbBorrowed.Text = Math.Round(borrowed, 1).ToString();
                cpbBorrowed.Value = Convert.ToInt32(borrowed);

                cpbDamaged.Text = Math.Round(damaged, 1).ToString();
                cpbDamaged.Value = Convert.ToInt32(damaged);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Show();   
        }

        private void txtReturnID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnReturnSearch.PerformClick();
            }
        }

        private void btnTransactionFilter_Click(object sender, EventArgs e)
        {
            string type = "";
            if (drpTransactionType.Text == "Equipment Registration")
            {
                type = "Registered an Equipment";
            }
            else if (drpTransactionType.Text == "Equipment Borrowing")
            {
                type = "Borrowed an Equipment";
            }
            else if (drpTransactionType.Text == "Equipment Returning")
            {
                type = "Returning an Equipment";
            }
            else if (drpTransactionType.Text == "Equipment Reservation")
            {
                type = "Reserved an Equipment";
            }
            else if (drpTransactionType.Text == "Equipment Deployment")
            {
                type = "Deployed an Equipment";
            }
            else if (drpTransactionType.Text == "All")
            {
                type = "";
            }
            else
            {
                type = "";
            }
            dgvTransactionHistory.DataSource = db.sp_TransactionSearchDate(dtpTransactionFrom.Value, dtpTransactionTo.Value, type);
        }

        private void dgvTransactionHistory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TransactionDetails td = new TransactionDetails(int.Parse(dgvTransactionHistory.CurrentRow.Cells[0].Value.ToString()), DateTime.Parse(dgvTransactionHistory.CurrentRow.Cells[1].Value.ToString()), dgvTransactionHistory.CurrentRow.Cells[3].Value.ToString(), CurrentGENID, dgvTransactionHistory.CurrentRow.Cells[2].Value.ToString());

            if (dgvTransactionHistory.CurrentRow.Cells[2].Value.ToString() == "Borrowed an Equipment")
            {

            }
            else if (dgvTransactionHistory.CurrentRow.Cells[2].Value.ToString() == "Returning an Equipment")
            {

            }

            td.ShowDialog();
        }

        /// <summary>
        /// Deployment Area
        /// </summary>
        

        // Deploymen Add to List
        private void btnAddtoDeploy_Click(object sender, EventArgs e)
        {
            //dgvEquipmentDeployList.Rows.Insert(0, dgvDeployEquipment.CurrentRow.Cells[0].Value.ToString(), g.GetEquipmentName(int.Parse(dgvDeployEquipment.CurrentRow.Cells[0].Value.ToString())), 1);
            g.EquipmentID = int.Parse(dgvDeployEquipment.CurrentRow.Cells[0].Value.ToString());

            bool Found = false;
            int Qty = 1;

            //rows is not blanks
            if (dgvEquipmentDeployList.Rows.Count > 0)
            {
                //Check if the product exists
                foreach (DataGridViewRow row in dgvEquipmentDeployList.Rows)
                {
                    if (Convert.ToString(row.Cells[0].Value) == dgvDeployEquipment.CurrentRow.Cells[0].Value.ToString())
                    {
                        if (Convert.ToInt32(row.Cells[2].Value.ToString()) < Convert.ToInt32(dgvDeployEquipment.CurrentRow.Cells[3].Value.ToString()))
                        {
                            row.Cells[2].Value = Convert.ToString(1 + Convert.ToInt32(row.Cells[2].Value));
                        }
                        else
                        {
                            MetroMessageBox.Show(this, "You cannot add more than what is available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        //row.Cells[2].Value = Convert.ToString(1 + Convert.ToInt32(row.Cells[2].Value));
                        Found = true;
                    }
                }
                if (!Found)
                {
                    //Add new text
                    dgvEquipmentDeployList.Rows.Insert(0, dgvDeployEquipment.CurrentRow.Cells[0].Value.ToString(), g.GetEquipmentName(int.Parse(dgvDeployEquipment.CurrentRow.Cells[0].Value.ToString())), 1);
                }
            }
            else
            {
                //add the first row if
                dgvEquipmentDeployList.Rows.Insert(0, dgvDeployEquipment.CurrentRow.Cells[0].Value.ToString(), g.GetEquipmentName(int.Parse(dgvDeployEquipment.CurrentRow.Cells[0].Value.ToString())), 1);
            }

            DeployEquipmentCount++;
            lblDeploymentItemsCount.Text = DeployEquipmentCount.ToString();
        }

        // Remove an item from the deployment LIst
        private void btnRemoveFromDeploy_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dgvEquipmentDeployList.SelectedRows)
            {
                dgvEquipmentDeployList.Rows.RemoveAt(item.Index);
            }

            int value = Convert.ToInt32(dgvEquipmentDeployList.CurrentRow.Cells[2].Value.ToString());

            DeployEquipmentCount = DeployEquipmentCount - value;
            lblDeploymentItemsCount.Text = DeployEquipmentCount.ToString();
        }

        // Clear all the rows in the deployment list
        private void btnClearDeploymentList_Click(object sender, EventArgs e)
        {
            dgvEquipmentDeployList.Rows.Clear();
            DeployEquipmentCount = 0;
            lblDeploymentItemsCount.Text = DeployEquipmentCount.ToString();
        }

        private void drpDeploymentDestination_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDeploymentTeacher.Text = g.GetTeacherNameFromFacility(drpDeploymentDestination.Text);
            lblDeploymentRmDesignation.Text = g.GetRoomName(drpDeploymentDestination.Text);
        }

        private void btnDeploymentConfirm_Click(object sender, EventArgs e)
        {
            if (dgvEquipmentDeployList.Rows.Count==0)
            {
                MetroMessageBox.Show(this, "Deployment list is Empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty( drpDeploymentDestination.Text)||string.IsNullOrEmpty(lblDeploymentRmDesignation.Text)||string.IsNullOrEmpty(lblDeploymentTeacher.Text))
            {
                MetroMessageBox.Show(this, "Please select deployment destination!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                t.TransactionID();

                FinalizeDeployment d = new FinalizeDeployment(t.TID, drpDeploymentDestination.Text, g.GetFacilyTeacherGENID(drpDeploymentDestination.Text), dtpDeploymentDate.Value, DeployEquipmentCount, CurrentGENID);

                DataGridViewRow row = new DataGridViewRow();

                for (int i = 0; i < dgvEquipmentDeployList.Rows.Count; i++)
                {
                    row = (DataGridViewRow)dgvEquipmentDeployList.Rows[i].Clone();
                    int intColIndex = 0;
                    foreach (DataGridViewCell cell in dgvEquipmentDeployList.Rows[i].Cells)
                    {
                        row.Cells[intColIndex].Value = cell.Value;
                        intColIndex++;
                    }
                    d.dgvDeployList.Rows.Add(row);
                }

                d.ShowDialog();

                dgvEquipmentDeployList.Rows.Clear();
                drpDeploymentDestination.Text = "";
            }
        }

        private void btnViewPullOutDetails_Click_1(object sender, EventArgs e)
        {
            int PTID;

            if (string.IsNullOrWhiteSpace(txtPullOutTraansactionID.Text.Trim()))
            {
                

                if (string.IsNullOrEmpty(drpPullOutLocation.Text.Trim()))
                {
                    MetroMessageBox.Show(this, "Please input Transaction ID or Room No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearSearch();
                }
                else
                {
                    dgvPullOutView.DataSource = db.sp_ViewDeployedEquipmentsFacilityID(g.GetFacilityID(drpPullOutLocation.Text));

                    int q = 0;

                    for (int i = 0; i < dgvPullOutView.Rows.Count; i++)
                    {
                        q += Convert.ToInt32(dgvPullOutView.Rows[i].Cells[2].Value);
                    }

                    lblPulloutTotalBorrowed.Text = q.ToString();

                    ClearSearch();
                }
            }
            else
            {
                if (int.TryParse(txtPullOutTraansactionID.Text,out PTID))
                {
                    dgvPullOutView.DataSource = db.sp_ViewDeployedEquipmentsTransactionID(Convert.ToInt32(txtPullOutTraansactionID.Text));

                    int q = 0;

                    for (int i = 0; i < dgvPullOutView.Rows.Count; i++)
                    {
                        q += Convert.ToInt32(dgvPullOutView.Rows[i].Cells[2].Value);
                    }

                    lblPulloutTotalBorrowed.Text = q.ToString();
                    ClearSearch();
                }
                else
                {
                    MetroMessageBox.Show(this, "Invalid Transcation ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPullOutTraansactionID.Text = null;

                }

            }
        }

        public void ClearSearch()
        {
            txtPullOutTraansactionID.Text = null;
        }

        private void dgvPullOutView_CellValidating(object sender,DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 4) // 1 should be your column index
            {
                int i;

                if (!int.TryParse(Convert.ToString(e.FormattedValue), out i))
                {
                    e.Cancel = true;
                    label1.Text = "please enter numeric";
                }
                else
                {
                    // the input is numeric 
                }
            }
        }

        /// <summary>
        /// Pull Out Code
        /// </summary>


        private void drpPullOutLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblPullOutTeacher.Text = g.GetTeacherNameFromFacility(drpPullOutLocation.Text);
            lblPullOutRmName.Text = g.GetRoomName(drpPullOutLocation.Text);
            lblPullOutRoom.Text = drpPullOutLocation.Text;

            int q = 0;

            for (int i = 0; i < dgvPullOutView.Rows.Count; i++)
            {
                q += Convert.ToInt32(dgvPullOutView.Rows[i].Cells[2].Value);
            }

            lblPulloutTotalBorrowed.Text = q.ToString();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            if (dgvPullOutView.Rows.Count==0)
            {
                MetroMessageBox.Show(this, "Pull-Out list is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FinalizePullOut f = new FinalizePullOut(CurrentGENID, g.GetFacilyTeacherGENID(drpPullOutLocation.Text), lblPullOutRoom.Text, lblPullOutRmName.Text);

                DataGridViewRow row = new DataGridViewRow();

                for (int i = 0; i < dgvPullOutView.Rows.Count; i++)
                {
                    row = (DataGridViewRow)dgvPullOutView.Rows[i].Clone();
                    int intColIndex = 0;
                    foreach (DataGridViewCell cell in dgvPullOutView.Rows[i].Cells)
                    {
                        row.Cells[intColIndex].Value = cell.Value;
                        intColIndex++;
                    }
                    f.dgvPullOutFinal.Rows.Add(row);
                }

                f.ShowDialog();

                dgvPullOutView.Rows.Clear();
            }
        }

        private void RequestGridUpdate()
        {
            //foreach (DataGridViewRow row in dgvRequest.Rows)
            //{
            //    if (row.Cells[4].Value.ToString() == "OPEN")
            //    {
            //        row.DefaultCellStyle.BackColor = Color.FromArgb(78, 186, 186);
            //    }
            //    else if (row.Cells[4].Value.ToString() == "PENDING")
            //    {
            //        row.DefaultCellStyle.BackColor = Color.Red;
            //    }
            //    else if (row.Cells[4].Value.ToString() == "CLOSED")
            //    {
            //        row.DefaultCellStyle.BackColor = Color.Red;
            //    }
            //}

            //foreach (DataGridViewRow row in dgvEquipment.Rows)
            //{
            //    if (Convert.ToInt32(row.Cells[3].Value) == 110)
            //    {
            //        row.DefaultCellStyle.BackColor = Color.FromArgb(78, 186, 186);
            //    }
            //    else if (Convert.ToInt32(row.Cells[3].Value) == 110)
            //    {
            //        row.DefaultCellStyle.BackColor = Color.FromArgb(255, 206, 107);
            //    }
            //    if (Convert.ToInt32(row.Cells[3].Value) == 110)
            //    {
            //        row.DefaultCellStyle.BackColor = Color.FromArgb(255, 107, 107);
            //    }
            //}
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

        private void bunifuCustomLabel19_Click(object sender, EventArgs e)
        {

        }

        private void tabPage17_Click(object sender, EventArgs e)
        {

        }

        private void metroGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnReturnSearch_Click(object sender, EventArgs e)
        {

        }

        private void txtReturnID_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvCurrentBorrowed_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bgwEquipmentRegistration_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void dgvEquipment_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgvEquipment.Columns[e.ColumnIndex] is DataGridViewImageColumn)
            {
                string imagePath = (e.Value ?? "").ToString().Trim();

                if (imagePath != "")
                {
                    e.Value = Image.FromFile(imagePath);
                }
            }
        }


        private void lblCurrentUser_Click(object sender, EventArgs e)
        {

        }

        private void kryptonRichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonRichTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnViewPullOutDetails.PerformClick();
            }
        }

        private void btnViewPullOutDetails_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void btnViewPullOutDetails_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void tabPage10_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            g.GetUsername(CurrentGENID);
            g.GetFullname();
            frmCurrentBorrowed f = new frmCurrentBorrowed(g.Fullname, DateTime.Now);
            f.ShowDialog();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            frmDeploymentReport f = new frmDeploymentReport(CurrentGENID, DateTime.Now);
            f.ShowDialog();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            frmReservationReport f = new frmReservationReport(CurrentGENID, DateTime.Now);
            f.ShowDialog();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            frmEquipmmentStatus f = new frmEquipmmentStatus(CurrentGENID);
            f.ShowDialog();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            frmInventoryReport f = new frmInventoryReport(CurrentGENID, DateTime.Now);
            f.ShowDialog();
        }

        private void btnReservationClear_Click(object sender, EventArgs e)
        {
            dgvEquipmentToReserve.Rows.Clear();
        }

        private void btnReservationRemove_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dgvEquipmentToReserve.SelectedRows)
            {
                dgvEquipmentToReserve.Rows.RemoveAt(item.Index);
            }
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            frmEquipmentsReport f = new frmEquipmentsReport(CurrentGENID);
            f.ShowDialog();
        }
    }
}