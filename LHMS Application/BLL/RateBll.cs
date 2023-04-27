using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LHMS_Application.BLL
{
    internal class RateBll
    {
        public int id { get; set; }
        public int dealer_id { get; set; }
        public decimal rate { get; set; }
        public DateTime added_date  { get; set; }
        public int added_by { get; set; }
    }
}
