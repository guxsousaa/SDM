using SDM.Methods;
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
    public partial class FRM_Printer : Form
    {
        public FRM_Printer()
        {
            InitializeComponent();
        }

        private void btn_ping_computer_Click(object sender, EventArgs e)
        {
            if(input_compName.Text == null || input_compName.Text.Length <= 0)
            {
                MessageBox.Show("Cannot search for a computer with empty search field",
                    "SDM - Empty search!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string hostName = input_compName.Text.ToString();
                if (ToolsHelper.PingHost(hostName))
                {
                    MessageBox.Show("ON",
                        "SDM - Empty search!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("OFF",
                        "SDM - Empty search!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
