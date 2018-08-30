namespace ANS_SEIS_TV
{
    partial class AccountRecovery
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
            this.label6 = new System.Windows.Forms.Label();
            this.txtUsername = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.drpQuestion = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.txtSecurityAnswer = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnSubmit = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.drpQuestion)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(79, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 19);
            this.label6.TabIndex = 3;
            this.label6.Text = "Username :";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(170, 76);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(226, 23);
            this.txtUsername.TabIndex = 1;
            // 
            // drpQuestion
            // 
            this.drpQuestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpQuestion.DropDownWidth = 224;
            this.drpQuestion.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Ribbon;
            this.drpQuestion.Items.AddRange(new object[] {
            "In what city were you born?",
            "What high school did you attend?",
            "What is the first and last name of your first boyfriend or girlfriend?",
            "What is the name of your favorite pet?",
            "What is the name of your first grade teacher?",
            "What is the name of your first school?",
            "What is your father\'s middle name?",
            "What is your favorite color?",
            "what is your favorite forum",
            "What is your favorite movie?",
            "what is your favorite online platform",
            "what is your favorite social media website",
            "what is your favorite website",
            "What is your mother\'s maiden name?",
            "What street did you grow up on?",
            "What was the make of your first car?",
            "What was your favorite place to visit as a child?",
            "What was your high school mascot?",
            "When is your anniversary?",
            "Which is your favorite web browser?",
            "Which phone number do you remember most from your childhood?",
            "Who is your favorite actor, musician, or artist?"});
            this.drpQuestion.Location = new System.Drawing.Point(170, 105);
            this.drpQuestion.Name = "drpQuestion";
            this.drpQuestion.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.drpQuestion.Size = new System.Drawing.Size(226, 21);
            this.drpQuestion.TabIndex = 2;
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.BackColor = System.Drawing.SystemColors.Window;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel12.Location = new System.Drawing.Point(29, 105);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(135, 19);
            this.materialLabel12.TabIndex = 11;
            this.materialLabel12.Text = "Security Question :";
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.BackColor = System.Drawing.SystemColors.Window;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel13.Location = new System.Drawing.Point(39, 135);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(125, 19);
            this.materialLabel13.TabIndex = 12;
            this.materialLabel13.Text = "Security Answer :";
            // 
            // txtSecurityAnswer
            // 
            this.txtSecurityAnswer.Location = new System.Drawing.Point(170, 135);
            this.txtSecurityAnswer.Name = "txtSecurityAnswer";
            this.txtSecurityAnswer.Size = new System.Drawing.Size(226, 23);
            this.txtSecurityAnswer.TabIndex = 3;
            // 
            // btnSubmit
            // 
            this.btnSubmit.AutoSize = true;
            this.btnSubmit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSubmit.Depth = 0;
            this.btnSubmit.Icon = null;
            this.btnSubmit.Location = new System.Drawing.Point(325, 164);
            this.btnSubmit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Primary = true;
            this.btnSubmit.Size = new System.Drawing.Size(71, 36);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // AccountRecovery
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 221);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.drpQuestion);
            this.Controls.Add(this.materialLabel12);
            this.Controls.Add(this.materialLabel13);
            this.Controls.Add(this.txtSecurityAnswer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtUsername);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "AccountRecovery";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Account Recovery";
            this.Load += new System.EventHandler(this.AccountRecovery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.drpQuestion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtUsername;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox drpQuestion;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtSecurityAnswer;
        private MaterialSkin.Controls.MaterialRaisedButton btnSubmit;
    }
}