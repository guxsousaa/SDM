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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Ad));
            this.btn_new_computer = new System.Windows.Forms.Button();
            this.panel_cotainer_main_ad = new System.Windows.Forms.Panel();
            this.panel_list_container_ad = new System.Windows.Forms.Panel();
            this.panel_question = new System.Windows.Forms.Panel();
            this.txt_question = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.chart_ad_status = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_move_ad = new System.Windows.Forms.Button();
            this.btn_search_ad = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.panel_container_notes = new System.Windows.Forms.Panel();
            this.txt_desc_note = new System.Windows.Forms.Label();
            this.txt_header_notes = new System.Windows.Forms.Label();
            this.panel_container = new System.Windows.Forms.Panel();
            this.panel_container_computers = new System.Windows.Forms.Panel();
            this.txt_details_from_ad = new System.Windows.Forms.Label();
            this.txt_allComputer_ad = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_title_computers = new System.Windows.Forms.Label();
            this.panel_top_container_ad = new System.Windows.Forms.Panel();
            this.txt_active_directory = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_cotainer_main_ad.SuspendLayout();
            this.panel_list_container_ad.SuspendLayout();
            this.panel_question.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_ad_status)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel_container_notes.SuspendLayout();
            this.panel_container.SuspendLayout();
            this.panel_container_computers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_top_container_ad.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_new_computer
            // 
            this.btn_new_computer.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_new_computer.FlatAppearance.BorderSize = 0;
            this.btn_new_computer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_new_computer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new_computer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_new_computer.Location = new System.Drawing.Point(13, 55);
            this.btn_new_computer.Margin = new System.Windows.Forms.Padding(4);
            this.btn_new_computer.Name = "btn_new_computer";
            this.btn_new_computer.Size = new System.Drawing.Size(220, 41);
            this.btn_new_computer.TabIndex = 0;
            this.btn_new_computer.Text = "Novo computador";
            this.btn_new_computer.UseVisualStyleBackColor = true;
            this.btn_new_computer.Click += new System.EventHandler(this.btn_new_computer_Click);
            // 
            // panel_cotainer_main_ad
            // 
            this.panel_cotainer_main_ad.Controls.Add(this.panel_list_container_ad);
            this.panel_cotainer_main_ad.Controls.Add(this.panel_top_container_ad);
            this.panel_cotainer_main_ad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_cotainer_main_ad.Location = new System.Drawing.Point(0, 0);
            this.panel_cotainer_main_ad.Margin = new System.Windows.Forms.Padding(4);
            this.panel_cotainer_main_ad.Name = "panel_cotainer_main_ad";
            this.panel_cotainer_main_ad.Size = new System.Drawing.Size(729, 571);
            this.panel_cotainer_main_ad.TabIndex = 1;
            // 
            // panel_list_container_ad
            // 
            this.panel_list_container_ad.Controls.Add(this.panel_question);
            this.panel_list_container_ad.Controls.Add(this.chart_ad_status);
            this.panel_list_container_ad.Controls.Add(this.panel4);
            this.panel_list_container_ad.Controls.Add(this.panel_container_notes);
            this.panel_list_container_ad.Controls.Add(this.panel_container);
            this.panel_list_container_ad.Controls.Add(this.panel_container_computers);
            this.panel_list_container_ad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_list_container_ad.Location = new System.Drawing.Point(0, 58);
            this.panel_list_container_ad.Margin = new System.Windows.Forms.Padding(4);
            this.panel_list_container_ad.Name = "panel_list_container_ad";
            this.panel_list_container_ad.Size = new System.Drawing.Size(729, 513);
            this.panel_list_container_ad.TabIndex = 1;
            // 
            // panel_question
            // 
            this.panel_question.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(71)))), ((int)(((byte)(93)))));
            this.panel_question.Controls.Add(this.txt_question);
            this.panel_question.Controls.Add(this.button2);
            this.panel_question.Controls.Add(this.button3);
            this.panel_question.Controls.Add(this.button4);
            this.panel_question.Location = new System.Drawing.Point(18, 460);
            this.panel_question.Name = "panel_question";
            this.panel_question.Size = new System.Drawing.Size(697, 41);
            this.panel_question.TabIndex = 5;
            // 
            // txt_question
            // 
            this.txt_question.AutoSize = true;
            this.txt_question.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_question.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_question.Location = new System.Drawing.Point(3, 11);
            this.txt_question.Name = "txt_question";
            this.txt_question.Size = new System.Drawing.Size(563, 20);
            this.txt_question.TabIndex = 5;
            this.txt_question.Text = "Qualquer dúvida sobre o aplicativo, entre em contato com o administrador.";
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button2.Location = new System.Drawing.Point(13, 202);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(196, 41);
            this.button2.TabIndex = 3;
            this.button2.Text = "Move";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button3.Location = new System.Drawing.Point(13, 104);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(196, 41);
            this.button3.TabIndex = 1;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button4.Location = new System.Drawing.Point(13, 153);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(196, 41);
            this.button4.TabIndex = 2;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // chart_ad_status
            // 
            this.chart_ad_status.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart_ad_status.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Name = "Legend1";
            this.chart_ad_status.Legends.Add(legend1);
            this.chart_ad_status.Location = new System.Drawing.Point(271, 184);
            this.chart_ad_status.Name = "chart_ad_status";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart_ad_status.Series.Add(series1);
            this.chart_ad_status.Size = new System.Drawing.Size(444, 257);
            this.chart_ad_status.TabIndex = 3;
            this.chart_ad_status.Text = "chart1";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(71)))), ((int)(((byte)(93)))));
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.btn_new_computer);
            this.panel4.Controls.Add(this.btn_move_ad);
            this.panel4.Controls.Add(this.btn_search_ad);
            this.panel4.Controls.Add(this.btn_remove);
            this.panel4.Location = new System.Drawing.Point(18, 184);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(247, 257);
            this.panel4.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Opções";
            // 
            // btn_move_ad
            // 
            this.btn_move_ad.FlatAppearance.BorderSize = 0;
            this.btn_move_ad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_move_ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_move_ad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_move_ad.Location = new System.Drawing.Point(13, 202);
            this.btn_move_ad.Margin = new System.Windows.Forms.Padding(4);
            this.btn_move_ad.Name = "btn_move_ad";
            this.btn_move_ad.Size = new System.Drawing.Size(220, 41);
            this.btn_move_ad.TabIndex = 3;
            this.btn_move_ad.Text = "Mover";
            this.btn_move_ad.UseVisualStyleBackColor = true;
            this.btn_move_ad.Click += new System.EventHandler(this.btn_move_ad_Click);
            // 
            // btn_search_ad
            // 
            this.btn_search_ad.FlatAppearance.BorderSize = 0;
            this.btn_search_ad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_search_ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search_ad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_search_ad.Location = new System.Drawing.Point(13, 104);
            this.btn_search_ad.Margin = new System.Windows.Forms.Padding(4);
            this.btn_search_ad.Name = "btn_search_ad";
            this.btn_search_ad.Size = new System.Drawing.Size(220, 41);
            this.btn_search_ad.TabIndex = 1;
            this.btn_search_ad.Text = "Procurar";
            this.btn_search_ad.UseVisualStyleBackColor = true;
            this.btn_search_ad.Click += new System.EventHandler(this.btn_search_ad_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.FlatAppearance.BorderSize = 0;
            this.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_remove.Location = new System.Drawing.Point(13, 153);
            this.btn_remove.Margin = new System.Windows.Forms.Padding(4);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(220, 41);
            this.btn_remove.TabIndex = 2;
            this.btn_remove.Text = "Excluir";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // panel_container_notes
            // 
            this.panel_container_notes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(71)))), ((int)(((byte)(93)))));
            this.panel_container_notes.Controls.Add(this.txt_desc_note);
            this.panel_container_notes.Controls.Add(this.txt_header_notes);
            this.panel_container_notes.Location = new System.Drawing.Point(567, 21);
            this.panel_container_notes.Name = "panel_container_notes";
            this.panel_container_notes.Size = new System.Drawing.Size(148, 143);
            this.panel_container_notes.TabIndex = 2;
            // 
            // txt_desc_note
            // 
            this.txt_desc_note.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_desc_note.Location = new System.Drawing.Point(17, 43);
            this.txt_desc_note.Name = "txt_desc_note";
            this.txt_desc_note.Size = new System.Drawing.Size(118, 100);
            this.txt_desc_note.TabIndex = 4;
            this.txt_desc_note.Text = "Esta página pode apresentar instabilidades nos próximos dias.";
            // 
            // txt_header_notes
            // 
            this.txt_header_notes.AutoSize = true;
            this.txt_header_notes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_header_notes.ForeColor = System.Drawing.Color.White;
            this.txt_header_notes.Location = new System.Drawing.Point(15, 16);
            this.txt_header_notes.Name = "txt_header_notes";
            this.txt_header_notes.Size = new System.Drawing.Size(63, 25);
            this.txt_header_notes.TabIndex = 1;
            this.txt_header_notes.Text = "Notas";
            // 
            // panel_container
            // 
            this.panel_container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(71)))), ((int)(((byte)(93)))));
            this.panel_container.Controls.Add(this.label2);
            this.panel_container.Location = new System.Drawing.Point(335, 21);
            this.panel_container.Name = "panel_container";
            this.panel_container.Size = new System.Drawing.Size(211, 143);
            this.panel_container.TabIndex = 1;
            // 
            // panel_container_computers
            // 
            this.panel_container_computers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(71)))), ((int)(((byte)(93)))));
            this.panel_container_computers.Controls.Add(this.txt_details_from_ad);
            this.panel_container_computers.Controls.Add(this.txt_allComputer_ad);
            this.panel_container_computers.Controls.Add(this.pictureBox1);
            this.panel_container_computers.Controls.Add(this.txt_title_computers);
            this.panel_container_computers.Location = new System.Drawing.Point(18, 21);
            this.panel_container_computers.Name = "panel_container_computers";
            this.panel_container_computers.Size = new System.Drawing.Size(297, 143);
            this.panel_container_computers.TabIndex = 0;
            // 
            // txt_details_from_ad
            // 
            this.txt_details_from_ad.AutoSize = true;
            this.txt_details_from_ad.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_details_from_ad.Location = new System.Drawing.Point(17, 104);
            this.txt_details_from_ad.Name = "txt_details_from_ad";
            this.txt_details_from_ad.Size = new System.Drawing.Size(84, 17);
            this.txt_details_from_ad.TabIndex = 2;
            this.txt_details_from_ad.Text = "Detalhes de";
            // 
            // txt_allComputer_ad
            // 
            this.txt_allComputer_ad.AutoSize = true;
            this.txt_allComputer_ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_allComputer_ad.ForeColor = System.Drawing.Color.Aqua;
            this.txt_allComputer_ad.Location = new System.Drawing.Point(13, 43);
            this.txt_allComputer_ad.Name = "txt_allComputer_ad";
            this.txt_allComputer_ad.Size = new System.Drawing.Size(156, 63);
            this.txt_allComputer_ad.TabIndex = 1;
            this.txt_allComputer_ad.Text = "40253";
            this.txt_allComputer_ad.UseCompatibleTextRendering = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(180, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // txt_title_computers
            // 
            this.txt_title_computers.AutoSize = true;
            this.txt_title_computers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_title_computers.ForeColor = System.Drawing.Color.White;
            this.txt_title_computers.Location = new System.Drawing.Point(15, 16);
            this.txt_title_computers.Name = "txt_title_computers";
            this.txt_title_computers.Size = new System.Drawing.Size(141, 25);
            this.txt_title_computers.TabIndex = 0;
            this.txt_title_computers.Text = "Computadores";
            // 
            // panel_top_container_ad
            // 
            this.panel_top_container_ad.Controls.Add(this.txt_active_directory);
            this.panel_top_container_ad.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top_container_ad.Location = new System.Drawing.Point(0, 0);
            this.panel_top_container_ad.Margin = new System.Windows.Forms.Padding(4);
            this.panel_top_container_ad.Name = "panel_top_container_ad";
            this.panel_top_container_ad.Size = new System.Drawing.Size(729, 58);
            this.panel_top_container_ad.TabIndex = 0;
            // 
            // txt_active_directory
            // 
            this.txt_active_directory.AutoSize = true;
            this.txt_active_directory.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_active_directory.ForeColor = System.Drawing.Color.White;
            this.txt_active_directory.Location = new System.Drawing.Point(12, 9);
            this.txt_active_directory.Name = "txt_active_directory";
            this.txt_active_directory.Size = new System.Drawing.Size(213, 32);
            this.txt_active_directory.TabIndex = 4;
            this.txt_active_directory.Text = "Active Directory";
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(16, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 122);
            this.label2.TabIndex = 5;
            this.label2.Text = "O base de dados está sendo atualizado a cada 1 minuto e meio.";
            // 
            // FRM_Ad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(729, 571);
            this.Controls.Add(this.panel_cotainer_main_ad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FRM_Ad";
            this.Text = "FRM_Ad";
            this.Load += new System.EventHandler(this.FRM_Ad_Load);
            this.panel_cotainer_main_ad.ResumeLayout(false);
            this.panel_list_container_ad.ResumeLayout(false);
            this.panel_question.ResumeLayout(false);
            this.panel_question.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_ad_status)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel_container_notes.ResumeLayout(false);
            this.panel_container_notes.PerformLayout();
            this.panel_container.ResumeLayout(false);
            this.panel_container_computers.ResumeLayout(false);
            this.panel_container_computers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_top_container_ad.ResumeLayout(false);
            this.panel_top_container_ad.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_new_computer;
        private System.Windows.Forms.Panel panel_cotainer_main_ad;
        private System.Windows.Forms.Panel panel_list_container_ad;
        private System.Windows.Forms.Panel panel_top_container_ad;
        private System.Windows.Forms.Button btn_search_ad;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_move_ad;
        private System.Windows.Forms.Label txt_active_directory;
        private System.Windows.Forms.Panel panel_container_computers;
        private System.Windows.Forms.Label txt_allComputer_ad;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label txt_details_from_ad;
        private System.Windows.Forms.Label txt_title_computers;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel_container_notes;
        private System.Windows.Forms.Label txt_desc_note;
        private System.Windows.Forms.Label txt_header_notes;
        private System.Windows.Forms.Panel panel_container;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_ad_status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_question;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label txt_question;
        private System.Windows.Forms.Label label2;
    }
}