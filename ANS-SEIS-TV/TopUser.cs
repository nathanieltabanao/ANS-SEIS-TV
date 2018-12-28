using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;


namespace ANS_SEIS_TV
{
    public partial class TopUser : Form
    {
        public TopUser()
        {
            InitializeComponent();

            DataClasses1DataContext db = new DataClasses1DataContext();

            fillChart();
        }

        private void fillChart()
        {
            SqlConnection con = new SqlConnection("Data Source=NATHANIEL-VX15;Initial Catalog=ANS_SEIS_TV;Integrated Security=true;");
            DataSet ds = new DataSet();
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter("SELECT TBLUSERDETAILS.FIRSTNAME+' '+TBLUSERDETAILS.MIDDLENAME +' '+ TBLUSERDETAILS.LASTNAME as 'Name', TBLUSERUSAGESTATISTICS.TotalBorrowedEquipments from TBLUSERUSAGESTATISTICS inner join TBLUSERDETAILS on TBLUSERUSAGESTATISTICS.GENID = TBLUSERDETAILS.GENID", con);
            adapt.Fill(ds);
            chart1.DataSource = ds;
            //set the member of the chart data source used to data bind to the X-values of the series  
            chart1.Series["Name"].XValueMember = "Name";
            //set the member columns of the chart data source used to data bind to the X-values of the series  
            chart1.Series["Name"].YValueMembers = "TotalBorrowedEquipments";
            chart1.Titles.Add("Top Borrowers Chart");
            con.Close();

        }
    }
}
