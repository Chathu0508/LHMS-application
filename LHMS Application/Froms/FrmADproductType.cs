using DocumentFormat.OpenXml.Bibliography;
using LHMS_Application.BLL;
using LHMS_Application.Dal;
using LHMS_Application.Forms;
using LHMS_Application.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LHMS_Application.Reports
{
    public partial class FrmADproductType : Form
    {
        categoryDal cdal = new categoryDal();
        ProducttypeDal dal = new ProducttypeDal();
        ProducttypeBll p = new ProducttypeBll();
        userDal udal = new userDal();
        public FrmADproductType()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            //int getCategoryId = cdal.GetCategoryId(cmbcategory.SelectedValue.ToString());
            //string cateid = FrmADCategory.categoryID;
            ////CatagorysubBll cb = dal.GETIDFromCategoryID(cateid);
            //p.category_id = getCategoryId;
            p.product_type = txtproducttype.Text;
            p.added_date = DateTime.Now;
            string loggedUser = FrmLogin.LoggedIn;
            UserBll usr = udal.GetIDFromUsername(loggedUser);
            p.added_by = usr.id;
            bool success = dal.Insert(p);
            if (success == true)
            {
                MessageBox.Show("New sub category successfully created.");
                DataTable dt = dal.Select();
                dgvProtucttype.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Fail to create sub category.");
            }

        }

        private void FrmADproductType_Load(object sender, EventArgs e)
        {


            DataTable dt = dal.Select();
            dgvProtucttype.DataSource = dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {

        }
    }
}
