
namespace SDM
{
    partial class FRM_Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Settings));
            this.panel_win_btns_main = new System.Windows.Forms.Panel();
            this.panel_actions_btns = new System.Windows.Forms.Panel();
            this.minimize_btn = new System.Windows.Forms.PictureBox();
            this.close_btn = new System.Windows.Forms.PictureBox();
            this.txt_title_frm = new System.Windows.Forms.Label();
            this.btn_update_BaseComp = new System.Windows.Forms.Button();
            this.txt_lastUpdateTime_CompBase = new System.Windows.Forms.Label();
            this.txt_file_size = new System.Windows.Forms.Label();
            this.panel_container_main = new System.Windows.Forms.Panel();
            this.btn_manage_my_account = new System.Windows.Forms.Button();
            this.btn_verify_permissions = new System.Windows.Forms.Button();
            this.btn_users = new System.Windows.Forms.Button();
            this.txt_shortcuts_title = new System.Windows.Forms.Label();
            this.panel_container_base_comp = new System.Windows.Forms.Panel();
            this.panel_contaioner_base_info = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_app_version = new System.Windows.Forms.Label();
            this.lbl_Copyright = new System.Windows.Forms.Label();
            this.panel_win_btns_main.SuspendLayout();
            this.panel_actions_btns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).BeginInit();
            this.panel_container_main.SuspendLayout();
            this.panel_container_base_comp.SuspendLayout();
            this.panel_contaioner_base_info.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_win_btns_main
            // 
            this.panel_win_btns_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.panel_win_btns_main.Controls.Add(this.panel_actions_btns);
            this.panel_win_btns_main.Controls.Add(this.txt_title_frm);
            this.panel_win_btns_main.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_win_btns_main.Location = new System.Drawing.Point(0, 0);
            this.panel_win_btns_main.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_win_btns_main.Name = "panel_win_btns_main";
            this.panel_win_btns_main.Size = new System.Drawing.Size(457, 30);
            this.panel_win_btns_main.TabIndex = 1;
            this.panel_win_btns_main.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_win_btns_main_MouseDown);
            // 
            // panel_actions_btns
            // 
            this.panel_actions_btns.AutoSize = true;
            this.panel_actions_btns.Controls.Add(this.minimize_btn);
            this.panel_actions_btns.Controls.Add(this.close_btn);
            this.panel_actions_btns.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_actions_btns.Location = new System.Drawing.Point(400, 0);
            this.panel_actions_btns.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.panel_actions_btns.Name = "panel_actions_btns";
            this.panel_actions_btns.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.panel_actions_btns.Size = new System.Drawing.Size(57, 30);
            this.panel_actions_btns.TabIndex = 11;
            // 
            // minimize_btn
            // 
            this.minimize_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimize_btn.Image = ((System.Drawing.Image)(resources.GetObject("minimize_btn.Image")));
            this.minimize_btn.Location = new System.Drawing.Point(3, 5);
            this.minimize_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.minimize_btn.Name = "minimize_btn";
            this.minimize_btn.Size = new System.Drawing.Size(20, 20);
            this.minimize_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimize_btn.TabIndex = 1;
            this.minimize_btn.TabStop = false;
            this.minimize_btn.Click += new System.EventHandler(this.minimize_btn_Click);
            // 
            // close_btn
            // 
            this.close_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_btn.Image = ((System.Drawing.Image)(resources.GetObject("close_btn.Image")));
            this.close_btn.Location = new System.Drawing.Point(29, 5);
            this.close_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(20, 20);
            this.close_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close_btn.TabIndex = 0;
            this.close_btn.TabStop = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // txt_title_frm
            // 
            this.txt_title_frm.Dock = System.Windows.Forms.DockStyle.Left;
            this.txt_title_frm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_title_frm.ForeColor = System.Drawing.Color.White;
            this.txt_title_frm.Location = new System.Drawing.Point(0, 0);
            this.txt_title_frm.Name = "txt_title_frm";
            this.txt_title_frm.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.txt_title_frm.Size = new System.Drawing.Size(242, 30);
            this.txt_title_frm.TabIndex = 4;
            this.txt_title_frm.Text = "SDM - Configurações";
            this.txt_title_frm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_title_frm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txt_title_frm_MouseDown);
            // 
            // btn_update_BaseComp
            // 
            this.btn_update_BaseComp.AutoSize = true;
            this.btn_update_BaseComp.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_update_BaseComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update_BaseComp.Location = new System.Drawing.Point(5, 5);
            this.btn_update_BaseComp.Margin = new System.Windows.Forms.Padding(4);
            this.btn_update_BaseComp.Name = "btn_update_BaseComp";
            this.btn_update_BaseComp.Size = new System.Drawing.Size(131, 55);
            this.btn_update_BaseComp.TabIndex = 2;
            this.btn_update_BaseComp.Text = "Atualizar base";
            this.btn_update_BaseComp.UseVisualStyleBackColor = true;
            this.btn_update_BaseComp.Click += new System.EventHandler(this.btn_update_BaseComp_Click);
            // 
            // txt_lastUpdateTime_CompBase
            // 
            this.txt_lastUpdateTime_CompBase.AutoSize = true;
            this.txt_lastUpdateTime_CompBase.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_lastUpdateTime_CompBase.Location = new System.Drawing.Point(4, 10);
            this.txt_lastUpdateTime_CompBase.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_lastUpdateTime_CompBase.Name = "txt_lastUpdateTime_CompBase";
            this.txt_lastUpdateTime_CompBase.Size = new System.Drawing.Size(127, 17);
            this.txt_lastUpdateTime_CompBase.TabIndex = 3;
            this.txt_lastUpdateTime_CompBase.Text = "Última atualização:";
            // 
            // txt_file_size
            // 
            this.txt_file_size.AutoSize = true;
            this.txt_file_size.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_file_size.Location = new System.Drawing.Point(4, 26);
            this.txt_file_size.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_file_size.Name = "txt_file_size";
            this.txt_file_size.Size = new System.Drawing.Size(72, 17);
            this.txt_file_size.TabIndex = 4;
            this.txt_file_size.Text = "Tamanho:";
            // 
            // panel_container_main
            // 
            this.panel_container_main.AutoSize = true;
            this.panel_container_main.Controls.Add(this.panel1);
            this.panel_container_main.Controls.Add(this.btn_manage_my_account);
            this.panel_container_main.Controls.Add(this.btn_verify_permissions);
            this.panel_container_main.Controls.Add(this.btn_users);
            this.panel_container_main.Controls.Add(this.txt_shortcuts_title);
            this.panel_container_main.Controls.Add(this.panel_container_base_comp);
            this.panel_container_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_container_main.Location = new System.Drawing.Point(0, 30);
            this.panel_container_main.Name = "panel_container_main";
            this.panel_container_main.Size = new System.Drawing.Size(457, 429);
            this.panel_container_main.TabIndex = 6;
            // 
            // btn_manage_my_account
            // 
            this.btn_manage_my_account.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(81)))), ((int)(((byte)(103)))));
            this.btn_manage_my_account.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_manage_my_account.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_manage_my_account.ForeColor = System.Drawing.Color.White;
            this.btn_manage_my_account.Location = new System.Drawing.Point(302, 127);
            this.btn_manage_my_account.Margin = new System.Windows.Forms.Padding(4);
            this.btn_manage_my_account.Name = "btn_manage_my_account";
            this.btn_manage_my_account.Size = new System.Drawing.Size(131, 54);
            this.btn_manage_my_account.TabIndex = 10;
            this.btn_manage_my_account.Text = "Gerenciar minha conta";
            this.btn_manage_my_account.UseVisualStyleBackColor = false;
            this.btn_manage_my_account.Click += new System.EventHandler(this.btn_manage_my_account_Click);
            // 
            // btn_verify_permissions
            // 
            this.btn_verify_permissions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(81)))), ((int)(((byte)(103)))));
            this.btn_verify_permissions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_verify_permissions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_verify_permissions.ForeColor = System.Drawing.Color.White;
            this.btn_verify_permissions.Location = new System.Drawing.Point(163, 127);
            this.btn_verify_permissions.Margin = new System.Windows.Forms.Padding(4);
            this.btn_verify_permissions.Name = "btn_verify_permissions";
            this.btn_verify_permissions.Size = new System.Drawing.Size(131, 54);
            this.btn_verify_permissions.TabIndex = 9;
            this.btn_verify_permissions.Text = "Verificar permissões";
            this.btn_verify_permissions.UseVisualStyleBackColor = false;
            this.btn_verify_permissions.Click += new System.EventHandler(this.btn_verify_permissions_Click);
            // 
            // btn_users
            // 
            this.btn_users.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(81)))), ((int)(((byte)(103)))));
            this.btn_users.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_users.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_users.ForeColor = System.Drawing.Color.White;
            this.btn_users.Location = new System.Drawing.Point(24, 127);
            this.btn_users.Margin = new System.Windows.Forms.Padding(4);
            this.btn_users.Name = "btn_users";
            this.btn_users.Size = new System.Drawing.Size(131, 54);
            this.btn_users.TabIndex = 5;
            this.btn_users.Text = "Gerenciar usuários";
            this.btn_users.UseVisualStyleBackColor = false;
            this.btn_users.Click += new System.EventHandler(this.btn_users_Click);
            // 
            // txt_shortcuts_title
            // 
            this.txt_shortcuts_title.AutoSize = true;
            this.txt_shortcuts_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_shortcuts_title.ForeColor = System.Drawing.Color.White;
            this.txt_shortcuts_title.Location = new System.Drawing.Point(15, 11);
            this.txt_shortcuts_title.Name = "txt_shortcuts_title";
            this.txt_shortcuts_title.Size = new System.Drawing.Size(79, 24);
            this.txt_shortcuts_title.TabIndex = 8;
            this.txt_shortcuts_title.Text = "Atalhos";
            // 
            // panel_container_base_comp
            // 
            this.panel_container_base_comp.AutoSize = true;
            this.panel_container_base_comp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(81)))), ((int)(((byte)(103)))));
            this.panel_container_base_comp.Controls.Add(this.panel_contaioner_base_info);
            this.panel_container_base_comp.Controls.Add(this.btn_update_BaseComp);
            this.panel_container_base_comp.Location = new System.Drawing.Point(19, 45);
            this.panel_container_base_comp.Name = "panel_container_base_comp";
            this.panel_container_base_comp.Padding = new System.Windows.Forms.Padding(5);
            this.panel_container_base_comp.Size = new System.Drawing.Size(416, 65);
            this.panel_container_base_comp.TabIndex = 6;
            // 
            // panel_contaioner_base_info
            // 
            this.panel_contaioner_base_info.AutoSize = true;
            this.panel_contaioner_base_info.Controls.Add(this.txt_lastUpdateTime_CompBase);
            this.panel_contaioner_base_info.Controls.Add(this.txt_file_size);
            this.panel_contaioner_base_info.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_contaioner_base_info.Location = new System.Drawing.Point(136, 5);
            this.panel_contaioner_base_info.Name = "panel_contaioner_base_info";
            this.panel_contaioner_base_info.Size = new System.Drawing.Size(135, 55);
            this.panel_contaioner_base_info.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(81)))), ((int)(((byte)(103)))));
            this.panel1.Controls.Add(this.lbl_Copyright);
            this.panel1.Controls.Add(this.lbl_app_version);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 374);
            this.panel1.MinimumSize = new System.Drawing.Size(0, 55);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(457, 55);
            this.panel1.TabIndex = 13;
            // 
            // lbl_app_version
            // 
            this.lbl_app_version.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_app_version.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_app_version.ForeColor = System.Drawing.Color.White;
            this.lbl_app_version.Location = new System.Drawing.Point(5, 5);
            this.lbl_app_version.Name = "lbl_app_version";
            this.lbl_app_version.Size = new System.Drawing.Size(447, 18);
            this.lbl_app_version.TabIndex = 0;
            this.lbl_app_version.Text = "Versão";
            this.lbl_app_version.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Copyright
            // 
            this.lbl_Copyright.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_Copyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Copyright.ForeColor = System.Drawing.Color.White;
            this.lbl_Copyright.Location = new System.Drawing.Point(5, 32);
            this.lbl_Copyright.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lbl_Copyright.Name = "lbl_Copyright";
            this.lbl_Copyright.Size = new System.Drawing.Size(447, 18);
            this.lbl_Copyright.TabIndex = 1;
            this.lbl_Copyright.Text = "Copyright © Kauã Lima & JBS S.A. All Rights Reserved";
            this.lbl_Copyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FRM_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(457, 459);
            this.Controls.Add(this.panel_container_main);
            this.Controls.Add(this.panel_win_btns_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRM_Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SDM - Settings";
            this.panel_win_btns_main.ResumeLayout(false);
            this.panel_win_btns_main.PerformLayout();
            this.panel_actions_btns.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.minimize_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).EndInit();
            this.panel_container_main.ResumeLayout(false);
            this.panel_container_main.PerformLayout();
            this.panel_container_base_comp.ResumeLayout(false);
            this.panel_container_base_comp.PerformLayout();
            this.panel_contaioner_base_info.ResumeLayout(false);
            this.panel_contaioner_base_info.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_win_btns_main;
        private System.Windows.Forms.PictureBox minimize_btn;
        private System.Windows.Forms.PictureBox close_btn;
        private System.Windows.Forms.Button btn_update_BaseComp;
        private System.Windows.Forms.Label txt_lastUpdateTime_CompBase;
        private System.Windows.Forms.Label txt_file_size;
        private System.Windows.Forms.Panel panel_container_main;
        private System.Windows.Forms.Button btn_users;
        private System.Windows.Forms.Label txt_shortcuts_title;
        private System.Windows.Forms.Panel panel_container_base_comp;
        private System.Windows.Forms.Label txt_title_frm;
        private System.Windows.Forms.Button btn_verify_permissions;
        private System.Windows.Forms.Button btn_manage_my_account;
        private System.Windows.Forms.Panel panel_actions_btns;
        private System.Windows.Forms.Panel panel_contaioner_base_info;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_app_version;
        private System.Windows.Forms.Label lbl_Copyright;
    }
}