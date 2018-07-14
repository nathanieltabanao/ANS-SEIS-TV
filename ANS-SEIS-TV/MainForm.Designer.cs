namespace ANS_SEIS_TV
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monitoringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowAndReturnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageAccountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pullOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deploymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.AliceBlue;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrationToolStripMenuItem,
            this.inventoryToolStripMenuItem,
            this.monitoringToolStripMenuItem,
            this.activitiesToolStripMenuItem,
            this.borrowAndReturnToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.manageAccountsToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.menuStrip1.Location = new System.Drawing.Point(9, 64);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(184, 423);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrationToolStripMenuItem
            // 
            this.registrationToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.registrationToolStripMenuItem.Name = "registrationToolStripMenuItem";
            this.registrationToolStripMenuItem.Size = new System.Drawing.Size(118, 29);
            this.registrationToolStripMenuItem.Text = "Registration";
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(99, 29);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            // 
            // monitoringToolStripMenuItem
            // 
            this.monitoringToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.monitoringToolStripMenuItem.Name = "monitoringToolStripMenuItem";
            this.monitoringToolStripMenuItem.Size = new System.Drawing.Size(113, 29);
            this.monitoringToolStripMenuItem.Text = "Monitoring";
            // 
            // activitiesToolStripMenuItem
            // 
            this.activitiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.requestToolStripMenuItem,
            this.pullOutToolStripMenuItem,
            this.deploymentToolStripMenuItem});
            this.activitiesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.activitiesToolStripMenuItem.Name = "activitiesToolStripMenuItem";
            this.activitiesToolStripMenuItem.Size = new System.Drawing.Size(141, 29);
            this.activitiesToolStripMenuItem.Text = "More Activities";
            // 
            // borrowAndReturnToolStripMenuItem
            // 
            this.borrowAndReturnToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.borrowAndReturnToolStripMenuItem.Name = "borrowAndReturnToolStripMenuItem";
            this.borrowAndReturnToolStripMenuItem.Size = new System.Drawing.Size(172, 29);
            this.borrowAndReturnToolStripMenuItem.Text = "Borrow and Return";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(85, 29);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // manageAccountsToolStripMenuItem
            // 
            this.manageAccountsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.manageAccountsToolStripMenuItem.Name = "manageAccountsToolStripMenuItem";
            this.manageAccountsToolStripMenuItem.Size = new System.Drawing.Size(166, 29);
            this.manageAccountsToolStripMenuItem.Text = "Manage Accounts";
            // 
            // requestToolStripMenuItem
            // 
            this.requestToolStripMenuItem.Name = "requestToolStripMenuItem";
            this.requestToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.requestToolStripMenuItem.Text = "Request";
            // 
            // pullOutToolStripMenuItem
            // 
            this.pullOutToolStripMenuItem.Name = "pullOutToolStripMenuItem";
            this.pullOutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pullOutToolStripMenuItem.Text = "Pull Out";
            // 
            // deploymentToolStripMenuItem
            // 
            this.deploymentToolStripMenuItem.Name = "deploymentToolStripMenuItem";
            this.deploymentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deploymentToolStripMenuItem.Text = "Deployment";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 488);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Equipment Inventory System";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monitoringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrowAndReturnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem requestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pullOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deploymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageAccountsToolStripMenuItem;
    }
}