namespace SDM.FRMs_AD
{
    partial class FRM_AD_Remove
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_AD_Remove));
            this.panel_container = new System.Windows.Forms.Panel();
            this.panel_container_search = new System.Windows.Forms.Panel();
            this.input_computerName_ad = new System.Windows.Forms.TextBox();
            this.btn_Delete_Computer = new System.Windows.Forms.Button();
            this.header_panel_newComp_ad = new System.Windows.Forms.Panel();
            this.txt_header_title_deleteComp_ad = new System.Windows.Forms.Label();
            this.close_btn_DeleteAd_AD = new System.Windows.Forms.PictureBox();
            this.panel_container.SuspendLayout();
            this.panel_container_search.SuspendLayout();
            this.header_panel_newComp_ad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn_DeleteAd_AD)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_container
            // 
            this.panel_container.AutoSize = true;
            this.panel_container.Controls.Add(this.panel_container_search);
            this.panel_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_container.Location = new System.Drawing.Point(0, 30);
            this.panel_container.Name = "panel_container";
            this.panel_container.Size = new System.Drawing.Size(362, 73);
            this.panel_container.TabIndex = 8;
            // 
            // panel_container_search
            // 
            this.panel_container_search.Controls.Add(this.input_computerName_ad);
            this.panel_container_search.Controls.Add(this.btn_Delete_Computer);
            this.panel_container_search.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_container_search.Location = new System.Drawing.Point(0, 0);
            this.panel_container_search.Name = "panel_container_search";
            this.panel_container_search.Size = new System.Drawing.Size(362, 67);
            this.panel_container_search.TabIndex = 6;
            // 
            // input_computerName_ad
            // 
            this.input_computerName_ad.Location = new System.Drawing.Point(13, 6);
            this.input_computerName_ad.Margin = new System.Windows.Forms.Padding(4);
            this.input_computerName_ad.MaxLength = 24;
            this.input_computerName_ad.Name = "input_computerName_ad";
            this.input_computerName_ad.Size = new System.Drawing.Size(220, 22);
            this.input_computerName_ad.TabIndex = 2;
            // 
            // btn_Delete_Computer
            // 
            this.btn_Delete_Computer.AutoSize = true;
            this.btn_Delete_Computer.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btn_Delete_Computer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete_Computer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete_Computer.ForeColor = System.Drawing.Color.White;
            this.btn_Delete_Computer.Location = new System.Drawing.Point(252, 5);
            this.btn_Delete_Computer.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Delete_Computer.Name = "btn_Delete_Computer";
            this.btn_Delete_Computer.Size = new System.Drawing.Size(100, 62);
            this.btn_Delete_Computer.TabIndex = 3;
            this.btn_Delete_Computer.Text = "Delete";
            this.btn_Delete_Computer.UseVisualStyleBackColor = true;
            this.btn_Delete_Computer.Click += new System.EventHandler(this.btn_Delete_Computer_Click);
            // 
            // header_panel_newComp_ad
            // 
            this.header_panel_newComp_ad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.header_panel_newComp_ad.Controls.Add(this.txt_header_title_deleteComp_ad);
            this.header_panel_newComp_ad.Controls.Add(this.close_btn_DeleteAd_AD);
            this.header_panel_newComp_ad.Dock = System.Windows.Forms.DockStyle.Top;
            this.header_panel_newComp_ad.Location = new System.Drawing.Point(0, 0);
            this.header_panel_newComp_ad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.header_panel_newComp_ad.Name = "header_panel_newComp_ad";
            this.header_panel_newComp_ad.Size = new System.Drawing.Size(362, 30);
            this.header_panel_newComp_ad.TabIndex = 7;
            this.header_panel_newComp_ad.MouseDown += new System.Windows.Forms.MouseEventHandler(this.header_panel_newComp_ad_MouseDown);
            // 
            // txt_header_title_deleteComp_ad
            // 
            this.txt_header_title_deleteComp_ad.Dock = System.Windows.Forms.DockStyle.Left;
            this.txt_header_title_deleteComp_ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_header_title_deleteComp_ad.ForeColor = System.Drawing.Color.White;
            this.txt_header_title_deleteComp_ad.Location = new System.Drawing.Point(0, 0);
            this.txt_header_title_deleteComp_ad.Name = "txt_header_title_deleteComp_ad";
            this.txt_header_title_deleteComp_ad.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.txt_header_title_deleteComp_ad.Size = new System.Drawing.Size(326, 30);
            this.txt_header_title_deleteComp_ad.TabIndex = 2;
            this.txt_header_title_deleteComp_ad.Text = "AD - Delete Computer";
            this.txt_header_title_deleteComp_ad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_header_title_deleteComp_ad.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txt_header_title_deleteComp_ad_MouseDown);
            // 
            // close_btn_DeleteAd_AD
            // 
            this.close_btn_DeleteAd_AD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_btn_DeleteAd_AD.Image = ((System.Drawing.Image)(resources.GetObject("close_btn_DeleteAd_AD.Image")));
            this.close_btn_DeleteAd_AD.Location = new System.Drawing.Point(332, 2);
            this.close_btn_DeleteAd_AD.Margin = new System.Windows.Forms.Padding(3, 2, 10, 2);
            this.close_btn_DeleteAd_AD.Name = "close_btn_DeleteAd_AD";
            this.close_btn_DeleteAd_AD.Size = new System.Drawing.Size(20, 30);
            this.close_btn_DeleteAd_AD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close_btn_DeleteAd_AD.TabIndex = 1;
            this.close_btn_DeleteAd_AD.TabStop = false;
            this.close_btn_DeleteAd_AD.Click += new System.EventHandler(this.close_btn_DeleteAd_AD_Click);
            // 
            // FRM_AD_Remove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(362, 103);
            this.Controls.Add(this.panel_container);
            this.Controls.Add(this.header_panel_newComp_ad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_AD_Remove";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_AD_Remove";
            this.panel_container.ResumeLayout(false);
            this.panel_container_search.ResumeLayout(false);
            this.panel_container_search.PerformLayout();
            this.header_panel_newComp_ad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.close_btn_DeleteAd_AD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_container;
        private System.Windows.Forms.Panel panel_container_search;
        private System.Windows.Forms.TextBox input_computerName_ad;
        private System.Windows.Forms.Button btn_Delete_Computer;
        private System.Windows.Forms.Panel header_panel_newComp_ad;
        private System.Windows.Forms.PictureBox close_btn_DeleteAd_AD;
        private System.Windows.Forms.Label txt_header_title_deleteComp_ad;
    }
}