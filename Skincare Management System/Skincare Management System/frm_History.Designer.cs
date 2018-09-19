namespace Skincare_Management_System
{
    partial class frm_History
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_History));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Setting = new System.Windows.Forms.Button();
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.btn_Report = new System.Windows.Forms.Button();
            this.btn_Medicine = new System.Windows.Forms.Button();
            this.btn_Patient = new System.Windows.Forms.Button();
            this.pic_Home = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_id_history = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_name_history = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_history = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.History = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SkinExamination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Investigation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diagnostic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.history_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_back_history = new System.Windows.Forms.Button();
            this.btn_print_history = new System.Windows.Forms.Button();
            this.btn_add_history = new System.Windows.Forms.Button();
            this.btn_Prescription = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_history)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(168)))), ((int)(((byte)(253)))));
            this.panel1.Controls.Add(this.btn_Setting);
            this.panel1.Controls.Add(this.btn_LogOut);
            this.panel1.Controls.Add(this.btn_Report);
            this.panel1.Controls.Add(this.btn_Medicine);
            this.panel1.Controls.Add(this.btn_Patient);
            this.panel1.Controls.Add(this.pic_Home);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 1560);
            this.panel1.TabIndex = 2;
            // 
            // btn_Setting
            // 
            this.btn_Setting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(168)))), ((int)(((byte)(253)))));
            this.btn_Setting.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Setting.BackgroundImage")));
            this.btn_Setting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Setting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Setting.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(168)))), ((int)(((byte)(253)))));
            this.btn_Setting.FlatAppearance.BorderSize = 2;
            this.btn_Setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Setting.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Setting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(168)))), ((int)(((byte)(253)))));
            this.btn_Setting.Location = new System.Drawing.Point(135, 1023);
            this.btn_Setting.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Setting.Name = "btn_Setting";
            this.btn_Setting.Size = new System.Drawing.Size(206, 70);
            this.btn_Setting.TabIndex = 69;
            this.btn_Setting.UseVisualStyleBackColor = false;
            this.btn_Setting.Click += new System.EventHandler(this.btn_Setting_Click);
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_LogOut.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_LogOut.FlatAppearance.BorderSize = 2;
            this.btn_LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LogOut.ForeColor = System.Drawing.Color.White;
            this.btn_LogOut.Location = new System.Drawing.Point(135, 1177);
            this.btn_LogOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(206, 70);
            this.btn_LogOut.TabIndex = 13;
            this.btn_LogOut.Text = "Log Out";
            this.btn_LogOut.UseVisualStyleBackColor = true;
            this.btn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click);
            // 
            // btn_Report
            // 
            this.btn_Report.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(168)))), ((int)(((byte)(253)))));
            this.btn_Report.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Report.BackgroundImage")));
            this.btn_Report.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Report.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Report.FlatAppearance.BorderSize = 0;
            this.btn_Report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Report.Location = new System.Drawing.Point(32, 720);
            this.btn_Report.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Report.Name = "btn_Report";
            this.btn_Report.Size = new System.Drawing.Size(426, 144);
            this.btn_Report.TabIndex = 3;
            this.btn_Report.UseVisualStyleBackColor = false;
            this.btn_Report.Click += new System.EventHandler(this.btn_Report_Click);
            // 
            // btn_Medicine
            // 
            this.btn_Medicine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(168)))), ((int)(((byte)(253)))));
            this.btn_Medicine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Medicine.BackgroundImage")));
            this.btn_Medicine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Medicine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Medicine.FlatAppearance.BorderSize = 0;
            this.btn_Medicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Medicine.Location = new System.Drawing.Point(32, 498);
            this.btn_Medicine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Medicine.Name = "btn_Medicine";
            this.btn_Medicine.Size = new System.Drawing.Size(426, 144);
            this.btn_Medicine.TabIndex = 3;
            this.btn_Medicine.UseVisualStyleBackColor = false;
            this.btn_Medicine.Click += new System.EventHandler(this.btn_Medicine_Click);
            // 
            // btn_Patient
            // 
            this.btn_Patient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(168)))), ((int)(((byte)(253)))));
            this.btn_Patient.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Patient.BackgroundImage")));
            this.btn_Patient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Patient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Patient.FlatAppearance.BorderSize = 0;
            this.btn_Patient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Patient.Location = new System.Drawing.Point(32, 277);
            this.btn_Patient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Patient.Name = "btn_Patient";
            this.btn_Patient.Size = new System.Drawing.Size(426, 144);
            this.btn_Patient.TabIndex = 2;
            this.btn_Patient.UseVisualStyleBackColor = false;
            this.btn_Patient.Click += new System.EventHandler(this.btn_Patient_Click);
            // 
            // pic_Home
            // 
            this.pic_Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_Home.Image = ((System.Drawing.Image)(resources.GetObject("pic_Home.Image")));
            this.pic_Home.Location = new System.Drawing.Point(3, 11);
            this.pic_Home.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pic_Home.Name = "pic_Home";
            this.pic_Home.Size = new System.Drawing.Size(484, 117);
            this.pic_Home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Home.TabIndex = 1;
            this.pic_Home.TabStop = false;
            this.pic_Home.Click += new System.EventHandler(this.pic_Home_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(168)))), ((int)(((byte)(253)))));
            this.label1.Location = new System.Drawing.Point(573, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 61);
            this.label1.TabIndex = 3;
            this.label1.Text = "History";
            // 
            // txt_id_history
            // 
            this.txt_id_history.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_id_history.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_history.Location = new System.Drawing.Point(1074, 41);
            this.txt_id_history.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_id_history.Name = "txt_id_history";
            this.txt_id_history.Size = new System.Drawing.Size(137, 53);
            this.txt_id_history.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(988, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 46);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID";
            // 
            // txt_name_history
            // 
            this.txt_name_history.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_name_history.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name_history.Location = new System.Drawing.Point(1436, 41);
            this.txt_name_history.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_name_history.Name = "txt_name_history";
            this.txt_name_history.Size = new System.Drawing.Size(786, 53);
            this.txt_name_history.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1280, 44);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 46);
            this.label4.TabIndex = 11;
            this.label4.Text = "Name";
            // 
            // dgv_history
            // 
            this.dgv_history.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_history.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_history.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_history.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.History,
            this.SkinExamination,
            this.Investigation,
            this.Location,
            this.Diagnostic,
            this.Level,
            this.history_id});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_history.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_history.Location = new System.Drawing.Point(584, 211);
            this.dgv_history.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_history.Name = "dgv_history";
            this.dgv_history.RowTemplate.Height = 24;
            this.dgv_history.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_history.Size = new System.Drawing.Size(1640, 883);
            this.dgv_history.TabIndex = 13;
            this.dgv_history.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // History
            // 
            this.History.DataPropertyName = "History";
            this.History.HeaderText = "History";
            this.History.Name = "History";
            // 
            // SkinExamination
            // 
            this.SkinExamination.DataPropertyName = "Skin Examination";
            this.SkinExamination.HeaderText = "Skin Examination";
            this.SkinExamination.Name = "SkinExamination";
            // 
            // Investigation
            // 
            this.Investigation.DataPropertyName = "Investigation";
            this.Investigation.HeaderText = "Investigation";
            this.Investigation.Name = "Investigation";
            // 
            // Location
            // 
            this.Location.DataPropertyName = "Location";
            this.Location.HeaderText = "Location";
            this.Location.Name = "Location";
            // 
            // Diagnostic
            // 
            this.Diagnostic.DataPropertyName = "Diagnostics";
            this.Diagnostic.HeaderText = "Diagnostic";
            this.Diagnostic.Name = "Diagnostic";
            // 
            // Level
            // 
            this.Level.DataPropertyName = "Level";
            this.Level.HeaderText = "Level";
            this.Level.Name = "Level";
            // 
            // history_id
            // 
            this.history_id.DataPropertyName = "his_id";
            this.history_id.HeaderText = "history_id";
            this.history_id.Name = "history_id";
            this.history_id.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(584, 153);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1640, 3);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // btn_back_history
            // 
            this.btn_back_history.BackColor = System.Drawing.Color.White;
            this.btn_back_history.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back_history.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(168)))), ((int)(((byte)(253)))));
            this.btn_back_history.FlatAppearance.BorderSize = 2;
            this.btn_back_history.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back_history.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back_history.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(168)))), ((int)(((byte)(253)))));
            this.btn_back_history.Location = new System.Drawing.Point(2018, 1142);
            this.btn_back_history.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_back_history.Name = "btn_back_history";
            this.btn_back_history.Size = new System.Drawing.Size(206, 70);
            this.btn_back_history.TabIndex = 27;
            this.btn_back_history.Text = "Back";
            this.btn_back_history.UseVisualStyleBackColor = false;
            this.btn_back_history.Click += new System.EventHandler(this.btn_back_history_Click);
            // 
            // btn_print_history
            // 
            this.btn_print_history.BackColor = System.Drawing.Color.White;
            this.btn_print_history.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_print_history.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(168)))), ((int)(((byte)(253)))));
            this.btn_print_history.FlatAppearance.BorderSize = 2;
            this.btn_print_history.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_print_history.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print_history.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(168)))), ((int)(((byte)(253)))));
            this.btn_print_history.Location = new System.Drawing.Point(1743, 1142);
            this.btn_print_history.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_print_history.Name = "btn_print_history";
            this.btn_print_history.Size = new System.Drawing.Size(206, 70);
            this.btn_print_history.TabIndex = 28;
            this.btn_print_history.Text = "Print";
            this.btn_print_history.UseVisualStyleBackColor = false;
            this.btn_print_history.Click += new System.EventHandler(this.btn_print_history_Click);
            // 
            // btn_add_history
            // 
            this.btn_add_history.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(168)))), ((int)(((byte)(253)))));
            this.btn_add_history.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_history.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(168)))), ((int)(((byte)(253)))));
            this.btn_add_history.FlatAppearance.BorderSize = 2;
            this.btn_add_history.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_history.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_history.ForeColor = System.Drawing.Color.White;
            this.btn_add_history.Location = new System.Drawing.Point(584, 1147);
            this.btn_add_history.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_add_history.Name = "btn_add_history";
            this.btn_add_history.Size = new System.Drawing.Size(206, 70);
            this.btn_add_history.TabIndex = 26;
            this.btn_add_history.Text = "Add";
            this.btn_add_history.UseVisualStyleBackColor = false;
            this.btn_add_history.Click += new System.EventHandler(this.btn_add_history_Click);
            // 
            // btn_Prescription
            // 
            this.btn_Prescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(168)))), ((int)(((byte)(253)))));
            this.btn_Prescription.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Prescription.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(168)))), ((int)(((byte)(253)))));
            this.btn_Prescription.FlatAppearance.BorderSize = 2;
            this.btn_Prescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Prescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Prescription.ForeColor = System.Drawing.Color.White;
            this.btn_Prescription.Location = new System.Drawing.Point(884, 1147);
            this.btn_Prescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Prescription.Name = "btn_Prescription";
            this.btn_Prescription.Size = new System.Drawing.Size(295, 70);
            this.btn_Prescription.TabIndex = 29;
            this.btn_Prescription.Text = "Prescription";
            this.btn_Prescription.UseVisualStyleBackColor = false;
            this.btn_Prescription.Click += new System.EventHandler(this.btn_Prescription_Click);
            // 
            // frm_History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(2497, 1560);
            this.Controls.Add(this.btn_Prescription);
            this.Controls.Add(this.btn_print_history);
            this.Controls.Add(this.btn_back_history);
            this.Controls.Add(this.btn_add_history);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgv_history);
            this.Controls.Add(this.txt_name_history);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_id_history);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frm_History";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Skincare - Patient History";
            this.Load += new System.EventHandler(this.frm_History_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_history)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Setting;
        private System.Windows.Forms.Button btn_LogOut;
        private System.Windows.Forms.Button btn_Report;
        private System.Windows.Forms.Button btn_Medicine;
        private System.Windows.Forms.Button btn_Patient;
        private System.Windows.Forms.PictureBox pic_Home;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_id_history;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_name_history;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_history;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_back_history;
        private System.Windows.Forms.Button btn_print_history;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn History;
        private System.Windows.Forms.DataGridViewTextBoxColumn SkinExamination;
        private System.Windows.Forms.DataGridViewTextBoxColumn Investigation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diagnostic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Level;
        private System.Windows.Forms.DataGridViewTextBoxColumn history_id;
        private System.Windows.Forms.Button btn_add_history;
        private System.Windows.Forms.Button btn_Prescription;
    }
}