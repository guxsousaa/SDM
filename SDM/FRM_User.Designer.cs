namespace SDM
{
    partial class FRM_User
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
            this.panel_container = new System.Windows.Forms.Panel();
            this.txt_network_login = new System.Windows.Forms.Label();
            this.input_user = new System.Windows.Forms.TextBox();
            this.btn_search_user = new System.Windows.Forms.Button();
            this.panel_top_container_ad = new System.Windows.Forms.Panel();
            this.txt_header_title_users = new System.Windows.Forms.Label();
            this.txt_result_search = new System.Windows.Forms.Label();
            this.panel_container.SuspendLayout();
            this.panel_top_container_ad.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_container
            // 
            this.panel_container.AutoSize = true;
            this.panel_container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(71)))), ((int)(((byte)(93)))));
            this.panel_container.Controls.Add(this.input_user);
            this.panel_container.Controls.Add(this.txt_network_login);
            this.panel_container.Controls.Add(this.btn_search_user);
            this.panel_container.Location = new System.Drawing.Point(18, 64);
            this.panel_container.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_container.MinimumSize = new System.Drawing.Size(400, 90);
            this.panel_container.Name = "panel_container";
            this.panel_container.Padding = new System.Windows.Forms.Padding(5);
            this.panel_container.Size = new System.Drawing.Size(434, 90);
            this.panel_container.TabIndex = 2;
            // 
            // txt_network_login
            // 
            this.txt_network_login.AutoSize = true;
            this.txt_network_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_network_login.ForeColor = System.Drawing.Color.White;
            this.txt_network_login.Location = new System.Drawing.Point(8, 10);
            this.txt_network_login.Name = "txt_network_login";
            this.txt_network_login.Size = new System.Drawing.Size(116, 20);
            this.txt_network_login.TabIndex = 3;
            this.txt_network_login.Text = "Login de rede:";
            // 
            // input_user
            // 
            this.input_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_user.Location = new System.Drawing.Point(149, 7);
            this.input_user.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.input_user.Name = "input_user";
            this.input_user.Size = new System.Drawing.Size(275, 27);
            this.input_user.TabIndex = 1;
            this.input_user.KeyDown += new System.Windows.Forms.KeyEventHandler(this.input_user_KeyDown);
            // 
            // btn_search_user
            // 
            this.btn_search_user.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_search_user.FlatAppearance.BorderSize = 0;
            this.btn_search_user.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_search_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search_user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_search_user.Location = new System.Drawing.Point(12, 40);
            this.btn_search_user.Margin = new System.Windows.Forms.Padding(4);
            this.btn_search_user.Name = "btn_search_user";
            this.btn_search_user.Size = new System.Drawing.Size(412, 41);
            this.btn_search_user.TabIndex = 2;
            this.btn_search_user.Text = "Pesquisar usuário";
            this.btn_search_user.UseVisualStyleBackColor = true;
            this.btn_search_user.Click += new System.EventHandler(this.btn_search_user_Click);
            // 
            // panel_top_container_ad
            // 
            this.panel_top_container_ad.Controls.Add(this.txt_header_title_users);
            this.panel_top_container_ad.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top_container_ad.Location = new System.Drawing.Point(0, 0);
            this.panel_top_container_ad.Margin = new System.Windows.Forms.Padding(4);
            this.panel_top_container_ad.Name = "panel_top_container_ad";
            this.panel_top_container_ad.Size = new System.Drawing.Size(729, 58);
            this.panel_top_container_ad.TabIndex = 3;
            // 
            // txt_header_title_users
            // 
            this.txt_header_title_users.AutoSize = true;
            this.txt_header_title_users.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_header_title_users.ForeColor = System.Drawing.Color.White;
            this.txt_header_title_users.Location = new System.Drawing.Point(12, 9);
            this.txt_header_title_users.Name = "txt_header_title_users";
            this.txt_header_title_users.Size = new System.Drawing.Size(127, 32);
            this.txt_header_title_users.TabIndex = 4;
            this.txt_header_title_users.Text = "Usuários";
            // 
            // txt_result_search
            // 
            this.txt_result_search.AutoSize = true;
            this.txt_result_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_result_search.ForeColor = System.Drawing.Color.White;
            this.txt_result_search.Location = new System.Drawing.Point(15, 165);
            this.txt_result_search.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_result_search.MinimumSize = new System.Drawing.Size(700, 0);
            this.txt_result_search.Name = "txt_result_search";
            this.txt_result_search.Size = new System.Drawing.Size(700, 18);
            this.txt_result_search.TabIndex = 4;
            this.txt_result_search.Text = "Aguardando busca";
            // 
            // FRM_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(729, 571);
            this.Controls.Add(this.txt_result_search);
            this.Controls.Add(this.panel_top_container_ad);
            this.Controls.Add(this.panel_container);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FRM_User";
            this.Text = "FRM_User";
            this.panel_container.ResumeLayout(false);
            this.panel_container.PerformLayout();
            this.panel_top_container_ad.ResumeLayout(false);
            this.panel_top_container_ad.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_container;
        private System.Windows.Forms.TextBox input_user;
        private System.Windows.Forms.Panel panel_top_container_ad;
        private System.Windows.Forms.Label txt_header_title_users;
        private System.Windows.Forms.Button btn_search_user;
        private System.Windows.Forms.Label txt_result_search;
        private System.Windows.Forms.Label txt_network_login;
    }
}