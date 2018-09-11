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
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            SkinCareConnection.OpenConnection();
            InitializeComponent();

            txt_Password.PasswordChar = '*';
        }

        Thread th;

        private void openHome()
        {
            Application.Run(new frm_Home());
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT dbo.fn_check_login(@u,@p)",SkinCareConnection.Conn);
            cmd.Parameters.Add(new SqlParameter("@u", txt_Username.Text.Trim()));
            cmd.Parameters.Add(new SqlParameter("@p", txt_Password.Text.Trim()));

            bool HasUser = (bool)cmd.ExecuteScalar();
            if (HasUser)
            {

                ObjectUpdateUser.username = txt_Username.Text.Trim();
                ObjectUpdateUser.password = txt_Password.Text.Trim();

                this.Close();
                th = new Thread(openHome);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
            else
            {
                MessageBox.Show("Incorrect Password or Username");
            }
            
        }
    }
}
