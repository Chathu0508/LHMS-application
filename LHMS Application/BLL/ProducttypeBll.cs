﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LHMS_Application.BLL
{
    internal class ProducttypeBll
    {
        public int id { get; set; }
        public int category_id { get; set; }
        public string product_type { get; set; }
        public DateTime added_date { get; set; }
        public int added_by { get; set; }
    }
}
