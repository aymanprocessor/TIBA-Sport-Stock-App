using System;
using System.Collections.Generic;

namespace tibasport_stock_new.Models
{
    public partial class TransHeader
    {
        public int TransNo { get; set; }
        public byte[] Date { get; set; }
        public int CustomerId { get; set; }
        public string Type { get; set; }
        public string OrderNo { get; set; }
        public string Total { get; set; }
    }
}
