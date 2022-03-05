﻿using DTO_AD;
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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDM.FRMs_AD
{
    public partial class FRM_newComp : Form
    {
        public FRM_newComp()
        {
            InitializeComponent();

            //  Make the window round
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
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
                ADInfo computerInfo = AdHelper.searchComputer(computerName);
                if(computerInfo == null && computerName.Where(c => char.IsNumber(c)).Count() <= 0)
                {
                    string number = AdHelper.getNextComputerName(computerName);

                    string suggestionMachine = string.Empty;
                    if (Int32.Parse(number) < 10) suggestionMachine = computerName + "0" + number;
                    else suggestionMachine = computerName + number;

                    DialogResult result = MessageBox.Show($"{{ The computer with the following name \"{suggestionMachine}\" is available.\n" +
                        $"Would you like to accept the suggestion? }}",
                    "SDM - Name suggestion!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        input_computerName_ad.Text = suggestionMachine;
                    }
                    else
                    {
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
            string COMPUTER_NAME = input_computerName_ad.Text.ToString();
            string PATH = "OU=OU Notebook,OU=Matriz,DC=corporate,DC=ad";

            string Argument = $"&{{ New-ADComputer -Name '{COMPUTER_NAME}' -Path '{PATH}' }}";

            if (COMPUTER_NAME.Length <= 0)
                MessageBox.Show("Cannot create a new computer with empty search field",
                    "SDM - Empty search!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            if(COMPUTER_NAME.Length > 20)
                MessageBox.Show("The computer name cannot be longer than 20 characters.",
                    "SDM - Max characters!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                Process process = PowerShellHelper.executeCommand(Argument);

                var command_result = process.StandardError.ReadToEnd();
                if (command_result == null || command_result == "")
                    MessageBox.Show("Machine created successfully!",
                        "SDM - Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    MessageBox.Show(command_result, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void header_panel_newComp_ad_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        // Method that uses a dll to round the window
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        /// Close window click event
        private void close_btn_newComp_AD_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
