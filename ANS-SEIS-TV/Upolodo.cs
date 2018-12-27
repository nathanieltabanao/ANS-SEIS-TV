using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ANS_SEIS_TV
{
    public partial class Upolodo : Form
    {
        public Upolodo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // name is sheetname
            String name = "Sheet1";

            // C:// could be  path
            // C:\\Users\Nathaniel Angelico\Desktop\\
            String constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
                            @"C:\\Users\Nathaniel Angelico\Desktop\Sample.xlsx" +
                            ";Extended Properties='Excel 12.0 XML;HDR=YES;';";

            OleDbConnection con = new OleDbConnection(constr);
            OleDbCommand oconn = new OleDbCommand("Select * From [" + name + "$]", con);
            con.Open();

            OleDbDataAdapter sda = new OleDbDataAdapter(oconn);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
        }
    }
}
