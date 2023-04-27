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
    internal class ProducttypeDal
    {
        DbConnection db = DbConnection.getInstance();
        #region Select Method
        public DataTable Select()
        {
            DataTable dt = new DataTable();
            try
            {
                db.OpenCon();
                string sql = "SELECT * FROM tbl_productType";
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
        #region Insert Method
        public bool Insert(ProducttypeBll c)
        {
            bool isSuccess = false;
            try
            {
                db.OpenCon();
                string sql = "INSERT INTO tbl_productType (product_type, added_date, added_by) VALUES(@product_type, @added_date, @added_by)";
                SqlCommand cmd = new SqlCommand(sql, db.conn);
                //cmd.Parameters.AddWithValue("@category_Id", c.category_id);
                cmd.Parameters.AddWithValue("@product_type", c.product_type);
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
        #region Update Method
        public bool Update(CatagorysubBll c)
        {
            bool isSuccess = false;


            try
            {
                db.OpenCon();
                string sql = "UPDATE tbl_SubCategory SET category_Id=@category_Id, Product_name=@Product_name, added_date=@added_date, added_by=@added_by  WHERE id=@id";

                SqlCommand cmd = new SqlCommand(sql, db.conn);
                cmd.Parameters.AddWithValue("@id", c.id);
                cmd.Parameters.AddWithValue("@category_Id", c.category_Id);
                cmd.Parameters.AddWithValue("@Product_name", c.Product_name);
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

        public CatagorysubBll GETIDFromCategoryID(string title)
        {
            CatagorysubBll cb = new CatagorysubBll();
            DataTable dt = new DataTable();
            try
            {
                db.OpenCon();
                string sql = "SELECT id FROM tbl_Category WHERE title='" + title + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, db.conn);
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    cb.id = int.Parse(dt.Rows[1]["id"].ToString());
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
            return cb;
        }

    }

}
