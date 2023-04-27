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
    internal class rateDal
    {
        DbConnection db = DbConnection.getInstance();

        #region Insert Method
        public bool Insert(RateBll c)
        {
            bool isSuccess = false;
            try
            {
                db.OpenCon();
                string sql = "INSERT INTO tbl_rate " +
                    "(dealer_id, rate, added_date, added_by) " +
                    "VALUES" +
                    "(@dealer_id, @rate, @added_date, @added_by)";
                SqlCommand cmd = new SqlCommand(sql, db.conn);

                cmd.Parameters.AddWithValue("@dealer_id", c.dealer_id);
                cmd.Parameters.AddWithValue("@rate", c.rate);
                cmd.Parameters.AddWithValue("@added_date", c.added_date);
                cmd.Parameters.AddWithValue("@added_by", c.added_by);
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

            catch (SqlException ex)
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
        #region Select Method
        public DataTable Select()
        {

            DataTable dt = new DataTable();
            try
            {
                db.OpenCon();
                string sql = "SELECT * FROM tbl_rate";
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
        public bool Update(RateBll dc)
        {
            bool isSuccess = false;
            try
            {
                db.OpenCon();
                string sql = "UPDATE tbl_rate SET " +
                    "dealer_id=@dealer_id, rate=@rate, added_date=@added_date, added_by=@added_by " +
                    "WHERE id=@id";
                SqlCommand cmd = new SqlCommand(sql, db.conn);
                cmd.Parameters.AddWithValue("@dealer_id", dc.dealer_id);
                cmd.Parameters.AddWithValue("@rate", dc.rate);
                cmd.Parameters.AddWithValue("@added_date", dc.added_date);
                cmd.Parameters.AddWithValue("@added_by", dc.added_by);
                cmd.Parameters.AddWithValue("@id", dc.id);
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
        public DataTable Search(string keywords)
        {
            DataTable dt = new DataTable();
            try
            {
                db.OpenCon();
                String sql = "SELECT * FROM tbl_rate WHERE id LIKE '%" + keywords + "%'";
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

    }
}
