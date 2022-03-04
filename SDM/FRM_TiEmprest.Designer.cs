
namespace SDM
{
    partial class FRM_TiEmprest
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
            this.input_compName = new System.Windows.Forms.TextBox();
            this.btn_shutdown_ti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // input_compName
            // 
            this.input_compName.Location = new System.Drawing.Point(28, 12);
            this.input_compName.Name = "input_compName";
            this.input_compName.Size = new System.Drawing.Size(100, 20);
            this.input_compName.TabIndex = 4;
            // 
            // btn_shutdown_ti
            // 
            this.btn_shutdown_ti.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_shutdown_ti.Location = new System.Drawing.Point(437, 12);
            this.btn_shutdown_ti.Name = "btn_shutdown_ti";
            this.btn_shutdown_ti.Size = new System.Drawing.Size(98, 44);
            this.btn_shutdown_ti.TabIndex = 5;
            this.btn_shutdown_ti.Text = "Showdown";
            this.btn_shutdown_ti.UseVisualStyleBackColor = true;
            this.btn_shutdown_ti.Click += new System.EventHandler(this.btn_shutdown_ti_Click);
            // 
            // FRM_TiEmprest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 464);
            this.Controls.Add(this.btn_shutdown_ti);
            this.Controls.Add(this.input_compName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_TiEmprest";
            this.Text = "FRM_TiEmprest";
            this.Load += new System.EventHandler(this.FRM_TiEmprest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input_compName;
        private System.Windows.Forms.Button btn_shutdown_ti;
    }
}