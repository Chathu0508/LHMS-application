using LHMS_Application.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LHMS_Application.Database;
using DocumentFormat.OpenXml.Office.Word;
using LHMS_Application.Models;

namespace LHMS_Application.Dal
{
    internal class TaskDal
    {
        DbConnection db = DbConnection.getInstance();
        #region Select method for task
        public DataTable Select()
        {
            DataTable dt = new DataTable();
            try
            {
                db.OpenCon();
                string sql = "SELECT * FROM tbl_task";
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
        #region Insert method for tasks
        public bool Insert(TaskBLL tc)
        {
            bool isSuccess = false;
            try
            {
                db.OpenCon();
                string sql =
                    "INSERT INTO tbl_task " +
                    "(taskcode, title, description, factory, departments, Date, added_date, added_by) " +
                    "VALUES" +
                    "(@taskcode, @title, @description, @factory, @departments, @Date, @added_date, @added_by)";
                SqlCommand cmd = new SqlCommand(sql, db.conn);
                cmd.Parameters.AddWithValue("@taskcode", tc.taskcode);
                cmd.Parameters.AddWithValue("@title", tc.title);
                cmd.Parameters.AddWithValue("@description", tc.description);
                cmd.Parameters.AddWithValue("@factory", tc.factory);
                cmd.Parameters.AddWithValue("@departments", tc.departments);
                cmd.Parameters.AddWithValue("@Date", tc.Date);
                cmd.Parameters.AddWithValue("@added_date", tc.added_date);
                cmd.Parameters.AddWithValue("@added_by", tc.added_by);
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
        #region update method for task
        public bool Update(TaskBLL tc)
        {
            bool isSuccess = false;
            try
            {
                db.OpenCon();
                string sql =
                    "UPDATE tbl_task SET " +
                    "taskcode=@taskcode, title=@title, description=@description, factory=@factory, departments=@departments, added_date=@added_date, added_by=@added_by " +
                    "WHERE Id=@Id";
                SqlCommand cmd = new SqlCommand(sql, db.conn);
                cmd.Parameters.AddWithValue("@Id", tc.Id);
                cmd.Parameters.AddWithValue("@taskcode", tc.taskcode);
                cmd.Parameters.AddWithValue("@title", tc.title);
                cmd.Parameters.AddWithValue("@description", tc.description);
                cmd.Parameters.AddWithValue("@factory", tc.factory);
                cmd.Parameters.AddWithValue("@departments", tc.departments);
                cmd.Parameters.AddWithValue("@added_date", tc.added_date);
                cmd.Parameters.AddWithValue("@added_by", tc.added_by);
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
        #region Delete method for task
        public bool Delete(TaskBLL t)
        {
            bool isSuccess = false;
            try
            {
                db.OpenCon();
                string sql = "DELETE FROM tbl_task WHERE id=@id";
                SqlCommand cmd = new SqlCommand(sql, db.conn);
                cmd.Parameters.AddWithValue("@id", t.Id);
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
        #region Search method for data
        public DataTable Search(string keywords)
        {
            DataTable dt = new DataTable();
            try
            {
                db.OpenCon();
                String sql = "SELECT * FROM tbl_task WHERE id LIKE '%" + keywords + "%' OR taskcode LIKE '%" + keywords + "%' ";
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
        #region Get the extact date for the kencard
        public DataTable GethThedate(string keywords)
        {
            DataTable dt = new DataTable();
            try
            {
                db.OpenCon(); ;
                String sql = "SELECT * FROM FROM tbl_task WHERE Date LIKE '%" + keywords + "%'";
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
       
        public string GetTaskcode(string name)
        {
            string id = "";
            try
            {
                db.OpenCon();
                SqlCommand objSqlCommand = new SqlCommand("SELECT title FROM tbl_task WHERE tbl_task.taskcode = @taskcode", db.conn);
                objSqlCommand.Parameters.AddWithValue("@taskcode", name);
                id = Convert.ToString(objSqlCommand.ExecuteScalar());
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

        public DataTable GetCurrentDayData(string dateTime)
        {

            DataTable dt = new DataTable();
           
            try
            {
                db.OpenCon();
                string sql = "SELECT * FROM tbl_task WHERE Date = '" + dateTime + "'" ;
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

        #region
        public DataTable Seletereportdata()
        {
            DataTable dt = new DataTable();
            try
            {
                db.OpenCon();
                string sql = "SELECT " +
                    "tbl_KenCD.Taskcode AS 'Task Code'," +
                    "tbl_KenCD.Task_name AS 'Name of the task'," +
                    "tbl_KenCD.Raw_metrial_name AS 'Require Metrial'," +
                    "tbl_KenCD.Raw_Metrials_Qty AS 'Require Metrial Qty'," +
                    "tbl_KenCD.Status AS 'Status of the Task'," +
                    "tbl_KenCD.added_date AS 'Create Date'," +
                    "tbl_KenCD.Modify_date AS 'Update Date'," +
                    "tbl_UserD.username AS 'Person who add'" +
                    "From " +
                    "[LookHoodDB].[dbo].[tbl_KenCD]" +
                    "LEFT JOIN [LookHoodDB].[dbo].[tbl_UserD] ON  tbl_KenCD.added_by = tbl_UserD.id";
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
