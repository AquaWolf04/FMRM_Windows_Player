using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Radio
{
    
    public partial class MainMenu : Form
    {
        private WindowsMediaPlayer awplayer = new WindowsMediaPlayer();
        public MainMenu()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            awplayer.URL = @"http://141.94.96.128:8054/stream"; //STREAM URL
            awplayer.controls.play();
            string state = awplayer.playState.ToString();
            if (state == "wmppsTransitioning")
            {
                play.Enabled = false;
                stop.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            awplayer.controls.stop();
            string state = awplayer.playState.ToString();
            if (state == "wmppsStopped")
            {
                play.Enabled = true;
                stop.Enabled = false;
            }
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            awplayer.settings.volume = 10;
            label2.Visible = true;
            label2.Text = trackBar1.Value.ToString() + "%";
            label4.Text = awplayer.versionInfo.ToString();
            string isOnline = awplayer.isOnline.ToString();
            label5.Visible = false;
            stop.Enabled = false;
            if (isOnline == "False")
            {
                label5.Text = "You currently offline!";
                label5.Visible = true;
                play.Enabled = false;
                stop.Enabled = false;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            awplayer.settings.volume = trackBar1.Value;
            label2.Text = trackBar1.Value.ToString()+"%";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
