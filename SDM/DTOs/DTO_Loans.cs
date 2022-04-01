using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDM.DTOs
{
    public class DTO_Loans
    {

        [DisplayName("É devolução")]
        public bool isReturn { get; set; }

        [DisplayName("Nome da Maquina")]
        public string computer_name { get; set; }

        [DisplayName("Número do Chamado")]
        public int request_number { get; set; }

        [DisplayName("Dias de Empréstimo")]
        public long loan_days { get; set; }

        [DisplayName("Login do Usuário")]
        public string user_login { get; set; }

        [DisplayName("Numéro de Contato")]
        public string contact_number { get; set; }

        [DisplayName("Requisição de compra")]
        public long buy_request { get; set; }

        [DisplayName("Observação")]
        public string obs { get; set; }

        [DisplayName("Emprestado por")]
        public string loan_by { get; set; }

        [DisplayName("Data e Hora")]
        public string date_time { get; set; }


        public DTO_Loans(string computer_name, int request_number, long loan_days,
            string user_login, string contact_number, long buy_request, string obs, string loan_by, string date_time)
        {
            this.computer_name = computer_name;
            this.request_number = request_number;
            this.loan_days = loan_days;
            this.user_login = user_login;
            this.contact_number = contact_number;
            this.buy_request = buy_request;
            this.obs = obs;
            this.loan_by = loan_by;
            this.date_time = date_time;
        }


        public DTO_Loans(string computer_name, string user_login, string contact_number,
            string obs, string date_time)
        {
            this.computer_name = computer_name;
            this.user_login = user_login;
            this.date_time = date_time;
            this.contact_number = contact_number;
            this.obs = obs;
        }

        public DTO_Loans() { }
    }
}
