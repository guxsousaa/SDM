using Microsoft.Win32;
using System;
using System.Collections.Generic;
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
        public static string NOTIFY_LOAN_FILE_NAME = "notify_loan.json";
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

                    var command_result = PowerShellHelper.executeCommand(Argument, false).StandardError.ReadToEnd();
                    if (command_result != null || command_result != "")
                        MessageBox.Show(command_result, "SDM - Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        MessageBox.Show("Shutdown performed successfully, in a few moments the computer is turned off.",
                            "SDM - Shutdown performed!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                }
                catch (PingException ex)
                {
                    LogHelper.doLog("\nTry ping a computer error\n\n" + ex.ToString() + "\n\n" + "Computer name: " + NAME,
                        ErrorHelper.PING_OTHER_COMPUTER);

                    MessageBox.Show("The computer is currently not turned on!!", "SDM - Turned On!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Cursor.Current = Cursors.Default;
            }
        }

        public static DateTime checkLastBaseCompChange()
        {
            return File.GetLastWriteTime(AppDomain.CurrentDomain.BaseDirectory + "AppAsset\\AD\\CompBase.json");
        }

        public static string getBaseCompSize()
        {
            return SizeSuffix(new FileInfo(AppDomain.CurrentDomain.BaseDirectory + "AppAsset\\AD\\CompBase.json").Length);
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
            MessageBox.Show(e.Mode.ToString());
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
