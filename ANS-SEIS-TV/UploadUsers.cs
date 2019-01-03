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
using MetroFramework.Forms;
using System.Globalization;
using System.IO;
using System.Data.OleDb;
using System.Runtime.InteropServices;

namespace ANS_SEIS_TV
{
    public partial class UploadUsers : MetroForm
    {
        public UploadUsers()
        {
            InitializeComponent();

            this.BorderStyle = MetroFormBorderStyle.FixedSingle;
            this.ShadowType = MetroFormShadowType.AeroShadow;

            IsUploaded = 0;
        }

        public int IsUploaded { get; set; }

        private void btnOpenFileDialog_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtFileLocation.Text = openFileDialog1.FileName;
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            // name is sheetname
            String name = txtSheetName.Text.Trim();

            
            // path
            String locationPath = txtFileLocation.Text;

            if (string.IsNullOrWhiteSpace(locationPath))
            {
                MetroMessageBox.Show(this, "Location is Empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(name))
            {
                MetroMessageBox.Show(this, "Sheet name can't be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // C:// could be  path
                // C:\\Users\Nathaniel Angelico\Desktop\\
                try
                {
                    String constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + locationPath + ";Extended Properties='Excel 12.0 XML;HDR=YES;';";

                    OleDbConnection con = new OleDbConnection(constr);
                    OleDbCommand oconn = new OleDbCommand("Select * From [" + name + "$]", con);

                    con.Open();

                    OleDbDataAdapter sda = new OleDbDataAdapter(oconn);
                    DataTable data = new DataTable();
                    sda.Fill(data);
                    dgvUserUpload.DataSource = data;
                }
                catch (Exception)
                {
                    MetroMessageBox.Show(this, "Incorrect Sheet Name or Sheet Name not Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    
                }

                int colCount = dgvUserUpload.Rows[0].Cells.Count;

                if (colCount > 6 || colCount < 6) 
                {
                    MetroMessageBox.Show(this, "Incorrect Sheet Format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dgvUserUpload.DataSource = null;
                }
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy == false)
            {
                backgroundWorker1.RunWorkerAsync();
                LoadingScreen2 l = new LoadingScreen2();
                l.ShowDialog();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            UserLibrary u = new UserLibrary();
            int Upload = 0;

            foreach (DataGridViewRow row in dgvUserUpload.Rows)
            {
                u.GENID = u.UserID();
                                
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    if (row.Cells[i].Value == null || row.Cells[i].Value == DBNull.Value || String.IsNullOrWhiteSpace(row.Cells[i].Value.ToString()))
                    {

                    }
                    else
                    {
                        if (Convert.ToInt32(row.Cells[5].Value) == 110)
                        {
                            u.ID = "AD-" + (u.UserID() + 1).ToString().PadLeft(5, '0');
                        }
                        else if (Convert.ToInt32(row.Cells[5].Value) == 111)
                        {
                            u.ID = "TR-" + (u.UserID() + 1).ToString().PadLeft(5, '0');
                        }
                        else if (Convert.ToInt32(row.Cells[5].Value) == 112)
                        {
                            u.ID = "ST-" + (u.UserID() + 1).ToString().PadLeft(5, '0');
                        }

                        u.Username = row.Cells[0].Value.ToString();
                        u.Password = "1234";
                        u.FirstName = row.Cells[1].Value.ToString();
                        u.MiddleName = row.Cells[2].Value.ToString();
                        u.LastName = row.Cells[3].Value.ToString();
                        u.ContactNumber = row.Cells[4].Value.ToString();
                        u.Usertype = Convert.ToInt32(row.Cells[5].Value);

                        Upload = 1;
                    }
                }

                if (Upload==1)
                {
                    u.UserInsert();
                    Upload = 0;
                }
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MetroMessageBox.Show(this, "Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                IsUploaded = 1;
                MetroMessageBox.Show(this, "User Upload Complete", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
        }
    }
}
