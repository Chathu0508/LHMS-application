using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LHMS_Application.Models
{
    internal class Kencardmodel
    {
        public int id { get; set; }
        public string date { get; set; }
        public string Taskcode { get; set; }
        public string Task_name { get; set; }
        public string ken_code { get; set; }
        public int Raw_metrial_Id { get; set; }
        public string Raw_metrial_name { get; set; }
        public int Raw_Metrials_Qty { get; set; }
        public string status { get; set; }
        public DateTime added_date { get; set; }
        public int added_by { get; set; }
        public DateTime Modify_date { get; set; }

    }
}
