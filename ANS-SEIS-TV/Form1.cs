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
using KeepAutomation.Barcode.Bean;
using KeepAutomation.Barcode;
using KeepAutomation;
using System.IO;

namespace ANS_SEIS_TV
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        EquipmentLibrary el = new EquipmentLibrary();

        DataClasses1DataContext db = new DataClasses1DataContext();

        private void Form1_Load(object sender, EventArgs e)
        {
            //kryptonDataGridView1.CellFormatting += kryptonDataGridView1_CellFormatting;
            kryptonDataGridView1.DataSource = db.sp_EquipmentViewBarcodePath("");
            metroGrid1.DataSource = db.sp_EquipmentViewBarcodePath("");
           


        }

        private void kryptonDataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.kryptonDataGridView1.Columns[e.ColumnIndex] is DataGridViewImageColumn)
            {
                string imagePath = (e.Value ?? "").ToString().Trim();

                if (imagePath != "")
                {
                    e.Value = Image.FromFile(imagePath);
                }
            }
        }

        private void metroGrid1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //if (metroGrid1.Columns[5].Name == "EQBarcodepath")
            //{
                

            //    e.Value = Image.FromFile(e.Value.ToString());
            //    e.FormattingApplied = true;
            //}
        }


        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {


            BarCode code128 = new BarCode();
            code128.Symbology = KeepAutomation.Barcode.Symbology.Code128Auto;
            code128.CodeToEncode = db.sp_EquipmentID().ToString();

            //Apply checksum for Code 128 barcode.
            code128.ChecksumEnabled = true;

            // Print Code 128 in specified image format like Png, Jpeg, Gif, Tiff, Bmp, etc.
            //code128.ImageFormat = ImageFormat.Png;

            // Display checksum in the Code 128 human-readable text
            code128.DisplayChecksum = true;

            // Set Code 128 image size

            // Code 128 unit of measure, Pixel, Cm and Inch supported.
            code128.BarcodeUnit = BarcodeUnit.Pixel;
            // Code 128 image resolution in DPI.
            code128.DPI = 72;
            // Code 128 bar module width (X dimention)
            code128.X = 3;
            // Code 128 bar module height (Y dimention)
            code128.Y = 60;
            // Image left margin size, a 10X is automatically added according to
            code128.LeftMargin = 0;
            // Image left margin size, a 10X is automatically added according to
            code128.RightMargin = 0;
            // Code 128 image top margin size
            code128.TopMargin = 0;
            // Code 128 image bottom margin size
            code128.BottomMargin = 0;
            // Code 128 image orientation, 0, 90, 180, 270 degrees supported.
            code128.Orientation = KeepAutomation.Barcode.Orientation.Degree0;

            // Set Code 128 human readable text

            // Display human readable text
            code128.DisplayText = true;
            code128.TextFont = new Font("Arial", 10f, FontStyle.Regular);
            // Space between barcode and text beneath.
            code128.TextMargin = 6;
            //Generate Code 93 barcodes in image PNG format



            
            code128.generateBarcodeToImageFile(Application.StartupPath + @"\barcodes\"+db.sp_EquipmentID().ToString()+".png");


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
