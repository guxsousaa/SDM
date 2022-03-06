using Newtonsoft.Json;
using SDM.AuthUsers;
using SDM.Methods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Users_DTO;

namespace SDM.UsersHelper.Actions
{
    public partial class FRM_NewUser : Form
    {
        public FRM_NewUser()
        {
            InitializeComponent();

            //  Make the window round
            Region = Region.FromHrgn(ToolsHelper.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            string NAME = input_name.Text.ToString();
            string USERNAME = input_username.Text.ToString();
            string IMAGE = input_image.Text.ToString();
            if (NAME == null || NAME.Length <= 0 || USERNAME == null || USERNAME.Length <= 0)
                MessageBox.Show("Please fill in all required fields", "SDM  - Required fields",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;

                    List<UserInfo> allUsers = AccessUsers.getMainUsersFile();

                    bool FULL = checkBox_full.Checked;
                    bool OP;
                    bool TIEMPREST;
                    if (FULL)
                    {
                        OP = true;
                        TIEMPREST = true;
                    }
                    else
                    {
                        OP = checkBox_operator.Checked;
                        TIEMPREST = checkBox_TiEmprest.Checked;
                    }

                    allUsers.Add(new UserInfo(NAME, USERNAME, FULL, OP, TIEMPREST, IMAGE));

                    string json = JsonConvert.SerializeObject(allUsers);
                    string mainPath = AppDomain.CurrentDomain.BaseDirectory;

                    File.WriteAllText(mainPath + "AppAsset\\accessUsers.json", json);

                    MessageBox.Show("User created successfully", "SDM  - New User Created",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Cursor.Current = Cursors.Default;

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "SDM  - Fatal Error!!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        void validadeCheckBoxs()
        {
            if (checkBox_full.Checked)
            {
                checkBox_operator.Enabled = false;
                checkBox_TiEmprest.Enabled = false;
            }
            else
            {
                checkBox_operator.Enabled = true;
                checkBox_TiEmprest.Enabled = true;
            }

            if (checkBox_operator.Checked || checkBox_TiEmprest.Checked) checkBox_full.Enabled = false;
            else checkBox_full.Enabled = true;
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

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox_full_CheckedChanged(object sender, EventArgs e)
        {
            validadeCheckBoxs();
        }

        private void checkBox_operator_CheckedChanged(object sender, EventArgs e)
        {
            validadeCheckBoxs();
        }

        private void checkBox_TiEmprest_CheckedChanged(object sender, EventArgs e)
        {
            validadeCheckBoxs();
        }
    }
}
