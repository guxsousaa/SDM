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

namespace SDM
{
    public partial class FRM_Main : Form
    {
        private static string currentUser = Environment.UserName;

        public FRM_Main()
        {
            InitializeComponent();

            //  Make the window round
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            //  Change nav for the start position
            changePnlNav(btn_dash_main);

            txt_username_main.Text = currentUser.Replace("-otimtz", "");

            //AdHelper.GetComputers();
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

        // Method that uses a dll to round the window
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


        // ---------- Start Click Event ----------

        private void btn_dash_main_Click(object sender, EventArgs e)
        {
            changePnlNav(btn_dash_main);
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
    }
}
