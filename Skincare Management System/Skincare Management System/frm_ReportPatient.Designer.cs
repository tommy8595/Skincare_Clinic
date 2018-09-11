
namespace Skincare_Management_System
{
    partial class frm_ReportPatient
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
            this.skincilinicDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skin_cilinicDataSet = new Skincare_Management_System.skin_cilinicDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.skincilinicDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skin_cilinicDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // skincilinicDataSetBindingSource
            // 
            this.skincilinicDataSetBindingSource.DataSource = this.skin_cilinicDataSet;
            this.skincilinicDataSetBindingSource.Position = 0;
            // 
            // skin_cilinicDataSet
            // 
            this.skin_cilinicDataSet.DataSetName = "skin_cilinicDataSet";
            this.skin_cilinicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.skincilinicDataSetBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.skincilinicDataSetBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Skincare_Management_System.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            //this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(891, 499);
            this.reportViewer1.TabIndex = 0;
            // 
            // frm_ReportPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 499);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_ReportPatient";
            this.Text = "frm_ReportPatient";
            this.Load += new System.EventHandler(this.frm_ReportPatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.skincilinicDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skin_cilinicDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource skincilinicDataSetBindingSource;
        private skin_cilinicDataSet skin_cilinicDataSet;
    }
}