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
    public partial class frm_AddHistory : Form
    {
        public frm_AddHistory()
        {
            InitializeComponent();
        }

        Thread th;
      
        private void pic_Home_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openHome);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openHome()
        {
            Application.Run(new frm_Home());
        }

        private void btn_Patient_Click(object sender, EventArgs e)
        {

            this.Close();
            th = new Thread(openPatient);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openPatient()
        {
            Application.Run(new frm_Patient());
        }

        private void btn_Medicine_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openMedicine);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openMedicine()
        {
            Application.Run(new frm_Medicine());
        }


        private void btn_Setting_Click(object sender, EventArgs e)
        {
            frm_Setting setting = new frm_Setting();
            setting.Show();
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openLogin);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openLogin()
        {
            Application.Run(new frm_Login());
        }


        private void openHistory()
        {
            Application.Run(new frm_History());
        }

        private void btn_back_addhistory_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openHistory);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void frm_AddHistory_Load(object sender, EventArgs e)
        {
            cbo_level.SelectedIndex = 0;
            txt_id_patient.Text = class1.id.ToString();
            txt_name_addhistory.Text = class1.name;
            txt_name_addhistory.Enabled = false;
            txt_id_patient.Enabled = false;
        }

        private void btn_save_addhistory_Click(object sender, EventArgs e)
        {
            class_connection.insert_history(class1.id, rt_history_addhistory.Text, rt_se_addhistory.Text, txt_location_addhistory.Text, rt_investigation_addhistory.Text, rt_diagnosis_addhistory.Text, cbo_level.Text);
            MessageBox.Show("You have Saved");
            class_connection.reset_controll(this);
            this.Close();
            th = new Thread(open_report_history);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        
        public void open_report_history()
        {
            Application.Run(new frm_History());
        }
    }
}
