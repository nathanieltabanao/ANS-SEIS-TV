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
    
        private readonly MaterialSkinManager materialSkinManager;


        //Main form Constructor
        public Main()
        {
            
            Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();
            Thread.Sleep(5000);

            InitializeComponent();
            
            t.Abort();

            bgwEquipmentRegistration.WorkerReportsProgress = true;
            bgwEquipmentRegistration.WorkerSupportsCancellation = true;
            // Initialize MaterialSkinManager
            //materialSkinManager = MaterialSkinManager.Instance;
            //materialSkinManager.AddFormToManage(this);
            //materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            //materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey600, Primary.Grey400, Primary.BlueGrey600, Accent.LightBlue400, TextShade.WHITE);
        }

        public void StartForm()
        {
            Application.Run(new SplashScreen());
        }

        //initialize Connection

        DataClasses1DataContext db = new DataClasses1DataContext();

        UserLibrary u = new UserLibrary();

        EquipmentLibrary eq = new EquipmentLibrary();

        GetSomethingFromServer g = new GetSomethingFromServer();

        TransactionLibrary t = new TransactionLibrary();

        StuffLibrary s = new StuffLibrary();
        

        public string CurrentUser { get; set; }
        public string CurrentUserID { get; set; }
        public string SearchKey { get; set; }
        public int CurrentGENID { get; set; }


        //Main form load 
        private void Main_Load(object sender, EventArgs e)
        {
            SearchKey = "";
            txtUsername.Enabled = false;
            txtPassword.Enabled = false;
            g.Username = CurrentUser;
            g.GetFullname();
            lblCurrentUser.Text = "Welcome Admin : " + g.Fullname;
            u.CurrentUsername = CurrentUser;
            g.GetUserID();
            CurrentUserID = g.ID;
            u.CurrentID = CurrentUserID;
            rdoAllRequest.Checked = true;
            
            CurrentGENID = g.GetGENID(CurrentUser);
            AddingEquipment();
            RequestGridUpdate();
            AddUser();
            UpdateAllTable();
            txtEquipmentID.Text = db.sp_EquipmentID().ToString();


        }

        private void UpdateAllTable()
        {
            ViewEquipment();

            rdoOpenRequest.Checked = true;
            dgvUserRegister.DataSource = db.sp_UserView();

            dgvToBeBorrowed.DataSource = db.sp_EquipmentBorrowableView(SearchKey);

            dgvEquipmentReservation.DataSource = db.sp_EquipmentBorrowableView(SearchKey);
        }

        

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
            txtUsername.Enabled = false;
            txtPassword.Enabled = false;
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
            UpdateAllTable();

            u.ID = u.CurrentID;
            u.Action = "Registered a new User";
            u.ActionReport();
            rdoAdmin.Checked = true;
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
            UpdateAllTable();

            u.ID = u.CurrentID;
            u.Action = "Deleted a user";
            u.ActionReport();
            Admin();
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {


            u.ID = u.CurrentID;
            u.Action = "Edited a user detail";
            u.ActionReport();

            Admin();
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

            if (string.IsNullOrWhiteSpace(drpEquipmentType.Text))
            {
                MessageBox.Show("Please choose Equipment Type!");
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
                if (string.IsNullOrEmpty(txtEquipmentName.Text) || string.IsNullOrEmpty(txtEquipmentDescription.Text) || string.IsNullOrEmpty(txtEquipmentID.Text))
                {
                    MetroMessageBox.Show(this, "Please fill all necessary information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    u.Action = "Registered a new Equipment";
                    txtEquipmentID.Text = db.sp_EquipmentID().ToString();
                    eq.ID = db.sp_EquipmentID(); // Get Equipment ID




                    eq.EquipmentBarcode = txtEquipmentID.Text;
                    eq.EquipmentName = txtEquipmentName.Text;
                    eq.EquipmentDescription = txtEquipmentDescription.Text;
                    eq.EquipmentTypeID = EquipmentTypeID; // int.Parse(drpEquipmentType.Text.Substring(0,3));
                    eq.EquipmentQuantity = int.Parse(numQuantity.Value.ToString());

                    eq.EquipmentInsert(); // Save data to Database

                    
                    s.GenerateBarcode(eq.EquipmentBarcode.ToString());

                    //Image img = Image.FromFile(s.SavePath);
                    //byte[] arr;

                    //using (MemoryStream ms = new MemoryStream())
                    //{
                    //    img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    //    arr = ms.ToArray();
                    //}

                    String strBLOBFilePath = s.SavePath;//Modify this path as needed.

                    //Read jpg into file stream, and from there into Byte array.
                    FileStream fsBLOBFile = new FileStream(strBLOBFilePath, FileMode.Open, FileAccess.Read);
                    Byte[] bytBLOBData = new Byte[fsBLOBFile.Length];
                    fsBLOBFile.Read(bytBLOBData, 0, bytBLOBData.Length);
                    fsBLOBFile.Close();


                    db.sp_NewEquipmentBarcodeInsert(Convert.ToInt32(eq.EquipmentBarcode), bytBLOBData, s.SavePath);

                    t.NewEquipmentAdded(eq.ID, 0);
                    t.Action = "Registered an Equipment";
                    t.NewTransaction(DateTime.Now, t.Action, CurrentGENID);

                    //commented cuz ok na
                    t.NewBorrowed(t.TID, CurrentGENID, eq.ID, DateTime.Now, 0, true, true);
                    t.NewEquipmentAdded(eq.ID, 0);

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

            //if (bgwEquipmentRegistration.IsBusy != true)
            //{
            //    bgwEquipmentRegistration.RunWorkerAsync();
            //    LoadingScreen l = new LoadingScreen();
            //    l.ShowDialog();
            //}
        }

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
            UpdateAllTable();
        }

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
            UpdateAllTable();
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

            if (r.RequestStatus=="OPEN")
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
                MetroMessageBox.Show(this, "Please fill all necessary information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                ReturnFinalize r = new ReturnFinalize();

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

                r.OldTransactionID = int.Parse(txtReturnID.Text);
                t.TransactionID();
                r.dgvTransaction.AllowUserToAddRows = false;
                r.dgvTransaction.Refresh();
                r.TransactionID = t.TID;
                r.BorrowerID = g.GetBorrowerGENID(int.Parse(txtReturnID.Text));
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


        private void btnFinalizeReservation_Click(object sender, EventArgs e)
        {
            ReservationFinalize r = new ReservationFinalize();

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
    }
}