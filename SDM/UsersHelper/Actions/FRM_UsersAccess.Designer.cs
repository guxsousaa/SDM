namespace SDM.UsersHelper
{
    partial class FRM_UsersAccess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_UsersAccess));
            this.panel_win_btns_main = new System.Windows.Forms.Panel();
            this.close_btn = new System.Windows.Forms.PictureBox();
            this.btn_new_user = new System.Windows.Forms.Button();
            this.panel_win_btns_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).BeginInit();
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
            this.panel_win_btns_main.Size = new System.Drawing.Size(659, 25);
            this.panel_win_btns_main.TabIndex = 2;
            // 
            // close_btn
            // 
            this.close_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_btn.Image = ((System.Drawing.Image)(resources.GetObject("close_btn.Image")));
            this.close_btn.Location = new System.Drawing.Point(630, 3);
            this.close_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(20, 20);
            this.close_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close_btn.TabIndex = 0;
            this.close_btn.TabStop = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // btn_new_user
            // 
            this.btn_new_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new_user.Location = new System.Drawing.Point(12, 42);
            this.btn_new_user.Name = "btn_new_user";
            this.btn_new_user.Size = new System.Drawing.Size(130, 56);
            this.btn_new_user.TabIndex = 3;
            this.btn_new_user.Text = "New Users";
            this.btn_new_user.UseVisualStyleBackColor = true;
            this.btn_new_user.Click += new System.EventHandler(this.btn_new_user_Click);
            // 
            // FRM_UsersAccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(659, 450);
            this.Controls.Add(this.btn_new_user);
            this.Controls.Add(this.panel_win_btns_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_UsersAccess";
            this.Text = "FRM_UsersAccess";
            this.panel_win_btns_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_win_btns_main;
        private System.Windows.Forms.PictureBox close_btn;
        private System.Windows.Forms.Button btn_new_user;
    }
}