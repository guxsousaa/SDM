namespace SDM
{
    partial class FRM_Ad
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
            this.btn_new_computer = new System.Windows.Forms.Button();
            this.panel_cotainer_main_ad = new System.Windows.Forms.Panel();
            this.panel_list_container_ad = new System.Windows.Forms.Panel();
            this.list_computer_ad = new System.Windows.Forms.ListView();
            this.panel_top_container_ad = new System.Windows.Forms.Panel();
            this.btn_move_ad = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_search_ad = new System.Windows.Forms.Button();
            this.panel_cotainer_main_ad.SuspendLayout();
            this.panel_list_container_ad.SuspendLayout();
            this.panel_top_container_ad.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_new_computer
            // 
            this.btn_new_computer.FlatAppearance.BorderSize = 0;
            this.btn_new_computer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_new_computer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new_computer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_new_computer.Location = new System.Drawing.Point(12, 12);
            this.btn_new_computer.Name = "btn_new_computer";
            this.btn_new_computer.Size = new System.Drawing.Size(147, 33);
            this.btn_new_computer.TabIndex = 0;
            this.btn_new_computer.Text = "New Computer";
            this.btn_new_computer.UseVisualStyleBackColor = true;
            this.btn_new_computer.Click += new System.EventHandler(this.btn_new_computer_Click);
            // 
            // panel_cotainer_main_ad
            // 
            this.panel_cotainer_main_ad.Controls.Add(this.panel_list_container_ad);
            this.panel_cotainer_main_ad.Controls.Add(this.panel_top_container_ad);
            this.panel_cotainer_main_ad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_cotainer_main_ad.Location = new System.Drawing.Point(0, 0);
            this.panel_cotainer_main_ad.Name = "panel_cotainer_main_ad";
            this.panel_cotainer_main_ad.Size = new System.Drawing.Size(547, 464);
            this.panel_cotainer_main_ad.TabIndex = 1;
            // 
            // panel_list_container_ad
            // 
            this.panel_list_container_ad.Controls.Add(this.list_computer_ad);
            this.panel_list_container_ad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_list_container_ad.Location = new System.Drawing.Point(0, 100);
            this.panel_list_container_ad.Name = "panel_list_container_ad";
            this.panel_list_container_ad.Size = new System.Drawing.Size(547, 364);
            this.panel_list_container_ad.TabIndex = 1;
            // 
            // list_computer_ad
            // 
            this.list_computer_ad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_computer_ad.HideSelection = false;
            this.list_computer_ad.Location = new System.Drawing.Point(0, 0);
            this.list_computer_ad.Name = "list_computer_ad";
            this.list_computer_ad.Size = new System.Drawing.Size(547, 364);
            this.list_computer_ad.TabIndex = 0;
            this.list_computer_ad.UseCompatibleStateImageBehavior = false;
            // 
            // panel_top_container_ad
            // 
            this.panel_top_container_ad.Controls.Add(this.btn_move_ad);
            this.panel_top_container_ad.Controls.Add(this.btn_remove);
            this.panel_top_container_ad.Controls.Add(this.btn_search_ad);
            this.panel_top_container_ad.Controls.Add(this.btn_new_computer);
            this.panel_top_container_ad.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top_container_ad.Location = new System.Drawing.Point(0, 0);
            this.panel_top_container_ad.Name = "panel_top_container_ad";
            this.panel_top_container_ad.Size = new System.Drawing.Size(547, 100);
            this.panel_top_container_ad.TabIndex = 0;
            // 
            // btn_move_ad
            // 
            this.btn_move_ad.FlatAppearance.BorderSize = 0;
            this.btn_move_ad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_move_ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_move_ad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_move_ad.Location = new System.Drawing.Point(408, 51);
            this.btn_move_ad.Name = "btn_move_ad";
            this.btn_move_ad.Size = new System.Drawing.Size(127, 33);
            this.btn_move_ad.TabIndex = 3;
            this.btn_move_ad.Text = "Move";
            this.btn_move_ad.UseVisualStyleBackColor = true;
            // 
            // btn_remove
            // 
            this.btn_remove.FlatAppearance.BorderSize = 0;
            this.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_remove.Location = new System.Drawing.Point(408, 12);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(127, 33);
            this.btn_remove.TabIndex = 2;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = true;
            // 
            // btn_search_ad
            // 
            this.btn_search_ad.FlatAppearance.BorderSize = 0;
            this.btn_search_ad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search_ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search_ad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_search_ad.Location = new System.Drawing.Point(12, 51);
            this.btn_search_ad.Name = "btn_search_ad";
            this.btn_search_ad.Size = new System.Drawing.Size(127, 33);
            this.btn_search_ad.TabIndex = 1;
            this.btn_search_ad.Text = "Search";
            this.btn_search_ad.UseVisualStyleBackColor = true;
            // 
            // FRM_Ad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(547, 464);
            this.Controls.Add(this.panel_cotainer_main_ad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FRM_Ad";
            this.Text = "FRM_Ad";
            this.Load += new System.EventHandler(this.FRM_Ad_Load);
            this.panel_cotainer_main_ad.ResumeLayout(false);
            this.panel_list_container_ad.ResumeLayout(false);
            this.panel_top_container_ad.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_new_computer;
        private System.Windows.Forms.Panel panel_cotainer_main_ad;
        private System.Windows.Forms.Panel panel_list_container_ad;
        private System.Windows.Forms.ListView list_computer_ad;
        private System.Windows.Forms.Panel panel_top_container_ad;
        private System.Windows.Forms.Button btn_search_ad;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_move_ad;
    }
}