namespace SDM
{
    partial class FRM_Splash
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Splash));
            this.main_text_splash = new System.Windows.Forms.Label();
            this.container_progress = new System.Windows.Forms.Panel();
            this.progress_splash = new System.Windows.Forms.Panel();
            this.timer_splash = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.container_progress.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_text_splash
            // 
            this.main_text_splash.BackColor = System.Drawing.Color.Transparent;
            this.main_text_splash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_text_splash.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_text_splash.ForeColor = System.Drawing.Color.White;
            this.main_text_splash.Location = new System.Drawing.Point(0, 0);
            this.main_text_splash.Name = "main_text_splash";
            this.main_text_splash.Size = new System.Drawing.Size(599, 350);
            this.main_text_splash.TabIndex = 0;
            this.main_text_splash.Text = "Service Desk\r\nManager";
            this.main_text_splash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // container_progress
            // 
            this.container_progress.Controls.Add(this.progress_splash);
            this.container_progress.Location = new System.Drawing.Point(-7, 343);
            this.container_progress.Name = "container_progress";
            this.container_progress.Size = new System.Drawing.Size(630, 7);
            this.container_progress.TabIndex = 1;
            // 
            // progress_splash
            // 
            this.progress_splash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(222)))), ((int)(((byte)(228)))));
            this.progress_splash.Location = new System.Drawing.Point(0, 0);
            this.progress_splash.Name = "progress_splash";
            this.progress_splash.Size = new System.Drawing.Size(92, 10);
            this.progress_splash.TabIndex = 2;
            // 
            // timer_splash
            // 
            this.timer_splash.Interval = 15;
            this.timer_splash.Tick += new System.EventHandler(this.timer_splash_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(182)))), ((int)(((byte)(184)))));
            this.label2.Location = new System.Drawing.Point(4, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Created by Kauã Vitorio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(182)))), ((int)(((byte)(184)))));
            this.label3.Location = new System.Drawing.Point(4, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Version 1.1";
            // 
            // FRM_Splash
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(92)))), ((int)(((byte)(94)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(599, 350);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.container_progress);
            this.Controls.Add(this.main_text_splash);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(92)))), ((int)(((byte)(94)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRM_Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SDM - Splash";
            this.container_progress.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label main_text_splash;
        private System.Windows.Forms.Panel container_progress;
        private System.Windows.Forms.Panel progress_splash;
        private System.Windows.Forms.Timer timer_splash;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

