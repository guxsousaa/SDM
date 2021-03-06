using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using SDM.Methods;
using SDM.AuthUsers;
using System.Windows.Forms.DataVisualization.Charting;
using System.Threading;
using System.DirectoryServices;
using SDM.FRMs_TraumaZero0;
using Microsoft.Win32;
using SDM.UsersHelper.Actions;
using System.Diagnostics;
using System.IO;

namespace SDM
{
    /**
     * 
     *  Copyright (c) 2022 Kauã Vitório
     *  Official repository https://github.com/Kauavitorio/SDM
     *  Responsible developer: https://github.com/Kauavitorio
     *  @author Kaua Vitorio
     *
     */

    public partial class FRM_Main : Form
    {
        private static string currentUser = Environment.UserName.ToLower();
        Thread updateThread;
        static FRM_Main instance;

        public FRM_Main()
        {
            InitializeComponent();

            //  Make the window round
            Region = Region.FromHrgn(ToolsHelper.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            txt_username_main.Text = AccessUsers.getUser_Name(currentUser);

            //Declaring the event.
            SystemEvents.SessionSwitch += new SessionSwitchEventHandler(ToolsHelper.SystemEvents_SessionSwitch);

            SystemEvents.PowerModeChanged += new PowerModeChangedEventHandler(ToolsHelper.SystemEvents_PowerModeChanged);

            //  Change nav for the start position
            changePnlNav(btn_dash_main);

            openWindown(new FRM_Dashboard());

            loadUserImage();

            instance = this;
        }

        public void loadUserImage()
        {
            //  Make picturebox rounded
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, user_profile_pic_main.Width - 3, user_profile_pic_main.Height - 3);
            Region rg = new Region(gp);
            user_profile_pic_main.Region = rg;

            string imgUrl = AccessUsers.getUserImageUrl(currentUser);
            if(imgUrl != null) user_profile_pic_main.ImageLocation = imgUrl;
        }

        public void updateName(string NAME)
        {
            txt_username_main.Text = NAME;
        }

        public static FRM_Main getInstance()
        {
            return instance;
        }

        private void FRM_Main_Load(object sender, EventArgs e)
        {
        }
        private void openWindown(object nextForm)
        {
            if (this.panel_main.Controls.Count > 0)
                this.panel_main.Controls.RemoveAt(0);

            Form form = nextForm as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.panel_main.Controls.Add(form);
            this.panel_main.Tag = form;
            form.Show();
        }

        // ---------- Start Click Event ----------

        private void btn_dash_main_Click(object sender, EventArgs e)
        {
            changePnlNav(btn_dash_main);
            openWindown(new FRM_Dashboard());
        }

        private void btn_ad_main_Click(object sender, EventArgs e)
        {
            changePnlNav(btn_ad_main);
            openWindown(new FRM_Ad());
        }

        private void btn_printer_main_Click(object sender, EventArgs e)
        {
            changePnlNav(btn_printer_main);
            openWindown(new FRM_Printer());
        }

        private void btn_tiemprest_main_Click(object sender, EventArgs e)
        {
            if (AccessUsers.getMyAccess().ti_emprest || AccessUsers.getMyAccess().full)
            {
                openWindown(new FRM_TiEmprest());
                changePnlNav(btn_tiemprest_main);
            }
            else
            {
                MessageBox.Show("Você não tem acesso para acessar a seção TiEmprest, entre em contato com o administrador do sistema (Kauã Vitorio).\n\n" +
                    "Código de aviso: " + ErrorHelper.ACCESS_DENIED_TIEMPREST,
                    "Acesso negado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btn_settings_main_Click(object sender, EventArgs e)
        {
            changePnlNav(btn_settings_main);

            FRM_Settings frm_settings = new FRM_Settings();
            frm_settings.ShowDialog();
        }
        private void btn_users_Click(object sender, EventArgs e)
        {
            changePnlNav(btn_users);
            openWindown(new FRM_User());
        }

        private void btn_traumaZero0_Click(object sender, EventArgs e)
        {
            FRM_Tr0_ThrowAgent frm_throwAgent = new FRM_Tr0_ThrowAgent();
            frm_throwAgent.ShowDialog();
        }

        // ---------- End Click Event ----------

        //  --------- Leave event ---------
        private void btn_dash_main_Leave(object sender, EventArgs e)
        {
            leaveClick(btn_dash_main);
        }


        private void btn_ad_main_Leave(object sender, EventArgs e)
        {
            leaveClick(btn_ad_main);
        }

        private void btn_printer_main_Leave(object sender, EventArgs e)
        {
            leaveClick(btn_printer_main);
        }

        private void btn_tiemprest_main_Leave(object sender, EventArgs e)
        {
            leaveClick(btn_tiemprest_main);
        }

        private void btn_settings_main_Leave(object sender, EventArgs e)
        {
            leaveClick(btn_settings_main);
        }
        private void btn_users_Leave(object sender, EventArgs e)
        {
            leaveClick(btn_users);
        }
        private void btn_traumaZero0_Leave(object sender, EventArgs e)
        {
            leaveClick(btn_traumaZero0);
        }
        //  --------- End Leave event ---------

        private void changePnlNav(Button btnClick)
        {
            PnlNav.Height = btnClick.Height;
            PnlNav.Top = btnClick.Top;
            PnlNav.Left = btnClick.Left;
            btnClick.BackColor = Color.FromArgb(46, 51, 73);
            Thread.Sleep(45);
        }

        private void leaveClick(Button leaveBtn)
        {
            leaveBtn.BackColor = Color.FromArgb(24, 30, 54);
        }


        //  Actions buttons Event
        private void minimize_btn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void FRM_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        private void panel_win_btns_main_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ToolsHelper.ReleaseCapture();
                ToolsHelper.SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void timer_checkup_Tick(object sender, EventArgs e)
        {
            //  This will only be called every 1.5 minutes
            if (updateThread == null || !updateThread.IsAlive)
            {
                try
                {
                    updateThread = new Thread(delegate ()
                    {
                        //  Check if the operating system is locked
                        if (!AdHelper.SECTION_LOCKED)
                        {
                            //  Check if there is connection with AD
                            if (AdHelper.GetAllComputers(true).Count >= 1)
                            {
                                //  Wait before updating the file
                                //  Wait because if you can't make a conflict
                                //  Waiting time will be between 10 seconds to 40 seconds
                                Thread.Sleep(new Random().Next(10000, 40000));

                                AdHelper.updateAdBaseFile(false);
                                return;
                            }
                            else
                                return;
                        }
                        else
                            return;
                    });
                    updateThread.IsBackground = true;
                    updateThread.Start();
                }catch (Exception ex)
                {
                    LogHelper.doLog(ex.ToString(), null);
                }
            }
        }

        public static bool IsNetworkBoxOpen = false;
        private void timer_network_Tick(object sender, EventArgs e)
        {
            //  Validate if user is connected to a internet connection
            bool networkStatus = System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable();
            if (!networkStatus && !IsNetworkBoxOpen)
            {
                IsNetworkBoxOpen = true;
                MessageBox.Show("You have no internet connection, please connect to a network and reopen the application.\n\n" +
                        "Warning code: " + ErrorHelper.NO_INTERNET,
                        "No Internet Connection!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                IsNetworkBoxOpen = false;
                Environment.Exit(1);
            }
        }

        private void user_profile_pic_main_Click(object sender, EventArgs e)
        {
            new FRM_MyAccount().ShowDialog();
        }

        private void btn_docs_Click(object sender, EventArgs e)
        {
            string path = "file://mtzdskti/web/SDM/index.html";
            if (File.Exists(path)) Process.Start(path);
            else
                MessageBox.Show("Nao foi possivel localizar os arquivos da pagina web", "SDM - Pagina nao encontrada!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
