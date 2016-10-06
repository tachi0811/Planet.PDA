using System;

namespace Planet.PDA
{
    public class pda_orders
    {
        public string store_cd { get; set; }
        public int terminal_id { get; set; }
        public DateTime orders_dtetim { get; set; }
        public string staff_cd { get; set; }
        public Nullable<short> send_flg { get; set; }
        public Nullable<short> server_update_flg { get; set; }
        public Nullable<DateTime> create_dte { get; set; }
        public Nullable<DateTime> update_dte { get; set; }
    }
}
