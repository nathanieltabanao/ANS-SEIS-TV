namespace ANS_SEIS_TV
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.barCodeControl1 = new KeepAutomation.Barcode.Windows.BarCodeControl();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(842, 536);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // barCodeControl1
            // 
            this.barCodeControl1.ApplicationIndicator = 0;
            this.barCodeControl1.BarCodeHeight = 0F;
            this.barCodeControl1.BarcodeUnit = KeepAutomation.Barcode.BarcodeUnit.Pixel;
            this.barCodeControl1.BarCodeWidth = 0F;
            this.barCodeControl1.BearerBarLeft = 1F;
            this.barCodeControl1.BearerBarTop = 1F;
            this.barCodeControl1.BottomMargin = 0F;
            this.barCodeControl1.ChecksumEnabled = false;
            this.barCodeControl1.CodabarStartChar = KeepAutomation.Barcode.CodabarStartStopChar.A;
            this.barCodeControl1.CodabarStopChar = KeepAutomation.Barcode.CodabarStartStopChar.A;
            this.barCodeControl1.CodeToEncode = "128";
            this.barCodeControl1.DataMatrixDataMode = KeepAutomation.Barcode.DataMatrixDataMode.Auto;
            this.barCodeControl1.DataMatrixFormatMode = KeepAutomation.Barcode.DataMatrixFormatMode.FM_12X12;
            this.barCodeControl1.DisplayChecksum = true;
            this.barCodeControl1.DisplayStartStop = true;
            this.barCodeControl1.DisplayText = true;
            this.barCodeControl1.DPI = 72;
            this.barCodeControl1.FNC1 = KeepAutomation.Barcode.FNC1.None;
            this.barCodeControl1.GroupEnabled = false;
            this.barCodeControl1.GroupId = 0;
            this.barCodeControl1.GroupItemCount = 0;
            this.barCodeControl1.GroupItemId = 0;
            this.barCodeControl1.I = 1F;
            this.barCodeControl1.ImageFormat = System.Drawing.Imaging.ImageFormat.Png;
            this.barCodeControl1.LeftMargin = 0F;
            this.barCodeControl1.Location = new System.Drawing.Point(403, 132);
            this.barCodeControl1.Name = "barCodeControl1";
            this.barCodeControl1.Orientation = KeepAutomation.Barcode.Orientation.Degree0;
            this.barCodeControl1.PDF417ColumnCount = 5;
            this.barCodeControl1.PDF417DataMode = KeepAutomation.Barcode.PDF417DataMode.Text;
            this.barCodeControl1.PDF417ECL = KeepAutomation.Barcode.PDF417ECL.ECL_2;
            this.barCodeControl1.PDF417RowCount = 3;
            this.barCodeControl1.PDF417Truncated = false;
            this.barCodeControl1.PDF417XtoYRatio = 0.33333F;
            this.barCodeControl1.QRCodeDataMode = KeepAutomation.Barcode.QRCodeDataMode.Auto;
            this.barCodeControl1.QRCodeECI = 3;
            this.barCodeControl1.QRCodeECL = KeepAutomation.Barcode.QRCodeECL.L;
            this.barCodeControl1.QRCodeVersion = KeepAutomation.Barcode.QRCodeVersion.V1;
            this.barCodeControl1.RightMargin = 0F;
            this.barCodeControl1.ShortTallRatio = 0.4F;
            this.barCodeControl1.Size = new System.Drawing.Size(150, 150);
            this.barCodeControl1.SupplementCode = "";
            this.barCodeControl1.SupplementHeight = 0.8F;
            this.barCodeControl1.SupplementSpace = 15F;
            this.barCodeControl1.Symbology = KeepAutomation.Barcode.Symbology.EAN128;
            this.barCodeControl1.TabIndex = 2;
            this.barCodeControl1.TextFont = new System.Drawing.Font("Arial", 9F);
            this.barCodeControl1.TextMargin = 6F;
            this.barCodeControl1.TildeEnabled = false;
            this.barCodeControl1.TopMargin = 0F;
            this.barCodeControl1.WideNarrowRatio = 2F;
            this.barCodeControl1.X = 1F;
            this.barCodeControl1.Y = 50F;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Icon = null;
            this.materialFlatButton1.Location = new System.Drawing.Point(505, 404);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(181, 36);
            this.materialFlatButton1.TabIndex = 3;
            this.materialFlatButton1.Text = "materialFlatButton1";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 609);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.barCodeControl1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button1;
        private KeepAutomation.Barcode.Windows.BarCodeControl barCodeControl1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
    }
}

