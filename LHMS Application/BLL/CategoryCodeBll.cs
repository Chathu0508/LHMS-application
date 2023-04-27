using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LHMS_Application.BLL
{
    internal class CategoryCodeBll
    {
        public int id { get; set; }
        public string CategoryCode { get; set; }
        public string CateogryName { get; set; }
        public DateTime added_date { get; set; }
        public int added_by { get; set; }
    }
}
