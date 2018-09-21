namespace Skincare_Management_System
{
    partial class frm_Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Home));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pic_Patient = new System.Windows.Forms.PictureBox();
            this.pic_Medicine = new System.Windows.Forms.PictureBox();
            this.lbl_Patient = new System.Windows.Forms.Label();
            this.lbl_Medicine = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.btn_Setting = new System.Windows.Forms.Button();
            this.lbl_cs = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Patient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Medicine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(396, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(706, 175);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pic_Patient
            // 
            this.pic_Patient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_Patient.Image = ((System.Drawing.Image)(resources.GetObject("pic_Patient.Image")));
            this.pic_Patient.Location = new System.Drawing.Point(396, 344);
            this.pic_Patient.Name = "pic_Patient";
            this.pic_Patient.Size = new System.Drawing.Size(232, 232);
            this.pic_Patient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Patient.TabIndex = 1;
            this.pic_Patient.TabStop = false;
            this.pic_Patient.Click += new System.EventHandler(this.pic_Patient_Click);
            // 
            // pic_Medicine
            // 
            this.pic_Medicine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_Medicine.Image = ((System.Drawing.Image)(resources.GetObject("pic_Medicine.Image")));
            this.pic_Medicine.Location = new System.Drawing.Point(870, 344);
            this.pic_Medicine.Name = "pic_Medicine";
            this.pic_Medicine.Size = new System.Drawing.Size(232, 232);
            this.pic_Medicine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Medicine.TabIndex = 2;
            this.pic_Medicine.TabStop = false;
            this.pic_Medicine.Click += new System.EventHandler(this.pic_Medicine_Click);
            // 
            // lbl_Patient
            // 
            this.lbl_Patient.AutoSize = true;
            this.lbl_Patient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Patient.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Patient.ForeColor = System.Drawing.Color.White;
            this.lbl_Patient.Location = new System.Drawing.Point(443, 588);
            this.lbl_Patient.Name = "lbl_Patient";
            this.lbl_Patient.Size = new System.Drawing.Size(125, 38);
            this.lbl_Patient.TabIndex = 4;
            this.lbl_Patient.Text = "Patient";
            this.lbl_Patient.Click += new System.EventHandler(this.lbl_Patient_Click);
            // 
            // lbl_Medicine
            // 
            this.lbl_Medicine.AutoSize = true;
            this.lbl_Medicine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Medicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Medicine.ForeColor = System.Drawing.Color.White;
            this.lbl_Medicine.Location = new System.Drawing.Point(898, 588);
            this.lbl_Medicine.Name = "lbl_Medicine";
            this.lbl_Medicine.Size = new System.Drawing.Size(155, 38);
            this.lbl_Medicine.TabIndex = 5;
            this.lbl_Medicine.Text = "Medicine";
            this.lbl_Medicine.Click += new System.EventHandler(this.lbl_Medicine_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.Location = new System.Drawing.Point(21, 276);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(1500, 1);
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_LogOut.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_LogOut.FlatAppearance.BorderSize = 2;
            this.btn_LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LogOut.ForeColor = System.Drawing.Color.White;
            this.btn_LogOut.Location = new System.Drawing.Point(1359, 752);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(137, 45);
            this.btn_LogOut.TabIndex = 10;
            this.btn_LogOut.Text = "Log Out";
            this.btn_LogOut.UseVisualStyleBackColor = true;
            this.btn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click);
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
            this.btn_Setting.Location = new System.Drawing.Point(1194, 752);
            this.btn_Setting.Name = "btn_Setting";
            this.btn_Setting.Size = new System.Drawing.Size(137, 45);
            this.btn_Setting.TabIndex = 69;
            this.btn_Setting.UseVisualStyleBackColor = false;
            this.btn_Setting.Click += new System.EventHandler(this.btn_Setting_Click);
            // 
            // lbl_cs
            // 
            this.lbl_cs.AutoSize = true;
            this.lbl_cs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_cs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cs.ForeColor = System.Drawing.Color.White;
            this.lbl_cs.Location = new System.Drawing.Point(60, 758);
            this.lbl_cs.Name = "lbl_cs";
            this.lbl_cs.Size = new System.Drawing.Size(138, 29);
            this.lbl_cs.TabIndex = 70;
            this.lbl_cs.Text = "Contact Us";
            this.lbl_cs.Click += new System.EventHandler(this.lbl_cs_Click);
            // 
            // frm_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(168)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.lbl_cs);
            this.Controls.Add(this.btn_Setting);
            this.Controls.Add(this.btn_LogOut);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.lbl_Medicine);
            this.Controls.Add(this.lbl_Patient);
            this.Controls.Add(this.pic_Medicine);
            this.Controls.Add(this.pic_Patient);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_Home";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Skincare - Home";
            this.Load += new System.EventHandler(this.frm_Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Patient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Medicine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pic_Patient;
        private System.Windows.Forms.PictureBox pic_Medicine;
        private System.Windows.Forms.Label lbl_Patient;
        private System.Windows.Forms.Label lbl_Medicine;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btn_LogOut;
        private System.Windows.Forms.Button btn_Setting;
        private System.Windows.Forms.Label lbl_cs;
    }
}