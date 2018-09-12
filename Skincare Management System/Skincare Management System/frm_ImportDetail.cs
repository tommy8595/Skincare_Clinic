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
    public partial class frm_ImportDetail : Form
    {
        int imd = 0;
        public frm_ImportDetail(int imid)
        {
            InitializeComponent();
            imd = imid;
        }
        
        Thread th;
        SqlConnection conn;
        DataTable dt;

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

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openImportHistory);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openImportHistory()
        {
            Application.Run(new frm_ImportHistory());
        }

        private void frm_ImportDetail_Load(object sender, EventArgs e)
        {
            try
            {
                string str = "Data Source=.;Initial Catalog=skin_cilinic;Integrated Security=True";
                conn = new SqlConnection(str);
                conn.Open();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
            string q = "select * from dbo.fn_get_import(" + imd+")";
            SqlDataAdapter data = new SqlDataAdapter(q, conn);
            dt = new DataTable();
            data.Fill(dt);
            dgv_imp_detail.DataSource = dt;
        }

        private void btn_edit_impdetail_Click(object sender, EventArgs e)
        {
            frm_EditImport EdImp = new frm_EditImport();
            EdImp.Show();
        }

        private void dgv_imp_detail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
