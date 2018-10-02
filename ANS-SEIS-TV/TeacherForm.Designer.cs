namespace ANS_SEIS_TV
{
    partial class TeacherForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.materialTabSelector2 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl2 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.materialTabSelector3 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl3 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage16 = new System.Windows.Forms.TabPage();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.rdoDenied = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.rdoOpenRequest = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.rdoApproved = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.rdoPendingRequest = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.rdoAllRequest = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.btnNewRequest = new MaterialSkin.Controls.MaterialRaisedButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblCurrentUser = new System.Windows.Forms.Label();
            this.btnLogout = new MaterialSkin.Controls.MaterialFlatButton();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnRefresh = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dgvRequest = new MetroFramework.Controls.MetroGrid();
            this.dgvBorrowed = new MetroFramework.Controls.MetroGrid();
            this.dgvDeployed = new MetroFramework.Controls.MetroGrid();
            this.aNS_SEIS_TVDataSet7 = new ANS_SEIS_TV.ANS_SEIS_TVDataSet7();
            this.spDeploymentViewTeacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_DeploymentViewTeacherTableAdapter = new ANS_SEIS_TV.ANS_SEIS_TVDataSet7TableAdapters.sp_DeploymentViewTeacherTableAdapter();
            this.materialTabControl2.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.materialTabControl3.SuspendLayout();
            this.tabPage16.SuspendLayout();
            this.tabPage11.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeployed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNS_SEIS_TVDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDeploymentViewTeacherBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabSelector2
            // 
            this.materialTabSelector2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector2.BaseTabControl = this.materialTabControl2;
            this.materialTabSelector2.Depth = 0;
            this.materialTabSelector2.Location = new System.Drawing.Point(-3, 59);
            this.materialTabSelector2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector2.Name = "materialTabSelector2";
            this.materialTabSelector2.Size = new System.Drawing.Size(1162, 48);
            this.materialTabSelector2.TabIndex = 25;
            this.materialTabSelector2.Text = "materialTabSelector1";
            // 
            // materialTabControl2
            // 
            this.materialTabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabControl2.Controls.Add(this.tabPage8);
            this.materialTabControl2.Depth = 0;
            this.materialTabControl2.Location = new System.Drawing.Point(-3, 109);
            this.materialTabControl2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl2.Name = "materialTabControl2";
            this.materialTabControl2.SelectedIndex = 0;
            this.materialTabControl2.Size = new System.Drawing.Size(1162, 632);
            this.materialTabControl2.TabIndex = 26;
            // 
            // tabPage8
            // 
            this.tabPage8.BackColor = System.Drawing.Color.White;
            this.tabPage8.Controls.Add(this.materialTabSelector3);
            this.tabPage8.Controls.Add(this.materialTabControl3);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(1154, 606);
            this.tabPage8.TabIndex = 1;
            this.tabPage8.Text = "Inventory";
            // 
            // materialTabSelector3
            // 
            this.materialTabSelector3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector3.BaseTabControl = this.materialTabControl3;
            this.materialTabSelector3.Depth = 0;
            this.materialTabSelector3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.materialTabSelector3.Location = new System.Drawing.Point(-19, -11);
            this.materialTabSelector3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector3.Name = "materialTabSelector3";
            this.materialTabSelector3.Size = new System.Drawing.Size(1191, 48);
            this.materialTabSelector3.TabIndex = 23;
            this.materialTabSelector3.Text = "materialTabSelector1";
            // 
            // materialTabControl3
            // 
            this.materialTabControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabControl3.Controls.Add(this.tabPage16);
            this.materialTabControl3.Controls.Add(this.tabPage11);
            this.materialTabControl3.Controls.Add(this.tabPage1);
            this.materialTabControl3.Depth = 0;
            this.materialTabControl3.Location = new System.Drawing.Point(0, 37);
            this.materialTabControl3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl3.Name = "materialTabControl3";
            this.materialTabControl3.SelectedIndex = 0;
            this.materialTabControl3.Size = new System.Drawing.Size(1162, 573);
            this.materialTabControl3.TabIndex = 24;
            // 
            // tabPage16
            // 
            this.tabPage16.BackColor = System.Drawing.Color.White;
            this.tabPage16.Controls.Add(this.dgvBorrowed);
            this.tabPage16.Controls.Add(this.bunifuCustomLabel2);
            this.tabPage16.Location = new System.Drawing.Point(4, 22);
            this.tabPage16.Name = "tabPage16";
            this.tabPage16.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage16.Size = new System.Drawing.Size(1154, 547);
            this.tabPage16.TabIndex = 2;
            this.tabPage16.Text = "Borrowed";
            // 
            // tabPage11
            // 
            this.tabPage11.Controls.Add(this.dgvRequest);
            this.tabPage11.Controls.Add(this.groupBox6);
            this.tabPage11.Controls.Add(this.btnNewRequest);
            this.tabPage11.Controls.Add(this.bunifuCustomLabel1);
            this.tabPage11.Location = new System.Drawing.Point(4, 22);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage11.Size = new System.Drawing.Size(1154, 547);
            this.tabPage11.TabIndex = 7;
            this.tabPage11.Text = "Requests";
            this.tabPage11.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.White;
            this.groupBox6.Controls.Add(this.rdoDenied);
            this.groupBox6.Controls.Add(this.rdoOpenRequest);
            this.groupBox6.Controls.Add(this.rdoApproved);
            this.groupBox6.Controls.Add(this.rdoPendingRequest);
            this.groupBox6.Controls.Add(this.rdoAllRequest);
            this.groupBox6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(777, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(357, 44);
            this.groupBox6.TabIndex = 48;
            this.groupBox6.TabStop = false;
            // 
            // rdoDenied
            // 
            this.rdoDenied.Location = new System.Drawing.Point(289, 14);
            this.rdoDenied.Name = "rdoDenied";
            this.rdoDenied.Size = new System.Drawing.Size(65, 24);
            this.rdoDenied.StateCommon.ShortText.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoDenied.TabIndex = 37;
            this.rdoDenied.Values.Text = "Denied";
            this.rdoDenied.CheckedChanged += new System.EventHandler(this.rdoDenied_CheckedChanged_1);
            // 
            // rdoOpenRequest
            // 
            this.rdoOpenRequest.Location = new System.Drawing.Point(63, 14);
            this.rdoOpenRequest.Name = "rdoOpenRequest";
            this.rdoOpenRequest.Size = new System.Drawing.Size(54, 24);
            this.rdoOpenRequest.StateCommon.ShortText.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoOpenRequest.TabIndex = 36;
            this.rdoOpenRequest.Values.Text = "Open";
            this.rdoOpenRequest.CheckedChanged += new System.EventHandler(this.rdoOpenRequest_CheckedChanged_1);
            // 
            // rdoApproved
            // 
            this.rdoApproved.Location = new System.Drawing.Point(202, 14);
            this.rdoApproved.Name = "rdoApproved";
            this.rdoApproved.Size = new System.Drawing.Size(81, 24);
            this.rdoApproved.StateCommon.ShortText.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoApproved.TabIndex = 35;
            this.rdoApproved.Values.Text = "Approved";
            this.rdoApproved.CheckedChanged += new System.EventHandler(this.rdoApproved_CheckedChanged);
            // 
            // rdoPendingRequest
            // 
            this.rdoPendingRequest.Location = new System.Drawing.Point(123, 14);
            this.rdoPendingRequest.Name = "rdoPendingRequest";
            this.rdoPendingRequest.Size = new System.Drawing.Size(73, 24);
            this.rdoPendingRequest.StateCommon.ShortText.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoPendingRequest.TabIndex = 34;
            this.rdoPendingRequest.Values.Text = "Pending";
            this.rdoPendingRequest.CheckedChanged += new System.EventHandler(this.rdoPendingRequest_CheckedChanged_1);
            // 
            // rdoAllRequest
            // 
            this.rdoAllRequest.Location = new System.Drawing.Point(8, 14);
            this.rdoAllRequest.Name = "rdoAllRequest";
            this.rdoAllRequest.Size = new System.Drawing.Size(39, 24);
            this.rdoAllRequest.StateCommon.ShortText.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoAllRequest.TabIndex = 33;
            this.rdoAllRequest.Values.Text = "All";
            this.rdoAllRequest.CheckedChanged += new System.EventHandler(this.rdoAllRequest_CheckedChanged_1);
            // 
            // btnNewRequest
            // 
            this.btnNewRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewRequest.AutoSize = true;
            this.btnNewRequest.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNewRequest.Depth = 0;
            this.btnNewRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewRequest.Icon = null;
            this.btnNewRequest.Location = new System.Drawing.Point(1027, 497);
            this.btnNewRequest.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNewRequest.Name = "btnNewRequest";
            this.btnNewRequest.Primary = true;
            this.btnNewRequest.Size = new System.Drawing.Size(113, 36);
            this.btnNewRequest.TabIndex = 47;
            this.btnNewRequest.Text = "New Request";
            this.btnNewRequest.UseVisualStyleBackColor = true;
            this.btnNewRequest.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.SlateGray;
            this.bunifuCustomLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Roboto Condensed", 13F);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(8, 15);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(100, 26);
            this.bunifuCustomLabel1.TabIndex = 44;
            this.bunifuCustomLabel1.Text = "Request List";
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentUser.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCurrentUser.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentUser.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCurrentUser.Location = new System.Drawing.Point(712, 35);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(351, 29);
            this.lblCurrentUser.TabIndex = 28;
            this.lblCurrentUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.AutoSize = true;
            this.btnLogout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogout.Depth = 0;
            this.btnLogout.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLogout.Icon = null;
            this.btnLogout.Location = new System.Drawing.Point(1070, 32);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLogout.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Primary = false;
            this.btnLogout.Size = new System.Drawing.Size(74, 36);
            this.btnLogout.TabIndex = 27;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click_1);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvDeployed);
            this.tabPage1.Controls.Add(this.bunifuCustomLabel3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1154, 547);
            this.tabPage1.TabIndex = 8;
            this.tabPage1.Text = "Deployed";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.SlateGray;
            this.bunifuCustomLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Roboto Condensed", 13F);
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(7, 18);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(227, 26);
            this.bunifuCustomLabel2.TabIndex = 45;
            this.bunifuCustomLabel2.Text = "Current Borrowed Equipments";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.SlateGray;
            this.bunifuCustomLabel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Roboto Condensed", 13F);
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(9, 16);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(223, 26);
            this.bunifuCustomLabel3.TabIndex = 47;
            this.bunifuCustomLabel3.Text = "Current Deployed Equipments";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(12, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btnRefresh.Size = new System.Drawing.Size(90, 34);
            this.btnRefresh.TabIndex = 29;
            this.btnRefresh.Values.Text = "Refresh Tables";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgvRequest
            // 
            this.dgvRequest.AllowUserToAddRows = false;
            this.dgvRequest.AllowUserToDeleteRows = false;
            this.dgvRequest.AllowUserToResizeRows = false;
            this.dgvRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRequest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRequest.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRequest.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvRequest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRequest.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvRequest.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRequest.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Semilight", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRequest.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvRequest.EnableHeadersVisualStyles = false;
            this.dgvRequest.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvRequest.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvRequest.Location = new System.Drawing.Point(8, 53);
            this.dgvRequest.MultiSelect = false;
            this.dgvRequest.Name = "dgvRequest";
            this.dgvRequest.ReadOnly = true;
            this.dgvRequest.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRequest.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvRequest.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvRequest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRequest.Size = new System.Drawing.Size(1132, 438);
            this.dgvRequest.TabIndex = 49;
            // 
            // dgvBorrowed
            // 
            this.dgvBorrowed.AllowUserToAddRows = false;
            this.dgvBorrowed.AllowUserToDeleteRows = false;
            this.dgvBorrowed.AllowUserToOrderColumns = true;
            this.dgvBorrowed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBorrowed.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvBorrowed.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBorrowed.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvBorrowed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBorrowed.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvBorrowed.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBorrowed.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvBorrowed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI Semilight", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBorrowed.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvBorrowed.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvBorrowed.EnableHeadersVisualStyles = false;
            this.dgvBorrowed.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvBorrowed.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvBorrowed.Location = new System.Drawing.Point(7, 47);
            this.dgvBorrowed.MultiSelect = false;
            this.dgvBorrowed.Name = "dgvBorrowed";
            this.dgvBorrowed.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBorrowed.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvBorrowed.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvBorrowed.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBorrowed.Size = new System.Drawing.Size(1137, 486);
            this.dgvBorrowed.TabIndex = 46;
            // 
            // dgvDeployed
            // 
            this.dgvDeployed.AllowUserToAddRows = false;
            this.dgvDeployed.AllowUserToDeleteRows = false;
            this.dgvDeployed.AllowUserToResizeRows = false;
            this.dgvDeployed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDeployed.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDeployed.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDeployed.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvDeployed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDeployed.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDeployed.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDeployed.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvDeployed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI Semilight", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDeployed.DefaultCellStyle = dataGridViewCellStyle17;
            this.dgvDeployed.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDeployed.EnableHeadersVisualStyles = false;
            this.dgvDeployed.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvDeployed.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvDeployed.Location = new System.Drawing.Point(6, 45);
            this.dgvDeployed.MultiSelect = false;
            this.dgvDeployed.Name = "dgvDeployed";
            this.dgvDeployed.ReadOnly = true;
            this.dgvDeployed.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDeployed.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvDeployed.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvDeployed.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvDeployed.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDeployed.Size = new System.Drawing.Size(1138, 506);
            this.dgvDeployed.TabIndex = 48;
            // 
            // aNS_SEIS_TVDataSet7
            // 
            this.aNS_SEIS_TVDataSet7.DataSetName = "ANS_SEIS_TVDataSet7";
            this.aNS_SEIS_TVDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spDeploymentViewTeacherBindingSource
            // 
            this.spDeploymentViewTeacherBindingSource.DataMember = "sp_DeploymentViewTeacher";
            this.spDeploymentViewTeacherBindingSource.DataSource = this.aNS_SEIS_TVDataSet7;
            // 
            // sp_DeploymentViewTeacherTableAdapter
            // 
            this.sp_DeploymentViewTeacherTableAdapter.ClearBeforeFill = true;
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 735);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblCurrentUser);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.materialTabSelector2);
            this.Controls.Add(this.materialTabControl2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TeacherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.TeacherForm_Load);
            this.materialTabControl2.ResumeLayout(false);
            this.tabPage8.ResumeLayout(false);
            this.materialTabControl3.ResumeLayout(false);
            this.tabPage16.ResumeLayout(false);
            this.tabPage16.PerformLayout();
            this.tabPage11.ResumeLayout(false);
            this.tabPage11.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeployed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNS_SEIS_TVDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDeploymentViewTeacherBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector2;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl2;
        private System.Windows.Forms.TabPage tabPage8;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector3;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl3;
        private System.Windows.Forms.TabPage tabPage16;
        private System.Windows.Forms.TabPage tabPage11;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton btnNewRequest;
        private System.Windows.Forms.Label lblCurrentUser;
        private MaterialSkin.Controls.MaterialFlatButton btnLogout;
        private System.Windows.Forms.GroupBox groupBox6;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rdoDenied;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rdoOpenRequest;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rdoApproved;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rdoPendingRequest;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rdoAllRequest;
        private System.Windows.Forms.TabPage tabPage1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnRefresh;
        private MetroFramework.Controls.MetroGrid dgvRequest;
        private MetroFramework.Controls.MetroGrid dgvBorrowed;
        private MetroFramework.Controls.MetroGrid dgvDeployed;
        private System.Windows.Forms.BindingSource spDeploymentViewTeacherBindingSource;
        private ANS_SEIS_TVDataSet7 aNS_SEIS_TVDataSet7;
        private ANS_SEIS_TVDataSet7TableAdapters.sp_DeploymentViewTeacherTableAdapter sp_DeploymentViewTeacherTableAdapter;
    }
}