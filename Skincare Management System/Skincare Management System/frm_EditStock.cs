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
    public partial class frm_EditStock : Form
    {
        public frm_EditStock()
        {
            InitializeComponent();
        }

        private void btn_save_edStock_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand cmd;
            string str = "";
            
            try
            {
                str = "Data Source=.;Initial Catalog=skin_cilinic;Integrated Security=True";
                conn = new SqlConnection(str);
                conn.Open();
                cmd = new SqlCommand("dbo.sp_update_product", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pn", txt_name_ediStock.Text);
                cmd.Parameters.AddWithValue("@ps", int.Parse(txt_sup_edStock.Text));
                cmd.Parameters.AddWithValue("@iq", int.Parse(txt_upis_edStock.Text));
                cmd.ExecuteNonQuery();
                conn.Close();

                this.Close();
            }
            catch (SqlException x)
            {

                MessageBox.Show(x.Message);
            }

        }

        private void btn_back_edStock_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
