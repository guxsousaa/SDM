using DTO_AD;
using SDM.Methods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.DirectoryServices;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDM.FRMs_AD
{
    public partial class FRM_newComp : Form
    {
        string OU_PATH = null;
        public FRM_newComp()
        {
            InitializeComponent();

            //  Make the window round
            Region = Region.FromHrgn(ToolsHelper.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void btn_search_Computer_Click(object sender, EventArgs e)
        {
            string computerName = input_computerName_ad.Text.ToString();
            if (computerName.Length <= 0)
                MessageBox.Show("Cannot search for a computer with empty search field",
                    "SDM - Empty search!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (computerName.Length <= 3)
                MessageBox.Show("Need to further specify the computer name.\n\nEx: " + "\"MTZ\" - Unit + " + "\"NTB\" - Computer Type",
                    "SDM - Specify name!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                ADInfo computerInfo = AdHelper.searchComputer(computerName.ToUpper());

                LogHelper.doLog("\nComputer search performed\nCN= " + computerName, null);

                if (computerName.Where(c => char.IsNumber(c)).Count() <= 0)
                {
                    string number = AdHelper.getNextComputerName(computerName.ToUpper());

                    string suggestionMachine = string.Empty;
                    if (Int32.Parse(number) < 10) suggestionMachine = computerName + "0" + number;
                    else suggestionMachine = computerName + number;

                    LogHelper.doLog("\nComputer suggestion\nCN= " + suggestionMachine, null);

                    DialogResult result = MessageBox.Show($"{{ The computer with the following name \"{suggestionMachine}\" is available.\n" +
                        $"Would you like to accept the suggestion? }}",
                    "SDM - Name suggestion!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        input_computerName_ad.Text = suggestionMachine;

                        LogHelper.doLog("\nSuggestion accepted\nCN= " + suggestionMachine, null);
                    }
                    else
                    {
                        LogHelper.doLog("\nSuggestion declined\nCN= " + suggestionMachine, null);

                        MessageBox.Show("Please inform the number available for the creation of the machine",
                            "SDM - Waiting for number!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    if (computerName.Where(c => char.IsNumber(c)).Count() > 0 || computerInfo != null)
                    {
                        txt_comp_desc.Text = AdHelper.buildOu(computerInfo);
                    }
                    else
                    {
                        MessageBox.Show("Name available for creation",
                            "SDM - OK!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btn_create_Computer_Click(object sender, EventArgs e)
        {
            string COMPUTER_NAME = input_computerName_ad.Text.ToString().ToUpper();

            string Argument = $"&{{ New-ADComputer -Name '{COMPUTER_NAME}' -Path '{OU_PATH}' }}";

            if (COMPUTER_NAME.Length <= 0)
                MessageBox.Show("Cannot create a new computer with empty search field",
                    "SDM - Empty search!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            if(COMPUTER_NAME.Length > 20)
                MessageBox.Show("The computer name cannot be longer than 20 characters.",
                    "SDM - Max characters!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if(OU_PATH == null || OU_PATH.Length <= 3)
                MessageBox.Show("Select the OU Path",
                    "SDM - OU not selected!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                LogHelper.doLog("\nRequest to create a new computer\nCN= " + COMPUTER_NAME, null);

                ADInfo computerInfo = AdHelper.searchComputer(COMPUTER_NAME);
                if(computerInfo != null)
                {
                    LogHelper.doLog("\nComputer already exists\nCN= " + COMPUTER_NAME, null);

                    MessageBox.Show("The informed computer already exists!!",
                        "SDM - Already exists!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    LogHelper.doLog("\nRunning create new computer\nCN= " + COMPUTER_NAME, null);

                    Process process = PowerShellHelper.executeCommand(Argument, true);

                    var command_result = process.StandardError.ReadToEnd();
                    if (command_result == null || command_result == "")
                    {
                        LogHelper.doLog("\nComputer created successfully", null);

                        AdHelper.requestUpdateBaseFile();

                        MessageBox.Show("Machine created successfully\n\nIf you perform the search again and it appears that it has not been moved," +
                        " this happens because the file that the application uses has not yet been updated, but the computer has been moved.!",
                            "SDM - Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        LogHelper.doLog("\nError creating a new computer\n\n" + command_result, ErrorHelper.CREATING_NEW_COMPUTER_AD);

                        MessageBox.Show(command_result, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void input_computerName_ad_TextChanged(object sender, EventArgs e)
        {
            string COMPUTER_NAME = input_computerName_ad.Text.ToString();
            txt_comp_desc.Text = "Typing: " + COMPUTER_NAME;

            if (COMPUTER_NAME.Length <= 0) txt_comp_desc.Text = "Waiting...";
            else
            {
                
            }
        }

        void updateOuPath(string ou_get)
        {
            OU_PATH = ou_get;
            txt_create_in.Text = "Create in: " + OU_PATH.Split(',')[0];
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

        private void txt_header_create_computer_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ToolsHelper.ReleaseCapture();
                ToolsHelper.SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        /// Close window click event
        private void close_btn_newComp_AD_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ou_wsus_win10_Click(object sender, EventArgs e)
        {
            updateOuPath(AdHelper.OU_WSUS_WIN10_MTZ);
        }

        private void btn_ou_mtz_note_Click(object sender, EventArgs e)
        {
            updateOuPath(AdHelper.OU_NOTEBOOK_MTZ);
        }

        private void btn_ou_mtz_dsk_Click(object sender, EventArgs e)
        {
            updateOuPath(AdHelper.OU_COMPUETRS_MTZ);
        }

        private void btn_ou_smt_note_Click(object sender, EventArgs e)
        {
            updateOuPath(AdHelper.OU_NTB_SMT);
        }

        private void btn_ou_smt_comp_Click(object sender, EventArgs e)
        {
            updateOuPath(AdHelper.OU_DSK_SMT);
        }
    }
}
