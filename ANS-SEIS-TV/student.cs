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
using System.Threading;
using System.IO;

namespace ANS_SEIS_TV
{
    public partial class student : MaterialForm
    {
        public student()
        {
            //InitializeComponent();

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
        }

        EquipmentLibrary e = new EquipmentLibrary();

        UserLibrary u = new UserLibrary();

        DataClasses1DataContext db = new DataClasses1DataContext();

        GetSomethingFromServer g = new GetSomethingFromServer();

        TransactionLibrary t = new TransactionLibrary();

        LoadingScreen2 l = new LoadingScreen2();

        public string CurrentUsername { get; set; }

        public int CurrentGENID { get; set; }

        public void StartForm()
        {
            Application.Run(new SplashScreen());
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void materialTabSelector2_Click(object sender, EventArgs e)
        {
            
        }

        private void student_Load(object sender, EventArgs e)
        {
            g.Username = CurrentUsername;
            g.GetFullname();
            lblCurrentUser.Text = "Welcome Student! : " + g.Fullname;
            
            g.GetGENID(CurrentUsername);
            CurrentGENID = g.GENID;

            TableUpdate();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm l = new LoginForm();
            u.Action = "User Logout";
            u.UserLoginLog();
            l.Show();
        }

        private void TableUpdate()
        {
            dgvBorrowed.DataSource = db.sp_BorrowTeacherView(CurrentGENID);
        }
    }
}
