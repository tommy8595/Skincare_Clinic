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
    public partial class frm_Stock : Form
    {
        public frm_Stock()
        {
            InitializeComponent();
        }

        Thread th;

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

        private void btn_back_stock_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openMedicine);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void btn_register_stock_Click(object sender, EventArgs e)
        {
            frm_Register register = new frm_Register();
            register.Show();
        }

        private void frm_Stock_Load(object sender, EventArgs e)
        {
            refresh_frmstock();
            dgv_product_frmstock.Update();
            this.dgv_product_frmstock.Columns[2].DefaultCellStyle.Format = "c";
            this.dgv_product_frmstock.Columns[3].DefaultCellStyle.Format = "c";

        }

        private void btn_print_frmstock_Click(object sender, EventArgs e)
        {
            frm_PrintStockReport f = new frm_PrintStockReport();
            f.Show();
        }

        private void btn_edit_stock_Click(object sender, EventArgs e)
        {
            if (dgv_product_frmstock.CurrentRow.Index!=-1)
            {
                int i = dgv_product_frmstock.CurrentRow.Index;
                int pi = int.Parse(dgv_product_frmstock.Rows[i].Cells[0].Value.ToString());//product id
                string pn = dgv_product_frmstock.Rows[i].Cells[1].Value.ToString();//product name
                double ps = double.Parse(dgv_product_frmstock.Rows[i].Cells[3].Value.ToString());//product sell price
                double up = double.Parse(dgv_product_frmstock.Rows[i].Cells[4].Value.ToString());//product import price
                frm_EditImportProduct f = new frm_EditImportProduct( pi,  pn,  ps, up);
                DialogResult d = new DialogResult();
                d=f.ShowDialog();
                if (d == DialogResult.None)
                {
                    
                }
                else
                    refresh_frmstock();
            }
            else
            {
                MessageBox.Show("Please select Item to Edit");
            }
        }
        public void refresh_frmstock()
        {
            SqlCommand cmd = new SqlCommand(@"select pro.pro_name as [Name],cate.cat_name[Category],pro.pro_sup as [Sell Price],pro.pro_upis as [Import Price],pro.pro_qty as [Qty]
                                            from tbl_product pro inner join tbl_catagory cate
                                            on pro.cat_id = cate.cat_id", SkinCareConnection.Conn);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            data.Fill(ds);
            dgv_product_frmstock.DataSource = ds.Tables[0];
        }
    }
}
