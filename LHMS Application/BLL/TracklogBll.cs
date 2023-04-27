using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LHMS_Application.BLL
{
    internal class TracklogBll
    {
        public int Id { get; set; }
        public int taskId { get; set; }
        public int numberofstages { get; set; }
        public string completesatges { get; set; }
        public int pendingsatges { get; set; }
        public DateTime added_date { get; set; }
        public int add_by { get; set; }
    }
}
