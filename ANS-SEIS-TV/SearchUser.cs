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
using MetroFramework.Forms;

namespace ANS_SEIS_TV
{
    public partial class SearchUser : MetroForm
    {
        public SearchUser()
        {
            InitializeComponent();
        }

        public string SearchKey { get; set; }

        DataClasses1DataContext db = new DataClasses1DataContext();

        public string Username { get; set; }
        public string Fullname { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string ID { get; set; }

        private void SearchUser_Load(object sender, EventArgs e)
        {
            SearchKey = "";
            dgvUser.DataSource = db.sp_UserSearchAdmin(SearchKey);
            rdoTeacher.Checked = true;
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (rdoStudent.Checked)
            {
                dgvUser.DataSource = db.sp_StudentSearch(SearchKey);
            }
            else if (rdoTeacher.Checked)
            {
                dgvUser.DataSource = db.sp_UserSearchAdmin(SearchKey);
            }
        }

        private void dgvSearch_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = dgvUser.CurrentRow.Cells[0].Value.ToString();
            Username = dgvUser.CurrentRow.Cells[1].Value.ToString();
            FirstName = dgvUser.CurrentRow.Cells[2].Value.ToString();
            MiddleName = dgvUser.CurrentRow.Cells[3].Value.ToString();
            LastName = dgvUser.CurrentRow.Cells[4].Value.ToString();
            Fullname = FirstName + " " + MiddleName + " " + LastName;
            this.Close();
        }

        private void SearchUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void SearchUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdoTeacher_CheckedChanged(object sender, EventArgs e)
        {
            dgvUser.DataSource = db.sp_UserSearchAdmin(SearchKey);
        }

        private void rdoStudent_CheckedChanged(object sender, EventArgs e)
        {
            dgvUser.DataSource = db.sp_StudentView();
        }
    }
}
