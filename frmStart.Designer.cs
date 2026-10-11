namespace StyleMii.Forms
{
    partial class frmStart
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
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.pbxGreyLineBack = new System.Windows.Forms.PictureBox();
            this.wiiButtonsExit = new OutfitGen.Classes.WiiButtons();
            this.wiiButtonsStart = new OutfitGen.Classes.WiiButtons();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGreyLineBack)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxLogo
            // 
            this.pbxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbxLogo.Image = global::StyleMii.Properties.Resources.BlueStyleMiiLogo;
            this.pbxLogo.Location = new System.Drawing.Point(222, 22);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(298, 136);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 7;
            this.pbxLogo.TabStop = false;
            // 
            // pbxGreyLineBack
            // 
            this.pbxGreyLineBack.Image = global::StyleMii.Properties.Resources.wiigreybarfix;
            this.pbxGreyLineBack.Location = new System.Drawing.Point(0, 299);
            this.pbxGreyLineBack.Name = "pbxGreyLineBack";
            this.pbxGreyLineBack.Size = new System.Drawing.Size(737, 116);
            this.pbxGreyLineBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxGreyLineBack.TabIndex = 4;
            this.pbxGreyLineBack.TabStop = false;
            // 
            // wiiButtonsExit
            // 
            this.wiiButtonsExit.BackColor = System.Drawing.Color.GhostWhite;
            this.wiiButtonsExit.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.wiiButtonsExit.BorderColor = System.Drawing.Color.DarkTurquoise;
            this.wiiButtonsExit.BorderRadius = 45;
            this.wiiButtonsExit.BorderSize = 2;
            this.wiiButtonsExit.FlatAppearance.BorderSize = 0;
            this.wiiButtonsExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wiiButtonsExit.Font = new System.Drawing.Font("Microsoft YaHei", 18F);
            this.wiiButtonsExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.wiiButtonsExit.Location = new System.Drawing.Point(142, 324);
            this.wiiButtonsExit.Name = "wiiButtonsExit";
            this.wiiButtonsExit.Size = new System.Drawing.Size(213, 59);
            this.wiiButtonsExit.TabIndex = 6;
            this.wiiButtonsExit.Text = "Exit";
            this.wiiButtonsExit.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.wiiButtonsExit.UseVisualStyleBackColor = false;
            this.wiiButtonsExit.Click += new System.EventHandler(this.wiiButtonsExit_Click);
            // 
            // wiiButtonsStart
            // 
            this.wiiButtonsStart.BackColor = System.Drawing.Color.GhostWhite;
            this.wiiButtonsStart.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.wiiButtonsStart.BorderColor = System.Drawing.Color.DarkTurquoise;
            this.wiiButtonsStart.BorderRadius = 45;
            this.wiiButtonsStart.BorderSize = 2;
            this.wiiButtonsStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.wiiButtonsStart.FlatAppearance.BorderSize = 0;
            this.wiiButtonsStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wiiButtonsStart.Font = new System.Drawing.Font("Microsoft YaHei", 18F);
            this.wiiButtonsStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.wiiButtonsStart.Location = new System.Drawing.Point(384, 324);
            this.wiiButtonsStart.Name = "wiiButtonsStart";
            this.wiiButtonsStart.Size = new System.Drawing.Size(213, 59);
            this.wiiButtonsStart.TabIndex = 5;
            this.wiiButtonsStart.Text = "Start";
            this.wiiButtonsStart.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.wiiButtonsStart.UseVisualStyleBackColor = false;
            this.wiiButtonsStart.Click += new System.EventHandler(this.wiiButtonsStart_Click);
            // 
            // frmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StyleMii.Properties.Resources.StyleMiiBackground;
            this.ClientSize = new System.Drawing.Size(721, 405);
            this.Controls.Add(this.pbxLogo);
            this.Controls.Add(this.wiiButtonsExit);
            this.Controls.Add(this.wiiButtonsStart);
            this.Controls.Add(this.pbxGreyLineBack);
            this.Name = "frmStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmStart";
            this.Load += new System.EventHandler(this.frmStart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGreyLineBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxGreyLineBack;
        private OutfitGen.Classes.WiiButtons wiiButtonsExit;
        private OutfitGen.Classes.WiiButtons wiiButtonsStart;
        private System.Windows.Forms.PictureBox pbxLogo;
    }
}