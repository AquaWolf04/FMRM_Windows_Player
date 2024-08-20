namespace Radio
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.playButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.volumeBar = new System.Windows.Forms.TrackBar();
            this.volumeText = new System.Windows.Forms.Label();
            this.volumePercent = new System.Windows.Forms.Label();
            this.logoImg = new System.Windows.Forms.PictureBox();
            this.authorText = new System.Windows.Forms.Label();
            this.informationText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.volumeBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoImg)).BeginInit();
            this.SuspendLayout();
            // 
            // playButton
            // 
            resources.ApplyResources(this.playButton, "playButton");
            this.playButton.Name = "playButton";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // stopButton
            // 
            resources.ApplyResources(this.stopButton, "stopButton");
            this.stopButton.Name = "stopButton";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // volumeBar
            // 
            this.volumeBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.volumeBar.Cursor = System.Windows.Forms.Cursors.VSplit;
            resources.ApplyResources(this.volumeBar, "volumeBar");
            this.volumeBar.Maximum = 100;
            this.volumeBar.Name = "volumeBar";
            this.volumeBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.volumeBar.Value = 10;
            this.volumeBar.Scroll += new System.EventHandler(this.volumeBar_Scroll);
            // 
            // volumeText
            // 
            resources.ApplyResources(this.volumeText, "volumeText");
            this.volumeText.BackColor = System.Drawing.Color.Transparent;
            this.volumeText.ForeColor = System.Drawing.Color.White;
            this.volumeText.Name = "volumeText";
            // 
            // volumePercent
            // 
            resources.ApplyResources(this.volumePercent, "volumePercent");
            this.volumePercent.BackColor = System.Drawing.Color.Transparent;
            this.volumePercent.ForeColor = System.Drawing.Color.White;
            this.volumePercent.Name = "volumePercent";
            // 
            // logoImg
            // 
            this.logoImg.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.logoImg, "logoImg");
            this.logoImg.Name = "logoImg";
            this.logoImg.TabStop = false;
            this.logoImg.Click += new System.EventHandler(this.logoImg_Click);
            // 
            // authorText
            // 
            resources.ApplyResources(this.authorText, "authorText");
            this.authorText.BackColor = System.Drawing.Color.Transparent;
            this.authorText.ForeColor = System.Drawing.Color.White;
            this.authorText.Name = "authorText";
            this.authorText.Click += new System.EventHandler(this.authorText_Click);
            // 
            // informationText
            // 
            resources.ApplyResources(this.informationText, "informationText");
            this.informationText.BackColor = System.Drawing.Color.Transparent;
            this.informationText.ForeColor = System.Drawing.Color.Red;
            this.informationText.Name = "informationText";
            // 
            // MainMenu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.informationText);
            this.Controls.Add(this.authorText);
            this.Controls.Add(this.logoImg);
            this.Controls.Add(this.volumePercent);
            this.Controls.Add(this.volumeText);
            this.Controls.Add(this.volumeBar);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.playButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.volumeBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.TrackBar volumeBar;
        private System.Windows.Forms.Label volumeText;
        private System.Windows.Forms.Label volumePercent;
        private System.Windows.Forms.PictureBox logoImg;
        private System.Windows.Forms.Label authorText;
        private System.Windows.Forms.Label informationText;
    }
}

