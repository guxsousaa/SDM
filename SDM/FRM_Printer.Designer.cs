
namespace SDM
{
    partial class FRM_Printer
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
            this.btn_ping_computer = new System.Windows.Forms.Button();
            this.input_compName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_ping_computer
            // 
            this.btn_ping_computer.FlatAppearance.BorderSize = 0;
            this.btn_ping_computer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ping_computer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ping_computer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_ping_computer.Location = new System.Drawing.Point(372, 12);
            this.btn_ping_computer.Name = "btn_ping_computer";
            this.btn_ping_computer.Size = new System.Drawing.Size(147, 33);
            this.btn_ping_computer.TabIndex = 1;
            this.btn_ping_computer.Text = "Is online?";
            this.btn_ping_computer.UseVisualStyleBackColor = true;
            this.btn_ping_computer.Click += new System.EventHandler(this.btn_ping_computer_Click);
            // 
            // input_compName
            // 
            this.input_compName.Location = new System.Drawing.Point(12, 12);
            this.input_compName.Name = "input_compName";
            this.input_compName.Size = new System.Drawing.Size(100, 20);
            this.input_compName.TabIndex = 2;
            // 
            // FRM_Printer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(531, 425);
            this.Controls.Add(this.input_compName);
            this.Controls.Add(this.btn_ping_computer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_Printer";
            this.Text = "FRM_Printer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ping_computer;
        private System.Windows.Forms.TextBox input_compName;
    }
}