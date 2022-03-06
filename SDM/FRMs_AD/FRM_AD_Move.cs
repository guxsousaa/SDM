using DTO_AD;
using SDM.Methods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDM.FRMs_AD
{
    public partial class FRM_AD_Move : Form
    {
        public FRM_AD_Move()
        {
            InitializeComponent();
            panel_options.Visible = false;
        }

        private void btn_search_Computer_Click(object sender, EventArgs e)
        {
            string COMPUTER_NAME = input_computerName_ad.Text.ToString();
            if (COMPUTER_NAME.Length <= 0)
                MessageBox.Show("Cannot search for a computer with empty search field",
                    "SDM - Empty search!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                ADInfo computerInfo = AdHelper.searchComputer(COMPUTER_NAME.ToUpper());
                turnOptions(computerInfo != null, computerInfo);
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
                        txt_response_status.Text = computerInfo.OU[0];
                    }
                }
                else
                {
                    MessageBox.Show("Computer not found",
                        "SDM - Not Found!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void input_computerName_ad_TextChanged(object sender, EventArgs e)
        {
            if (input_computerName_ad.Text.ToString().Length <= 0)
            {
                setWatingStatus();
                panel_options.Visible = false;
            }
        }

        void turnOptions(bool ON, ADInfo info)
        {
            enableAll();
            if (!ON)
            {
                setWatingStatus();
                panel_options.Visible = false;
            }
            else
            {
                panel_options.Visible = true;
                blockIfInOu(info);
            }
        }

        void blockIfInOu(ADInfo info)
        {
            List<string> OUS = info.OU;
            if (OUS.Contains("Bloqueio")) btn_move_block.Enabled = false;
            else if (OUS.Contains("Realocacao")) btn_move_realocation.Enabled = false;
            else if (OUS.Contains("OUNotebook") && OUS.Contains("Matriz")) btn_move_mtz_note.Enabled = false;
            else if (OUS.Contains("OUComputers") && OUS.Contains("Matriz")) btn_move_mtz_dsk.Enabled = false;
            else if (OUS.Contains("ValidaWin10") && OUS.Contains("Wsus") && OUS.Contains("Matriz")) btn_move_wsus_win10.Enabled = false;
        }

        void moveComputer(string COMPUTER, string OU)
        {
            string Argument = $"&{{ Get-ADComputer '{COMPUTER}' |Move-ADObject -TargetPath '{OU}' }}";
            DialogResult result = MessageBox.Show("Are you sure you want to move computer \'" + COMPUTER + "\' to \'" + OU + "\'?",
                "SDM - Moved!!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                Cursor.Current = Cursors.WaitCursor;

                Process process = PowerShellHelper.executeCommand(Argument, true);

                var command_result = process.StandardError.ReadToEnd();
                if (command_result == null || command_result == "")
                    MessageBox.Show("Computer successfully moved!!\n\nIf you perform the search again and it appears that it has not been moved," +
                        " this happens because the file that the application uses has not yet been updated, but the computer has been moved.", "SDM - Moved!!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show(command_result, "SDM - Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Cursor.Current = Cursors.Default;
            }
        }

        void enableAll()
        {
            btn_move_block.Enabled = true;
            btn_move_realocation.Enabled = true;
            btn_move_mtz_note.Enabled = true;
            btn_move_mtz_dsk.Enabled = true;
            btn_move_wsus_win10.Enabled = true;
        }

        void setWatingStatus()
        {
            txt_response_status.Text = "Wating...";
            txt_response_status.ForeColor = Color.White;
        }

        private void btn_move_wsus_win10_Click(object sender, EventArgs e)
        {
            string COMPUTER = input_computerName_ad.Text.ToString();
            moveComputer(COMPUTER, AdHelper.OU_WSUS_WIN10_MTZ);
        }

        private void btn_move_mtz_note_Click(object sender, EventArgs e)
        {
            string COMPUTER = input_computerName_ad.Text.ToString();
            moveComputer(COMPUTER, AdHelper.OU_NOTEBOOK_MTZ);
        }

        private void btn_move_mtz_dsk_Click(object sender, EventArgs e)
        {
            string COMPUTER = input_computerName_ad.Text.ToString();
            moveComputer(COMPUTER, AdHelper.OU_COMPUETRS_MTZ);
        }

        private void btn_move_block_Click(object sender, EventArgs e)
        {
            string COMPUTER = input_computerName_ad.Text.ToString();
            moveComputer(COMPUTER, AdHelper.OU_HOSTNAME_BLOCK);
        }

        private void close_btn_MoveAd_AD_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
