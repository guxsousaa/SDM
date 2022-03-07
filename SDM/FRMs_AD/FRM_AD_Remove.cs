using DTO_AD;
using SDM.Methods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDM.FRMs_AD
{
    public partial class FRM_AD_Remove : Form
    {
        public FRM_AD_Remove()
        {
            InitializeComponent();

            //  Make the window round
            Region = Region.FromHrgn(ToolsHelper.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void btn_Delete_Computer_Click(object sender, EventArgs e)
        {
            string COMPUTER_NAME = input_computerName_ad.Text.ToString();
            string Argument = $"&{{ Remove-ADComputer '{COMPUTER_NAME}' }}";

            if (COMPUTER_NAME.Length <= 0)
            {
                MessageBox.Show("Cannot delete a computer without entering the name",
                    "SDM - Empty search!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                input_computerName_ad.Focus();
            }
            else
            {
                FRM_AD_Password frm_password = new FRM_AD_Password();
                if (frm_password.ShowDialog() != DialogResult.OK)
                {
                    // The user canceled.
                    this.Close();
                }
                else
                {
                    Cursor.Current = Cursors.WaitCursor;
                    ADInfo computerInfo = AdHelper.searchComputer(COMPUTER_NAME);
                    if (computerInfo != null)
                    {
                        Process process = PowerShellHelper.executeCommand(Argument, false);

                        var command_result = process.StandardError.ReadToEnd();
                        if (command_result == null || command_result == "")
                        {
                            AdHelper.requestUpdateBaseFile();

                            MessageBox.Show("Computer successfully deleted!\n\nIf you perform the search again and it appears that it has not been moved," +
                        " this happens because the file that the application uses has not yet been updated, but the computer has been moved.",
                                "SDM - Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show(command_result, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("The informed computer does not exist!!",
                           "SDM - Not Found!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        input_computerName_ad.Focus();
                    }

                    Cursor.Current = Cursors.Default;
                }
            }
        }

        private void close_btn_DeleteAd_AD_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        private void header_panel_newComp_ad_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ToolsHelper.ReleaseCapture();
                ToolsHelper.SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
