using System;

namespace Planet.PDA.Portable
{
    public class store_goods
    {
        public string store_cd { get; set; }
        public string goods_cd { get; set; }
        public Nullable<decimal> sales_price { get; set; }
        public Nullable<decimal> sales_price2 { get; set; }
        public Nullable<decimal> sales_price3 { get; set; }
        public Nullable<decimal> sales_price4 { get; set; }
        public Nullable<decimal> sales_price5 { get; set; }
        public Nullable<int> inventory_reach_point { get; set; }
        public Nullable<short> delete_flg { get; set; }
        public Nullable<DateTime> create_dte { get; set; }
        public Nullable<DateTime> update_dte { get; set; }
    }
}
