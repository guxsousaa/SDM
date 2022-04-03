using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
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
    internal class PowerShellHelper
    {

        /// <summary>
        /// Nao utiliar esse metodo
        /// Esse metodo é apenas para testes e backup
        /// </summary>
        private static void OpenPowerShell()
        {
            //execute powershell cmdlets or scripts using command arguments as process
            ProcessStartInfo processInfo = new ProcessStartInfo();
            processInfo.WorkingDirectory = @"C:";
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
        /// Executa commandos via PowerShell
        /// Sempre como ADM
        /// </summary>
        /// <param name="_ARGUMENT"></param>
        /// <returns></returns>
        public static Process executeCommand(string _ARGUMENT, bool DONT_SHOW_DIALOG)
        {
            //execute powershell cmdlets or scripts using command arguments as process
            ProcessStartInfo _processInfo = new ProcessStartInfo();
            //_processInfo.WorkingDirectory = @"C:";
            _processInfo.FileName = @"powershell.exe";
            _processInfo.Arguments = _ARGUMENT;
            _processInfo.Verb = "runas";
            _processInfo.RedirectStandardError = true;
            _processInfo.RedirectStandardOutput = true;
            _processInfo.UseShellExecute = false;
            _processInfo.CreateNoWindow = DONT_SHOW_DIALOG;

            //start powershell process using process start info
            Process process = new Process();
            process.StartInfo = _processInfo;
            process.Start();

            return process;
        }
    }
}
