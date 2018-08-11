namespace ANS_SEIS_TV
{
    partial class AdminRequestReply
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblRequestStatus = new System.Windows.Forms.Label();
            this.lblDateRequested = new System.Windows.Forms.Label();
            this.lblDateReplied = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAdminReply = new System.Windows.Forms.TextBox();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRequestID
            // 
            this.lblRequestID.AutoSize = true;
            this.lblRequestID.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequestID.Location = new System.Drawing.Point(61, 69);
            this.lblRequestID.Name = "lblRequestID";
            this.lblRequestID.Size = new System.Drawing.Size(88, 21);
            this.lblRequestID.TabIndex = 0;
            this.lblRequestID.Text = "Request ID:";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(22, 176);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(127, 21);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Request Subject :";
            // 
            // lblRequestStatus
            // 
            this.lblRequestStatus.AutoSize = true;
            this.lblRequestStatus.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequestStatus.Location = new System.Drawing.Point(383, 69);
            this.lblRequestStatus.Name = "lblRequestStatus";
            this.lblRequestStatus.Size = new System.Drawing.Size(118, 21);
            this.lblRequestStatus.TabIndex = 2;
            this.lblRequestStatus.Text = "Request Status :";
            // 
            // lblDateRequested
            // 
            this.lblDateRequested.AutoSize = true;
            this.lblDateRequested.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateRequested.Location = new System.Drawing.Point(23, 105);
            this.lblDateRequested.Name = "lblDateRequested";
            this.lblDateRequested.Size = new System.Drawing.Size(126, 21);
            this.lblDateRequested.TabIndex = 3;
            this.lblDateRequested.Text = "Date Requested :";
            // 
            // lblDateReplied
            // 
            this.lblDateReplied.AutoSize = true;
            this.lblDateReplied.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateReplied.Location = new System.Drawing.Point(396, 105);
            this.lblDateReplied.Name = "lblDateReplied";
            this.lblDateReplied.Size = new System.Drawing.Size(105, 21);
            this.lblDateReplied.TabIndex = 4;
            this.lblDateReplied.Text = "Date Replied :";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Segoe UI Semilight", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.Location = new System.Drawing.Point(75, 197);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(33, 20);
            this.lblSubject.TabIndex = 5;
            this.lblSubject.Text = "Re :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Admin\'s Reply :";
            // 
            // txtAdminReply
            // 
            this.txtAdminReply.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtAdminReply.Location = new System.Drawing.Point(27, 256);
            this.txtAdminReply.Multiline = true;
            this.txtAdminReply.Name = "txtAdminReply";
            this.txtAdminReply.ReadOnly = true;
            this.txtAdminReply.Size = new System.Drawing.Size(798, 333);
            this.txtAdminReply.TabIndex = 7;
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.Location = new System.Drawing.Point(42, 141);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(107, 21);
            this.lblAdmin.TabIndex = 8;
            this.lblAdmin.Text = "Processed By :";
            // 
            // AdminRequestReply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 612);
            this.Controls.Add(this.lblAdmin);
            this.Controls.Add(this.txtAdminReply);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblDateReplied);
            this.Controls.Add(this.lblDateRequested);
            this.Controls.Add(this.lblRequestStatus);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lblRequestID);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "AdminRequestReply";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Reply from the Admin";
            this.Load += new System.EventHandler(this.AdminRequestReply_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRequestID;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblRequestStatus;
        private System.Windows.Forms.Label lblDateRequested;
        private System.Windows.Forms.Label lblDateReplied;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAdminReply;
        private System.Windows.Forms.Label lblAdmin;
    }
}