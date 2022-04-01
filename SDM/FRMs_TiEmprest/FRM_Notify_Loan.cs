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
using static SDM.DTOs.DTO_Loans;

namespace SDM.FRMs_TiEmprest
{
    public partial class FRM_Notify_Loan : Form
    {
        public FRM_Notify_Loan()
        {
            InitializeComponent();
        }

        private void btn_send_nofity_Click(object sender, EventArgs e)
        {
            string COMPUTER_NAME = input_computer_name.Text.ToString().ToUpper();
            string REQUEST_NUMBER = input_request_number.Text.ToString();
            string LOAN_DAYS = input_loan_days.Text.ToString();
            string USER_LOGIN = input_user_login.Text.ToString();
            string CONTACT_NUMBER = input_contact_number.Text.ToString();
            string BUY_REQUEST = input_buy_request.Text.ToString();
            string OBS = input_obs.Text.ToString();

            if (OBS == null) OBS = "";
            if (BUY_REQUEST == null) BUY_REQUEST = "";

            if (!isAllRequiredFields())
                MessageBox.Show("É necessário preencher todos os campos obrigatórios corretamente.\n\nOs compostos obrigatórios contêm *",
                    "SDM - Campos obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if(COMPUTER_NAME.Length < 6)
                    MessageBox.Show("Insira o nome da máquina corretamente!",
                        "SDM - Nome da maquina inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if(AdHelper.searchComputer(COMPUTER_NAME) == null)
                    MessageBox.Show("A máquina informada não existe!",
                        "SDM - Máquina inexistente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (int.Parse(LOAN_DAYS) > 31 && OBS.Length <= 0
                    && BUY_REQUEST.Length <= 0)
                    MessageBox.Show("Para empréstimos com duração superior a 31 dias, é necessário fornecer a requisição de compra ou uma observação",
                        "SDM - Tempo de empréstimo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    LogHelper.doLog("\nRegistering a new loan\n\n", null);
                    string mainPath = AppDomain.CurrentDomain.BaseDirectory + "AppAsset\\";

                    if (BUY_REQUEST == "") BUY_REQUEST = "0";

                    DTO_Loans newLoan = new DTO_Loans(COMPUTER_NAME, int.Parse(REQUEST_NUMBER),
                        long.Parse(LOAN_DAYS), USER_LOGIN, CONTACT_NUMBER, long.Parse(BUY_REQUEST), OBS,
                        Environment.UserName, DateTime.Now.ToString("yyyy-MM-dd h:mm:ss tt"));

                    List<DTO_Loans> allLoan = TiEmprestHelper.VerifyCurrentFile();
                    allLoan.Add(newLoan);

                    Directory.CreateDirectory(Path.Combine(mainPath, "TIEMPREST"));

                    Directory.CreateDirectory(Path.Combine(mainPath, "TIEMPREST\\Notify"));

                    var jsonData = JsonConvert.SerializeObject(allLoan);

                    File.WriteAllText(mainPath + "TIEMPREST\\Notify\\" + ToolsHelper.NOTIFY_LOAN_FILE_NAME, jsonData);

                    MessageBox.Show("Empréstimo registrado com sucesso!!\n\n" +
                        "Por favor, considere notificar o responsavel pelos empréstimos sobre o empréstimo feito, pois esta operação está armazenando apenas um dado por vez",
                        "SDM - Empréstimo registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

            }
        }

        bool isAllRequiredFields()
        {
            string COMPUTER_NAME = input_computer_name.Text.ToString();
            string LOAN_DAYS = input_loan_days.Text.ToString();
            string USER_LOGIN = input_user_login.Text.ToString();
            string CONTACT_NUMBER = input_contact_number.Text.ToString();
            return COMPUTER_NAME != null && COMPUTER_NAME.Length > 0 &&
                LOAN_DAYS != null && LOAN_DAYS.Length > 0 &&
                USER_LOGIN != null && USER_LOGIN.Length > 2 &&
            CONTACT_NUMBER != null && CONTACT_NUMBER.Length > 3;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        private void header_panel_MoveComp_ad_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ToolsHelper.ReleaseCapture();
                ToolsHelper.SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
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

        private void input_loan_days_KeyPress(object sender, KeyPressEventArgs e)
        {
            validateJustNumber(sender, e);
        }
        private void input_request_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            validateJustNumber(sender, e);
        }
        private void input_buy_request_KeyPress(object sender, KeyPressEventArgs e)
        {
            validateJustNumber(sender, e);
        }

        void validateJustNumber(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void input_computer_name_TextChanged(object sender, EventArgs e)
        {
            ToolsHelper.convertToUpter(sender);
        }
    }
}