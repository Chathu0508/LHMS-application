using LHMS_Application.Database;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LHMS_Application.Models
{
    internal class codegenareate
    {
        DbConnection db = DbConnection.getInstance();


        public string CreateAutoID()
        {

            db.OpenCon();
            var randomCode = "";
            SqlCommand objSqlCommand = new SqlCommand("select count(*) from tbl_task", db.conn);
            int randomId = Convert.ToInt32(objSqlCommand.ExecuteScalar());

            db.conn.Close();
            if (randomId > 0)
            {
                randomId = randomId + 1;
                randomCode = "PROCD0000" + (int)randomId;
            }
            else
            {
                randomCode = "PROCD00001";
            }
            return randomCode.ToString();
        }


    }
}
