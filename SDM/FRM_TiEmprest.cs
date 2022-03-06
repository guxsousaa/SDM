using DTO_AD;
using SDM.AuthUsers;
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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDM
{
    public partial class FRM_TiEmprest : Form
    {
        private static string currentUser = Environment.UserName.ToLower();

        public FRM_TiEmprest()
        {
            InitializeComponent();
            setWatingStatus();

        }

        private void FRM_TiEmprest_Load(object sender, EventArgs e)
        {


        }


        //  Check computer status events
        private void btn_check_statusClick(object sender, EventArgs e)
        {
            string NTBNAME = input_compName.Text.ToString();
            doCheckStatus(NTBNAME);
        }

        private void input_compName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string NTBNAME = input_compName.Text.ToString();
                doCheckStatus(NTBNAME);
            }
        }   //  End Check computer status events

        void doCheckStatus(string NTBNAME)
        {
            if (NTBNAME != null && NTBNAME.Length > 0)
            {
                Cursor.Current = Cursors.WaitCursor;
                try
                {
                    Ping ping = new Ping();
                    PingReply pingresult = ping.Send(NTBNAME);
                    if (pingresult.Status.ToString() == "Success")
                    {
                        txt_response_online.ForeColor = Color.Green;
                        txt_response_online.Text = "Online";

                        //  Get the current user who is logged in
                        string Argument = $"&{{ Get-WmiObject –ComputerName {NTBNAME} –Class Win32_ComputerSystem | Select-Object UserName }}";
                        Process process = PowerShellHelper.executeCommand(Argument, true);

                        string responseError = process.StandardError.ReadToEnd();
                        if (responseError != null && responseError != "")
                        {
                            txt_response_currentUser.Text = "Error";
                            MessageBox.Show(responseError, "SDM - Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            txt_response_currentUser.Text = clearCurrentUser(process.StandardOutput.ReadToEnd(), NTBNAME);
                            txt_response_currentUser.ForeColor = Color.White;
                        }

                    }
                    else
                    {
                        setOfflineStatus();
                    }
                }
                catch (PingException ex)
                {
                    LogHelper.doLog("\nTry ping a computer error\n\n" + ex.ToString() + "\n\n" + "Computer name: " + NTBNAME,
                        ErrorHelper.PING_OTHER_COMPUTER);

                    setOfflineStatus();
                }

                //  Get AD path
                ADInfo computerInfo = AdHelper.searchComputer(NTBNAME);
                if (computerInfo != null)
                {
                    if (computerInfo.OU.Contains("Bloqueio") || computerInfo.OU.Contains("Realocacao"))
                    {
                        txt_response_status.ForeColor = Color.Red;
                        txt_response_status.Text = computerInfo.OU[0];
                        if (computerInfo.OU.Count > 1)
                            txt_response_status.Text = txt_response_status.Text + " - " + computerInfo.OU[1];
                    }
                    else
                    {
                        txt_response_status.ForeColor = Color.Green;
                        txt_response_status.Text = "Okay - " + computerInfo.OU[0];
                    }
                }
                else
                {
                    txt_response_status.Text = "Does not exist";
                    txt_response_status.ForeColor = Color.Red;
                }

                //panel_container.Size = new Size(panel_container.Width + 50, 0);

                Cursor.Current = Cursors.Default;
            }
            else
                MessageBox.Show("You need to enter the machine name",
                    "SDM - Empty search!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        string clearCurrentUser(string response, string NTBNAME)
        {
            return RemoveWhitespace(response.Replace("UserName", "").Replace("--------", "").Replace(NTBNAME + "\\", ""));
        }
        public static string RemoveWhitespace(string input)
        {
            return new string(input.ToCharArray()
                .Where(c => !Char.IsWhiteSpace(c))
                .ToArray());
        }

        void setWatingStatus()
        {
            txt_response_online.Text = "Wating...";
            txt_response_currentUser.Text = "Wating...";
            txt_response_status.Text = "Wating...";

            txt_response_online.ForeColor = Color.White;
            txt_response_currentUser.ForeColor = Color.White;
            txt_response_status.ForeColor = Color.White;
        }
        void setOfflineStatus()
        {
            txt_response_online.Text = "Offline";
            txt_response_currentUser.Text = "Logged out";

            txt_response_online.ForeColor = Color.Red;
            txt_response_currentUser.ForeColor = Color.Red;
        }

        private void input_compName_TextChanged(object sender, EventArgs e)
        {
            string input = input_compName.Text.ToString();
            if (input.Length <= 0) setWatingStatus();
        }

        private void btn_shutdown_ti_Click_1(object sender, EventArgs e)
        {
            string input = input_compName.Text.ToString();
            ToolsHelper.shutdownComputer(input);
        }

        private void btn_block_tiemprest_Click(object sender, EventArgs e)
        {
            string NTBNAME = input_compName.Text.ToString();
            if(NTBNAME == null || NTBNAME.Length <= 0)
                MessageBox.Show("You need to enter the machine name",
                    "SDM - Empty search!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (NTBNAME.Length < 9)
                    MessageBox.Show("Enter the name of a valid loan machine.",
                        "SDM - Machine name!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    Cursor.Current = Cursors.WaitCursor;

                    //  Get AD path
                    ADInfo computerInfo = AdHelper.searchComputer(NTBNAME);
                    if (computerInfo != null)
                    {
                        if (computerInfo.OU.Contains("Bloqueio"))
                        {
                            DialogResult result = MessageBox.Show("This machine is already blocked, would you like to just turn it off?",
                                "SDM - Machine already blocked", MessageBoxButtons.YesNo);
                            if (result == DialogResult.Yes)
                                ToolsHelper.shutdownComputer(NTBNAME);
                        }
                        else
                        {
                            string Argument = $"&{{ Get-ADComputer '{NTBNAME}' |Move-ADObject -TargetPath '{AdHelper.OU_HOSTNAME_BLOCK}' }}";
                            Process process = PowerShellHelper.executeCommand(Argument, true);

                            var command_result = process.StandardError.ReadToEnd();
                            if (command_result == null || command_result == "")
                                ToolsHelper.shutdownComputer(NTBNAME);
                            else
                                MessageBox.Show(command_result, "SDM - Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                        MessageBox.Show("The computer informed for the block does not exist, enter the correct name!",
                            "SDM - NOT FOUND!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    Cursor.Current = Cursors.Default;
                    doCheckStatus(NTBNAME);
                }
            }
        }


    }
}
