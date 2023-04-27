using LHMS_Application.BLL;
using LHMS_Application.Dal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LHMS_Application.Froms
{
    public partial class FrmADSales : Form
    {
        public FrmADSales()
        {
            InitializeComponent();
        }
        TransactionSaleingBll tc = new TransactionSaleingBll();
        TransactionSaleingDal tdal = new TransactionSaleingDal();
        ProductCodeDal pcdal = new ProductCodeDal();
        categoryDal cdal = new categoryDal();
        userDal udal = new userDal();
        customerDal Ddal = new customerDal();

        private void FrmADSales_Load(object sender, EventArgs e)
        {
            DataTable categoriesDT = cdal.Select();
            cmbCategory.DataSource = categoriesDT;
            cmbCategory.DisplayMember = "title";
            cmbCategory.ValueMember = "title";

            //load product name
            DataTable productDT = pcdal.Select();
            cmbproduct.DataSource = productDT;
            cmbproduct.DisplayMember = "product";
            cmbproduct.ValueMember = "product";


        }
    }
}
