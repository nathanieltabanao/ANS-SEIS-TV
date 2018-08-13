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
            

            foreach (DataGridViewRow row in dgv.Rows)
            {
                //if (row.Cells[3].Value == "OPEN")
                //{
                //    row.DefaultCellStyle.BackColor = Color.FromArgb(78, 186, 186);
                //}
                //else if (row.Cells[4].Value == "PENDING")
                //{
                //    row.DefaultCellStyle.BackColor = Color.Red;
                //}
                //else if (row.Cells[4].Value == "CLOSED")
                //{
                //    row.DefaultCellStyle.BackColor = Color.Red;
                //}
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.dgv.Rows.Insert(0, "one", "two", "three", "four");
        }
    }
}
