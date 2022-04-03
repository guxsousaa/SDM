using DTO_AD;
using SDM.Methods;
using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SDM.FRMs_AD
{
    public partial class FRM_newComp : Form
    {
        string OU_PATH = null;
        public FRM_newComp()
        {
            InitializeComponent();

            //  Make the window round
            Region = Region.FromHrgn(ToolsHelper.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void btn_search_Computer_Click(object sender, EventArgs e)
        {
            string computerName = input_computerName_ad.Text.ToString();
            if (computerName.Length <= 0)
                MessageBox.Show("Não é possível procurar um computador com campo de pesquisa vazio",
                    "SDM - Pesquisa vazia!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (computerName.Length <= 3)
                MessageBox.Show("Precisa especificar ainda mais o nome do computador.\n\nEx: " + "\"MTZ\" - Unidade + " + "\"NTB\" - Tipo de computador",
                    "SDM - Especifique o nome!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                ADInfo computerInfo = AdHelper.searchComputer(computerName.ToUpper());

                LogHelper.doLog("\nComputer search performed\nCN= " + computerName, null);

                if (computerName.Where(c => char.IsNumber(c)).Count() <= 0)
                {
                    string number = AdHelper.getNextComputerName(computerName.ToUpper());

                    string suggestionMachine = string.Empty;
                    if (Int32.Parse(number) < 10) suggestionMachine = computerName + "0" + number;
                    else suggestionMachine = computerName + number;

                    LogHelper.doLog("\nComputer suggestion\nCN= " + suggestionMachine, null);

                    DialogResult result = MessageBox.Show($"{{ O computador com o seguinte nome \"{suggestionMachine}\" está disponível.\n" +
                        $"Gostaria de aceitar a sugestão? }}",
                    "SDM - Sugestão de nome!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        input_computerName_ad.Text = suggestionMachine;

                        LogHelper.doLog("\nSuggestion accepted\nCN= " + suggestionMachine, null);
                    }
                    else
                    {
                        LogHelper.doLog("\nSuggestion declined\nCN= " + suggestionMachine, null);

                        MessageBox.Show("Informe um número disponível para a criação da máquina",
                            "SDM - Aguardando o número!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    if (computerName.Where(c => char.IsNumber(c)).Count() > 0 && computerInfo != null)
                    {
                        txt_comp_desc.Text = AdHelper.buildOu(computerInfo);

                        MessageBox.Show("Maquina ja existe!!",
                            "SDM - Maquina encontrada!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Nome disponivel para a criacao",
                            "SDM - OK!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btn_create_Computer_Click(object sender, EventArgs e)
        {
            string COMPUTER_NAME = input_computerName_ad.Text.ToString().ToUpper();

            string Argument = $"&{{ New-ADComputer -Name '{COMPUTER_NAME}' -Path '{OU_PATH}' }}";

            if (COMPUTER_NAME.Length <= 0)
                MessageBox.Show("Não é possível criar um novo computador com campo de pesquisa vazio",
                    "SDM - Pesquisa vazia!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            if(COMPUTER_NAME.Length > 20)
                MessageBox.Show("O nome do computador não pode ter mais de 20 caracteres.",
                    "SDM - Caracteres máximos!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if(OU_PATH == null || OU_PATH.Length <= 3)
                MessageBox.Show("Selecione o caminho da UO",
                    "SDM - UO não selecionada!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                LogHelper.doLog("\nRequest to create a new computer\nCN= " + COMPUTER_NAME +
                    "\nOU= " + OU_PATH + "\n", null);

                ADInfo computerInfo = AdHelper.searchComputer(COMPUTER_NAME);
                if(computerInfo != null)
                {
                    LogHelper.doLog("\nComputer already exists\nCN= " + COMPUTER_NAME, null);

                    MessageBox.Show("O computador informado já existe!!",
                        "SDM - Já existe!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    LogHelper.doLog("\nRunning create new computer\nCN= " + COMPUTER_NAME +
                    "\nOU= " + OU_PATH + "\n", null);

                    Process process = PowerShellHelper.executeCommand(Argument, true);

                    var command_result = process.StandardError.ReadToEnd();
                    if (command_result == null || command_result == "")
                    {
                        LogHelper.doLog("\nComputer created successfully", null);

                        AdHelper.requestUpdateBaseFile();

                        MessageBox.Show("Máquina criada com sucesso\n\nSe você realizar a pesquisa novamente e parecer que ela não foi movida," +
                         " isso acontece porque o arquivo que o aplicativo usa ainda não foi atualizado, mas o computador foi criado.!",
                            "SDM - Sucessi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        LogHelper.doLog("\nError creating a new computer\n\n" + command_result, ErrorHelper.CREATING_NEW_COMPUTER_AD);

                        MessageBox.Show(command_result, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void input_computerName_ad_TextChanged(object sender, EventArgs e)
        {
            input_computerName_ad.Text = string.Concat(input_computerName_ad.Text.Where(char.IsLetterOrDigit));

            ToolsHelper.convertToUpter(sender);

            string COMPUTER_NAME = input_computerName_ad.Text.ToString();
            txt_comp_desc.Text = "Typing: " + COMPUTER_NAME;

            if (COMPUTER_NAME.Length <= 0) txt_comp_desc.Text = "Waiting...";
        }

        void updateOuPath(string ou_get)
        {
            OU_PATH = ou_get;
            txt_create_in.Text = "Criar em: " + OU_PATH.Split(',')[0];
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        private void header_panel_newComp_ad_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ToolsHelper.ReleaseCapture();
                ToolsHelper.SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void txt_header_create_computer_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ToolsHelper.ReleaseCapture();
                ToolsHelper.SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        /// Close window click event
        private void close_btn_newComp_AD_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ou_wsus_win10_Click(object sender, EventArgs e)
        {
            updateOuPath(AdHelper.OU_WSUS_WIN10_MTZ);
        }

        private void btn_ou_mtz_note_Click(object sender, EventArgs e)
        {
            updateOuPath(AdHelper.OU_NOTEBOOK_MTZ);
        }

        private void btn_ou_mtz_dsk_Click(object sender, EventArgs e)
        {
            updateOuPath(AdHelper.OU_COMPUETRS_MTZ);
        }

        private void btn_ou_smt_note_Click(object sender, EventArgs e)
        {
            updateOuPath(AdHelper.OU_NTB_SMT);
        }

        private void btn_ou_smt_comp_Click(object sender, EventArgs e)
        {
            updateOuPath(AdHelper.OU_DSK_SMT);
        }

        private void btn_ou_mtz_ti_Click(object sender, EventArgs e)
        {
            updateOuPath(AdHelper.OU_NOTEBOOK_EMPREST);
        }
    }
}
