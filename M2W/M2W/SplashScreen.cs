using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M2W
{
    public partial class SplashScreen : Form
    {
        private System.Windows.Forms.Timer? fadeOutTimer;

        public SplashScreen()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Opacity = 1;
            this.TopMost = true;

            // Load app version dynamically
            lblAppName.Text = "M2W - MP3 to WAV Converter";
            lblVersion.Text = $"Version {Assembly.GetExecutingAssembly().GetName().Version}";
            lblStatus.Text = "Loading, please wait...";

            // Set the splash image (update path if necessary)
            pictureBoxLogo.Image = Image.FromStream(new MemoryStream(Properties.Resources.M2W_Splash)); // Make sure you have an image in Resources

            System.Windows.Forms.Timer displayTimer = new System.Windows.Forms.Timer { Interval = 2000 };
            displayTimer.Tick += (s, e) =>
            {
                displayTimer.Stop();
                StartFadeOut();
            };
            displayTimer.Start();
        }

        private void StartFadeOut()
        {
            fadeOutTimer = new System.Windows.Forms.Timer { Interval = 50 };
            fadeOutTimer.Tick += (s, e) =>
            {
                if (this.Opacity > 0)
                    this.Opacity -= 0.05;
                else
                {
                    fadeOutTimer.Stop();
                    this.Close();
                }
            };
            fadeOutTimer.Start();
        }
    }
}
