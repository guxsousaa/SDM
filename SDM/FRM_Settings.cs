using SDM.AuthUsers;
using SDM.Methods;
using SDM.UsersHelper;
using SDM.UsersHelper.Actions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
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

            lbl_app_version.Text = "Versão: " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            lbl_Copyright.Text = "Copyright © " + System.DateTime.Now.Year + " Kauã Lima & JBS S.A. All Rights Reserved";

            updateInfoFileBaseComp();
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
            if (AccessUsers.getMyAccess().full)
            {
                DialogResult result = MessageBox.Show("Updating the database can take a while, you really want to update the database?\n\nEstimated time of 5 - 10 minutes.", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Set cursor as hourglass
                    btn_update_BaseComp.Enabled = false;
                    Cursor.Current = Cursors.WaitCursor;

                    if (AdHelper.updateAdBaseFile(false))
                        MessageBox.Show("Active directory base updated successfully!\n\n",
                            "Updated successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Set cursor as default arrow
                    Cursor.Current = Cursors.Default;
                    btn_update_BaseComp.Enabled = true;

                    updateInfoFileBaseComp();

                }
            }
            else
            {
                MessageBox.Show("You do not have access to update AD base, please contact the system administrator (Kauã Vitorio).\n\n" +
                    "Warning code: " + ErrorHelper.ACCESS_DENIEDUPDATE_ADBASE,
                    "Access denied!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void updateInfoFileBaseComp()
        {
            txt_lastUpdateTime_CompBase.Text = "Última atualização: " + ToolsHelper.checkLastBaseCompChange();
            txt_file_size.Text = "Tamanho: " + ToolsHelper.getBaseCompSize();

            
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

        private void btn_users_Click(object sender, EventArgs e)
        {
            if (AccessUsers.getMyAccess().full)
            {
                FRM_UsersAccess frmUsers = new FRM_UsersAccess();
                frmUsers.ShowDialog();
            }
            else
            {
                MessageBox.Show("You do not have access to manage a user, please contact the system administrator (Kauã Vitorio).\n\n" +
                    "Warning code: " + ErrorHelper.ACCESS_DENIED_MANAGE_USER,
                    "Access denied!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_verify_permissions_Click(object sender, EventArgs e)
        {
            btn_verify_permissions.Enabled = false;
            Cursor.Current = Cursors.WaitCursor;

            AccessUsers.cretateUsersFile();

            Thread.Sleep(1500);

            Cursor.Current = Cursors.Default;
            btn_verify_permissions.Enabled = true;
        }

        private void btn_manage_my_account_Click(object sender, EventArgs e)
        {
            FRM_MyAccount frmAccount = new FRM_MyAccount();
            frmAccount.ShowDialog();
        }

        private void txt_title_frm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ToolsHelper.ReleaseCapture();
                ToolsHelper.SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
