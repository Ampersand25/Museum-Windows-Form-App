using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class StartSplashScreen : Form
    {
        public StartSplashScreen()
        {
            InitializeComponent();
        }

        private void StartSplashScreen_Load(object sender, EventArgs e)
        {
            this.Text = "Starting Application";
            this.Icon = new Icon("../../Images/MuseumLogo.ico");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            currentProgressPanel.Width += 3;
            if (currentProgressPanel.Width >= 700)
            {
                timer1.Stop();
                new Login().Show();
                this.Hide();
            }
        }
    }
}
