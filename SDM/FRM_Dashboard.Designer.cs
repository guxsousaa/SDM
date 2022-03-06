namespace SDM
{
    partial class FRM_Dashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart_ad_status = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txt_dashboard = new System.Windows.Forms.Label();
            this.panel_container_TIEMPREST_flag = new System.Windows.Forms.Panel();
            this.txt_flag_a_loan = new System.Windows.Forms.Label();
            this.txt_desc_flag_loan = new System.Windows.Forms.Label();
            this.btn_notify_loan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart_ad_status)).BeginInit();
            this.panel_container_TIEMPREST_flag.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart_ad_status
            // 
            this.chart_ad_status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.chart_ad_status.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chart_ad_status.ChartAreas.Add(chartArea2);
            this.chart_ad_status.Cursor = System.Windows.Forms.Cursors.SizeAll;
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.ForeColor = System.Drawing.Color.White;
            legend2.Name = "Legend1";
            this.chart_ad_status.Legends.Add(legend2);
            this.chart_ad_status.Location = new System.Drawing.Point(12, 256);
            this.chart_ad_status.Name = "chart_ad_status";
            this.chart_ad_status.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.White;
            series2.LabelBackColor = System.Drawing.Color.Transparent;
            series2.LabelForeColor = System.Drawing.Color.White;
            series2.Legend = "Legend1";
            series2.Name = "Total";
            series2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
            this.chart_ad_status.Series.Add(series2);
            this.chart_ad_status.Size = new System.Drawing.Size(421, 303);
            this.chart_ad_status.TabIndex = 1;
            this.chart_ad_status.Text = "chart1";
            // 
            // txt_dashboard
            // 
            this.txt_dashboard.AutoSize = true;
            this.txt_dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dashboard.ForeColor = System.Drawing.Color.White;
            this.txt_dashboard.Location = new System.Drawing.Point(12, 9);
            this.txt_dashboard.Name = "txt_dashboard";
            this.txt_dashboard.Size = new System.Drawing.Size(153, 32);
            this.txt_dashboard.TabIndex = 2;
            this.txt_dashboard.Text = "Dashboard";
            // 
            // panel_container_TIEMPREST_flag
            // 
            this.panel_container_TIEMPREST_flag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(71)))), ((int)(((byte)(93)))));
            this.panel_container_TIEMPREST_flag.Controls.Add(this.btn_notify_loan);
            this.panel_container_TIEMPREST_flag.Controls.Add(this.txt_desc_flag_loan);
            this.panel_container_TIEMPREST_flag.Controls.Add(this.txt_flag_a_loan);
            this.panel_container_TIEMPREST_flag.Location = new System.Drawing.Point(18, 57);
            this.panel_container_TIEMPREST_flag.Name = "panel_container_TIEMPREST_flag";
            this.panel_container_TIEMPREST_flag.Size = new System.Drawing.Size(309, 146);
            this.panel_container_TIEMPREST_flag.TabIndex = 3;
            // 
            // txt_flag_a_loan
            // 
            this.txt_flag_a_loan.AutoSize = true;
            this.txt_flag_a_loan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_flag_a_loan.ForeColor = System.Drawing.Color.White;
            this.txt_flag_a_loan.Location = new System.Drawing.Point(13, 13);
            this.txt_flag_a_loan.Name = "txt_flag_a_loan";
            this.txt_flag_a_loan.Size = new System.Drawing.Size(110, 22);
            this.txt_flag_a_loan.TabIndex = 0;
            this.txt_flag_a_loan.Text = "Flag a loan";
            // 
            // txt_desc_flag_loan
            // 
            this.txt_desc_flag_loan.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_desc_flag_loan.Location = new System.Drawing.Point(14, 44);
            this.txt_desc_flag_loan.Name = "txt_desc_flag_loan";
            this.txt_desc_flag_loan.Size = new System.Drawing.Size(276, 59);
            this.txt_desc_flag_loan.TabIndex = 1;
            this.txt_desc_flag_loan.Text = "If you have made a loan and have not notified the person responsible for the loan" +
    ", you can register the loan here.";
            // 
            // btn_notify_loan
            // 
            this.btn_notify_loan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_notify_loan.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_notify_loan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_notify_loan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_notify_loan.ForeColor = System.Drawing.Color.White;
            this.btn_notify_loan.Location = new System.Drawing.Point(17, 97);
            this.btn_notify_loan.Name = "btn_notify_loan";
            this.btn_notify_loan.Size = new System.Drawing.Size(273, 37);
            this.btn_notify_loan.TabIndex = 2;
            this.btn_notify_loan.Text = "Notify";
            this.btn_notify_loan.UseVisualStyleBackColor = true;
            this.btn_notify_loan.Click += new System.EventHandler(this.btn_notify_loan_Click);
            // 
            // FRM_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(729, 571);
            this.Controls.Add(this.panel_container_TIEMPREST_flag);
            this.Controls.Add(this.txt_dashboard);
            this.Controls.Add(this.chart_ad_status);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_Dashboard";
            this.Text = "FRM_Dashboard";
            this.Load += new System.EventHandler(this.FRM_Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_ad_status)).EndInit();
            this.panel_container_TIEMPREST_flag.ResumeLayout(false);
            this.panel_container_TIEMPREST_flag.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_ad_status;
        private System.Windows.Forms.Label txt_dashboard;
        private System.Windows.Forms.Panel panel_container_TIEMPREST_flag;
        private System.Windows.Forms.Label txt_desc_flag_loan;
        private System.Windows.Forms.Label txt_flag_a_loan;
        private System.Windows.Forms.Button btn_notify_loan;
    }
}