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

            SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_user");
            cmd.Connection = SkinCareConnection.Conn;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    MessageBox.Show(reader[0].ToString());
                }
            }
            else
            {
                MessageBox.Show("No Rows");
            }
        }

        Thread th;

        private void openHome()
        {
            Application.Run(new frm_Home());
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openHome);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}
