using DTO_AD;
using SDM.Methods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            Cursor.Current = Cursors.WaitCursor;
            Cursor.Current = Cursors.Default;
        }
    }
}
