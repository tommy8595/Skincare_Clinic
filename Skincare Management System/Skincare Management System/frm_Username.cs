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
    public partial class frm_Username : Form
    {
        public frm_Username()
        {
            
            InitializeComponent();
            SkinCareConnection.OpenConnection(); 

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
        
        private void btn_save_update_username_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("sp_update_user", SkinCareConnection.Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@ou", ObjectUpdateUser.username));//chab old name pi klang login
            cmd.Parameters.Add(new SqlParameter("@u", txt_user_ChangeUser.Text));
            cmd.Parameters.Add(new SqlParameter("@p",ObjectUpdateUser.password));
            cmd.ExecuteNonQuery();
            this.Close();
        }
    }
}
