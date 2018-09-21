using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Skincare_Management_System
{
    public partial class frm_PatientList : Form
    {
        public frm_PatientList()
        {
            InitializeComponent();
        }
        SqlCommand cmd;
        SqlConnection con;
        string conn = "";
      

        private void dgv_patientlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void frm_PatientList_Load(object sender, EventArgs e)
        {
            conn = "Data Source=.;Initial Catalog=skin_cilinic;Integrated Security=True";
            con = new SqlConnection(conn);
            con.Open();
            string query = "select cus_id,cus_name,cus_phone from tbl_customer";
            SqlDataReader dr = new SqlCommand(query, con).ExecuteReader();
            while (dr.Read())
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = dr.GetValue(0).ToString();
                dataGridView1.Rows[n].Cells[1].Value = dr.GetValue(1).ToString();
                dataGridView1.Rows[n].Cells[2].Value = dr.GetValue(2).ToString();
            }
            this.dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Ascending);
            dr.Close();
            con.Close();
        }
    }
}
