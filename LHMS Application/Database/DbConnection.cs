using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LHMS_Application.Database
{
    internal class DbConnection
    {

        //public SqlConnection conn = new SqlConnection();

        //private static DbConnection conInstance = new DbConnection();


        //private DbConnection() { }

        //public static DbConnection getInstance()
        //{
        //    if (conInstance == null)
        //    {
        //        conInstance = new DbConnection();
        //    }
        //    return conInstance;
        //}

        //public void OpenCon()
        //{

        //    conn.ConnectionString = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString.ToString();
        //    db.OpenCon();
        //}

        //public void CloseCon()
        //{
        //    conn.Close();
        //}


        private SqlConnection con;
        public SqlConnection conn 
        { get 
            { 
                return con; 
            } 
        }

        //private static DbConnection conInstance = new DbConnection();
        private static DbConnection conInstance;

        private DbConnection() { }

        public static DbConnection getInstance()
        {
            if (conInstance == null)
            {
                conInstance = new DbConnection();
            }
            return conInstance;
        }

        public void OpenCon()
        {
            string connstr = ConfigurationManager.ConnectionStrings["connstring"].ToString();
            con = new SqlConnection(connstr);
            con.Open();
        }

        public void CloseCon()
        {
            con.Close();
        }
    }
}
