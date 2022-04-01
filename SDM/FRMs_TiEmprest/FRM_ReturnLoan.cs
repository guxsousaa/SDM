using Newtonsoft.Json;
using SDM.DTOs;
using SDM.Methods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDM.FRMs_TiEmprest
{
    public partial class FRM_ReturnLoan : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        public FRM_ReturnLoan()
        {
            InitializeComponent();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            //sendReturn();

            AdHelper.GetAllUsers(true);
        }

        void sendReturn()
        {
            string COMPUTER_NAME = txt_computer_name.Text;
            string USER_LOGIN = txt_user_login.Text;
            string CALL_REQUEST = txt_call_number.Text;
            string OBS = txt_obs.Text;
            string DATE_TIME = DateTime.Now.ToString();

            if (COMPUTER_NAME == null || COMPUTER_NAME.Length <= 5)
                MessageBox.Show("Insira o nome da máquina corretamente!",
                    "SDM - Nome da maquina inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (USER_LOGIN == null || USER_LOGIN.Length <= 3)
                MessageBox.Show("Insira o login do usuario corretamente!",
                    "SDM - Login do usuario inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (OBS == null || OBS.Length < 5)
                MessageBox.Show("Recomendado para inserir uma observação como \"Com carregador\"",
                    "SDM - Sem Observação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                LogHelper.doLog("\nRegistering a return loan\n\n", null);
                string mainPath = AppDomain.CurrentDomain.BaseDirectory + "AppAsset\\";

                DTO_Loans newLoan = new DTO_Loans(COMPUTER_NAME, USER_LOGIN,
                    CALL_REQUEST, OBS, DATE_TIME);

                List<DTO_Loans> allLoan = TiEmprestHelper.VerifyCurrentFile();
                allLoan.Add(newLoan);

                Directory.CreateDirectory(Path.Combine(mainPath, "TIEMPREST"));

                Directory.CreateDirectory(Path.Combine(mainPath, "TIEMPREST\\Notify"));

                var jsonData = JsonConvert.SerializeObject(allLoan);

                File.WriteAllText(mainPath + "TIEMPREST\\Notify\\" + ToolsHelper.RETURN_LOAN_FILE_NAME, jsonData);

                MessageBox.Show("Empréstimo registrado com sucesso!!\n\n" +
                    "Por favor, considere notificar o responsavel pelos empréstimos sobre o empréstimo feito, pois esta operação está armazenando apenas um dado por vez",
                    "SDM - Empréstimo registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void txt_header_title_moveComp_ad_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ToolsHelper.ReleaseCapture();
                ToolsHelper.SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void header_panel_MoveRetrunLoan_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                ToolsHelper.ReleaseCapture();
                ToolsHelper.SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void txt_computer_name_TextChanged(object sender, EventArgs e)
        {
            ToolsHelper.convertToUpter(sender);
        }
    }
}
