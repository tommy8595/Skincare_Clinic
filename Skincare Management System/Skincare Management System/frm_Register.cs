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
    public partial class frm_Register : Form
    {
        public frm_Register()
        {
            InitializeComponent();
            SkinCareConnection.OpenConnection();
        }
        SqlCommand cmd;
        SqlConnection con;
        DataTable dt;
        string str;
        string test;
        string[] spl;
        Thread th;       
        

        private void btn_Back_Click(object sender, EventArgs e)
        {
         
            this.Close();
        }
        private void openImportMedicine()
        {
            Application.Run(new frm_ImportMedicine());
        }

        private void btn_save_register_Click(object sender, EventArgs e)
        {
            try
            {
                if( string.IsNullOrEmpty((txt_importprice_register.Text)) || string.IsNullOrEmpty(txt_name_register.Text) || string.IsNullOrEmpty(txt_sellprice_register.Text)
                    || string.IsNullOrEmpty(lst_category_register.Text))
                {
                    MessageBox.Show("Please enter all field!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    str = "Data Source=.;Initial Catalog=skin_cilinic;Integrated Security=True";
                    con = new SqlConnection(str);
                    con.Open();
                    if (lst_category_register.SelectedIndex != (lst_category_register.Items.Count - 1))
                    {                      
                        spl = lst_category_register.Text.Split('.');                       
                        SqlCommand cmd = new SqlCommand("dbo.sp_insert_product", con);
                        cmd.CommandType = CommandType.StoredProcedure;                    
                        cmd.Parameters.AddWithValue("@pn", txt_name_register.Text);
                        cmd.Parameters.AddWithValue("@ci", spl[0]);
                        cmd.Parameters.AddWithValue("@ps", txt_sellprice_register.Text);
                        cmd.Parameters.AddWithValue("@pu", txt_importprice_register.Text);
                        cmd.Parameters.AddWithValue("@q",0);
                        cmd.ExecuteNonQuery();
                        txt_importprice_register.Clear();
                        txt_name_register.Clear();
                        txt_sellprice_register.Clear();
                        lst_category_register.Text = "";
                        MessageBox.Show("Your data have been saved!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.Close(); 
                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand("dbo.sp_insert_product", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        
                   
                        cmd.Parameters.AddWithValue("@pn", txt_name_register.Text);
                        cmd.Parameters.AddWithValue("@cn", lst_category_register.Text);
                        cmd.Parameters.AddWithValue("@ps", txt_sellprice_register.Text);
                        cmd.Parameters.AddWithValue("@pu", txt_importprice_register.Text);
                        cmd.Parameters.AddWithValue("@q", 0);
                        cmd.ExecuteNonQuery();
                        txt_importprice_register.Clear();
                        txt_name_register.Clear();
                        txt_sellprice_register.Clear();
                        lst_category_register.Text = "";
                        con.Close();
                        MessageBox.Show("Your data have been saved!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);               
                    }

                }
            }
            catch (SqlException x)
            {

                MessageBox.Show(x.Message);
            }
        }

        private void frm_Register_Load(object sender, EventArgs e)
        {
            lst_category_register.Text = "Choose Or Add New...";
            str = "Data Source=.;Initial Catalog=skin_cilinic;Integrated Security=True";
            con = new SqlConnection(str);
            con.Open();
            string q = "SELECT cat_id,cat_name FROM tbl_catagory";
            SqlDataReader dr = new SqlCommand(q, con).ExecuteReader();
            while (dr.Read())
            {
                lst_category_register.Items.Add(dr.GetValue(0).ToString() + "." + dr.GetValue(1).ToString());
            }
            lst_category_register.Items.Add("Add New...");
            dr.Close();
            con.Close();
        }

        private void cboCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_category_register.SelectedIndex==(lst_category_register.Items.Count-1))
            {
                lst_category_register.Items.Clear();
                lst_category_register.Focus();               
            }
        }

        private void txt_importprice_register_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_sellprice_register_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

       
    }
}
