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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetForReceipt = new Skincare_Management_System.Receipt.DataSetForReceipt();
            this.prescriptonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientTableAdapter = new Skincare_Management_System.Receipt.DataSetForReceiptTableAdapters.PatientTableAdapter();
            this.dataSetForReceipt1 = new Skincare_Management_System.Receipt.DataSetForReceipt();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetForReceipt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prescriptonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetForReceipt1)).BeginInit();
            this.SuspendLayout();
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataMember = "Patient";
            this.patientBindingSource.DataSource = this.dataSetForReceipt;
            // 
            // dataSetForReceipt
            // 
            this.dataSetForReceipt.DataSetName = "DataSetForReceipt";
            this.dataSetForReceipt.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prescriptonBindingSource
            // 
            this.prescriptonBindingSource.DataMember = "Prescripton";
            this.prescriptonBindingSource.DataSource = this.dataSetForReceipt;
            // 
            // patientTableAdapter
            // 
            this.patientTableAdapter.ClearBeforeFill = true;
            // 
            // dataSetForReceipt1
            // 
            this.dataSetForReceipt1.DataSetName = "DataSetForReceipt";
            this.dataSetForReceipt1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetPatient";
            reportDataSource1.Value = this.patientBindingSource;
            reportDataSource2.Name = "DataSetPres";
            reportDataSource2.Value = this.prescriptonBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Skincare_Management_System.Receipt.ReportReceipt.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1030, 640);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // frm_Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 640);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_Receipt";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Skincare - Receipt";
            this.Load += new System.EventHandler(this.frm_Receipt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetForReceipt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prescriptonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetForReceipt1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource prescriptonBindingSource;
        private Receipt.DataSetForReceipt dataSetForReceipt;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private Receipt.DataSetForReceiptTableAdapters.PatientTableAdapter patientTableAdapter;
        private Receipt.DataSetForReceipt dataSetForReceipt1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}