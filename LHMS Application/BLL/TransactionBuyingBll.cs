using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LHMS_Application.BLL
{
    internal class TransactionBuyingBll
    {
        public int id { get; set; }
        public int Category { get; set; }
        public string Category_code { get; set; }
        public string Product_Name { get; set; }
        public string Product_code { get; set; }
        public int qty { get; set; }
        public string dealer_name { get; set; }
        public decimal rate { get; set; }
        public decimal total { get; set; }
        public string Status { get; set; }
        public DateTime added_date { get; set; }
        public int added_by { get; set; }
        public DateTime Modify_date { get; set; }
    }
}
