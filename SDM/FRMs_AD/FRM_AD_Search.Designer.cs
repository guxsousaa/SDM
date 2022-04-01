namespace SDM.FRMs_AD
{
    partial class FRM_AD_Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_AD_Search));
            this.btn_search_Computer = new System.Windows.Forms.Button();
            this.input_computerName_ad = new System.Windows.Forms.TextBox();
            this.header_panel_SearchComp_ad = new System.Windows.Forms.Panel();
            this.txt_header_title_searchComp = new System.Windows.Forms.Label();
            this.close_btn_SearchAd_AD = new System.Windows.Forms.PictureBox();
            this.txt_compResult = new System.Windows.Forms.Label();
            this.panel_container = new System.Windows.Forms.Panel();
            this.panel_container_result = new System.Windows.Forms.Panel();
            this.panel_container_search = new System.Windows.Forms.Panel();
            this.header_panel_SearchComp_ad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn_SearchAd_AD)).BeginInit();
            this.panel_container.SuspendLayout();
            this.panel_container_result.SuspendLayout();
            this.panel_container_search.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_search_Computer
            // 
            this.btn_search_Computer.AutoSize = true;
            this.btn_search_Computer.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_search_Computer.Location = new System.Drawing.Point(400, 0);
            this.btn_search_Computer.Margin = new System.Windows.Forms.Padding(4);
            this.btn_search_Computer.Name = "btn_search_Computer";
            this.btn_search_Computer.Size = new System.Drawing.Size(100, 62);
            this.btn_search_Computer.TabIndex = 3;
            this.btn_search_Computer.Text = "Procurar";
            this.btn_search_Computer.UseVisualStyleBackColor = true;
            this.btn_search_Computer.Click += new System.EventHandler(this.btn_search_Computer_Click);
            // 
            // input_computerName_ad
            // 
            this.input_computerName_ad.Location = new System.Drawing.Point(13, 16);
            this.input_computerName_ad.Margin = new System.Windows.Forms.Padding(4);
            this.input_computerName_ad.MaxLength = 24;
            this.input_computerName_ad.Name = "input_computerName_ad";
            this.input_computerName_ad.Size = new System.Drawing.Size(220, 22);
            this.input_computerName_ad.TabIndex = 2;
            this.input_computerName_ad.TextChanged += new System.EventHandler(this.input_computerName_ad_TextChanged);
            // 
            // header_panel_SearchComp_ad
            // 
            this.header_panel_SearchComp_ad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.header_panel_SearchComp_ad.Controls.Add(this.txt_header_title_searchComp);
            this.header_panel_SearchComp_ad.Controls.Add(this.close_btn_SearchAd_AD);
            this.header_panel_SearchComp_ad.Dock = System.Windows.Forms.DockStyle.Top;
            this.header_panel_SearchComp_ad.Location = new System.Drawing.Point(0, 0);
            this.header_panel_SearchComp_ad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.header_panel_SearchComp_ad.Name = "header_panel_SearchComp_ad";
            this.header_panel_SearchComp_ad.Size = new System.Drawing.Size(522, 30);
            this.header_panel_SearchComp_ad.TabIndex = 4;
            this.header_panel_SearchComp_ad.MouseDown += new System.Windows.Forms.MouseEventHandler(this.header_panel_SearchComp_ad_MouseDown);
            // 
            // txt_header_title_searchComp
            // 
            this.txt_header_title_searchComp.Dock = System.Windows.Forms.DockStyle.Left;
            this.txt_header_title_searchComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_header_title_searchComp.ForeColor = System.Drawing.Color.White;
            this.txt_header_title_searchComp.Location = new System.Drawing.Point(0, 0);
            this.txt_header_title_searchComp.Name = "txt_header_title_searchComp";
            this.txt_header_title_searchComp.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.txt_header_title_searchComp.Size = new System.Drawing.Size(316, 30);
            this.txt_header_title_searchComp.TabIndex = 3;
            this.txt_header_title_searchComp.Text = "AD - Search Computer";
            this.txt_header_title_searchComp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_header_title_searchComp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txt_header_title_searchComp_MouseDown);
            // 
            // close_btn_SearchAd_AD
            // 
            this.close_btn_SearchAd_AD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_btn_SearchAd_AD.Image = ((System.Drawing.Image)(resources.GetObject("close_btn_SearchAd_AD.Image")));
            this.close_btn_SearchAd_AD.Location = new System.Drawing.Point(492, 0);
            this.close_btn_SearchAd_AD.Margin = new System.Windows.Forms.Padding(3, 2, 11, 2);
            this.close_btn_SearchAd_AD.Name = "close_btn_SearchAd_AD";
            this.close_btn_SearchAd_AD.Size = new System.Drawing.Size(20, 30);
            this.close_btn_SearchAd_AD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close_btn_SearchAd_AD.TabIndex = 1;
            this.close_btn_SearchAd_AD.TabStop = false;
            this.close_btn_SearchAd_AD.Click += new System.EventHandler(this.close_btn_SearchAd_AD_Click);
            // 
            // txt_compResult
            // 
            this.txt_compResult.AutoSize = true;
            this.txt_compResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_compResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_compResult.ForeColor = System.Drawing.Color.White;
            this.txt_compResult.Location = new System.Drawing.Point(0, 0);
            this.txt_compResult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_compResult.MaximumSize = new System.Drawing.Size(500, 0);
            this.txt_compResult.MinimumSize = new System.Drawing.Size(500, 0);
            this.txt_compResult.Name = "txt_compResult";
            this.txt_compResult.Size = new System.Drawing.Size(500, 25);
            this.txt_compResult.TabIndex = 5;
            this.txt_compResult.Text = "Wating...";
            // 
            // panel_container
            // 
            this.panel_container.AutoSize = true;
            this.panel_container.Controls.Add(this.panel_container_result);
            this.panel_container.Controls.Add(this.panel_container_search);
            this.panel_container.Location = new System.Drawing.Point(0, 30);
            this.panel_container.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_container.MaximumSize = new System.Drawing.Size(500, 0);
            this.panel_container.MinimumSize = new System.Drawing.Size(500, 0);
            this.panel_container.Name = "panel_container";
            this.panel_container.Size = new System.Drawing.Size(500, 89);
            this.panel_container.TabIndex = 6;
            // 
            // panel_container_result
            // 
            this.panel_container_result.AutoSize = true;
            this.panel_container_result.Controls.Add(this.txt_compResult);
            this.panel_container_result.Location = new System.Drawing.Point(0, 62);
            this.panel_container_result.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_container_result.MaximumSize = new System.Drawing.Size(500, 0);
            this.panel_container_result.Name = "panel_container_result";
            this.panel_container_result.Size = new System.Drawing.Size(500, 25);
            this.panel_container_result.TabIndex = 7;
            // 
            // panel_container_search
            // 
            this.panel_container_search.Controls.Add(this.input_computerName_ad);
            this.panel_container_search.Controls.Add(this.btn_search_Computer);
            this.panel_container_search.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_container_search.Location = new System.Drawing.Point(0, 0);
            this.panel_container_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_container_search.Name = "panel_container_search";
            this.panel_container_search.Size = new System.Drawing.Size(500, 62);
            this.panel_container_search.TabIndex = 6;
            // 
            // FRM_AD_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(522, 250);
            this.Controls.Add(this.panel_container);
            this.Controls.Add(this.header_panel_SearchComp_ad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(500, 200);
            this.Name = "FRM_AD_Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_AD_Search";
            this.header_panel_SearchComp_ad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.close_btn_SearchAd_AD)).EndInit();
            this.panel_container.ResumeLayout(false);
            this.panel_container.PerformLayout();
            this.panel_container_result.ResumeLayout(false);
            this.panel_container_result.PerformLayout();
            this.panel_container_search.ResumeLayout(false);
            this.panel_container_search.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_search_Computer;
        private System.Windows.Forms.TextBox input_computerName_ad;
        private System.Windows.Forms.Panel header_panel_SearchComp_ad;
        private System.Windows.Forms.PictureBox close_btn_SearchAd_AD;
        private System.Windows.Forms.Label txt_compResult;
        private System.Windows.Forms.Panel panel_container;
        private System.Windows.Forms.Panel panel_container_result;
        private System.Windows.Forms.Panel panel_container_search;
        private System.Windows.Forms.Label txt_header_title_searchComp;
    }
}