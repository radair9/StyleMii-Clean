using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StyleMii.Forms
{
    public partial class frmCreate : Form
    {
        public frmCreate()
        {
            InitializeComponent();

            MXP.URL = @"ChooseToCreate.mp3";
            MXP.settings.playCount = 9999;
            MXP.Ctlcontrols.stop();
            MXP.Visible = false;
        }

        private void frmCreate_Load(object sender, EventArgs e)
        {
            MXP.Ctlcontrols.play();
            pnlPopUp.Visible = false;
            pnlPopUp.Location = new Point(152, 94);

        }
            

        private void wiiButtonsCreate_Click(object sender, EventArgs e)
        {           
            pnlPopUp.Visible = true;         
            lblPnlDesc.Text = "Create an outfit\r\n";
            
            wiiButtonsScratch.Visible = true;
            lblHowCreate.Visible = true;
            MXP.Visible = false;
        }

        private void pbxClose_Click(object sender, EventArgs e)
        {
            pnlPopUp.Visible = false;
        }

        private void wiiButtonsSettings_Click(object sender, EventArgs e)
        {
            pnlPopUp.Visible = true;
            lblPnlDesc.Text = "Settings";           
            
            wiiButtonsScratch.Visible = false;
            lblHowCreate.Visible = false;
            MXP.Visible = true; 
        }

        private void MXP_Enter(object sender, EventArgs e)
        {

        }

        private void wiiButtonsRandom_Click(object sender, EventArgs e)
        {
            //random outfit
        }

        private void wiiButtonsScratch_Click(object sender, EventArgs e)
        {
            //outfit gen
            Forms.frmDesign design = new Forms.frmDesign();
            this.Hide();
            design.Show();
        }
    }
}
