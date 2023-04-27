using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LHMS_Application.BLL
{
    internal class InventoryBll
    {
        public int id { get; set; }
        public int product_Id { get; set; }
        public string Product_name { get; set; }
        public int qty { get; set; }
        public DateTime added_date { get; set; }
        public DateTime modify_date { get; set; }
    }
}
