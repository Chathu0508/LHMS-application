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
    internal class KencardDal
    {
        DbConnection db = DbConnection.getInstance();

        #region Search data from using keywords
        public DataTable Search(string keywords)
        {
            DataTable dt = new DataTable();
            try
            {
                db.OpenCon(); ;
                String sql = "SELECT * FROM tbl_Inventory WHERE product_id LIKE '%" + keywords + "%'";
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
        #region Select method
        public DataTable Select()
        {
            DataTable dt = new DataTable();
            try
            {
                db.OpenCon();
                string sql = "SELECT * FROM tbl_KenCD";
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


        public int InsertData(Kencardmodel kb)
        {

            db.OpenCon();
            try
            {

                string sql =
                    "INSERT INTO tbl_KenCD " +
                    "(Taskcode,Task_name, ken_code, Raw_metrial_Id,Raw_metrial_name, Raw_Metrials_Qty,status,added_date,added_by )" +
                    "VALUES " +
                    "(@Taskcode,@Task_name, @ken_code,@Raw_metrial_Id,@Raw_metrial_name, @Raw_Metrials_Qty,@status, @added_date, @added_by)";
                SqlCommand cmd = new SqlCommand(sql, db.conn);
                //cmd.Parameters.AddWithValue("@date", kb.date);
                cmd.Parameters.AddWithValue("@Taskcode", kb.Taskcode);
                cmd.Parameters.AddWithValue("@Task_name", kb.Task_name);
                cmd.Parameters.AddWithValue("@ken_code", kb.ken_code);
                cmd.Parameters.AddWithValue("@Raw_metrial_Id", kb.Raw_metrial_Id);
                cmd.Parameters.AddWithValue("@Raw_metrial_name", kb.Raw_metrial_name);
                cmd.Parameters.AddWithValue("@Raw_Metrials_Qty", kb.Raw_Metrials_Qty);
                cmd.Parameters.AddWithValue("@status", kb.status);
                cmd.Parameters.AddWithValue("@added_date", kb.added_date);
                cmd.Parameters.AddWithValue("@added_by", kb.added_by);

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
        #region Update
        public bool updatedata(KencardBll kb)
        {
            bool isSuccess = false; 
            try
            {
                db.OpenCon();

                string sql =
                    "UPDATE  tbl_KenCD SET Taskcode=@Taskcode,Task_name=Task_name, ken_code=@ken_code, Raw_metrial_Id=@Raw_metrial_Id,Raw_metrial_name=@Raw_metrial_name, Raw_Metrials_Qty=@Raw_Metrials_Qty,status=@status, Modify_date=@Modify_date WHERE id=@id";
                SqlCommand cmd = new SqlCommand(sql, db.conn);
                cmd.Parameters.AddWithValue("@id", kb.id);
                cmd.Parameters.AddWithValue("@Taskcode", kb.Taskcode);
                cmd.Parameters.AddWithValue("@Task_name", kb.Task_name);
                cmd.Parameters.AddWithValue("@ken_code", kb.ken_code);
                cmd.Parameters.AddWithValue("@Raw_metrial_Id", kb.Raw_metrial_Id);
                cmd.Parameters.AddWithValue("@Raw_metrial_name", kb.Raw_metrial_name);
                cmd.Parameters.AddWithValue("@Raw_Metrials_Qty", kb.Raw_Metrials_Qty);
                cmd.Parameters.AddWithValue("@status", kb.status);
                cmd.Parameters.AddWithValue("@Modify_date", kb.Modify_date);
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
        public DataTable searchDate(string keywords)
        {
            DataTable dt = new DataTable();
            try
            {
                db.OpenCon(); ;
                String sql = "SELECT * FROM tbl_KenCD WHERE id LIKE '%" + keywords + "%' OR Taskcode LIKE '%" + keywords + "%' OR ken_code LIKE '%" + keywords + "%'";
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
        public DataTable SerachReportdata(string keywords)
        {
            DataTable dt = new DataTable();
            try
            {
                db.OpenCon(); ;
                String sql = "SELECT Taskcode 'Task code', Task_name 'Task Name', ken_code'Kencard Code', Raw_metrial_name 'Metrial Name', Raw_Metrials_Qty 'Require Qty', status 'Status', added_date 'Create Date', Modify_date 'Update Date' FROM tbl_kenCD";
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
