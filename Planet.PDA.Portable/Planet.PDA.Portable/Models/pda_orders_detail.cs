using System;

namespace Planet.PDA.Portable
{
    public class pda_orders_detail
    {
        public string store_cd { get; set; }
        public int terminal_id { get; set; }
        public DateTime orders_dtetim { get; set; }
        public short seq_no { get; set; }
        public string goods_cd { get; set; }
        public Nullable<int> order_qty { get; set; }
        public string supplier_cd { get; set; }
        public Nullable<DateTime> create_dte { get; set; }
        public Nullable<DateTime> update_dte { get; set; }
    }
}
