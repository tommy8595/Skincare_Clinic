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
            this.tbl_customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skin_cilinicDataSet1 = new Skincare_Management_System.skin_cilinicDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tbl_customerTableAdapter = new Skincare_Management_System.skin_cilinicDataSet1TableAdapters.tbl_customerTableAdapter();
            this.dataSetPrescription = new Skincare_Management_System.Receipt.DataSetPrescription();
            this.prescriptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prescriptionTableAdapter = new Skincare_Management_System.Receipt.DataSetPrescriptionTableAdapters.PrescriptionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skin_cilinicDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPrescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prescriptionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbl_customerBindingSource
            // 
            this.tbl_customerBindingSource.DataMember = "tbl_customer";
            this.tbl_customerBindingSource.DataSource = this.skin_cilinicDataSet1;
            // 
            // skin_cilinicDataSet1
            // 
            this.skin_cilinicDataSet1.DataSetName = "skin_cilinicDataSet1";
            this.skin_cilinicDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetPatient";
            reportDataSource1.Value = this.tbl_customerBindingSource;
            reportDataSource2.Name = "DataSetPrescription";
            reportDataSource2.Value = this.prescriptionBindingSource;
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
            // tbl_customerTableAdapter
            // 
            this.tbl_customerTableAdapter.ClearBeforeFill = true;
            // 
            // dataSetPrescription
            // 
            this.dataSetPrescription.DataSetName = "DataSetPrescription";
            this.dataSetPrescription.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prescriptionBindingSource
            // 
            this.prescriptionBindingSource.DataMember = "Prescription";
            this.prescriptionBindingSource.DataSource = this.dataSetPrescription;
            // 
            // prescriptionTableAdapter
            // 
            this.prescriptionTableAdapter.ClearBeforeFill = true;
            // 
            // frm_Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 640);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_Receipt";
            this.Text = "frm_Receipt";
            this.Load += new System.EventHandler(this.frm_Receipt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skin_cilinicDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPrescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prescriptionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tbl_customerBindingSource;
        private skin_cilinicDataSet1 skin_cilinicDataSet1;
        private skin_cilinicDataSet1TableAdapters.tbl_customerTableAdapter tbl_customerTableAdapter;
        private Receipt.DataSetPrescription dataSetPrescription;
        private System.Windows.Forms.BindingSource prescriptionBindingSource;
        private Receipt.DataSetPrescriptionTableAdapters.PrescriptionTableAdapter prescriptionTableAdapter;
    }
}