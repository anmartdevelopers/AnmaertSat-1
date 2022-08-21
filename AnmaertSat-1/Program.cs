using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tweetinvi;

namespace AnmaertSat_1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            var twitterHelper = new TwitterHelper(
            Environment.GetEnvironmentVariable("JSdVRvJWHl6rX2D2LWsZ7t167"),
            Environment.GetEnvironmentVariable("VRstnL2Bob1plG27ekFFKNwplhL1Rnhbg9RBqkMf02QMARnP7b"),
            Environment.GetEnvironmentVariable("3499944196-fEt2V4a7vw053GA0kcRm34H7VtGqjYCPauS2276"),
            Environment.GetEnvironmentVariable("Mb2J5OsJUmTmOOxje9XdEm0pOigpTye5FD4OvE6icnU3d"));
        }
        
    }
}
