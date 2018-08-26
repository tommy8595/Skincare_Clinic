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

namespace Skincare_Management_System
{
    public partial class frm_Username : Form
    {
        public frm_Username()
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

        private void button6_Click(object sender, EventArgs e)
        {
            //if (true)
            //{
            //string connectionString =;
            //SqlConnection con = new SqlConnection(connectionString);
            //SqlCommand sql = new SqlCommand("Update User set Username=@NewUsername),con");
            //sql.Parameter.AddWithValue("@NewUsername",txt_user_ChangeUser);
            //}
            //y need password

        }
    }
}
