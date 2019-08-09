using System;
using System.Collections.Generic;

namespace tibasport_stock_new.Models
{
    public partial class Balance
    {
        public int Year { get; set; }
        public string Code { get; set; }
        public string ItemDesc { get; set; }
        public string Store { get; set; }
        public string Count { get; set; }
        public string Avg { get; set; }
    }
}
