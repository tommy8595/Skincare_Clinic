using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Windows.Forms;
using System.Data;

namespace Skincare_Management_System
{
    class class_connection
    {


        public static SqlConnection connection()
        {
            string connection_string = @"Data Source=.;Initial Catalog=skin_cilinic;Integrated Security=True";
            SqlConnection con = new SqlConnection(connection_string);
            try
            {

                con.Open();


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return con;
        }
        public static void reset_controll(Control form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = null;
                }
                if (control is RichTextBox)
                {
                    RichTextBox textBox = (RichTextBox)control;
                    textBox.Text = null;
                }

                if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    if (comboBox.Items.Count > 0)
                        comboBox.SelectedIndex = 0;
                }

                if (control is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)control;
                    checkBox.Checked = false;
                }

                if (control is ListBox)
                {
                    ListBox listBox = (ListBox)control;
                    listBox.ClearSelected();
                }
            }
        }
        public static void insert_customer(string cn, string ca, string cp, string cg, string co,int cage)
        {
            SqlCommand cmd = new SqlCommand("sp_insert_customer", connection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cn", cn);
            cmd.Parameters.AddWithValue("@ca", ca);
            cmd.Parameters.AddWithValue("@cp", cp);
            cmd.Parameters.AddWithValue("@cg", cg);
            cmd.Parameters.AddWithValue("@co", co);
            cmd.Parameters.AddWithValue("@cage",cage);
            cmd.ExecuteNonQuery();
            cmd.Dispose();

        }
        public static void insert_history(int ci,string his, string sk, string lc, string iv, string dg, string lv)
        {
            SqlCommand cmd = new SqlCommand("sp_insert_history", connection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ci",ci);
            cmd.Parameters.AddWithValue("@sk", sk);
            cmd.Parameters.AddWithValue("@iv", iv);
            cmd.Parameters.AddWithValue("@lc", lc);
            cmd.Parameters.AddWithValue("@dg", dg);
            cmd.Parameters.AddWithValue("@lv", int.Parse(lv));
            cmd.Parameters.AddWithValue("@his", his);
            cmd.Parameters.AddWithValue("@pre", "");
            cmd.ExecuteNonQuery();
            cmd.Dispose();

        }
        public static void update_customer(int ci, string cn, string ca, string cp, string cg,string co,int cage)
        {
            SqlCommand cmd = new SqlCommand("sp_update_customer", connection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ci", ci);
            cmd.Parameters.AddWithValue("@cn", cn);
            cmd.Parameters.AddWithValue("@ca", ca);
            cmd.Parameters.AddWithValue("@cp", cp);
            cmd.Parameters.AddWithValue("@cg", cg);
            cmd.Parameters.AddWithValue("@co", co);
            cmd.Parameters.AddWithValue("@cage",cage);
            cmd.ExecuteNonQuery();
            cmd.Dispose();

        }
        public static SqlDataReader get_customer_max_id()
        {

            SqlDataReader sdr;
            string q = "select max(cus_id) from tbl_customer";
            //SqlCommand cmd = new SqlCommand("select max(cus_id) from tbl_customer", connection()).ExecuteReader());
            sdr = new SqlCommand(q, connection()).ExecuteReader();
            return sdr;

        }

        public static SqlDataReader get_customer_id(int cid)
        {

            SqlDataReader sdr;
            SqlCommand cmd = new SqlCommand("sp_get_customer", connection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ci", cid);

            cmd.ExecuteNonQuery();
            sdr = cmd.ExecuteReader();
            return sdr;

        }
        public static SqlDataReader get_history_id(int cid)
        {

            SqlDataReader sdr;
            SqlCommand cmd = new SqlCommand("sp_get_history", connection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ci", cid);
            cmd.ExecuteNonQuery();
            sdr = cmd.ExecuteReader();
            return sdr;

        }
        public static SqlDataReader get_customer_name(string cn)
        {
            SqlDataReader sdr = null;
            SqlCommand cmd = new SqlCommand("sp_get_customer_name", connection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cn", cn);
            cmd.ExecuteNonQuery();
            sdr = cmd.ExecuteReader();
            return sdr;



        }
        public static SqlDataReader get_customer_phone(string cp)
        {
            SqlDataReader sdr = null;
            SqlCommand cmd = new SqlCommand("sp_get_customer_phone", connection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cp", cp);
            cmd.ExecuteNonQuery();
            sdr = cmd.ExecuteReader();
            return sdr;



        }

    }
}

