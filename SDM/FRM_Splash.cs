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

namespace SDM
{
    public partial class FRM_Splash : Form
    {

        public FRM_Splash()
        {
            InitializeComponent();

            //  Set the initial width of the progress bar
            progress_splash.Width = 1;

            // System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable();


        }

        private void timer_splash_Tick(object sender, EventArgs e)
        {

            progress_splash.Width += 3;

            if (progress_splash.Width >= 100)
            {
                timer_splash.Stop();
                FRM_Auth fRM_Auth = new FRM_Auth();

                LogHelper.doLog("\nError 8\n");

                /*fRM_Auth.Show();
                this.Hide();*/
            }
        }


    }


}