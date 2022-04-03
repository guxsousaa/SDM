using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDM.FRMs_TiEmprest.Dialogs
{
    public partial class FRM_Notify_Options : Form
    {
        public FRM_Notify_Options()
        {
            InitializeComponent();

            btn_return_loan.Visible = false;
        }

        private void btn_new_loan_Click(object sender, EventArgs e)
        {

            this.Hide();
            MessageBox.Show("Esta ferramenta ainda está em teste, qualquer dúvida entre em contato com o Administrador.\n\n" +
                "Por favor, considere notificar o responsavel pelos emprestimos sobre o empréstimo feito, pois esta operação está armazenando apenas um dado por vez",
                "SDM - Ferramenta em teste", MessageBoxButtons.OK, MessageBoxIcon.Information);

            new FRM_Notify_Loan().ShowDialog();
        }

        private void btn_return_loan_Click(object sender, EventArgs e)
        {

            this.Hide();
            MessageBox.Show("Esta ferramenta ainda está em desenvolvimento",
                "SDM - Ferramenta em desenvolvimento", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //new FRM_ReturnLoan().ShowDialog();
        }
    }
}
