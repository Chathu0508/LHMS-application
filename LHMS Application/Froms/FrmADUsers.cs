using LHMS_Application.BLL;
using LHMS_Application.Dal;
using LHMS_Application.UI;
using LHMS_Application.Validation;
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
    public partial class FrmADUsers : Form
    {
        public FrmADUsers()
        {
            InitializeComponent();
            //LoadTheme();
        }
        UserBll u = new UserBll();
        userDal dal = new userDal();
        Validationf val_d = new Validationf();



        private bool Validation()
        {
            bool isEmpty = false;
            if (!String.IsNullOrWhiteSpace(txtFirstName.Text) && !String.IsNullOrWhiteSpace(txtLastName.Text) && !String.IsNullOrWhiteSpace(txtEmail.Text) && !String.IsNullOrWhiteSpace(txtUsername.Text) && !String.IsNullOrWhiteSpace(txtPassword.Text) && !String.IsNullOrWhiteSpace(txtContact.Text) && !String.IsNullOrWhiteSpace(txtAddress.Text) && !String.IsNullOrWhiteSpace(cmbGender.Text) && !String.IsNullOrWhiteSpace(cmbUserType.Text) && !String.IsNullOrWhiteSpace(cmbdepartment.Text) && !String.IsNullOrWhiteSpace(cmbFactory.Text))
            {
                isEmpty = true;
            }

            return isEmpty;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool isEmpty = Validation();
            if (isEmpty)
            {
                u.firstname = txtFirstName.Text;
                u.lastname = txtLastName.Text;
                u.email = txtEmail.Text;
                u.username = txtUsername.Text;
                u.password = txtPassword.Text;
                u.contact = txtContact.Text;
                u.address = txtAddress.Text;
                u.gender = cmbGender.Text;
                u.user_type = cmbUserType.Text;
                u.department = cmbdepartment.Text;
                u.Factory = cmbFactory.Text;
                u.added_Date = DateTime.Now;

                //get the username of the user
                string loggeduser = FrmLogin.LoggedIn;
                UserBll usr = dal.GetIDFromUsername(loggeduser);

                u.added_by = usr.id;

                //Insert in to Database. 
                bool success = dal.Insert(u);

                //if the data is Successfully inserted them the value of success will be true else it will  be fales. 
                if (success)
                {
                    //Data successfully Insert 
                    MessageBox.Show("Successfully create a user");
                    clear();
                }
                else
                {
                    //Data didnot insert Successfully.
                    MessageBox.Show("Fail to create the user");
                }
                //Refreshing Data Grid View.
                DataTable dt = dal.Select();
                dgvUsers.DataSource = dt;
            }

            else
            {
                MessageBox.Show("Please Insert all the deatils");
            }
        }


        public void clear()
        {
            txtID.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtContact.Text = "";
            txtAddress.Text = "";
            cmbGender.Text = "";
            cmbUserType.Text = "";
            cmbdepartment.Text = "";
            cmbFactory.Text = "";
        }

        // to load the users in the data grid.
        private void FrmUsers_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dgvUsers.DataSource = dt;

        }

        // to load the users in the data grid and select from it.
        private void dgvUsers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtID.Text = dgvUsers.Rows[rowIndex].Cells[00].Value.ToString();
            txtFirstName.Text = dgvUsers.Rows[rowIndex].Cells[01].Value.ToString();
            txtLastName.Text = dgvUsers.Rows[rowIndex].Cells[02].Value.ToString();
            txtEmail.Text = dgvUsers.Rows[rowIndex].Cells[03].Value.ToString();
            txtUsername.Text = dgvUsers.Rows[rowIndex].Cells[04].Value.ToString();
            txtPassword.Text = dgvUsers.Rows[rowIndex].Cells[05].Value.ToString();
            txtContact.Text = dgvUsers.Rows[rowIndex].Cells[06].Value.ToString();
            txtAddress.Text = dgvUsers.Rows[rowIndex].Cells[07].Value.ToString();
            cmbGender.Text = dgvUsers.Rows[rowIndex].Cells[08].Value.ToString();
            cmbUserType.Text = dgvUsers.Rows[rowIndex].Cells[09].Value.ToString();
            cmbdepartment.Text = dgvUsers.Rows[rowIndex].Cells[10].Value.ToString();
            cmbFactory.Text = dgvUsers.Rows[rowIndex].Cells[11].Value.ToString();

        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            u.id = Convert.ToInt32(txtID.Text);

            u.firstname = txtFirstName.Text;
            u.lastname = txtLastName.Text;
            u.email = txtEmail.Text;
            u.username = txtUsername.Text;
            u.password = txtPassword.Text;
            u.contact = txtContact.Text;
            u.address = txtAddress.Text;
            u.gender = cmbGender.Text;
            u.user_type = cmbUserType.Text;
            u.department = cmbdepartment.Text;
            u.Factory = cmbFactory.Text;
            u.added_Date = DateTime.Now;

            string loggeduser = FrmLogin.LoggedIn;
            UserBll usr = dal.GetIDFromUsername(loggeduser);

            u.added_by = usr.id;

            //updat database
            bool success = dal.Update(u);

            //if the data is updated successfully then the value of success will be ture else it will be falses
            if (success)
            {
                //data update Successfully 
                MessageBox.Show("User Successfully updated");
                clear();
            }
            else
            {
                MessageBox.Show("Falied to update User");
            }
            //Refreshing Data Grid View.
            DataTable dt = dal.Select();
            dgvUsers.DataSource = dt;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            u.id = Convert.ToInt32(txtID.Text);

            bool success = dal.Delete(u);

            //if data is delete then the value of success will be ture else it will be false 
            if (success)
            {
                MessageBox.Show("User deleted successfully");
            }
            else
            {
                MessageBox.Show("Fail to detele thw user");
            }
            DataTable dt = dal.Select();
            dgvUsers.DataSource = dt;

        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            string keywords = txtSearch.Text;

            if (keywords != null)
            {
                DataTable dt = dal.Search(keywords);
                dgvUsers.DataSource = dt;
            }
            else
            {
                DataTable dt = dal.Select();
                dgvUsers.DataSource = dt;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keywords = txtSearch.Text;
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
