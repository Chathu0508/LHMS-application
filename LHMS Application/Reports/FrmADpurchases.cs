using LHMS_Application.BLL;
using LHMS_Application.Dal;
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

namespace LHMS_Application.Reports
{
    public partial class FrmADpurchases : Form
    {
        TransactionBuyingDal BuyDal = new TransactionBuyingDal();
        TransactionBuyingBll BuyBll = new TransactionBuyingBll();
 
        public FrmADpurchases()
        {
            InitializeComponent();
        }
        private void btnexport_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = "Response.xls";
                savefile.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
                if (dgvlogtrack.Rows.Count > 0)
                {
                    if (savefile.ShowDialog() == DialogResult.OK)
                    {

                        StreamWriter wr = new StreamWriter(savefile.FileName);
                        for (int i = 0; i < dgvlogtrack.Columns.Count; i++)
                        {
                            wr.Write(dgvlogtrack.Columns[i].Name.ToString().ToUpper() + "\t");
                        }

                        wr.WriteLine();

                        //write rows to excel file
                        for (int i = 0; i < (dgvlogtrack.Rows.Count); i++)
                        {
                            for (int j = 0; j < dgvlogtrack.Columns.Count; j++)
                            {
                                if (dgvlogtrack.Rows[i].Cells[j].Value != null)
                                {
                                    wr.Write(Convert.ToString(dgvlogtrack.Rows[i].Cells[j].Value.ToString()) + "\t");
                                }
                                else
                                {
                                    wr.Write("\t");
                                }
                            }
                            //go to next line
                            wr.WriteLine();
                        }
                        //close file
                        wr.Close();
                        MessageBox.Show(this, "Data saved in Excel format at location " + savefile.FileName, "Successfully Saved", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                }
                else
                {
                    MessageBox.Show(this, "Zero record to export , perform a operation first", "Can't export file", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

            }

        }

        private void FrmADpurchases_Load(object sender, EventArgs e)
        {


        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            DataTable dt = BuyDal.SelectData();
            dgvlogtrack.DataSource = dt;
        }
    }
}
