using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;

namespace WindowsFormsApp1
{
    public partial class SplashScreen : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public SplashScreen()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            circularProgressBar.Value = 0;
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            this.Text = "Museum Application Loading Screen";
            this.Icon = new Icon("../../Images/MuseumLogo.ico");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            circularProgressBar.Value += 1;
            circularProgressBar.Text = circularProgressBar.Value.ToString() + "%";
            if (circularProgressBar.Value == 100)
            {
                timer.Enabled = false;
                new GenericMasterDetailWindow().Show();
                this.Hide();
            }
        }

        private void SplashScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
