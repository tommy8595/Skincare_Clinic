namespace Skincare_Management_System
{
    partial class frm_Prescription
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_add_prescription = new System.Windows.Forms.Button();
            this.txt_name_prescription = new System.Windows.Forms.TextBox();
            this.txt_qty_prescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_consultation_prescription = new System.Windows.Forms.CheckBox();
            this.txt_consultprice = new System.Windows.Forms.TextBox();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_done_prescription = new System.Windows.Forms.Button();
            this.lst_category_prescription = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(54, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1356, 565);
            this.dataGridView1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(168)))), ((int)(((byte)(253)))));
            this.label1.Location = new System.Drawing.Point(47, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 39);
            this.label1.TabIndex = 15;
            this.label1.Text = "Prescription";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(425, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 31);
            this.label4.TabIndex = 16;
            this.label4.Text = "Name";
            // 
            // btn_add_prescription
            // 
            this.btn_add_prescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(168)))), ((int)(((byte)(253)))));
            this.btn_add_prescription.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_prescription.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(168)))), ((int)(((byte)(253)))));
            this.btn_add_prescription.FlatAppearance.BorderSize = 2;
            this.btn_add_prescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_prescription.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_prescription.ForeColor = System.Drawing.Color.White;
            this.btn_add_prescription.Location = new System.Drawing.Point(1273, 77);
            this.btn_add_prescription.Name = "btn_add_prescription";
            this.btn_add_prescription.Size = new System.Drawing.Size(137, 45);
            this.btn_add_prescription.TabIndex = 27;
            this.btn_add_prescription.Text = "Add";
            this.btn_add_prescription.UseVisualStyleBackColor = false;
            // 
            // txt_name_prescription
            // 
            this.txt_name_prescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_name_prescription.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name_prescription.Location = new System.Drawing.Point(541, 81);
            this.txt_name_prescription.Name = "txt_name_prescription";
            this.txt_name_prescription.Size = new System.Drawing.Size(446, 38);
            this.txt_name_prescription.TabIndex = 28;
            // 
            // txt_qty_prescription
            // 
            this.txt_qty_prescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_qty_prescription.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_qty_prescription.Location = new System.Drawing.Point(1142, 81);
            this.txt_qty_prescription.Name = "txt_qty_prescription";
            this.txt_qty_prescription.Size = new System.Drawing.Size(92, 38);
            this.txt_qty_prescription.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1007, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 31);
            this.label2.TabIndex = 29;
            this.label2.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 31);
            this.label3.TabIndex = 31;
            this.label3.Text = "Category";
            // 
            // cb_consultation_prescription
            // 
            this.cb_consultation_prescription.AutoSize = true;
            this.cb_consultation_prescription.FlatAppearance.BorderSize = 0;
            this.cb_consultation_prescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_consultation_prescription.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_consultation_prescription.Location = new System.Drawing.Point(54, 739);
            this.cb_consultation_prescription.Name = "cb_consultation_prescription";
            this.cb_consultation_prescription.Size = new System.Drawing.Size(176, 35);
            this.cb_consultation_prescription.TabIndex = 33;
            this.cb_consultation_prescription.Text = "Consultaion";
            this.cb_consultation_prescription.UseVisualStyleBackColor = true;
            // 
            // txt_consultprice
            // 
            this.txt_consultprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_consultprice.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_consultprice.Location = new System.Drawing.Point(260, 739);
            this.txt_consultprice.Name = "txt_consultprice";
            this.txt_consultprice.Size = new System.Drawing.Size(92, 38);
            this.txt_consultprice.TabIndex = 34;
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
            this.btn_Back.Location = new System.Drawing.Point(1273, 735);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(137, 45);
            this.btn_Back.TabIndex = 36;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_done_prescription
            // 
            this.btn_done_prescription.BackColor = System.Drawing.Color.White;
            this.btn_done_prescription.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_done_prescription.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(168)))), ((int)(((byte)(253)))));
            this.btn_done_prescription.FlatAppearance.BorderSize = 2;
            this.btn_done_prescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_done_prescription.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_done_prescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(168)))), ((int)(((byte)(253)))));
            this.btn_done_prescription.Location = new System.Drawing.Point(1090, 735);
            this.btn_done_prescription.Name = "btn_done_prescription";
            this.btn_done_prescription.Size = new System.Drawing.Size(137, 45);
            this.btn_done_prescription.TabIndex = 35;
            this.btn_done_prescription.Text = "Done";
            this.btn_done_prescription.UseVisualStyleBackColor = false;
            this.btn_done_prescription.Click += new System.EventHandler(this.btn_done_prescription_Click);
            // 
            // lst_category_prescription
            // 
            this.lst_category_prescription.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_category_prescription.FormattingEnabled = true;
            this.lst_category_prescription.ItemHeight = 31;
            this.lst_category_prescription.Location = new System.Drawing.Point(183, 83);
            this.lst_category_prescription.Name = "lst_category_prescription";
            this.lst_category_prescription.Size = new System.Drawing.Size(185, 35);
            this.lst_category_prescription.TabIndex = 46;
            // 
            // frm_Prescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1464, 795);
            this.Controls.Add(this.lst_category_prescription);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_done_prescription);
            this.Controls.Add(this.txt_consultprice);
            this.Controls.Add(this.cb_consultation_prescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_qty_prescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_name_prescription);
            this.Controls.Add(this.btn_add_prescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Prescription";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Skincare - Prescription";
            this.Load += new System.EventHandler(this.frm_Prescription_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_add_prescription;
        private System.Windows.Forms.TextBox txt_name_prescription;
        private System.Windows.Forms.TextBox txt_qty_prescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cb_consultation_prescription;
        private System.Windows.Forms.TextBox txt_consultprice;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_done_prescription;
        private System.Windows.Forms.ListBox lst_category_prescription;
    }
}