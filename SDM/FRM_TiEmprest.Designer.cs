
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
            this.main_panel_tiemprest = new System.Windows.Forms.Panel();
            this.panel_top_container_tiemprest = new System.Windows.Forms.Panel();
            this.txt_tiemprest = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_block_tiemprest = new System.Windows.Forms.Button();
            this.btn_shutdown_ti = new System.Windows.Forms.Button();
            this.btn_UnBlock = new System.Windows.Forms.Button();
            this.panel_container = new System.Windows.Forms.Panel();
            this.btn_check_status = new System.Windows.Forms.Button();
            this.txt_status_online = new System.Windows.Forms.Label();
            this.txt_status_currentUser = new System.Windows.Forms.Label();
            this.txt_response_status = new System.Windows.Forms.Label();
            this.txt_status_ntb = new System.Windows.Forms.Label();
            this.txt_response_currentUser = new System.Windows.Forms.Label();
            this.txt_response_online = new System.Windows.Forms.Label();
            this.main_panel_tiemprest.SuspendLayout();
            this.panel_top_container_tiemprest.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_container.SuspendLayout();
            this.SuspendLayout();
            // 
            // input_compName
            // 
            this.input_compName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_compName.Location = new System.Drawing.Point(9, 9);
            this.input_compName.Margin = new System.Windows.Forms.Padding(4);
            this.input_compName.Name = "input_compName";
            this.input_compName.Size = new System.Drawing.Size(209, 24);
            this.input_compName.TabIndex = 4;
            this.input_compName.TextChanged += new System.EventHandler(this.input_compName_TextChanged);
            this.input_compName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.input_compName_KeyDown);
            // 
            // main_panel_tiemprest
            // 
            this.main_panel_tiemprest.Controls.Add(this.panel_top_container_tiemprest);
            this.main_panel_tiemprest.Controls.Add(this.panel1);
            this.main_panel_tiemprest.Controls.Add(this.panel_container);
            this.main_panel_tiemprest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_panel_tiemprest.Location = new System.Drawing.Point(0, 0);
            this.main_panel_tiemprest.Name = "main_panel_tiemprest";
            this.main_panel_tiemprest.Size = new System.Drawing.Size(729, 571);
            this.main_panel_tiemprest.TabIndex = 6;
            // 
            // panel_top_container_tiemprest
            // 
            this.panel_top_container_tiemprest.Controls.Add(this.txt_tiemprest);
            this.panel_top_container_tiemprest.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top_container_tiemprest.Location = new System.Drawing.Point(0, 0);
            this.panel_top_container_tiemprest.Margin = new System.Windows.Forms.Padding(4);
            this.panel_top_container_tiemprest.Name = "panel_top_container_tiemprest";
            this.panel_top_container_tiemprest.Size = new System.Drawing.Size(729, 58);
            this.panel_top_container_tiemprest.TabIndex = 14;
            // 
            // txt_tiemprest
            // 
            this.txt_tiemprest.AutoSize = true;
            this.txt_tiemprest.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tiemprest.ForeColor = System.Drawing.Color.White;
            this.txt_tiemprest.Location = new System.Drawing.Point(12, 9);
            this.txt_tiemprest.Name = "txt_tiemprest";
            this.txt_tiemprest.Size = new System.Drawing.Size(174, 32);
            this.txt_tiemprest.TabIndex = 4;
            this.txt_tiemprest.Text = "TIEMPREST";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(71)))), ((int)(((byte)(93)))));
            this.panel1.Controls.Add(this.btn_block_tiemprest);
            this.panel1.Controls.Add(this.btn_shutdown_ti);
            this.panel1.Controls.Add(this.btn_UnBlock);
            this.panel1.Location = new System.Drawing.Point(18, 164);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(446, 54);
            this.panel1.TabIndex = 13;
            // 
            // btn_block_tiemprest
            // 
            this.btn_block_tiemprest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_block_tiemprest.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_block_tiemprest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_block_tiemprest.Location = new System.Drawing.Point(9, 9);
            this.btn_block_tiemprest.Margin = new System.Windows.Forms.Padding(4);
            this.btn_block_tiemprest.Name = "btn_block_tiemprest";
            this.btn_block_tiemprest.Size = new System.Drawing.Size(138, 36);
            this.btn_block_tiemprest.TabIndex = 1;
            this.btn_block_tiemprest.Text = "Do Block";
            this.btn_block_tiemprest.UseVisualStyleBackColor = true;
            this.btn_block_tiemprest.Click += new System.EventHandler(this.btn_block_tiemprest_Click);
            // 
            // btn_shutdown_ti
            // 
            this.btn_shutdown_ti.AutoSize = true;
            this.btn_shutdown_ti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_shutdown_ti.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_shutdown_ti.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_shutdown_ti.Location = new System.Drawing.Point(299, 9);
            this.btn_shutdown_ti.Margin = new System.Windows.Forms.Padding(4);
            this.btn_shutdown_ti.Name = "btn_shutdown_ti";
            this.btn_shutdown_ti.Size = new System.Drawing.Size(136, 36);
            this.btn_shutdown_ti.TabIndex = 12;
            this.btn_shutdown_ti.Text = "Shutdown";
            this.btn_shutdown_ti.UseVisualStyleBackColor = true;
            this.btn_shutdown_ti.Click += new System.EventHandler(this.btn_shutdown_ti_Click_1);
            // 
            // btn_UnBlock
            // 
            this.btn_UnBlock.AutoSize = true;
            this.btn_UnBlock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UnBlock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UnBlock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_UnBlock.Location = new System.Drawing.Point(155, 9);
            this.btn_UnBlock.Margin = new System.Windows.Forms.Padding(4);
            this.btn_UnBlock.Name = "btn_UnBlock";
            this.btn_UnBlock.Size = new System.Drawing.Size(136, 36);
            this.btn_UnBlock.TabIndex = 2;
            this.btn_UnBlock.Text = "Un Block";
            this.btn_UnBlock.UseVisualStyleBackColor = true;
            this.btn_UnBlock.Click += new System.EventHandler(this.btn_UnBlock_Click);
            // 
            // panel_container
            // 
            this.panel_container.AutoSize = true;
            this.panel_container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(71)))), ((int)(((byte)(93)))));
            this.panel_container.Controls.Add(this.input_compName);
            this.panel_container.Controls.Add(this.btn_check_status);
            this.panel_container.Controls.Add(this.txt_status_online);
            this.panel_container.Controls.Add(this.txt_status_currentUser);
            this.panel_container.Controls.Add(this.txt_response_status);
            this.panel_container.Controls.Add(this.txt_status_ntb);
            this.panel_container.Controls.Add(this.txt_response_currentUser);
            this.panel_container.Controls.Add(this.txt_response_online);
            this.panel_container.Location = new System.Drawing.Point(18, 65);
            this.panel_container.Name = "panel_container";
            this.panel_container.Padding = new System.Windows.Forms.Padding(5);
            this.panel_container.Size = new System.Drawing.Size(446, 93);
            this.panel_container.TabIndex = 7;
            // 
            // btn_check_status
            // 
            this.btn_check_status.BackColor = System.Drawing.Color.Transparent;
            this.btn_check_status.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_check_status.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_check_status.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(121)))), ((int)(((byte)(143)))));
            this.btn_check_status.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(71)))), ((int)(((byte)(93)))));
            this.btn_check_status.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_check_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_check_status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_check_status.Location = new System.Drawing.Point(9, 41);
            this.btn_check_status.Margin = new System.Windows.Forms.Padding(4);
            this.btn_check_status.Name = "btn_check_status";
            this.btn_check_status.Size = new System.Drawing.Size(209, 41);
            this.btn_check_status.TabIndex = 5;
            this.btn_check_status.Text = "Check Status";
            this.btn_check_status.UseVisualStyleBackColor = false;
            this.btn_check_status.Click += new System.EventHandler(this.btn_check_statusClick);
            // 
            // txt_status_online
            // 
            this.txt_status_online.AutoSize = true;
            this.txt_status_online.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_status_online.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_status_online.Location = new System.Drawing.Point(225, 9);
            this.txt_status_online.Name = "txt_status_online";
            this.txt_status_online.Size = new System.Drawing.Size(85, 22);
            this.txt_status_online.TabIndex = 6;
            this.txt_status_online.Text = "Is Online:";
            // 
            // txt_status_currentUser
            // 
            this.txt_status_currentUser.AutoSize = true;
            this.txt_status_currentUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_status_currentUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_status_currentUser.Location = new System.Drawing.Point(225, 31);
            this.txt_status_currentUser.Name = "txt_status_currentUser";
            this.txt_status_currentUser.Size = new System.Drawing.Size(118, 22);
            this.txt_status_currentUser.TabIndex = 7;
            this.txt_status_currentUser.Text = "Current User:";
            // 
            // txt_response_status
            // 
            this.txt_response_status.AutoSize = true;
            this.txt_response_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_response_status.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_response_status.Location = new System.Drawing.Point(297, 53);
            this.txt_response_status.Name = "txt_response_status";
            this.txt_response_status.Size = new System.Drawing.Size(81, 22);
            this.txt_response_status.TabIndex = 11;
            this.txt_response_status.Text = "Wating...";
            // 
            // txt_status_ntb
            // 
            this.txt_status_ntb.AutoSize = true;
            this.txt_status_ntb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_status_ntb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_status_ntb.Location = new System.Drawing.Point(225, 50);
            this.txt_status_ntb.Name = "txt_status_ntb";
            this.txt_status_ntb.Size = new System.Drawing.Size(66, 22);
            this.txt_status_ntb.TabIndex = 8;
            this.txt_status_ntb.Text = "Status:";
            // 
            // txt_response_currentUser
            // 
            this.txt_response_currentUser.AutoSize = true;
            this.txt_response_currentUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_response_currentUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_response_currentUser.Location = new System.Drawing.Point(349, 31);
            this.txt_response_currentUser.Name = "txt_response_currentUser";
            this.txt_response_currentUser.Size = new System.Drawing.Size(81, 22);
            this.txt_response_currentUser.TabIndex = 10;
            this.txt_response_currentUser.Text = "Wating...";
            // 
            // txt_response_online
            // 
            this.txt_response_online.AutoSize = true;
            this.txt_response_online.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_response_online.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_response_online.Location = new System.Drawing.Point(316, 9);
            this.txt_response_online.Name = "txt_response_online";
            this.txt_response_online.Size = new System.Drawing.Size(81, 22);
            this.txt_response_online.TabIndex = 9;
            this.txt_response_online.Text = "Wating...";
            // 
            // FRM_TiEmprest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(729, 571);
            this.Controls.Add(this.main_panel_tiemprest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRM_TiEmprest";
            this.Text = "FRM_TiEmprest";
            this.Load += new System.EventHandler(this.FRM_TiEmprest_Load);
            this.main_panel_tiemprest.ResumeLayout(false);
            this.main_panel_tiemprest.PerformLayout();
            this.panel_top_container_tiemprest.ResumeLayout(false);
            this.panel_top_container_tiemprest.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_container.ResumeLayout(false);
            this.panel_container.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox input_compName;
        private System.Windows.Forms.Panel main_panel_tiemprest;
        private System.Windows.Forms.Button btn_block_tiemprest;
        private System.Windows.Forms.Label txt_status_ntb;
        private System.Windows.Forms.Label txt_status_currentUser;
        private System.Windows.Forms.Label txt_status_online;
        private System.Windows.Forms.Button btn_check_status;
        private System.Windows.Forms.Button btn_UnBlock;
        private System.Windows.Forms.Label txt_response_status;
        private System.Windows.Forms.Label txt_response_currentUser;
        private System.Windows.Forms.Label txt_response_online;
        private System.Windows.Forms.Button btn_shutdown_ti;
        private System.Windows.Forms.Panel panel_container;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_top_container_tiemprest;
        private System.Windows.Forms.Label txt_tiemprest;
    }
}