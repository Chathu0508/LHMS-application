using LHMS_Application.BLL;
using LHMS_Application.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LHMS_Application.Dal
{
    internal class TransactionBuyingDal
    {
        DbConnection db = DbConnection.getInstance();
        #region Select Method
        public DataTable Select()
        {
            DataTable dt = new DataTable();
            try
            {
                db.OpenCon();
                string sql = "SELECT * FROM tbl_Buying";
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

        public bool Insert(TransactionBuyingBll c)
        {
            bool isSuccess = false;
            try
            {
                db.OpenCon();
                string sql = "INSERT INTO tbl_Buying " +
                    "(Category, Category_code, Product_Name, Product_code, qty, dealer_name, rate, total, Status, added_date, added_by) " +
                    "VALUES" +
                    "(@Category, @Category_code, @Product_Name, @Product_code, @qty, @dealer_name, @rate, @total, @Status, @added_date, @added_by)";
                SqlCommand cmd = new SqlCommand(sql, db.conn);
                cmd.Parameters.AddWithValue("@Category", c.Category);
                cmd.Parameters.AddWithValue("@Category_code", c.Category_code);
                cmd.Parameters.AddWithValue("@Product_Name", c.Product_Name);
                cmd.Parameters.AddWithValue("@Product_code", c.Product_code);
                cmd.Parameters.AddWithValue("@qty", c.qty);
                cmd.Parameters.AddWithValue("@dealer_name", c.dealer_name);
                cmd.Parameters.AddWithValue("@rate", c.rate);
                cmd.Parameters.AddWithValue("@total", c.total);
                cmd.Parameters.AddWithValue("@Status", c.Status);
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
        public bool Update(TransactionBuyingBll c)
        {
            bool isSuccess = false;
            try
            {
                db.OpenCon();
                string sql = "UPDATE  tbl_Buying SET " +
                    "Category=@Category, Category_code=@Category_code, Product_Name=@Product_Name, Product_code=@Product_code,qty =@qty, dealer_name=@dealer_name, rate=@rate, total=@total, Status=@Status, Modify_date=@Modify_date " +
                    "WHERE id=@id";
                SqlCommand cmd = new SqlCommand(sql, db.conn);
                cmd.Parameters.AddWithValue("@id", c.id);
                cmd.Parameters.AddWithValue("@Category", c.Category);
                cmd.Parameters.AddWithValue("@Category_code", c.Category_code);
                cmd.Parameters.AddWithValue("@Product_Name", c.Product_Name);
                cmd.Parameters.AddWithValue("@Product_code", c.Product_code);
                cmd.Parameters.AddWithValue("@qty", c.qty);
                cmd.Parameters.AddWithValue("@dealer_name", c.dealer_name);
                cmd.Parameters.AddWithValue("@rate", c.rate);
                cmd.Parameters.AddWithValue("@total", c.total);
                cmd.Parameters.AddWithValue("@Status", c.Status);
                cmd.Parameters.AddWithValue("@Modify_date", c.Modify_date);
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
        //#region Delete Method
        //public bool Delete(TransactionalDetailsBll c)
        //{
        //    bool isSuccess = false;
        //    try
        //    {
        //        db.OpenCon();
        //        string sql = "DELETE FROM tbl_transactionaldetails WHERE id=@id";
        //        SqlCommand cmd = new SqlCommand(sql, db.conn);
        //        cmd.Parameters.AddWithValue("@id", c.id);
        //        int rows = cmd.ExecuteNonQuery();
        //        if (rows > 0)
        //        {
        //            isSuccess = true;
        //        }
        //        else
        //        {
        //            isSuccess = false;
        //        }
        //    }
        //    catch (SqlException ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    finally
        //    {
        //        db.CloseCon();
        //    }
        //    return isSuccess;
        //}

        //#endregion

        public DataTable Search(string keywords)
        {
            DataTable dt = new DataTable();
            try
            {
                db.OpenCon(); ;
                String sql = "SELECT * FROM tbl_Buying WHERE id LIKE '%" + keywords + "%' OR Category_code LIKE '%" + keywords + "%' OR product_code LIKE '%" + keywords + "%'";
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
        public DataTable SelectData()
        {
            DataTable dt = new DataTable();
            try
            {
                db.OpenCon();
                string sql = " Select " +
                    "tbl_Category.title AS 'Name of the Category', " +
                    "tbl_Buying.Product_Name AS 'Name of the Products', " +
                    "tbl_Buying.qty AS 'Order Qty', " +
                    "tbl_Buying.dealer_name AS 'Supplier', " +
                    "tbl_Buying.rate AS 'One unit per Rs.', " +
                    "tbl_Buying.total AS 'Total Cost'," +
                    "tbl_UserD.username AS 'Person Who Add' " +
                    "From [LookHoodDB].[dbo].[tbl_Buying] " +
                    "left join [LookHoodDB].[dbo].[tbl_Category] on tbl_Buying.Category = tbl_Category.id " +
                    "LEFT JOIN [LookHoodDB].[dbo].[tbl_UserD] ON  tbl_Buying.added_by = tbl_UserD.id";
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

        public DataTable SelectjoinTables()
        {
            DataTable dt = new DataTable();
            try
            {
                db.OpenCon();
                string sql = "  Select tbl_Buying.Product_Name AS 'Name of the Products',  tbl_dealer.name AS 'Name Of the dealer',tbl_dealer.contact AS 'Contact Number', tbl_rate.rate AS 'Price for one unit' ,tbl_UserD.username AS 'Person Who Add' FROM [LookHoodDB].[dbo].[tbl_dealer] LEFT JOIN [LookHoodDB].[dbo].[tbl_Buying] on tbl_dealer.name = tbl_Buying.dealer_name left join [LookHoodDB].[dbo].[tbl_rate] on tbl_dealer.id = tbl_rate.dealer_id LEFT JOIN [LookHoodDB].[dbo].[tbl_UserD] ON  tbl_dealer.added_by = tbl_UserD.id";
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
