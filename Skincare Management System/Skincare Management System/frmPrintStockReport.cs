using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skincare_Management_System
{
    public partial class frmPrintStockReport : Form
    {
        public frmPrintStockReport()
        {
            InitializeComponent();
        }

        private void frmPrintStockReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'skin_cilinicDataSet1.tbl_product' table. You can move, or remove it, as needed.
            this.tbl_productTableAdapter.Fill(this.skin_cilinicDataSet1.tbl_product);

            this.reportViewer1.RefreshReport();
        }
    }
}
