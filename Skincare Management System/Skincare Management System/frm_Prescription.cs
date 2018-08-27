﻿using System;
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
    public partial class frm_Prescription : Form
    {
        public frm_Prescription()
        {
            InitializeComponent();
        }
        Thread th;

        private void openReceipt()
        {
            Application.Run(new frmReceipt());
        }
        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_done_prescription_Click(object sender, EventArgs e)
        {
            th = new Thread(openReceipt);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}
