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
    public partial class frm_History : Form
    {
        public frm_History()
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

        private void btn_Report_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openReport);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openReport()
        {
            Application.Run(new frm_Report());
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




        private void openAddHistory()
        {
            Application.Run(new frm_AddHistory());
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btn_add_history_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openAddHistory);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void btn_back_history_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openPatient);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void btn_print_history_Click(object sender, EventArgs e)
        {
            frm_ReportPatient rp = new frm_ReportPatient
            (int.Parse(dgv_history.CurrentRow.Cells["history_id"].Value.ToString()),int.Parse(txt_id_history.Text),txt_name_history.Text);
            rp.Show();
        }

        private void frm_History_Load(object sender, EventArgs e)
        {
            txt_id_history.Text = class1.id.ToString();
            txt_name_history.Text = class1.name.ToString();
            txt_id_history.Enabled = false;
            txt_name_history.Enabled = false;
            DataTable dt = new DataTable();
            dt.Load(class_connection.get_history_id(class1.id));
            dgv_history.DataSource = dt;
            foreach (DataGridViewColumn column in dgv_history.Columns)
            {
                column.Width = 130;
            }

            foreach (DataGridViewRow row in dgv_history.Rows)
            {
                row.Height = 200;
            }
            for(int i=1;i<8;i++)
            this.dgv_history.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;

        }
    }
}
