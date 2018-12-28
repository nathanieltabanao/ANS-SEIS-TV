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
        }

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
                String constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + locationPath + ";Extended Properties='Excel 12.0 XML;HDR=YES;';";

                OleDbConnection con = new OleDbConnection(constr);
                OleDbCommand oconn = new OleDbCommand("Select * From [" + name + "$]", con);

                con.Open();

                OleDbDataAdapter sda = new OleDbDataAdapter(oconn);
                DataTable data = new DataTable();
                try
                {
                    sda.Fill(data);
                }
                catch (COMException ce)
                {
                    if (ce.ErrorCode ==Convert.ToInt32(0x80004005))
                    {
                        MetroMessageBox.Show(this, "Incorrect Sheet Name or Sheet Name not Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                finally
                {
                    dgvInventoryUpload.DataSource = data;
                }
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {

        }
    }
}
