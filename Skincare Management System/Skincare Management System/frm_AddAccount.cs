using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Skincare_Management_System
{
    public partial class frm_AddAccount : Form
    {
        public frm_AddAccount()
        {
            InitializeComponent();
        }

        Thread th;

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openSetting);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openSetting()
        {
            Application.Run(new frm_Setting());
        }

    }
}
