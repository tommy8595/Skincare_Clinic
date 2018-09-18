using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Skincare_Management_System
{
    public partial class frm_Receipt : Form
    {
        public frm_Receipt(Receipt.DataSetForReceipt dataSetForReceipt)
        {
            InitializeComponent();

            prescriptonBindingSource.DataSource = dataSetForReceipt.Prescripton;
            ReportDataSource reportDataSource = new ReportDataSource("Prescripton",prescriptonBindingSource);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);

        }
        int his_id = frm_Prescription.his_id;
        private void frm_Receipt_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetForReceipt.Prescription' table. You can move, or remove it, as needed.
            try
            {
                this.patientTableAdapter.Fill(this.dataSetForReceipt.Patient, class1.id);
                this.reportViewer1.RefreshReport();
                
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
