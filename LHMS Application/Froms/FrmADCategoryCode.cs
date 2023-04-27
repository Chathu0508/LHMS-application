using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Vml.Office;
using LHMS_Application.BLL;
using LHMS_Application.Dal;
using LHMS_Application.Database;
using LHMS_Application.UI;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VBSQLHelper;
using DataTable = System.Data.DataTable;

namespace LHMS_Application.Reports
{
    public partial class FrmADCategoryCode : Form
    {
        CategoryCodeDal ccdal = new CategoryCodeDal();
        CategoryCodeBll cbl = new CategoryCodeBll();
        categoryDal cdal = new categoryDal();
        UserBll u = new UserBll();
        userDal dal = new userDal();


        public FrmADCategoryCode()
        {
            InitializeComponent();
        }
        DbConnection db = DbConnection.getInstance();

        private void FrmproductCode_Load(object sender, EventArgs e)
        {
            LoadData();
            DataTable categoriesDT = cdal.Select();
            cmbCategorypdc.DataSource = categoriesDT;
            cmbCategorypdc.DisplayMember = "title";
            cmbCategorypdc.ValueMember = "title";
            DataTable dt = ccdal.Select();
            dgvcategoryCode.DataSource = dt;
        }
        public void Clear()
        {
            txtcetagroycode.Text = "";
            cmbCategorypdc.Text = "";
        }


        public void LoadData()
        {
            db.OpenCon();
           
            SqlCommand objSqlCommand = new SqlCommand("select * from tbl_CategoryCode", db.conn);
            try
            {
              var  i = objSqlCommand.ExecuteNonQuery();
                dgvcategoryCode.DataSource = i;
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
            SqlCommand objSqlCommand = new SqlCommand("select count(*) from tbl_CategoryCode", db.conn);
            int randomId = Convert.ToInt32(objSqlCommand.ExecuteScalar());
         
            db.conn.Close();
            if(randomId > 0)
            {
                randomId = randomId + 1;
                randomCode = "PROCD0000" + (int) randomId;
            }
            else
            {
                randomCode = "PROCD00001";
            }
            return randomCode.ToString();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            txtcetagroycode.Text=CreateAutoID();
        }

        private void btnAddPCD_Click(object sender, EventArgs e)
        {
            cbl.CategoryCode = txtcetagroycode.Text;
            cbl.CateogryName = cmbCategorypdc.Text;
            cbl.added_date = DateTime.Now;
            string loggeduser = FrmLogin.LoggedIn;
            UserBll usr = dal.GetIDFromUsername(loggeduser);
            cbl.added_by = usr.id;
            bool success = ccdal.Insert(cbl);

            if (success == true)
            {
                MessageBox.Show("Category Code successfully created");
                Clear();

                DataTable dt = ccdal.Select();
                dgvcategoryCode.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed ctrate category code successfully");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcetagroycode_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbCategorypdc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
