namespace Skincare_Management_System
{
    partial class frm_EditImport
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_name_edimp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_qty_edimp = new System.Windows.Forms.TextBox();
            this.btn_save_edimp = new System.Windows.Forms.Button();
            this.btn_back_edimp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 23);
            this.label1.TabIndex = 21;
            this.label1.Text = "Product Name";
            // 
            // txt_name_edimp
            // 
            this.txt_name_edimp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_name_edimp.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name_edimp.Location = new System.Drawing.Point(254, 88);
            this.txt_name_edimp.Margin = new System.Windows.Forms.Padding(2);
            this.txt_name_edimp.Name = "txt_name_edimp";
            this.txt_name_edimp.ReadOnly = true;
            this.txt_name_edimp.Size = new System.Drawing.Size(271, 32);
            this.txt_name_edimp.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 172);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 23);
            this.label2.TabIndex = 23;
            this.label2.Text = "Quantity";
            // 
            // txt_qty_edimp
            // 
            this.txt_qty_edimp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_qty_edimp.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_qty_edimp.Location = new System.Drawing.Point(254, 170);
            this.txt_qty_edimp.Margin = new System.Windows.Forms.Padding(2);
            this.txt_qty_edimp.Name = "txt_qty_edimp";
            this.txt_qty_edimp.Size = new System.Drawing.Size(271, 32);
            this.txt_qty_edimp.TabIndex = 22;
            this.txt_qty_edimp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_qty_edimp_KeyPress);
            // 
            // btn_save_edimp
            // 
            this.btn_save_edimp.BackColor = System.Drawing.Color.White;
            this.btn_save_edimp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save_edimp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(168)))), ((int)(((byte)(253)))));
            this.btn_save_edimp.FlatAppearance.BorderSize = 2;
            this.btn_save_edimp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save_edimp.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_edimp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(168)))), ((int)(((byte)(253)))));
            this.btn_save_edimp.Location = new System.Drawing.Point(254, 248);
            this.btn_save_edimp.Margin = new System.Windows.Forms.Padding(2);
            this.btn_save_edimp.Name = "btn_save_edimp";
            this.btn_save_edimp.Size = new System.Drawing.Size(103, 37);
            this.btn_save_edimp.TabIndex = 31;
            this.btn_save_edimp.Text = "Save";
            this.btn_save_edimp.UseVisualStyleBackColor = false;
            this.btn_save_edimp.Click += new System.EventHandler(this.btn_save_edimp_Click);
            // 
            // btn_back_edimp
            // 
            this.btn_back_edimp.BackColor = System.Drawing.Color.White;
            this.btn_back_edimp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back_edimp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(168)))), ((int)(((byte)(253)))));
            this.btn_back_edimp.FlatAppearance.BorderSize = 2;
            this.btn_back_edimp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back_edimp.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back_edimp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(168)))), ((int)(((byte)(253)))));
            this.btn_back_edimp.Location = new System.Drawing.Point(422, 248);
            this.btn_back_edimp.Margin = new System.Windows.Forms.Padding(2);
            this.btn_back_edimp.Name = "btn_back_edimp";
            this.btn_back_edimp.Size = new System.Drawing.Size(103, 37);
            this.btn_back_edimp.TabIndex = 30;
            this.btn_back_edimp.Text = "Back";
            this.btn_back_edimp.UseVisualStyleBackColor = false;
            this.btn_back_edimp.Click += new System.EventHandler(this.btn_back_edimp_Click);
            // 
            // frm_EditImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btn_save_edimp);
            this.Controls.Add(this.btn_back_edimp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_qty_edimp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_name_edimp);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_EditImport";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Import";
            this.Load += new System.EventHandler(this.frm_EditImport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_name_edimp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_qty_edimp;
        private System.Windows.Forms.Button btn_save_edimp;
        private System.Windows.Forms.Button btn_back_edimp;
    }
}