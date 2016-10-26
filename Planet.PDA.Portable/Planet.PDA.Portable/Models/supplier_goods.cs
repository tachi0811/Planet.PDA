using System;

namespace Planet.PDA.Portable
{
    public class supplier_goods
    {
        public string supplier_cd { get; set; }
        public string goods_cd { get; set; }
        public Nullable<decimal> cost_price { get; set; }
        public Nullable<short> lot { get; set; }
        public Nullable<int> lead_time { get; set; }
        public Nullable<short> advise_order_flg { get; set; }
        public Nullable<short> delete_flg { get; set; }
        public Nullable<DateTime> create_dte { get; set; }
        public Nullable<DateTime> update_dte { get; set; }
    }
}
