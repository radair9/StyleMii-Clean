using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

using System.Media;

namespace StyleMii.Forms
{
    public partial class frmStart : Form
    {
        SoundPlayer loadingSoundEffect;
        public frmStart()
        {
            InitializeComponent();
        }
        private void frmStart_Load(object sender, EventArgs e)
        {
            loadingSoundEffect = new SoundPlayer(@"ChannelIntro.wav");
            loadingSoundEffect.Play();
        }
        private void wiiButtonsStart_Click(object sender, EventArgs e)
        {         
            Forms.frmCreate create = new Forms.frmCreate();
            this.Hide();
            create.Show();
        }

        private void wiiButtonsExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
