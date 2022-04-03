
namespace SDM.FRMs_TiEmprest.Dialogs
{
    partial class FRM_Notify_Options
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Notify_Options));
            this.lbl_notify = new System.Windows.Forms.Label();
            this.btn_return_loan = new System.Windows.Forms.Button();
            this.btn_new_loan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_notify
            // 
            this.lbl_notify.AutoSize = true;
            this.lbl_notify.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_notify.ForeColor = System.Drawing.Color.White;
            this.lbl_notify.Location = new System.Drawing.Point(12, 9);
            this.lbl_notify.Name = "lbl_notify";
            this.lbl_notify.Size = new System.Drawing.Size(169, 20);
            this.lbl_notify.TabIndex = 0;
            this.lbl_notify.Text = "Quero notificar um(a)";
            // 
            // btn_return_loan
            // 
            this.btn_return_loan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_return_loan.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_return_loan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_return_loan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_return_loan.ForeColor = System.Drawing.Color.White;
            this.btn_return_loan.Location = new System.Drawing.Point(12, 75);
            this.btn_return_loan.Name = "btn_return_loan";
            this.btn_return_loan.Size = new System.Drawing.Size(169, 37);
            this.btn_return_loan.TabIndex = 3;
            this.btn_return_loan.Text = "Devolução";
            this.btn_return_loan.UseVisualStyleBackColor = true;
            this.btn_return_loan.Click += new System.EventHandler(this.btn_return_loan_Click);
            // 
            // btn_new_loan
            // 
            this.btn_new_loan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_new_loan.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_new_loan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_new_loan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new_loan.ForeColor = System.Drawing.Color.White;
            this.btn_new_loan.Location = new System.Drawing.Point(12, 32);
            this.btn_new_loan.Name = "btn_new_loan";
            this.btn_new_loan.Size = new System.Drawing.Size(169, 37);
            this.btn_new_loan.TabIndex = 4;
            this.btn_new_loan.Text = "Emprestimo";
            this.btn_new_loan.UseVisualStyleBackColor = true;
            this.btn_new_loan.Click += new System.EventHandler(this.btn_new_loan_Click);
            // 
            // FRM_Notify_Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(265, 125);
            this.Controls.Add(this.btn_new_loan);
            this.Controls.Add(this.btn_return_loan);
            this.Controls.Add(this.lbl_notify);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRM_Notify_Options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SDM - Opções de notificação";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_notify;
        private System.Windows.Forms.Button btn_return_loan;
        private System.Windows.Forms.Button btn_new_loan;
    }
}