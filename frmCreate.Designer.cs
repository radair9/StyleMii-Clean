namespace StyleMii.Forms
{
    partial class frmCreate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreate));
            this.pnlSideBar = new System.Windows.Forms.Panel();
            this.wiiButtonsSettings = new OutfitGen.Classes.WiiButtons();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.wiiButtonsCreate = new OutfitGen.Classes.WiiButtons();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.lblNoFits = new System.Windows.Forms.Label();
            this.pbxSortSearch = new System.Windows.Forms.PictureBox();
            this.pnlPopUp = new System.Windows.Forms.Panel();
            this.MXP = new AxWMPLib.AxWindowsMediaPlayer();
            this.pbxClose = new System.Windows.Forms.PictureBox();
            this.lblPnlDesc = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblHowCreate = new System.Windows.Forms.Label();
            this.wiiButtonsScratch = new OutfitGen.Classes.WiiButtons();
            this.pnlSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSortSearch)).BeginInit();
            this.pnlPopUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MXP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSideBar
            // 
            this.pnlSideBar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlSideBar.Controls.Add(this.wiiButtonsSettings);
            this.pnlSideBar.Controls.Add(this.pbxLogo);
            this.pnlSideBar.Controls.Add(this.wiiButtonsCreate);
            this.pnlSideBar.Location = new System.Drawing.Point(-14, 0);
            this.pnlSideBar.Name = "pnlSideBar";
            this.pnlSideBar.Size = new System.Drawing.Size(187, 411);
            this.pnlSideBar.TabIndex = 0;
            // 
            // wiiButtonsSettings
            // 
            this.wiiButtonsSettings.BackColor = System.Drawing.Color.GhostWhite;
            this.wiiButtonsSettings.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.wiiButtonsSettings.BorderColor = System.Drawing.Color.DarkTurquoise;
            this.wiiButtonsSettings.BorderRadius = 45;
            this.wiiButtonsSettings.BorderSize = 2;
            this.wiiButtonsSettings.FlatAppearance.BorderSize = 2;
            this.wiiButtonsSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wiiButtonsSettings.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.wiiButtonsSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.wiiButtonsSettings.Location = new System.Drawing.Point(36, 154);
            this.wiiButtonsSettings.Name = "wiiButtonsSettings";
            this.wiiButtonsSettings.Size = new System.Drawing.Size(127, 52);
            this.wiiButtonsSettings.TabIndex = 4;
            this.wiiButtonsSettings.Text = "Settings";
            this.wiiButtonsSettings.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.wiiButtonsSettings.UseVisualStyleBackColor = false;
            this.wiiButtonsSettings.Click += new System.EventHandler(this.wiiButtonsSettings_Click);
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = global::StyleMii.Properties.Resources.BlueStyleMiiLogo;
            this.pbxLogo.Location = new System.Drawing.Point(26, 321);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(148, 72);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 3;
            this.pbxLogo.TabStop = false;
            // 
            // wiiButtonsCreate
            // 
            this.wiiButtonsCreate.BackColor = System.Drawing.Color.GhostWhite;
            this.wiiButtonsCreate.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.wiiButtonsCreate.BorderColor = System.Drawing.Color.DarkTurquoise;
            this.wiiButtonsCreate.BorderRadius = 45;
            this.wiiButtonsCreate.BorderSize = 2;
            this.wiiButtonsCreate.FlatAppearance.BorderSize = 2;
            this.wiiButtonsCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wiiButtonsCreate.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.wiiButtonsCreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.wiiButtonsCreate.Location = new System.Drawing.Point(36, 81);
            this.wiiButtonsCreate.Name = "wiiButtonsCreate";
            this.wiiButtonsCreate.Size = new System.Drawing.Size(127, 52);
            this.wiiButtonsCreate.TabIndex = 0;
            this.wiiButtonsCreate.Text = "Create Outfit";
            this.wiiButtonsCreate.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.wiiButtonsCreate.UseVisualStyleBackColor = false;
            this.wiiButtonsCreate.Click += new System.EventHandler(this.wiiButtonsCreate_Click);
            // 
            // tbxSearch
            // 
            this.tbxSearch.Font = new System.Drawing.Font("Microsoft YaHei", 18F);
            this.tbxSearch.Location = new System.Drawing.Point(359, 24);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(313, 39);
            this.tbxSearch.TabIndex = 0;
            // 
            // lblNoFits
            // 
            this.lblNoFits.AutoSize = true;
            this.lblNoFits.Font = new System.Drawing.Font("Microsoft YaHei", 15F);
            this.lblNoFits.Location = new System.Drawing.Point(214, 93);
            this.lblNoFits.Name = "lblNoFits";
            this.lblNoFits.Size = new System.Drawing.Size(468, 27);
            this.lblNoFits.TabIndex = 1;
            this.lblNoFits.Text = "You don\'t have any saved outfits. Start creating!";
            // 
            // pbxSortSearch
            // 
            this.pbxSortSearch.Image = global::StyleMii.Properties.Resources.BlueStyleMiiLogo;
            this.pbxSortSearch.Location = new System.Drawing.Point(255, 24);
            this.pbxSortSearch.Name = "pbxSortSearch";
            this.pbxSortSearch.Size = new System.Drawing.Size(53, 50);
            this.pbxSortSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxSortSearch.TabIndex = 2;
            this.pbxSortSearch.TabStop = false;
            // 
            // pnlPopUp
            // 
            this.pnlPopUp.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlPopUp.Controls.Add(this.MXP);
            this.pnlPopUp.Controls.Add(this.pbxClose);
            this.pnlPopUp.Controls.Add(this.lblPnlDesc);
            this.pnlPopUp.Controls.Add(this.pictureBox2);
            this.pnlPopUp.Controls.Add(this.lblHowCreate);
            this.pnlPopUp.Controls.Add(this.wiiButtonsScratch);
            this.pnlPopUp.Location = new System.Drawing.Point(219, 145);
            this.pnlPopUp.Name = "pnlPopUp";
            this.pnlPopUp.Size = new System.Drawing.Size(427, 214);
            this.pnlPopUp.TabIndex = 3;
            // 
            // MXP
            // 
            this.MXP.Enabled = true;
            this.MXP.Location = new System.Drawing.Point(74, 81);
            this.MXP.Name = "MXP";
            this.MXP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MXP.OcxState")));
            this.MXP.Size = new System.Drawing.Size(291, 46);
            this.MXP.TabIndex = 9;
            this.MXP.Enter += new System.EventHandler(this.MXP_Enter);
            // 
            // pbxClose
            // 
            this.pbxClose.Image = global::StyleMii.Properties.Resources.BlueStyleMiiLogo;
            this.pbxClose.Location = new System.Drawing.Point(394, 3);
            this.pbxClose.Name = "pbxClose";
            this.pbxClose.Size = new System.Drawing.Size(30, 30);
            this.pbxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxClose.TabIndex = 6;
            this.pbxClose.TabStop = false;
            this.pbxClose.Click += new System.EventHandler(this.pbxClose_Click);
            // 
            // lblPnlDesc
            // 
            this.lblPnlDesc.AutoSize = true;
            this.lblPnlDesc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblPnlDesc.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.lblPnlDesc.Location = new System.Drawing.Point(160, 10);
            this.lblPnlDesc.Name = "lblPnlDesc";
            this.lblPnlDesc.Size = new System.Drawing.Size(114, 20);
            this.lblPnlDesc.TabIndex = 5;
            this.lblPnlDesc.Text = "Create an outfit\r\n";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(427, 39);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // lblHowCreate
            // 
            this.lblHowCreate.AutoSize = true;
            this.lblHowCreate.Font = new System.Drawing.Font("Microsoft YaHei", 13F);
            this.lblHowCreate.Location = new System.Drawing.Point(136, 42);
            this.lblHowCreate.Name = "lblHowCreate";
            this.lblHowCreate.Size = new System.Drawing.Size(155, 48);
            this.lblHowCreate.TabIndex = 3;
            this.lblHowCreate.Text = "Analyse an outfit\r\n\r\n";
            // 
            // wiiButtonsScratch
            // 
            this.wiiButtonsScratch.BackColor = System.Drawing.Color.GhostWhite;
            this.wiiButtonsScratch.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.wiiButtonsScratch.BorderColor = System.Drawing.Color.DarkTurquoise;
            this.wiiButtonsScratch.BorderRadius = 45;
            this.wiiButtonsScratch.BorderSize = 2;
            this.wiiButtonsScratch.FlatAppearance.BorderSize = 2;
            this.wiiButtonsScratch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wiiButtonsScratch.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.wiiButtonsScratch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.wiiButtonsScratch.Location = new System.Drawing.Point(147, 93);
            this.wiiButtonsScratch.Name = "wiiButtonsScratch";
            this.wiiButtonsScratch.Size = new System.Drawing.Size(127, 52);
            this.wiiButtonsScratch.TabIndex = 1;
            this.wiiButtonsScratch.Text = "From Scratch";
            this.wiiButtonsScratch.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.wiiButtonsScratch.UseVisualStyleBackColor = false;
            this.wiiButtonsScratch.Click += new System.EventHandler(this.wiiButtonsScratch_Click);
            // 
            // frmCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(721, 405);
            this.Controls.Add(this.pnlPopUp);
            this.Controls.Add(this.lblNoFits);
            this.Controls.Add(this.pbxSortSearch);
            this.Controls.Add(this.pnlSideBar);
            this.Controls.Add(this.tbxSearch);
            this.Name = "frmCreate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCreate";
            this.Load += new System.EventHandler(this.frmCreate_Load);
            this.pnlSideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSortSearch)).EndInit();
            this.pnlPopUp.ResumeLayout(false);
            this.pnlPopUp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MXP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSideBar;
        private OutfitGen.Classes.WiiButtons wiiButtonsCreate;
        private System.Windows.Forms.Label lblNoFits;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.PictureBox pbxSortSearch;
        private System.Windows.Forms.Panel pnlPopUp;
        private System.Windows.Forms.Label lblPnlDesc;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblHowCreate;
        private OutfitGen.Classes.WiiButtons wiiButtonsScratch;
        private System.Windows.Forms.PictureBox pbxClose;
        private OutfitGen.Classes.WiiButtons wiiButtonsSettings;
        private AxWMPLib.AxWindowsMediaPlayer MXP;
    }
}