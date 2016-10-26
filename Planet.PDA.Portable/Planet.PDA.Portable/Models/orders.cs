using System;

namespace Planet.PDA.Portable
{
    public class orders
    {
        public string store_cd { get; set; }
        public int terminal_id { get; set; }
        public DateTime orders_dtetim { get; set; }
        public string slip_no { get; set; }
        public string staff_cd { get; set; }
        public string supplier_cd { get; set; }
        public Nullable<short> server_update_flg { get; set; }
        public Nullable<DateTime> create_dte { get; set; }
        public Nullable<DateTime> update_dte { get; set; }
    }
}
