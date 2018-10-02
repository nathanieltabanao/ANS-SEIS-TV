namespace ANS_SEIS_TV
{
    partial class FinalizePullOut
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
            this.components = new System.ComponentModel.Container();
            this.dgvPullOutFinal = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Returned = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PullOutQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aNS_SEIS_TVDataSet6 = new ANS_SEIS_TV.ANS_SEIS_TVDataSet6();
            this.spViewDeployedEquipmentsTransactionIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_ViewDeployedEquipmentsTransactionIDTableAdapter = new ANS_SEIS_TV.ANS_SEIS_TVDataSet6TableAdapters.sp_ViewDeployedEquipmentsTransactionIDTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTransactionID = new System.Windows.Forms.Label();
            this.lblProcessedBy = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTeacherName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTransactionDate = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTransactionType = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblRoomNumber = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSubmitPullOut = new MaterialSkin.Controls.MaterialRaisedButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPullOutFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNS_SEIS_TVDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spViewDeployedEquipmentsTransactionIDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPullOutFinal
            // 
            this.dgvPullOutFinal.AllowUserToAddRows = false;
            this.dgvPullOutFinal.AllowUserToDeleteRows = false;
            this.dgvPullOutFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPullOutFinal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPullOutFinal.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPullOutFinal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPullOutFinal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Name,
            this.Quantity,
            this.Returned,
            this.PullOutQty});
            this.dgvPullOutFinal.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvPullOutFinal.Location = new System.Drawing.Point(23, 211);
            this.dgvPullOutFinal.MultiSelect = false;
            this.dgvPullOutFinal.Name = "dgvPullOutFinal";
            this.dgvPullOutFinal.Size = new System.Drawing.Size(920, 392);
            this.dgvPullOutFinal.TabIndex = 72;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 47;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            this.Name.Width = 68;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 82;
            // 
            // Returned
            // 
            this.Returned.HeaderText = "Returned?";
            this.Returned.Name = "Returned";
            this.Returned.Width = 70;
            // 
            // PullOutQty
            // 
            this.PullOutQty.HeaderText = "Quantity To Pull Out";
            this.PullOutQty.MaxInputLength = 4;
            this.PullOutQty.Name = "PullOutQty";
            this.PullOutQty.Width = 114;
            // 
            // aNS_SEIS_TVDataSet6
            // 
            this.aNS_SEIS_TVDataSet6.DataSetName = "ANS_SEIS_TVDataSet6";
            this.aNS_SEIS_TVDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spViewDeployedEquipmentsTransactionIDBindingSource
            // 
            this.spViewDeployedEquipmentsTransactionIDBindingSource.DataMember = "sp_ViewDeployedEquipmentsTransactionID";
            this.spViewDeployedEquipmentsTransactionIDBindingSource.DataSource = this.aNS_SEIS_TVDataSet6;
            // 
            // sp_ViewDeployedEquipmentsTransactionIDTableAdapter
            // 
            this.sp_ViewDeployedEquipmentsTransactionIDTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 73;
            this.label1.Text = "Transaction ID :";
            // 
            // lblTransactionID
            // 
            this.lblTransactionID.AutoSize = true;
            this.lblTransactionID.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionID.Location = new System.Drawing.Point(179, 80);
            this.lblTransactionID.Name = "lblTransactionID";
            this.lblTransactionID.Size = new System.Drawing.Size(0, 20);
            this.lblTransactionID.TabIndex = 74;
            // 
            // lblProcessedBy
            // 
            this.lblProcessedBy.AutoSize = true;
            this.lblProcessedBy.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcessedBy.Location = new System.Drawing.Point(179, 115);
            this.lblProcessedBy.Name = "lblProcessedBy";
            this.lblProcessedBy.Size = new System.Drawing.Size(0, 20);
            this.lblProcessedBy.TabIndex = 76;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 75;
            this.label4.Text = "Processed By :";
            // 
            // lblTeacherName
            // 
            this.lblTeacherName.AutoSize = true;
            this.lblTeacherName.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeacherName.Location = new System.Drawing.Point(523, 115);
            this.lblTeacherName.Name = "lblTeacherName";
            this.lblTeacherName.Size = new System.Drawing.Size(0, 20);
            this.lblTeacherName.TabIndex = 78;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(378, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 20);
            this.label6.TabIndex = 77;
            this.label6.Text = "Teacher Name :";
            // 
            // lblTransactionDate
            // 
            this.lblTransactionDate.AutoSize = true;
            this.lblTransactionDate.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionDate.Location = new System.Drawing.Point(523, 80);
            this.lblTransactionDate.Name = "lblTransactionDate";
            this.lblTransactionDate.Size = new System.Drawing.Size(0, 20);
            this.lblTransactionDate.TabIndex = 80;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(378, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 20);
            this.label8.TabIndex = 79;
            this.label8.Text = "Transaction Date :";
            // 
            // lblTransactionType
            // 
            this.lblTransactionType.AutoSize = true;
            this.lblTransactionType.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionType.Location = new System.Drawing.Point(179, 152);
            this.lblTransactionType.Name = "lblTransactionType";
            this.lblTransactionType.Size = new System.Drawing.Size(0, 20);
            this.lblTransactionType.TabIndex = 82;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(34, 152);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 20);
            this.label10.TabIndex = 81;
            this.label10.Text = "Transaction Type :";
            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.AutoSize = true;
            this.lblRoomNumber.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomNumber.Location = new System.Drawing.Point(523, 152);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.Size = new System.Drawing.Size(0, 20);
            this.lblRoomNumber.TabIndex = 84;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(378, 152);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 20);
            this.label12.TabIndex = 83;
            this.label12.Text = "Room No :";
            // 
            // btnSubmitPullOut
            // 
            this.btnSubmitPullOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmitPullOut.AutoSize = true;
            this.btnSubmitPullOut.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSubmitPullOut.Depth = 0;
            this.btnSubmitPullOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitPullOut.Icon = null;
            this.btnSubmitPullOut.Location = new System.Drawing.Point(862, 609);
            this.btnSubmitPullOut.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSubmitPullOut.Name = "btnSubmitPullOut";
            this.btnSubmitPullOut.Primary = true;
            this.btnSubmitPullOut.Size = new System.Drawing.Size(81, 36);
            this.btnSubmitPullOut.TabIndex = 85;
            this.btnSubmitPullOut.Text = "Confirm";
            this.btnSubmitPullOut.UseVisualStyleBackColor = true;
            this.btnSubmitPullOut.Click += new System.EventHandler(this.btnSubmitPullOut_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // FinalizePullOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 654);
            this.Controls.Add(this.btnSubmitPullOut);
            this.Controls.Add(this.lblRoomNumber);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblTransactionType);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblTransactionDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblTeacherName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblProcessedBy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTransactionID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPullOutFinal);
            this.Movable = false;
            //this.Name = "FinalizePullOut";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "Transaction Details";
            this.Load += new System.EventHandler(this.FinalizePullOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPullOutFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNS_SEIS_TVDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spViewDeployedEquipmentsTransactionIDBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource spViewDeployedEquipmentsTransactionIDBindingSource;
        private ANS_SEIS_TVDataSet6 aNS_SEIS_TVDataSet6;
        private ANS_SEIS_TVDataSet6TableAdapters.sp_ViewDeployedEquipmentsTransactionIDTableAdapter sp_ViewDeployedEquipmentsTransactionIDTableAdapter;
        internal ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvPullOutFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTransactionID;
        private System.Windows.Forms.Label lblProcessedBy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTeacherName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTransactionDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTransactionType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblRoomNumber;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Returned;
        private System.Windows.Forms.DataGridViewTextBoxColumn PullOutQty;
        private MaterialSkin.Controls.MaterialRaisedButton btnSubmitPullOut;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}