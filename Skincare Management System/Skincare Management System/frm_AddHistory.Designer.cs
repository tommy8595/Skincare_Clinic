namespace Skincare_Management_System
{
    partial class frm_AddHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AddHistory));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Setting = new System.Windows.Forms.Button();
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.btn_Medicine = new System.Windows.Forms.Button();
            this.btn_Patient = new System.Windows.Forms.Button();
            this.pic_Home = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_id_patient = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_name_addhistory = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rt_history_addhistory = new System.Windows.Forms.RichTextBox();
            this.txt_location_addhistory = new System.Windows.Forms.TextBox();
            this.rt_se_addhistory = new System.Windows.Forms.RichTextBox();
            this.rt_investigation_addhistory = new System.Windows.Forms.RichTextBox();
            this.rt_diagnosis_addhistory = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_back_addhistory = new System.Windows.Forms.Button();
            this.btn_save_addhistory = new System.Windows.Forms.Button();
            this.cbo_level = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(168)))), ((int)(((byte)(253)))));
            this.panel1.Controls.Add(this.btn_Setting);
            this.panel1.Controls.Add(this.btn_LogOut);
            this.panel1.Controls.Add(this.btn_Medicine);
            this.panel1.Controls.Add(this.btn_Patient);
            this.panel1.Controls.Add(this.pic_Home);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 821);
            this.panel1.TabIndex = 1;
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
            this.btn_Setting.Location = new System.Drawing.Point(90, 655);
            this.btn_Setting.Name = "btn_Setting";
            this.btn_Setting.Size = new System.Drawing.Size(137, 45);
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
            this.btn_LogOut.Location = new System.Drawing.Point(90, 753);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(137, 45);
            this.btn_LogOut.TabIndex = 13;
            this.btn_LogOut.Text = "Log Out";
            this.btn_LogOut.UseVisualStyleBackColor = true;
            this.btn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click);
            // 
            // btn_Medicine
            // 
            this.btn_Medicine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(168)))), ((int)(((byte)(253)))));
            this.btn_Medicine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Medicine.BackgroundImage")));
            this.btn_Medicine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Medicine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Medicine.FlatAppearance.BorderSize = 0;
            this.btn_Medicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Medicine.Location = new System.Drawing.Point(19, 420);
            this.btn_Medicine.Name = "btn_Medicine";
            this.btn_Medicine.Size = new System.Drawing.Size(284, 92);
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
            this.btn_Patient.Location = new System.Drawing.Point(19, 279);
            this.btn_Patient.Name = "btn_Patient";
            this.btn_Patient.Size = new System.Drawing.Size(284, 92);
            this.btn_Patient.TabIndex = 2;
            this.btn_Patient.UseVisualStyleBackColor = false;
            this.btn_Patient.Click += new System.EventHandler(this.btn_Patient_Click);
            // 
            // pic_Home
            // 
            this.pic_Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_Home.Image = ((System.Drawing.Image)(resources.GetObject("pic_Home.Image")));
            this.pic_Home.Location = new System.Drawing.Point(2, 7);
            this.pic_Home.Name = "pic_Home";
            this.pic_Home.Size = new System.Drawing.Size(323, 75);
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
            this.label1.Location = new System.Drawing.Point(382, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "History";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(659, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID";
            // 
            // txt_id_patient
            // 
            this.txt_id_patient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_id_patient.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_patient.Location = new System.Drawing.Point(716, 26);
            this.txt_id_patient.Name = "txt_id_patient";
            this.txt_id_patient.Size = new System.Drawing.Size(92, 36);
            this.txt_id_patient.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(853, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 29);
            this.label4.TabIndex = 12;
            this.label4.Text = "Name";
            // 
            // txt_name_addhistory
            // 
            this.txt_name_addhistory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_name_addhistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name_addhistory.Location = new System.Drawing.Point(957, 26);
            this.txt_name_addhistory.Name = "txt_name_addhistory";
            this.txt_name_addhistory.Size = new System.Drawing.Size(525, 36);
            this.txt_name_addhistory.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(389, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1093, 2);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(383, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 29);
            this.label3.TabIndex = 27;
            this.label3.Text = "History";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(383, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 29);
            this.label5.TabIndex = 29;
            this.label5.Text = "Skin Examination";
            // 
            // rt_history_addhistory
            // 
            this.rt_history_addhistory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rt_history_addhistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rt_history_addhistory.Location = new System.Drawing.Point(665, 136);
            this.rt_history_addhistory.Name = "rt_history_addhistory";
            this.rt_history_addhistory.Size = new System.Drawing.Size(817, 111);
            this.rt_history_addhistory.TabIndex = 3;
            this.rt_history_addhistory.Text = "";
            // 
            // txt_location_addhistory
            // 
            this.txt_location_addhistory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_location_addhistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_location_addhistory.Location = new System.Drawing.Point(665, 410);
            this.txt_location_addhistory.Name = "txt_location_addhistory";
            this.txt_location_addhistory.Size = new System.Drawing.Size(817, 36);
            this.txt_location_addhistory.TabIndex = 5;
            // 
            // rt_se_addhistory
            // 
            this.rt_se_addhistory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rt_se_addhistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rt_se_addhistory.Location = new System.Drawing.Point(665, 273);
            this.rt_se_addhistory.Name = "rt_se_addhistory";
            this.rt_se_addhistory.Size = new System.Drawing.Size(817, 111);
            this.rt_se_addhistory.TabIndex = 4;
            this.rt_se_addhistory.Text = "";
            // 
            // rt_investigation_addhistory
            // 
            this.rt_investigation_addhistory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rt_investigation_addhistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rt_investigation_addhistory.Location = new System.Drawing.Point(665, 474);
            this.rt_investigation_addhistory.Name = "rt_investigation_addhistory";
            this.rt_investigation_addhistory.Size = new System.Drawing.Size(817, 111);
            this.rt_investigation_addhistory.TabIndex = 6;
            this.rt_investigation_addhistory.Text = "";
            // 
            // rt_diagnosis_addhistory
            // 
            this.rt_diagnosis_addhistory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rt_diagnosis_addhistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rt_diagnosis_addhistory.Location = new System.Drawing.Point(665, 611);
            this.rt_diagnosis_addhistory.Name = "rt_diagnosis_addhistory";
            this.rt_diagnosis_addhistory.Size = new System.Drawing.Size(817, 111);
            this.rt_diagnosis_addhistory.TabIndex = 7;
            this.rt_diagnosis_addhistory.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(383, 412);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 29);
            this.label6.TabIndex = 37;
            this.label6.Text = "Location";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(383, 476);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 29);
            this.label7.TabIndex = 38;
            this.label7.Text = "Investigation";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(383, 613);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 29);
            this.label8.TabIndex = 39;
            this.label8.Text = "Diagnosis";
            // 
            // btn_back_addhistory
            // 
            this.btn_back_addhistory.BackColor = System.Drawing.Color.White;
            this.btn_back_addhistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back_addhistory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(168)))), ((int)(((byte)(253)))));
            this.btn_back_addhistory.FlatAppearance.BorderSize = 2;
            this.btn_back_addhistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back_addhistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back_addhistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(168)))), ((int)(((byte)(253)))));
            this.btn_back_addhistory.Location = new System.Drawing.Point(1335, 805);
            this.btn_back_addhistory.Name = "btn_back_addhistory";
            this.btn_back_addhistory.Size = new System.Drawing.Size(137, 45);
            this.btn_back_addhistory.TabIndex = 40;
            this.btn_back_addhistory.Text = "Back";
            this.btn_back_addhistory.UseVisualStyleBackColor = false;
            this.btn_back_addhistory.Click += new System.EventHandler(this.btn_back_addhistory_Click);
            // 
            // btn_save_addhistory
            // 
            this.btn_save_addhistory.BackColor = System.Drawing.Color.White;
            this.btn_save_addhistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save_addhistory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(168)))), ((int)(((byte)(253)))));
            this.btn_save_addhistory.FlatAppearance.BorderSize = 2;
            this.btn_save_addhistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save_addhistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_addhistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(168)))), ((int)(((byte)(253)))));
            this.btn_save_addhistory.Location = new System.Drawing.Point(1151, 805);
            this.btn_save_addhistory.Name = "btn_save_addhistory";
            this.btn_save_addhistory.Size = new System.Drawing.Size(137, 45);
            this.btn_save_addhistory.TabIndex = 8;
            this.btn_save_addhistory.Text = "Save";
            this.btn_save_addhistory.UseVisualStyleBackColor = false;
            this.btn_save_addhistory.Click += new System.EventHandler(this.btn_save_addhistory_Click);
            // 
            // cbo_level
            // 
            this.cbo_level.DropDownHeight = 100;
            this.cbo_level.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_level.FormattingEnabled = true;
            this.cbo_level.IntegralHeight = false;
            this.cbo_level.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbo_level.Location = new System.Drawing.Point(664, 747);
            this.cbo_level.Name = "cbo_level";
            this.cbo_level.Size = new System.Drawing.Size(285, 37);
            this.cbo_level.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(383, 747);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 29);
            this.label9.TabIndex = 60;
            this.label9.Text = "Level";
            // 
            // frm_AddHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1541, 821);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbo_level);
            this.Controls.Add(this.btn_save_addhistory);
            this.Controls.Add(this.btn_back_addhistory);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rt_diagnosis_addhistory);
            this.Controls.Add(this.rt_investigation_addhistory);
            this.Controls.Add(this.rt_se_addhistory);
            this.Controls.Add(this.txt_location_addhistory);
            this.Controls.Add(this.rt_history_addhistory);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_name_addhistory);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_id_patient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_AddHistory";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Skincare - Add History";
            this.Load += new System.EventHandler(this.frm_AddHistory_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Setting;
        private System.Windows.Forms.Button btn_LogOut;
        private System.Windows.Forms.Button btn_Medicine;
        private System.Windows.Forms.Button btn_Patient;
        private System.Windows.Forms.PictureBox pic_Home;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_id_patient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_name_addhistory;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rt_history_addhistory;
        private System.Windows.Forms.TextBox txt_location_addhistory;
        private System.Windows.Forms.RichTextBox rt_se_addhistory;
        private System.Windows.Forms.RichTextBox rt_investigation_addhistory;
        private System.Windows.Forms.RichTextBox rt_diagnosis_addhistory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_back_addhistory;
        private System.Windows.Forms.Button btn_save_addhistory;
        private System.Windows.Forms.ComboBox cbo_level;
        private System.Windows.Forms.Label label9;
    }
}