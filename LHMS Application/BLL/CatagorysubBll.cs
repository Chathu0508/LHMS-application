using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LHMS_Application.BLL
{
    internal class CatagorysubBll
    {
        public int id { get; set; }
        public int category_Id { get; set; }
        public string Product_name { get; set; }
        public DateTime added_date { get; set; }
        public int added_by { get; set; }
    }
}
