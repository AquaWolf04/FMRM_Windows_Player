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

        private void playButton_Click(object sender, EventArgs e)
        {
            awplayer.URL = @"https://ssl.servereradio.ro/8054/stream";
            awplayer.controls.play();
            string state = awplayer.playState.ToString();
            if (state == "wmppsTransitioning")
            {
                playButton.Enabled = false;
                stopButton.Enabled = true;
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            awplayer.controls.stop();
            string state = awplayer.playState.ToString();
            if (state == "wmppsStopped")
            {
                playButton.Enabled = true;
                stopButton.Enabled = false;
            }
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            awplayer.settings.volume = 10;
            volumePercent.Visible = true;
            volumePercent.Text = volumeBar.Value.ToString() + "%";
            string isOnline = awplayer.isOnline.ToString();
            informationText.Visible = false;
            stopButton.Enabled = false;
            if (isOnline == "False")
            {
                informationText.Text = "You currently offline!";
                informationText.Visible = true;
                playButton.Enabled = false;
                stopButton.Enabled = false;
            }
        }

        private void volumeBar_Scroll(object sender, EventArgs e)
        {
            awplayer.settings.volume = volumeBar.Value;
            volumePercent.Text = volumeBar.Value.ToString()+"%";
        }

        private void logoImg_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://fmradiomanele.ro");
        }

        private void authorText_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://aquawolf04.com");

        }
    }
}
