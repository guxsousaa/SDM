namespace SDM.UsersHelper.Actions
{
    partial class FRM_NewUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_NewUser));
            this.panel_win_btns_main = new System.Windows.Forms.Panel();
            this.close_btn = new System.Windows.Forms.PictureBox();
            this.txt_name = new System.Windows.Forms.Label();
            this.input_name = new System.Windows.Forms.TextBox();
            this.input_username = new System.Windows.Forms.TextBox();
            this.txt_userName = new System.Windows.Forms.Label();
            this.checkBox_full = new System.Windows.Forms.CheckBox();
            this.checkBox_operator = new System.Windows.Forms.CheckBox();
            this.checkBox_TiEmprest = new System.Windows.Forms.CheckBox();
            this.btn_create = new System.Windows.Forms.Button();
            this.panel_access_check = new System.Windows.Forms.Panel();
            this.input_image = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_win_btns_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).BeginInit();
            this.panel_access_check.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_win_btns_main
            // 
            this.panel_win_btns_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.panel_win_btns_main.Controls.Add(this.close_btn);
            this.panel_win_btns_main.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_win_btns_main.Location = new System.Drawing.Point(0, 0);
            this.panel_win_btns_main.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_win_btns_main.Name = "panel_win_btns_main";
            this.panel_win_btns_main.Size = new System.Drawing.Size(287, 25);
            this.panel_win_btns_main.TabIndex = 3;
            this.panel_win_btns_main.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_win_btns_main_MouseDown);
            // 
            // close_btn
            // 
            this.close_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_btn.Image = ((System.Drawing.Image)(resources.GetObject("close_btn.Image")));
            this.close_btn.Location = new System.Drawing.Point(255, 2);
            this.close_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(20, 20);
            this.close_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close_btn.TabIndex = 0;
            this.close_btn.TabStop = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // txt_name
            // 
            this.txt_name.AutoSize = true;
            this.txt_name.ForeColor = System.Drawing.Color.White;
            this.txt_name.Location = new System.Drawing.Point(12, 36);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(52, 16);
            this.txt_name.TabIndex = 4;
            this.txt_name.Text = "*Name:";
            // 
            // input_name
            // 
            this.input_name.Location = new System.Drawing.Point(15, 56);
            this.input_name.Name = "input_name";
            this.input_name.Size = new System.Drawing.Size(260, 22);
            this.input_name.TabIndex = 1;
            // 
            // input_username
            // 
            this.input_username.Location = new System.Drawing.Point(15, 110);
            this.input_username.Name = "input_username";
            this.input_username.Size = new System.Drawing.Size(260, 22);
            this.input_username.TabIndex = 2;
            // 
            // txt_userName
            // 
            this.txt_userName.AutoSize = true;
            this.txt_userName.ForeColor = System.Drawing.Color.White;
            this.txt_userName.Location = new System.Drawing.Point(12, 91);
            this.txt_userName.Name = "txt_userName";
            this.txt_userName.Size = new System.Drawing.Size(78, 16);
            this.txt_userName.TabIndex = 6;
            this.txt_userName.Text = "*Username:";
            // 
            // checkBox_full
            // 
            this.checkBox_full.AutoSize = true;
            this.checkBox_full.ForeColor = System.Drawing.Color.White;
            this.checkBox_full.Location = new System.Drawing.Point(3, 3);
            this.checkBox_full.Name = "checkBox_full";
            this.checkBox_full.Size = new System.Drawing.Size(98, 20);
            this.checkBox_full.TabIndex = 4;
            this.checkBox_full.Text = "Full Access";
            this.checkBox_full.UseVisualStyleBackColor = true;
            this.checkBox_full.CheckedChanged += new System.EventHandler(this.checkBox_full_CheckedChanged);
            // 
            // checkBox_operator
            // 
            this.checkBox_operator.AutoSize = true;
            this.checkBox_operator.ForeColor = System.Drawing.Color.White;
            this.checkBox_operator.Location = new System.Drawing.Point(127, 3);
            this.checkBox_operator.Name = "checkBox_operator";
            this.checkBox_operator.Size = new System.Drawing.Size(130, 20);
            this.checkBox_operator.TabIndex = 5;
            this.checkBox_operator.Text = "Operator Access";
            this.checkBox_operator.UseVisualStyleBackColor = true;
            this.checkBox_operator.CheckedChanged += new System.EventHandler(this.checkBox_operator_CheckedChanged);
            // 
            // checkBox_TiEmprest
            // 
            this.checkBox_TiEmprest.AutoSize = true;
            this.checkBox_TiEmprest.ForeColor = System.Drawing.Color.White;
            this.checkBox_TiEmprest.Location = new System.Drawing.Point(3, 29);
            this.checkBox_TiEmprest.Name = "checkBox_TiEmprest";
            this.checkBox_TiEmprest.Size = new System.Drawing.Size(107, 20);
            this.checkBox_TiEmprest.TabIndex = 6;
            this.checkBox_TiEmprest.Text = "TIEMPREST";
            this.checkBox_TiEmprest.UseVisualStyleBackColor = true;
            this.checkBox_TiEmprest.CheckedChanged += new System.EventHandler(this.checkBox_TiEmprest_CheckedChanged);
            // 
            // btn_create
            // 
            this.btn_create.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_create.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_create.Location = new System.Drawing.Point(0, 313);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(287, 45);
            this.btn_create.TabIndex = 7;
            this.btn_create.Text = "Create User";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // panel_access_check
            // 
            this.panel_access_check.Controls.Add(this.checkBox_full);
            this.panel_access_check.Controls.Add(this.checkBox_operator);
            this.panel_access_check.Controls.Add(this.checkBox_TiEmprest);
            this.panel_access_check.Location = new System.Drawing.Point(15, 216);
            this.panel_access_check.Name = "panel_access_check";
            this.panel_access_check.Size = new System.Drawing.Size(260, 54);
            this.panel_access_check.TabIndex = 12;
            // 
            // input_image
            // 
            this.input_image.Location = new System.Drawing.Point(15, 161);
            this.input_image.Name = "input_image";
            this.input_image.Size = new System.Drawing.Size(260, 22);
            this.input_image.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Image:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "*Access:";
            // 
            // FRM_NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(287, 358);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.input_image);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_access_check);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.input_username);
            this.Controls.Add(this.txt_userName);
            this.Controls.Add(this.input_name);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.panel_win_btns_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_NewUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SDM - Create User";
            this.panel_win_btns_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).EndInit();
            this.panel_access_check.ResumeLayout(false);
            this.panel_access_check.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_win_btns_main;
        private System.Windows.Forms.PictureBox close_btn;
        private System.Windows.Forms.Label txt_name;
        private System.Windows.Forms.TextBox input_name;
        private System.Windows.Forms.TextBox input_username;
        private System.Windows.Forms.Label txt_userName;
        private System.Windows.Forms.CheckBox checkBox_full;
        private System.Windows.Forms.CheckBox checkBox_operator;
        private System.Windows.Forms.CheckBox checkBox_TiEmprest;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Panel panel_access_check;
        private System.Windows.Forms.TextBox input_image;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}