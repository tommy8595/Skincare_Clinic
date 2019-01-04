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
    public partial class frm_ImportMedicine : Form
    {
        public frm_ImportMedicine()
        {
            InitializeComponent();
        }

        Thread th;
        string str;
        SqlConnection con;
        DataTable dt;
        string[] spl;
        int ord_id;
        int lastPrescription = 0;
        DataSet dataSet = new DataSet();
        public string pres = "";

        private void openImportMedicine()
        {
            Application.Run(new frm_ImportMedicine());
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

        private void btn_Register_Click(object sender, EventArgs e)
        {
           
       
            frm_Register register = new frm_Register();
            register.Show();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openImportHistory);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openImportHistory()
        {
            Application.Run(new frm_ImportHistory());
        }


        public void getData() 
        {
            int n = dataGridView1.Rows.Add();
            //string st = cboName.SelectedItem.ToString();
            //spl = st.Split(new string[] { "    | " }, StringSplitOptions.None);
            //dataGridView1.Rows[n].Cells[0].Value = spl[0];
            //dataGridView1.Rows[n].Cells[1].Value = comboBox1.SelectedItem;
            //dataGridView1.Rows[n].Cells[2].Value = txtQuantity.Text;
            //dataGridView1.Rows[n].Cells[3].Value = spl[1];
            //dataGridView1.Rows[n].Cells[4].Value = getPrice(int.Parse(spl[1]));
            dataGridView1.Rows[n].Cells[0].Value = dataSet.Tables["Product"].Rows[cboName.SelectedIndex]["pro_name"].ToString();
            dataGridView1.Rows[n].Cells[1].Value = dataSet.Tables["Category"].Rows[comboBox1.SelectedIndex]["cat_name"].ToString();
            dataGridView1.Rows[n].Cells[2].Value = txtQuantity.Text;
            dataGridView1.Rows[n].Cells[3].Value = dataSet.Tables["Product"].Rows[cboName.SelectedIndex]["pro_id"].ToString();
            dataGridView1.Rows[n].Cells[4].Value = getPrice((int)cboName.SelectedValue);
        }

        public float getPrice(int ID) 
        {
            float id=0.0F;
            str = "Data Source=.;Initial Catalog=skin_cilinic;Integrated Security=True";
            con = new SqlConnection(str);
            con.Open();
            string q = "SELECT pro_upis FROM tbl_product where pro_id= " + ID.ToString();
            SqlDataReader dr = new SqlCommand(q, con).ExecuteReader();
            while (dr.Read())
            {
                id = Convert.ToSingle(dr.GetValue(0).ToString());
            }
            dr.Dispose();
            con.Close();
            return id;
            

            
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            //try
            //{          
            //spl = cboName.Text.Split(new string[] { "    | " }, StringSplitOptions.None);
            //if (cboName.SelectedItem == null || txtQuantity.Text=="")
            //{
            //    MessageBox.Show("Please Enter Name and Quantity!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else
            //{


            //        if (dataGridView1.Rows.Count != 0 && dataGridView1.Rows != null)
            //        {
            //            int i = 0;
            //            do
            //            {
            //                 if (dataGridView1.Rows[i].Cells[3].Value.ToString() == spl[1])
            //                {
            //                    dataGridView1.Rows[i].Cells[2].Value = int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()) 
            //                    + int.Parse(txtQuantity.Text);
            //                    goto god;
            //                }
            //                 i++;
            //            } while (i < dataGridView1.Rows.Count);
            //            getData();
            //        }
            //        else
            //        {
            //            getData();

            //        }               
            //}
            //     god:


            //cboName.Items.Clear();
            //comboBox1.Text = "Pick one...";
            //cboName.Enabled = false;
            //cboName.Text = "Pick Category First.";
            //txtQuantity.Text = "";
            //txtQuantity.Focus();
            //lblTotal.BorderStyle = BorderStyle.Fixed3D;
            //lblTotal.Text = "Total: " + getTotal().ToString("c");
            //if (dataGridView1.Rows.Count != 0) { btn_save.Enabled = true; btnRemove.Enabled = true; } 

            //}
            //catch (Exception t)
            //{

            //    MessageBox.Show("Please contact developer!" + t.Message);
            //}

            try
            {
                //spl = cboName.Text.Split(new string[] { "    | " }, StringSplitOptions.None);
                if (cboName.SelectedItem == null || txtQuantity.Text == "")
                {
                    MessageBox.Show("Please Enter Name and Quantity!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {


                    if (dataGridView1.Rows.Count != 0 && dataGridView1.Rows != null)
                    {
                        int i = 0;
                        do
                        {
                            if (dataGridView1.Rows[i].Cells[3].Value.ToString() == dataSet.Tables["Product"].Rows[cboName.SelectedIndex]["pro_id"].ToString())
                            {
                                dataGridView1.Rows[i].Cells[2].Value = int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString())
                                + int.Parse(txtQuantity.Text);
                                goto god;
                            }
                            i++;
                        } while (i < dataGridView1.Rows.Count);
                        getData();
                    }
                    else
                    {
                        getData();

                    }
                }
                god:


                SqlDataAdapter adapter = new SqlDataAdapter("SELECT MAX(tbl_order.ord_id) as ord_id FROM tbl_order ", SkinCareConnection.Conn);
                dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows[0][0].ToString() != "") ord_id = int.Parse(dt.Rows[0][0].ToString());
                else ord_id = 0;

                //cboName.Items.Clear();
                dataSet.Tables["Product"].Rows.Clear();
                comboBox1.Text = "Pick one...";
                cboName.Enabled = false;
                cboName.Text = "Pick Category First.";
                txtQuantity.Text = "";
                txtQuantity.Focus();
                lblTotal.BorderStyle = BorderStyle.Fixed3D;
                lblTotal.Text = "Total: " + getTotal().ToString("c");
                if (dataGridView1.Rows.Count != 0) { btn_save.Enabled = true; }
                comboBox1.SelectedIndexChanged -= comboBox1_SelectedIndexChanged;

            }
            catch (Exception t)
            {

                MessageBox.Show("Please contact developer!\t" + t.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to save?", "Confirmation",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {



                    str = "Data Source=.;Initial Catalog=skin_cilinic;Integrated Security=True";
                    con = new SqlConnection(str);
                    con.Open();
                    dt = new DataTable();
                    dt.Columns.Add("pid", typeof(int));
                    dt.Columns.Add("qty", typeof(int));

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            int pid = int.Parse(row.Cells[3].Value.ToString());
                            int qty = int.Parse(row.Cells[2].Value.ToString());
                            dt.Rows.Add(pid, qty);
                        }

                    }
                    SqlParameter t = new SqlParameter("@y", SqlDbType.Structured)
                    {
                        TypeName = "dbo.ty_many",
                        Value = dt
                    };
                    SqlCommand cmd = new SqlCommand("sp_insert_import", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(t);
                    cmd.ExecuteNonQuery();
                    dataGridView1.Rows.Clear();
                    con.Close();
                    if (MessageBox.Show("Your data have been saved successfully!","Information",MessageBoxButtons.OK,MessageBoxIcon.Information) == DialogResult.OK) 
                    {
                        this.Close();
                        th = new Thread(openMedicine);
                        th.SetApartmentState(ApartmentState.STA);
                        th.Start();
                    }                    
                    
                }

                catch (SqlException x)
                {
                    MessageBox.Show(x.Message);
                    throw;
                }
            }
            else
            {
                return;
            }
        }
        
        public float getTotal()
        {
            float total=0.0f;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                total = total + Convert.ToSingle(row.Cells[2].Value.ToString()) * Convert.ToSingle(row.Cells[4].Value.ToString()); 
            }
            return total;
        }
        
        public void frm_ImportMedicine_Load(object sender, EventArgs e)
        {
            this.dataGridView1.Columns[4].DefaultCellStyle.Format = "c";
            btn_save.Enabled = false;
            cboName.Enabled = false;
            btnRemove.Enabled = false;
            comboBox1.Text = "Pick one..";
            cboName.Text = "Pick Category first.";

            if (dataSet.Tables.Count.Equals(0))
            {
                dataSet.Tables.Add(new DataTable("Category"));
                dataSet.Tables.Add(new DataTable("Product"));
            }

            comboBox1.SelectedIndex = -1;
            comboBox1.SelectedIndexChanged -= comboBox1_SelectedIndexChanged;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string[] split;
            //string getString = comboBox1.SelectedItem.ToString();
            //split = getString.Split('.');
            //string SelectedString = split[0];
            //cboName.Items.Clear();
            //if (SelectedString != "")
            //{
            //    try
            //    {
            //        cboName.Text = "Pick One..";
            //        cboName.Enabled = true;
            //        con.Open();
            //        string q = "Select pro_name,pro_id from tbl_product where cat_id= " + SelectedString;
            //        SqlDataReader dr = new SqlCommand(q, con).ExecuteReader();
            //        while (dr.Read())
            //        {

            //            cboName.Items.Add(dr.GetValue(0).ToString() + "    | " + dr.GetValue(1).ToString());
            //        }

            //        dr.Close();
            //        con.Close();
            //    }
            //    catch (SqlException x)
            //    {
            //        MessageBox.Show(x.Message);
            //        throw;
            //    }
            //}
            dataSet.Tables["Product"].Rows.Clear();
            try
            {
                //cboName.Text = "Pick One..";
                cboName.Enabled = true;
                con.Open();
                string q = "Select pro_name,pro_id from tbl_product where cat_id= " + (int)comboBox1.SelectedValue;
                SqlDataReader dr = new SqlCommand(q, con).ExecuteReader();
                //while (dr.Read())
                //{

                //    cboName.Items.Add(dr.GetValue(0).ToString());
                //    pro_id.Add(dr.GetInt32(1));
                //}
                dataSet.Tables["Product"].Load(dr);

                dr.Close();
                con.Close();

                cboName.DisplayMember = "pro_name";
                cboName.ValueMember = "pro_id";
                cboName.DataSource = dataSet.Tables["Product"];
                //pro_id.Add((int)dataSet.Tables["Product"].Rows[cboName.SelectedIndex]["pro_id"]);
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.Message);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
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
       
        private void cboName_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtQuantity.Focus();
        }

       

        private void txtQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button2_Click(this, new EventArgs());
            }
        }

      

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            //try
            //{
            //    comboBox1.Items.Clear();
            //    str = "Data Source=.;Initial Catalog=skin_cilinic;Integrated Security=True";
            //    con = new SqlConnection(str);
            //    con.Open();
            //    string q = "SELECT cat_id,cat_name FROM tbl_catagory";
            //    SqlDataReader dr = new SqlCommand(q, con).ExecuteReader();
            //    while (dr.Read())
            //    {
            //        comboBox1.Items.Add(dr.GetValue(0).ToString() + "." + dr.GetValue(1).ToString());

            //    }
            //    dr.Close();
            //    con.Close();
            //}
            //catch (SqlException x)
            //{
            //    MessageBox.Show(x.Message);
            //    throw;
            //} 
            try
            {
                //comboBox1.Items.Clear();
                dataSet.Tables["Category"].Rows.Clear();
                str = "Data Source=.;Initial Catalog=skin_cilinic;Integrated Security=True";
                con = new SqlConnection(str);
                con.Open();
                string q = "SELECT cat_id,cat_name FROM tbl_catagory";
                SqlDataReader dr = new SqlCommand(q, con).ExecuteReader();
                //while (dr.Read())
                //{
                //    comboBox1.Items.Add(dr.GetValue(0) + "." + dr.GetValue(1).ToString());

                //}

                dataSet.Tables["Category"].Load(dr);
                dr.Close();
                con.Close();

                comboBox1.DisplayMember = "cat_name";
                comboBox1.ValueMember = "cat_id";
                comboBox1.DataSource = dataSet.Tables["Category"];

                comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            }
            catch (SqlException x)
            {
                MessageBox.Show(x.Message);
                throw;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell oneCell in dataGridView1.SelectedCells)
            {
                if (oneCell.Selected)
                    dataGridView1.Rows.RemoveAt(oneCell.RowIndex);
            }
        }
    }
}
