using SDM.AuthUsers;
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

namespace SDM
{
    public partial class FRM_TiEmprest : Form
    {
        private static string currentUser = Environment.UserName.ToLower();

        public FRM_TiEmprest()
        {
            InitializeComponent();

        }

        private void FRM_TiEmprest_Load(object sender, EventArgs e)
        {


        }

        private void btn_shutdown_ti_Click(object sender, EventArgs e)
        {
            //execute powershell cmdlets or scripts using command arguments as process
            ProcessStartInfo processInfo = new ProcessStartInfo();
            processInfo.FileName = @"powershell.exe";
            //execute powershell script using script file
            //processInfo.Arguments = @"& {c:\temp\Get-EventLog.ps1}";
            //execute powershell command
            processInfo.Arguments = @"& {shutdown -s -t 01 -f -m \\"+ input_compName.Text.ToString() + "}";
            processInfo.Verb = "runas";
            processInfo.RedirectStandardError = true;
            processInfo.RedirectStandardOutput = true;
            processInfo.UseShellExecute = false;
            processInfo.CreateNoWindow = true;

            //start powershell process using process start info
            Process process = new Process();
            process.StartInfo = processInfo;
            process.Start();
        }
    }
}
