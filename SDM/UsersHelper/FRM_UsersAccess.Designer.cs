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
            this.minimize_btn = new System.Windows.Forms.PictureBox();
            this.close_btn = new System.Windows.Forms.PictureBox();
            this.panel_win_btns_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_win_btns_main
            // 
            this.panel_win_btns_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.panel_win_btns_main.Controls.Add(this.minimize_btn);
            this.panel_win_btns_main.Controls.Add(this.close_btn);
            this.panel_win_btns_main.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_win_btns_main.Location = new System.Drawing.Point(0, 0);
            this.panel_win_btns_main.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_win_btns_main.Name = "panel_win_btns_main";
            this.panel_win_btns_main.Size = new System.Drawing.Size(662, 25);
            this.panel_win_btns_main.TabIndex = 2;
            // 
            // minimize_btn
            // 
            this.minimize_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimize_btn.Image = ((System.Drawing.Image)(resources.GetObject("minimize_btn.Image")));
            this.minimize_btn.Location = new System.Drawing.Point(603, 3);
            this.minimize_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.minimize_btn.Name = "minimize_btn";
            this.minimize_btn.Size = new System.Drawing.Size(20, 20);
            this.minimize_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimize_btn.TabIndex = 1;
            this.minimize_btn.TabStop = false;
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
            // 
            // FRM_UsersAccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 450);
            this.Controls.Add(this.panel_win_btns_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_UsersAccess";
            this.Text = "FRM_UsersAccess";
            this.panel_win_btns_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.minimize_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_win_btns_main;
        private System.Windows.Forms.PictureBox minimize_btn;
        private System.Windows.Forms.PictureBox close_btn;
    }
}