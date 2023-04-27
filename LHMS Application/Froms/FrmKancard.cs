using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Office.CoverPageProps;
using DocumentFormat.OpenXml.Wordprocessing;
using LHMS_Application.BLL;
using LHMS_Application.Dal;
using LHMS_Application.Database;
using LHMS_Application.Models;
using LHMS_Application.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LHMS_Application.Froms
{
    public partial class FrmKancard : Form
    {
        public FrmKancard()
        {
            InitializeComponent();
        }

        TaskDal tdal = new TaskDal();
        KencardDal kdal = new KencardDal();
        KencardBll ken = new KencardBll();
        InventoryDal inv = new InventoryDal();
        InventoryModal idal = new InventoryModal();

        userDal udal = new userDal();

        DbConnection db = DbConnection.getInstance();
        public string CreateAutoID()
        {

            db.OpenCon();
            var randomCode = "";
            SqlCommand objSqlCommand = new SqlCommand("select count(*) from tbl_KenCD", db.conn);
            int randomId = Convert.ToInt32(objSqlCommand.ExecuteScalar());

            db.conn.Close();
            if (randomId > 0)
            {
                randomId = randomId + 1;
                randomCode = "KCARD000" + (int)randomId;
            }
            else
            {
                randomCode = "KCARD0001";
            }
            return randomCode.ToString();
        }
        private void btnkancode_Click(object sender, EventArgs e)
        {
            txtkencode.Text = CreateAutoID();
            if (txtkencode.Text != null && txtkencode.Text != "")
            {
                txtsearch.Enabled = true;
                txtRawMetID.Enabled = true;
                txtProductName.Enabled = true;
                txtqty.Enabled = true;
                btncreatecard.Enabled = true;
            }
            else
            {
                txtsearch.Enabled = false;
                txtRawMetID.Enabled = false;
                txtProductName.Enabled = false;
                txtqty.Enabled = false;
                btncreatecard.Enabled = false;
            }

        }
        private void FrmKancard_Load(object sender, EventArgs e)
        {
            //load the Task Code and the title of the task
            DataTable TaskPDT = tdal.Select();
            cmbcode.DataSource = TaskPDT;
            cmbcode.DisplayMember = "taskcode";
            cmbcode.ValueMember = "taskcode";

            DataTable drt = tdal.Select();
            dgvtask.DataSource = drt;

            DataTable dtr = kdal.Select();
            dgvkencard.DataSource = dtr;

            DataTable dt = inv.Select();
            dgvinvtory.DataSource = dt;

            //cmbcode.Enabled = false;
            txtsearch.Enabled = false;
            txtRawMetID.Enabled = false;
            txtProductName.Enabled = false;
            txtqty.Enabled = false;
            btncreatecard.Enabled = false;
        }
        private void btnsearch_Click_1(object sender, EventArgs e)
        {
            string keywords = txtsearch.Text;

            if (keywords != null && keywords != "")
            {

                DataTable dt = inv.SearchData(keywords);
                dgvinvtory.DataSource = dt;
                txtRawMetID.Text = dgvinvtory.Rows[0].Cells[1].Value.ToString();
                txtProductName.Text = dgvinvtory.Rows[0].Cells[2].Value.ToString();
                lblAvailableQty.Text = dgvinvtory.Rows[0].Cells[3].Value.ToString();


            }
            else
            {
                DataTable dt = inv.Select();
                dgvinvtory.DataSource = dt;
            }

        }
        private void btnrest_Click(object sender, EventArgs e)
        {
            cmbcode.Text = "";
            txttaskname.Text = "";
            txtkencode.Text = "";
            txtsearch.Text = "";
            txtRawMetID.Text = "";
            txtProductName.Text = "";
            txtqty.Text = "";
        }
        private void btncreatecard_Click(object sender, EventArgs e)
        {
            if (txtqty.Text != null && txtqty.Text != "" && txtqty.Text != "0")
            {
                if (Convert.ToInt16(lblAvailableQty.Text) >= Convert.ToInt16(txtqty.Text) && Convert.ToInt16(txtqty.Text) > 0)
                {
                    Kencardmodel kencard = new Kencardmodel();
                    kencard.Taskcode = cmbcode.Text;
                    kencard.Task_name = txttaskname.Text;
                    kencard.ken_code = txtkencode.Text;
                    kencard.Raw_metrial_Id = Convert.ToInt32(txtRawMetID.Text);
                    kencard.Raw_metrial_name = txtProductName.Text;
                    kencard.Raw_Metrials_Qty = Convert.ToInt32(txtqty.Text);
                    kencard.status = cmbstatus.Text;
                    kencard.added_date = DateTime.Now;
                    var loggedUser = "";
                    if (File.Exists("setting.txt"))
                    {
                        using (StreamReader streamReader = new StreamReader("setting.txt"))
                        {
                            loggedUser = streamReader.ReadLine();

                        }
                    }
                    kencard.added_by = Convert.ToInt32(loggedUser);
                    var data = kdal.InsertData(kencard);
                    var qty = Convert.ToInt16(lblAvailableQty.Text) - Convert.ToInt32(txtqty.Text);
                    var update = inv.updateinvqty(Convert.ToInt32(txtRawMetID.Text), qty);
                    MessageBox.Show("Stock Transfer Successfully.");
                    DataTable dtr = kdal.Select();
                    dgvkencard.DataSource = dtr;

                    DataTable dt = inv.Select();
                    dgvinvtory.DataSource = dt;


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
        private void cmbcode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbcode.SelectedValue.ToString() != "" && (cmbcode.SelectedValue != null))
            {
                var getCode = tdal.GetTaskcode(cmbcode.SelectedValue.ToString());
                if (getCode != null)
                {
                    cmbcode.Enabled = true;
                }
                txttaskname.Text = getCode.ToString();
            }
        }
        private void dpdate_ValueChanged(object sender, EventArgs e)
        {
        }

        private void txtkencode_TextChanged(object sender, EventArgs e)
        {
        }

        private void dgvinvtory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvinvtory_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtsearch.Text = dgvinvtory.Rows[rowIndex].Cells[2].Value.ToString();
        }
        private void btnmodify_Click(object sender, EventArgs e)
        {
            ken.id = int.Parse(txtid.Text);
            ken.Taskcode = cmbcode.Text;
            ken.Task_name=txttaskname.Text;
            ken.ken_code = txtkencode.Text;
            ken.Raw_metrial_Id = Convert.ToInt32 (txtRawMetID.Text);
            ken.Raw_metrial_name = txtProductName.Text;
            ken.Raw_Metrials_Qty = Convert.ToInt32 (txtqty.Text);
            ken.status = cmbstatus.Text;
            ken.Modify_date = DateTime.Now;
            bool success = kdal.updatedata(ken);
            if (success)
            {
                MessageBox.Show("Tasks Successfully updated");
                DataTable dtr = kdal.Select();
                dgvkencard.DataSource = dtr;

                DataTable dt = inv.Select();
                dgvinvtory.DataSource = dt;

            }
            else
            {
                MessageBox.Show("Falied to update Tasks");
            }
        }
        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            //if (dateTimePicker1.SelectedValue.ToString() != "" && (dateTimePicker1.SelectedValue != null))
            //{
            //    var getCode = tdal.GetCurrentDayData(cmbcode.SelectedValue.ToString());
            //    if (cmbcode.SelectedValue.ToString() != "" && (cmbcode.SelectedValue != null))
            //    {
            //        var gettask = tdal.GetTaskcode(cmbcode.SelectedValue.ToString());
            //        if (getCode != null)
            //        {
            //            cmbcode.Enabled = true;
            //        }
            //        txttaskname.Text = getCode.ToString();
            //    }
            //}

        }
        private void btnsearchken_Click(object sender, EventArgs e)
        {
            string keywords = txtid.Text;
            if (keywords != null && keywords != "")
            {
                DataTable dt = kdal.searchDate(keywords);
                dgvkencard.DataSource = dt;
                if (dgvkencard.Rows.Count > 0)
                {
                    cmbcode.Text = dgvkencard.Rows[0].Cells[1].Value.ToString();
                    txttaskname.Text = dgvkencard.Rows[0].Cells[2].Value.ToString();
                    txtkencode.Text = dgvkencard.Rows[0].Cells[3].Value.ToString();
                    txtRawMetID.Text = dgvkencard.Rows[0].Cells[4].Value.ToString();
                    txtProductName.Text = dgvkencard.Rows[0].Cells[5].Value.ToString();
                    txtqty.Text = dgvkencard.Rows[0].Cells[6].Value.ToString();
                }
            }
            else
            {
                DataTable dt = kdal.Select();
                dgvkencard.DataSource = dt;

                DataTable dte = inv.Select();
                dgvinvtory.DataSource = dte;

            }

        }

        private void dgvkencard_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtid.Text = dgvkencard.Rows[rowIndex].Cells[0].Value.ToString();
            cmbcode.Text = dgvkencard.Rows[rowIndex].Cells[1].Value.ToString();
            txttaskname.Text = dgvkencard.Rows[rowIndex].Cells[2].Value.ToString();
            txtkencode.Text = dgvkencard.Rows[rowIndex].Cells[3].Value.ToString();
            txtRawMetID.Text = dgvkencard.Rows[rowIndex].Cells[4].Value.ToString();
            txtProductName.Text = dgvkencard.Rows[rowIndex].Cells[5].Value.ToString();
            txtqty.Text = dgvkencard.Rows[rowIndex].Cells[6].Value.ToString();

        }
    }
}
