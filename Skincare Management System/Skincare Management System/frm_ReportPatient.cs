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
        int his_id=0;
        int id = 0;
        string name;
        public frm_ReportPatient(int his_id,int id,string name)
        {
            InitializeComponent();
            this.his_id = his_id;
            this.id = id;
            this.name = name;

        }

        private void frm_ReportPatient_Load(object sender, EventArgs e)
        {
            MessageBox.Show(his_id.ToString()+id.ToString()+name);
            this.reportViewer1.RefreshReport();
        }
    }
}
