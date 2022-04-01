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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDM.FRMs_TiEmprest
{
    public partial class FRM_NewLoans : Form
    {
        public List<DTO_Loans> loans = null;
        string mainPath = AppDomain.CurrentDomain.BaseDirectory + "AppAsset\\";

        public FRM_NewLoans()
        {
            InitializeComponent();

            loans = TiEmprestHelper.VerifyCurrentFile();
            this.loans_dataView.DataSource = loans;

            UpdateSelected();
        }

        private void loans_dataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateSelected();
        }

        int SelectedRowPos = 0;
        void UpdateSelected()
        {
            if (loans_dataView != null && loans_dataView.Rows.Count > 0 && loans_dataView.CurrentCell !=  null) 
                SelectedRowPos = loans_dataView.CurrentCell.RowIndex;

            if (loans.ElementAtOrDefault(SelectedRowPos) != null)
            {
                if (loans != null && loans[SelectedRowPos] != null)
                {
                    txt_machine_name.Text = loans[SelectedRowPos].computer_name.ToString();
                    txt_request_number.Text = loans[SelectedRowPos].request_number.ToString();
                    txt_loan_days.Text = loans[SelectedRowPos].loan_days.ToString();
                    txt_user_login.Text = loans[SelectedRowPos].user_login.ToString();
                    txt_contact_number.Text = loans[SelectedRowPos].contact_number.ToString();
                    txt_buy_request.Text = loans[SelectedRowPos].buy_request.ToString();
                    txt_obs.Text = loans[SelectedRowPos].obs.ToString();
                    txt_loan_by.Text = loans[SelectedRowPos].loan_by.ToString();
                    txt_date_and_time.Text = loans[SelectedRowPos].date_time.ToString();
                }
            }
            else
            {
                this.Hide();

                MessageBox.Show("Não há mais notificações de empréstimo para verificar", "SDM - Sem Novos Empréstimos",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_loan_accounted_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Você está prestes a excluir a notificação de empréstimo da máquina " 
                + loans[SelectedRowPos].computer_name.ToString() + ", você realmente contabilizou esse empréstimo no planilha de empréstimos?",
                "SDM - Empréstimo: " + loans[SelectedRowPos].computer_name.ToString(), MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Cursor.Current = Cursors.WaitCursor;

                loans.RemoveAt(SelectedRowPos);

                this.loans_dataView.DataSource = null;
                this.loans_dataView.DataSource = loans;

                var jsonData = JsonConvert.SerializeObject(loans);

                File.WriteAllText(mainPath + "TIEMPREST\\Notify\\" + ToolsHelper.NOTIFY_LOAN_FILE_NAME, jsonData);

                Thread.Sleep(300);

                UpdateSelected();

                Cursor.Current = Cursors.Default;
            }
        }

        private void loans_dataView_MouseDown(object sender, MouseEventArgs e)
        {
            UpdateSelected();
        }
    }
}
