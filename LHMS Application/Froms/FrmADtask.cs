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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LHMS_Application.Reports
{
    public partial class FrmADtask : Form
    {
        TaskBLL t = new TaskBLL();
        TaskDal dal = new TaskDal();
        userDal udal = new userDal();
        codegenareate cg = new codegenareate();
        public FrmADtask()
        {
            InitializeComponent();
        }
        public void clear()
        {
            txtID.Text = "";
            txtCodegn.Text = "";
            txtTitle.Text = "";
            txtDiscription.Text = "";
            cmbFactory.Text = "";
            cmbDevepartment.Text = "";
        }
        private void btnAddtask_Click(object sender, EventArgs e)
        {
            t.taskcode = txtCodegn.Text;
            t.title = txtTitle.Text;
            t.description = txtDiscription.Text;
            t.factory = cmbFactory.Text;
            t.departments = cmbDevepartment.Text;
            t.Date = this.dtpDate.Text;
            t.added_date = DateTime.Now;
            string loggedUser = FrmLogin.LoggedIn;
            UserBll usr = udal.GetIDFromUsername(loggedUser);
            t.added_by = usr.id;
            bool success = dal.Insert(t);
            if (success == true)
            {
                MessageBox.Show("New task Inserted successfully.");
                clear();
                DataTable dt = dal.Select();
                dgvtask.DataSource = dt;
            }
            else
            {
                MessageBox.Show("New task Inserted Failed.");
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            t.Id = int.Parse(txtID.Text);
            bool success = dal.Delete(t);
            if (success == true)
            {
                MessageBox.Show("This Tasks is removed from the system.");
                clear();
                DataTable dt = dal.Select();
                dgvtask.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Fail to remove the Tasks. TRY Again.");
            }
        }
        private void dgvtasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void FrmtaskAD_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dgvtask.DataSource = dt;

            txtTitle.Enabled = false;
            txtDiscription.Enabled = false;
            cmbFactory.Enabled = false;
            cmbDevepartment.Enabled = false;
            
        }
        private void dgvtask_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtID.Text = dgvtask.Rows[rowIndex].Cells[00].Value.ToString();
            //txtCodegn.Text = dgvtask.Rows[rowIndex].Cells[01].Value.ToString();
            //txtTitle.Text = dgvtask.Rows[rowIndex].Cells[02].Value.ToString();
            //txtDiscription.Text = dgvtask.Rows[rowIndex].Cells[03].Value.ToString();
            //cmbFactory.Text = dgvtask.Rows[rowIndex].Cells[04].Value.ToString();
            //cmbDevepartment.Text = dgvtask.Rows[rowIndex].Cells[05].Value.ToString();
        }
        private void btnupdate_Click(object sender, EventArgs e)
        {
                t.Id = int.Parse(txtID.Text);
                t.taskcode = txtCodegn.Text;
                t.title = txtTitle.Text;
                t.description = txtDiscription.Text;
                t.factory = cmbFactory.Text;
                t.departments = cmbDevepartment.Text;
                t.added_date = DateTime.Now;
                string loggedUser = FrmLogin.LoggedIn;
                UserBll usr = udal.GetIDFromUsername(loggedUser);
                t.added_by = usr.id;
                bool success = dal.Update(t);
                if (success)
                {
                    MessageBox.Show("Tasks Successfully updated");
                    clear();
                }
                else
                {
                    MessageBox.Show("Falied to update Tasks");
                }
                DataTable dt = dal.Select();
                dgvtask.DataSource = dt;
        }

        DbConnection db = DbConnection.getInstance();
        public string CreateAutoID()
        {

            db.OpenCon();
            var randomCode = "";
            SqlCommand objSqlCommand = new SqlCommand("select count(*) from tbl_task", db.conn);
            int randomId = Convert.ToInt32(objSqlCommand.ExecuteScalar());

            db.conn.Close();
            if (randomId > 0)
            {
                randomId = randomId + 1;
                randomCode = "TSK000" + (int)randomId;
            }
            else
            {
                randomCode = "TSK00001";
            }
            return randomCode.ToString();
        }
        private void btnCodegen_Click(object sender, EventArgs e)
        {
            txtCodegn.Text = CreateAutoID();
            if (txtCodegn.Text != null && txtCodegn.Text != "")
            {
                txtTitle.Enabled = true;
                txtDiscription.Enabled = true;
                cmbFactory.Enabled = true;
                cmbDevepartment.Enabled = true;
            }
        }
        private void btnsearch_Click(object sender, EventArgs e)
        {
            string keywords = txtID.Text;
            if (keywords != null && keywords != "")
            {
                DataTable dt = dal.Search(keywords);
                dgvtask.DataSource = dt;
                if (dgvtask.Rows.Count > 0)
                {
                    txtCodegn.Text = dgvtask.Rows[0].Cells[1].Value.ToString();
                    txtTitle.Text = dgvtask.Rows[0].Cells[2].Value.ToString();
                    txtDiscription.Text = dgvtask.Rows[0].Cells[3].Value.ToString();
                    cmbFactory.Text = dgvtask.Rows[0].Cells[4].Value.ToString();
                    cmbDevepartment.Text = dgvtask.Rows[0].Cells[5].Value.ToString();
                    txtTitle.Enabled = true;
                    txtDiscription.Enabled = true;
                    cmbFactory.Enabled = true;
                    cmbDevepartment.Enabled = true;
                }
            }
            else
            {
                DataTable dt = dal.Select();
                dgvtask.DataSource = dt;
            }

        }
        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDapertment_Click(object sender, EventArgs e)
        {

        }

        private void cmbDevepartment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
