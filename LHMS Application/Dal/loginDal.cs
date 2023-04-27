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
using LHMS_Application.UI;
using LHMS_Application.Models;
using DocumentFormat.OpenXml.Office.Word;

namespace LHMS_Application.Dal
{
    public class loginDal
    {
        //private readonly LogTrackDal logTrackDal;
        DbConnection db = DbConnection.getInstance();
        public bool loginCheck(LoginBll l)
        {
            bool isSuccess = false;
            try
            {
                db.OpenCon();
                string sql = "SELECT * FROM tbl_UserD WHERE username=@username AND password=@password AND user_type=@user_type";
                SqlCommand cmd = new SqlCommand(sql, db.conn);
                cmd.Parameters.AddWithValue("@username", l.username);
                cmd.Parameters.AddWithValue("@password", l.password);
                cmd.Parameters.AddWithValue("@user_type", l.user_type);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    int UserD_id = 0;
                  
                    LogTrackBll logTrackBillModel = new LogTrackBll();
                    foreach (DataRow row in dt.Rows)
                    {
                        UserD_id = Convert.ToInt32(row["id"]);
                    }

                    logTrackBillModel.id = 1;
                    logTrackBillModel.username = l.username;
                    logTrackBillModel.UserD_id = UserD_id;
                    logTrackBillModel.InOut = "LogIn";

                    LogTrackDal dal = new LogTrackDal();
                    dal.UsrAuthor(logTrackBillModel);

                    //string sql = "select top 1 id from tbl_logtrack where UserD_id = 2 order by logtime desc;";
                    //int  lastLogId = 13;
                    //Login.loginId = lastLogId;


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

        public UserModal GetUserIdByUserName(string username, string user_type)
        {
            UserModal userModal = new UserModal();

            try
            {
                db.OpenCon();

                SqlCommand objSqlCommand = new SqlCommand("SELECT id,username FROM tbl_UserD WHERE username = @username AND user_type =@user_type", db.conn);
                objSqlCommand.Parameters.AddWithValue("@username", username);
                objSqlCommand.Parameters.AddWithValue("@user_type", user_type);
                SqlDataAdapter adapter = new SqlDataAdapter(objSqlCommand);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {

                    foreach (DataRow row in dt.Rows)
                    {
                        userModal.id = Convert.ToInt32(row["id"]);
                        userModal.username = Convert.ToString(row["username"]);
                    }
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
            return userModal;
        }

        public UserModal GetUserByUserId(int userId)
        {
            UserModal userModal = new UserModal();

            try
            {
                db.OpenCon();

                SqlCommand objSqlCommand = new SqlCommand("SELECT id,username FROM tbl_UserD WHERE id = @id", db.conn);
                objSqlCommand.Parameters.AddWithValue("@id", userId);
                SqlDataAdapter adapter = new SqlDataAdapter(objSqlCommand);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {

                    foreach (DataRow row in dt.Rows)
                    {
                        userModal.id = Convert.ToInt32(row["id"]);
                        userModal.username = Convert.ToString(row["username"]);
                    }
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
            return userModal;
        }

    }
}
