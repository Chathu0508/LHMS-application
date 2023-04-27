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

namespace LHMS_Application.Froms
{
    public partial class FrmADDelaer : Form
    {
        DbConnection db = DbConnection.getInstance();

        dealerBll dc = new dealerBll();
        DealerDal Ddal = new DealerDal();
        userDal udal = new userDal();

        public static string Dealer_ID;

        public FrmADDelaer()
        {
            InitializeComponent();
        }
        public void clear()
        {
            txtcode.Text = "";
            txtname.Text = "";
            txtemail.Text = "";
            txtcontact.Text = "";
            txtaddress.Text = "";
            txtsearch.Text = "";
        }

        public string CreateAutoID()
        {
            db.OpenCon();
            var randomCode = "";
            SqlCommand objSqlCommand = new SqlCommand("select count(*) from tbl_dealer", db.conn);
            int randomId = Convert.ToInt32(objSqlCommand.ExecuteScalar());

            db.conn.Close();
            if (randomId > 0)
            {
                randomId = randomId + 1;
                randomCode = "DealID00000" + (int)randomId;
            }
            else
            {
                randomCode = "DealID00001";
            }
            return randomCode.ToString();
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

        private void btnadd_Click(object sender, EventArgs e)
        {
            dc.DeaCode = txtcode.Text;
            dc.name = txtname.Text;
            dc.email = txtemail.Text;
            dc.contact = txtcontact.Text;
            dc.address = txtaddress.Text;
            dc.added_date = DateTime.Now;
            string loggedUser = FrmLogin.LoggedIn;
            UserBll usr = udal.GetIDFromUsername(loggedUser);
            dc.added_by = usr.id;
            bool success = Ddal.Insert(dc);
            if (success == true)
            {
                MessageBox.Show("New dealer is successfully Created.");
                clear();
                DataTable dt = Ddal.Select();
                dgvDealer.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Fail to create a dealer");
            }

        }

        private void FrmADDelaer_Load(object sender, EventArgs e)
        {
            DataTable dt = Ddal.Select();
            dgvDealer.DataSource = dt;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dc.id = int.Parse(txtsearch.Text);
            dc.DeaCode = txtcode.Text;
            dc.name = txtname.Text;
            dc.email = txtemail.Text;
            dc.contact = txtcontact.Text;
            dc.address = txtaddress.Text;
            dc.added_date = DateTime.Now;
            string loggedUser = FrmLogin.LoggedIn;
            UserBll usr = udal.GetIDFromUsername(loggedUser);
            dc.added_by = usr.id;
            bool success = Ddal.Update(dc);
            if (success == true)
            {
                MessageBox.Show("New Dealer is successfully update.");
                clear();
                DataTable dt = Ddal.Select();
                dgvDealer.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Fail to update a dealer");
            }

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string keywords = txtsearch.Text;

            if (keywords != null && keywords != "")
            {

                DataTable dt = Ddal.Search(keywords);
                dgvDealer.DataSource = dt;
                txtsearch.Text = dgvDealer.Rows[0].Cells[0].Value.ToString();
                txtcode.Text = dgvDealer.Rows[0].Cells[1].Value.ToString();
                txtname.Text = dgvDealer.Rows[0].Cells[2].Value.ToString();
                txtemail.Text = dgvDealer.Rows[0].Cells[3].Value.ToString();
                txtcontact.Text = dgvDealer.Rows[0].Cells[4].Value.ToString();
                txtaddress.Text = dgvDealer.Rows[0].Cells[5].Value.ToString();
            }
            else
            {
                DataTable dt = Ddal.Select();
                dgvDealer.DataSource = dt;
            }

        }
        private void dgvDealer_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int RowIndex = e.RowIndex;
            txtsearch.Text = dgvDealer.Rows[0].Cells[0].Value.ToString();
            txtcode.Text = dgvDealer.Rows[0].Cells[1].Value.ToString();
            txtname.Text = dgvDealer.Rows[0].Cells[2].Value.ToString();
            txtemail.Text = dgvDealer.Rows[0].Cells[3].Value.ToString();
            txtcontact.Text = dgvDealer.Rows[0].Cells[4].Value.ToString();
            txtaddress.Text = dgvDealer.Rows[0].Cells[5].Value.ToString();
        }
    }
}
