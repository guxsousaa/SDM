using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDM.Methods
{
    /**
     * 
     *  Copyright (c) 2022 Kauã Vitório
     *  Official repository https://github.com/Kauavitorio/SDM
     *  Responsible developer: https://github.com/Kauavitorio
     *  @author Kaua Vitorio
     *
     */
    class ToolsHelper
    {
        public static string NOTIFY_LOAN_FILE_NAME = "new_loans.json";
        public static string RETURN_LOAN_FILE_NAME = "return_loans.json";

        public static void shutdownComputer(string NAME)
        {
            if(NAME != null && NAME.Length > 0)
            {
                Cursor.Current = Cursors.WaitCursor;
                string Argument = $"&{{ shutdown -s -t 01 -f -m \\{NAME} }}";
                try
                {
                    Ping ping = new Ping();
                    PingReply pingresult = ping.Send(NAME);
                    bool pingResult = pingresult.Status.ToString() == "Success";

                    //  Wait few milliseconds before shutdown
                    Thread.Sleep(500);


                    var psi = new ProcessStartInfo("shutdown", "-s -t 01 -f -m \\\\" + NAME);
                    psi.CreateNoWindow = true;
                    psi.UseShellExecute = false;
                    Process.Start(psi);

                    MessageBox.Show("Desligamento realizado com sucesso, em poucos instantes o computador é desligado.",
                        "SDM - Desligamento realizado!!", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                catch (PingException ex)
                {
                    LogHelper.doLog("\nTry ping a computer error\n\n" + ex.ToString() + "\n\n" + "Computer name: " + NAME,
                        ErrorHelper.PING_OTHER_COMPUTER);

                    MessageBox.Show("O computador não está ligado no momento!!", "SDM - Ligados!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Cursor.Current = Cursors.Default;
            }
        }

        public static void convertToUpter(object sender)
        {
            TextBox currentContainer = ((TextBox)sender);
            int caretPosition = currentContainer.SelectionStart;

            currentContainer.Text = currentContainer.Text.ToUpper();
            currentContainer.SelectionStart = caretPosition++;
        }

        public static DateTime checkLastBaseCompChange()
        {
            return File.GetLastWriteTime(AppDomain.CurrentDomain.BaseDirectory + "AppAsset\\AD\\CompBase.json");
        }

        public static string getBaseCompSize()
        {
            try
            {
                return SizeSuffix(new FileInfo(AppDomain.CurrentDomain.BaseDirectory + "AppAsset\\AD\\CompBase.json").Length);
            }catch (Exception ex)
            {
                LogHelper.doLog("\nGet CompBase.json size \n\n" + ex.ToString(),
                    ErrorHelper.GET_FILE_SIZE);
                return "";
            }
        }

        public static string FirstLetterToUpper(string str)
        {
            if (str == null)
                return null;

            if (str.Length > 1)
                return char.ToUpper(str[0]) + str.Substring(1);

            return str.ToUpper();
        }

        static readonly string[] SizeSuffixes =
                   { "bytes", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB" };
        static string SizeSuffix(Int64 value, int decimalPlaces = 1)
        {
            if (decimalPlaces < 0) { throw new ArgumentOutOfRangeException("decimalPlaces"); }
            if (value < 0) { return "-" + SizeSuffix(-value, decimalPlaces); }
            if (value == 0) { return string.Format("{0:n" + decimalPlaces + "} bytes", 0); }

            // mag is 0 for bytes, 1 for KB, 2, for MB, etc.
            int mag = (int)Math.Log(value, 1024);

            // 1L << (mag * 10) == 2 ^ (10 * mag) 
            // [i.e. the number of bytes in the unit corresponding to mag]
            decimal adjustedSize = (decimal)value / (1L << (mag * 10));

            // make adjustment when the value is large enough that
            // it would round up to 1000 or more
            if (Math.Round(adjustedSize, decimalPlaces) >= 1000)
            {
                mag += 1;
                adjustedSize /= 1024;
            }

            return string.Format("{0:n" + decimalPlaces + "} {1}",
                adjustedSize,
                SizeSuffixes[mag]);
        }

        // Method that uses a dll to round the window
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr OpenInputDesktop(uint dwFlags, bool fInherit, uint dwDesiredAccess);


        public static void SystemEvents_PowerModeChanged(object sender, PowerModeChangedEventArgs e)
        {
            LogHelper.doLog("\nComputer PowerMode Change: " + e.Mode.ToString() + "\nType: " 
                + e.Mode.GetType() + "\n", null);
        }

        //Event definition
        public static void SystemEvents_SessionSwitch(object sender, SessionSwitchEventArgs e)
        {
            //Use switch case to identify the session switch reason.
            //Code accordingly.
            switch (e.Reason)
            {
                case SessionSwitchReason.SessionLock:
                    AdHelper.SECTION_LOCKED = true;
                    break;
                case SessionSwitchReason.SessionLogoff:
                    AdHelper.SECTION_LOCKED = true;
                    break;
                case SessionSwitchReason.SessionLogon:
                    AdHelper.SECTION_LOCKED = false;
                    break;
                case SessionSwitchReason.SessionUnlock:
                    AdHelper.SECTION_LOCKED = false;
                    break;
                default:
                    break;
            }
        }
    }
}
