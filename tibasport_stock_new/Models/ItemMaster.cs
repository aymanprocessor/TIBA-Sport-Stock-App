using System;
using System.Collections.Generic;

namespace tibasport_stock_new.Models
{
    public partial class ItemMaster
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string MajorGp { get; set; }
        public string Mark { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public string ItemDesc { get; set; }
        public string Store { get; set; }
        public string Unit { get; set; }
        public string Reorder { get; set; }
        public string Avg { get; set; }
        public string Location { get; set; }
    }
}
