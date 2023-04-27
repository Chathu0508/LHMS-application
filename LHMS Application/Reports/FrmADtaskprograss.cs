using DocumentFormat.OpenXml.Bibliography;
using LHMS_Application.BLL;
using LHMS_Application.Dal;
using LHMS_Application.Database;
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

namespace LHMS_Application.Reports
{
    public partial class FrmADtaskprograss : Form
    {
        TaskDal task
            = new TaskDal();
        KencardDal ken = new KencardDal();
        public FrmADtaskprograss()
        {
            InitializeComponent();
        }

        private void Frmtaskprograss_Load(object sender, EventArgs e)
        {

        }


        private void btnexport_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = "Response.xls";
                savefile.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
                if (Dgvtaskprogress.Rows.Count > 0)
                {
                    if (savefile.ShowDialog() == DialogResult.OK)
                    {

                        StreamWriter wr = new StreamWriter(savefile.FileName);
                        for (int i = 0; i < Dgvtaskprogress.Columns.Count; i++)
                        {
                            wr.Write(Dgvtaskprogress.Columns[i].Name.ToString().ToUpper() + "\t");
                        }

                        wr.WriteLine();

                        //write rows to excel file
                        for (int i = 0; i < (Dgvtaskprogress.Rows.Count); i++)
                        {
                            for (int j = 0; j < Dgvtaskprogress.Columns.Count; j++)
                            {
                                if (Dgvtaskprogress.Rows[i].Cells[j].Value != null)
                                {
                                    wr.Write(Convert.ToString(Dgvtaskprogress.Rows[i].Cells[j].Value.ToString()) + "\t");
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

        private void btnImport_Click(object sender, EventArgs e)
        {
            DataTable dt = task.Seletereportdata();
            Dgvtaskprogress.DataSource = dt;

        }
    }
}
