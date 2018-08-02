namespace ANS_SEIS_TV
{
    partial class RequestForm
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
            this.dgvRequest = new System.Windows.Forms.DataGridView();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.kryptonRadioButton2 = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.kryptonRadioButton1 = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.kryptonRadioButton3 = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.kryptonRadioButton4 = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequest)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRequest
            // 
            this.dgvRequest.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequest.Location = new System.Drawing.Point(27, 124);
            this.dgvRequest.Name = "dgvRequest";
            this.dgvRequest.Size = new System.Drawing.Size(1057, 467);
            this.dgvRequest.TabIndex = 0;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.BackColor = System.Drawing.Color.SlateGray;
            this.bunifuCustomLabel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Roboto Condensed", 13F);
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(27, 92);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(100, 26);
            this.bunifuCustomLabel5.TabIndex = 41;
            this.bunifuCustomLabel5.Text = "Request List";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.kryptonRadioButton4);
            this.groupBox1.Controls.Add(this.kryptonRadioButton3);
            this.groupBox1.Controls.Add(this.kryptonRadioButton2);
            this.groupBox1.Controls.Add(this.kryptonRadioButton1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(768, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 44);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            // 
            // kryptonRadioButton2
            // 
            this.kryptonRadioButton2.Location = new System.Drawing.Point(163, 14);
            this.kryptonRadioButton2.Name = "kryptonRadioButton2";
            this.kryptonRadioButton2.Size = new System.Drawing.Size(73, 24);
            this.kryptonRadioButton2.StateCommon.ShortText.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonRadioButton2.TabIndex = 34;
            this.kryptonRadioButton2.Values.Text = "Pending";
            // 
            // kryptonRadioButton1
            // 
            this.kryptonRadioButton1.Location = new System.Drawing.Point(35, 14);
            this.kryptonRadioButton1.Name = "kryptonRadioButton1";
            this.kryptonRadioButton1.Size = new System.Drawing.Size(39, 24);
            this.kryptonRadioButton1.StateCommon.ShortText.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonRadioButton1.TabIndex = 33;
            this.kryptonRadioButton1.Values.Text = "All";
            // 
            // kryptonRadioButton3
            // 
            this.kryptonRadioButton3.Location = new System.Drawing.Point(242, 14);
            this.kryptonRadioButton3.Name = "kryptonRadioButton3";
            this.kryptonRadioButton3.Size = new System.Drawing.Size(64, 24);
            this.kryptonRadioButton3.StateCommon.ShortText.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonRadioButton3.TabIndex = 35;
            this.kryptonRadioButton3.Values.Text = "Closed";
            // 
            // kryptonRadioButton4
            // 
            this.kryptonRadioButton4.Location = new System.Drawing.Point(90, 14);
            this.kryptonRadioButton4.Name = "kryptonRadioButton4";
            this.kryptonRadioButton4.Size = new System.Drawing.Size(54, 24);
            this.kryptonRadioButton4.StateCommon.ShortText.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonRadioButton4.TabIndex = 36;
            this.kryptonRadioButton4.Values.Text = "Open";
            // 
            // RequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 614);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.dgvRequest);
            this.Name = "RequestForm";
            this.Text = "Request Form";
            this.Load += new System.EventHandler(this.RequestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequest)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRequest;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private System.Windows.Forms.GroupBox groupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton kryptonRadioButton4;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton kryptonRadioButton3;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton kryptonRadioButton2;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton kryptonRadioButton1;
    }
}