namespace Skincare_Management_System
{
    partial class frm_AddAccount
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
            this.txt_New_pass = new System.Windows.Forms.TextBox();
            this.txt_New_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Save_NewUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_New_pass
            // 
            this.txt_New_pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_New_pass.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_New_pass.Location = new System.Drawing.Point(339, 258);
            this.txt_New_pass.Name = "txt_New_pass";
            this.txt_New_pass.Size = new System.Drawing.Size(361, 38);
            this.txt_New_pass.TabIndex = 11;
            // 
            // txt_New_name
            // 
            this.txt_New_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_New_name.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_New_name.Location = new System.Drawing.Point(339, 173);
            this.txt_New_name.Name = "txt_New_name";
            this.txt_New_name.Size = new System.Drawing.Size(361, 38);
            this.txt_New_name.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 31);
            this.label1.TabIndex = 14;
            this.label1.Text = "New Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 31);
            this.label3.TabIndex = 15;
            this.label3.Text = "New Password";
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
            // btn_Save_NewUser
            // 
            this.btn_Save_NewUser.BackColor = System.Drawing.Color.White;
            this.btn_Save_NewUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save_NewUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(168)))), ((int)(((byte)(253)))));
            this.btn_Save_NewUser.FlatAppearance.BorderSize = 2;
            this.btn_Save_NewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save_NewUser.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save_NewUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(168)))), ((int)(((byte)(253)))));
            this.btn_Save_NewUser.Location = new System.Drawing.Point(339, 350);
            this.btn_Save_NewUser.Name = "btn_Save_NewUser";
            this.btn_Save_NewUser.Size = new System.Drawing.Size(137, 45);
            this.btn_Save_NewUser.TabIndex = 27;
            this.btn_Save_NewUser.Text = "Save";
            this.btn_Save_NewUser.UseVisualStyleBackColor = false;
            this.btn_Save_NewUser.Click += new System.EventHandler(this.btn_Save_NewUser_Click);
            // 
            // frm_AddAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Save_NewUser);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_New_name);
            this.Controls.Add(this.txt_New_pass);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_AddAccount";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setting - Add Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_New_pass;
        private System.Windows.Forms.TextBox txt_New_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Save_NewUser;
    }
}