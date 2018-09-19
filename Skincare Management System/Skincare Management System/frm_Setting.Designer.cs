namespace Skincare_Management_System
{
    partial class frm_Setting
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
            this.btn_ChangeUsername = new System.Windows.Forms.Button();
            this.btn_ChangePassword = new System.Windows.Forms.Button();
            this.btn_AddAccount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ChangeUsername
            // 
            this.btn_ChangeUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(168)))), ((int)(((byte)(253)))));
            this.btn_ChangeUsername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ChangeUsername.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ChangeUsername.FlatAppearance.BorderSize = 0;
            this.btn_ChangeUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ChangeUsername.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChangeUsername.ForeColor = System.Drawing.Color.White;
            this.btn_ChangeUsername.Location = new System.Drawing.Point(115, 74);
            this.btn_ChangeUsername.Name = "btn_ChangeUsername";
            this.btn_ChangeUsername.Size = new System.Drawing.Size(554, 58);
            this.btn_ChangeUsername.TabIndex = 3;
            this.btn_ChangeUsername.Text = "Change Username";
            this.btn_ChangeUsername.UseVisualStyleBackColor = false;
            this.btn_ChangeUsername.Click += new System.EventHandler(this.btn_ChangeUsername_Click);
            // 
            // btn_ChangePassword
            // 
            this.btn_ChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(168)))), ((int)(((byte)(253)))));
            this.btn_ChangePassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ChangePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ChangePassword.FlatAppearance.BorderSize = 0;
            this.btn_ChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ChangePassword.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChangePassword.ForeColor = System.Drawing.Color.White;
            this.btn_ChangePassword.Location = new System.Drawing.Point(115, 196);
            this.btn_ChangePassword.Name = "btn_ChangePassword";
            this.btn_ChangePassword.Size = new System.Drawing.Size(554, 58);
            this.btn_ChangePassword.TabIndex = 4;
            this.btn_ChangePassword.Text = "Change Password";
            this.btn_ChangePassword.UseVisualStyleBackColor = false;
            this.btn_ChangePassword.Click += new System.EventHandler(this.btn_ChangePassword_Click);
            // 
            // btn_AddAccount
            // 
            this.btn_AddAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(185)))), ((int)(((byte)(124)))));
            this.btn_AddAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_AddAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddAccount.FlatAppearance.BorderSize = 0;
            this.btn_AddAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddAccount.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddAccount.ForeColor = System.Drawing.Color.White;
            this.btn_AddAccount.Location = new System.Drawing.Point(115, 318);
            this.btn_AddAccount.Name = "btn_AddAccount";
            this.btn_AddAccount.Size = new System.Drawing.Size(554, 58);
            this.btn_AddAccount.TabIndex = 5;
            this.btn_AddAccount.Text = "Add New Account";
            this.btn_AddAccount.UseVisualStyleBackColor = false;
            this.btn_AddAccount.Click += new System.EventHandler(this.btn_AddAccount_Click);
            // 
            // frm_Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_AddAccount);
            this.Controls.Add(this.btn_ChangePassword);
            this.Controls.Add(this.btn_ChangeUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Setting";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setting";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ChangeUsername;
        private System.Windows.Forms.Button btn_ChangePassword;
        private System.Windows.Forms.Button btn_AddAccount;
    }
}