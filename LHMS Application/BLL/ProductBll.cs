using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LHMS_Application.BLL
{
    internal class ProductBll
    {
        public int id { get; set; }
        public string Category { get; set; }
        public string Category_code { get; set; }
        public string Product_Name { get; set; }
        public string Product_code { get; set; }
        public decimal Qty { get; set; }
        public string Qty_type { get; set; }
        public DateTime added_date { get; set; }
        public int added_by { get; set; }
    }
}
