using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDM
{
    public partial class FRM_User : Form
    {
        public FRM_User()
        {
            InitializeComponent();
        }

        private void btn_search_user_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry, this page is under development.\n\n" +
                "If you have any questions, please contact the Administrator(Kauã Vitorio)",
                "SDM - Under development", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
