using LHMS_Application.BLL;
using LHMS_Application.Database;
using LHMS_Application.Models;
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
    internal class InventoryDal
    {
        DbConnection db = DbConnection.getInstance();
        #region Select Method all the data in Inventory table
        public DataTable Select()
        {
            DataTable dt = new DataTable();
            try
            {
                db.OpenCon();
                //string sql = "SELECT id,product_Id,Product_name,qty,added_date,modify_date FROM tbl_Inventory";
                string sql = "SELECT * FROM tbl_Inventory";
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
        #region Search data from using in Inventory table keywords
        public DataTable SearchData(string keywords)
        {
            DataTable dt = new DataTable();
            try
            {
                db.OpenCon(); ;
                String sql = "SELECT * FROM tbl_Inventory WHERE Product_Name LIKE '%" + keywords + "%'";
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
        #region Search data from using in Product table keywords
        public DataTable Search(string keywords)
        {
            DataTable dt = new DataTable();
            try
            {
                db.OpenCon(); ;
                String sql = "SELECT * FROM tbl_products WHERE Product_Name LIKE '%" + keywords + "%'";
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
        public DataTable IsExistProduct(int product_id)
        {
            DataTable dt = new DataTable();
            try
            {
                db.OpenCon(); ;
                String sql = "SELECT * FROM tbl_Inventory WHERE product_id = @product_id";
                SqlCommand cmd = new SqlCommand(sql, db.conn);
                cmd.Parameters.AddWithValue("@product_id", product_id);
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
        public int InsertData(InventoryModal lt)
        {

            db.OpenCon();
            try
            {

                string sql = 
                    "INSERT INTO tbl_Inventory " +
                    "( product_id, Product_name, qty, added_date )" +
                    "VALUES " +
                    "(@product_id, @Product_name, @qty, @added_date)";
                SqlCommand cmd = new SqlCommand(sql, db.conn);
                //cmd.Parameters.AddWithValue("@id", 0);
                cmd.Parameters.AddWithValue("@product_id", lt.product_Id);
                cmd.Parameters.AddWithValue("@Product_name", lt.Product_name);
                cmd.Parameters.AddWithValue("@qty", lt.qty);
                cmd.Parameters.AddWithValue("@added_date", DateTime.Now);

                return cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.CloseCon();
            }
            return 0;
        }
        public int GetProductCurrentQty(int productId)
        {
            int id = 0;
            try
            {
                db.OpenCon();
                SqlCommand objSqlCommand = new SqlCommand("SELECT qty FROM tbl_Inventory WHERE id = @id", db.conn);
                objSqlCommand.Parameters.AddWithValue("@id", productId);
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
        public int UpdateQtyData(int productId, int qty)
        {

            db.OpenCon();
            try
            {
                string sql = "UPDATE tbl_products SET Qty = @qty WHERE id = @id";
                SqlCommand cmd = new SqlCommand(sql, db.conn);
                cmd.Parameters.AddWithValue("@id", productId);
                cmd.Parameters.AddWithValue("@qty", qty);

                return cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.CloseCon();
            }
            return 0;
        }
        #region Modify the Current
        public bool Update(InventoryBll ib)
        {
            bool isSuccess = false;
            try
            {
                db.OpenCon();
                string sql = "UPDATE tbl_Inventory SET Qty = @qty, modify_date=@modify_date WHERE product_Id = @product_id";

                SqlCommand cmd = new SqlCommand(sql, db.conn);
                cmd.Parameters.AddWithValue("@product_id", ib.product_Id);
                cmd.Parameters.AddWithValue("@Product_name", ib.Product_name);
                cmd.Parameters.AddWithValue("@qty", ib.qty);
                cmd.Parameters.AddWithValue("@modify_date", DateTime.Now);
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
        public int updateinvqty(int productId, int qty)
        {

            db.OpenCon();
            try
            {
                string sql = "UPDATE tbl_Inventory  SET Qty = @qty WHERE id = @id";
                SqlCommand cmd = new SqlCommand(sql, db.conn);
                cmd.Parameters.AddWithValue("@id", productId);
                cmd.Parameters.AddWithValue("@qty", qty);

                return cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.CloseCon();
            }
            return 0;
        }
        #region inventory Report table
        public DataTable SelectData()
        {
            DataTable dt = new DataTable();
            try
            {
                db.OpenCon();
                string sql = "SELECT " +
                    "tbl_products.Category  AS 'Name of the Category', " +
                    "tbl_products.Category_code AS'Category Code', " +
                    "tbl_products.Product_Name AS'Name of the Product', " +
                    "tbl_products.Qty AS'Stand by Qty', " +
                    "tbl_Inventory.qty AS'Inventory Qty', " +
                    "tbl_UserD.username AS 'Person Who Add' " +
                    "FROM [LookHoodDB].[dbo].[tbl_products] " +
                    "LEFT join[LookHoodDB].[dbo].[tbl_Inventory]   on tbl_products.Product_Name = tbl_Inventory.Product_Name  " +
                    "LEFT JOIN [LookHoodDB].[dbo].[tbl_UserD] ON  tbl_products.added_by = tbl_UserD.id";
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


