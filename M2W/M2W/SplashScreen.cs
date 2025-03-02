using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
