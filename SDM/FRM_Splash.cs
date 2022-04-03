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
using Microsoft.Win32;

namespace SDM
{
    public partial class FRM_Splash : Form
    {
        private static string currentUser = Environment.UserName.ToLower();

        public FRM_Splash()
        {
            InitializeComponent();

            txt_version.Text = "Versão " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;

            //  Set the initial width of the progress bar
            progress_splash.Width = 1;

            //  Validate if user is connected to a internet connection
            bool networkStatus = System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable();
            if (networkStatus)
            {

                timer_splash.Stop();
                if (!AccessUsers.canAccess(currentUser))
                {
                    MessageBox.Show("Você não tem acesso para usar este aplicativo, entre em contato com o administrador do sistema (Kauã Vitorio).\n\n" +
                        "Código de aviso: " + ErrorHelper.ACCESS_DENIED,
                        "Acesso negado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Environment.Exit(1);

                }
                else
                    timer_splash.Start();
            }
            else
            {
                MessageBox.Show("Você não tem conexão com a Internet, conecte-se a uma rede e reabra o aplicativo.\n\n" +
                        "Código de aviso: " + ErrorHelper.NO_INTERNET,
                        "Sem conexão com a Internet!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Environment.Exit(1);
            }
        }

        private void timer_splash_Tick(object sender, EventArgs e)
        {
            if(Cursor.Current != Cursors.AppStarting) Cursor.Current = Cursors.AppStarting;

            if(progress_splash.Width <= 100)
                progress_splash.Width += 4;
            else if (progress_splash.Width <= 200)
            {
                //  Init ad list
                if (AdHelper.AD.Count <= 0)
                    AdHelper.InitList();

                progress_splash.Width += 8;
            }
            else if (progress_splash.Width <= 400)
                progress_splash.Width += 30;
            else
                progress_splash.Width += 40;

            if (progress_splash.Width >= 600)
            {
                Cursor.Current = Cursors.Default;
                timer_splash.Stop();
                new FRM_Main().Show();
                this.Hide();
            }
        }
    }
}