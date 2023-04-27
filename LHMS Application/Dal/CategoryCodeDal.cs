using LHMS_Application.BLL;
using LHMS_Application.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LHMS_Application.Dal
{
    internal class CategoryCodeDal
    {
        DbConnection db = DbConnection.getInstance();

        #region Select Method .
        public DataTable Select()
        {

            DataTable dt = new DataTable();
            try
            {
                db.OpenCon();
                String sql = "SELECT * FROM tbl_CategoryCode";
                SqlCommand cmd = new SqlCommand(sql, db.conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.CloseCon();
            }
            return dt;
        }
        #endregion

        #region insert Method
        public bool Insert(CategoryCodeBll cbl)
        {
            bool isSuccess = false;
            try
            {
                db.OpenCon();
                String sql = "INSERT INTO  tbl_CategoryCode (CategoryCode, CateogryName,added_date,added_by) VALUES (@CategoryCode, @CateogryName, @added_date, @added_by)";
                SqlCommand cmd = new SqlCommand(sql, db.conn); 
                cmd.Parameters.AddWithValue("@CategoryCode", cbl.CategoryCode);
                cmd.Parameters.AddWithValue("@CateogryName", cbl.CateogryName);
                cmd.Parameters.AddWithValue("added_date", cbl.added_date);
                cmd.Parameters.AddWithValue("added_by", cbl.added_by);
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.CloseCon();
            }
            return isSuccess;
        }

        #endregion



    }
}
