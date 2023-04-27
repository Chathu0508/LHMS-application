using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using DocumentFormat.OpenXml.Wordprocessing;
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
    public partial class FrmADCategorySub : Form
    {
        CatagorysubBll c = new CatagorysubBll();
        categoryDal cdal = new categoryDal();
        CatagorysubDal dal = new CatagorysubDal();
        userDal udal = new userDal(); 

        public FrmADCategorySub()
        {
            InitializeComponent();
        }

        private void FrmCategorySub_Load(object sender, EventArgs e)
        {
            DataTable categoriesDT = cdal.Select();
            cmbCategories.DataSource = categoriesDT;
            cmbCategories.DisplayMember = "title";
            cmbCategories.ValueMember = "title";

            DataTable dt = dal.Select();
            dgvsubcategory.DataSource = dt;

        }

        private void dgvsubcategory_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int RowIndex = e.RowIndex;
            txtid.Text = dgvsubcategory.Rows[RowIndex].Cells[0].Value.ToString();
            cmbCategories.Text = dgvsubcategory.Rows[RowIndex].Cells[1].Value.ToString();
            txtProdctname.Text = dgvsubcategory.Rows[RowIndex].Cells[2].Value.ToString();

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
                DataTable dt = dal.Select();
                dgvsubcategory.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Fail to create sub category.");
            }
        }

        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            c.id = int.Parse(txtid.Text);
            int getCategoryId = cdal.GetCategoryId(cmbCategories.SelectedValue.ToString());
            string cateid = FrmADCategory.categoryID;
            c.category_Id = getCategoryId;
            c.Product_name = txtProdctname.Text;
            c.added_date = DateTime.Now;
            string loggedUser = FrmLogin.LoggedIn;
            UserBll usr = udal.GetIDFromUsername(loggedUser);
            bool success = dal.Update(c);
            if (success == true)
            {
                MessageBox.Show("Categories are updated successfully");
                DataTable dt = dal.Select();
                dgvsubcategory.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Categories are failed to updated");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
