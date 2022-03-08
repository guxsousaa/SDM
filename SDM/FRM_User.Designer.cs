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
            this.btn_search_user = new System.Windows.Forms.Button();
            this.input_user = new System.Windows.Forms.TextBox();
            this.panel_top_container_ad = new System.Windows.Forms.Panel();
            this.txt_header_title_users = new System.Windows.Forms.Label();
            this.panel_container.SuspendLayout();
            this.panel_top_container_ad.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_container
            // 
            this.panel_container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(71)))), ((int)(((byte)(93)))));
            this.panel_container.Controls.Add(this.btn_search_user);
            this.panel_container.Controls.Add(this.input_user);
            this.panel_container.Location = new System.Drawing.Point(18, 65);
            this.panel_container.Name = "panel_container";
            this.panel_container.Padding = new System.Windows.Forms.Padding(5);
            this.panel_container.Size = new System.Drawing.Size(257, 88);
            this.panel_container.TabIndex = 2;
            // 
            // btn_search_user
            // 
            this.btn_search_user.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_search_user.FlatAppearance.BorderSize = 0;
            this.btn_search_user.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_search_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search_user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_search_user.Location = new System.Drawing.Point(11, 37);
            this.btn_search_user.Margin = new System.Windows.Forms.Padding(4);
            this.btn_search_user.Name = "btn_search_user";
            this.btn_search_user.Size = new System.Drawing.Size(237, 41);
            this.btn_search_user.TabIndex = 2;
            this.btn_search_user.Text = "Search User";
            this.btn_search_user.UseVisualStyleBackColor = true;
            this.btn_search_user.Click += new System.EventHandler(this.btn_search_user_Click);
            // 
            // input_user
            // 
            this.input_user.Location = new System.Drawing.Point(11, 8);
            this.input_user.Name = "input_user";
            this.input_user.Size = new System.Drawing.Size(238, 22);
            this.input_user.TabIndex = 1;
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
            this.txt_header_title_users.Size = new System.Drawing.Size(87, 32);
            this.txt_header_title_users.TabIndex = 4;
            this.txt_header_title_users.Text = "Users";
            // 
            // FRM_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(729, 571);
            this.Controls.Add(this.panel_top_container_ad);
            this.Controls.Add(this.panel_container);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_User";
            this.Text = "FRM_User";
            this.panel_container.ResumeLayout(false);
            this.panel_container.PerformLayout();
            this.panel_top_container_ad.ResumeLayout(false);
            this.panel_top_container_ad.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_container;
        private System.Windows.Forms.TextBox input_user;
        private System.Windows.Forms.Panel panel_top_container_ad;
        private System.Windows.Forms.Label txt_header_title_users;
        private System.Windows.Forms.Button btn_search_user;
    }
}