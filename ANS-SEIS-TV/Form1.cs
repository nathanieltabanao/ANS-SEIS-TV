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

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            
            BarCode code93 = new BarCode();

            //Set barcode symbology type to Code 93              
            code93.Symbology = Symbology.Code93;

            //Set Code 93 valid input: All ASCII characters, including 0-9, A-Z, a-z, special 
            
           code93.CodeToEncode = el.EquipmentID().ToString();

            //Set Code 93 image size

            code93.BarcodeUnit = BarcodeUnit.Pixel;    // Unit of measure, Pixel, Cm and Inch supported. 
            code93.DPI = 72;                           // Code 93 image resolution in DPI.
            code93.X = 3;                              // Code 93 bar module width (X dimention)
            code93.Y = 60;                             // Code 93 bar module height (Y dimention)
            code93.LeftMargin = 0;                 // Image left margin size, minimum value is 10X.
            code93.RightMargin = 0;                    // Image right margin size, minimum value is 10X.
            code93.TopMargin = 0;                  // Code 93 image top margin size
            code93.BottomMargin = 0;               // Code 93 image bottom margin size
            code93.Orientation =KeepAutomation.Barcode.Orientation.Degree0;  // Orientation, 90, 180, 270 degrees supported

            //Set Code 93 human readable text style

            code93.DisplayText = true;                 // Display human readable text
            code93.TextFont = new Font("Arial", 10f, FontStyle.Regular);
            code93.TextMargin = 6;                     // Space between barcode and text

            //Generate Code 93 barcodes in image GIF format
            code93.generateBarcodeToImageFile(@"C: \Users\Nathaniel Angelico\Desktop\barcode.png");
            
        }
    }
}
