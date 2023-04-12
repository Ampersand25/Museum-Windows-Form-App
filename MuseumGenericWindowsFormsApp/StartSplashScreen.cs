using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void timer_Tick(object sender, EventArgs e)
        {
            currentProgressPanel.Width += 3;
            if (currentProgressPanel.Width >= 700)
            {
                timer.Stop();
                new Login().Show();
                this.Hide();
            }
        }
    }
}
