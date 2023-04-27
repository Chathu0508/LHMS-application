using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Wordprocessing;
using LHMS_Application.BLL;
using LHMS_Application.Dal;
using LHMS_Application.Forms;
using LHMS_Application.Froms;
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
    public partial class FrmADPurchase : Form
    {
        public FrmADPurchase()
        {
            InitializeComponent();
        }

        public void clear()
        {
        }
        TransactionBuyingBll tc = new TransactionBuyingBll();
        TransactionBuyingDal tdal = new TransactionBuyingDal();
        ProductCodeDal pcdal = new ProductCodeDal();
        categoryDal cdal = new categoryDal();
        userDal udal = new userDal();
        DealerDal Ddal = new DealerDal();
        rateDal rd = new rateDal();
        private void btnadd_Click(object sender, EventArgs e)
        {
            int getCategoryId = cdal.GetCategoryId(cmbCategory.SelectedValue.ToString());
            string cateid = FrmADCategory.categoryID;
            tc.Category = getCategoryId;
            tc.Category_code = txtcategoryCode.Text;
            tc.Product_Name = cmbproduct.Text;
            tc.Product_code = txtproductcode.Text;
            tc.qty = int.Parse(txtqty.Text);
            tc.dealer_name = cmbdealcus.Text;
            tc.rate = decimal.Parse(txtrate.Text);
            tc.total = decimal.Parse(txtrate.Text) * int.Parse(txtqty.Text);
            tc.Status = cmbstatus.Text;
            tc.added_date = DateTime.Now;
            string loggedUser = FrmLogin.LoggedIn;
            UserBll usr = udal.GetIDFromUsername(loggedUser);
            tc.added_by = usr.id;
            bool success = tdal.Insert(tc);
            if (success == true)
            {
                MessageBox.Show("Action is successful");
                DataTable dt = tdal.Select();
                dgvbuyer.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Something missing. try again");
            }

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

                DataTable cmbCat = cdal.getProductType(txtcategoryCode.Text);
                cmbproduct.DataSource = cmbCat;
                cmbproduct.DisplayMember = "Product_name";
                cmbproduct.ValueMember = "Product_name";

            }

        }
        private void cmbproduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            var getCategoryId = cdal.GetCategoryId(cmbCategory.SelectedValue.ToString());
            var getCode = cdal.GetSubCategoryCode(getCategoryId, cmbproduct.SelectedValue.ToString());

            txtproductcode.Text = getCode.ToString();

            var dds = cdal.GetProductCode(cmbproduct.SelectedValue.ToString());
            var dd = cdal.GetProductQty(dds.ToString());
            txtproductcode.Text = dds.ToString();
            txtqty.Text = dd.ToString();

        }
        private void FrmADPurchaseandsales_Load(object sender, EventArgs e)
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


            //DataTable Transbuydal = tdal.Select();
            //cmbproduct.DataSource = Transbuydal;
            //cmbproduct.DisplayMember = "";
            //cmbproduct.ValueMember = "";


            DataTable dt = tdal.Select();
            dgvbuyer.DataSource = dt;

            cmbproduct.Enabled = false;
            txtproductcode.Enabled = false;
            txtcategoryCode.Enabled = false;

            DataTable dealcusDT = Ddal.Select();
            cmbdealcus.DataSource = dealcusDT;
            cmbdealcus.DisplayMember = "name";
            cmbdealcus.ValueMember = "name";

        }
        private void dgvtranaction_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        }
        private void dgvtranaction_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int RowIndex = e.RowIndex;
            txtid.Text = dgvbuyer.Rows[RowIndex].Cells[0].Value.ToString();
            cmbCategory.Text = dgvbuyer.Rows[RowIndex].Cells[1].Value.ToString();
            txtcategoryCode.Text = dgvbuyer.Rows[RowIndex].Cells[2].Value.ToString();
            cmbproduct.Text = dgvbuyer.Rows[RowIndex].Cells[3].Value.ToString();
            txtproductcode.Text = dgvbuyer.Rows[RowIndex].Cells[4].Value.ToString();
            txtqty.Text = dgvbuyer.Rows[RowIndex].Cells[5].Value.ToString();
            cmbdealcus.Text = dgvbuyer.Rows[RowIndex].Cells[6].Value.ToString();
            txtrate.Text = dgvbuyer.Rows[RowIndex].Cells[7].Value.ToString();
            txttotle.Text = dgvbuyer.Rows[RowIndex].Cells[8].Value.ToString();
            cmbstatus.Text = dgvbuyer.Rows[RowIndex].Cells[9].Value.ToString();
        }

        private void txtcategoryCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtrate_TextChanged(object sender, EventArgs e)
        {
            var total = decimal.Parse(txtrate.Text) * int.Parse(txtqty.Text);
            txttotle.Text = total.ToString();
        }

        private void txtproductcode_TextChanged(object sender, EventArgs e)
        {
        }

        private void cmbdealcus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbdealcus.SelectedValue.ToString() != "" && (cmbdealcus.SelectedValue != null))
            {
                var getCode = Ddal.rateId(cmbdealcus.SelectedValue.ToString());
                if (getCode != null)
                {
                    cmbproduct.Enabled = true;
                }
                txtrate.Text = getCode.ToString();
                var total = Convert.ToInt32(txtqty.Text) * Convert.ToInt32(getCode.ToString());
                txttotle.Text = total.ToString();
            }
        }
        private void btnreset_Click(object sender, EventArgs e)
        {
            cmbCategory.Text = "";
            txtcategoryCode.Text = "";
            cmbproduct.Text = "";
            txtproductcode.Text = "";
            cmbdealcus.Text = "";
            txtrate.Text = "";
            txttotle.Text = "";
            cmbstatus.Text = "";

        }
        private void tbnrate_Click(object sender, EventArgs e)
        {
            FrmADrate rate = new FrmADrate();
            rate.Show();
        }
        private void btnsearch_Click(object sender, EventArgs e)
        {
            string keywords = txtid.Text;
            if (keywords != null && keywords != "")
            {
                DataTable dt =tdal.Search(keywords);
                dgvbuyer.DataSource = dt;
                if (dgvbuyer.Rows.Count > 0)
                {
                    cmbCategory.Text = dgvbuyer.Rows[0].Cells[1].Value.ToString();
                    txtcategoryCode.Text = dgvbuyer.Rows[0].Cells[2].Value.ToString();
                    cmbproduct.Text = dgvbuyer.Rows[0].Cells[3].Value.ToString();
                    txtproductcode.Text = dgvbuyer.Rows[0].Cells[4].Value.ToString();
                    txtqty.Text = dgvbuyer.Rows[0].Cells[5].Value.ToString();
                    cmbdealcus.Text = dgvbuyer.Rows[0].Cells[6].Value.ToString();
                    txtrate.Text = dgvbuyer.Rows[0].Cells[7].Value.ToString();
                    txttotle.Text = dgvbuyer.Rows[0].Cells[8].Value.ToString();
                    cmbstatus.Text = dgvbuyer.Rows[0].Cells[9].Value.ToString();
                }
            }
            else
            {
                DataTable dt = tdal.Select();
                dgvbuyer.DataSource = dt;
            }
       }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            tc.id = int.Parse(txtid.Text);
            int getCategoryId = cdal.GetCategoryId(cmbCategory.SelectedValue.ToString());
            string cateid = FrmADCategory.categoryID;
            tc.Category = getCategoryId;
            tc.Category_code = txtcategoryCode.Text;
            tc.Product_Name = cmbproduct.Text;
            tc.Product_code = txtproductcode.Text;
            tc.qty = int.Parse(txtqty.Text);
            tc.dealer_name = cmbdealcus.Text;
            tc.rate = decimal.Parse(txtrate.Text);
            tc.total = decimal.Parse(txtrate.Text) * int.Parse(txtqty.Text);
            tc.Status = cmbstatus.Text;
            tc.Modify_date= DateTime.Now;
            bool success = tdal.Update(tc);
            if (success == true)
            {
                MessageBox.Show("Action is successful");
                DataTable dt = tdal.Select();
                dgvbuyer.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Something missing. try again");
            }

        }

        private void txttotle_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
