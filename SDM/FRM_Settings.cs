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
            Region = Region.FromHrgn(ToolsHelper.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));


            txt_lastUpdateTime_CompBase.Text = "Last update: " + ToolsHelper.checkLastBaseCompChange();
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

                    if (AdHelper.updateAdBaseFile())
                    {
                        MessageBox.Show("Active directory base updated successfully!\n\n",
                            "Updated successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    // Set cursor as default arrow
                    Cursor.Current = Cursors.Default;

                    txt_lastUpdateTime_CompBase.Text = "Last update: " + ToolsHelper.checkLastBaseCompChange();

                }
            }
            else
            {
                MessageBox.Show("You do not have access to update AD base, please contact the system administrator (Kauã Vitorio).\n\n" +
                    "Warning code: " + ErrorHelper.ACCESS_DENIEDUPDATE_ADBASE,
                    "Access denied!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
    }
}
