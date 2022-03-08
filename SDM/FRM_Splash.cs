using log4net;
using log4net.Config;
using SDM.Methods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net.Appender;
using log4net.Layout;
using log4net.Repository.Hierarchy;
using System.IO;
using SDM.AuthUsers;

namespace SDM
{
    public partial class FRM_Splash : Form
    {
        private static string currentUser = Environment.UserName.ToLower();

        public FRM_Splash()
        {
            InitializeComponent();

            txt_version.Text = "Version " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;

            //  Set the initial width of the progress bar
            progress_splash.Width = 1;

            //  Validate if user is connected to a internet connection
            bool networkStatus = System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable();
            if (networkStatus)
            {

                timer_splash.Stop();
                if (!AccessUsers.canAccess(currentUser))
                {
                    MessageBox.Show("You do not have access to use this application, please contact the system administrator (Kauã Vitorio).\n\n" +
                        "Warning code: " + ErrorHelper.ACCESS_DENIED,
                        "Access denied!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Environment.Exit(1);

                }
                else
                    timer_splash.Start();
            }
            else
            {
                MessageBox.Show("You have no internet connection, please connect to a network and reopen the application.\n\n" +
                        "Warning code: " + ErrorHelper.NO_INTERNET,
                        "No Internet Connection!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Environment.Exit(1);
            }
        }

        private void timer_splash_Tick(object sender, EventArgs e)
        {

            if(progress_splash.Width <= 100)
                progress_splash.Width += 2;
            else if (progress_splash.Width <= 200)
            {
                //  Init ad list
                if (AdHelper.AD.Count <= 0)
                    AdHelper.initList();

                progress_splash.Width += 6;
            }
            else if (progress_splash.Width <= 400)
                progress_splash.Width += 20;
            else
                progress_splash.Width += 35;

            if (progress_splash.Width >= 600)
            {
                timer_splash.Stop();
                FRM_Main fRM_Main = new FRM_Main();

                //OpenPowerShell();

                fRM_Main.Show();
                this.Hide();
            }
        }
    }
}