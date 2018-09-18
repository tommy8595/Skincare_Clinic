
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.skin_cilinicDataSet11 = new Skincare_Management_System.skin_cilinicDataSet1();
            this.skincilinicDataSet11BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spselecthistory1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_select_history1TableAdapter1 = new Skincare_Management_System.skin_cilinicDataSet1TableAdapters.sp_select_history1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.skin_cilinicDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skincilinicDataSet11BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spselecthistory1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spselecthistory1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Skincare_Management_System.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(891, 499);
            this.reportViewer1.TabIndex = 0;
            // 
            // skin_cilinicDataSet11
            // 
            this.skin_cilinicDataSet11.DataSetName = "skin_cilinicDataSet1";
            this.skin_cilinicDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // skincilinicDataSet11BindingSource
            // 
            this.skincilinicDataSet11BindingSource.DataSource = this.skin_cilinicDataSet11;
            this.skincilinicDataSet11BindingSource.Position = 0;
            // 
            // spselecthistory1BindingSource
            // 
            this.spselecthistory1BindingSource.DataMember = "sp_select_history1";
            this.spselecthistory1BindingSource.DataSource = this.skincilinicDataSet11BindingSource;
            // 
            // sp_select_history1TableAdapter1
            // 
            this.sp_select_history1TableAdapter1.ClearBeforeFill = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.skin_cilinicDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skincilinicDataSet11BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spselecthistory1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private skin_cilinicDataSet1 skin_cilinicDataSet1;
        private skin_cilinicDataSet1TableAdapters.sp_select_history1TableAdapter sp_select_history1TableAdapter;
        private System.Windows.Forms.BindingSource skincilinicDataSet11BindingSource;
        private skin_cilinicDataSet1 skin_cilinicDataSet11;
        private System.Windows.Forms.BindingSource spselecthistory1BindingSource;
        private skin_cilinicDataSet1TableAdapters.sp_select_history1TableAdapter sp_select_history1TableAdapter1;
    }
}