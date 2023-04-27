using LHMS_Application.BLL;
using LHMS_Application.Dal;
using LHMS_Application.Database;
using LHMS_Application.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LHMS_Application.Reports
{
    public partial class FrmADCustomer : Form
    {
        public FrmADCustomer()
        {
            InitializeComponent();
        }
        CustomerBll dc = new CustomerBll();
        customerDal Cdal = new customerDal();

        userDal udal = new userDal();


        private void FrmDealersAndCustomer_Load(object sender, EventArgs e)
        {
            DataTable dt = Cdal.Select();
            dgvCustomer.DataSource = dt;

        }
        public void clear()
        {
            txtcode.Text = "";
            txtname.Text = "";
            txtemail.Text = "";
            txtcontact.Text = "";
            txtaddress.Text = "";
            txtid.Text = "";
        }
        DbConnection db = DbConnection.getInstance();
        public string CreateAutoID()
        {

            db.OpenCon();
            var randomCode = "";
            SqlCommand objSqlCommand = new SqlCommand("select count(*) from tbl_customer", db.conn);
            int randomId = Convert.ToInt32(objSqlCommand.ExecuteScalar());

            db.conn.Close();
            if (randomId > 0)
            {
                randomId = randomId + 1;
                randomCode = "CusID0000" + (int)randomId;
            }
            else
            {
                randomCode = "CusID00001";
            }
            return randomCode.ToString();
        }


        private void btnadd_Click(object sender, EventArgs e)
        {
            dc.cusCode= txtcode.Text;
            dc.name = txtname.Text;
            dc.email = txtemail.Text;
            dc.contact = txtcontact.Text;
            dc.address = txtaddress.Text;
            dc.added_date=DateTime.Now;
            string loggedUser = FrmLogin.LoggedIn;
            UserBll usr = udal.GetIDFromUsername(loggedUser);
            dc.added_by = usr.id;
            bool success = Cdal.Insert(dc);
            if (success == true)
            {
                MessageBox.Show("New customer is successfully Created.");
                clear();
                DataTable dt = Cdal.Select();
                dgvCustomer.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Fail to create a custormer");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dc.id = int.Parse(txtid.Text);
            dc.cusCode = txtcode.Text;
            dc.name = txtname.Text;
            dc.email = txtemail.Text;
            dc.contact = txtcontact.Text;
            dc.address = txtaddress.Text;
            dc.added_date = DateTime.Now;
            string loggedUser = FrmLogin.LoggedIn;
            UserBll usr = udal.GetIDFromUsername(loggedUser);
            dc.added_by = usr.id;
            bool success = Cdal.Update(dc);
            if (success == true)
            {
                MessageBox.Show("New customer is successfully upated.");
                clear();
                DataTable dt = Cdal.Select();
                dgvCustomer.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Fail to create a updated");
            }

        }
        private void dgvDeal_cus_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        { 
            int RowIndex = e.RowIndex;
            txtid.Text = dgvCustomer.Rows[0].Cells[0].Value.ToString();
            txtcode.Text = dgvCustomer.Rows[0].Cells[1].Value.ToString();
            txtname.Text = dgvCustomer.Rows[0].Cells[2].Value.ToString();
            txtemail.Text = dgvCustomer.Rows[0].Cells[3].Value.ToString();
            txtcontact.Text = dgvCustomer.Rows[0].Cells[4].Value.ToString();
            txtaddress.Text = dgvCustomer.Rows[0].Cells[5].Value.ToString();
        }

        private void btucuscode_Click(object sender, EventArgs e)
        {
            txtcode.Text = CreateAutoID();
            if (txtcode.Text != null && txtcode.Text != "")
            {
                txtcode.Enabled = true;
                txtname.Enabled = true;
                txtemail.Enabled = true;
                txtcontact.Enabled = true;
                txtaddress.Enabled = true;
            }
            else
            {
                txtcode.Enabled = false;
                txtname.Enabled = false;
                txtemail.Enabled = false;
                txtcontact.Enabled = false;
                txtaddress.Enabled = false;
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string keywords = txtid.Text;

            if (keywords != null && keywords != "")
            {

                DataTable dt = Cdal.Search(keywords);
                dgvCustomer.DataSource = dt;
                txtid.Text = dgvCustomer.Rows[0].Cells[0].Value.ToString();
                txtcode.Text = dgvCustomer.Rows[0].Cells[1].Value.ToString();
                txtname.Text = dgvCustomer.Rows[0].Cells[2].Value.ToString();
                txtemail.Text = dgvCustomer.Rows[0].Cells[3].Value.ToString();
                txtcontact.Text = dgvCustomer.Rows[0].Cells[4].Value.ToString();
                txtaddress.Text = dgvCustomer.Rows[0].Cells[5].Value.ToString();
            }
            else
            {
                DataTable dt = Cdal.Select();
                dgvCustomer.DataSource = dt;
            }

        }

        private void btnExtrat_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = "Response.xls";
                savefile.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
                if (dgvCustomer.Rows.Count > 0)
                {
                    if (savefile.ShowDialog() == DialogResult.OK)
                    {

                        StreamWriter wr = new StreamWriter(savefile.FileName);
                        for (int i = 0; i < dgvCustomer.Columns.Count; i++)
                        {
                            wr.Write(dgvCustomer.Columns[i].Name.ToString().ToUpper() + "\t");
                        }

                        wr.WriteLine();

                        //write rows to excel file
                        for (int i = 0; i < (dgvCustomer.Rows.Count); i++)
                        {
                            for (int j = 0; j < dgvCustomer.Columns.Count; j++)
                            {
                                if (dgvCustomer.Rows[i].Cells[j].Value != null)
                                {
                                    wr.Write(Convert.ToString(dgvCustomer.Rows[i].Cells[j].Value.ToString()) + "\t");
                                }
                                else
                                {
                                    wr.Write("\t");
                                }
                            }
                            //go to next line
                            wr.WriteLine();
                        }
                        //close file
                        wr.Close();
                        MessageBox.Show(this, "Data saved in Excel format at location " + savefile.FileName, "Successfully Saved", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                }
                else
                {
                    MessageBox.Show(this, "Zero record to export , perform a operation first", "Can't export file", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

            }


        }
    }
}
