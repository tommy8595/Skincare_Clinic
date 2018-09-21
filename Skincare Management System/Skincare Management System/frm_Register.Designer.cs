namespace Skincare_Management_System
{
    partial class frm_Register
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_name_register = new System.Windows.Forms.TextBox();
            this.txt_importprice_register = new System.Windows.Forms.TextBox();
            this.txt_sellprice_register = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_save_register = new System.Windows.Forms.Button();
            this.btn_back_register = new System.Windows.Forms.Button();
            this.lst_category_register = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "Category";
            // 
            // txt_name_register
            // 
            this.txt_name_register.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_name_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name_register.Location = new System.Drawing.Point(340, 130);
            this.txt_name_register.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_name_register.Name = "txt_name_register";
            this.txt_name_register.Size = new System.Drawing.Size(361, 36);
            this.txt_name_register.TabIndex = 16;
            // 
            // txt_importprice_register
            // 
            this.txt_importprice_register.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_importprice_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_importprice_register.Location = new System.Drawing.Point(340, 208);
            this.txt_importprice_register.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_importprice_register.Name = "txt_importprice_register";
            this.txt_importprice_register.Size = new System.Drawing.Size(361, 36);
            this.txt_importprice_register.TabIndex = 17;
            this.txt_importprice_register.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_importprice_register_KeyPress);
            // 
            // txt_sellprice_register
            // 
            this.txt_sellprice_register.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_sellprice_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sellprice_register.Location = new System.Drawing.Point(340, 286);
            this.txt_sellprice_register.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_sellprice_register.Name = "txt_sellprice_register";
            this.txt_sellprice_register.Size = new System.Drawing.Size(361, 36);
            this.txt_sellprice_register.TabIndex = 18;
            this.txt_sellprice_register.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sellprice_register_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 29);
            this.label1.TabIndex = 19;
            this.label1.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 29);
            this.label3.TabIndex = 20;
            this.label3.Text = "Import Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 29);
            this.label4.TabIndex = 21;
            this.label4.Text = "Sell Price";
            // 
            // btn_save_register
            // 
            this.btn_save_register.BackColor = System.Drawing.Color.White;
            this.btn_save_register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save_register.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(168)))), ((int)(((byte)(253)))));
            this.btn_save_register.FlatAppearance.BorderSize = 2;
            this.btn_save_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_register.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(168)))), ((int)(((byte)(253)))));
            this.btn_save_register.Location = new System.Drawing.Point(340, 357);
            this.btn_save_register.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_save_register.Name = "btn_save_register";
            this.btn_save_register.Size = new System.Drawing.Size(137, 46);
            this.btn_save_register.TabIndex = 29;
            this.btn_save_register.Text = "Save";
            this.btn_save_register.UseVisualStyleBackColor = false;
            this.btn_save_register.Click += new System.EventHandler(this.btn_save_register_Click);
            // 
            // btn_back_register
            // 
            this.btn_back_register.BackColor = System.Drawing.Color.White;
            this.btn_back_register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back_register.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(168)))), ((int)(((byte)(253)))));
            this.btn_back_register.FlatAppearance.BorderSize = 2;
            this.btn_back_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back_register.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(168)))), ((int)(((byte)(253)))));
            this.btn_back_register.Location = new System.Drawing.Point(564, 357);
            this.btn_back_register.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_back_register.Name = "btn_back_register";
            this.btn_back_register.Size = new System.Drawing.Size(137, 46);
            this.btn_back_register.TabIndex = 28;
            this.btn_back_register.Text = "Back";
            this.btn_back_register.UseVisualStyleBackColor = false;
            this.btn_back_register.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // lst_category_register
            // 
            this.lst_category_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lst_category_register.FormattingEnabled = true;
            this.lst_category_register.Location = new System.Drawing.Point(340, 54);
            this.lst_category_register.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lst_category_register.Name = "lst_category_register";
            this.lst_category_register.Size = new System.Drawing.Size(361, 37);
            this.lst_category_register.TabIndex = 30;
            this.lst_category_register.DropDown += new System.EventHandler(this.lst_category_register_DropDown);
            this.lst_category_register.SelectedIndexChanged += new System.EventHandler(this.cboCat_SelectedIndexChanged);
            // 
            // frm_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lst_category_register);
            this.Controls.Add(this.btn_save_register);
            this.Controls.Add(this.btn_back_register);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_sellprice_register);
            this.Controls.Add(this.txt_importprice_register);
            this.Controls.Add(this.txt_name_register);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Register";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register Product";
            this.Load += new System.EventHandler(this.frm_Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_name_register;
        private System.Windows.Forms.TextBox txt_importprice_register;
        private System.Windows.Forms.TextBox txt_sellprice_register;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_save_register;
        private System.Windows.Forms.Button btn_back_register;
        private System.Windows.Forms.ComboBox lst_category_register;
    }
}