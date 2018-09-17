namespace Skincare_Management_System
{
    partial class frm_Receipt
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dataSetForReceipt = new Skincare_Management_System.Receipt.DataSetForReceipt();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.receiptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.receiptTableAdapter = new Skincare_Management_System.Receipt.DataSetForReceiptTableAdapters.ReceiptTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetForReceipt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSetForReceipt
            // 
            this.dataSetForReceipt.DataSetName = "DataSetForReceipt";
            this.dataSetForReceipt.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetReceipt";
            reportDataSource1.Value = this.receiptBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Skincare_Management_System.Receipt.ReportReceipt.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
           
            this.reportViewer1.Size = new System.Drawing.Size(1030, 640);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // receiptBindingSource
            // 
            this.receiptBindingSource.DataMember = "Receipt";
            this.receiptBindingSource.DataSource = this.dataSetForReceipt;
            // 
            // receiptTableAdapter
            // 
            this.receiptTableAdapter.ClearBeforeFill = true;
            // 
            // frm_Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 640);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_Receipt";
            this.ShowIcon = false;
            this.Text = "Skincare - Receipt";
            this.Load += new System.EventHandler(this.frm_Receipt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetForReceipt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Receipt.DataSetForReceipt dataSetForReceipt;
        private System.Windows.Forms.BindingSource receiptBindingSource;
        private Receipt.DataSetForReceiptTableAdapters.ReceiptTableAdapter receiptTableAdapter;
    }
}