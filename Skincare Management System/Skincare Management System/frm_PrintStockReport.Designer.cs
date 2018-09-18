namespace Skincare_Management_System
{
    partial class frm_PrintStockReport
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
            this.spprintstockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skin_cilinicDataSet1 = new Skincare_Management_System.skin_cilinicDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_print_stockTableAdapter = new Skincare_Management_System.skin_cilinicDataSet1TableAdapters.sp_print_stockTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spprintstockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skin_cilinicDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // spprintstockBindingSource
            // 
            this.spprintstockBindingSource.DataMember = "sp_print_stock";
            this.spprintstockBindingSource.DataSource = this.skin_cilinicDataSet1;
            // 
            // skin_cilinicDataSet1
            // 
            this.skin_cilinicDataSet1.DataSetName = "skin_cilinicDataSet1";
            this.skin_cilinicDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spprintstockBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Skincare_Management_System.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // sp_print_stockTableAdapter
            // 
            this.sp_print_stockTableAdapter.ClearBeforeFill = true;
            // 
            // frm_PrintStockReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_PrintStockReport";
            this.Text = "frm_PrintStockReport";
            this.Load += new System.EventHandler(this.frm_PrintStockReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spprintstockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skin_cilinicDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private skin_cilinicDataSet1 skin_cilinicDataSet1;
        private System.Windows.Forms.BindingSource spprintstockBindingSource;
        private skin_cilinicDataSet1TableAdapters.sp_print_stockTableAdapter sp_print_stockTableAdapter;
    }
}