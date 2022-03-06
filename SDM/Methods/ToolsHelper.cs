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
    class ToolsHelper
    {
        public static void shutdownComputer(string NAME)
        {
            Cursor.Current = Cursors.WaitCursor;

            string Argument = $"&{{ shutdown -s -t 01 -f -m \\{NAME} }}";
            try
            {
                Ping ping = new Ping();
                PingReply pingresult = ping.Send(NAME);
                bool pingResult = pingresult.Status.ToString() == "Success";

                //  Wait 2 seconds before shutdown
                Thread.Sleep(500);

                var command_result = PowerShellHelper.executeCommand(Argument).StandardError.ReadToEnd();
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
                MessageBox.Show("The computer is currently not turned on!!", "SDM - Turned On!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Cursor.Current = Cursors.Default;
        }

        public static DateTime checkLastBaseCompChange()
        {
            return File.GetLastWriteTime(AppDomain.CurrentDomain.BaseDirectory + "AppAsset\\AD\\CompBase.json");
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
    }
}
