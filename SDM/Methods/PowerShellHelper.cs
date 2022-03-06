using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDM.Methods
{
    internal class PowerShellHelper
    {
        static void OpenPowerShell()
        {
            //execute powershell cmdlets or scripts using command arguments as process
            ProcessStartInfo processInfo = new ProcessStartInfo();
            processInfo.FileName = @"powershell.exe";
            //execute powershell script using script file
            //processInfo.Arguments = @"& {c:\temp\Get-EventLog.ps1}";
            //execute powershell command
            processInfo.Arguments = @"& {Get-NetIPAddress}";
            processInfo.Verb = "runas";
            processInfo.RedirectStandardError = true;
            processInfo.RedirectStandardOutput = true;
            processInfo.UseShellExecute = false;
            processInfo.CreateNoWindow = true;

            //start powershell process using process start info
            Process process = new Process();
            process.StartInfo = processInfo;
            process.Start();



            MessageBox.Show(process.StandardOutput.ReadToEnd(), "Out", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            MessageBox.Show(process.StandardError.ReadToEnd(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);


            Console.Read();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_ARGUMENT"></param>
        /// <returns></returns>
        public static Process executeCommand(string _ARGUMENT, bool DONT_SHOW_DIALOG)
        {
            //execute powershell cmdlets or scripts using command arguments as process
            ProcessStartInfo processInfo = new ProcessStartInfo();
            processInfo.FileName = @"powershell.exe";
            processInfo.Arguments = _ARGUMENT;
            processInfo.Verb = "runas";
            processInfo.RedirectStandardError = true;
            processInfo.RedirectStandardOutput = true;
            processInfo.UseShellExecute = false;
            processInfo.CreateNoWindow = DONT_SHOW_DIALOG;

            //start powershell process using process start info
            Process process = new Process();
            process.StartInfo = processInfo;
            process.Start();

            return process;
        }
    }
}
