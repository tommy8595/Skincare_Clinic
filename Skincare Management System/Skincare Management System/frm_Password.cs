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
    public partial class frm_Password : Form
    {
        public frm_Password()
        {
            InitializeComponent();
        }

        Thread th;

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openSetting);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openSetting()
        {
            Application.Run(new frm_Setting());
        }

        private void btn_save_changepass_Click(object sender, EventArgs e)
        {
            string newpass = txt_pass_ChangePassword.Text;
            string confirmpass = txt_confirm_changepassword.Text;
            SkinCareConnection.OpenConnection();
            if (newpass==confirmpass)
            {
                SqlCommand cmd = new SqlCommand("update_password", SkinCareConnection.Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ui", ObjectUpdateUser.username));
                cmd.Parameters.Add(new SqlParameter("@p", txt_confirm_changepassword.Text));
                cmd.ExecuteNonQuery();
                
                MessageBox.Show("change password sucessfully");
                this.Close();
            }
            else
            {
                MessageBox.Show("Password Does not Match.");
            }
            SkinCareConnection.CloseConnection();
        }

       
    }
}
