namespace ANS_SEIS_TV
{
    partial class BorrowingForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtSearch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dgvEquipView = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnSearch = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dgvBorrowed = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.grpBoxBorrower = new System.Windows.Forms.GroupBox();
            this.kryptonTextBox1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonTextBox2 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnAddList = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnRmvList = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnClrList = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnPrintSlip = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowed)).BeginInit();
            this.grpBoxBorrower.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Depth = 0;
            this.txtSearch.Hint = "";
            this.txtSearch.Location = new System.Drawing.Point(21, 153);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.Size = new System.Drawing.Size(409, 23);
            this.txtSearch.TabIndex = 31;
            this.txtSearch.TabStop = false;
            this.txtSearch.UseSystemPasswordChar = false;
            // 
            // dgvEquipView
            // 
            this.dgvEquipView.AllowUserToAddRows = false;
            this.dgvEquipView.AllowUserToDeleteRows = false;
            this.dgvEquipView.AllowUserToOrderColumns = true;
            this.dgvEquipView.AllowUserToResizeColumns = false;
            this.dgvEquipView.AllowUserToResizeRows = false;
            this.dgvEquipView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEquipView.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvEquipView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEquipView.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEquipView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvEquipView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvEquipView.Location = new System.Drawing.Point(18, 244);
            this.dgvEquipView.Name = "dgvEquipView";
            this.dgvEquipView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvEquipView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEquipView.Size = new System.Drawing.Size(538, 346);
            this.dgvEquipView.TabIndex = 30;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.SystemColors.Window;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Roboto Condensed", 12F);
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(17, 128);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(124, 21);
            this.bunifuCustomLabel2.TabIndex = 29;
            this.bunifuCustomLabel2.Text = "Search Equipment";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(49, 38);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(72, 21);
            this.bunifuCustomLabel1.TabIndex = 32;
            this.bunifuCustomLabel1.Text = "Username";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(439, 38);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnSearch.Size = new System.Drawing.Size(74, 57);
            this.btnSearch.StateNormal.Back.Color1 = System.Drawing.Color.Silver;
            this.btnSearch.TabIndex = 34;
            this.btnSearch.Values.Text = "Search";
            // 
            // dgvBorrowed
            // 
            this.dgvBorrowed.AllowUserToAddRows = false;
            this.dgvBorrowed.AllowUserToDeleteRows = false;
            this.dgvBorrowed.AllowUserToOrderColumns = true;
            this.dgvBorrowed.AllowUserToResizeColumns = false;
            this.dgvBorrowed.AllowUserToResizeRows = false;
            this.dgvBorrowed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBorrowed.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvBorrowed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBorrowed.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBorrowed.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvBorrowed.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvBorrowed.Location = new System.Drawing.Point(562, 244);
            this.dgvBorrowed.Name = "dgvBorrowed";
            this.dgvBorrowed.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvBorrowed.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBorrowed.Size = new System.Drawing.Size(556, 346);
            this.dgvBorrowed.TabIndex = 35;
            // 
            // grpBoxBorrower
            // 
            this.grpBoxBorrower.BackColor = System.Drawing.Color.Transparent;
            this.grpBoxBorrower.Controls.Add(this.kryptonTextBox2);
            this.grpBoxBorrower.Controls.Add(this.bunifuCustomLabel3);
            this.grpBoxBorrower.Controls.Add(this.kryptonTextBox1);
            this.grpBoxBorrower.Controls.Add(this.btnSearch);
            this.grpBoxBorrower.Controls.Add(this.bunifuCustomLabel1);
            this.grpBoxBorrower.Font = new System.Drawing.Font("Roboto", 10F);
            this.grpBoxBorrower.Location = new System.Drawing.Point(562, 79);
            this.grpBoxBorrower.Name = "grpBoxBorrower";
            this.grpBoxBorrower.Size = new System.Drawing.Size(550, 121);
            this.grpBoxBorrower.TabIndex = 36;
            this.grpBoxBorrower.TabStop = false;
            this.grpBoxBorrower.Text = "Borrower Details";
            // 
            // kryptonTextBox1
            // 
            this.kryptonTextBox1.Location = new System.Drawing.Point(134, 38);
            this.kryptonTextBox1.Name = "kryptonTextBox1";
            this.kryptonTextBox1.Size = new System.Drawing.Size(279, 23);
            this.kryptonTextBox1.TabIndex = 37;
            // 
            // kryptonTextBox2
            // 
            this.kryptonTextBox2.Location = new System.Drawing.Point(134, 72);
            this.kryptonTextBox2.Name = "kryptonTextBox2";
            this.kryptonTextBox2.Size = new System.Drawing.Size(279, 23);
            this.kryptonTextBox2.TabIndex = 39;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.SystemColors.Window;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(75, 70);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(46, 21);
            this.bunifuCustomLabel3.TabIndex = 38;
            this.bunifuCustomLabel3.Text = "Name";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.BackColor = System.Drawing.SystemColors.Window;
            this.bunifuCustomLabel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Roboto Condensed", 13F);
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(562, 213);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(94, 26);
            this.bunifuCustomLabel4.TabIndex = 37;
            this.bunifuCustomLabel4.Text = "Borrow List";
            // 
            // btnAddList
            // 
            this.btnAddList.Location = new System.Drawing.Point(18, 599);
            this.btnAddList.Name = "btnAddList";
            this.btnAddList.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnAddList.Size = new System.Drawing.Size(90, 42);
            this.btnAddList.TabIndex = 38;
            this.btnAddList.Values.Text = "Add to List";
            // 
            // btnRmvList
            // 
            this.btnRmvList.Location = new System.Drawing.Point(563, 599);
            this.btnRmvList.Name = "btnRmvList";
            this.btnRmvList.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnRmvList.Size = new System.Drawing.Size(107, 42);
            this.btnRmvList.TabIndex = 39;
            this.btnRmvList.Values.Text = "Remove from List";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.BackColor = System.Drawing.SystemColors.Window;
            this.bunifuCustomLabel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Roboto Condensed", 13F);
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(18, 213);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(118, 26);
            this.bunifuCustomLabel5.TabIndex = 40;
            this.bunifuCustomLabel5.Text = "Equipment List";
            // 
            // btnClrList
            // 
            this.btnClrList.Location = new System.Drawing.Point(676, 599);
            this.btnClrList.Name = "btnClrList";
            this.btnClrList.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnClrList.Size = new System.Drawing.Size(107, 42);
            this.btnClrList.TabIndex = 41;
            this.btnClrList.Values.Text = "Clear List";
            // 
            // btnPrintSlip
            // 
            this.btnPrintSlip.Location = new System.Drawing.Point(969, 596);
            this.btnPrintSlip.Name = "btnPrintSlip";
            this.btnPrintSlip.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnPrintSlip.Size = new System.Drawing.Size(149, 45);
            this.btnPrintSlip.StateNormal.Back.Color1 = System.Drawing.Color.Silver;
            this.btnPrintSlip.StatePressed.Back.Color1 = System.Drawing.Color.Firebrick;
            this.btnPrintSlip.StatePressed.Back.Color2 = System.Drawing.Color.IndianRed;
            this.btnPrintSlip.TabIndex = 42;
            this.btnPrintSlip.Values.Text = "PRINT BORROW SLIP";
            // 
            // BorrowingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 653);
            this.Controls.Add(this.btnPrintSlip);
            this.Controls.Add(this.btnClrList);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.btnRmvList);
            this.Controls.Add(this.btnAddList);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.dgvBorrowed);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvEquipView);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.grpBoxBorrower);
            this.Name = "BorrowingForm";
            this.Text = "BorrowingForm";
            this.Load += new System.EventHandler(this.BorrowingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowed)).EndInit();
            this.grpBoxBorrower.ResumeLayout(false);
            this.grpBoxBorrower.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtSearch;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvEquipView;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSearch;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvBorrowed;
        private System.Windows.Forms.GroupBox grpBoxBorrower;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAddList;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnRmvList;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnClrList;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnPrintSlip;
    }
}