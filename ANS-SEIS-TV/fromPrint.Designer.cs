namespace ANS_SEIS_TV
{
    partial class fromPrint
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
            this.crystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.BorrowSlip1 = new ANS_SEIS_TV.BorrowSlip();
            this.SuspendLayout();
            // 
            // crystalReportViewer
            // 
            this.crystalReportViewer.ActiveViewIndex = 0;
            this.crystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer.Location = new System.Drawing.Point(20, 60);
            this.crystalReportViewer.Name = "crystalReportViewer";
            this.crystalReportViewer.ReportSource = this.BorrowSlip1;
            this.crystalReportViewer.Size = new System.Drawing.Size(1085, 1020);
            this.crystalReportViewer.TabIndex = 0;
            this.crystalReportViewer.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // fromPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 1100);
            this.Controls.Add(this.crystalReportViewer);
            this.Name = "fromPrint";
            this.Text = "Print Details";
            this.Load += new System.EventHandler(this.fromPrint_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer;
        private BorrowSlip BorrowSlip1;
    }
}