using SDM.Methods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDM
{
    public partial class FRM_User : Form
    {
        public FRM_User()
        {
            InitializeComponent();
        }

        private void btn_search_user_Click(object sender, EventArgs e)
        {
            doCheckUser();
        }

        void doCheckUser()
        {
            string USER = input_user.Text.ToString().ToLower();
            if (USER == null || USER.Length <= 0)
            {
                MessageBox.Show("Necessário inserir o login do usuário!!",
                    "SDM - Login do Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
                input_user.Focus();
            }
            else
            {
                Cursor.Current = Cursors.WaitCursor;
                btn_search_user.Enabled = false;

                string Argument = "Get-ADUser -filter{ (SamAccountName -eq '" + USER + "')} –Properties 'SamAccountName', 'displayName', 'extensionAttribute1', 'extensionAttribute2', 'enabled', 'mail', 'distinguishedName', 'manager', 'passwordlastset', 'lastLogonTimestamp', 'accountExpires', 'uSNCreated' | Sort-object SamAccountName | Select-Object -Property 'SamAccountName', 'displayName', 'extensionAttribute1', 'extensionAttribute2', 'enabled', 'mail', 'distinguishedName','manager', 'passwordlastset', @{ Name = 'lastLogonTimestam'; Expression ={[datetime]::FromFileTime($_.'lastLogonTimestamp')} }, @{ Name = 'accountExpire'; Expression ={[datetime]::FromFileTime($_.'accountExpires')} }, @{ Name = 'uSNCreated'; Expression ={[datetime]::FromFileTimeUtc($_.(ConvertADSLargeInteger pwdlastset.value))} }";

                Process result = PowerShellHelper.executeCommand(Argument, true);

                var resultError = result.StandardError.ReadToEnd();
                string resultCommand = result.StandardOutput.ReadToEnd().ToString();
                if (resultCommand.Length > 10)
                {
                    txt_result_search.Text = string.Join("\n", buildUserInfo(resultCommand));
                }
                else
                {
                    if (resultError.Length > 0)
                    {
                        txt_result_search.Text = "Error ao consultar o usuário";
                        MessageBox.Show(result.StandardError.ReadToEnd(),
                            "SDM - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        txt_result_search.Text = "Usuário não encontrado!!";
                    }
                }

                Cursor.Current = Cursors.Default;
                btn_search_user.Enabled = true;
            }
        }

        List<string> buildUserInfo(string INPUT)
        {
            List<string> userInfo = new List<string>();

            string[] stringSeparators = new string[] { "\r\n" };
            string[] strSplit = INPUT.Split(stringSeparators, StringSplitOptions.None);

            for(int i = 0; i < strSplit.Count(); i++)
            {
                string row = strSplit[i];

                if(row != null && row.Length > 3)
                {

                    string[] splitRow = row.Split(':');

                    if(splitRow.Length > 0)
                        splitRow[0] = ToolsHelper.FirstLetterToUpper(Regex.Replace(splitRow[0], @"\s", ""));

                    if (splitRow.Length == 2)
                    {
                        userInfo.Add(splitRow[0] + ": " + splitRow[1]);
                    }
                    else if(splitRow.Length > 2)
                    {
                        StringBuilder buildInfo = new StringBuilder();
                        for(int pos = 1; pos < splitRow.Length; pos++)
                        {
                            buildInfo.Append(splitRow[pos]);
                        }
                        userInfo.Add(splitRow[0] + ": " + buildInfo.ToString());
                    }
                }
            }
            return userInfo;
        }

        private void input_user_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                doCheckUser();
        }
    }
}
