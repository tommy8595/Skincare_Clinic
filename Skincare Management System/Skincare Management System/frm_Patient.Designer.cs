﻿namespace Skincare_Management_System
{
    partial class frm_Patient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Patient));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Setting = new System.Windows.Forms.Button();
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.btn_Medicine = new System.Windows.Forms.Button();
            this.btn_Patient = new System.Windows.Forms.Button();
            this.pic_Home = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_history_patient = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_name_patient = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_occupation_patient = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_phone_patient = new System.Windows.Forms.TextBox();
            this.txt_address_patient = new System.Windows.Forms.TextBox();
            this.dt_dob_patient = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_add_patient = new System.Windows.Forms.Button();
            this.btn_edit_patient = new System.Windows.Forms.Button();
            this.txt_id_patient = new System.Windows.Forms.TextBox();
            this.cbo_gender_patient = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_patientlist = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtage = new System.Windows.Forms.TextBox();
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
            this.panel1.Size = new System.Drawing.Size(328, 1033);
            this.panel1.TabIndex = 0;
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
            this.btn_Medicine.Location = new System.Drawing.Point(21, 445);
            this.btn_Medicine.Name = "btn_Medicine";
            this.btn_Medicine.Size = new System.Drawing.Size(284, 92);
            this.btn_Medicine.TabIndex = 46;
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
            this.btn_Patient.Location = new System.Drawing.Point(21, 222);
            this.btn_Patient.Name = "btn_Patient";
            this.btn_Patient.Size = new System.Drawing.Size(284, 92);
            this.btn_Patient.TabIndex = 67;
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
            this.label1.Size = new System.Drawing.Size(328, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Clinical Observation";
            // 
            // btn_history_patient
            // 
            this.btn_history_patient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(168)))), ((int)(((byte)(253)))));
            this.btn_history_patient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_history_patient.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(168)))), ((int)(((byte)(253)))));
            this.btn_history_patient.FlatAppearance.BorderSize = 2;
            this.btn_history_patient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_history_patient.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_history_patient.ForeColor = System.Drawing.Color.White;
            this.btn_history_patient.Location = new System.Drawing.Point(629, 730);
            this.btn_history_patient.Name = "btn_history_patient";
            this.btn_history_patient.Size = new System.Drawing.Size(137, 45);
            this.btn_history_patient.TabIndex = 14;
            this.btn_history_patient.Text = "History";
            this.btn_history_patient.UseVisualStyleBackColor = false;
            this.btn_history_patient.Click += new System.EventHandler(this.btn_history_patient_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(624, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(389, 198);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1093, 2);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(383, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Name";
            // 
            // txt_name_patient
            // 
            this.txt_name_patient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_name_patient.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name_patient.Location = new System.Drawing.Point(629, 248);
            this.txt_name_patient.Name = "txt_name_patient";
            this.txt_name_patient.Size = new System.Drawing.Size(853, 36);
            this.txt_name_patient.TabIndex = 2;
            this.txt_name_patient.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(383, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "Gender";
            // 
            // txt_occupation_patient
            // 
            this.txt_occupation_patient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_occupation_patient.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_occupation_patient.Location = new System.Drawing.Point(629, 448);
            this.txt_occupation_patient.Name = "txt_occupation_patient";
            this.txt_occupation_patient.Size = new System.Drawing.Size(853, 36);
            this.txt_occupation_patient.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(383, 450);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 29);
            this.label6.TabIndex = 13;
            this.label6.Text = "Occupation";
            // 
            // txt_phone_patient
            // 
            this.txt_phone_patient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_phone_patient.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_phone_patient.Location = new System.Drawing.Point(629, 648);
            this.txt_phone_patient.Name = "txt_phone_patient";
            this.txt_phone_patient.Size = new System.Drawing.Size(853, 36);
            this.txt_phone_patient.TabIndex = 8;
            this.txt_phone_patient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_phone_patient_KeyPress);
            this.txt_phone_patient.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_phone_patient_KeyUp);
            // 
            // txt_address_patient
            // 
            this.txt_address_patient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_address_patient.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_address_patient.Location = new System.Drawing.Point(629, 548);
            this.txt_address_patient.Name = "txt_address_patient";
            this.txt_address_patient.Size = new System.Drawing.Size(853, 36);
            this.txt_address_patient.TabIndex = 7;
            // 
            // dt_dob_patient
            // 
            this.dt_dob_patient.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_dob_patient.Location = new System.Drawing.Point(980, 296);
            this.dt_dob_patient.Name = "dt_dob_patient";
            this.dt_dob_patient.Size = new System.Drawing.Size(485, 36);
            this.dt_dob_patient.TabIndex = 4;
            this.dt_dob_patient.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(794, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 29);
            this.label7.TabIndex = 17;
            this.label7.Text = "Date of Birth";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(383, 550);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 29);
            this.label8.TabIndex = 19;
            this.label8.Text = "Address";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(383, 650);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 29);
            this.label9.TabIndex = 20;
            this.label9.Text = "Telephone";
            // 
            // btn_add_patient
            // 
            this.btn_add_patient.BackColor = System.Drawing.Color.White;
            this.btn_add_patient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_patient.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(168)))), ((int)(((byte)(253)))));
            this.btn_add_patient.FlatAppearance.BorderSize = 2;
            this.btn_add_patient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_patient.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_patient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(168)))), ((int)(((byte)(253)))));
            this.btn_add_patient.Location = new System.Drawing.Point(823, 730);
            this.btn_add_patient.Name = "btn_add_patient";
            this.btn_add_patient.Size = new System.Drawing.Size(137, 45);
            this.btn_add_patient.TabIndex = 9;
            this.btn_add_patient.Text = "Add";
            this.btn_add_patient.UseVisualStyleBackColor = false;
            this.btn_add_patient.Click += new System.EventHandler(this.btn_add_patient_Click);
            // 
            // btn_edit_patient
            // 
            this.btn_edit_patient.BackColor = System.Drawing.Color.White;
            this.btn_edit_patient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_edit_patient.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(168)))), ((int)(((byte)(253)))));
            this.btn_edit_patient.FlatAppearance.BorderSize = 2;
            this.btn_edit_patient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit_patient.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit_patient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(168)))), ((int)(((byte)(253)))));
            this.btn_edit_patient.Location = new System.Drawing.Point(1006, 730);
            this.btn_edit_patient.Name = "btn_edit_patient";
            this.btn_edit_patient.Size = new System.Drawing.Size(137, 45);
            this.btn_edit_patient.TabIndex = 10;
            this.btn_edit_patient.Text = "Edit";
            this.btn_edit_patient.UseVisualStyleBackColor = false;
            this.btn_edit_patient.Click += new System.EventHandler(this.btn_edit_patient_Click);
            // 
            // txt_id_patient
            // 
            this.txt_id_patient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_id_patient.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_patient.Location = new System.Drawing.Point(694, 114);
            this.txt_id_patient.Name = "txt_id_patient";
            this.txt_id_patient.Size = new System.Drawing.Size(788, 36);
            this.txt_id_patient.TabIndex = 1;
            this.txt_id_patient.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_id_patient_KeyUp);
            // 
            // cbo_gender_patient
            // 
            this.cbo_gender_patient.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_gender_patient.FormattingEnabled = true;
            this.cbo_gender_patient.ItemHeight = 29;
            this.cbo_gender_patient.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbo_gender_patient.Location = new System.Drawing.Point(629, 355);
            this.cbo_gender_patient.Margin = new System.Windows.Forms.Padding(2);
            this.cbo_gender_patient.Name = "cbo_gender_patient";
            this.cbo_gender_patient.Size = new System.Drawing.Size(192, 37);
            this.cbo_gender_patient.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(168)))), ((int)(((byte)(253)))));
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(168)))), ((int)(((byte)(253)))));
            this.button1.Location = new System.Drawing.Point(1344, 730);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 45);
            this.button1.TabIndex = 21;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_patientlist
            // 
            this.btn_patientlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(168)))), ((int)(((byte)(253)))));
            this.btn_patientlist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_patientlist.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(168)))), ((int)(((byte)(253)))));
            this.btn_patientlist.FlatAppearance.BorderSize = 2;
            this.btn_patientlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_patientlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_patientlist.ForeColor = System.Drawing.Color.White;
            this.btn_patientlist.Location = new System.Drawing.Point(388, 108);
            this.btn_patientlist.Name = "btn_patientlist";
            this.btn_patientlist.Size = new System.Drawing.Size(204, 45);
            this.btn_patientlist.TabIndex = 22;
            this.btn_patientlist.Text = "Patient List";
            this.btn_patientlist.UseVisualStyleBackColor = false;
            this.btn_patientlist.Click += new System.EventHandler(this.btn_patientlist_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(986, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 29);
            this.label3.TabIndex = 23;
            this.label3.Text = "Age";
            // 
            // txtage
            // 
            this.txtage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtage.Location = new System.Drawing.Point(1130, 358);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(351, 36);
            this.txtage.TabIndex = 24;
            // 
            // frm_Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.txtage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_patientlist);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbo_gender_patient);
            this.Controls.Add(this.txt_id_patient);
            this.Controls.Add(this.btn_edit_patient);
            this.Controls.Add(this.btn_add_patient);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dt_dob_patient);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_address_patient);
            this.Controls.Add(this.txt_phone_patient);
            this.Controls.Add(this.txt_occupation_patient);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_name_patient);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_history_patient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_Patient";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Skincare - Patient";
            this.Load += new System.EventHandler(this.frm_Patient_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Medicine;
        private System.Windows.Forms.Button btn_Patient;
        private System.Windows.Forms.Button btn_LogOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pic_Home;
        private System.Windows.Forms.Button btn_history_patient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_name_patient;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_occupation_patient;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_phone_patient;
        private System.Windows.Forms.TextBox txt_address_patient;
        private System.Windows.Forms.DateTimePicker dt_dob_patient;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_add_patient;
        private System.Windows.Forms.Button btn_edit_patient;
        private System.Windows.Forms.Button btn_Setting;
        private System.Windows.Forms.TextBox txt_id_patient;
        private System.Windows.Forms.ComboBox cbo_gender_patient;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_patientlist;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtage;
    }
}