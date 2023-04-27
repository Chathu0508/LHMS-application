using LHMS_Application.BLL;
using LHMS_Application.Dal;
using LHMS_Application.UI;
using System;
using System.Data;
using System.Windows.Forms;

namespace LHMS_Application.EMForms
{
    public partial class FrmCategory : Form
    {
        public FrmCategory()
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
        }

        private void FrmCategory_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dgvcategory.DataSource = dt;

        }
    }
}
