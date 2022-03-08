namespace SDM.FRMs_TraumaZero0
{
    partial class FRM_Tr0_ThrowAgent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Tr0_ThrowAgent));
            this.txt_computer_name = new System.Windows.Forms.Label();
            this.input_computer_name = new System.Windows.Forms.TextBox();
            this.btn_throwAgent = new System.Windows.Forms.Button();
            this.txt_my_ip = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_computer_name
            // 
            this.txt_computer_name.AutoSize = true;
            this.txt_computer_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_computer_name.ForeColor = System.Drawing.Color.White;
            this.txt_computer_name.Location = new System.Drawing.Point(12, 9);
            this.txt_computer_name.Name = "txt_computer_name";
            this.txt_computer_name.Size = new System.Drawing.Size(133, 20);
            this.txt_computer_name.TabIndex = 0;
            this.txt_computer_name.Text = "Computer name:";
            // 
            // input_computer_name
            // 
            this.input_computer_name.Location = new System.Drawing.Point(216, 9);
            this.input_computer_name.Name = "input_computer_name";
            this.input_computer_name.Size = new System.Drawing.Size(216, 22);
            this.input_computer_name.TabIndex = 1;
            // 
            // btn_throwAgent
            // 
            this.btn_throwAgent.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_throwAgent.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_throwAgent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_throwAgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_throwAgent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_throwAgent.Location = new System.Drawing.Point(216, 42);
            this.btn_throwAgent.Margin = new System.Windows.Forms.Padding(4);
            this.btn_throwAgent.Name = "btn_throwAgent";
            this.btn_throwAgent.Size = new System.Drawing.Size(216, 41);
            this.btn_throwAgent.TabIndex = 2;
            this.btn_throwAgent.Text = "Throw Agent";
            this.btn_throwAgent.UseVisualStyleBackColor = true;
            this.btn_throwAgent.Click += new System.EventHandler(this.btn_throwAgent_Click);
            // 
            // txt_my_ip
            // 
            this.txt_my_ip.AutoSize = true;
            this.txt_my_ip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_my_ip.ForeColor = System.Drawing.Color.White;
            this.txt_my_ip.Location = new System.Drawing.Point(12, 29);
            this.txt_my_ip.Name = "txt_my_ip";
            this.txt_my_ip.Size = new System.Drawing.Size(54, 20);
            this.txt_my_ip.TabIndex = 3;
            this.txt_my_ip.Text = "My ip:";
            // 
            // FRM_Tr0_ThrowAgent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(471, 96);
            this.Controls.Add(this.txt_my_ip);
            this.Controls.Add(this.btn_throwAgent);
            this.Controls.Add(this.input_computer_name);
            this.Controls.Add(this.txt_computer_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRM_Tr0_ThrowAgent";
            this.Text = "SDM - Throw TraumaZer0 Agent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_computer_name;
        private System.Windows.Forms.TextBox input_computer_name;
        private System.Windows.Forms.Button btn_throwAgent;
        private System.Windows.Forms.Label txt_my_ip;
    }
}