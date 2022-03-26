namespace SDM.FRMs_TiEmprest
{
    partial class FRM_NewLoans
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_NewLoans));
            this.loans_dataView = new System.Windows.Forms.DataGridView();
            this.panel_container_loans_list = new System.Windows.Forms.Panel();
            this.panel_loan_actions = new System.Windows.Forms.Panel();
            this.txt_date_and_time = new System.Windows.Forms.Label();
            this.txt_loan_by = new System.Windows.Forms.Label();
            this.txt_obs = new System.Windows.Forms.Label();
            this.txt_buy_request = new System.Windows.Forms.Label();
            this.txt_contact_number = new System.Windows.Forms.Label();
            this.txt_user_login = new System.Windows.Forms.Label();
            this.txt_loan_days = new System.Windows.Forms.Label();
            this.txt_request_number = new System.Windows.Forms.Label();
            this.txt_machine_name = new System.Windows.Forms.Label();
            this.title_date_and_time = new System.Windows.Forms.Label();
            this.loan_by = new System.Windows.Forms.Label();
            this.title_obs = new System.Windows.Forms.Label();
            this.title_loan_days = new System.Windows.Forms.Label();
            this.title_buy_request = new System.Windows.Forms.Label();
            this.title_contact_number = new System.Windows.Forms.Label();
            this.title_user_login = new System.Windows.Forms.Label();
            this.title_request_number = new System.Windows.Forms.Label();
            this.title_machine_name = new System.Windows.Forms.Label();
            this.btn_loan_accounted = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.loans_dataView)).BeginInit();
            this.panel_container_loans_list.SuspendLayout();
            this.panel_loan_actions.SuspendLayout();
            this.SuspendLayout();
            // 
            // loans_dataView
            // 
            this.loans_dataView.AllowUserToAddRows = false;
            this.loans_dataView.AllowUserToDeleteRows = false;
            this.loans_dataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.loans_dataView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.loans_dataView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.loans_dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loans_dataView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loans_dataView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.loans_dataView.Location = new System.Drawing.Point(0, 0);
            this.loans_dataView.MultiSelect = false;
            this.loans_dataView.Name = "loans_dataView";
            this.loans_dataView.ReadOnly = true;
            this.loans_dataView.RowHeadersWidth = 51;
            this.loans_dataView.RowTemplate.Height = 24;
            this.loans_dataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.loans_dataView.Size = new System.Drawing.Size(1182, 200);
            this.loans_dataView.TabIndex = 0;
            this.loans_dataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.loans_dataView_CellContentClick);
            this.loans_dataView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.loans_dataView_MouseDown);
            // 
            // panel_container_loans_list
            // 
            this.panel_container_loans_list.AutoSize = true;
            this.panel_container_loans_list.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_container_loans_list.Controls.Add(this.loans_dataView);
            this.panel_container_loans_list.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_container_loans_list.Location = new System.Drawing.Point(0, 0);
            this.panel_container_loans_list.MaximumSize = new System.Drawing.Size(0, 400);
            this.panel_container_loans_list.MinimumSize = new System.Drawing.Size(0, 200);
            this.panel_container_loans_list.Name = "panel_container_loans_list";
            this.panel_container_loans_list.Size = new System.Drawing.Size(1182, 200);
            this.panel_container_loans_list.TabIndex = 1;
            // 
            // panel_loan_actions
            // 
            this.panel_loan_actions.AutoSize = true;
            this.panel_loan_actions.Controls.Add(this.btn_loan_accounted);
            this.panel_loan_actions.Controls.Add(this.txt_date_and_time);
            this.panel_loan_actions.Controls.Add(this.txt_loan_by);
            this.panel_loan_actions.Controls.Add(this.txt_obs);
            this.panel_loan_actions.Controls.Add(this.txt_buy_request);
            this.panel_loan_actions.Controls.Add(this.txt_contact_number);
            this.panel_loan_actions.Controls.Add(this.txt_user_login);
            this.panel_loan_actions.Controls.Add(this.txt_loan_days);
            this.panel_loan_actions.Controls.Add(this.txt_request_number);
            this.panel_loan_actions.Controls.Add(this.txt_machine_name);
            this.panel_loan_actions.Controls.Add(this.title_date_and_time);
            this.panel_loan_actions.Controls.Add(this.loan_by);
            this.panel_loan_actions.Controls.Add(this.title_obs);
            this.panel_loan_actions.Controls.Add(this.title_loan_days);
            this.panel_loan_actions.Controls.Add(this.title_buy_request);
            this.panel_loan_actions.Controls.Add(this.title_contact_number);
            this.panel_loan_actions.Controls.Add(this.title_user_login);
            this.panel_loan_actions.Controls.Add(this.title_request_number);
            this.panel_loan_actions.Controls.Add(this.title_machine_name);
            this.panel_loan_actions.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_loan_actions.Location = new System.Drawing.Point(0, 200);
            this.panel_loan_actions.Name = "panel_loan_actions";
            this.panel_loan_actions.Size = new System.Drawing.Size(357, 353);
            this.panel_loan_actions.TabIndex = 2;
            // 
            // txt_date_and_time
            // 
            this.txt_date_and_time.AutoSize = true;
            this.txt_date_and_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_date_and_time.ForeColor = System.Drawing.Color.White;
            this.txt_date_and_time.Location = new System.Drawing.Point(194, 239);
            this.txt_date_and_time.Name = "txt_date_and_time";
            this.txt_date_and_time.Size = new System.Drawing.Size(92, 18);
            this.txt_date_and_time.TabIndex = 17;
            this.txt_date_and_time.Text = "Data e Hora:";
            // 
            // txt_loan_by
            // 
            this.txt_loan_by.AutoSize = true;
            this.txt_loan_by.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_loan_by.ForeColor = System.Drawing.Color.White;
            this.txt_loan_by.Location = new System.Drawing.Point(193, 212);
            this.txt_loan_by.Name = "txt_loan_by";
            this.txt_loan_by.Size = new System.Drawing.Size(119, 18);
            this.txt_loan_by.TabIndex = 16;
            this.txt_loan_by.Text = "Emprestado por:";
            // 
            // txt_obs
            // 
            this.txt_obs.AutoSize = true;
            this.txt_obs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_obs.ForeColor = System.Drawing.Color.White;
            this.txt_obs.Location = new System.Drawing.Point(193, 184);
            this.txt_obs.Name = "txt_obs";
            this.txt_obs.Size = new System.Drawing.Size(93, 18);
            this.txt_obs.TabIndex = 15;
            this.txt_obs.Text = "Observação:";
            // 
            // txt_buy_request
            // 
            this.txt_buy_request.AutoSize = true;
            this.txt_buy_request.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buy_request.ForeColor = System.Drawing.Color.White;
            this.txt_buy_request.Location = new System.Drawing.Point(193, 157);
            this.txt_buy_request.Name = "txt_buy_request";
            this.txt_buy_request.Size = new System.Drawing.Size(161, 18);
            this.txt_buy_request.TabIndex = 14;
            this.txt_buy_request.Text = "Requisição de compra:";
            // 
            // txt_contact_number
            // 
            this.txt_contact_number.AutoSize = true;
            this.txt_contact_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contact_number.ForeColor = System.Drawing.Color.White;
            this.txt_contact_number.Location = new System.Drawing.Point(193, 130);
            this.txt_contact_number.Name = "txt_contact_number";
            this.txt_contact_number.Size = new System.Drawing.Size(143, 18);
            this.txt_contact_number.TabIndex = 13;
            this.txt_contact_number.Text = "Numéro de Contato:";
            // 
            // txt_user_login
            // 
            this.txt_user_login.AutoSize = true;
            this.txt_user_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user_login.ForeColor = System.Drawing.Color.White;
            this.txt_user_login.Location = new System.Drawing.Point(193, 103);
            this.txt_user_login.Name = "txt_user_login";
            this.txt_user_login.Size = new System.Drawing.Size(125, 18);
            this.txt_user_login.TabIndex = 12;
            this.txt_user_login.Text = "Login do Usuário:";
            // 
            // txt_loan_days
            // 
            this.txt_loan_days.AutoSize = true;
            this.txt_loan_days.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_loan_days.ForeColor = System.Drawing.Color.White;
            this.txt_loan_days.Location = new System.Drawing.Point(193, 76);
            this.txt_loan_days.Name = "txt_loan_days";
            this.txt_loan_days.Size = new System.Drawing.Size(147, 18);
            this.txt_loan_days.TabIndex = 11;
            this.txt_loan_days.Text = "Dias de Empréstimo:";
            // 
            // txt_request_number
            // 
            this.txt_request_number.AutoSize = true;
            this.txt_request_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_request_number.ForeColor = System.Drawing.Color.White;
            this.txt_request_number.Location = new System.Drawing.Point(193, 48);
            this.txt_request_number.Name = "txt_request_number";
            this.txt_request_number.Size = new System.Drawing.Size(156, 18);
            this.txt_request_number.TabIndex = 10;
            this.txt_request_number.Text = "Número do Chamado:";
            // 
            // txt_machine_name
            // 
            this.txt_machine_name.AutoSize = true;
            this.txt_machine_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_machine_name.ForeColor = System.Drawing.Color.White;
            this.txt_machine_name.Location = new System.Drawing.Point(193, 21);
            this.txt_machine_name.Name = "txt_machine_name";
            this.txt_machine_name.Size = new System.Drawing.Size(129, 18);
            this.txt_machine_name.TabIndex = 9;
            this.txt_machine_name.Text = "Nome da maquina";
            // 
            // title_date_and_time
            // 
            this.title_date_and_time.AutoSize = true;
            this.title_date_and_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_date_and_time.ForeColor = System.Drawing.Color.LightGray;
            this.title_date_and_time.Location = new System.Drawing.Point(12, 239);
            this.title_date_and_time.Name = "title_date_and_time";
            this.title_date_and_time.Size = new System.Drawing.Size(92, 18);
            this.title_date_and_time.TabIndex = 8;
            this.title_date_and_time.Text = "Data e Hora:";
            // 
            // loan_by
            // 
            this.loan_by.AutoSize = true;
            this.loan_by.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loan_by.ForeColor = System.Drawing.Color.LightGray;
            this.loan_by.Location = new System.Drawing.Point(12, 212);
            this.loan_by.Name = "loan_by";
            this.loan_by.Size = new System.Drawing.Size(119, 18);
            this.loan_by.TabIndex = 7;
            this.loan_by.Text = "Emprestado por:";
            // 
            // title_obs
            // 
            this.title_obs.AutoSize = true;
            this.title_obs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_obs.ForeColor = System.Drawing.Color.LightGray;
            this.title_obs.Location = new System.Drawing.Point(12, 184);
            this.title_obs.Name = "title_obs";
            this.title_obs.Size = new System.Drawing.Size(93, 18);
            this.title_obs.TabIndex = 6;
            this.title_obs.Text = "Observação:";
            // 
            // title_loan_days
            // 
            this.title_loan_days.AutoSize = true;
            this.title_loan_days.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_loan_days.ForeColor = System.Drawing.Color.LightGray;
            this.title_loan_days.Location = new System.Drawing.Point(12, 76);
            this.title_loan_days.Name = "title_loan_days";
            this.title_loan_days.Size = new System.Drawing.Size(147, 18);
            this.title_loan_days.TabIndex = 5;
            this.title_loan_days.Text = "Dias de Empréstimo:";
            // 
            // title_buy_request
            // 
            this.title_buy_request.AutoSize = true;
            this.title_buy_request.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_buy_request.ForeColor = System.Drawing.Color.LightGray;
            this.title_buy_request.Location = new System.Drawing.Point(12, 157);
            this.title_buy_request.Name = "title_buy_request";
            this.title_buy_request.Size = new System.Drawing.Size(161, 18);
            this.title_buy_request.TabIndex = 4;
            this.title_buy_request.Text = "Requisição de compra:";
            // 
            // title_contact_number
            // 
            this.title_contact_number.AutoSize = true;
            this.title_contact_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_contact_number.ForeColor = System.Drawing.Color.LightGray;
            this.title_contact_number.Location = new System.Drawing.Point(12, 130);
            this.title_contact_number.Name = "title_contact_number";
            this.title_contact_number.Size = new System.Drawing.Size(143, 18);
            this.title_contact_number.TabIndex = 3;
            this.title_contact_number.Text = "Numéro de Contato:";
            // 
            // title_user_login
            // 
            this.title_user_login.AutoSize = true;
            this.title_user_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_user_login.ForeColor = System.Drawing.Color.LightGray;
            this.title_user_login.Location = new System.Drawing.Point(12, 103);
            this.title_user_login.Name = "title_user_login";
            this.title_user_login.Size = new System.Drawing.Size(125, 18);
            this.title_user_login.TabIndex = 2;
            this.title_user_login.Text = "Login do Usuário:";
            // 
            // title_request_number
            // 
            this.title_request_number.AutoSize = true;
            this.title_request_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_request_number.ForeColor = System.Drawing.Color.LightGray;
            this.title_request_number.Location = new System.Drawing.Point(12, 48);
            this.title_request_number.Name = "title_request_number";
            this.title_request_number.Size = new System.Drawing.Size(156, 18);
            this.title_request_number.TabIndex = 1;
            this.title_request_number.Text = "Número do Chamado:";
            // 
            // title_machine_name
            // 
            this.title_machine_name.AutoSize = true;
            this.title_machine_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_machine_name.ForeColor = System.Drawing.Color.LightGray;
            this.title_machine_name.Location = new System.Drawing.Point(12, 21);
            this.title_machine_name.Name = "title_machine_name";
            this.title_machine_name.Size = new System.Drawing.Size(133, 18);
            this.title_machine_name.TabIndex = 0;
            this.title_machine_name.Text = "Nome da maquina:";
            // 
            // btn_loan_accounted
            // 
            this.btn_loan_accounted.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_loan_accounted.FlatAppearance.BorderSize = 0;
            this.btn_loan_accounted.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_loan_accounted.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_loan_accounted.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_loan_accounted.Location = new System.Drawing.Point(15, 279);
            this.btn_loan_accounted.Margin = new System.Windows.Forms.Padding(4);
            this.btn_loan_accounted.Name = "btn_loan_accounted";
            this.btn_loan_accounted.Size = new System.Drawing.Size(334, 41);
            this.btn_loan_accounted.TabIndex = 18;
            this.btn_loan_accounted.Text = "Empréstimo contabilizado";
            this.btn_loan_accounted.UseVisualStyleBackColor = true;
            this.btn_loan_accounted.Click += new System.EventHandler(this.btn_loan_accounted_Click);
            // 
            // FRM_NewLoans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.panel_loan_actions);
            this.Controls.Add(this.panel_container_loans_list);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRM_NewLoans";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novos Emprestimos";
            ((System.ComponentModel.ISupportInitialize)(this.loans_dataView)).EndInit();
            this.panel_container_loans_list.ResumeLayout(false);
            this.panel_loan_actions.ResumeLayout(false);
            this.panel_loan_actions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView loans_dataView;
        private System.Windows.Forms.Panel panel_container_loans_list;
        private System.Windows.Forms.Panel panel_loan_actions;
        private System.Windows.Forms.Label title_machine_name;
        private System.Windows.Forms.Label title_loan_days;
        private System.Windows.Forms.Label title_buy_request;
        private System.Windows.Forms.Label title_contact_number;
        private System.Windows.Forms.Label title_user_login;
        private System.Windows.Forms.Label title_request_number;
        private System.Windows.Forms.Label title_obs;
        private System.Windows.Forms.Label title_date_and_time;
        private System.Windows.Forms.Label loan_by;
        private System.Windows.Forms.Label txt_date_and_time;
        private System.Windows.Forms.Label txt_loan_by;
        private System.Windows.Forms.Label txt_obs;
        private System.Windows.Forms.Label txt_buy_request;
        private System.Windows.Forms.Label txt_contact_number;
        private System.Windows.Forms.Label txt_user_login;
        private System.Windows.Forms.Label txt_loan_days;
        private System.Windows.Forms.Label txt_request_number;
        private System.Windows.Forms.Label txt_machine_name;
        private System.Windows.Forms.Button btn_loan_accounted;
    }
}