using System;

namespace Planet.PDA.Portable
{
    public class stocktaking_account_detail
    {
        public string store_cd { get; set; }
        public int terminal_id { get; set; }
        public DateTime tana_account_dtetim { get; set; }
        public short seq_no { get; set; }
        public string small_class_cd { get; set; }
        public Nullable<decimal> sales_price { get; set; }
        public Nullable<int> tana_qty { get; set; }
        public string goods_cd { get; set; }
    }
}
