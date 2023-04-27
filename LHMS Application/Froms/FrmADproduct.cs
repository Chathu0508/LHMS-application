using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Wordprocessing;
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

namespace LHMS_Application.Reports
{
    public partial class FrmADproduct : Form
    {
        public FrmADproduct()
        {
            InitializeComponent();
        }
        ProductCodeDal pcdal = new ProductCodeDal();
        ProducttypeDal ptdal = new ProducttypeDal();
        categoryDal cdal = new categoryDal();
        ProductBll p = new ProductBll();
        productDal dal = new productDal();
        userDal udal = new userDal();
        private void FrmADproduct_Load(object sender, EventArgs e)
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

            //var getCode = cdal.GetCategoryCode(cmbCategory.SelectedValue.ToString());
            //if (getCode != null)
            //{
            //    cmbproduct.Enabled = true;
            //}
            //txtcategoryCode.Text = getCode.ToString();

            //DataTable cmbCat = cdal.getProductType(txtcategoryCode.Text);
            //cmbproduct.DataSource = cmbCat;
            //cmbproduct.DisplayMember = "Product_name";
            //cmbproduct.ValueMember = "Product_name";


        }
        private void cmbproduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            var getCategoryId = cdal.GetCategoryId(cmbCategory.SelectedValue.ToString());
            var getCode = cdal.GetSubCategoryCode(getCategoryId, cmbproduct.SelectedValue.ToString());
            txtproductcode.Text = getCode.ToString();

            //var getCategoryId = cdal.GetCategoryId(cmbCategory.SelectedValue.ToString());
            //var getCode = cdal.GetSubCategoryCode(getCategoryId, cmbproduct.SelectedValue.ToString());

            //txtproductcode.Text = getCode.ToString();

            //var dds = cdal.GetProductCode(cmbproduct.SelectedValue.ToString());
            //var dd = cdal.GetProductQty(dds.ToString());
            //txtproductcode.Text = dds.ToString();
            //txtqty.Text = dd.ToString();



        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            p.Category = cmbCategory.Text;
            p.Category_code = txtcategoryCode.Text;
            p.Product_Name = cmbproduct.Text;
            p.Product_code = txtproductcode.Text;
            p.Qty = int.Parse(txtqty.Text);
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
        private void button1_Click(object sender, EventArgs e)
        {
            FrmADproductType pt = new FrmADproductType();
            pt.Show();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            p.id = int.Parse(txtId.Text);
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
            bool success = dal.Update(p);
            if (success == true)
            {
                MessageBox.Show("Product is successfully update");
                DataTable dt = dal.Select();
                dgvproduct.DataSource = dt;
            }
            else
            {
                MessageBox.Show("New product pdate is failed.");
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            p.id = Convert.ToInt32(txtId.Text);

            bool success = dal.Delete(p);
            if (success == true)
            {
                MessageBox.Show("This product is removed from the database.");
                DataTable dt = dal.Select();
                dgvproduct.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Fail to remove the product. TRY Again.");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmADProductCode pd = new FrmADProductCode();
            pd.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmADCategoryCode CD = new FrmADCategoryCode();
            CD.Show();
        }

        private void txtproductcode_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
