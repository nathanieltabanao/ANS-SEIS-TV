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
    public partial class UploadInventory : MetroForm
    {
        public UploadInventory()
        {
            InitializeComponent();

            this.BorderStyle = MetroFormBorderStyle.FixedSingle;
            this.ShadowType = MetroFormShadowType.AeroShadow;

            LocationToolTip.SetToolTip(btnOpenFileDialog, "Click to open Locate File");

            IsUploaded = 0;
        }

        DataClasses1DataContext db = new DataClasses1DataContext();
        EquipmentLibrary eq = new EquipmentLibrary();
        TransactionLibrary t = new TransactionLibrary();
        StuffLibrary s = new StuffLibrary();
        UserLibrary u = new UserLibrary();

        public int IsUploaded { get; set; }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result== DialogResult.OK)
            {
                txtFileLocation.Text = openFileDialog1.FileName;
            }
        }

        private void LocationToolTip_Popup(object sender, PopupEventArgs e)
        {
            // LocationToolTip.Show("Click to open Locate File", btnOpenFileDialog);
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
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
                    if (ce.ErrorCode == Convert.ToInt32(0x80004005))
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
            if (backgroundWorker1.IsBusy==false)
            {
                backgroundWorker1.RunWorkerAsync();
                LoadingScreen2 l = new LoadingScreen2();
                l.ShowDialog();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            t.TransactionID();
            eq.ID = db.sp_EquipmentID(); // Get Equipment ID
            t.Action = "Registered an Equipment";
            t.NewTransaction(DateTime.Now, t.Action, 1000000);
            foreach (DataGridViewRow row in dgvInventoryUpload.Rows)
            {
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    if (row.Cells[i].Value == null || row.Cells[i].Value == DBNull.Value || String.IsNullOrWhiteSpace(row.Cells[i].Value.ToString()))
                    {

                    }
                    else
                    {
                        eq.ID = db.sp_EquipmentID(); // Get Equipment ID

                        // Load stuff sa Equipment Library
                        eq.EquipmentBarcode = eq.ID.ToString();
                        eq.EquipmentName = row.Cells[0].Value.ToString();
                        eq.EquipmentDescription = row.Cells[1].Value.ToString();
                        eq.EquipmentTypeID = Convert.ToInt32(row.Cells[2].Value);
                        eq.EquipmentQuantity = Convert.ToInt32(row.Cells[3].Value);

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
                        //t.Action = "Registered an Equipment";
                        //t.NewTransaction(DateTime.Now, t.Action, CurrentGENID);

                        //commented cuz ok na
                        t.NewBorrowed(t.TID, 1000000, eq.ID, DateTime.Now, 0, true);
                        t.NewEquipmentAdded(eq.ID, 0);


                        //for the borrowing
                        // for status btaw na hahahaha
                        eq.EquipmentStatusAdd(eq.ID, eq.EquipmentQuantity);


                        // for PullOut
                        eq.NewEquipmentPullOut(eq.ID);
                    }
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
                MetroMessageBox.Show(this, "Equipment Inventory Upload Complete", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
