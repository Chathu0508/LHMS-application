using LHMS_Application.Database;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LHMS_Application.BLL
{
    public class LogTrackBll
    {
        public int id { get; set; }
        public string username { get; set; }
        public DateTime logtime { get; set; }
        public string InOut { get; set; }
        public int UserD_id { get; set; }
    }

}
