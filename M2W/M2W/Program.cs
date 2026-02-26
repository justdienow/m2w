using System;
using System.Windows.Forms;

namespace M2W
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            // Correct order of initialization
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Show splash screen
            using (SplashScreen splash = new SplashScreen())
            {
                splash.ShowDialog();
            }

            // Start the main application
            Application.Run(new Form1());
        }
    }
}
