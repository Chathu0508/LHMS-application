using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LHMS_Application.Database;
using LHMS_Application.BLL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LHMS_Application.Dal
{
    public class LogTrackDal
    {        // createing the connection to the datebase.
        DbConnection db = DbConnection.getInstance();

        #region Select method for the Table
        public DataTable Select()
        {
            DataTable dt = new DataTable();
            try
            {
                db.OpenCon();
                String sql = "SELECT * FROM tbl_logtrack";
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
        #region Get the recoard s for the login and log out 
        public int UsrAuthor(LogTrackBll lt)
        {
             
            db.OpenCon();
            try
            {
                string sql = "INSERT INTO tbl_logtrack ( username, logtime, InOut, UserD_id )VALUES (@username, @logtime, @InOut, @UserD_id)";
                SqlCommand cmd = new SqlCommand(sql, db.conn);
                //cmd.Parameters.AddWithValue("@id", 0);
                cmd.Parameters.AddWithValue("@username", lt.username);
                cmd.Parameters.AddWithValue("@logtime", DateTime.Now);
                cmd.Parameters.AddWithValue("@InOut", lt.InOut);
                cmd.Parameters.AddWithValue("@UserD_id", lt.UserD_id);
                
                return cmd.ExecuteNonQuery();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.CloseCon();
            }
            return 0;
        }


        #endregion
    }
}
