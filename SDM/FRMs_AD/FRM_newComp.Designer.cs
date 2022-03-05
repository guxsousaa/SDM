
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
            this.txt_comp_desc = new System.Windows.Forms.Label();
            this.header_panel_newComp_ad = new System.Windows.Forms.Panel();
            this.close_btn_newComp_AD = new System.Windows.Forms.PictureBox();
            this.main_panel_container_newComp_ad.SuspendLayout();
            this.header_panel_newComp_ad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn_newComp_AD)).BeginInit();
            this.SuspendLayout();
            // 
            // input_computerName_ad
            // 
            this.input_computerName_ad.Location = new System.Drawing.Point(7, 36);
            this.input_computerName_ad.Margin = new System.Windows.Forms.Padding(4);
            this.input_computerName_ad.MaxLength = 24;
            this.input_computerName_ad.Name = "input_computerName_ad";
            this.input_computerName_ad.Size = new System.Drawing.Size(220, 22);
            this.input_computerName_ad.TabIndex = 0;
            this.input_computerName_ad.TextChanged += new System.EventHandler(this.input_computerName_ad_TextChanged);
            // 
            // btn_search_Computer
            // 
            this.btn_search_Computer.Location = new System.Drawing.Point(349, 36);
            this.btn_search_Computer.Margin = new System.Windows.Forms.Padding(4);
            this.btn_search_Computer.Name = "btn_search_Computer";
            this.btn_search_Computer.Size = new System.Drawing.Size(100, 38);
            this.btn_search_Computer.TabIndex = 1;
            this.btn_search_Computer.Text = "Search";
            this.btn_search_Computer.UseVisualStyleBackColor = true;
            this.btn_search_Computer.Click += new System.EventHandler(this.btn_search_Computer_Click);
            // 
            // btn_create_Computer
            // 
            this.btn_create_Computer.Location = new System.Drawing.Point(349, 81);
            this.btn_create_Computer.Margin = new System.Windows.Forms.Padding(4);
            this.btn_create_Computer.Name = "btn_create_Computer";
            this.btn_create_Computer.Size = new System.Drawing.Size(100, 38);
            this.btn_create_Computer.TabIndex = 2;
            this.btn_create_Computer.Text = "Create";
            this.btn_create_Computer.UseVisualStyleBackColor = true;
            this.btn_create_Computer.Click += new System.EventHandler(this.btn_create_Computer_Click);
            // 
            // main_panel_container_newComp_ad
            // 
            this.main_panel_container_newComp_ad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.main_panel_container_newComp_ad.Controls.Add(this.txt_comp_desc);
            this.main_panel_container_newComp_ad.Controls.Add(this.btn_create_Computer);
            this.main_panel_container_newComp_ad.Controls.Add(this.header_panel_newComp_ad);
            this.main_panel_container_newComp_ad.Controls.Add(this.btn_search_Computer);
            this.main_panel_container_newComp_ad.Controls.Add(this.input_computerName_ad);
            this.main_panel_container_newComp_ad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_panel_container_newComp_ad.Location = new System.Drawing.Point(0, 0);
            this.main_panel_container_newComp_ad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.main_panel_container_newComp_ad.Name = "main_panel_container_newComp_ad";
            this.main_panel_container_newComp_ad.Size = new System.Drawing.Size(463, 453);
            this.main_panel_container_newComp_ad.TabIndex = 3;
            // 
            // txt_comp_desc
            // 
            this.txt_comp_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_comp_desc.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_comp_desc.Location = new System.Drawing.Point(4, 71);
            this.txt_comp_desc.Name = "txt_comp_desc";
            this.txt_comp_desc.Size = new System.Drawing.Size(338, 90);
            this.txt_comp_desc.TabIndex = 3;
            this.txt_comp_desc.Text = "Waiting...";
            // 
            // header_panel_newComp_ad
            // 
            this.header_panel_newComp_ad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.header_panel_newComp_ad.Controls.Add(this.close_btn_newComp_AD);
            this.header_panel_newComp_ad.Dock = System.Windows.Forms.DockStyle.Top;
            this.header_panel_newComp_ad.Location = new System.Drawing.Point(0, 0);
            this.header_panel_newComp_ad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.header_panel_newComp_ad.Name = "header_panel_newComp_ad";
            this.header_panel_newComp_ad.Size = new System.Drawing.Size(463, 30);
            this.header_panel_newComp_ad.TabIndex = 0;
            this.header_panel_newComp_ad.MouseDown += new System.Windows.Forms.MouseEventHandler(this.header_panel_newComp_ad_MouseDown);
            // 
            // close_btn_newComp_AD
            // 
            this.close_btn_newComp_AD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_btn_newComp_AD.Image = ((System.Drawing.Image)(resources.GetObject("close_btn_newComp_AD.Image")));
            this.close_btn_newComp_AD.Location = new System.Drawing.Point(431, 2);
            this.close_btn_newComp_AD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.close_btn_newComp_AD.Name = "close_btn_newComp_AD";
            this.close_btn_newComp_AD.Size = new System.Drawing.Size(20, 20);
            this.close_btn_newComp_AD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close_btn_newComp_AD.TabIndex = 1;
            this.close_btn_newComp_AD.TabStop = false;
            this.close_btn_newComp_AD.Click += new System.EventHandler(this.close_btn_newComp_AD_Click);
            // 
            // FRM_newComp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 453);
            this.Controls.Add(this.main_panel_container_newComp_ad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Label txt_comp_desc;
    }
}