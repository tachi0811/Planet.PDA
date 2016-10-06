using System;

namespace Planet.PDA
{
    public class pda_stocktaking_sku_detail
    {
        public string store_cd { get; set; }
        public int terminal_id { get; set; }
        public DateTime tana_item_timstamp { get; set; }
        public short seq_no { get; set; }
        public string goods_cd { get; set; }
        public Nullable<int> real_qty { get; set; }
        public Nullable<DateTime> create_dte { get; set; }
        public Nullable<DateTime> update_dte { get; set; }
    }
}
