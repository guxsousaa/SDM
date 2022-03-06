using SDM.Methods;
using SDM.UsersHelper.Actions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDM.UsersHelper
{
    public partial class FRM_UsersAccess : Form
    {
        public FRM_UsersAccess()
        {
            InitializeComponent();

            //  Make the window round
            Region = Region.FromHrgn(ToolsHelper.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void btn_new_user_Click(object sender, EventArgs e)
        {
            FRM_NewUser frm_newUser = new FRM_NewUser();
            frm_newUser.ShowDialog();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
