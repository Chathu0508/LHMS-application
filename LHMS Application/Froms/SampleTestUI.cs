using LHMS_Application.BLL;
using LHMS_Application.Dal;
using LHMS_Application.Database;
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
    public partial class SampleTestUI : Form
    {
        public SampleTestUI()
        {
            InitializeComponent();
        }

        private void SampleTestUI_Load(object sender, EventArgs e)
        {
            DbConnection db = DbConnection.getInstance();

            db.OpenCon();
            SqlCommand cmd = new SqlCommand("SELECT ", db.conn);
            SqlDataAdapter dr = new SqlDataAdapter();
            dr.SelectCommand = cmd;
            DataTable dt = new DataTable();
            dr.Fill(dt);

            dgvtask.DataSource = dt;
            dgvtask.Columns[0].HeaderText = "id";
            dgvtask.Columns[1].HeaderText = "title";
            dgvtask.Columns[2].HeaderText = "description";
            dgvtask.Columns[3].HeaderText = "factory";
            dgvtask.Columns[4].HeaderText = "numberofstages";
            dgvtask.Columns[5].HeaderText = "completesatges";
            dgvtask.Columns[6].HeaderText = "pendingsatges";


        }
    }
}
