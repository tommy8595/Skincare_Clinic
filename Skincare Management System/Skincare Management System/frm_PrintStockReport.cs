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
    public partial class frm_PrintStockReport : Form
    {
        public frm_PrintStockReport()
        {
            InitializeComponent();
        }

        private void frm_PrintStockReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'skin_cilinicDataSet1.sp_print_stock' table. You can move, or remove it, as needed.
            this.sp_print_stockTableAdapter.Fill(this.skin_cilinicDataSet1.sp_print_stock);

            this.reportViewer1.RefreshReport();
        }
    }
}
