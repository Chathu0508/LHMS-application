using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LHMS_Application.BLL;
using LHMS_Application.Database;

namespace LHMS_Application.Dal
{
    internal class categoryDal
    {
        DbConnection db = DbConnection.getInstance();
        #region Select Method
        public DataTable Select()
        {
            DataTable dt = new DataTable();
            try
            {
                db.OpenCon();
                string sql = "SELECT * FROM tbl_Category";
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
        public string GetCategoryCode(string name)
        {
            var randomId = "";
            try
            {
                db.OpenCon();
              
                SqlCommand objSqlCommand = new SqlCommand("SELECT CategoryCode FROM tbl_Category LEFT JOIN tbl_CategoryCode ON  tbl_Category.title = tbl_CategoryCode.CateogryName WHERE tbl_Category.title = @title", db.conn);
                objSqlCommand.Parameters.AddWithValue("@title", name);
                 randomId = Convert.ToString(objSqlCommand.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.CloseCon();
            }
            return randomId.ToString();
        }

        public string GetSubCategoryCode(int id,string name)
        {
            var randomId = "";
            try
            {
                db.OpenCon();

                SqlCommand objSqlCommand = new SqlCommand("SELECT " +
                    "productCode FROM tbl_SubCategory " +
                    "LEFT JOIN tbl_productCode ON  tbl_SubCategory.Product_name = tbl_productCode.product WHERE tbl_SubCategory.category_Id = @id ", db.conn);
                objSqlCommand.Parameters.AddWithValue("@id", id);
                objSqlCommand.Parameters.AddWithValue("@Product_name", name);
                randomId = Convert.ToString(objSqlCommand.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.CloseCon();
            }
            return randomId.ToString();
        }
        public string GetProductCode(string name)
        {
            var randomId = "";
            try
            {
                db.OpenCon();
                SqlCommand objSqlCommand = new SqlCommand("SELECT Product_code FROM tbl_products WHERE  tbl_products.Product_Name =@Product_Name", db.conn);
                objSqlCommand.Parameters.AddWithValue("@Product_Name", name);
                randomId = Convert.ToString(objSqlCommand.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.CloseCon();
            }
            return randomId.ToString();
        }
        public int GetProductQty(string name)
        {
            int randomId = 0;
            try
            {
                db.OpenCon();

                SqlCommand objSqlCommand = new SqlCommand("SELECT Qty FROM tbl_products WHERE  tbl_products.Product_code =@Product_code", db.conn);
                objSqlCommand.Parameters.AddWithValue("@Product_code", name);
                randomId = Convert.ToInt32(objSqlCommand.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.CloseCon();
            }
            return randomId;
        }
        
        public DataTable getProductType(string name)
        {
          
            DataTable dt = new DataTable();
            try
            {
                db.OpenCon(); string sql = "SELECT tbl_SubCategory.Product_name FROM tbl_CategoryCode LEFT JOIN tbl_Category ON tbl_CategoryCode.CateogryName=  tbl_Category.title LEFT JOIN tbl_SubCategory ON tbl_Category.id = tbl_SubCategory.category_Id WHERE tbl_CategoryCode.CategoryCode ='"+name+"'";
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
        

        public int GetCategoryId(string name)
        {
            int id = 0;
            try
            {
                db.OpenCon();

                SqlCommand objSqlCommand = new SqlCommand("SELECT id FROM tbl_Category WHERE tbl_Category.title = @title", db.conn);
                objSqlCommand.Parameters.AddWithValue("@title", name);
                id = Convert.ToInt32(objSqlCommand.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.CloseCon();
            }
            return id;
        }

        #endregion
        #region Insert New Categories
        public bool Insert(CategoryBll c)
        {
            bool isSuccess = false;
            try
            {
                db.OpenCon();
                string sql = "INSERT INTO tbl_Category (title, description, added_date, added_by) VALUES(@title, @description, @added_date, @added_by)";
                SqlCommand cmd = new SqlCommand(sql, db.conn);
                cmd.Parameters.AddWithValue("@title", c.title);
                cmd.Parameters.AddWithValue("@description", c.description);
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
        #region Update method 
        public bool Update(CategoryBll c)
        {
            bool isSuccess = false;


            try
            {
                db.OpenCon();
                string sql = "UPDATE tbl_Category SET title=@title, description=@description, added_date=@added_date, added_by=@added_by WHERE id=@id";

                SqlCommand cmd = new SqlCommand(sql, db.conn);

                cmd.Parameters.AddWithValue("@title", c.title);
                cmd.Parameters.AddWithValue("@description", c.description);
                cmd.Parameters.AddWithValue("@added_date", c.added_date);
                cmd.Parameters.AddWithValue("@added_by", c.added_by);
                cmd.Parameters.AddWithValue("@id", c.id);


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
        public bool Delete(CategoryBll c)
        {
            bool isSuccess = false;
            try
            {
                db.OpenCon();
                string sql = "DELETE FROM tbl_Category WHERE id=@id";
                SqlCommand cmd = new SqlCommand(sql, db.conn);
                cmd.Parameters.AddWithValue("@id", c.id);
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
        #region Search data
        public DataTable Search(string keywords)
        {
            DataTable dt = new DataTable();
            try
            {
                db.OpenCon();
                String sql = "SELECT * FROM tbl_Category WHERE id LIKE '%" + keywords + "%' OR title LIKE '%" + keywords + "%' ";
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

    }
}
