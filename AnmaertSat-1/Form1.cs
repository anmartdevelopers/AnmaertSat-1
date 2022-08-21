using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tweetinvi;
using Tweetinvi.Models;

namespace AnmaertSat_1
{
    public partial class Form1 : Form

    {
        System.Timers.Timer t;
        int h, m, s;
        public Form1()
        {
            InitializeComponent();
            //Auth.SetUserCredentials();
            ((Control)webBrowser1).Enabled = false;
            webBrowser1.Navigate("https://www.openstreetmap.org/#map=2/50.8/5.6");
            webBrowser1.Visible = true;
            webBrowser2.Navigate("https://www.openstreetmap.org/#map=2/50.8/5.6");
            webBrowser2.Visible = true;
        }
        //Tweeter class
        public class TwitterHelper
        {
            private TwitterClient _twitterClient{get; set;}
            public TwitterHelper(string apikey, string apiSecret, string accessToken, string accessScret)
            {
                _twitterClient = new TwitterClient(apikey, apiSecret, accessToken, accessScret);
                var twitterHelper = new TwitterHelper(
                   Environment.GetEnvironmentVariable("JSdVRvJWHl6rX2D2LWsZ7t167"),
                   Environment.GetEnvironmentVariable("VRstnL2Bob1plG27ekFFKNwplhL1Rnhbg9RBqkMf02QMARnP7b"),
                   Environment.GetEnvironmentVariable("3499944196-fEt2V4a7vw053GA0kcRm34H7VtGqjYCPauS2276"),
                   Environment.GetEnvironmentVariable("Mb2J5OsJUmTmOOxje9XdEm0pOigpTye5FD4OvE6icnU3d")
                   );
            }
        }
        private void timer1_Tick(object sender, EventArgs e)

        {
            //assigning all the clock variable parameters to read the exact time on the gmt and also to update every second
            IbTime.Text = DateTime.Now.ToString("HH:mm");
            IbSeconds.Text = DateTime.Now.ToString("ss");
            IbDate.Text = DateTime.Now.ToString("MMM dd yyyy");
            IbDay.Text = DateTime.Now.ToString("ddd");
            IbSeconds.Location = new Point(IbTime.Location.X + IbTime.Width - 5, IbSeconds.Location.Y);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            t = new System.Timers.Timer();
            t.Interval = 10;
            t.Elapsed += OnTimeEvent;
            //initializing the watch
            timer1.Start();

            //twitter
           // var User = User.GetAuthenticatedUser();

        }
        private void OnTimeEvent(object sender, System.Timers.ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                s += 1;
                if (s == 60)
                {
                    s = 0;
                    m += 1;
                }
                if (m == 60)
                {
                    m = 0;
                    h += 1;
                }
                txtResult.Text = string.Format("{0}:{1}:{2}", h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
            }));
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            t.Start();
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            t.Stop();
        }
        
        private void bunifuDataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDataGridView10_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void IbDay_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void webBrowser2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDataGridView13_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
