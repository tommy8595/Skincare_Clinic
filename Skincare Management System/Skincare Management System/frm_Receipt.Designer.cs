﻿namespace Skincare_Management_System
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.prescriptonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetForReceipt = new Skincare_Management_System.Receipt.DataSetForReceipt();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientTableAdapter = new Skincare_Management_System.Receipt.DataSetForReceiptTableAdapters.PatientTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.prescriptonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetForReceipt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1030, 640);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // prescriptonBindingSource
            // 
            this.prescriptonBindingSource.DataMember = "Prescripton";
            this.prescriptonBindingSource.DataSource = this.dataSetForReceipt;
            // 
            // dataSetForReceipt
            // 
            this.dataSetForReceipt.DataSetName = "DataSetForReceipt";
            this.dataSetForReceipt.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataMember = "Patient";
            this.patientBindingSource.DataSource = this.dataSetForReceipt;
            // 
            // patientTableAdapter
            // 
            this.patientTableAdapter.ClearBeforeFill = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.prescriptonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetForReceipt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource prescriptonBindingSource;
        private Receipt.DataSetForReceipt dataSetForReceipt;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private Receipt.DataSetForReceiptTableAdapters.PatientTableAdapter patientTableAdapter;
    }
}