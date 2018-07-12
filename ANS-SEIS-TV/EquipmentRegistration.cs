using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace ANS_SEIS_TV
{
    public partial class EquipmentRegistration : MaterialForm
    {
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSearch;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvView;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtID;
        private GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtFirstName;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtMiddleName;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox kryptonComboBox2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox kryptonComboBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnClear;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDelete;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnInsert;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnEdit;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;

        public EquipmentRegistration()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtSearch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dgvView = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtID = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtFirstName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.txtMiddleName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.kryptonComboBox1 = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonComboBox2 = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.btnClear = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnDelete = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnInsert = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnEdit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Depth = 0;
            this.txtSearch.Hint = "";
            this.txtSearch.Location = new System.Drawing.Point(877, 74);
            this.txtSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.Size = new System.Drawing.Size(299, 23);
            this.txtSearch.TabIndex = 31;
            this.txtSearch.UseSystemPasswordChar = false;
            // 
            // dgvView
            // 
            this.dgvView.AllowUserToAddRows = false;
            this.dgvView.AllowUserToDeleteRows = false;
            this.dgvView.AllowUserToOrderColumns = true;
            this.dgvView.AllowUserToResizeColumns = false;
            this.dgvView.AllowUserToResizeRows = false;
            this.dgvView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvView.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvView.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvView.Location = new System.Drawing.Point(427, 103);
            this.dgvView.Name = "dgvView";
            this.dgvView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvView.Size = new System.Drawing.Size(749, 479);
            this.dgvView.TabIndex = 30;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.SystemColors.Window;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(808, 74);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(63, 18);
            this.bunifuCustomLabel2.TabIndex = 29;
            this.bunifuCustomLabel2.Text = "Search :";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(12, 85);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(66, 20);
            this.bunifuCustomLabel1.TabIndex = 33;
            this.bunifuCustomLabel1.Text = "Barcode";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(163, 85);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(252, 23);
            this.txtID.TabIndex = 32;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.kryptonComboBox2);
            this.groupBox2.Controls.Add(this.bunifuCustomLabel3);
            this.groupBox2.Controls.Add(this.txtFirstName);
            this.groupBox2.Controls.Add(this.materialLabel5);
            this.groupBox2.Controls.Add(this.materialLabel6);
            this.groupBox2.Controls.Add(this.txtMiddleName);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.groupBox2.Location = new System.Drawing.Point(12, 155);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(409, 154);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Equipment Details";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(64, 38);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(81, 18);
            this.bunifuCustomLabel3.TabIndex = 24;
            this.bunifuCustomLabel3.Text = "Item name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(151, 38);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(252, 23);
            this.txtFirstName.TabIndex = 2;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(40, 67);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(106, 19);
            this.materialLabel5.TabIndex = 8;
            this.materialLabel5.Text = "Manufacturer :";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(52, 98);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(93, 19);
            this.materialLabel6.TabIndex = 9;
            this.materialLabel6.Text = "Designation:";
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Location = new System.Drawing.Point(151, 67);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(252, 23);
            this.txtMiddleName.TabIndex = 3;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(12, 119);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(120, 20);
            this.bunifuCustomLabel4.TabIndex = 35;
            this.bunifuCustomLabel4.Text = "Equipment type";
            // 
            // kryptonComboBox1
            // 
            this.kryptonComboBox1.DropDownWidth = 252;
            this.kryptonComboBox1.Location = new System.Drawing.Point(163, 117);
            this.kryptonComboBox1.Name = "kryptonComboBox1";
            this.kryptonComboBox1.Size = new System.Drawing.Size(252, 21);
            this.kryptonComboBox1.TabIndex = 36;
            // 
            // kryptonComboBox2
            // 
            this.kryptonComboBox2.DropDownWidth = 252;
            this.kryptonComboBox2.Location = new System.Drawing.Point(151, 98);
            this.kryptonComboBox2.Name = "kryptonComboBox2";
            this.kryptonComboBox2.Size = new System.Drawing.Size(252, 21);
            this.kryptonComboBox2.TabIndex = 37;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(16, 548);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 34);
            this.btnClear.TabIndex = 40;
            this.btnClear.Values.Text = "Clear";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(112, 548);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 34);
            this.btnDelete.TabIndex = 39;
            this.btnDelete.Values.Text = "Delete";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(304, 548);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(90, 34);
            this.btnInsert.TabIndex = 38;
            this.btnInsert.Values.Text = "Add";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(208, 548);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(90, 34);
            this.btnEdit.TabIndex = 37;
            this.btnEdit.Values.Text = "Edit";
            // 
            // EquipmentRegistration
            // 
            this.ClientSize = new System.Drawing.Size(1188, 628);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.kryptonComboBox1);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvView);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Name = "EquipmentRegistration";
            this.Text = "Equipment Registration";
            this.Load += new System.EventHandler(this.EquipmentRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void EquipmentRegistration_Load(object sender, EventArgs e)
        {

        }
    }
}
