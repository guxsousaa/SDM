using DTO_AD;
using SDM.Methods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDM.FRMs_AD
{
    public partial class FRM_AD_Search : Form
    {
        public FRM_AD_Search()
        {
            InitializeComponent();

            //  Make the window round
            Region = Region.FromHrgn(ToolsHelper.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void btn_search_Computer_Click(object sender, EventArgs e)
        {
            string COMPUTER_NAME = input_computerName_ad.Text.ToString();
            if (COMPUTER_NAME.Length <= 0)
                MessageBox.Show("Cannot search for a computer with empty search field",
                    "SDM - Empty search!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (COMPUTER_NAME.Length <= 3)
                MessageBox.Show("Need to further specify the computer name.\n\nEx: " + "\"MTZ\" - Unit + " + "\"NTB\" - Computer Type",
                    "SDM - Specify name!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                ADInfo computerInfo = AdHelper.searchComputer(COMPUTER_NAME.ToUpper());
                if (COMPUTER_NAME.Where(c => char.IsNumber(c)).Count() > 0 || computerInfo != null)
                {
                    string[] resultOu = AdHelper.buildOu(computerInfo).Replace(" ", string.Empty).Split(',');

                    StringBuilder str = new StringBuilder();
                    for (int i = 0; i < resultOu.Count(); i++)
                    {
                        int step = i + 1;
                        if (i == 0)
                            str.Append("1- " + resultOu[i]);
                        else
                            str.Append("\n" + step + "- " + resultOu[i]);
                    }

                    if (resultOu.Count() > 5)
                        MessageBox.Show(str.ToString(),
                            "SDM - Result!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                    {
                        txt_compResult.Text = str.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Name available for creation",
                        "SDM - OK!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    setWatingText();
                }
            }
        }

        private void input_computerName_ad_TextChanged(object sender, EventArgs e)
        {
            string input = input_computerName_ad.Text.ToString();
            if (input.Length <= 0) setWatingText();
        }

        void setWatingText()
        {
            txt_compResult.Text = "Wating...";
        }

        private void close_btn_SearchAd_AD_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        private void header_panel_SearchComp_ad_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ToolsHelper.ReleaseCapture();
                ToolsHelper.SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void txt_header_title_searchComp_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ToolsHelper.ReleaseCapture();
                ToolsHelper.SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
