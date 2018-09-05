namespace Skincare_Management_System
{
    partial class frm_Password
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
            this.txt_pass_ChangePassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_confirm_changepassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_save_changepass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_pass_ChangePassword
            // 
            this.txt_pass_ChangePassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_pass_ChangePassword.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass_ChangePassword.Location = new System.Drawing.Point(339, 88);
            this.txt_pass_ChangePassword.Name = "txt_pass_ChangePassword";
            this.txt_pass_ChangePassword.Size = new System.Drawing.Size(361, 38);
            this.txt_pass_ChangePassword.TabIndex = 8;
            
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "New Password";
            // 
            // txt_confirm_changepassword
            // 
            this.txt_confirm_changepassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_confirm_changepassword.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_confirm_changepassword.Location = new System.Drawing.Point(339, 173);
            this.txt_confirm_changepassword.Name = "txt_confirm_changepassword";
            this.txt_confirm_changepassword.Size = new System.Drawing.Size(361, 38);
            this.txt_confirm_changepassword.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 31);
            this.label1.TabIndex = 13;
            this.label1.Text = "Confirm Password";
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.White;
            this.btn_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Back.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(168)))), ((int)(((byte)(253)))));
            this.btn_Back.FlatAppearance.BorderSize = 2;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(168)))), ((int)(((byte)(253)))));
            this.btn_Back.Location = new System.Drawing.Point(563, 350);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(137, 45);
            this.btn_Back.TabIndex = 26;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_save_changepass
            // 
            this.btn_save_changepass.BackColor = System.Drawing.Color.White;
            this.btn_save_changepass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save_changepass.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(168)))), ((int)(((byte)(253)))));
            this.btn_save_changepass.FlatAppearance.BorderSize = 2;
            this.btn_save_changepass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save_changepass.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_changepass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(168)))), ((int)(((byte)(253)))));
            this.btn_save_changepass.Location = new System.Drawing.Point(339, 350);
            this.btn_save_changepass.Name = "btn_save_changepass";
            this.btn_save_changepass.Size = new System.Drawing.Size(137, 45);
            this.btn_save_changepass.TabIndex = 27;
            this.btn_save_changepass.Text = "Save";
            this.btn_save_changepass.UseVisualStyleBackColor = false;
            this.btn_save_changepass.Click += new System.EventHandler(this.btn_save_changepass_Click);
            // 
            // frm_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_save_changepass);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_confirm_changepassword);
            this.Controls.Add(this.txt_pass_ChangePassword);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Password";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setting - Change Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_pass_ChangePassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_confirm_changepassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_save_changepass;
    }
}