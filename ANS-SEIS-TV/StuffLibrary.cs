using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KeepAutomation.Barcode.Bean;
using KeepAutomation.Barcode;
using KeepAutomation;
using System.IO;

namespace ANS_SEIS_TV
{
    class StuffLibrary
    {
        DataClasses1DataContext db = new DataClasses1DataContext();

        public string SavePath;

        public void GenerateBarcode(string ToBarode)
        {
            BarCode code128 = new BarCode();
            code128.Symbology = KeepAutomation.Barcode.Symbology.Code128Auto;
            code128.CodeToEncode = ToBarode;

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

            //Generate the barcode
            SavePath = Application.StartupPath + @"\barcodes\" + ToBarode + ".png";

            code128.generateBarcodeToImageFile(SavePath);
        }
        
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }
    }
}
