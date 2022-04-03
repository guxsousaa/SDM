using DTO_AD;
using SDM.Methods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDM.FRMs_TraumaZero0
{
    /**
     * 
     *  Copyright (c) 2022 Kauã Vitório
     *  Official repository https://github.com/Kauavitorio/SDM
     *  Responsible developer: https://github.com/Kauavitorio
     *  @author Kaua Vitorio
     *
     */
    public partial class FRM_Tr0_ThrowAgent : Form
    {
        public FRM_Tr0_ThrowAgent()
        {
            InitializeComponent();

            txt_my_ip.Text = "My ip: " + NetworkHelper.GetLocalIPAddress();
        }

        private void btn_throwAgent_Click(object sender, EventArgs e)
        {
            string COMPUTER_NAME = input_computer_name.Text.ToString();

            if (COMPUTER_NAME == null || COMPUTER_NAME.Length <= 0)
                MessageBox.Show("You need to enter the computer name",
                    "SDM - Empty field!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                Cursor.Current = Cursors.WaitCursor;

                //  Get AD path
                ADInfo computerInfo = AdHelper.searchComputer(COMPUTER_NAME);
                if(computerInfo == null)
                    MessageBox.Show("The computer informed does not exist, enter the correct name!",
                                "SDM - NOT FOUND!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    try
                    {
                        Ping ping = new Ping();
                        PingReply pingresult = ping.Send(COMPUTER_NAME);
                        if (pingresult.Address != null && pingresult.Address.ToString().Length > 3)
                            COMPUTER_NAME = pingresult.Address.ToString();
                        if (pingresult.Status.ToString() == "Success")
                        {
                            throwAgent(COMPUTER_NAME);

                        }
                        else
                        {
                            throwAgent(COMPUTER_NAME);
                        }
                    }
                    catch (PingException ex)
                    {
                        LogHelper.doLog("\nTry ping a computer error\n\n" + ex.ToString() + "\n\n" + "Computer name: " + COMPUTER_NAME,
                            ErrorHelper.PING_OTHER_COMPUTER);

                        MessageBox.Show("The computer entered is not connected or does not exist, please check the name entered!",
                                    "SDM - PING EXCEPTION!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                Cursor.Current = Cursors.Default;
            }
        }

        void throwAgent(string COMPUTER_NAME)
        {

            string Argument = $"&{{ Set-Location -Path C:\\ | .\\PsExec.exe \\{COMPUTER_NAME} -c c:\\AgenteTz0.exe {NetworkHelper.GetLocalIPAddress()} }}";
            Cursor.Current = Cursors.WaitCursor;


            LogHelper.doLog("\nRunning script to throw Traumaer0 Agent\nCN= " + COMPUTER_NAME, null);

            Process process = PowerShellHelper.executeCommand(Argument, false);

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
                LogHelper.doLog("\nError running Trauma Command\n\n" + command_result, ErrorHelper.CREATING_NEW_COMPUTER_AD);

                MessageBox.Show(command_result, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Cursor.Current = Cursors.Default;
        }
    }
}
