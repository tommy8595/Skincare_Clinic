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
        public frm_Receipt()
        {
            InitializeComponent();
        }

        private void frm_Receipt_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetForReceipt.Prescription' table. You can move, or remove it, as needed.
            try
            {
                this.receiptTableAdapter.Fill(this.dataSetForReceipt.Receipt, class1.id);
                this.reportViewer1.RefreshReport();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
