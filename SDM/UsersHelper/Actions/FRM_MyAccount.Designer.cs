namespace SDM.UsersHelper.Actions
{
    partial class FRM_MyAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_MyAccount));
            this.header_panel_MyAccount = new System.Windows.Forms.Panel();
            this.txt_header_title_myAccount = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.PictureBox();
            this.user_profile_pic = new System.Windows.Forms.PictureBox();
            this.txt_user_name = new System.Windows.Forms.Label();
            this.txt_UserName = new System.Windows.Forms.Label();
            this.txt_user_access = new System.Windows.Forms.Label();
            this.btn_move_wsus_win10 = new System.Windows.Forms.Button();
            this.btn_new_name = new System.Windows.Forms.Button();
            this.panel_container_userInfo = new System.Windows.Forms.Panel();
            this.panel_container_main_info = new System.Windows.Forms.Panel();
            this.panel_container_update_photo = new System.Windows.Forms.Panel();
            this.btn_save_newImage = new System.Windows.Forms.Button();
            this.btn_test_newphoto = new System.Windows.Forms.Button();
            this.input_newPhoto = new System.Windows.Forms.TextBox();
            this.panel_container_newName = new System.Windows.Forms.Panel();
            this.btn_save_name = new System.Windows.Forms.Button();
            this.input_newName = new System.Windows.Forms.TextBox();
            this.header_panel_MyAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_profile_pic)).BeginInit();
            this.panel_container_userInfo.SuspendLayout();
            this.panel_container_main_info.SuspendLayout();
            this.panel_container_update_photo.SuspendLayout();
            this.panel_container_newName.SuspendLayout();
            this.SuspendLayout();
            // 
            // header_panel_MyAccount
            // 
            this.header_panel_MyAccount.AutoSize = true;
            this.header_panel_MyAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.header_panel_MyAccount.Controls.Add(this.txt_header_title_myAccount);
            this.header_panel_MyAccount.Controls.Add(this.btn_close);
            this.header_panel_MyAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.header_panel_MyAccount.Location = new System.Drawing.Point(0, 0);
            this.header_panel_MyAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.header_panel_MyAccount.Name = "header_panel_MyAccount";
            this.header_panel_MyAccount.Size = new System.Drawing.Size(289, 36);
            this.header_panel_MyAccount.TabIndex = 6;
            this.header_panel_MyAccount.MouseDown += new System.Windows.Forms.MouseEventHandler(this.header_panel_MyAccount_MouseDown);
            // 
            // txt_header_title_myAccount
            // 
            this.txt_header_title_myAccount.Dock = System.Windows.Forms.DockStyle.Left;
            this.txt_header_title_myAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_header_title_myAccount.ForeColor = System.Drawing.Color.White;
            this.txt_header_title_myAccount.Location = new System.Drawing.Point(0, 0);
            this.txt_header_title_myAccount.Name = "txt_header_title_myAccount";
            this.txt_header_title_myAccount.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.txt_header_title_myAccount.Size = new System.Drawing.Size(189, 36);
            this.txt_header_title_myAccount.TabIndex = 3;
            this.txt_header_title_myAccount.Text = "SDM - Minha Conta";
            this.txt_header_title_myAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_header_title_myAccount.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txt_header_title_myAccount_MouseDown);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.Location = new System.Drawing.Point(261, 4);
            this.btn_close.Margin = new System.Windows.Forms.Padding(3, 2, 11, 2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(20, 30);
            this.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_close.TabIndex = 1;
            this.btn_close.TabStop = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // user_profile_pic
            // 
            this.user_profile_pic.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.user_profile_pic.Image = ((System.Drawing.Image)(resources.GetObject("user_profile_pic.Image")));
            this.user_profile_pic.Location = new System.Drawing.Point(8, 7);
            this.user_profile_pic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.user_profile_pic.Name = "user_profile_pic";
            this.user_profile_pic.Size = new System.Drawing.Size(80, 80);
            this.user_profile_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.user_profile_pic.TabIndex = 7;
            this.user_profile_pic.TabStop = false;
            // 
            // txt_user_name
            // 
            this.txt_user_name.AutoSize = true;
            this.txt_user_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user_name.ForeColor = System.Drawing.Color.White;
            this.txt_user_name.Location = new System.Drawing.Point(3, 0);
            this.txt_user_name.Name = "txt_user_name";
            this.txt_user_name.Size = new System.Drawing.Size(106, 22);
            this.txt_user_name.TabIndex = 8;
            this.txt_user_name.Text = "User name";
            // 
            // txt_UserName
            // 
            this.txt_UserName.AutoSize = true;
            this.txt_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UserName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_UserName.Location = new System.Drawing.Point(3, 22);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(86, 20);
            this.txt_UserName.TabIndex = 9;
            this.txt_UserName.Text = "Username";
            // 
            // txt_user_access
            // 
            this.txt_user_access.AutoSize = true;
            this.txt_user_access.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user_access.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_user_access.Location = new System.Drawing.Point(3, 42);
            this.txt_user_access.Name = "txt_user_access";
            this.txt_user_access.Size = new System.Drawing.Size(65, 20);
            this.txt_user_access.TabIndex = 10;
            this.txt_user_access.Text = "Access";
            // 
            // btn_move_wsus_win10
            // 
            this.btn_move_wsus_win10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_move_wsus_win10.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btn_move_wsus_win10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_move_wsus_win10.ForeColor = System.Drawing.Color.White;
            this.btn_move_wsus_win10.Location = new System.Drawing.Point(12, 144);
            this.btn_move_wsus_win10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_move_wsus_win10.Name = "btn_move_wsus_win10";
            this.btn_move_wsus_win10.Size = new System.Drawing.Size(123, 30);
            this.btn_move_wsus_win10.TabIndex = 11;
            this.btn_move_wsus_win10.Text = "Atualizar Foto";
            this.btn_move_wsus_win10.UseVisualStyleBackColor = true;
            this.btn_move_wsus_win10.Click += new System.EventHandler(this.btn_move_wsus_win10_Click);
            // 
            // btn_new_name
            // 
            this.btn_new_name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_new_name.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btn_new_name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_new_name.ForeColor = System.Drawing.Color.White;
            this.btn_new_name.Location = new System.Drawing.Point(141, 144);
            this.btn_new_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_new_name.Name = "btn_new_name";
            this.btn_new_name.Size = new System.Drawing.Size(123, 30);
            this.btn_new_name.TabIndex = 12;
            this.btn_new_name.Text = "Atualizar Nome";
            this.btn_new_name.UseVisualStyleBackColor = true;
            this.btn_new_name.Click += new System.EventHandler(this.btn_new_name_Click);
            // 
            // panel_container_userInfo
            // 
            this.panel_container_userInfo.AutoSize = true;
            this.panel_container_userInfo.Controls.Add(this.txt_user_name);
            this.panel_container_userInfo.Controls.Add(this.txt_UserName);
            this.panel_container_userInfo.Controls.Add(this.txt_user_access);
            this.panel_container_userInfo.Location = new System.Drawing.Point(94, 7);
            this.panel_container_userInfo.Name = "panel_container_userInfo";
            this.panel_container_userInfo.Size = new System.Drawing.Size(145, 79);
            this.panel_container_userInfo.TabIndex = 13;
            // 
            // panel_container_main_info
            // 
            this.panel_container_main_info.AutoSize = true;
            this.panel_container_main_info.Controls.Add(this.user_profile_pic);
            this.panel_container_main_info.Controls.Add(this.panel_container_userInfo);
            this.panel_container_main_info.Location = new System.Drawing.Point(12, 39);
            this.panel_container_main_info.Name = "panel_container_main_info";
            this.panel_container_main_info.Padding = new System.Windows.Forms.Padding(5);
            this.panel_container_main_info.Size = new System.Drawing.Size(265, 100);
            this.panel_container_main_info.TabIndex = 14;
            // 
            // panel_container_update_photo
            // 
            this.panel_container_update_photo.Controls.Add(this.btn_save_newImage);
            this.panel_container_update_photo.Controls.Add(this.btn_test_newphoto);
            this.panel_container_update_photo.Controls.Add(this.input_newPhoto);
            this.panel_container_update_photo.Location = new System.Drawing.Point(12, 198);
            this.panel_container_update_photo.Name = "panel_container_update_photo";
            this.panel_container_update_photo.Padding = new System.Windows.Forms.Padding(3);
            this.panel_container_update_photo.Size = new System.Drawing.Size(265, 102);
            this.panel_container_update_photo.TabIndex = 15;
            // 
            // btn_save_newImage
            // 
            this.btn_save_newImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save_newImage.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btn_save_newImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save_newImage.ForeColor = System.Drawing.Color.White;
            this.btn_save_newImage.Location = new System.Drawing.Point(3, 65);
            this.btn_save_newImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_save_newImage.Name = "btn_save_newImage";
            this.btn_save_newImage.Size = new System.Drawing.Size(259, 30);
            this.btn_save_newImage.TabIndex = 17;
            this.btn_save_newImage.Text = "Salvar";
            this.btn_save_newImage.UseVisualStyleBackColor = true;
            this.btn_save_newImage.Click += new System.EventHandler(this.btn_save_newImage_Click);
            // 
            // btn_test_newphoto
            // 
            this.btn_test_newphoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_test_newphoto.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btn_test_newphoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_test_newphoto.ForeColor = System.Drawing.Color.White;
            this.btn_test_newphoto.Location = new System.Drawing.Point(3, 31);
            this.btn_test_newphoto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_test_newphoto.Name = "btn_test_newphoto";
            this.btn_test_newphoto.Size = new System.Drawing.Size(259, 30);
            this.btn_test_newphoto.TabIndex = 16;
            this.btn_test_newphoto.Text = "Testar Imagem";
            this.btn_test_newphoto.UseVisualStyleBackColor = true;
            this.btn_test_newphoto.Click += new System.EventHandler(this.btn_test_newphoto_Click);
            // 
            // input_newPhoto
            // 
            this.input_newPhoto.Location = new System.Drawing.Point(4, 4);
            this.input_newPhoto.Name = "input_newPhoto";
            this.input_newPhoto.Size = new System.Drawing.Size(258, 22);
            this.input_newPhoto.TabIndex = 0;
            // 
            // panel_container_newName
            // 
            this.panel_container_newName.Controls.Add(this.btn_save_name);
            this.panel_container_newName.Controls.Add(this.input_newName);
            this.panel_container_newName.Location = new System.Drawing.Point(12, 306);
            this.panel_container_newName.Name = "panel_container_newName";
            this.panel_container_newName.Padding = new System.Windows.Forms.Padding(3);
            this.panel_container_newName.Size = new System.Drawing.Size(265, 69);
            this.panel_container_newName.TabIndex = 18;
            // 
            // btn_save_name
            // 
            this.btn_save_name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save_name.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btn_save_name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save_name.ForeColor = System.Drawing.Color.White;
            this.btn_save_name.Location = new System.Drawing.Point(3, 31);
            this.btn_save_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_save_name.Name = "btn_save_name";
            this.btn_save_name.Size = new System.Drawing.Size(259, 30);
            this.btn_save_name.TabIndex = 17;
            this.btn_save_name.Text = "Salvar";
            this.btn_save_name.UseVisualStyleBackColor = true;
            this.btn_save_name.Click += new System.EventHandler(this.btn_save_name_Click);
            // 
            // input_newName
            // 
            this.input_newName.Location = new System.Drawing.Point(4, 4);
            this.input_newName.Name = "input_newName";
            this.input_newName.Size = new System.Drawing.Size(258, 22);
            this.input_newName.TabIndex = 0;
            // 
            // FRM_MyAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(289, 389);
            this.Controls.Add(this.panel_container_newName);
            this.Controls.Add(this.panel_container_update_photo);
            this.Controls.Add(this.panel_container_main_info);
            this.Controls.Add(this.btn_new_name);
            this.Controls.Add(this.btn_move_wsus_win10);
            this.Controls.Add(this.header_panel_MyAccount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_MyAccount";
            this.Text = "FRM_MyAccount";
            this.header_panel_MyAccount.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_profile_pic)).EndInit();
            this.panel_container_userInfo.ResumeLayout(false);
            this.panel_container_userInfo.PerformLayout();
            this.panel_container_main_info.ResumeLayout(false);
            this.panel_container_main_info.PerformLayout();
            this.panel_container_update_photo.ResumeLayout(false);
            this.panel_container_update_photo.PerformLayout();
            this.panel_container_newName.ResumeLayout(false);
            this.panel_container_newName.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel header_panel_MyAccount;
        private System.Windows.Forms.Label txt_header_title_myAccount;
        private System.Windows.Forms.PictureBox btn_close;
        private System.Windows.Forms.PictureBox user_profile_pic;
        private System.Windows.Forms.Label txt_user_name;
        private System.Windows.Forms.Label txt_UserName;
        private System.Windows.Forms.Label txt_user_access;
        private System.Windows.Forms.Button btn_move_wsus_win10;
        private System.Windows.Forms.Button btn_new_name;
        private System.Windows.Forms.Panel panel_container_userInfo;
        private System.Windows.Forms.Panel panel_container_main_info;
        private System.Windows.Forms.Panel panel_container_update_photo;
        private System.Windows.Forms.Button btn_test_newphoto;
        private System.Windows.Forms.TextBox input_newPhoto;
        private System.Windows.Forms.Button btn_save_newImage;
        private System.Windows.Forms.Panel panel_container_newName;
        private System.Windows.Forms.Button btn_save_name;
        private System.Windows.Forms.TextBox input_newName;
    }
}