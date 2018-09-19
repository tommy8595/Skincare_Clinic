namespace Skincare_Management_System
{
    partial class frm_EditImportProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_EditImportProduct));
            this.btn_save_EditStock = new System.Windows.Forms.Button();
            this.btn_back_EditStock = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_sup_EditStock = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_name_EditStock = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_upis_EditStock = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_save_EditStock
            // 
            resources.ApplyResources(this.btn_save_EditStock, "btn_save_EditStock");
            this.btn_save_EditStock.BackColor = System.Drawing.Color.White;
            this.btn_save_EditStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save_EditStock.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(168)))), ((int)(((byte)(253)))));
            this.btn_save_EditStock.FlatAppearance.BorderSize = 2;
            this.btn_save_EditStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(168)))), ((int)(((byte)(253)))));
            this.btn_save_EditStock.Name = "btn_save_EditStock";
            this.btn_save_EditStock.UseVisualStyleBackColor = false;
            this.btn_save_EditStock.Click += new System.EventHandler(this.btn_save_EditStock_Click);
            // 
            // btn_back_EditStock
            // 
            resources.ApplyResources(this.btn_back_EditStock, "btn_back_EditStock");
            this.btn_back_EditStock.BackColor = System.Drawing.Color.White;
            this.btn_back_EditStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back_EditStock.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(168)))), ((int)(((byte)(253)))));
            this.btn_back_EditStock.FlatAppearance.BorderSize = 2;
            this.btn_back_EditStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(168)))), ((int)(((byte)(253)))));
            this.btn_back_EditStock.Name = "btn_back_EditStock";
            this.btn_back_EditStock.UseVisualStyleBackColor = false;
            this.btn_back_EditStock.Click += new System.EventHandler(this.btn_back_EditStock_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // txt_sup_EditStock
            // 
            resources.ApplyResources(this.txt_sup_EditStock, "txt_sup_EditStock");
            this.txt_sup_EditStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_sup_EditStock.Name = "txt_sup_EditStock";
            this.txt_sup_EditStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sup_EditStock_KeyPress);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txt_name_EditStock
            // 
            resources.ApplyResources(this.txt_name_EditStock, "txt_name_EditStock");
            this.txt_name_EditStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_name_EditStock.Name = "txt_name_EditStock";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // txt_upis_EditStock
            // 
            resources.ApplyResources(this.txt_upis_EditStock, "txt_upis_EditStock");
            this.txt_upis_EditStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_upis_EditStock.Name = "txt_upis_EditStock";
            this.txt_upis_EditStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_upis_EditStock_KeyPress);
            // 
            // frm_EditImportProduct
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_upis_EditStock);
            this.Controls.Add(this.btn_save_EditStock);
            this.Controls.Add(this.btn_back_EditStock);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_sup_EditStock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_name_EditStock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_EditImportProduct";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.frm_EditImportProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_save_EditStock;
        private System.Windows.Forms.Button btn_back_EditStock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_sup_EditStock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_name_EditStock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_upis_EditStock;
    }
}