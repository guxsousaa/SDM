using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDM.FRMs_AD
{
    public partial class FRM_AD_Password : Form
    {

        private static string PASSWORD = "!SDM.AD@2022.";
        public FRM_AD_Password()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            checkPassword();
        }

        void checkPassword()
        {
            if (input_password.Text == PASSWORD)
            {
                // The password is ok.
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                // The password is invalid.
                input_password.Clear();
                MessageBox.Show("Invalid password.", "SDM - Password request",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                input_password.Focus();
            }
        }

        private void input_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                checkPassword();
            }
        }
    }
}
