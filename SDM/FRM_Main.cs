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

namespace SDM
{
    public partial class FRM_Main : Form
    {
        private static string currentUser = Environment.UserName.ToLower();
        Thread updateThread;

        public FRM_Main()
        {
            InitializeComponent();

            //  Make the window round
            Region = Region.FromHrgn(ToolsHelper.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            //  Change nav for the start position
            changePnlNav(btn_dash_main);

            txt_username_main.Text = AccessUsers.getUser_Name(currentUser);

            openWindown(new FRM_Dashboard());

            loadUserImage();
        }

        void loadUserImage()
        {
            //  Make picturebox rounded
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, user_profile_pic_main.Width - 3, user_profile_pic_main.Height - 3);
            Region rg = new Region(gp);
            user_profile_pic_main.Region = rg;

            string imgUrl = AccessUsers.getUserImageUrl(currentUser);
            if(imgUrl != null) user_profile_pic_main.ImageLocation = imgUrl;
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
            if (!AccessUsers.canAccessTiEmprest.Contains(currentUser.ToLower()))
            {
                MessageBox.Show("You do not have access to access TiEmprest section, please contact the system administrator (Kauã Vitorio).\n\n" +
                    "Warning code: " + ErrorHelper.ACCESS_DENIED_TIEMPREST,
                    "Access denied!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                openWindown(new FRM_TiEmprest());
                changePnlNav(btn_tiemprest_main);
            }
        }
        private void btn_settings_main_Click(object sender, EventArgs e)
        {
            changePnlNav(btn_settings_main);

            FRM_Settings frm_settings = new FRM_Settings();
            frm_settings.ShowDialog();
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
        //  --------- End Leave event ---------

        private void changePnlNav(Button btnClick)
        {
            PnlNav.Height = btnClick.Height;
            PnlNav.Top = btnClick.Top;
            PnlNav.Left = btnClick.Left;
            btnClick.BackColor = Color.FromArgb(46, 51, 73);
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
            //  This will only be called every 5 minutes
            if (updateThread == null || !updateThread.IsAlive)
            {
                updateThread = new Thread(delegate ()
                {
                    //  Check if there is connection with AD
                    if (AdHelper.GetAllComputers(true).Count >= 1)
                    {
                        //  Wait before updating the file
                        //  Wait because if you can't make a conflict
                        //  Waiting time will be between 50 to 2 minutes
                        Thread.Sleep(new Random().Next(50000, 120005));

                        AdHelper.updateAdBaseFile();
                        return;
                    }
                    else
                        return;
                });
                updateThread.IsBackground = true;
                updateThread.Start();
            }
        }
    }
}
