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

namespace LHMS_Application.EMForms
{
    public partial class FrmCategorySub : Form
    {
        public FrmCategorySub()
        {
            InitializeComponent();
        }
        CatagorysubBll c = new CatagorysubBll();
        categoryDal cdal = new categoryDal();
        CatagorysubDal dal = new CatagorysubDal();
        userDal udal = new userDal();


        private void FrmCategorySub_Load(object sender, EventArgs e)
        {
            DataTable categoriesDT = cdal.Select();
            cmbCategories.DataSource = categoriesDT;
            cmbCategories.DisplayMember = "title";
            cmbCategories.ValueMember = "title";

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            int getCategoryId = cdal.GetCategoryId(cmbCategories.SelectedValue.ToString());
            string cateid = FrmADCategory.categoryID;
            c.category_Id = getCategoryId;
            c.Product_name = txtProdctname.Text;
            c.added_date = DateTime.Now;
            string loggedUser = FrmLogin.LoggedIn;
            UserBll usr = udal.GetIDFromUsername(loggedUser);
            c.added_by = usr.id;
            bool success = dal.Insert(c);
            if (success == true)
            {
                MessageBox.Show("New sub category successfully created.");
            }
            else
            {
                MessageBox.Show("Fail to create sub category.");
            }

        }
    }
}
