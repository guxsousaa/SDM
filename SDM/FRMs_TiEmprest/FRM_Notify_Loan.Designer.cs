namespace SDM.FRMs_TiEmprest
{
    partial class FRM_Notify_Loan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Notify_Loan));
            this.header_panel_MoveComp_ad = new System.Windows.Forms.Panel();
            this.txt_header_title_moveComp_ad = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.PictureBox();
            this.txt_computer_name = new System.Windows.Forms.Label();
            this.input_computer_name = new System.Windows.Forms.TextBox();
            this.input_request_number = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.input_loan_days = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.input_user_login = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.input_contact_number = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.input_buy_request = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.input_obs = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_send_nofity = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel_container_notes = new System.Windows.Forms.Panel();
            this.txt_desc_note = new System.Windows.Forms.Label();
            this.txt_header_notes = new System.Windows.Forms.Label();
            this.header_panel_MoveComp_ad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).BeginInit();
            this.panel_container_notes.SuspendLayout();
            this.SuspendLayout();
            // 
            // header_panel_MoveComp_ad
            // 
            this.header_panel_MoveComp_ad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.header_panel_MoveComp_ad.Controls.Add(this.txt_header_title_moveComp_ad);
            this.header_panel_MoveComp_ad.Controls.Add(this.btn_close);
            this.header_panel_MoveComp_ad.Dock = System.Windows.Forms.DockStyle.Top;
            this.header_panel_MoveComp_ad.Location = new System.Drawing.Point(0, 0);
            this.header_panel_MoveComp_ad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.header_panel_MoveComp_ad.Name = "header_panel_MoveComp_ad";
            this.header_panel_MoveComp_ad.Size = new System.Drawing.Size(505, 30);
            this.header_panel_MoveComp_ad.TabIndex = 6;
            this.header_panel_MoveComp_ad.MouseDown += new System.Windows.Forms.MouseEventHandler(this.header_panel_MoveComp_ad_MouseDown);
            // 
            // txt_header_title_moveComp_ad
            // 
            this.txt_header_title_moveComp_ad.Dock = System.Windows.Forms.DockStyle.Left;
            this.txt_header_title_moveComp_ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_header_title_moveComp_ad.ForeColor = System.Drawing.Color.White;
            this.txt_header_title_moveComp_ad.Location = new System.Drawing.Point(0, 0);
            this.txt_header_title_moveComp_ad.Name = "txt_header_title_moveComp_ad";
            this.txt_header_title_moveComp_ad.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.txt_header_title_moveComp_ad.Size = new System.Drawing.Size(321, 30);
            this.txt_header_title_moveComp_ad.TabIndex = 3;
            this.txt_header_title_moveComp_ad.Text = "SDM - Notificar Empréstimo";
            this.txt_header_title_moveComp_ad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_header_title_moveComp_ad.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txt_header_title_moveComp_ad_MouseDown);
            // 
            // btn_close
            // 
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.Location = new System.Drawing.Point(474, -2);
            this.btn_close.Margin = new System.Windows.Forms.Padding(3, 2, 11, 2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(20, 30);
            this.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_close.TabIndex = 1;
            this.btn_close.TabStop = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // txt_computer_name
            // 
            this.txt_computer_name.AutoSize = true;
            this.txt_computer_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_computer_name.ForeColor = System.Drawing.Color.White;
            this.txt_computer_name.Location = new System.Drawing.Point(12, 50);
            this.txt_computer_name.Name = "txt_computer_name";
            this.txt_computer_name.Size = new System.Drawing.Size(150, 20);
            this.txt_computer_name.TabIndex = 7;
            this.txt_computer_name.Text = "*Nome da maquina";
            // 
            // input_computer_name
            // 
            this.input_computer_name.Location = new System.Drawing.Point(16, 74);
            this.input_computer_name.MaxLength = 20;
            this.input_computer_name.Name = "input_computer_name";
            this.input_computer_name.Size = new System.Drawing.Size(214, 22);
            this.input_computer_name.TabIndex = 1;
            this.input_computer_name.TextChanged += new System.EventHandler(this.input_computer_name_TextChanged);
            // 
            // input_request_number
            // 
            this.input_request_number.Location = new System.Drawing.Point(16, 134);
            this.input_request_number.Name = "input_request_number";
            this.input_request_number.Size = new System.Drawing.Size(214, 22);
            this.input_request_number.TabIndex = 2;
            this.input_request_number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.input_request_number_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Numero do chamado";
            // 
            // input_loan_days
            // 
            this.input_loan_days.Location = new System.Drawing.Point(16, 195);
            this.input_loan_days.Name = "input_loan_days";
            this.input_loan_days.Size = new System.Drawing.Size(214, 22);
            this.input_loan_days.TabIndex = 3;
            this.input_loan_days.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.input_loan_days_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "*Quantidade de dias";
            // 
            // input_user_login
            // 
            this.input_user_login.Location = new System.Drawing.Point(16, 259);
            this.input_user_login.Name = "input_user_login";
            this.input_user_login.Size = new System.Drawing.Size(214, 22);
            this.input_user_login.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "*Login de rede do solicitante";
            // 
            // input_contact_number
            // 
            this.input_contact_number.Location = new System.Drawing.Point(16, 321);
            this.input_contact_number.Name = "input_contact_number";
            this.input_contact_number.Size = new System.Drawing.Size(214, 22);
            this.input_contact_number.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "*Numero para contato";
            // 
            // input_buy_request
            // 
            this.input_buy_request.Location = new System.Drawing.Point(16, 380);
            this.input_buy_request.Name = "input_buy_request";
            this.input_buy_request.Size = new System.Drawing.Size(214, 22);
            this.input_buy_request.TabIndex = 6;
            this.input_buy_request.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.input_buy_request_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Requisição de compra";
            // 
            // input_obs
            // 
            this.input_obs.Location = new System.Drawing.Point(240, 74);
            this.input_obs.MaxLength = 155;
            this.input_obs.Multiline = true;
            this.input_obs.Name = "input_obs";
            this.input_obs.Size = new System.Drawing.Size(254, 69);
            this.input_obs.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(236, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Observação";
            // 
            // btn_send_nofity
            // 
            this.btn_send_nofity.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_send_nofity.FlatAppearance.BorderSize = 0;
            this.btn_send_nofity.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_send_nofity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_send_nofity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_send_nofity.Location = new System.Drawing.Point(242, 150);
            this.btn_send_nofity.Margin = new System.Windows.Forms.Padding(4);
            this.btn_send_nofity.Name = "btn_send_nofity";
            this.btn_send_nofity.Size = new System.Drawing.Size(252, 41);
            this.btn_send_nofity.TabIndex = 8;
            this.btn_send_nofity.Text = "Enviar";
            this.btn_send_nofity.UseVisualStyleBackColor = true;
            this.btn_send_nofity.Click += new System.EventHandler(this.btn_send_nofity_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.Location = new System.Drawing.Point(266, 235);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 46);
            this.button2.TabIndex = 9;
            this.button2.Text = "Verificar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel_container_notes
            // 
            this.panel_container_notes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(71)))), ((int)(((byte)(93)))));
            this.panel_container_notes.Controls.Add(this.txt_desc_note);
            this.panel_container_notes.Controls.Add(this.txt_header_notes);
            this.panel_container_notes.Location = new System.Drawing.Point(266, 288);
            this.panel_container_notes.Name = "panel_container_notes";
            this.panel_container_notes.Size = new System.Drawing.Size(226, 116);
            this.panel_container_notes.TabIndex = 21;
            // 
            // txt_desc_note
            // 
            this.txt_desc_note.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_desc_note.Location = new System.Drawing.Point(17, 43);
            this.txt_desc_note.Name = "txt_desc_note";
            this.txt_desc_note.Size = new System.Drawing.Size(194, 58);
            this.txt_desc_note.TabIndex = 4;
            this.txt_desc_note.Text = "A verificação do usuário não está funcionando no momento.";
            // 
            // txt_header_notes
            // 
            this.txt_header_notes.AutoSize = true;
            this.txt_header_notes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_header_notes.ForeColor = System.Drawing.Color.White;
            this.txt_header_notes.Location = new System.Drawing.Point(15, 16);
            this.txt_header_notes.Name = "txt_header_notes";
            this.txt_header_notes.Size = new System.Drawing.Size(63, 25);
            this.txt_header_notes.TabIndex = 1;
            this.txt_header_notes.Text = "Notas";
            // 
            // FRM_Notify_Loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(505, 416);
            this.Controls.Add(this.panel_container_notes);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_send_nofity);
            this.Controls.Add(this.input_obs);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.input_buy_request);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.input_contact_number);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.input_user_login);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.input_loan_days);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.input_request_number);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input_computer_name);
            this.Controls.Add(this.txt_computer_name);
            this.Controls.Add(this.header_panel_MoveComp_ad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRM_Notify_Loan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notify Loan";
            this.header_panel_MoveComp_ad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).EndInit();
            this.panel_container_notes.ResumeLayout(false);
            this.panel_container_notes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel header_panel_MoveComp_ad;
        private System.Windows.Forms.Label txt_header_title_moveComp_ad;
        private System.Windows.Forms.PictureBox btn_close;
        private System.Windows.Forms.Label txt_computer_name;
        private System.Windows.Forms.TextBox input_computer_name;
        private System.Windows.Forms.TextBox input_request_number;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox input_loan_days;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox input_user_login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox input_contact_number;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox input_buy_request;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox input_obs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_send_nofity;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel_container_notes;
        private System.Windows.Forms.Label txt_desc_note;
        private System.Windows.Forms.Label txt_header_notes;
    }
}