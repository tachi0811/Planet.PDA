using System;

namespace Planet.PDA.Portable
{
    public class inventory
    {
        public string store_cd { get; set; }
        public string goods_cd { get; set; }
        public Nullable<int> inventory_qty { get; set; }
        public Nullable<int> inventory_Mortgage_qty { get; set; }
        public Nullable<short> orders_constant { get; set; }
        public Nullable<DateTime> create_dte { get; set; }
        public Nullable<DateTime> update_dte { get; set; }
    }
}
