
namespace SDM.FRMs_AD
{
    partial class FRM_newComp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_newComp));
            this.input_computerName_ad = new System.Windows.Forms.TextBox();
            this.btn_search_Computer = new System.Windows.Forms.Button();
            this.btn_create_Computer = new System.Windows.Forms.Button();
            this.main_panel_container_newComp_ad = new System.Windows.Forms.Panel();
            this.header_panel_newComp_ad = new System.Windows.Forms.Panel();
            this.close_btn_newComp_AD = new System.Windows.Forms.PictureBox();
            this.main_panel_container_newComp_ad.SuspendLayout();
            this.header_panel_newComp_ad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn_newComp_AD)).BeginInit();
            this.SuspendLayout();
            // 
            // input_computerName_ad
            // 
            this.input_computerName_ad.Location = new System.Drawing.Point(5, 29);
            this.input_computerName_ad.Name = "input_computerName_ad";
            this.input_computerName_ad.Size = new System.Drawing.Size(130, 20);
            this.input_computerName_ad.TabIndex = 0;
            // 
            // btn_search_Computer
            // 
            this.btn_search_Computer.Location = new System.Drawing.Point(262, 29);
            this.btn_search_Computer.Name = "btn_search_Computer";
            this.btn_search_Computer.Size = new System.Drawing.Size(75, 31);
            this.btn_search_Computer.TabIndex = 1;
            this.btn_search_Computer.Text = "Search";
            this.btn_search_Computer.UseVisualStyleBackColor = true;
            this.btn_search_Computer.Click += new System.EventHandler(this.btn_search_Computer_Click);
            // 
            // btn_create_Computer
            // 
            this.btn_create_Computer.Location = new System.Drawing.Point(262, 66);
            this.btn_create_Computer.Name = "btn_create_Computer";
            this.btn_create_Computer.Size = new System.Drawing.Size(75, 31);
            this.btn_create_Computer.TabIndex = 2;
            this.btn_create_Computer.Text = "Create";
            this.btn_create_Computer.UseVisualStyleBackColor = true;
            this.btn_create_Computer.Click += new System.EventHandler(this.btn_create_Computer_Click);
            // 
            // main_panel_container_newComp_ad
            // 
            this.main_panel_container_newComp_ad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.main_panel_container_newComp_ad.Controls.Add(this.btn_create_Computer);
            this.main_panel_container_newComp_ad.Controls.Add(this.header_panel_newComp_ad);
            this.main_panel_container_newComp_ad.Controls.Add(this.btn_search_Computer);
            this.main_panel_container_newComp_ad.Controls.Add(this.input_computerName_ad);
            this.main_panel_container_newComp_ad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_panel_container_newComp_ad.Location = new System.Drawing.Point(0, 0);
            this.main_panel_container_newComp_ad.Margin = new System.Windows.Forms.Padding(2);
            this.main_panel_container_newComp_ad.Name = "main_panel_container_newComp_ad";
            this.main_panel_container_newComp_ad.Size = new System.Drawing.Size(347, 368);
            this.main_panel_container_newComp_ad.TabIndex = 3;
            // 
            // header_panel_newComp_ad
            // 
            this.header_panel_newComp_ad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.header_panel_newComp_ad.Controls.Add(this.close_btn_newComp_AD);
            this.header_panel_newComp_ad.Dock = System.Windows.Forms.DockStyle.Top;
            this.header_panel_newComp_ad.Location = new System.Drawing.Point(0, 0);
            this.header_panel_newComp_ad.Margin = new System.Windows.Forms.Padding(2);
            this.header_panel_newComp_ad.Name = "header_panel_newComp_ad";
            this.header_panel_newComp_ad.Size = new System.Drawing.Size(347, 24);
            this.header_panel_newComp_ad.TabIndex = 0;
            this.header_panel_newComp_ad.MouseDown += new System.Windows.Forms.MouseEventHandler(this.header_panel_newComp_ad_MouseDown);
            // 
            // close_btn_newComp_AD
            // 
            this.close_btn_newComp_AD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_btn_newComp_AD.Image = ((System.Drawing.Image)(resources.GetObject("close_btn_newComp_AD.Image")));
            this.close_btn_newComp_AD.Location = new System.Drawing.Point(323, 2);
            this.close_btn_newComp_AD.Margin = new System.Windows.Forms.Padding(2);
            this.close_btn_newComp_AD.Name = "close_btn_newComp_AD";
            this.close_btn_newComp_AD.Size = new System.Drawing.Size(15, 16);
            this.close_btn_newComp_AD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close_btn_newComp_AD.TabIndex = 1;
            this.close_btn_newComp_AD.TabStop = false;
            this.close_btn_newComp_AD.Click += new System.EventHandler(this.close_btn_newComp_AD_Click);
            // 
            // FRM_newComp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 368);
            this.Controls.Add(this.main_panel_container_newComp_ad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_newComp";
            this.Text = "Create new computer";
            this.main_panel_container_newComp_ad.ResumeLayout(false);
            this.main_panel_container_newComp_ad.PerformLayout();
            this.header_panel_newComp_ad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.close_btn_newComp_AD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox input_computerName_ad;
        private System.Windows.Forms.Button btn_search_Computer;
        private System.Windows.Forms.Button btn_create_Computer;
        private System.Windows.Forms.Panel main_panel_container_newComp_ad;
        private System.Windows.Forms.Panel header_panel_newComp_ad;
        private System.Windows.Forms.PictureBox close_btn_newComp_AD;
    }
}