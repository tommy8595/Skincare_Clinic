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
    public partial class frm_editstockProduct : Form
    {
        private int ps;
        private int up;

        public frm_editstockProduct(int pi, string pn)
        {
            InitializeComponent();
        }

        public frm_editstockProduct(int pi, string pn, int ps, int up) : this(pi, pn)
        {
            this.ps = ps;
            this.up = up;
        }

        private void btn_save_EditStock_Click(object sender, EventArgs e)
        {

        }

        private void btn_back_EditStock_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
