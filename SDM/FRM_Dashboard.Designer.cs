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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart_ad_status = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txt_dashboard = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart_ad_status)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_ad_status
            // 
            this.chart_ad_status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.chart_ad_status.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart_ad_status.ChartAreas.Add(chartArea1);
            this.chart_ad_status.Cursor = System.Windows.Forms.Cursors.SizeAll;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.ForeColor = System.Drawing.Color.White;
            legend1.Name = "Legend1";
            this.chart_ad_status.Legends.Add(legend1);
            this.chart_ad_status.Location = new System.Drawing.Point(12, 256);
            this.chart_ad_status.Name = "chart_ad_status";
            this.chart_ad_status.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.White;
            series1.LabelBackColor = System.Drawing.Color.Transparent;
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.Name = "Total";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
            this.chart_ad_status.Series.Add(series1);
            this.chart_ad_status.Size = new System.Drawing.Size(705, 303);
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
            // FRM_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(729, 571);
            this.Controls.Add(this.txt_dashboard);
            this.Controls.Add(this.chart_ad_status);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_Dashboard";
            this.Text = "FRM_Dashboard";
            this.Load += new System.EventHandler(this.FRM_Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_ad_status)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_ad_status;
        private System.Windows.Forms.Label txt_dashboard;
    }
}