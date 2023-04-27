using LHMS_Application.BLL;
using LHMS_Application.Dal;
using LHMS_Application.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LHMS_Application.Reports
{
    public partial class FrmADProductCode : Form
    {
        ProductcodeBll pbl = new ProductcodeBll();
        ProductCodeDal pcdal = new ProductCodeDal();

        CatagorysubDal cdal = new CatagorysubDal();

        public FrmADProductCode()
        {
            InitializeComponent();
        }

        DbConnection db = DbConnection.getInstance();

        public void Clear()
        {
            txtproductcode.Text = "";
            cmbProductname.Text = "";
        }


        private void FrmProductCode_Load(object sender, EventArgs e)
        {
            DataTable categoriessubDT = cdal.Select();
            cmbProductname.DataSource = categoriessubDT;
            cmbProductname.DisplayMember = "Product_name";
            cmbProductname.ValueMember = "Product_name";


            DataTable dt = pcdal.Select();
            dgvProductCode.DataSource = dt;


        }

        public void LoadData()
        {
            db.OpenCon();

            SqlCommand objSqlCommand = new SqlCommand("select * from tbl_productCode", db.conn);
            try
            {
                var i = objSqlCommand.ExecuteNonQuery();
                dgvProductCode.DataSource = i;
            }
            catch (Exception ex)
            {
                db.conn.Close();
            }
        }
        public string CreateAutoID()
        {
            db.OpenCon();
            var randomCode = "";
            SqlCommand objSqlCommand = new SqlCommand("select count(*) from tbl_productCode", db.conn);
            int randomId = Convert.ToInt32(objSqlCommand.ExecuteScalar());
            db.conn.Close();
            if (randomId > 0)
            {
                randomId = randomId + 1;
                randomCode = "PRCD0000" + (int)randomId;
            }
            else
            {
                randomCode = "PRCD00001";
            }
            return randomCode.ToString();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            txtproductcode.Text = CreateAutoID();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            pbl.productCode = txtproductcode.Text;
            pbl.product = cmbProductname.Text;

            bool success = pcdal.Insert(pbl);

            if (success == true)
            {
                MessageBox.Show("Productcode successfully create");
                Clear();

                DataTable dt = pcdal.Select();
                dgvProductCode.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed craete product successfully");
            }

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
