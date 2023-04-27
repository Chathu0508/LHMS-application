using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LHMS_Application.BLL
{
    internal class TaskprograssBll
    {
        public int id { get; set; }
        public string Taskcode { get; set; }
        public string Task_name { get; set; }
        public string ken_code { get; set; }
        public string Stage { get; set; }
        public DateTime Added_date { get; set; }
        public int Added_id { get; set; }
    }
}
