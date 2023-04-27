using LHMS_Application.BLL;
using LHMS_Application.Dal;
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
    public partial class FrmProduct : Form
    {
        public FrmProduct()
        {
            InitializeComponent();
        }
        ProductCodeDal pcdal = new ProductCodeDal();
        ProducttypeDal ptdal = new ProducttypeDal();
        categoryDal cdal = new categoryDal();
        ProductBll p = new ProductBll();
        productDal dal = new productDal();
        userDal udal = new userDal();


        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            cmbCategory.Text = "";
            txtcategoryCode.Text = "";
            cmbproduct.Text = "";
            txtproductcode.Text = "";
            txtqty.Text = "";
            cmbqtytype.Text = "";
        }
        private void FrmProduct_Load(object sender, EventArgs e)
        {
            //load categery Names
            DataTable categoriesDT = cdal.Select();
            cmbCategory.DataSource = categoriesDT;
            cmbCategory.DisplayMember = "title";
            cmbCategory.ValueMember = "title";

            //load product name
            DataTable productDT = pcdal.Select();
            cmbproduct.DataSource = productDT;
            cmbproduct.DisplayMember = "product";
            cmbproduct.ValueMember = "product";

            //load producttype
            DataTable productPDT = ptdal.Select();
            cmbqtytype.DataSource = productPDT;
            cmbqtytype.DisplayMember = "product_type";
            cmbqtytype.ValueMember = "product_type";

            DataTable dt = dal.Select();
            dgvproduct.DataSource = dt;

            cmbproduct.Enabled = false;
            txtproductcode.Enabled = false;
            txtcategoryCode.Enabled = false;

        }


        private void dgvproduct_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtId.Text = dgvproduct.Rows[rowIndex].Cells[0].Value.ToString();
            cmbCategory.Text = dgvproduct.Rows[rowIndex].Cells[1].Value.ToString();
            txtcategoryCode.Text = dgvproduct.Rows[rowIndex].Cells[2].Value.ToString();
            cmbproduct.Text = dgvproduct.Rows[rowIndex].Cells[3].Value.ToString();
            txtproductcode.Text = dgvproduct.Rows[rowIndex].Cells[4].Value.ToString();
            txtqty.Text = dgvproduct.Rows[rowIndex].Cells[5].Value.ToString();
            cmbqtytype.Text = dgvproduct.Rows[rowIndex].Cells[6].Value.ToString();

        }


        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategory.SelectedValue.ToString() != "" && (cmbCategory.SelectedValue != null))
            {
                var getCode = cdal.GetCategoryCode(cmbCategory.SelectedValue.ToString());
                if (getCode != null)
                {
                    cmbproduct.Enabled = true;
                }
                txtcategoryCode.Text = getCode.ToString();
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            p.Category = cmbCategory.Text;
            p.Category_code = txtcategoryCode.Text;
            p.Product_Name = cmbproduct.Text;
            p.Product_code = txtproductcode.Text;
            p.Qty = Convert.ToInt32(txtqty.Text);
            p.Qty_type = cmbqtytype.Text;
            p.added_date = DateTime.Now;
            string loggedUser = FrmLogin.LoggedIn;
            UserBll usr = udal.GetIDFromUsername(loggedUser);
            p.added_by = usr.id;
            bool success = dal.Insert(p);
            if (success == true)
            {
                MessageBox.Show("Product is successfully insert");
                DataTable dt = dal.Select();
                dgvproduct.DataSource = dt;
            }
            else
            {
                MessageBox.Show("New Product Insert is Failed.");
            }
        }
        private void cmbproduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            var getCategoryId = cdal.GetCategoryId(cmbCategory.SelectedValue.ToString());
            var getCode = cdal.GetSubCategoryCode(getCategoryId, cmbproduct.SelectedValue.ToString());
            txtproductcode.Text = getCode.ToString();

        }
    }
}
