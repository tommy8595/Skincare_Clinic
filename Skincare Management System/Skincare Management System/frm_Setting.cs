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
    public partial class frm_Setting : Form
    {
        public frm_Setting()
        {
            InitializeComponent();
        }

        Thread th;

        private void btn_ChangeUsername_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openUsername);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openUsername()
        {
            Application.Run(new frm_Username());
        }

        private void btn_ChangePassword_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openPassword);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openPassword()
        {
            Application.Run(new frm_Password());
        }

        private void btn_AddAccount_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openAddAccount);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openAddAccount()
        {
            Application.Run(new frm_AddAccount());
        }
    }
}
