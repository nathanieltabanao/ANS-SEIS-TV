namespace ANS_SEIS_TV
{
    partial class RequestReply
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
            this.txtReply = new MetroFramework.Controls.MetroTextBox();
            this.btnReply = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // txtReply
            // 
            // 
            // 
            // 
            this.txtReply.CustomButton.Image = null;
            this.txtReply.CustomButton.Location = new System.Drawing.Point(426, 1);
            this.txtReply.CustomButton.Name = "";
            this.txtReply.CustomButton.Size = new System.Drawing.Size(327, 327);
            this.txtReply.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtReply.CustomButton.TabIndex = 1;
            this.txtReply.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtReply.CustomButton.UseSelectable = true;
            this.txtReply.CustomButton.Visible = false;
            this.txtReply.Lines = new string[0];
            this.txtReply.Location = new System.Drawing.Point(23, 63);
            this.txtReply.MaxLength = 32767;
            this.txtReply.Multiline = true;
            this.txtReply.Name = "txtReply";
            this.txtReply.PasswordChar = '\0';
            this.txtReply.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtReply.SelectedText = "";
            this.txtReply.SelectionLength = 0;
            this.txtReply.SelectionStart = 0;
            this.txtReply.ShortcutsEnabled = true;
            this.txtReply.Size = new System.Drawing.Size(754, 329);
            this.txtReply.TabIndex = 0;
            this.txtReply.UseSelectable = true;
            this.txtReply.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtReply.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnReply
            // 
            this.btnReply.AutoSize = true;
            this.btnReply.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReply.Depth = 0;
            this.btnReply.Icon = null;
            this.btnReply.Location = new System.Drawing.Point(721, 398);
            this.btnReply.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReply.Name = "btnReply";
            this.btnReply.Primary = true;
            this.btnReply.Size = new System.Drawing.Size(56, 36);
            this.btnReply.TabIndex = 1;
            this.btnReply.Text = "Send";
            this.btnReply.UseVisualStyleBackColor = true;
            this.btnReply.Click += new System.EventHandler(this.btnReply_Click);
            // 
            // RequestReply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackLocation = MetroFramework.Forms.BackLocation.TopLeft;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReply);
            this.Controls.Add(this.txtReply);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "RequestReply";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "Request Reply";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtReply;
        private MaterialSkin.Controls.MaterialRaisedButton btnReply;
    }
}