
namespace SDM
{
    partial class FRM_Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Settings));
            this.panel_win_btns_main = new System.Windows.Forms.Panel();
            this.minimize_btn = new System.Windows.Forms.PictureBox();
            this.close_btn = new System.Windows.Forms.PictureBox();
            this.btn_update_BaseComp = new System.Windows.Forms.Button();
            this.txt_lastUpdateTime_CompBase = new System.Windows.Forms.Label();
            this.panel_win_btns_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_win_btns_main
            // 
            this.panel_win_btns_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.panel_win_btns_main.Controls.Add(this.minimize_btn);
            this.panel_win_btns_main.Controls.Add(this.close_btn);
            this.panel_win_btns_main.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_win_btns_main.Location = new System.Drawing.Point(0, 0);
            this.panel_win_btns_main.Margin = new System.Windows.Forms.Padding(2);
            this.panel_win_btns_main.Name = "panel_win_btns_main";
            this.panel_win_btns_main.Size = new System.Drawing.Size(400, 20);
            this.panel_win_btns_main.TabIndex = 1;
            this.panel_win_btns_main.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_win_btns_main_MouseDown);
            // 
            // minimize_btn
            // 
            this.minimize_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimize_btn.Image = ((System.Drawing.Image)(resources.GetObject("minimize_btn.Image")));
            this.minimize_btn.Location = new System.Drawing.Point(354, 2);
            this.minimize_btn.Margin = new System.Windows.Forms.Padding(2);
            this.minimize_btn.Name = "minimize_btn";
            this.minimize_btn.Size = new System.Drawing.Size(15, 16);
            this.minimize_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimize_btn.TabIndex = 1;
            this.minimize_btn.TabStop = false;
            this.minimize_btn.Click += new System.EventHandler(this.minimize_btn_Click);
            // 
            // close_btn
            // 
            this.close_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_btn.Image = ((System.Drawing.Image)(resources.GetObject("close_btn.Image")));
            this.close_btn.Location = new System.Drawing.Point(374, 2);
            this.close_btn.Margin = new System.Windows.Forms.Padding(2);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(15, 16);
            this.close_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close_btn.TabIndex = 0;
            this.close_btn.TabStop = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // btn_update_BaseComp
            // 
            this.btn_update_BaseComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update_BaseComp.Location = new System.Drawing.Point(12, 34);
            this.btn_update_BaseComp.Name = "btn_update_BaseComp";
            this.btn_update_BaseComp.Size = new System.Drawing.Size(98, 44);
            this.btn_update_BaseComp.TabIndex = 2;
            this.btn_update_BaseComp.Text = "Update Base";
            this.btn_update_BaseComp.UseVisualStyleBackColor = true;
            this.btn_update_BaseComp.Click += new System.EventHandler(this.btn_update_BaseComp_Click);
            // 
            // txt_lastUpdateTime_CompBase
            // 
            this.txt_lastUpdateTime_CompBase.AutoSize = true;
            this.txt_lastUpdateTime_CompBase.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_lastUpdateTime_CompBase.Location = new System.Drawing.Point(116, 34);
            this.txt_lastUpdateTime_CompBase.Name = "txt_lastUpdateTime_CompBase";
            this.txt_lastUpdateTime_CompBase.Size = new System.Drawing.Size(66, 13);
            this.txt_lastUpdateTime_CompBase.TabIndex = 3;
            this.txt_lastUpdateTime_CompBase.Text = "Last update:";
            // 
            // FRM_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(400, 523);
            this.Controls.Add(this.txt_lastUpdateTime_CompBase);
            this.Controls.Add(this.btn_update_BaseComp);
            this.Controls.Add(this.panel_win_btns_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FRM_Settings";
            this.panel_win_btns_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.minimize_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_win_btns_main;
        private System.Windows.Forms.PictureBox minimize_btn;
        private System.Windows.Forms.PictureBox close_btn;
        private System.Windows.Forms.Button btn_update_BaseComp;
        private System.Windows.Forms.Label txt_lastUpdateTime_CompBase;
    }
}