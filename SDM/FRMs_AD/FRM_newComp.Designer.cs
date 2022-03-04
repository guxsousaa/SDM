
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
            this.input_computerName_ad = new System.Windows.Forms.TextBox();
            this.btn_search_Computer = new System.Windows.Forms.Button();
            this.btn_create_Computer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // input_computerName_ad
            // 
            this.input_computerName_ad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input_computerName_ad.Location = new System.Drawing.Point(3, 12);
            this.input_computerName_ad.Name = "input_computerName_ad";
            this.input_computerName_ad.Size = new System.Drawing.Size(130, 20);
            this.input_computerName_ad.TabIndex = 0;
            // 
            // btn_search_Computer
            // 
            this.btn_search_Computer.Location = new System.Drawing.Point(260, 12);
            this.btn_search_Computer.Name = "btn_search_Computer";
            this.btn_search_Computer.Size = new System.Drawing.Size(75, 31);
            this.btn_search_Computer.TabIndex = 1;
            this.btn_search_Computer.Text = "Search";
            this.btn_search_Computer.UseVisualStyleBackColor = true;
            // 
            // btn_create_Computer
            // 
            this.btn_create_Computer.Location = new System.Drawing.Point(260, 49);
            this.btn_create_Computer.Name = "btn_create_Computer";
            this.btn_create_Computer.Size = new System.Drawing.Size(75, 31);
            this.btn_create_Computer.TabIndex = 2;
            this.btn_create_Computer.Text = "Create";
            this.btn_create_Computer.UseVisualStyleBackColor = true;
            // 
            // FRM_newComp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 368);
            this.Controls.Add(this.btn_create_Computer);
            this.Controls.Add(this.btn_search_Computer);
            this.Controls.Add(this.input_computerName_ad);
            this.Name = "FRM_newComp";
            this.Text = "Create new computer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input_computerName_ad;
        private System.Windows.Forms.Button btn_search_Computer;
        private System.Windows.Forms.Button btn_create_Computer;
    }
}