using DocumentFormat.OpenXml.Bibliography;
using LHMS_Application.BLL;
using LHMS_Application.Dal;
using LHMS_Application.Forms;
using LHMS_Application.Reports;
using LHMS_Application.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace LHMS_Application.Froms
{
    public partial class FrmADrate : Form
    {
        RateBll rb = new RateBll();
        rateDal rd = new rateDal();
        DealerDal Ddal = new DealerDal();
        userDal udal = new userDal();

        public FrmADrate()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            int GetDealerID = Ddal.GetDealerID(cmbdealer.SelectedValue.ToString());
            string dealid = FrmADDelaer.Dealer_ID;
            rb.dealer_id = GetDealerID;
            rb.rate = decimal.Parse( txtRate.Text);
            rb.added_date = DateTime.Now;
            var loggedUser = "";
            if (File.Exists("setting.txt"))
            {
                using (StreamReader streamReader = new StreamReader("setting.txt"))
                {
                    loggedUser = streamReader.ReadLine();
                   
                }
            }
            rb.added_by = Convert.ToInt32(loggedUser);
            bool success = rd.Insert(rb);
            if (success == true)
            {
                MessageBox.Show("New rate successfully created.");
                DataTable dt = rd.Select();
                dgvrate.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Fail to rate .");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FrmADrate_Load(object sender, EventArgs e)
        {
            DataTable Deal = Ddal.Select();
            cmbdealer.DataSource = Deal;
            cmbdealer.DisplayMember = "name";
            cmbdealer.ValueMember = "name";

            DataTable dt = rd.Select();
            dgvrate.DataSource = dt;

        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            rb.id = int.Parse(txtid.Text);
            int GetDealerID = Ddal.GetDealerID(cmbdealer.SelectedValue.ToString());
            string dealid = FrmADDelaer.Dealer_ID;
            rb.dealer_id = GetDealerID;
            rb.rate = decimal.Parse(txtRate.Text);
            rb.added_date = DateTime.Now;
            var loggedUser = "";
            if (File.Exists("setting.txt"))
            {
                using (StreamReader streamReader = new StreamReader("setting.txt"))
                {
                    loggedUser = streamReader.ReadLine();

                }
            }
            rb.added_by = Convert.ToInt32(loggedUser);
            bool success = rd.Update(rb);
            if (success == true)
            {
                MessageBox.Show("New rate successfully created.");
                DataTable dt = rd.Select();
                dgvrate.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Fail to rate .");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string keywords = txtid.Text;

            if (keywords != null && keywords != "")
            {

                DataTable dt = rd.Search(keywords);
                dgvrate.DataSource = dt;
                txtid.Text = dgvrate.Rows[0].Cells[0].Value.ToString();
                cmbdealer.Text = dgvrate.Rows[0].Cells[1].Value.ToString();
                txtRate.Text = dgvrate.Rows[0].Cells[2].Value.ToString();
            }
            else
            {
                DataTable dt = Ddal.Select();
                dgvrate.DataSource = dt;
            }


        }
    }
}
