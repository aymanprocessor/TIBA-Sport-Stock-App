using System;
using System.Collections.Generic;

namespace tibasport_stock_new.Models
{
    public partial class TransDetail
    {
        public int TransNo { get; set; }
        public byte[] TransDate { get; set; }
        public string TransType { get; set; }
        public string Code { get; set; }
        public string Quantity { get; set; }
        public string TotalPerItem { get; set; }
        public string Price { get; set; }
        public string Store { get; set; }
    }
}
