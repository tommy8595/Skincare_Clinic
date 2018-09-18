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
    public partial class frm_ReportPatient : Form
    {
        public frm_ReportPatient()
        {
            InitializeComponent();

        }

        private void frm_ReportPatient_Load(object sender, EventArgs e)
        {
            this.sp_select_history1TableAdapter1.Fill(this.skin_cilinicDataSet11.sp_select_history1, class1.id, 2);
            this.reportViewer1.RefreshReport();
        }
    }
}
