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
using System.Globalization;

namespace Skincare_Management_System
{
    public partial class frm_Patient : Form
    {
        public frm_Patient()
        {
            InitializeComponent();
        }

        Thread th;
       

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

        public static string cun="";
        private void openHistory()
        {
            Application.Run(new frm_History());
        }

      

        private void btn_history_patient_Click(object sender, EventArgs e)
        {
            try
            {   
                if(class1.id==0)
                class1.id = int.Parse(txt_id_patient.Text);
                class1.name = txt_name_patient.Text;
 
                this.Close();
                th = new Thread(openHistory);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("You must select a patient first.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
           
        }

        private void btn_add_patient_Click(object sender, EventArgs e)
        {
           
       
            class_connection.insert_customer(txt_name_patient.Text, txt_address_patient.Text, txt_phone_patient.Text,
                cbo_gender_patient.Text,txt_occupation_patient.Text,int.Parse(txtage.Text));
            class_connection.reset_controll(this);
            SqlDataReader sqlDataReader = class_connection.get_customer_max_id();
            
            sqlDataReader.Read();
            string id = sqlDataReader.GetValue(0).ToString();
            class1.name = txt_name_patient.Text;
            class1.id = int.Parse(id);
            MessageBox.Show("You have successful, The id is: "+id);
            this.Close();
            th = new Thread(openHistory);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();


        }
        private void txt_id_patient_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                if (txt_id_patient.Text.Length == 0)
                {
                    txt_address_patient.Text = "";
                    cbo_gender_patient.Text = "";
                    txt_occupation_patient.Text = "";
                    txt_name_patient.Text = "";
                    txt_phone_patient.Text = "";
                    txtage.Text = "";
                    btn_add_patient.Enabled = true;
                }
           
                else
                {
                    SqlDataReader s_dr = class_connection.get_customer_id(int.Parse(txt_id_patient.Text.Trim()));
                    while (s_dr.Read())
                    {
                        txt_id_patient.Text = s_dr["cus_id"].ToString();
                        txt_name_patient.Text = s_dr["cus_name"].ToString();
                        cbo_gender_patient.Text = s_dr["cus_gender"].ToString();
                        txt_occupation_patient.Text = s_dr["cus_occupation"].ToString();
                        txt_address_patient.Text = s_dr["cus_address"].ToString();
                        txt_phone_patient.Text = s_dr["cus_phone"].ToString();
                        txtage.Text = s_dr["age"].ToString();
                       
                        
                        btn_add_patient.Enabled = false;
                        //+DateTime.Now-s_dr["cus_dob"]
                    }


                }

            }
            else
            {
                try
                {
                    SqlDataReader s_dr = class_connection.get_customer_id(int.Parse(txt_id_patient.Text.Trim()));

                    if (s_dr.HasRows)
                    {
                        while (s_dr.Read())
                        {
                            txt_id_patient.Text = s_dr["cus_id"].ToString();
                            txt_name_patient.Text = (s_dr["cus_name"].ToString());
                            cbo_gender_patient.Text = s_dr["cus_gender"].ToString();
                            txt_occupation_patient.Text = s_dr["cus_occupation"].ToString();
                            txt_address_patient.Text = s_dr["cus_address"].ToString();
                            txt_phone_patient.Text = s_dr["cus_phone"].ToString();
                            txtage.Text = s_dr["age"].ToString();
                            btn_add_patient.Enabled = false;
                        }
                    }
                    else
                    {
                        txt_address_patient.Text = "";
                        cbo_gender_patient.Text = "";
                        txt_occupation_patient.Text = "";
                        txt_name_patient.Text = "";
                        txt_phone_patient.Text = "";
                        txtage.Text = "";
                        btn_add_patient.Enabled = true;

                        MessageBox.Show("No Patient of this ID : " + txt_id_patient.Text.Trim());
                        txt_id_patient.Clear();
                    }
                }
                catch (Exception ex)
                {
                    if (txt_id_patient.Text.Length==1)
                        txt_id_patient.Text = "0";
                   
                    if (txt_id_patient.Text.Length > 1) 
                    {
                        txt_id_patient.Text = txt_id_patient.Text.Substring(0, txt_id_patient.Text.Length - 1);
                       
                    }
                    
                    MessageBox.Show("Please Input the number");
                }

            }
        }
        private void txt_phone_patient_KeyUp(object sender, KeyEventArgs e)
        {          

            if (e.KeyCode == Keys.Back)
            {
              if (txt_id_patient.Text.Length != 0)
              {
                    txt_address_patient.Text = "";
                    cbo_gender_patient.Text = "";
                    txt_occupation_patient.Text = "";
                    txt_name_patient.Text = "";
                    txt_id_patient.Text = "";
                    txtage.Text = "";
              }
          

            }
            else
            {
                SqlDataReader s_dr = class_connection.get_customer_phone(txt_phone_patient.Text);
                while (s_dr.Read())
                {
                     class1.id= int.Parse(s_dr["cus_id"].ToString()) ;
                    txt_name_patient.Text = s_dr["cus_name"].ToString();
                    cbo_gender_patient.Text = s_dr["cus_gender"].ToString();
                    txt_occupation_patient.Text = s_dr["cus_occupation"].ToString();
                    txt_address_patient.Text = s_dr["cus_address"].ToString();
                    txtage.Text = s_dr["cus_age"].ToString();

                }


            }
        }

        private void btn_edit_patient_Click(object sender, EventArgs e)
        {   
            if(class1.id==0)
            class_connection.update_customer(int.Parse(txt_id_patient.Text), txt_name_patient.Text, txt_address_patient.Text, txt_phone_patient.Text,
               cbo_gender_patient.Text,txt_occupation_patient.Text,int.Parse(txtage.Text));
            else
                class_connection.update_customer(class1.id, txt_name_patient.Text, txt_address_patient.Text, txt_phone_patient.Text,
              cbo_gender_patient.Text,txt_occupation_patient.Text,int.Parse(txtage.Text));
            MessageBox.Show("Update Successful");

        }

        private void frm_Patient_Load(object sender, EventArgs e)
        {
            class1.id = 0;
            class1.his_id = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            class_connection.reset_controll(this);
        }

        private void txt_phone_patient_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar==(char)Keys.Space);
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
             (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btn_patientlist_Click(object sender, EventArgs e)
        {
            frm_PatientList pl = new frm_PatientList();
            pl.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlDataReader s_dr = class_connection.get_customer_id(int.Parse(txt_id_patient.Text.Trim()));
            MessageBox.Show(s_dr["cus_age"].ToString());
        }

        //private void txt_phone_patient_KeyDown(object sender, KeyEventArgs e)
        //{
        //    Keys key = e.KeyCode;
        //    if(key==Keys.Space)
        //    {
        //        e.Handled = false;
        //    }
        //    base.OnKeyDown(e);

        //}
    }
}