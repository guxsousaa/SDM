
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
            this.txt_title_frm = new System.Windows.Forms.Label();
            this.minimize_btn = new System.Windows.Forms.PictureBox();
            this.close_btn = new System.Windows.Forms.PictureBox();
            this.btn_update_BaseComp = new System.Windows.Forms.Button();
            this.txt_lastUpdateTime_CompBase = new System.Windows.Forms.Label();
            this.txt_file_size = new System.Windows.Forms.Label();
            this.panel_container_main = new System.Windows.Forms.Panel();
            this.btn_users = new System.Windows.Forms.Button();
            this.txt_shortcuts_title = new System.Windows.Forms.Label();
            this.panel_container_base_comp = new System.Windows.Forms.Panel();
            this.panel_win_btns_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).BeginInit();
            this.panel_container_main.SuspendLayout();
            this.panel_container_base_comp.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_win_btns_main
            // 
            this.panel_win_btns_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.panel_win_btns_main.Controls.Add(this.txt_title_frm);
            this.panel_win_btns_main.Controls.Add(this.minimize_btn);
            this.panel_win_btns_main.Controls.Add(this.close_btn);
            this.panel_win_btns_main.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_win_btns_main.Location = new System.Drawing.Point(0, 0);
            this.panel_win_btns_main.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_win_btns_main.Name = "panel_win_btns_main";
            this.panel_win_btns_main.Size = new System.Drawing.Size(533, 30);
            this.panel_win_btns_main.TabIndex = 1;
            this.panel_win_btns_main.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_win_btns_main_MouseDown);
            // 
            // txt_title_frm
            // 
            this.txt_title_frm.Dock = System.Windows.Forms.DockStyle.Left;
            this.txt_title_frm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_title_frm.ForeColor = System.Drawing.Color.White;
            this.txt_title_frm.Location = new System.Drawing.Point(0, 0);
            this.txt_title_frm.Name = "txt_title_frm";
            this.txt_title_frm.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.txt_title_frm.Size = new System.Drawing.Size(150, 30);
            this.txt_title_frm.TabIndex = 4;
            this.txt_title_frm.Text = "SDM - Settings";
            this.txt_title_frm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // minimize_btn
            // 
            this.minimize_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimize_btn.Image = ((System.Drawing.Image)(resources.GetObject("minimize_btn.Image")));
            this.minimize_btn.Location = new System.Drawing.Point(473, 5);
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
            this.close_btn.Location = new System.Drawing.Point(499, 5);
            this.close_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(20, 20);
            this.close_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close_btn.TabIndex = 0;
            this.close_btn.TabStop = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // btn_update_BaseComp
            // 
            this.btn_update_BaseComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update_BaseComp.Location = new System.Drawing.Point(4, 4);
            this.btn_update_BaseComp.Margin = new System.Windows.Forms.Padding(4);
            this.btn_update_BaseComp.Name = "btn_update_BaseComp";
            this.btn_update_BaseComp.Size = new System.Drawing.Size(131, 54);
            this.btn_update_BaseComp.TabIndex = 2;
            this.btn_update_BaseComp.Text = "Update Base";
            this.btn_update_BaseComp.UseVisualStyleBackColor = true;
            this.btn_update_BaseComp.Click += new System.EventHandler(this.btn_update_BaseComp_Click);
            // 
            // txt_lastUpdateTime_CompBase
            // 
            this.txt_lastUpdateTime_CompBase.AutoSize = true;
            this.txt_lastUpdateTime_CompBase.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_lastUpdateTime_CompBase.Location = new System.Drawing.Point(143, 4);
            this.txt_lastUpdateTime_CompBase.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_lastUpdateTime_CompBase.Name = "txt_lastUpdateTime_CompBase";
            this.txt_lastUpdateTime_CompBase.Size = new System.Drawing.Size(80, 16);
            this.txt_lastUpdateTime_CompBase.TabIndex = 3;
            this.txt_lastUpdateTime_CompBase.Text = "Last update:";
            // 
            // txt_file_size
            // 
            this.txt_file_size.AutoSize = true;
            this.txt_file_size.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_file_size.Location = new System.Drawing.Point(143, 24);
            this.txt_file_size.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_file_size.Name = "txt_file_size";
            this.txt_file_size.Size = new System.Drawing.Size(39, 16);
            this.txt_file_size.TabIndex = 4;
            this.txt_file_size.Text = "Size: ";
            // 
            // panel_container_main
            // 
            this.panel_container_main.Controls.Add(this.btn_users);
            this.panel_container_main.Controls.Add(this.txt_shortcuts_title);
            this.panel_container_main.Controls.Add(this.panel_container_base_comp);
            this.panel_container_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_container_main.Location = new System.Drawing.Point(0, 30);
            this.panel_container_main.Name = "panel_container_main";
            this.panel_container_main.Size = new System.Drawing.Size(533, 614);
            this.panel_container_main.TabIndex = 6;
            // 
            // btn_users
            // 
            this.btn_users.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(81)))), ((int)(((byte)(103)))));
            this.btn_users.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_users.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_users.ForeColor = System.Drawing.Color.White;
            this.btn_users.Location = new System.Drawing.Point(19, 127);
            this.btn_users.Margin = new System.Windows.Forms.Padding(4);
            this.btn_users.Name = "btn_users";
            this.btn_users.Size = new System.Drawing.Size(131, 54);
            this.btn_users.TabIndex = 5;
            this.btn_users.Text = "Manage Users";
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
            this.txt_shortcuts_title.Size = new System.Drawing.Size(95, 22);
            this.txt_shortcuts_title.TabIndex = 8;
            this.txt_shortcuts_title.Text = "Shortcuts";
            // 
            // panel_container_base_comp
            // 
            this.panel_container_base_comp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(81)))), ((int)(((byte)(103)))));
            this.panel_container_base_comp.Controls.Add(this.btn_update_BaseComp);
            this.panel_container_base_comp.Controls.Add(this.txt_lastUpdateTime_CompBase);
            this.panel_container_base_comp.Controls.Add(this.txt_file_size);
            this.panel_container_base_comp.Location = new System.Drawing.Point(19, 45);
            this.panel_container_base_comp.Name = "panel_container_base_comp";
            this.panel_container_base_comp.Size = new System.Drawing.Size(500, 65);
            this.panel_container_base_comp.TabIndex = 6;
            // 
            // FRM_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(533, 644);
            this.Controls.Add(this.panel_container_main);
            this.Controls.Add(this.panel_win_btns_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRM_Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SDM - Settings";
            this.panel_win_btns_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.minimize_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).EndInit();
            this.panel_container_main.ResumeLayout(false);
            this.panel_container_main.PerformLayout();
            this.panel_container_base_comp.ResumeLayout(false);
            this.panel_container_base_comp.PerformLayout();
            this.ResumeLayout(false);

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
    }
}