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
using System.Data.SqlClient;

namespace Skincare_Management_System
{
    public partial class frm_ImportHistory : Form
    {
        public frm_ImportHistory()
        {
            InitializeComponent();
        }

        Thread th;
        SqlConnection conn;
        DataTable dt;
        int imid;

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


        private void openImportDetail()
        {
            Application.Run(new frm_ImportDetail(imid));
        }



        private void openImportMedicine()
        {
            Application.Run(new frm_ImportMedicine());
        }

        private void btn_imp_his_add_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openImportMedicine);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void btn_imp_his_back_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openMedicine);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void btn_imp_his_detail_Click(object sender, EventArgs e)
        {
            if (dgv_imp_his.CurrentRow.Index != 0)
            {
                int i = dgv_imp_his.CurrentRow.Index;
                imid = int.Parse(dgv_imp_his.Rows[i].Cells[0].Value.ToString());

                this.Close();
                th = new Thread(openImportDetail);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
            else
                MessageBox.Show("Please select Import");
        }

        private void frm_ImportHistory_Load(object sender, EventArgs e)
        {
            try
            {
                string str = "Data Source=.;Initial Catalog=skin_cilinic;Integrated Security=True";
                conn = new SqlConnection(str);
                conn.Open();
                string q = "SELECT imp_id,imp_date,imp_total FROM tbl_import";
                SqlDataAdapter data = new SqlDataAdapter(q, conn);
                dt = new DataTable();
                data.Fill(dt);
                dgv_imp_his.DataSource = dt;
                conn.Close();
            }
            catch(SqlException exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
