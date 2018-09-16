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
    public partial class frm_EditImport : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string str = "";
        int ii = 0;
        string pName = "";
        int pi = 0;
        int iq = 0;
      
        public frm_EditImport(int iid, string proName, int pid, int iqty)
        {
            InitializeComponent();

            ii = iid;
            pName = proName;
            pi = pid;
            iq = iqty;

            if (iid != 0 && proName != "" && pid != 0 && iqty != 0)
            {
                ii = iid;
                pName = proName;
                pi = pid;
                iq = iqty;
            }
            else
                MessageBox.Show("Error in data editing");
        }
        private void text_id_patient_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void btn_back_edimp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_EditImport_Load(object sender, EventArgs e)
        {
            txt_name_edimp.Text = pName;
            txt_qty_edimp.Text = iq.ToString();
        }

        private void btn_save_edimp_Click(object sender, EventArgs e)
        {
            try
            {
            str = "Data Source=.;Initial Catalog=skin_cilinic;Integrated Security=True";
            conn = new SqlConnection(str);
            conn.Open();
            cmd = new SqlCommand("dbo.sp_update_import",conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ii", ii);
            cmd.Parameters.AddWithValue("@pi", pi);
            cmd.Parameters.AddWithValue("@iq", int.Parse(txt_qty_edimp.Text));
            cmd.ExecuteNonQuery();
            conn.Close();
                this.Close();
            }
            catch (SqlException x)
            {

                MessageBox.Show(x.Message);
            }

        }

        private void txt_qty_edimp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 8)
            {
                return;
            }
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                e.Handled = true;
            }
        }


        private void frm_EditImport_Load_1(object sender, EventArgs e)
        {

        }
    }
}
