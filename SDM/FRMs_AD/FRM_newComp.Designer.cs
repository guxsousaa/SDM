
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_newComp));
            this.input_computerName_ad = new System.Windows.Forms.TextBox();
            this.btn_search_Computer = new System.Windows.Forms.Button();
            this.btn_create_Computer = new System.Windows.Forms.Button();
            this.main_panel_container_newComp_ad = new System.Windows.Forms.Panel();
            this.panel_container_ou_btns = new System.Windows.Forms.Panel();
            this.btn_ou_smt_comp = new System.Windows.Forms.Button();
            this.btn_ou_smt_note = new System.Windows.Forms.Button();
            this.btn_ou_mtz_dsk = new System.Windows.Forms.Button();
            this.btn_ou_mtz_note = new System.Windows.Forms.Button();
            this.btn_ou_wsus_win10 = new System.Windows.Forms.Button();
            this.txt_select_one_ou = new System.Windows.Forms.Label();
            this.panel_container_main_funcions = new System.Windows.Forms.Panel();
            this.panel_container_btns_actions = new System.Windows.Forms.Panel();
            this.txt_create_in = new System.Windows.Forms.Label();
            this.txt_comp_desc = new System.Windows.Forms.Label();
            this.header_panel_newComp_ad = new System.Windows.Forms.Panel();
            this.txt_header_create_computer = new System.Windows.Forms.Label();
            this.close_btn_newComp_AD = new System.Windows.Forms.PictureBox();
            this.main_panel_container_newComp_ad.SuspendLayout();
            this.panel_container_ou_btns.SuspendLayout();
            this.panel_container_main_funcions.SuspendLayout();
            this.panel_container_btns_actions.SuspendLayout();
            this.header_panel_newComp_ad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn_newComp_AD)).BeginInit();
            this.SuspendLayout();
            // 
            // input_computerName_ad
            // 
            this.input_computerName_ad.Location = new System.Drawing.Point(3, 3);
            this.input_computerName_ad.MaxLength = 24;
            this.input_computerName_ad.Name = "input_computerName_ad";
            this.input_computerName_ad.Size = new System.Drawing.Size(166, 20);
            this.input_computerName_ad.TabIndex = 0;
            this.input_computerName_ad.TextChanged += new System.EventHandler(this.input_computerName_ad_TextChanged);
            // 
            // btn_search_Computer
            // 
            this.btn_search_Computer.Location = new System.Drawing.Point(3, 3);
            this.btn_search_Computer.Name = "btn_search_Computer";
            this.btn_search_Computer.Size = new System.Drawing.Size(75, 31);
            this.btn_search_Computer.TabIndex = 1;
            this.btn_search_Computer.Text = "Search";
            this.btn_search_Computer.UseVisualStyleBackColor = true;
            this.btn_search_Computer.Click += new System.EventHandler(this.btn_search_Computer_Click);
            // 
            // btn_create_Computer
            // 
            this.btn_create_Computer.Location = new System.Drawing.Point(3, 37);
            this.btn_create_Computer.Name = "btn_create_Computer";
            this.btn_create_Computer.Size = new System.Drawing.Size(75, 31);
            this.btn_create_Computer.TabIndex = 2;
            this.btn_create_Computer.Text = "Create";
            this.btn_create_Computer.UseVisualStyleBackColor = true;
            this.btn_create_Computer.Click += new System.EventHandler(this.btn_create_Computer_Click);
            // 
            // main_panel_container_newComp_ad
            // 
            this.main_panel_container_newComp_ad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.main_panel_container_newComp_ad.Controls.Add(this.panel_container_ou_btns);
            this.main_panel_container_newComp_ad.Controls.Add(this.txt_select_one_ou);
            this.main_panel_container_newComp_ad.Controls.Add(this.panel_container_main_funcions);
            this.main_panel_container_newComp_ad.Controls.Add(this.header_panel_newComp_ad);
            this.main_panel_container_newComp_ad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_panel_container_newComp_ad.Location = new System.Drawing.Point(0, 0);
            this.main_panel_container_newComp_ad.Margin = new System.Windows.Forms.Padding(2);
            this.main_panel_container_newComp_ad.Name = "main_panel_container_newComp_ad";
            this.main_panel_container_newComp_ad.Size = new System.Drawing.Size(347, 200);
            this.main_panel_container_newComp_ad.TabIndex = 3;
            // 
            // panel_container_ou_btns
            // 
            this.panel_container_ou_btns.AutoSize = true;
            this.panel_container_ou_btns.Controls.Add(this.btn_ou_smt_comp);
            this.panel_container_ou_btns.Controls.Add(this.btn_ou_smt_note);
            this.panel_container_ou_btns.Controls.Add(this.btn_ou_mtz_dsk);
            this.panel_container_ou_btns.Controls.Add(this.btn_ou_mtz_note);
            this.panel_container_ou_btns.Controls.Add(this.btn_ou_wsus_win10);
            this.panel_container_ou_btns.Location = new System.Drawing.Point(6, 117);
            this.panel_container_ou_btns.Name = "panel_container_ou_btns";
            this.panel_container_ou_btns.Padding = new System.Windows.Forms.Padding(5);
            this.panel_container_ou_btns.Size = new System.Drawing.Size(329, 66);
            this.panel_container_ou_btns.TabIndex = 8;
            // 
            // btn_ou_smt_comp
            // 
            this.btn_ou_smt_comp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ou_smt_comp.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btn_ou_smt_comp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ou_smt_comp.ForeColor = System.Drawing.Color.White;
            this.btn_ou_smt_comp.Location = new System.Drawing.Point(119, 35);
            this.btn_ou_smt_comp.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ou_smt_comp.Name = "btn_ou_smt_comp";
            this.btn_ou_smt_comp.Size = new System.Drawing.Size(107, 24);
            this.btn_ou_smt_comp.TabIndex = 15;
            this.btn_ou_smt_comp.Text = "SMT - Computers";
            this.btn_ou_smt_comp.UseVisualStyleBackColor = true;
            this.btn_ou_smt_comp.Click += new System.EventHandler(this.btn_ou_smt_comp_Click);
            // 
            // btn_ou_smt_note
            // 
            this.btn_ou_smt_note.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ou_smt_note.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btn_ou_smt_note.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ou_smt_note.ForeColor = System.Drawing.Color.White;
            this.btn_ou_smt_note.Location = new System.Drawing.Point(8, 35);
            this.btn_ou_smt_note.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ou_smt_note.Name = "btn_ou_smt_note";
            this.btn_ou_smt_note.Size = new System.Drawing.Size(107, 24);
            this.btn_ou_smt_note.TabIndex = 14;
            this.btn_ou_smt_note.Text = "SMT - Notebook";
            this.btn_ou_smt_note.UseVisualStyleBackColor = true;
            this.btn_ou_smt_note.Click += new System.EventHandler(this.btn_ou_smt_note_Click);
            // 
            // btn_ou_mtz_dsk
            // 
            this.btn_ou_mtz_dsk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ou_mtz_dsk.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btn_ou_mtz_dsk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ou_mtz_dsk.ForeColor = System.Drawing.Color.White;
            this.btn_ou_mtz_dsk.Location = new System.Drawing.Point(215, 7);
            this.btn_ou_mtz_dsk.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ou_mtz_dsk.Name = "btn_ou_mtz_dsk";
            this.btn_ou_mtz_dsk.Size = new System.Drawing.Size(107, 24);
            this.btn_ou_mtz_dsk.TabIndex = 13;
            this.btn_ou_mtz_dsk.Text = "Matriz - Computers";
            this.btn_ou_mtz_dsk.UseVisualStyleBackColor = true;
            this.btn_ou_mtz_dsk.Click += new System.EventHandler(this.btn_ou_mtz_dsk_Click);
            // 
            // btn_ou_mtz_note
            // 
            this.btn_ou_mtz_note.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ou_mtz_note.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btn_ou_mtz_note.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ou_mtz_note.ForeColor = System.Drawing.Color.White;
            this.btn_ou_mtz_note.Location = new System.Drawing.Point(104, 7);
            this.btn_ou_mtz_note.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ou_mtz_note.Name = "btn_ou_mtz_note";
            this.btn_ou_mtz_note.Size = new System.Drawing.Size(107, 24);
            this.btn_ou_mtz_note.TabIndex = 12;
            this.btn_ou_mtz_note.Text = "Matriz - Notebook";
            this.btn_ou_mtz_note.UseVisualStyleBackColor = true;
            this.btn_ou_mtz_note.Click += new System.EventHandler(this.btn_ou_mtz_note_Click);
            // 
            // btn_ou_wsus_win10
            // 
            this.btn_ou_wsus_win10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ou_wsus_win10.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btn_ou_wsus_win10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ou_wsus_win10.ForeColor = System.Drawing.Color.White;
            this.btn_ou_wsus_win10.Location = new System.Drawing.Point(8, 7);
            this.btn_ou_wsus_win10.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ou_wsus_win10.Name = "btn_ou_wsus_win10";
            this.btn_ou_wsus_win10.Size = new System.Drawing.Size(92, 24);
            this.btn_ou_wsus_win10.TabIndex = 11;
            this.btn_ou_wsus_win10.Text = "Wsus - Win10";
            this.btn_ou_wsus_win10.UseVisualStyleBackColor = true;
            this.btn_ou_wsus_win10.Click += new System.EventHandler(this.btn_ou_wsus_win10_Click);
            // 
            // txt_select_one_ou
            // 
            this.txt_select_one_ou.AutoSize = true;
            this.txt_select_one_ou.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_select_one_ou.ForeColor = System.Drawing.Color.White;
            this.txt_select_one_ou.Location = new System.Drawing.Point(3, 99);
            this.txt_select_one_ou.Name = "txt_select_one_ou";
            this.txt_select_one_ou.Size = new System.Drawing.Size(89, 15);
            this.txt_select_one_ou.TabIndex = 7;
            this.txt_select_one_ou.Text = "Select one OU:";
            // 
            // panel_container_main_funcions
            // 
            this.panel_container_main_funcions.Controls.Add(this.panel_container_btns_actions);
            this.panel_container_main_funcions.Controls.Add(this.input_computerName_ad);
            this.panel_container_main_funcions.Controls.Add(this.txt_create_in);
            this.panel_container_main_funcions.Controls.Add(this.txt_comp_desc);
            this.panel_container_main_funcions.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_container_main_funcions.Location = new System.Drawing.Point(0, 24);
            this.panel_container_main_funcions.Name = "panel_container_main_funcions";
            this.panel_container_main_funcions.Size = new System.Drawing.Size(347, 72);
            this.panel_container_main_funcions.TabIndex = 6;
            // 
            // panel_container_btns_actions
            // 
            this.panel_container_btns_actions.Controls.Add(this.btn_search_Computer);
            this.panel_container_btns_actions.Controls.Add(this.btn_create_Computer);
            this.panel_container_btns_actions.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_container_btns_actions.Location = new System.Drawing.Point(260, 0);
            this.panel_container_btns_actions.Name = "panel_container_btns_actions";
            this.panel_container_btns_actions.Size = new System.Drawing.Size(87, 72);
            this.panel_container_btns_actions.TabIndex = 7;
            // 
            // txt_create_in
            // 
            this.txt_create_in.AutoSize = true;
            this.txt_create_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_create_in.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_create_in.Location = new System.Drawing.Point(3, 44);
            this.txt_create_in.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_create_in.Name = "txt_create_in";
            this.txt_create_in.Size = new System.Drawing.Size(69, 15);
            this.txt_create_in.TabIndex = 5;
            this.txt_create_in.Text = "Create in:";
            // 
            // txt_comp_desc
            // 
            this.txt_comp_desc.AutoSize = true;
            this.txt_comp_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_comp_desc.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_comp_desc.Location = new System.Drawing.Point(2, 26);
            this.txt_comp_desc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_comp_desc.Name = "txt_comp_desc";
            this.txt_comp_desc.Size = new System.Drawing.Size(67, 15);
            this.txt_comp_desc.TabIndex = 3;
            this.txt_comp_desc.Text = "Waiting...";
            // 
            // header_panel_newComp_ad
            // 
            this.header_panel_newComp_ad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.header_panel_newComp_ad.Controls.Add(this.txt_header_create_computer);
            this.header_panel_newComp_ad.Controls.Add(this.close_btn_newComp_AD);
            this.header_panel_newComp_ad.Dock = System.Windows.Forms.DockStyle.Top;
            this.header_panel_newComp_ad.Location = new System.Drawing.Point(0, 0);
            this.header_panel_newComp_ad.Margin = new System.Windows.Forms.Padding(2);
            this.header_panel_newComp_ad.Name = "header_panel_newComp_ad";
            this.header_panel_newComp_ad.Size = new System.Drawing.Size(347, 24);
            this.header_panel_newComp_ad.TabIndex = 0;
            this.header_panel_newComp_ad.MouseDown += new System.Windows.Forms.MouseEventHandler(this.header_panel_newComp_ad_MouseDown);
            // 
            // txt_header_create_computer
            // 
            this.txt_header_create_computer.Dock = System.Windows.Forms.DockStyle.Left;
            this.txt_header_create_computer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_header_create_computer.ForeColor = System.Drawing.Color.White;
            this.txt_header_create_computer.Location = new System.Drawing.Point(0, 0);
            this.txt_header_create_computer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_header_create_computer.Name = "txt_header_create_computer";
            this.txt_header_create_computer.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.txt_header_create_computer.Size = new System.Drawing.Size(237, 24);
            this.txt_header_create_computer.TabIndex = 3;
            this.txt_header_create_computer.Text = "AD - Create Computer";
            this.txt_header_create_computer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_header_create_computer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txt_header_create_computer_MouseDown);
            // 
            // close_btn_newComp_AD
            // 
            this.close_btn_newComp_AD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_btn_newComp_AD.Image = ((System.Drawing.Image)(resources.GetObject("close_btn_newComp_AD.Image")));
            this.close_btn_newComp_AD.Location = new System.Drawing.Point(323, 2);
            this.close_btn_newComp_AD.Margin = new System.Windows.Forms.Padding(2);
            this.close_btn_newComp_AD.Name = "close_btn_newComp_AD";
            this.close_btn_newComp_AD.Size = new System.Drawing.Size(15, 16);
            this.close_btn_newComp_AD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close_btn_newComp_AD.TabIndex = 1;
            this.close_btn_newComp_AD.TabStop = false;
            this.close_btn_newComp_AD.Click += new System.EventHandler(this.close_btn_newComp_AD_Click);
            // 
            // FRM_newComp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(347, 200);
            this.Controls.Add(this.main_panel_container_newComp_ad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRM_newComp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create new computer";
            this.main_panel_container_newComp_ad.ResumeLayout(false);
            this.main_panel_container_newComp_ad.PerformLayout();
            this.panel_container_ou_btns.ResumeLayout(false);
            this.panel_container_main_funcions.ResumeLayout(false);
            this.panel_container_main_funcions.PerformLayout();
            this.panel_container_btns_actions.ResumeLayout(false);
            this.header_panel_newComp_ad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.close_btn_newComp_AD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox input_computerName_ad;
        private System.Windows.Forms.Button btn_search_Computer;
        private System.Windows.Forms.Button btn_create_Computer;
        private System.Windows.Forms.Panel main_panel_container_newComp_ad;
        private System.Windows.Forms.Panel header_panel_newComp_ad;
        private System.Windows.Forms.PictureBox close_btn_newComp_AD;
        private System.Windows.Forms.Label txt_comp_desc;
        private System.Windows.Forms.Label txt_header_create_computer;
        private System.Windows.Forms.Panel panel_container_main_funcions;
        private System.Windows.Forms.Panel panel_container_btns_actions;
        private System.Windows.Forms.Label txt_create_in;
        private System.Windows.Forms.Label txt_select_one_ou;
        private System.Windows.Forms.Panel panel_container_ou_btns;
        private System.Windows.Forms.Button btn_ou_smt_comp;
        private System.Windows.Forms.Button btn_ou_smt_note;
        private System.Windows.Forms.Button btn_ou_mtz_dsk;
        private System.Windows.Forms.Button btn_ou_mtz_note;
        private System.Windows.Forms.Button btn_ou_wsus_win10;
    }
}