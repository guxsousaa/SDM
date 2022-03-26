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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Users_DTO;

namespace SDM.UsersHelper.Actions
{
    public partial class FRM_MyAccount : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        private static string currentUser = Environment.UserName.ToLower();

        public FRM_MyAccount()
        {
            InitializeComponent();

            hideAllContainer();

            UserInfo myAccount = AccessUsers.getMyAccess();

            txt_user_name.Text = myAccount.name;
            txt_UserName.Text = myAccount.username;

            if (myAccount.full) txt_user_access.Text = "Acesso Full";
            else
            {
                if(myAccount.op) txt_user_access.Text = "Acesso Operador";
                if (myAccount.ti_emprest) txt_user_access.Text = txt_user_access.Text + " | Empréstimo";
            }


            loadUserImage();
        }

        void loadUserImage()
        {
            //  Make picturebox rounded
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, user_profile_pic.Width - 3, user_profile_pic.Height - 3);
            Region rg = new Region(gp);
            user_profile_pic.Region = rg;

            string imgUrl = AccessUsers.getUserImageUrl(currentUser);
            if (imgUrl != null) user_profile_pic.ImageLocation = imgUrl;
        }

        void hideAllContainer()
        {
            panel_container_update_photo.Visible = false;
            panel_container_newName.Visible = false;
            input_newPhoto.Text = string.Empty;
            input_newName.Text = string.Empty;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_move_wsus_win10_Click(object sender, EventArgs e)
        {
            hideAllContainer();
            panel_container_update_photo.Visible = true;
        }

        private void btn_test_newphoto_Click(object sender, EventArgs e)
        {
            string newPhoto = input_newPhoto.Text.ToString();
            if (newPhoto == null || newPhoto.Length <= 5)
                MessageBox.Show("Insira o URL da imagem corretamente", "SDM - Imagem incorreta",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                user_profile_pic.ImageLocation = newPhoto;
            }
        }

        private void btn_save_newImage_Click(object sender, EventArgs e)
        {
            string newPhoto = input_newPhoto.Text.ToString();
            if (newPhoto == null || newPhoto.Length <= 5)
                MessageBox.Show("Insira o URL da imagem corretamente", "SDM - Imagem incorreta",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                UpdateImage(newPhoto);
            }

            void UpdateImage(string IMAGE)
            {
                Cursor.Current = Cursors.WaitCursor;

                List<UserInfo> allUsers = AccessUsers.getMainUsersFile();
                string mainPath = AppDomain.CurrentDomain.BaseDirectory;

                if(allUsers != null)
                {
                    hideAllContainer();
                    string currentUser = Environment.UserName.ToLower();
                    for (int i = 0; i < allUsers.Count; i++)
                    {
                        if (allUsers[i].username.ToLower() == currentUser.ToLower())
                        {
                            allUsers[i].imageUrl = IMAGE;

                            string json = JsonConvert.SerializeObject(allUsers);

                            Thread.Sleep(new Random().Next(500, 1000));
                            File.WriteAllText(mainPath + "AppAsset\\accessUsers.json", json);

                            AccessUsers.cretateUsersFile();

                            Thread.Sleep(500);

                            FRM_Main.getInstance().loadUserImage();

                            Cursor.Current = Cursors.Default;
                            return;
                        }
                    }
                }
                else
                {
                    Cursor.Current = Cursors.Default;
                    MessageBox.Show("ERROR");
                    return;
                }
            }
        }

        private void btn_save_name_Click(object sender, EventArgs e)
        {
            string NAME = input_newName.Text.ToString();
            if (NAME == null || NAME.Length <= 5)
                MessageBox.Show("Insira seu nome corretamente", "SDM - Nome incorreta",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                UpdateName(NAME);
            }
        }

        void UpdateName(string NAME)
        {
            Cursor.Current = Cursors.WaitCursor;

            List<UserInfo> allUsers = AccessUsers.getMainUsersFile();
            string mainPath = AppDomain.CurrentDomain.BaseDirectory;

            if (allUsers != null)
            {
                hideAllContainer();
                string currentUser = Environment.UserName.ToLower();
                for (int i = 0; i < allUsers.Count; i++)
                {
                    if (allUsers[i].username.ToLower() == currentUser.ToLower())
                    {
                        allUsers[i].name = NAME;
                        txt_user_name.Text = NAME;

                        string json = JsonConvert.SerializeObject(allUsers);

                        Thread.Sleep(new Random().Next(500, 1200));
                        File.WriteAllText(mainPath + "AppAsset\\accessUsers.json", json);

                        AccessUsers.cretateUsersFile();

                        Thread.Sleep(500);

                        FRM_Main.getInstance().updateName(NAME);

                        Cursor.Current = Cursors.Default;
                        return;
                    }
                }
            }
            else
            {
                Cursor.Current = Cursors.Default;
                MessageBox.Show("ERROR");
                return;
            }
        }

        private void btn_new_name_Click(object sender, EventArgs e)
        {
            hideAllContainer();
            panel_container_newName.Visible = true;
        }

        private void txt_header_title_myAccount_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ToolsHelper.ReleaseCapture();
                ToolsHelper.SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void header_panel_MyAccount_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ToolsHelper.ReleaseCapture();
                ToolsHelper.SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
