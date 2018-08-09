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
using MaterialSkin.Animations;

namespace ANS_SEIS_TV
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();

            

        }

        DataClasses1DataContext db = new DataClasses1DataContext();

        private void Form1_Load(object sender, EventArgs e)
        {
            dgv.DataSource = db.sp_UserView();

            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (Convert.ToInt32(row.Cells[7].Value) == 110)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (Convert.ToInt32(row.Cells[7].Value)==110)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }
    }
}
