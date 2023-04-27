using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Wordprocessing;
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
    internal class productDal
    {
        DbConnection db = DbConnection.getInstance();

        #region Select Method
        public DataTable Select()
        {
            DataTable dt = new DataTable();
            try
            {
                db.OpenCon();
                String sql = "SELECT * FROM tbl_products";
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
        #region Method to insert 

        public bool Insert(ProductBll p)
        {
            bool isSuccess = false;
            try
            {
                db.OpenCon();
                String sql = "INSERT INTO tbl_products (Category, Category_code, Product_Name, Product_code, Qty, Qty_type, added_date, added_by) VALUES (@Category, @Category_code, @Product_Name, @Product_code, @Qty, @Qty_type, @added_date, @added_by)";
                SqlCommand cmd = new SqlCommand(sql, db.conn);
                cmd.Parameters.AddWithValue("@Category", p.Category);
                cmd.Parameters.AddWithValue("@Category_code", p.Category_code);
                cmd.Parameters.AddWithValue("@Product_Name", p.Product_Name);
                cmd.Parameters.AddWithValue("@Product_code", p.Product_code);
                cmd.Parameters.AddWithValue("@Qty", p.Qty);
                cmd.Parameters.AddWithValue("@Qty_type", p.Qty_type);
                cmd.Parameters.AddWithValue("@added_date", p.added_date);
                cmd.Parameters.AddWithValue("@added_by", p.added_by);
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
        #region Update method 
        public bool Update(ProductBll p)
        {
            bool isSuccess = false;
            try
            {
                db.OpenCon();
                string sql = "UPDATE tbl_products SET Category=@Category, Category_code=@Category_code, Product_Name=@Product_Name, Product_code=@Product_code,Qty=@Qty, Qty_type=@Qty_type, added_date=@added_date, added_by=@added_by WHERE id=@id";
                SqlCommand cmd = new SqlCommand(sql, db.conn);
                cmd.Parameters.AddWithValue("@id", p.id);
                cmd.Parameters.AddWithValue("@Category", p.Category);
                cmd.Parameters.AddWithValue("@Category_code", p.Category_code);
                cmd.Parameters.AddWithValue("@Product_Name", p.Product_Name);
                cmd.Parameters.AddWithValue("@Product_code", p.Product_code);
                cmd.Parameters.AddWithValue("@Qty", p.Qty);
                cmd.Parameters.AddWithValue("@Qty_type", p.Qty_type);
                cmd.Parameters.AddWithValue("@added_date", p.added_date);
                cmd.Parameters.AddWithValue("@added_by", p.added_by);
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
        #region Delete Categories
        public bool Delete(ProductBll p)
        {
            bool isSuccess = false;
            try
            {
                db.OpenCon();
                string sql = "DELETE FROM tbl_products WHERE id=@id";
                SqlCommand cmd = new SqlCommand(sql, db.conn);
                cmd.Parameters.AddWithValue("@id", p.id);
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
        #region Get the Product id
        public ProductBll GETIDFromProductID(string name)
        {
            ProductBll cb = new ProductBll();
            DataTable dt = new DataTable();
            try
            {
                db.OpenCon();
                string sql = "SELECT id FROM tbl_products WHERE Product_Name='" + name + "'";
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
        #endregion

    }
}
