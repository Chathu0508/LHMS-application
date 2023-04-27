using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LHMS_Application.BLL
{
    internal class TaskBLL
    {
        public int Id { get; set; }
        public string taskcode { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string factory { get; set; }
        public string departments { get; set; }
        public string Date { get; set; }
        public DateTime added_date { get; set; }
        public int added_by { get; set; }
    }
}
