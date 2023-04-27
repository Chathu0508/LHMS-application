using LHMS_Application.BLL;
using LHMS_Application.Dal;
using LHMS_Application.Reports;
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

namespace LHMS_Application.Forms
{
    public partial class FrmADCategory : Form
    {
        public FrmADCategory()
        {
            InitializeComponent();
        }
        CategoryBll c = new CategoryBll();
        categoryDal dal = new categoryDal();
        userDal udal = new userDal();
        public static string categoryID;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            c.title = txtTitle.Text;
            c.description = txtdescription.Text;
            c.added_date = DateTime.Now;
            string loggedUser = FrmLogin.LoggedIn;
            UserBll usr = udal.GetIDFromUsername(loggedUser);
            c.added_by = usr.id;
            bool success = dal.Insert(c);
            if (success == true)
            {
                MessageBox.Show("New Category Inserted successfully.");
                clear();
                DataTable dt = dal.Select();
                dgvcategory.DataSource = dt;
            }
            else
            {
                MessageBox.Show("New Category Inserted Failed.");
            }
        }
        public void clear()
        {
            txtID.Text = "";
            txtTitle.Text = "";
            txtdescription.Text = "";
            txtsearch.Text = "";
        }
        private void FrmCategory_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dgvcategory.DataSource = dt;
        }
        private void dgvcategory_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int RowIndex = e.RowIndex;
            txtID.Text = dgvcategory.Rows[RowIndex].Cells[0].Value.ToString();
            txtTitle.Text = dgvcategory.Rows[RowIndex].Cells[1].Value.ToString();
            txtdescription.Text = dgvcategory.Rows[RowIndex].Cells[2].Value.ToString();
        }
        private void btnupdate_Click(object sender, EventArgs e)
        {

            c.id = int.Parse(txtID.Text);
            c.title = txtTitle.Text;
            c.description = txtdescription.Text;
            c.added_date = DateTime.Now;
            string loggedUser = FrmLogin.LoggedIn;
            UserBll usr = udal.GetIDFromUsername(loggedUser);
            c.added_by = usr.id;
            bool success = dal.Update(c);
            if (success == true)
            {
                MessageBox.Show("Categories are updated successfully");
                clear();

                DataTable dt = dal.Select();
                dgvcategory.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Categories are failed to updated");
            }

        }
        private void btnDelate_Click(object sender, EventArgs e)
        {
            c.id = int.Parse(txtID.Text);
            bool success = dal.Delete(c);
            if (success == true)
            {
                MessageBox.Show("This category is removed from the system.");
                clear();
                DataTable dt = dal.Select();
                dgvcategory.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Fail to remove the category. TRY Again.");
            }

        }
        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtsearch.Text;
            if (keywords != null)
            {
                DataTable dt = dal.Search(keywords);
                dgvcategory.DataSource = dt;
            }
            else
            {
                DataTable dt = dal.Select();
                dgvcategory.DataSource = dt;
            }

        }
    }
}

