using DocumentFormat.OpenXml.Bibliography;
using LHMS_Application.Dal;
using LHMS_Application.Models;
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
    public partial class FrmADInventoryD : Form
    {
        public FrmADInventoryD()
        {
            InitializeComponent();
        }
        productDal dal = new productDal();
        InventoryDal inv = new InventoryDal();
        private void btnsearch_Click(object sender, EventArgs e)
        {
            string keywords = txtsearch.Text;

            if (keywords != null && keywords != "")
            {
                DataTable dt = inv.Search(keywords);
                dgvinvtory.DataSource = dt;
                if (dgvinvtory.Rows.Count > 0)
                {
                    txtqty.Text = "0";
                    btnadde.Enabled = true;
                    txtqty.Enabled = true;
                    btnadde.Enabled = true;
                    btnsaveadd.Enabled = true;
                }
            }
            else
            {
                DataTable dt = dal.Select();
                dgvinvtory.DataSource = dt;
                btnadde.Enabled = false;
                txtProductId.Text = "";
                txtProductName.Text = "";
                txtqty.Text = "";
                txtqty.Enabled = false;
                btnsaveadd.Enabled = false;
                btnadde.Enabled = false;
                txtsearch.Text = "";
            }

        }
        private void btnreset_Click(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dgvinvtory.DataSource = dt;
            btnadde.Enabled = false;
            txtProductId.Text = "";
            txtProductName.Text = "";
            txtqty.Text = "";
            txtqty.Enabled = false;
            btnsaveadd.Enabled = false;
            btnadde.Enabled = false;
            txtsearch.Text = "";

        }
        private void btnadde_Click(object sender, EventArgs e)
        {
            if (dgvinvtory.Rows.Count > 0)
            {
                txtProductId.Text = dgvinvtory.Rows[0].Cells[0].Value.ToString();
                txtProductName.Text = dgvinvtory.Rows[0].Cells[3].Value.ToString();
                lblAvailableQty.Text = dgvinvtory.Rows[0].Cells[5].Value.ToString();
            }

        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtqty.Text != null && txtqty.Text != "" && txtqty.Text != "0")
            {
                if (Convert.ToInt16(lblAvailableQty.Text) >= Convert.ToInt16(txtqty.Text) && Convert.ToInt16(txtqty.Text) > 0)
                {
                    InventoryModal inventoryModal = new InventoryModal();

                    inventoryModal.product_Id = Convert.ToInt32(txtProductId.Text);
                    inventoryModal.qty = Convert.ToInt32(txtqty.Text);
                    inventoryModal.added_date = DateTime.Now;

                    var data = inv.InsertData(inventoryModal);
                    var qty = Convert.ToInt16(lblAvailableQty.Text) - Convert.ToInt32(txtqty.Text);
                    var update = inv.UpdateQtyData(Convert.ToInt32(txtProductId.Text), qty);

                    DataTable dt = dal.Select();
                    dgvinvtory.DataSource = dt;
                    lblAvailableQty.Text = "";
                    txtProductId.Text = "";
                    txtProductName.Text = "";
                    txtqty.Text = "";
                    btnadde.Enabled = false;
                    txtqty.Enabled = false;
                    btnadd.Enabled = false;
                    btnsaveadd.Enabled = false;

                    MessageBox.Show("Stock Transfer Successfully.");
                }
                else
                {
                    MessageBox.Show(Convert.ToInt16(lblAvailableQty.Text) > 0 ? "Please enter a valid quantity." : "Please update your current stock as your current stock is currently out of stock.");
                }
            }
            else
            {
                MessageBox.Show("Please enter value.");
            }
        }
        private void btnsaveadd_Click(object sender, EventArgs e)
        {
            if (txtqty.Text != null && txtqty.Text != "" && txtqty.Text != "0" && Convert.ToInt16(txtqty.Text) > 0)
            {
                var qty = Convert.ToInt16(lblAvailableQty.Text) + Convert.ToInt32(txtqty.Text);

                var update = inv.UpdateQtyData(Convert.ToInt32(txtProductId.Text), qty);
                DataTable dt = dal.Select();
                dgvinvtory.DataSource = dt;
                lblAvailableQty.Text = "";
                txtProductId.Text = "";
                txtProductName.Text = "";
                txtqty.Text = "";
                btnadde.Enabled = false;
                txtqty.Enabled = false;
                btnadd.Enabled = false;
                btnsaveadd.Enabled = false;
                MessageBox.Show("Stock Updated Successfully.");
            }
            else
            {
                MessageBox.Show("Please enter value.");
            }
        }
        private void FrmADInventoryD_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dgvinvtory.DataSource = dt;
            btnadde.Enabled = false;
            txtProductId.Enabled = false;
            txtProductName.Enabled = false;
            txtqty.Enabled = false;
            btnadd.Enabled = false;
            btnsaveadd.Enabled = false;

        }
    }
}
