using SDM.AuthUsers;
using SDM.Methods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDM
{
    public partial class FRM_Settings : Form
    {
        private static string currentUser = Environment.UserName.ToLower();

        public FRM_Settings()
        {
            InitializeComponent();

            //  Make the window round
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));


            checkLastBaseCompChange();
        }

        private void checkLastBaseCompChange()
        {
            string mainPath = AppDomain.CurrentDomain.BaseDirectory + "AppAsset\\AD\\CompBase.json";

            DateTime dt = File.GetLastWriteTime(mainPath);
            dt = File.GetLastWriteTime(mainPath);
            txt_lastUpdateTime_CompBase.Text = "Last update: " + dt;
        }


        //  Actions buttons Event
        private void minimize_btn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_update_BaseComp_Click(object sender, EventArgs e)
        {
            if (AccessUsers.canUpdateBase.Contains(currentUser))
            {
                DialogResult result = MessageBox.Show("Updating the database can take a while, you really want to update the database?\n\nEstimated time of 5 - 10 minutes.", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Set cursor as hourglass
                    Cursor.Current = Cursors.WaitCursor;

                    AdHelper.updateAdBaseFile();

                    // Set cursor as default arrow
                    Cursor.Current = Cursors.Default;

                    checkLastBaseCompChange();

                    MessageBox.Show("Active directory base updated successfully!\n\n",
                        "Updated successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("You do not have access to update AD base, please contact the system administrator (Kauã Vitorio).\n\n" +
                    "Warning code: " + ErrorHelper.ACCESS_DENIEDUPDATE_ADBASE,
                    "Access denied!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void panel_win_btns_main_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
