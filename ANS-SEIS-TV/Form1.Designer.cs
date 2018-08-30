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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.kryptonDataGridView1 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.spEquipmentViewBarcodePathBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aNS_SEIS_TVDataSet3 = new ANS_SEIS_TV.ANS_SEIS_TVDataSet3();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.aNS_SEIS_TVDataSet = new ANS_SEIS_TV.ANS_SEIS_TVDataSet();
            this.aNSSEISTVDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aNS_SEIS_TVDataSet1 = new ANS_SEIS_TV.ANS_SEIS_TVDataSet1();
            this.spEquipmentViewBarcodeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_EquipmentViewBarcodeTableAdapter = new ANS_SEIS_TV.ANS_SEIS_TVDataSet1TableAdapters.sp_EquipmentViewBarcodeTableAdapter();
            this.aNS_SEIS_TVDataSet2 = new ANS_SEIS_TV.ANS_SEIS_TVDataSet2();
            this.spEquipmentViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_EquipmentViewTableAdapter = new ANS_SEIS_TV.ANS_SEIS_TVDataSet2TableAdapters.sp_EquipmentViewTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sp_EquipmentViewBarcodePathTableAdapter = new ANS_SEIS_TV.ANS_SEIS_TVDataSet3TableAdapters.sp_EquipmentViewBarcodePathTableAdapter();
            this.equipmentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EQBarcodepath = new System.Windows.Forms.DataGridViewImageColumn();
            this.image = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spEquipmentViewBarcodePathBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNS_SEIS_TVDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNS_SEIS_TVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNSSEISTVDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNS_SEIS_TVDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spEquipmentViewBarcodeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNS_SEIS_TVDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spEquipmentViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // kryptonDataGridView1
            // 
            this.kryptonDataGridView1.AllowUserToAddRows = false;
            this.kryptonDataGridView1.AllowUserToDeleteRows = false;
            this.kryptonDataGridView1.AutoGenerateColumns = false;
            this.kryptonDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.kryptonDataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.kryptonDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kryptonDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.equipmentIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.EQBarcodepath,
            this.image});
            this.kryptonDataGridView1.DataSource = this.spEquipmentViewBarcodePathBindingSource;
            this.kryptonDataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonDataGridView1.Location = new System.Drawing.Point(0, 0);
            this.kryptonDataGridView1.Name = "kryptonDataGridView1";
            this.kryptonDataGridView1.ReadOnly = true;
            this.kryptonDataGridView1.Size = new System.Drawing.Size(1578, 314);
            this.kryptonDataGridView1.TabIndex = 4;
            this.kryptonDataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.kryptonDataGridView1_CellFormatting);
            // 
            // spEquipmentViewBarcodePathBindingSource
            // 
            this.spEquipmentViewBarcodePathBindingSource.DataMember = "sp_EquipmentViewBarcodePath";
            this.spEquipmentViewBarcodePathBindingSource.DataSource = this.aNS_SEIS_TVDataSet3;
            // 
            // aNS_SEIS_TVDataSet3
            // 
            this.aNS_SEIS_TVDataSet3.DataSetName = "ANS_SEIS_TVDataSet3";
            this.aNS_SEIS_TVDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(0, 452);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(1578, 289);
            this.metroGrid1.TabIndex = 5;
            this.metroGrid1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.metroGrid1_CellFormatting);
            // 
            // aNS_SEIS_TVDataSet
            // 
            this.aNS_SEIS_TVDataSet.DataSetName = "ANS_SEIS_TVDataSet";
            this.aNS_SEIS_TVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aNSSEISTVDataSetBindingSource
            // 
            this.aNSSEISTVDataSetBindingSource.DataSource = this.aNS_SEIS_TVDataSet;
            this.aNSSEISTVDataSetBindingSource.Position = 0;
            // 
            // aNS_SEIS_TVDataSet1
            // 
            this.aNS_SEIS_TVDataSet1.DataSetName = "ANS_SEIS_TVDataSet1";
            this.aNS_SEIS_TVDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spEquipmentViewBarcodeBindingSource
            // 
            this.spEquipmentViewBarcodeBindingSource.DataMember = "sp_EquipmentViewBarcode";
            this.spEquipmentViewBarcodeBindingSource.DataSource = this.aNS_SEIS_TVDataSet1;
            // 
            // sp_EquipmentViewBarcodeTableAdapter
            // 
            this.sp_EquipmentViewBarcodeTableAdapter.ClearBeforeFill = true;
            // 
            // aNS_SEIS_TVDataSet2
            // 
            this.aNS_SEIS_TVDataSet2.DataSetName = "ANS_SEIS_TVDataSet2";
            this.aNS_SEIS_TVDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spEquipmentViewBindingSource
            // 
            this.spEquipmentViewBindingSource.DataMember = "sp_EquipmentView";
            this.spEquipmentViewBindingSource.DataSource = this.aNS_SEIS_TVDataSet2;
            // 
            // sp_EquipmentViewTableAdapter
            // 
            this.sp_EquipmentViewTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(392, 320);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(547, 107);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // sp_EquipmentViewBarcodePathTableAdapter
            // 
            this.sp_EquipmentViewBarcodePathTableAdapter.ClearBeforeFill = true;
            // 
            // equipmentIDDataGridViewTextBoxColumn
            // 
            this.equipmentIDDataGridViewTextBoxColumn.DataPropertyName = "Equipment ID";
            this.equipmentIDDataGridViewTextBoxColumn.HeaderText = "Equipment ID";
            this.equipmentIDDataGridViewTextBoxColumn.Name = "equipmentIDDataGridViewTextBoxColumn";
            this.equipmentIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.equipmentIDDataGridViewTextBoxColumn.Width = 108;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 68;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 96;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeDataGridViewTextBoxColumn.Width = 61;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantityDataGridViewTextBoxColumn.Width = 82;
            // 
            // EQBarcodepath
            // 
            this.EQBarcodepath.DataPropertyName = "EQBarcodepath";
            this.EQBarcodepath.HeaderText = "EQBarcodepath";
            this.EQBarcodepath.Name = "EQBarcodepath";
            this.EQBarcodepath.ReadOnly = true;
            this.EQBarcodepath.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EQBarcodepath.Width = 99;
            // 
            // image
            // 
            this.image.HeaderText = "image";
            this.image.Name = "image";
            this.image.ReadOnly = true;
            this.image.Width = 50;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1578, 741);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.kryptonDataGridView1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spEquipmentViewBarcodePathBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNS_SEIS_TVDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNS_SEIS_TVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNSSEISTVDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNS_SEIS_TVDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spEquipmentViewBarcodeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNS_SEIS_TVDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spEquipmentViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private ANS_SEIS_TVDataSet aNS_SEIS_TVDataSet;
        private System.Windows.Forms.BindingSource aNSSEISTVDataSetBindingSource;
        private System.Windows.Forms.BindingSource spEquipmentViewBarcodeBindingSource;
        private ANS_SEIS_TVDataSet1 aNS_SEIS_TVDataSet1;
        private ANS_SEIS_TVDataSet1TableAdapters.sp_EquipmentViewBarcodeTableAdapter sp_EquipmentViewBarcodeTableAdapter;
        private System.Windows.Forms.BindingSource spEquipmentViewBindingSource;
        private ANS_SEIS_TVDataSet2 aNS_SEIS_TVDataSet2;
        private ANS_SEIS_TVDataSet2TableAdapters.sp_EquipmentViewTableAdapter sp_EquipmentViewTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource spEquipmentViewBarcodePathBindingSource;
        private ANS_SEIS_TVDataSet3 aNS_SEIS_TVDataSet3;
        private ANS_SEIS_TVDataSet3TableAdapters.sp_EquipmentViewBarcodePathTableAdapter sp_EquipmentViewBarcodePathTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipmentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn EQBarcodepath;
        private System.Windows.Forms.DataGridViewImageColumn image;
    }
}

