namespace ANS_SEIS_TV
{
    partial class RequestInformation
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
            this.lblRequestID = new System.Windows.Forms.Label();
            this.lblRequestName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRequestMessage = new MetroFramework.Controls.MetroTextBox();
            this.btnReply = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblDateRequested = new System.Windows.Forms.Label();
            this.lblRequestStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRequestSubject = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // lblRequestID
            // 
            this.lblRequestID.AutoSize = true;
            this.lblRequestID.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequestID.Location = new System.Drawing.Point(23, 78);
            this.lblRequestID.Name = "lblRequestID";
            this.lblRequestID.Size = new System.Drawing.Size(92, 20);
            this.lblRequestID.TabIndex = 0;
            this.lblRequestID.Text = "Request ID :";
            // 
            // lblRequestName
            // 
            this.lblRequestName.AutoSize = true;
            this.lblRequestName.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequestName.Location = new System.Drawing.Point(23, 115);
            this.lblRequestName.Name = "lblRequestName";
            this.lblRequestName.Size = new System.Drawing.Size(113, 20);
            this.lblRequestName.TabIndex = 1;
            this.lblRequestName.Text = "Requested By :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Message :";
            // 
            // txtRequestMessage
            // 
            // 
            // 
            // 
            this.txtRequestMessage.CustomButton.Image = null;
            this.txtRequestMessage.CustomButton.Location = new System.Drawing.Point(511, 1);
            this.txtRequestMessage.CustomButton.Name = "";
            this.txtRequestMessage.CustomButton.Size = new System.Drawing.Size(241, 241);
            this.txtRequestMessage.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRequestMessage.CustomButton.TabIndex = 1;
            this.txtRequestMessage.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRequestMessage.CustomButton.UseSelectable = true;
            this.txtRequestMessage.CustomButton.Visible = false;
            this.txtRequestMessage.Enabled = false;
            this.txtRequestMessage.Lines = new string[0];
            this.txtRequestMessage.Location = new System.Drawing.Point(27, 242);
            this.txtRequestMessage.MaxLength = 32767;
            this.txtRequestMessage.Multiline = true;
            this.txtRequestMessage.Name = "txtRequestMessage";
            this.txtRequestMessage.PasswordChar = '\0';
            this.txtRequestMessage.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRequestMessage.SelectedText = "";
            this.txtRequestMessage.SelectionLength = 0;
            this.txtRequestMessage.SelectionStart = 0;
            this.txtRequestMessage.ShortcutsEnabled = true;
            this.txtRequestMessage.Size = new System.Drawing.Size(753, 243);
            this.txtRequestMessage.TabIndex = 3;
            this.txtRequestMessage.UseSelectable = true;
            this.txtRequestMessage.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRequestMessage.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnReply
            // 
            this.btnReply.AutoSize = true;
            this.btnReply.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReply.Depth = 0;
            this.btnReply.Icon = null;
            this.btnReply.Location = new System.Drawing.Point(714, 491);
            this.btnReply.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReply.Name = "btnReply";
            this.btnReply.Primary = true;
            this.btnReply.Size = new System.Drawing.Size(62, 36);
            this.btnReply.TabIndex = 5;
            this.btnReply.Text = "Reply";
            this.btnReply.UseVisualStyleBackColor = true;
            this.btnReply.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // lblDateRequested
            // 
            this.lblDateRequested.AutoSize = true;
            this.lblDateRequested.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateRequested.Location = new System.Drawing.Point(437, 78);
            this.lblDateRequested.Name = "lblDateRequested";
            this.lblDateRequested.Size = new System.Drawing.Size(127, 20);
            this.lblDateRequested.TabIndex = 6;
            this.lblDateRequested.Text = "Date Requested :";
            // 
            // lblRequestStatus
            // 
            this.lblRequestStatus.AutoSize = true;
            this.lblRequestStatus.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequestStatus.Location = new System.Drawing.Point(441, 115);
            this.lblRequestStatus.Name = "lblRequestStatus";
            this.lblRequestStatus.Size = new System.Drawing.Size(123, 20);
            this.lblRequestStatus.TabIndex = 7;
            this.lblRequestStatus.Text = "Request Status :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Subject :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtRequestSubject
            // 
            // 
            // 
            // 
            this.txtRequestSubject.CustomButton.Image = null;
            this.txtRequestSubject.CustomButton.Location = new System.Drawing.Point(731, 1);
            this.txtRequestSubject.CustomButton.Name = "";
            this.txtRequestSubject.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRequestSubject.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRequestSubject.CustomButton.TabIndex = 1;
            this.txtRequestSubject.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRequestSubject.CustomButton.UseSelectable = true;
            this.txtRequestSubject.CustomButton.Visible = false;
            this.txtRequestSubject.Enabled = false;
            this.txtRequestSubject.Lines = new string[0];
            this.txtRequestSubject.Location = new System.Drawing.Point(23, 182);
            this.txtRequestSubject.MaxLength = 32767;
            this.txtRequestSubject.Name = "txtRequestSubject";
            this.txtRequestSubject.PasswordChar = '\0';
            this.txtRequestSubject.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRequestSubject.SelectedText = "";
            this.txtRequestSubject.SelectionLength = 0;
            this.txtRequestSubject.SelectionStart = 0;
            this.txtRequestSubject.ShortcutsEnabled = true;
            this.txtRequestSubject.Size = new System.Drawing.Size(753, 23);
            this.txtRequestSubject.TabIndex = 9;
            this.txtRequestSubject.UseSelectable = true;
            this.txtRequestSubject.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRequestSubject.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // RequestInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackLocation = MetroFramework.Forms.BackLocation.TopLeft;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.None;
            this.ClientSize = new System.Drawing.Size(786, 533);
            this.Controls.Add(this.txtRequestSubject);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRequestStatus);
            this.Controls.Add(this.lblDateRequested);
            this.Controls.Add(this.btnReply);
            this.Controls.Add(this.txtRequestMessage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRequestName);
            this.Controls.Add(this.lblRequestID);
            this.Movable = false;
            this.Name = "RequestInformation";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Request Information";
            this.Load += new System.EventHandler(this.RequestInformation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRequestID;
        private System.Windows.Forms.Label lblRequestName;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTextBox txtRequestMessage;
        private MaterialSkin.Controls.MaterialRaisedButton btnReply;
        private System.Windows.Forms.Label lblDateRequested;
        private System.Windows.Forms.Label lblRequestStatus;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox txtRequestSubject;
    }
}