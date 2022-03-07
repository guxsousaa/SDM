namespace SDM.FRMs_AD
{
    partial class FRM_AD_Move
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_AD_Move));
            this.header_panel_newComp_ad = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.close_btn_MoveAd_AD = new System.Windows.Forms.PictureBox();
            this.panel_container_search = new System.Windows.Forms.Panel();
            this.txt_response_status = new System.Windows.Forms.Label();
            this.input_computerName_ad = new System.Windows.Forms.TextBox();
            this.btn_search_Computer = new System.Windows.Forms.Button();
            this.panel_options = new System.Windows.Forms.Panel();
            this.btn_move_smt_comp = new System.Windows.Forms.Button();
            this.btn_move_smt_note = new System.Windows.Forms.Button();
            this.btn_move_realocation = new System.Windows.Forms.Button();
            this.btn_move_block = new System.Windows.Forms.Button();
            this.btn_move_mtz_dsk = new System.Windows.Forms.Button();
            this.btn_move_mtz_note = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_move_wsus_win10 = new System.Windows.Forms.Button();
            this.header_panel_newComp_ad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn_MoveAd_AD)).BeginInit();
            this.panel_container_search.SuspendLayout();
            this.panel_options.SuspendLayout();
            this.SuspendLayout();
            // 
            // header_panel_newComp_ad
            // 
            this.header_panel_newComp_ad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.header_panel_newComp_ad.Controls.Add(this.label1);
            this.header_panel_newComp_ad.Controls.Add(this.close_btn_MoveAd_AD);
            this.header_panel_newComp_ad.Dock = System.Windows.Forms.DockStyle.Top;
            this.header_panel_newComp_ad.Location = new System.Drawing.Point(0, 0);
            this.header_panel_newComp_ad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.header_panel_newComp_ad.Name = "header_panel_newComp_ad";
            this.header_panel_newComp_ad.Size = new System.Drawing.Size(358, 24);
            this.header_panel_newComp_ad.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(237, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "AD - Move Computer";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // close_btn_MoveAd_AD
            // 
            this.close_btn_MoveAd_AD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_btn_MoveAd_AD.Image = ((System.Drawing.Image)(resources.GetObject("close_btn_MoveAd_AD.Image")));
            this.close_btn_MoveAd_AD.Location = new System.Drawing.Point(333, 2);
            this.close_btn_MoveAd_AD.Margin = new System.Windows.Forms.Padding(2, 2, 8, 2);
            this.close_btn_MoveAd_AD.Name = "close_btn_MoveAd_AD";
            this.close_btn_MoveAd_AD.Size = new System.Drawing.Size(15, 24);
            this.close_btn_MoveAd_AD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close_btn_MoveAd_AD.TabIndex = 1;
            this.close_btn_MoveAd_AD.TabStop = false;
            this.close_btn_MoveAd_AD.Click += new System.EventHandler(this.close_btn_MoveAd_AD_Click);
            // 
            // panel_container_search
            // 
            this.panel_container_search.Controls.Add(this.txt_response_status);
            this.panel_container_search.Controls.Add(this.input_computerName_ad);
            this.panel_container_search.Controls.Add(this.btn_search_Computer);
            this.panel_container_search.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_container_search.Location = new System.Drawing.Point(0, 24);
            this.panel_container_search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_container_search.Name = "panel_container_search";
            this.panel_container_search.Size = new System.Drawing.Size(358, 60);
            this.panel_container_search.TabIndex = 7;
            // 
            // txt_response_status
            // 
            this.txt_response_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_response_status.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_response_status.Location = new System.Drawing.Point(9, 26);
            this.txt_response_status.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_response_status.Name = "txt_response_status";
            this.txt_response_status.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.txt_response_status.Size = new System.Drawing.Size(223, 28);
            this.txt_response_status.TabIndex = 12;
            this.txt_response_status.Text = "Wating...";
            // 
            // input_computerName_ad
            // 
            this.input_computerName_ad.Location = new System.Drawing.Point(10, 5);
            this.input_computerName_ad.MaxLength = 24;
            this.input_computerName_ad.Name = "input_computerName_ad";
            this.input_computerName_ad.Size = new System.Drawing.Size(166, 20);
            this.input_computerName_ad.TabIndex = 2;
            this.input_computerName_ad.TextChanged += new System.EventHandler(this.input_computerName_ad_TextChanged);
            // 
            // btn_search_Computer
            // 
            this.btn_search_Computer.AutoSize = true;
            this.btn_search_Computer.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btn_search_Computer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search_Computer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search_Computer.ForeColor = System.Drawing.Color.White;
            this.btn_search_Computer.Location = new System.Drawing.Point(273, 5);
            this.btn_search_Computer.Name = "btn_search_Computer";
            this.btn_search_Computer.Size = new System.Drawing.Size(75, 50);
            this.btn_search_Computer.TabIndex = 3;
            this.btn_search_Computer.Text = "Search";
            this.btn_search_Computer.UseVisualStyleBackColor = true;
            this.btn_search_Computer.Click += new System.EventHandler(this.btn_search_Computer_Click);
            // 
            // panel_options
            // 
            this.panel_options.Controls.Add(this.btn_move_smt_comp);
            this.panel_options.Controls.Add(this.btn_move_smt_note);
            this.panel_options.Controls.Add(this.btn_move_realocation);
            this.panel_options.Controls.Add(this.btn_move_block);
            this.panel_options.Controls.Add(this.btn_move_mtz_dsk);
            this.panel_options.Controls.Add(this.btn_move_mtz_note);
            this.panel_options.Controls.Add(this.label2);
            this.panel_options.Controls.Add(this.btn_move_wsus_win10);
            this.panel_options.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_options.Location = new System.Drawing.Point(0, 84);
            this.panel_options.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_options.Name = "panel_options";
            this.panel_options.Size = new System.Drawing.Size(358, 317);
            this.panel_options.TabIndex = 8;
            // 
            // btn_move_smt_comp
            // 
            this.btn_move_smt_comp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_move_smt_comp.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btn_move_smt_comp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_move_smt_comp.ForeColor = System.Drawing.Color.White;
            this.btn_move_smt_comp.Location = new System.Drawing.Point(179, 93);
            this.btn_move_smt_comp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_move_smt_comp.Name = "btn_move_smt_comp";
            this.btn_move_smt_comp.Size = new System.Drawing.Size(107, 24);
            this.btn_move_smt_comp.TabIndex = 10;
            this.btn_move_smt_comp.Text = "SMT - Computers";
            this.btn_move_smt_comp.UseVisualStyleBackColor = true;
            this.btn_move_smt_comp.Click += new System.EventHandler(this.btn_move_smt_comp_Click);
            // 
            // btn_move_smt_note
            // 
            this.btn_move_smt_note.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_move_smt_note.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btn_move_smt_note.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_move_smt_note.ForeColor = System.Drawing.Color.White;
            this.btn_move_smt_note.Location = new System.Drawing.Point(179, 63);
            this.btn_move_smt_note.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_move_smt_note.Name = "btn_move_smt_note";
            this.btn_move_smt_note.Size = new System.Drawing.Size(107, 24);
            this.btn_move_smt_note.TabIndex = 9;
            this.btn_move_smt_note.Text = "SMT - Notebook";
            this.btn_move_smt_note.UseVisualStyleBackColor = true;
            this.btn_move_smt_note.Click += new System.EventHandler(this.btn_move_smt_note_Click);
            // 
            // btn_move_realocation
            // 
            this.btn_move_realocation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_move_realocation.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btn_move_realocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_move_realocation.ForeColor = System.Drawing.Color.White;
            this.btn_move_realocation.Location = new System.Drawing.Point(291, 35);
            this.btn_move_realocation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_move_realocation.Name = "btn_move_realocation";
            this.btn_move_realocation.Size = new System.Drawing.Size(57, 24);
            this.btn_move_realocation.TabIndex = 8;
            this.btn_move_realocation.Text = "Relocation";
            this.btn_move_realocation.UseVisualStyleBackColor = true;
            // 
            // btn_move_block
            // 
            this.btn_move_block.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_move_block.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_move_block.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_move_block.ForeColor = System.Drawing.Color.White;
            this.btn_move_block.Location = new System.Drawing.Point(291, 6);
            this.btn_move_block.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_move_block.Name = "btn_move_block";
            this.btn_move_block.Size = new System.Drawing.Size(57, 24);
            this.btn_move_block.TabIndex = 7;
            this.btn_move_block.Text = "Block";
            this.btn_move_block.UseVisualStyleBackColor = true;
            this.btn_move_block.Click += new System.EventHandler(this.btn_move_block_Click);
            // 
            // btn_move_mtz_dsk
            // 
            this.btn_move_mtz_dsk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_move_mtz_dsk.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btn_move_mtz_dsk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_move_mtz_dsk.ForeColor = System.Drawing.Color.White;
            this.btn_move_mtz_dsk.Location = new System.Drawing.Point(179, 34);
            this.btn_move_mtz_dsk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_move_mtz_dsk.Name = "btn_move_mtz_dsk";
            this.btn_move_mtz_dsk.Size = new System.Drawing.Size(107, 24);
            this.btn_move_mtz_dsk.TabIndex = 6;
            this.btn_move_mtz_dsk.Text = "Matriz - Computers";
            this.btn_move_mtz_dsk.UseVisualStyleBackColor = true;
            this.btn_move_mtz_dsk.Click += new System.EventHandler(this.btn_move_mtz_dsk_Click);
            // 
            // btn_move_mtz_note
            // 
            this.btn_move_mtz_note.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_move_mtz_note.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btn_move_mtz_note.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_move_mtz_note.ForeColor = System.Drawing.Color.White;
            this.btn_move_mtz_note.Location = new System.Drawing.Point(179, 6);
            this.btn_move_mtz_note.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_move_mtz_note.Name = "btn_move_mtz_note";
            this.btn_move_mtz_note.Size = new System.Drawing.Size(107, 24);
            this.btn_move_mtz_note.TabIndex = 5;
            this.btn_move_mtz_note.Text = "Matriz - Notebook";
            this.btn_move_mtz_note.UseVisualStyleBackColor = true;
            this.btn_move_mtz_note.Click += new System.EventHandler(this.btn_move_mtz_note_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(2, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(76, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Move to:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_move_wsus_win10
            // 
            this.btn_move_wsus_win10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_move_wsus_win10.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btn_move_wsus_win10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_move_wsus_win10.ForeColor = System.Drawing.Color.White;
            this.btn_move_wsus_win10.Location = new System.Drawing.Point(83, 6);
            this.btn_move_wsus_win10.Margin = new System.Windows.Forms.Padding(2);
            this.btn_move_wsus_win10.Name = "btn_move_wsus_win10";
            this.btn_move_wsus_win10.Size = new System.Drawing.Size(92, 24);
            this.btn_move_wsus_win10.TabIndex = 0;
            this.btn_move_wsus_win10.Text = "Wsus - Win10";
            this.btn_move_wsus_win10.UseVisualStyleBackColor = true;
            this.btn_move_wsus_win10.Click += new System.EventHandler(this.btn_move_wsus_win10_Click);
            // 
            // FRM_AD_Move
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(358, 401);
            this.Controls.Add(this.panel_options);
            this.Controls.Add(this.panel_container_search);
            this.Controls.Add(this.header_panel_newComp_ad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FRM_AD_Move";
            this.Text = "FRM_AD_Move";
            this.header_panel_newComp_ad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.close_btn_MoveAd_AD)).EndInit();
            this.panel_container_search.ResumeLayout(false);
            this.panel_container_search.PerformLayout();
            this.panel_options.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header_panel_newComp_ad;
        private System.Windows.Forms.PictureBox close_btn_MoveAd_AD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_container_search;
        private System.Windows.Forms.TextBox input_computerName_ad;
        private System.Windows.Forms.Button btn_search_Computer;
        private System.Windows.Forms.Label txt_response_status;
        private System.Windows.Forms.Panel panel_options;
        private System.Windows.Forms.Button btn_move_realocation;
        private System.Windows.Forms.Button btn_move_block;
        private System.Windows.Forms.Button btn_move_mtz_dsk;
        private System.Windows.Forms.Button btn_move_mtz_note;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_move_smt_note;
        private System.Windows.Forms.Button btn_move_smt_comp;
        private System.Windows.Forms.Button btn_move_wsus_win10;
    }
}