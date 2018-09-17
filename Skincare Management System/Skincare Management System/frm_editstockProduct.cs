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
    public partial class frm_EditImportProduct : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string str = "";
        private double ps1;
        private double up1;
        private int pid;
        private string proname;

        public frm_EditImportProduct(int pi, string pn,double ps,double up)
        {
            InitializeComponent();
            if (pi != 0 && pn != "" && ps != 0 && up != 0)
            {
                pid = pi;
                proname = pn;
                ps1 = ps;
                up1 = up;
            }
            else
                MessageBox.Show("Error please go back and select item");
        }

        //public frm_EditImportProduct(int pi, string pn, int ps, int up) : this(pi, pn)
        //{
        //    this.ps = ps;
        //    this.up = up;
        //}

        private void btn_save_EditStock_Click(object sender, EventArgs e)
        {
            try
            {
                str = "Data Source=.;Initial Catalog=skin_cilinic;Integrated Security=True";
                conn = new SqlConnection(str);
                conn.Open();
                cmd = new SqlCommand("dbo.update_product", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("pi", pid);
                cmd.Parameters.AddWithValue("@pn", txt_name_EditStock.Text);
                cmd.Parameters.AddWithValue("@ps", int.Parse(txt_sup_EditStock.Text));
                cmd.Parameters.AddWithValue("@up", int.Parse(txt_upis_EditStock.Text));
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Updated");
                this.Close();
                
            }
            catch (SqlException x)
            {

                MessageBox.Show(x.Message);
            }

        }

        private void btn_back_EditStock_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_EditImportProduct_Load(object sender, EventArgs e)
        {
            txt_name_EditStock.Text = proname;
            txt_sup_EditStock.Text = ps1.ToString();
            txt_upis_EditStock.Text = up1.ToString();
        }
        
    }
}
