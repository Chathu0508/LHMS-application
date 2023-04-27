using LHMS_Application.BLL;
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

namespace LHMS_Application.Reports
{
    public partial class FrmADInventory : Form
    {
        public FrmADInventory()
        {
            InitializeComponent();
        }
        productDal dal = new productDal();
        InventoryDal inv = new InventoryDal();
        InventoryBll ib = new InventoryBll();
        private void FrmADInventory_Load(object sender, EventArgs e)
        {
            DataTable et = inv.Select();
            dgvin.DataSource = et;
            DataTable dt = dal.Select();
            dgvinvtory.DataSource = dt;
            btnadde.Enabled = false;
            txtProductId.Enabled = false;
            txtProductName.Enabled = false;
            txtqty.Enabled = false;
            btnadd.Enabled = false;
            btnsaveadd.Enabled = false;
        }

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
                    btnadd.Enabled = true;
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
                btnadd.Enabled = false;
                txtsearch.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dgvinvtory.DataSource = dt;
            btnadde.Enabled = false;
            txtProductId.Text = "";
            txtProductName.Text = "";
            txtqty.Text = "";
            txtqty.Enabled = false;
            btnsaveadd.Enabled = false;
            btnadd.Enabled = false;
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
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtqty.Text != null && txtqty.Text != "" && txtqty.Text != "0")
            {
                if (Convert.ToInt16(lblAvailableQty.Text) >= Convert.ToInt16(txtqty.Text) && Convert.ToInt16(txtqty.Text) > 0)
                {
                    InventoryModal inventoryModal = new InventoryModal();

                    inventoryModal.product_Id = Convert.ToInt32(txtProductId.Text);
                    inventoryModal.Product_name=txtProductName.Text;
                    inventoryModal.qty = Convert.ToInt32(txtqty.Text);
                    inventoryModal.added_date = DateTime.Now;

                    var data = inv.InsertData(inventoryModal);
                    var qty = Convert.ToInt16(lblAvailableQty.Text) - Convert.ToInt32(txtqty.Text);
                    var update = inv.UpdateQtyData(Convert.ToInt32(txtProductId.Text), qty);

                    DataTable dt = dal.Select();
                    dgvinvtory.DataSource = dt;
                    DataTable et = inv.Select();
                    dgvin.DataSource = et;
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
            //if (txtqty.Text != null && txtqty.Text != "" && txtqty.Text != "0" && Convert.ToInt16(txtqty.Text) > 0)
            //{
            //    var qty = Convert.ToInt16(lblAvailableQty.Text) + Convert.ToInt32(txtqty.Text);

            //    var update = inv.UpdateQtyData(Convert.ToInt32(txtProductId.Text), qty);
            //    DataTable dt = dal.Select();
            //    dgvinvtory.DataSource = dt;
            //    lblAvailableQty.Text = "";
            //    txtProductId.Text = "";
            //    txtProductName.Text = "";
            //    txtqty.Text = "";
            //    btnadde.Enabled = false;
            //    txtqty.Enabled = false;
            //    btnadd.Enabled = false;
            //    btnsaveadd.Enabled = false;

            //    MessageBox.Show("Stock Updated Successfully.");

            //}
            //else
            //{
            //    MessageBox.Show("Please enter value.");
            //}

            if (txtqty.Text != null && txtqty.Text != "" && txtqty.Text != "0")
            {
                if (Convert.ToInt16(lblAvailableQty.Text) >= Convert.ToInt16(txtqty.Text) && Convert.ToInt16(txtqty.Text) > 0)
                {
                    InventoryBll inventoryModal = new InventoryBll();

                    var currentQty = inv.GetProductCurrentQty(Convert.ToInt32(txtProductId.Text));
                    ib.product_Id = Convert.ToInt32(txtProductId.Text);
                    ib.Product_name = txtProductName.Text;
                    var qty = (Convert.ToInt16(lblAvailableQty.Text) - Convert.ToInt32(txtqty.Text));
                    var update = inv.UpdateQtyData(Convert.ToInt32(txtProductId.Text), qty);
                    ib.qty = Convert.ToInt32(txtqty.Text);
                    ib.modify_date = DateTime.Now;
                    inventoryModal.product_Id = Convert.ToInt32(txtProductId.Text);
                    inventoryModal.Product_name = txtProductName.Text;
                   
                    int productQty = (Convert.ToInt16(currentQty) + Convert.ToInt32(txtqty.Text));
                    inventoryModal.qty = productQty;
                    inventoryModal.modify_date = DateTime.Now;
                    var data = inv.Update(inventoryModal);




                    DataTable dt = dal.Select();
                    dgvinvtory.DataSource = dt;
                    DataTable et = inv.Select();
                    dgvin.DataSource = et;
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

        private void btnexport_Click(object sender, EventArgs e)
        {

        }
    }
}

