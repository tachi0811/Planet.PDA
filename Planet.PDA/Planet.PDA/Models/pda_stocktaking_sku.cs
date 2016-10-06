using System;

namespace Planet.PDA
{
    public class pda_stocktaking_sku
    {
        public string store_cd { get; set; }
        public int terminal_id { get; set; }
        public DateTime tana_item_timstamp { get; set; }
        public string staff_cd { get; set; }
        public Nullable<short> send_flg { get; set; }
        public Nullable<short> csv_output_flg { get; set; }
        public Nullable<DateTime> create_dte { get; set; }
        public Nullable<DateTime> update_dte { get; set; }
    }
}
