namespace Skincare_Management_System
{
    partial class frm_ImportHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ImportHistory));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Setting = new System.Windows.Forms.Button();
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.btn_Medicine = new System.Windows.Forms.Button();
            this.btn_Patient = new System.Windows.Forms.Button();
            this.pic_Home = new System.Windows.Forms.PictureBox();
            this.dgv_imp_his = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_imp_his_back = new System.Windows.Forms.Button();
            this.btn_imp_his_add = new System.Windows.Forms.Button();
            this.btn_imp_his_detail = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_imp_his)).BeginInit();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 1283);
            this.panel1.TabIndex = 3;
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
            this.btn_Setting.Location = new System.Drawing.Point(136, 1023);
            this.btn_Setting.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Setting.Name = "btn_Setting";
            this.btn_Setting.Size = new System.Drawing.Size(206, 72);
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
            this.btn_LogOut.Location = new System.Drawing.Point(136, 1177);
            this.btn_LogOut.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(206, 72);
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
            this.btn_Medicine.Location = new System.Drawing.Point(39, 591);
            this.btn_Medicine.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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
            this.btn_Patient.Location = new System.Drawing.Point(39, 370);
            this.btn_Patient.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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
            this.pic_Home.Location = new System.Drawing.Point(4, 11);
            this.pic_Home.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pic_Home.Name = "pic_Home";
            this.pic_Home.Size = new System.Drawing.Size(484, 117);
            this.pic_Home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Home.TabIndex = 1;
            this.pic_Home.TabStop = false;
            this.pic_Home.Click += new System.EventHandler(this.pic_Home_Click);
            // 
            // dgv_imp_his
            // 
            this.dgv_imp_his.AllowUserToAddRows = false;
            this.dgv_imp_his.AllowUserToDeleteRows = false;
            this.dgv_imp_his.AllowUserToResizeColumns = false;
            this.dgv_imp_his.AllowUserToResizeRows = false;
            this.dgv_imp_his.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_imp_his.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_imp_his.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_imp_his.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_imp_his.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_imp_his.Location = new System.Drawing.Point(584, 136);
            this.dgv_imp_his.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgv_imp_his.Name = "dgv_imp_his";
            this.dgv_imp_his.RowTemplate.Height = 24;
            this.dgv_imp_his.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_imp_his.Size = new System.Drawing.Size(1640, 958);
            this.dgv_imp_his.TabIndex = 15;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "imp_id";
            this.Column1.HeaderText = "Import ID";
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "imp_date";
            this.Column2.HeaderText = "Import Date";
            this.Column2.Name = "Column2";
            this.Column2.Width = 350;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "imp_total";
            this.Column3.HeaderText = "Total Import Price";
            this.Column3.Name = "Column3";
            this.Column3.Width = 250;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(168)))), ((int)(((byte)(253)))));
            this.label1.Location = new System.Drawing.Point(572, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 61);
            this.label1.TabIndex = 16;
            this.label1.Text = "Import History";
            // 
            // btn_imp_his_back
            // 
            this.btn_imp_his_back.BackColor = System.Drawing.Color.White;
            this.btn_imp_his_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_imp_his_back.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(168)))), ((int)(((byte)(253)))));
            this.btn_imp_his_back.FlatAppearance.BorderSize = 2;
            this.btn_imp_his_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_imp_his_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_imp_his_back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(168)))), ((int)(((byte)(253)))));
            this.btn_imp_his_back.Location = new System.Drawing.Point(2018, 1142);
            this.btn_imp_his_back.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_imp_his_back.Name = "btn_imp_his_back";
            this.btn_imp_his_back.Size = new System.Drawing.Size(206, 72);
            this.btn_imp_his_back.TabIndex = 30;
            this.btn_imp_his_back.Text = "Back";
            this.btn_imp_his_back.UseVisualStyleBackColor = false;
            this.btn_imp_his_back.Click += new System.EventHandler(this.btn_imp_his_back_Click);
            // 
            // btn_imp_his_add
            // 
            this.btn_imp_his_add.BackColor = System.Drawing.Color.White;
            this.btn_imp_his_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_imp_his_add.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(168)))), ((int)(((byte)(253)))));
            this.btn_imp_his_add.FlatAppearance.BorderSize = 2;
            this.btn_imp_his_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_imp_his_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_imp_his_add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(168)))), ((int)(((byte)(253)))));
            this.btn_imp_his_add.Location = new System.Drawing.Point(1744, 1142);
            this.btn_imp_his_add.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_imp_his_add.Name = "btn_imp_his_add";
            this.btn_imp_his_add.Size = new System.Drawing.Size(206, 72);
            this.btn_imp_his_add.TabIndex = 31;
            this.btn_imp_his_add.Text = "Add";
            this.btn_imp_his_add.UseVisualStyleBackColor = false;
            this.btn_imp_his_add.Click += new System.EventHandler(this.btn_imp_his_add_Click);
            // 
            // btn_imp_his_detail
            // 
            this.btn_imp_his_detail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(168)))), ((int)(((byte)(253)))));
            this.btn_imp_his_detail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_imp_his_detail.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(168)))), ((int)(((byte)(253)))));
            this.btn_imp_his_detail.FlatAppearance.BorderSize = 2;
            this.btn_imp_his_detail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_imp_his_detail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_imp_his_detail.ForeColor = System.Drawing.Color.White;
            this.btn_imp_his_detail.Location = new System.Drawing.Point(584, 1142);
            this.btn_imp_his_detail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_imp_his_detail.Name = "btn_imp_his_detail";
            this.btn_imp_his_detail.Size = new System.Drawing.Size(206, 72);
            this.btn_imp_his_detail.TabIndex = 32;
            this.btn_imp_his_detail.Text = "Detail";
            this.btn_imp_his_detail.UseVisualStyleBackColor = false;
            this.btn_imp_his_detail.Click += new System.EventHandler(this.btn_imp_his_detail_Click);
            // 
            // frm_ImportHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(2312, 1283);
            this.Controls.Add(this.btn_imp_his_detail);
            this.Controls.Add(this.btn_imp_his_add);
            this.Controls.Add(this.btn_imp_his_back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_imp_his);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "frm_ImportHistory";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Skincare - Import History";
            this.Load += new System.EventHandler(this.frm_ImportHistory_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_imp_his)).EndInit();
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
        private System.Windows.Forms.DataGridView dgv_imp_his;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_imp_his_back;
        private System.Windows.Forms.Button btn_imp_his_add;
        private System.Windows.Forms.Button btn_imp_his_detail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}